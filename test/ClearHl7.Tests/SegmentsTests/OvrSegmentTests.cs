using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class OvrSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new OvrSegment
            {
                BusinessRuleOverrideType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                BusinessRuleOverrideCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                OverrideComments = new Text
                {
                    Value = "3"
                },
                OverrideEnteredBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "4"
                },
                OverrideAuthorizedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "5"
                }
            };

            string expected = "OVR|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
