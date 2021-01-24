using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RxcSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RxcSegment
            {
                RxComponentType = "1",
                ComponentCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ComponentAmount = 3,
                ComponentUnits = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                ComponentStrength = 5,
                ComponentStrengthUnits = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                SupplementaryCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                ComponentDrugStrengthVolume = 8,
                ComponentDrugStrengthVolumeUnits = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                DispenseAmount = 10,
                DispenseUnits = new CodedWithExceptions
                {
                    Identifier = "11"
                }
            };

            string expected = "RXC|1|2|3|4|5|6|7|8|9|10|11";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
