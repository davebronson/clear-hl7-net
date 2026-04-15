using BenchmarkDotNet.Attributes;
using ClearHl7;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.Benchmarks
{
    /// <summary>
    /// Benchmarks the serialization hot path which traverses segment hierarchies via
    /// <c>SegmentHelper.SetSubcomponentFlags</c>. Previously, every traversal called
    /// <c>Type.GetProperties()</c> (uncached reflection) on each object in the hierarchy.
    /// After the fix, results are stored in a <c>ConcurrentDictionary</c> so reflection
    /// is paid only once per type per process lifetime.
    /// </summary>
    [MemoryDiagnoser]
    [SimpleJob]
    public class SerializeBenchmarks
    {
        // A realistic ADT^A01 multi-segment HL7 v2.9 message with nested components.
        // PID contains PatientName and PatientAddress with nested sub-components
        // (StreetAddress, FamilyName, AssigningAuthority) — these trigger deep
        // subcomponent-flag traversal during serialization.
        private const string Hl7MultiSegmentMessage =
            "MSH|^~\\&|SendApp|SendFac|RcvApp|RcvFac|20201202144539||ADT^A01|MSG001|P|2.9\r" +
            "EVN||20201202144539\r" +
            "PID|1||12345^^^Hospital&UNI&ISO||Smith^John^A||19800115|M|||123 Main St&Apt 4B^^Springfield^IL^62701^USA||555-555-1234|||M||987-65-4321\r" +
            "PV1|1|I|2WEST^201^1^HOSPITAL||||ATTEND^Doctor^Attending|||SUR||||ADM|A0\r" +
            "IN1|1|BCBS001|Blue Cross|PO Box 100^^Chicago^IL^60601|||||||20200101|20201231\r" +
            "AL1|1|DA|PENICILLIN|MO|Rash\r" +
            "DG1|1||I10^Essential hypertension^ICD-10|Essential hypertension||W\r" +
            "GT1|1||Jones^Mary^^Mrs.||100 Oak Ave^^Springfield^IL^62702||555-234-5678||19551010|F\r" +
            "NK1|1|Smith^Jane^B|SPO|456 Elm St^^Springfield^IL^62703|555-987-6543\r";

        private const string Hl7SingleSegmentMessage =
            "MSH|^~\\&|SendApp|SendFac|RcvApp|RcvFac|20201202144539||ADT^A01|MSG001|P|2.9\r";

        private V290.Message _deepMessage = null!;
        private V290.Message _shallowMessage = null!;

        [GlobalSetup]
        public void Setup()
        {
            // Deserialize once to build the object graph used for serialization benchmarks.
            _deepMessage = MessageSerializer.Deserialize<V290.Message>(Hl7MultiSegmentMessage);
            _shallowMessage = MessageSerializer.Deserialize<V290.Message>(Hl7SingleSegmentMessage);
        }

        [Benchmark(Description = "Serialize shallow message (MSH only)")]
        public string SerializeShallow()
        {
            return MessageSerializer.Serialize(_shallowMessage);
        }

        [Benchmark(Description = "Serialize deep message (9 segments with nested types)")]
        public string SerializeDeep()
        {
            return MessageSerializer.Serialize(_deepMessage);
        }
    }

    /// <summary>
    /// Same serialization benchmarks as <see cref="SerializeBenchmarks"/> but with the
    /// reflection caches disabled so each iteration pays the full uncached reflection cost.
    /// This gives a genuine "before optimisation" baseline for comparison.
    /// </summary>
    [MemoryDiagnoser]
    [SimpleJob]
    public class SerializeBenchmarksUncached
    {
        private const string Hl7MultiSegmentMessage =
            "MSH|^~\\&|SendApp|SendFac|RcvApp|RcvFac|20201202144539||ADT^A01|MSG001|P|2.9\r" +
            "EVN||20201202144539\r" +
            "PID|1||12345^^^Hospital&UNI&ISO||Smith^John^A||19800115|M|||123 Main St&Apt 4B^^Springfield^IL^62701^USA||555-555-1234|||M||987-65-4321\r" +
            "PV1|1|I|2WEST^201^1^HOSPITAL||||ATTEND^Doctor^Attending|||SUR||||ADM|A0\r" +
            "IN1|1|BCBS001|Blue Cross|PO Box 100^^Chicago^IL^60601|||||||20200101|20201231\r" +
            "AL1|1|DA|PENICILLIN|MO|Rash\r" +
            "DG1|1||I10^Essential hypertension^ICD-10|Essential hypertension||W\r" +
            "GT1|1||Jones^Mary^^Mrs.||100 Oak Ave^^Springfield^IL^62702||555-234-5678||19551010|F\r" +
            "NK1|1|Smith^Jane^B|SPO|456 Elm St^^Springfield^IL^62703|555-987-6543\r";

        private const string Hl7SingleSegmentMessage =
            "MSH|^~\\&|SendApp|SendFac|RcvApp|RcvFac|20201202144539||ADT^A01|MSG001|P|2.9\r";

        private V290.Message _deepMessage = null!;
        private V290.Message _shallowMessage = null!;

        [GlobalSetup]
        public void Setup()
        {
            SegmentHelper.DisableCaches = true;
            _deepMessage = MessageSerializer.Deserialize<V290.Message>(Hl7MultiSegmentMessage);
            _shallowMessage = MessageSerializer.Deserialize<V290.Message>(Hl7SingleSegmentMessage);
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            SegmentHelper.DisableCaches = false;
        }

        [Benchmark(Description = "Serialize shallow message (MSH only) — no cache")]
        public string SerializeShallow()
        {
            return MessageSerializer.Serialize(_shallowMessage);
        }

        [Benchmark(Description = "Serialize deep message (9 segments with nested types) — no cache")]
        public string SerializeDeep()
        {
            return MessageSerializer.Serialize(_deepMessage);
        }
    }
}
