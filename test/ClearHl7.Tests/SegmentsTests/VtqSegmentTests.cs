using System;
using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class VtqSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new VtqSegment
            {
                QueryTag = "1",
                QueryResponseFormatCode = "2",
                VtQueryName = new CodedElement
                {
                    Identifier = "3"
                },
                VirtualTableName = new CodedElement
                {
                    Identifier = "4"
                },
                SelectionCriteria = new QuerySelectionCriteria
                {
                    SegmentFieldName = "5"
                }
            };

            ISegment actual = new VtqSegment();
            actual.FromDelimitedString("VTQ|1|2|3|4|5");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that calling FromDelimitedString() with a string input containing an incorrect segment ID results in an ArgumentException being thrown.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithIncorrectSegmentId_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ISegment hl7Segment = new VtqSegment();
                hl7Segment.FromDelimitedString("VTA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new VtqSegment
            {
                QueryTag = "1",
                QueryResponseFormatCode = "2",
                VtQueryName = new CodedElement
                {
                    Identifier = "3"
                },
                VirtualTableName = new CodedElement
                {
                    Identifier = "4"
                },
                SelectionCriteria = new QuerySelectionCriteria
                {
                    SegmentFieldName = "5"
                }
            };

            string expected = "VTQ|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
