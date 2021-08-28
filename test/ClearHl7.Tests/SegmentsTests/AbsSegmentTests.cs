using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class AbsSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new AbsSegment
            {
                DischargeCareProvider = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "1"
                },
                TransferMedicalServiceCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                SeverityOfIllnessCode = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                DateTimeOfAttestation = new DateTime(2020, 4, 1, 0, 0, 0),
                AttestedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "5"
                },
                TriageCode = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                AbstractCompletionDateTime = new DateTime(2020, 7, 1, 0, 0, 0),
                AbstractedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "8"
                },
                CaseCategoryCode = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                CaesarianSectionIndicator = "10",
                GestationCategoryCode = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                GestationPeriodWeeks = 12,
                NewbornCode = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                StillbornIndicator = "14"
            };

            ISegment actual = new AbsSegment();
            actual.FromDelimitedString("ABS|1|2|3|20200401000000|5|6|20200701000000|8|9|10|11|12|13|14");
            
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
                ISegment hl7Segment = new AbsSegment();
                hl7Segment.FromDelimitedString("ABA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new AbsSegment
            {
                DischargeCareProvider = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "1"
                },
                TransferMedicalServiceCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                SeverityOfIllnessCode = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                DateTimeOfAttestation = new DateTime(2020, 4, 1, 0, 0, 0),
                AttestedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "5"
                },
                TriageCode = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                AbstractCompletionDateTime = new DateTime(2020, 7, 1, 0, 0, 0),
                AbstractedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "8"
                },
                CaseCategoryCode = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                CaesarianSectionIndicator = "10",
                GestationCategoryCode = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                GestationPeriodWeeks = 12,
                NewbornCode = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                StillbornIndicator = "14"
            };

            string expected = "ABS|1|2|3|20200401000000|5|6|20200701000000|8|9|10|11|12|13|14";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
