using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class SidSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new SidSegment
            {
                ApplicationMethodIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                SubstanceLotNumber = "2",
                SubstanceContainerIdentifier = "3",
                SubstanceManufacturerIdentifier = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            ISegment actual = new SidSegment();
            actual.FromDelimitedString("SID|1|2|3|4");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new SidSegment
            {
                ApplicationMethodIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                SubstanceLotNumber = "2",
                SubstanceContainerIdentifier = "3",
                SubstanceManufacturerIdentifier = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            string expected = "SID|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
