using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class TccSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new TccSegment
            {
                UniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                EquipmentTestApplicationIdentifier = new EntityIdentifier
                {
                    EntityId = "2"
                },
                SpecimenSource = "3",
                AutoDilutionFactorDefault = new StructuredNumeric
                {
                    Comparator = "4"
                },
                RerunDilutionFactorDefault = new StructuredNumeric
                {
                    Comparator = "5"
                },
                PreDilutionFactorDefault = new StructuredNumeric
                {
                    Comparator = "6"
                },
                EndogenousContentOfPreDilutionDiluent = new StructuredNumeric
                {
                    Comparator = "7"
                },
                InventoryLimitsWarningLevel = 8,
                AutomaticRerunAllowed = "9",
                AutomaticRepeatAllowed = "10",
                AutomaticReflexAllowed = "11",
                EquipmentDynamicRange = new StructuredNumeric
                {
                    Comparator = "12"
                },
                Units = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                ProcessingType = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                TestCriticality = new CodedWithExceptions
                {
                    Identifier = "15"
                }
            };

            string expected = "TCC|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
