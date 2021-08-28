using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class CspSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new CspSegment
            {
                StudyPhaseIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                DateTimeStudyPhaseBegan = new DateTime(2020, 2, 2, 0, 0, 2),
                DateTimeStudyPhaseEnded = new DateTime(2020, 3, 3, 0, 0, 3),
                StudyPhaseEvaluability = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            ISegment actual = new CspSegment();
            actual.FromDelimitedString("CSP|1|20200202000002|20200303000003|4");

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
                ISegment hl7Segment = new CspSegment();
                hl7Segment.FromDelimitedString("CSA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new CspSegment
            {
                StudyPhaseIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                DateTimeStudyPhaseBegan = new DateTime(2020, 2, 2, 0, 0, 2),
                DateTimeStudyPhaseEnded = new DateTime(2020, 3, 3, 0, 0, 3),
                StudyPhaseEvaluability = new CodedWithExceptions
                {
                    Identifier = "4"
                }
            };

            string expected = "CSP|1|20200202000002|20200303000003|4";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
