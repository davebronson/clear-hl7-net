using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class DmiSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new DmiSegment
            {
                DiagnosticRelatedGroup = new CodedWithNoExceptions
                {
                    Identifier = "1"
                },
                MajorDiagnosticCategory = new CodedWithNoExceptions
                {
                    Identifier = "2"
                },
                LowerAndUpperTrimPoints = new NumericRange
                {
                    LowValue = 3
                },
                AverageLengthOfStay = 4,
                RelativeWeight = 5
            };

            string expected = "DMI|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
