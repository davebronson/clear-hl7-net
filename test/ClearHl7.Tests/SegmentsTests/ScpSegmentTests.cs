using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class ScpSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ScpSegment
            {
                NumberOfDecontaminationSterilizationDevices = 1,
                LaborCalculationType = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                DateFormat = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                DeviceNumber = new EntityIdentifier
                {
                    EntityId = "4"
                },
                DeviceName = "5",
                DeviceModelName = "6",
                DeviceType = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                LotControl = new CodedWithExceptions
                {
                    Identifier = "8"
                }
            };

            string expected = "SCP|1|2|3|4|5|6|7|8";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
