using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class CsrSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new CsrSegment
            {
                SponsorStudyId = new EntityIdentifier
                {
                    EntityId = "1"
                },
                AlternateStudyId = new EntityIdentifier
                {
                    EntityId = "2"
                },
                InstitutionRegisteringThePatient = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                SponsorPatientId = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "4"
                },
                AlternatePatientIdCsr = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "5"
                },
                DateTimeOfPatientStudyRegistration = new DateTime(2020, 6, 6, 0, 0, 6),
                PersonPerformingStudyRegistration = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "7"
                    }
                },
                StudyAuthorizingProvider = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "8"
                    }
                },
                DateTimePatientStudyConsentSigned = new DateTime(2020, 9, 9, 0, 0, 9),
                PatientStudyEligibilityStatus = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                StudyRandomizationDateTime = new DateTime[]
                {
                    new DateTime(2020,11,11,0,0,11)
                },
                RandomizedStudyArm = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "12"
                    }
                },
                StratumForStudyRandomization = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                },
                PatientEvaluabilityStatus = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                DateTimeEndedStudy = new DateTime(2020, 1, 15, 0, 0, 15),
                ReasonEndedStudy = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                ActionCode = "17"
            };

            ISegment actual = new CsrSegment();
            actual.FromDelimitedString("CSR|1|2|3|4|5|20200606000006|7|8|20200909000009|10|20201111000011|12|13|14|20200115000015|16|17");

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
                ISegment hl7Segment = new CsrSegment();
                hl7Segment.FromDelimitedString("CSA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new CsrSegment
            {
                SponsorStudyId = new EntityIdentifier
                {
                    EntityId = "1"
                },
                AlternateStudyId = new EntityIdentifier
                {
                    EntityId = "2"
                },
                InstitutionRegisteringThePatient = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                SponsorPatientId = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "4"
                },
                AlternatePatientIdCsr = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "5"
                },
                DateTimeOfPatientStudyRegistration = new DateTime(2020, 6, 6, 0, 0, 6),
                PersonPerformingStudyRegistration = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "7"
                    }
                },
                StudyAuthorizingProvider = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "8"
                    }
                },
                DateTimePatientStudyConsentSigned = new DateTime(2020, 9, 9, 0, 0, 9),
                PatientStudyEligibilityStatus = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                StudyRandomizationDateTime = new DateTime[]
                {
                    new DateTime(2020,11,11,0,0,11)
                },
                RandomizedStudyArm = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "12"
                    }
                },
                StratumForStudyRandomization = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                },
                PatientEvaluabilityStatus = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                DateTimeEndedStudy = new DateTime(2020, 1, 15, 0, 0, 15),
                ReasonEndedStudy = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                ActionCode = "17"
            };

            string expected = "CSR|1|2|3|4|5|20200606000006|7|8|20200909000009|10|20201111000011|12|13|14|20200115000015|16|17";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
