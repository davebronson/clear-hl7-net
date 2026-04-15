# ClearHl7 Performance Benchmark Results

Benchmarks measuring the two hot-path optimizations introduced in this PR:

1. **`SegmentHelper.GetProperties()` caching** — eliminates repeated reflection during serialization
2. **`Assembly.CreateInstance()` factory caching** — eliminates repeated reflection + string allocations during deserialization

## Environment

```
BenchmarkDotNet v0.15.0, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.201
  [Host] : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX2
```

## How to run

```bash
dotnet run --project benchmarks/ClearHl7.Benchmarks -c Release
```

---

## How the "before" numbers were captured

Rather than reverting code, each source class exposes an `internal static bool DisableCaches` flag
(visible to this project via `InternalsVisibleTo`). The `*Uncached` benchmark classes set this flag
before their iterations so every call pays the full original reflection cost. This produces a
genuine apples-to-apples comparison in a single benchmark run without touching production defaults.

---

## Deserialization benchmarks (`Assembly.CreateInstance` factory caching)

| Method | Mean | Error | StdDev | Gen0 | Gen1 | Allocated |
|---|---:|---:|---:|---:|---:|---:|
| Deserialize 9-segment HL7 v2.9 message *(cached — after)* | 12.520 µs | 0.2328 µs | 0.2064 µs | 1.2360 | 0.3052 | 20.22 KB |
| Deserialize 9-segment HL7 v2.9 message *(uncached — before)* | 15.132 µs | 0.1923 µs | 0.1704 µs | 1.2817 | 0.3052 | 21.77 KB |
| Deserialize single-segment (MSH only) *(cached — after)* | 1.784 µs | 0.0291 µs | 0.0258 µs | 0.1831 | 0.1812 | 3.00 KB |
| Deserialize single-segment (MSH only) *(uncached — before)* | 2.138 µs | 0.0344 µs | 0.0322 µs | 0.1907 | 0.1869 | 3.17 KB |
| Auto-detect version + deserialize 9-segment *(cached — after)* | 13.184 µs | 0.1577 µs | 0.1398 µs | 1.2360 | 0.3052 | 20.29 KB |
| Auto-detect version + deserialize 9-segment *(uncached — before)* | 15.583 µs | 0.2103 µs | 0.1756 µs | 1.2817 | 0.3052 | 21.83 KB |

**Summary:** Each 9-segment deserialization is **~21% faster** (12.5 µs vs 15.1 µs), saving 2.6 µs and 1.5 KB of allocations per message.

---

## Serialization benchmarks (`GetProperties()` reflection caching)

| Method | Mean | Error | StdDev | Gen0 | Allocated |
|---|---:|---:|---:|---:|---:|
| Serialize deep message 9 segments *(cached — after)* | 114.252 µs | 0.7013 µs | 0.6217 µs | 3.0518 | 51.83 KB |
| Serialize deep message 9 segments *(uncached — before)* | 170.378 µs | 2.8307 µs | 3.5800 µs | 2.9297 | 63.53 KB |
| Serialize shallow message (MSH only) *(cached — after)* | 7.332 µs | 0.0344 µs | 0.0305 µs | 0.3128 | 5.18 KB |
| Serialize shallow message (MSH only) *(uncached — before)* | 7.621 µs | 0.0403 µs | 0.0336 µs | 0.3510 | 5.81 KB |

**Summary:** Deep (multi-segment) serialization is **~49% faster** (114 µs vs 170 µs), saving 56 µs and 11.7 KB of allocations per message. Shallow messages (MSH only) see a smaller gain (~4%) because there is little nested-type traversal to cache.

---

## Real-world impact — what this actually means in practice

The numbers above are per-message. Here is how they translate to real workloads:

### Serialization (deep/multi-segment messages, the common case)

| Daily message volume | CPU time saved per day | Memory pressure saved per day |
|---|---|---|
| 1,000 messages/day | ~0.06 seconds | ~11 MB |
| 10,000 messages/day | ~0.6 seconds | ~114 MB |
| 100,000 messages/day | ~5.6 seconds | ~1.1 GB |
| 1,000,000 messages/day | ~56 seconds (~1 minute) | ~11 GB |
| 10,000,000 messages/day | ~9 minutes | ~111 GB |

### Deserialization (9-segment messages)

| Daily message volume | CPU time saved per day |
|---|---|
| 100,000 messages/day | ~0.3 seconds |
| 1,000,000 messages/day | ~2.6 seconds |
| 10,000,000 messages/day | ~26 seconds |

### Throughput (single-threaded, steady state)

| Operation | Before (uncached) | After (cached) | Extra capacity |
|---|---|---|---|
| Serialize 9-segment messages | ~5,900 msg/sec | ~8,750 msg/sec | **+2,850 msg/sec per thread** |
| Deserialize 9-segment messages | ~66,000 msg/sec | ~79,900 msg/sec | **+13,800 msg/sec per thread** |

### Plain-English summary

- **Low-volume integrations (a few thousand messages a day):** the saving is real but small —
  fractions of a second per day. The main benefit here is the reduction in GC allocation pressure,
  which smooths out pause spikes rather than changing wall-clock time noticeably.
- **Mid-volume integrations (tens of thousands of messages a day):** serialization savings reach
  several seconds per day, and the reduced allocation load (over 100 MB/day less data for the GC
  to collect) starts to matter for latency consistency.
- **High-volume / streaming integrations (millions of messages a day):** this is where the gains
  compound. At 1 million messages/day, serialization alone runs a full minute faster and pushes
  ~11 GB less data through the GC. At 10 million messages/day the CPU time saving alone is
  ~9 minutes and each thread can handle ~49% more serialize operations per second.
- **Memory:** the 18% per-message allocation reduction for deep serialization is the most
  universally felt improvement — less data for the garbage collector means shorter GC pauses
  regardless of message rate.

---

## Notes

- All numbers are steady-state (warm cache). The very first call per type does still pay the
  reflection cost once; after that it is a dictionary lookup.
- The old "415–1,455×" ratios quoted previously came from BenchmarkDotNet's `Dry` (single cold)
  iteration, which is dominated by JIT compilation rather than cache effects and does not
  represent typical runtime behaviour. The figures above are the honest per-message numbers.

