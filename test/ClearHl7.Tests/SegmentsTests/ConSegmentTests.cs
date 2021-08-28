using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class ConSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new ConSegment
            {
                SetIdCon = 1,
                ConsentType = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ConsentFormIdAndVersion = "3",
                ConsentFormNumber = new EntityIdentifier
                {
                    EntityId = "4"
                },
                ConsentText = new string[]
                {
                    "5"
                },
                SubjectSpecificConsentText = new string[]
                {
                    "6"
                },
                ConsentBackgroundInformation = new string[]
                {
                    "7"
                },
                SubjectSpecificConsentBackgroundText = new string[]
                {
                    "8"
                },
                ConsenterImposedLimitations = new string[]
                {
                    "9"
                },
                ConsentMode = new CodedWithNoExceptions
                {
                    Identifier = "10"
                },
                ConsentStatus = new CodedWithNoExceptions
                {
                    Identifier = "11"
                },
                ConsentDiscussionDateTime = new DateTime(2020, 1, 12, 0, 0, 12),
                ConsentDecisionDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                ConsentEffectiveDateTime = new DateTime(2020, 1, 14, 0, 0, 14),
                ConsentEndDateTime = new DateTime(2020, 1, 15, 0, 0, 15),
                SubjectCompetenceIndicator = "16",
                TranslatorAssistanceIndicator = "17",
                LanguageTranslatedTo = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                InformationalMaterialSuppliedIndicator = "19",
                ConsentBypassReason = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                ConsentDisclosureLevel = "21",
                ConsentNonDisclosureReason = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                NonSubjectConsenterReason = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                ConsenterId = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "24"
                        }
                    }
                },
                RelationshipToSubject = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "25"
                    }
                }
            };

            ISegment actual = new ConSegment();
            actual.FromDelimitedString("CON|1|2|3|4|5|6|7|8|9|10|11|20200112000012|20200113000013|20200114000014|20200115000015|16|17|18|19|20|21|22|23|24|25");

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
                ISegment hl7Segment = new ConSegment();
                hl7Segment.FromDelimitedString("COA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ConSegment
            {
                SetIdCon = 1,
                ConsentType = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ConsentFormIdAndVersion = "3",
                ConsentFormNumber = new EntityIdentifier
                {
                    EntityId = "4"
                },
                ConsentText = new string[]
                {
                    "5"
                },
                SubjectSpecificConsentText = new string[]
                {
                    "6"
                },
                ConsentBackgroundInformation = new string[]
                {
                    "7"
                },
                SubjectSpecificConsentBackgroundText = new string[]
                {
                    "8"
                },
                ConsenterImposedLimitations = new string[]
                {
                    "9"
                },
                ConsentMode = new CodedWithNoExceptions
                {
                    Identifier = "10"
                },
                ConsentStatus = new CodedWithNoExceptions
                {
                    Identifier = "11"
                },
                ConsentDiscussionDateTime = new DateTime(2020, 1, 12, 0, 0, 12),
                ConsentDecisionDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                ConsentEffectiveDateTime = new DateTime(2020, 1, 14, 0, 0, 14),
                ConsentEndDateTime = new DateTime(2020, 1, 15, 0, 0, 15),
                SubjectCompetenceIndicator = "16",
                TranslatorAssistanceIndicator = "17",
                LanguageTranslatedTo = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                InformationalMaterialSuppliedIndicator = "19",
                ConsentBypassReason = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                ConsentDisclosureLevel = "21",
                ConsentNonDisclosureReason = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                NonSubjectConsenterReason = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                ConsenterId = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "24"
                        }
                    }
                },
                RelationshipToSubject = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "25"
                    }
                }
            };

            string expected = "CON|1|2|3|4|5|6|7|8|9|10|11|20200112000012|20200113000013|20200114000014|20200115000015|16|17|18|19|20|21|22|23|24|25";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
