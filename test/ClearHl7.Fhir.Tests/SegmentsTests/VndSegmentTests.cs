using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class VndSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new VndSegment
            {
                SetIdVnd = 1,
                VendorIdentifier = new EntityIdentifier
                {
                    EntityId = "2"
                },
                VendorName = "3",
                VendorCatalogNumber = new EntityIdentifier
                {
                    EntityId = "4"
                },
                PrimaryVendorIndicator = new CodedWithNoExceptions
                {
                    Identifier = "5"
                }
            };

            string expected = "VND|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
