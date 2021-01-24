using System;
using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class MfeSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new MfeSegment
            {
                RecordLevelEventCode = "1",
                MfnControlId = "2",
                EffectiveDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                PrimaryKeyValueMfe = new string[]
                {
                    "4"
                },
                PrimaryKeyValueType = new string[]
                {
                    "5"
                },
                EnteredDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                EnteredBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "7"
                }
            };

            string expected = "MFE|1|2|20200303000003|4|5|20200606000006|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
