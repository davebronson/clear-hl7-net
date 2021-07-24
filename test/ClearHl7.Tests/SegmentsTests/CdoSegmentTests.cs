using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class CdoSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new CdoSegment
            {
                SetIdCdo = 1,
                ActionCode = "2",
                CumulativeDosageLimit = new CompositeQuantityWithUnits
                {
                    Quantity = 3
                },
                CumulativeDosageLimitTimeInterval = new CompositeQuantityWithUnits
                {
                    Quantity = 4
                }
            };

            ISegment actual = new CdoSegment();
            actual.FromDelimitedString("CDO|1|2|3|4");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new CdoSegment
            {
                SetIdCdo = 1,
                ActionCode = "2",
                CumulativeDosageLimit = new CompositeQuantityWithUnits
                {
                    Quantity = 3
                },
                CumulativeDosageLimitTimeInterval = new CompositeQuantityWithUnits
                {
                    Quantity = 4
                }
            };

            string expected = "CDO|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
