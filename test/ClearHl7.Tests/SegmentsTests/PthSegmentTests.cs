using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PthSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new PthSegment
            {
                ActionCode = "1",
                PathwayId = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                PathwayInstanceId = new EntityIdentifier
                {
                    EntityId = "3"
                },
                PathwayEstablishedDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                PathwayLifeCycleStatus = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ChangePathwayLifeCycleStatusDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                MoodCode = new CodedWithNoExceptions
                {
                    Identifier = "7"
                }
            };

            ISegment actual = new PthSegment();
            actual.FromDelimitedString("PTH|1|2|3|20200404000004|5|20200606000006|7");

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
                ISegment hl7Segment = new PthSegment();
                hl7Segment.FromDelimitedString("PTA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PthSegment
            {
                ActionCode = "1",
                PathwayId = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                PathwayInstanceId = new EntityIdentifier
                {
                    EntityId = "3"
                },
                PathwayEstablishedDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                PathwayLifeCycleStatus = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ChangePathwayLifeCycleStatusDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                MoodCode = new CodedWithNoExceptions
                {
                    Identifier = "7"
                }
            };

            string expected = "PTH|1|2|3|20200404000004|5|20200606000006|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
