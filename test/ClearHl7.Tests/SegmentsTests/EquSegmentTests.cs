using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class EquSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new EquSegment
            {
                EquipmentInstanceIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "1"
                    }
                },
                EventDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                EquipmentState = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                LocalRemoteControlState = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                AlertLevel = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ExpectedDateTimeOfTheNextStatusChange = new DateTime(2020, 6, 6, 0, 0, 6)
            };

            ISegment actual = new EquSegment();
            actual.FromDelimitedString("EQU|1|20200202000002|3|4|5|20200606000006");

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
                ISegment hl7Segment = new EquSegment();
                hl7Segment.FromDelimitedString("EQA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new EquSegment
            {
                EquipmentInstanceIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "1"
                    }
                },
                EventDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                EquipmentState = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                LocalRemoteControlState = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                AlertLevel = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ExpectedDateTimeOfTheNextStatusChange = new DateTime(2020, 6, 6, 0, 0, 6)
            };

            string expected = "EQU|1|20200202000002|3|4|5|20200606000006";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
