using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RcpSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RcpSegment
            {
                QueryPriority = "1",
                QuantityLimitedRequest = new CompositeQuantityWithUnits
                {
                    Quantity = 2
                },
                ResponseModality = new CodedWithNoExceptions
                {
                    Identifier = "3"
                },
                ExecutionAndDeliveryTime = new DateTime(2020, 4, 4, 0, 0, 4),
                ModifyIndicator = "5",
                SortByField = new SortOrder[]
                {
                    new SortOrder
                    {
                        SortByField = "6"
                    }
                },
                SegmentGroupInclusion = new string[]
                {
                    "7"
                }
            };

            ISegment actual = new RcpSegment();
            actual.FromDelimitedString("RCP|1|2|3|20200404000004|5|6|7");

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
                ISegment hl7Segment = new RcpSegment();
                hl7Segment.FromDelimitedString("RCA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RcpSegment
            {
                QueryPriority = "1",
                QuantityLimitedRequest = new CompositeQuantityWithUnits
                {
                    Quantity = 2
                },
                ResponseModality = new CodedWithNoExceptions
                {
                    Identifier = "3"
                },
                ExecutionAndDeliveryTime = new DateTime(2020, 4, 4, 0, 0, 4),
                ModifyIndicator = "5",
                SortByField = new SortOrder[]
                {
                    new SortOrder
                    {
                        SortByField = "6"
                    }
                },
                SegmentGroupInclusion = new string[]
                {
                    "7"
                }
            };

            string expected = "RCP|1|2|3|20200404000004|5|6|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
