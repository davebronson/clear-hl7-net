using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Oh1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Oh1Segment
            {
                SetId = 1,
                ActionCode = "2",
                EmploymentStatus = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                EmploymentStatusStartDate = new DateTime(2020, 4, 4),
                EmploymentStatusEndDate = new DateTime(2020, 5, 5),
                EnteredDate = new DateTime(2020, 6, 6),
                EmploymentStatusUniqueIdentifier = new EntityIdentifier
                {
                    EntityId = "7"
                }
            };

            ISegment actual = new Oh1Segment();
            actual.FromDelimitedString("OH1|1|2|3|20200404|20200505|20200606|7");

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
                ISegment hl7Segment = new Oh1Segment();
                hl7Segment.FromDelimitedString("OHA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Oh1Segment
            {
                SetId = 1,
                ActionCode = "2",
                EmploymentStatus = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                EmploymentStatusStartDate = new DateTime(2020, 4, 4),
                EmploymentStatusEndDate = new DateTime(2020, 5, 5),
                EnteredDate = new DateTime(2020, 6, 6),
                EmploymentStatusUniqueIdentifier = new EntityIdentifier
                {
                    EntityId = "7"
                }
            };

            string expected = "OH1|1|2|3|20200404|20200505|20200606|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
