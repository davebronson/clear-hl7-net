using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class LccSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new LccSegment
            {
                PrimaryKeyValueLcc = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "1"
                    }
                },
                LocationDepartment = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AccommodationType = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                },
                ChargeCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                }
            };

            string expected = "LCC|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
