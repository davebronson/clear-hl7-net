using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class NteSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new NteSegment
            {
                SetIdNte = 1,
                SourceOfComment = "2",
                Comment = new string[]
                {
                    "3"
                },
                CommentType = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                EnteredBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "5"
                },
                EnteredDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                EffectiveStartDate = new DateTime(2020, 7, 7, 0, 0, 7),
                ExpirationDate = new DateTime(2020, 8, 8, 0, 0, 8),
                CodedComment = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                }
            };

            ISegment actual = new NteSegment();
            actual.FromDelimitedString("NTE|1|2|3|4|5|20200606000006|20200707000007|20200808000008|9");

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
                ISegment hl7Segment = new NteSegment();
                hl7Segment.FromDelimitedString("NTA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new NteSegment
            {
                SetIdNte = 1,
                SourceOfComment = "2",
                Comment = new string[]
                {
                    "3"
                },
                CommentType = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                EnteredBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "5"
                },
                EnteredDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                EffectiveStartDate = new DateTime(2020, 7, 7, 0, 0, 7),
                ExpirationDate = new DateTime(2020, 8, 8, 0, 0, 8),
                CodedComment = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                }
            };

            string expected = "NTE|1|2|3|4|5|20200606000006|20200707000007|20200808000008|9";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
