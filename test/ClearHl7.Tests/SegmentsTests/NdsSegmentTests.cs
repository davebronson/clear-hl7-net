using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class NdsSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new NdsSegment
            {
                NotificationReferenceNumber = 1,
                NotificationDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                NotificationAlertSeverity = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                NotificationCode = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            ISegment actual = new NdsSegment();
            actual.FromDelimitedString("NDS|1|20200202000002|3|4");

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
                ISegment hl7Segment = new NdsSegment();
                hl7Segment.FromDelimitedString("NDA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new NdsSegment
            {
                NotificationReferenceNumber = 1,
                NotificationDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                NotificationAlertSeverity = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                NotificationCode = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            string expected = "NDS|1|20200202000002|3|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
