using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class EqpSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new EqpSegment
            {
                EventType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                FileName = "2",
                StartDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                EndDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                TransactionData = "5"
            };

            ISegment actual = new EqpSegment();
            actual.FromDelimitedString("EQP|1|2|20200303000003|20200404000004|5");

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
                ISegment hl7Segment = new EqpSegment();
                hl7Segment.FromDelimitedString("EQA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new EqpSegment
            {
                EventType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                FileName = "2",
                StartDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                EndDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                TransactionData = "5"
            };

            string expected = "EQP|1|2|20200303000003|20200404000004|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
