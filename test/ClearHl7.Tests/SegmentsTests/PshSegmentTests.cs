using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PshSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new PshSegment
            {
                ReportType = "1",
                ReportFormIdentifier = "2",
                ReportDate = new DateTime(2020, 3, 3, 0, 0, 3),
                ReportIntervalStartDate = new DateTime(2020, 4, 4, 0, 0, 4),
                ReportIntervalEndDate = new DateTime(2020, 5, 5, 0, 0, 5),
                QuantityManufactured = new CompositeQuantityWithUnits
                {
                    Quantity = 6
                },
                QuantityDistributed = new CompositeQuantityWithUnits
                {
                    Quantity = 7
                },
                QuantityDistributedMethod = "8",
                QuantityDistributedComment = "9",
                QuantityInUse = new CompositeQuantityWithUnits
                {
                    Quantity = 10
                },
                QuantityInUseMethod = "11",
                QuantityInUseComment = "12",
                NumberOfProductExperienceReportsFiledByFacility = new decimal[]
                {
                    13
                },
                NumberOfProductExperienceReportsFiledByDistributor = new decimal[]
                {
                    14
                }
            };

            ISegment actual = new PshSegment();
            actual.FromDelimitedString("PSH|1|2|20200303000003|20200404000004|20200505000005|6|7|8|9|10|11|12|13|14");

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
                ISegment hl7Segment = new PshSegment();
                hl7Segment.FromDelimitedString("PSA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PshSegment
            {
                ReportType = "1",
                ReportFormIdentifier = "2",
                ReportDate = new DateTime(2020, 3, 3, 0, 0, 3),
                ReportIntervalStartDate = new DateTime(2020, 4, 4, 0, 0, 4),
                ReportIntervalEndDate = new DateTime(2020, 5, 5, 0, 0, 5),
                QuantityManufactured = new CompositeQuantityWithUnits
                {
                    Quantity = 6
                },
                QuantityDistributed = new CompositeQuantityWithUnits
                {
                    Quantity = 7
                },
                QuantityDistributedMethod = "8",
                QuantityDistributedComment = "9",
                QuantityInUse = new CompositeQuantityWithUnits
                {
                    Quantity = 10
                },
                QuantityInUseMethod = "11",
                QuantityInUseComment = "12",
                NumberOfProductExperienceReportsFiledByFacility = new decimal[]
                {
                    13
                },
                NumberOfProductExperienceReportsFiledByDistributor = new decimal[]
                {
                    14
                }
            };

            string expected = "PSH|1|2|20200303000003|20200404000004|20200505000005|6|7|8|9|10|11|12|13|14";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
