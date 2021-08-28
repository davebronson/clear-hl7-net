using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class ShpSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new ShpSegment
            {
                ShipmentId = new EntityIdentifier
                {
                    EntityId = "1"
                },
                InternalShipmentId = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "2"
                    }
                },
                ShipmentStatus = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ShipmentStatusDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                ShipmentStatusReason = new Text
                {
                    Value = "5"
                },
                ShipmentPriority = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                ShipmentConfidentiality = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                NumberOfPackagesInShipment = 8,
                ShipmentCondition = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                ShipmentHandlingCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "10"
                    }
                },
                ShipmentRiskCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                ActionCode = "12"
            };

            ISegment actual = new ShpSegment();
            actual.FromDelimitedString("SHP|1|2|3|20200404000004|5|6|7|8|9|10|11|12");

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
                ISegment hl7Segment = new ShpSegment();
                hl7Segment.FromDelimitedString("SHA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ShpSegment
            {
                ShipmentId = new EntityIdentifier
                {
                    EntityId = "1"
                },
                InternalShipmentId = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "2"
                    }
                },
                ShipmentStatus = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ShipmentStatusDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                ShipmentStatusReason = new Text
                {
                    Value = "5"
                },
                ShipmentPriority = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                ShipmentConfidentiality = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                NumberOfPackagesInShipment = 8,
                ShipmentCondition = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                ShipmentHandlingCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "10"
                    }
                },
                ShipmentRiskCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                ActionCode = "12"
            };

            string expected = "SHP|1|2|3|20200404000004|5|6|7|8|9|10|11|12";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
