using System;
using ClearHl7.V290.Segments;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class NstSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new NstSegment
            {
                StatisticsAvailable = "1",
                SourceIdentifier = "2",
                SourceType = "3",
                StatisticsStart = new DateTime(2020, 4, 4, 0, 0, 4),
                StatisticsEnd = new DateTime(2020, 5, 5, 0, 0, 5),
                ReceiveCharacterCount = 6,
                SendCharacterCount = 7,
                MessagesReceived = 8,
                MessagesSent = 9,
                ChecksumErrorsReceived = 10,
                LengthErrorsReceived = 11,
                OtherErrorsReceived = 12,
                ConnectTimeouts = 13,
                ReceiveTimeouts = 14,
                ApplicationControlLevelErrors = 15
            };

            ISegment actual = new NstSegment();
            actual.FromDelimitedString("NST|1|2|3|20200404000004|20200505000005|6|7|8|9|10|11|12|13|14|15");

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
                ISegment hl7Segment = new NstSegment();
                hl7Segment.FromDelimitedString("NSA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new NstSegment
            {
                StatisticsAvailable = "1",
                SourceIdentifier = "2",
                SourceType = "3",
                StatisticsStart = new DateTime(2020, 4, 4, 0, 0, 4),
                StatisticsEnd = new DateTime(2020, 5, 5, 0, 0, 5),
                ReceiveCharacterCount = 6,
                SendCharacterCount = 7,
                MessagesReceived = 8,
                MessagesSent = 9,
                ChecksumErrorsReceived = 10,
                LengthErrorsReceived = 11,
                OtherErrorsReceived = 12,
                ConnectTimeouts = 13,
                ReceiveTimeouts = 14,
                ApplicationControlLevelErrors = 15
            };

            string expected = "NST|1|2|3|20200404000004|20200505000005|6|7|8|9|10|11|12|13|14|15";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
