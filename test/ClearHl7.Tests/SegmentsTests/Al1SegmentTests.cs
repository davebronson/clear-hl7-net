using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Al1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Al1Segment
            {
                SetIdAl1 = 1,
                AllergenTypeCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AllergenCodeMnemonicDescription = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                AllergySeverityCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                AllergyReactionCode = new string[]
                {
                    "5"
                },
                IdentificationDate = new DateTime(2020, 6, 6)
            };

            ISegment actual = new Al1Segment();
            actual.FromDelimitedString("AL1|1|2|3|4|5|20200606");

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
                ISegment hl7Segment = new Al1Segment();
                hl7Segment.FromDelimitedString("ALA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Al1Segment
            {
                SetIdAl1 = 1,
                AllergenTypeCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AllergenCodeMnemonicDescription = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                AllergySeverityCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                AllergyReactionCode = new string[]
                {
                    "5"
                },
                IdentificationDate = new DateTime(2020, 6, 6)
            };

            string expected = "AL1|1|2|3|4|5|20200606";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
