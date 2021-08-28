using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class MfeSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new MfeSegment
            {
                RecordLevelEventCode = "1",
                MfnControlId = "2",
                EffectiveDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                PrimaryKeyValueMfe = new string[]
                {
                    "4"
                },
                PrimaryKeyValueType = new string[]
                {
                    "5"
                },
                EnteredDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                EnteredBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "7"
                }
            };

            ISegment actual = new MfeSegment();
            actual.FromDelimitedString("MFE|1|2|20200303000003|4|5|20200606000006|7");

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
                ISegment hl7Segment = new MfeSegment();
                hl7Segment.FromDelimitedString("MFA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new MfeSegment
            {
                RecordLevelEventCode = "1",
                MfnControlId = "2",
                EffectiveDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                PrimaryKeyValueMfe = new string[]
                {
                    "4"
                },
                PrimaryKeyValueType = new string[]
                {
                    "5"
                },
                EnteredDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                EnteredBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "7"
                }
            };

            string expected = "MFE|1|2|20200303000003|4|5|20200606000006|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
