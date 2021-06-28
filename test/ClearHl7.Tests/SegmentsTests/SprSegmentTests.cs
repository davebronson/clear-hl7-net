using ClearHl7.V251.Segments;
using ClearHl7.V251.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class SprSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new SprSegment
            {
                QueryTag = "1",
                QueryResponseFormatCode = "2",
                StoredProcedureName = new CodedElement
                {
                    Identifier = "3"
                },
                InputParameterList = new QueryInputParameterList[]
                {
                    new QueryInputParameterList
                    {
                        SegmentFieldName = "4"
                    }
                }
            };
            ISegment actual = new SprSegment().FromDelimitedString("SPR|1|2|3|4");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new SprSegment
            {
                QueryTag = "1",
                QueryResponseFormatCode = "2",
                StoredProcedureName = new CodedElement
                {
                    Identifier = "3"
                },
                InputParameterList = new QueryInputParameterList[]
                {
                    new QueryInputParameterList
                    {
                        SegmentFieldName = "4"
                    }
                }
            };

            string expected = "SPR|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
