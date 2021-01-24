using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class CnsSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new CnsSegment
            {
                StartingNotificationReferenceNumber = 1,
                EndingNotificationReferenceNumber = 2,
                StartingNotificationDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                EndingNotificationDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                StartingNotificationCode = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                EndingNotificationCode = new CodedWithExceptions
                {
                    Identifier = "6"
                }
            };

            string expected = "CNS|1|2|20200303000003|20200404000004|5|6";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
