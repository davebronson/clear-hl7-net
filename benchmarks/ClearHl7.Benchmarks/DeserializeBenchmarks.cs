using BenchmarkDotNet.Attributes;
using ClearHl7.Serialization;

namespace ClearHl7.Benchmarks
{
    /// <summary>
    /// Benchmarks the <see cref="MessageSerializer.Deserialize{T}"/> hot path which previously used
    /// <c>Assembly.CreateInstance()</c> with string-built type names on every segment.
    /// After the fix, segment factory delegates are cached in a <c>ConcurrentDictionary</c> so
    /// the reflection overhead is paid only once per segment type per process lifetime.
    /// </summary>
    [MemoryDiagnoser]
    [SimpleJob]
    public class DeserializeBenchmarks
    {
        // A realistic ADT^A01 multi-segment HL7 v2.9 message covering several segment types.
        private const string Hl7MultiSegmentMessage =
            "MSH|^~\\&|SendApp|SendFac|RcvApp|RcvFac|20201202144539||ADT^A01|MSG001|P|2.9\r" +
            "EVN||20201202144539\r" +
            "PID|1||12345^^^Hospital&UNI&ISO||Smith^John^A||19800115|M|||123 Main St^^Springfield^IL^62701^USA||555-555-1234|||M||987-65-4321\r" +
            "PV1|1|I|2WEST^201^1^HOSPITAL||||ATTEND^Doctor^Attending|||SUR||||ADM|A0\r" +
            "IN1|1|BCBS001|Blue Cross|PO Box 100^^Chicago^IL^60601|||||||20200101|20201231\r" +
            "AL1|1|DA|PENICILLIN|MO|Rash\r" +
            "DG1|1||I10^Essential hypertension^ICD-10|Essential hypertension||W\r" +
            "GT1|1||Jones^Mary^^Mrs.||100 Oak Ave^^Springfield^IL^62702||555-234-5678||19551010|F\r" +
            "NK1|1|Smith^Jane^B|SPO|456 Elm St^^Springfield^IL^62703|555-987-6543\r";

        // A minimal single-segment message used to isolate MSH parsing overhead.
        private const string Hl7SingleSegmentMessage =
            "MSH|^~\\&|SendApp|SendFac|RcvApp|RcvFac|20201202144539||ADT^A01|MSG001|P|2.9\r";

        [Benchmark(Description = "Deserialize 9-segment HL7 v2.9 message")]
        public V290.Message DeserializeMultiSegment()
        {
            return MessageSerializer.Deserialize<V290.Message>(Hl7MultiSegmentMessage);
        }

        [Benchmark(Description = "Deserialize single-segment (MSH only) HL7 v2.9 message")]
        public V290.Message DeserializeSingleSegment()
        {
            return MessageSerializer.Deserialize<V290.Message>(Hl7SingleSegmentMessage);
        }

        [Benchmark(Description = "Auto-detect version and deserialize 9-segment message")]
        public IMessage DeserializeAutoDetect()
        {
            return MessageSerializer.Deserialize(Hl7MultiSegmentMessage);
        }
    }

    /// <summary>
    /// Same deserialization benchmarks as <see cref="DeserializeBenchmarks"/> but with the
    /// segment factory cache disabled so each iteration pays the full uncached reflection cost.
    /// This gives a genuine "before optimisation" baseline for comparison.
    /// </summary>
    [MemoryDiagnoser]
    [SimpleJob]
    public class DeserializeBenchmarksUncached
    {
        private const string Hl7MultiSegmentMessage =
            "MSH|^~\\&|SendApp|SendFac|RcvApp|RcvFac|20201202144539||ADT^A01|MSG001|P|2.9\r" +
            "EVN||20201202144539\r" +
            "PID|1||12345^^^Hospital&UNI&ISO||Smith^John^A||19800115|M|||123 Main St^^Springfield^IL^62701^USA||555-555-1234|||M||987-65-4321\r" +
            "PV1|1|I|2WEST^201^1^HOSPITAL||||ATTEND^Doctor^Attending|||SUR||||ADM|A0\r" +
            "IN1|1|BCBS001|Blue Cross|PO Box 100^^Chicago^IL^60601|||||||20200101|20201231\r" +
            "AL1|1|DA|PENICILLIN|MO|Rash\r" +
            "DG1|1||I10^Essential hypertension^ICD-10|Essential hypertension||W\r" +
            "GT1|1||Jones^Mary^^Mrs.||100 Oak Ave^^Springfield^IL^62702||555-234-5678||19551010|F\r" +
            "NK1|1|Smith^Jane^B|SPO|456 Elm St^^Springfield^IL^62703|555-987-6543\r";

        private const string Hl7SingleSegmentMessage =
            "MSH|^~\\&|SendApp|SendFac|RcvApp|RcvFac|20201202144539||ADT^A01|MSG001|P|2.9\r";

        [GlobalSetup]
        public void Setup()
        {
            MessageSerializer.DisableCaches = true;
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            MessageSerializer.DisableCaches = false;
        }

        [Benchmark(Description = "Deserialize 9-segment HL7 v2.9 message — no cache")]
        public V290.Message DeserializeMultiSegment()
        {
            return MessageSerializer.Deserialize<V290.Message>(Hl7MultiSegmentMessage);
        }

        [Benchmark(Description = "Deserialize single-segment (MSH only) HL7 v2.9 message — no cache")]
        public V290.Message DeserializeSingleSegment()
        {
            return MessageSerializer.Deserialize<V290.Message>(Hl7SingleSegmentMessage);
        }

        [Benchmark(Description = "Auto-detect version and deserialize 9-segment message — no cache")]
        public IMessage DeserializeAutoDetect()
        {
            return MessageSerializer.Deserialize(Hl7MultiSegmentMessage);
        }
    }
}
