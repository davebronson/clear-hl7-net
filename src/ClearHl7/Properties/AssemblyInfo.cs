using System.Runtime.CompilerServices;

// Grant the benchmark project access to internal members (e.g., DisableCaches flags used
// to measure uncached/before-optimisation performance without reverting any source changes).
[assembly: InternalsVisibleTo("ClearHl7.Benchmarks")]
