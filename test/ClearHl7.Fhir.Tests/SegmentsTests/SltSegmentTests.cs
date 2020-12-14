using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class SltSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new SltSegment
            {
                DeviceNumber = new EntityIdentifier
                {
                    EntityId = "1"
                },
                DeviceName = "2",
                LotNumber = new EntityIdentifier
                {
                    EntityId = "3"
                },
                ItemIdentifier = new EntityIdentifier
                {
                    EntityId = "4"
                },
                BarCode = "5"
            };

            string expected = "SLT|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
