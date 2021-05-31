using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class BlgSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new BlgSegment
            {
                WhenToCharge = new ChargeCodeAndDate
                {
                    InvocationEvent = "1"
                },
                ChargeType = "2",
                AccountId = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "3"
                },
                ChargeTypeReason = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            string expected = "BLG|1|2|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
