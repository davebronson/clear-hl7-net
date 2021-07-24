using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class BlcSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new BlcSegment
            {
                BloodProductCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                BloodAmount = new CompositeQuantityWithUnits
                {
                    Quantity = 2
                }
            };

            ISegment actual = new BlcSegment();
            actual.FromDelimitedString("BLC|1|2");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new BlcSegment
            {
                BloodProductCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                BloodAmount = new CompositeQuantityWithUnits
                {
                    Quantity = 2
                }
            };

            string expected = "BLC|1|2";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
