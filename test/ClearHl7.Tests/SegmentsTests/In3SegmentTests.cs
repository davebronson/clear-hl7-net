using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class In3SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new In3Segment
            {
                SetIdIn3 = 1,
                CertificationNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "2"
                },
                CertifiedBy = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "3"
                    }
                },
                CertificationRequired = "4",
                Penalty = new MoneyOrPercentage
                {
                    MoneyOrPercentageIndicator = "5"
                },
                CertificationDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                CertificationModifyDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                Operator = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "8"
                    }
                },
                CertificationBeginDate = new DateTime(2020, 9, 9),
                CertificationEndDate = new DateTime(2020, 10, 10),
                Days = new DayTypeAndNumber
                {
                    DayType = new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                NonConcurCodeDescription = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                NonConcurEffectiveDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                PhysicianReviewer = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "14"
                    }
                },
                CertificationContact = "15",
                CertificationContactPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "16"
                    }
                },
                AppealReason = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                CertificationAgency = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                CertificationAgencyPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "19"
                    }
                },
                PreCertificationRequirement = new InsuranceCertificationDefinition[]
                {
                    new InsuranceCertificationDefinition
                    {
                        CertificationPatientType = new CodedWithExceptions
                        {
                            Identifier = "20"
                        }
                    }
                },
                CaseManager = "21",
                SecondOpinionDate = new DateTime(2020, 2, 2),
                SecondOpinionStatus = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                SecondOpinionDocumentationReceived = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "24"
                    }
                },
                SecondOpinionPhysician = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "25"
                    }
                },
                CertificationType = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                CertificationCategory = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                OnlineVerificationDateTime = new DateTime(2020, 1, 28, 0, 0, 28),
                OnlineVerificationResult = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                OnlineVerificationResultErrorCode = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                OnlineVerificationResultCheckDigit = "31"
            };

            ISegment actual = new In3Segment();
            actual.FromDelimitedString("IN3|1|2|3|4|5|20200606000006|20200707000007|8|20200909|20201010|11|12|20200113000013|14|15|16|17|18|19|20|21|20200202|23|24|25|26|27|20200128000028|29|30|31");

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
                ISegment hl7Segment = new In3Segment();
                hl7Segment.FromDelimitedString("INA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new In3Segment
            {
                SetIdIn3 = 1,
                CertificationNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "2"
                },
                CertifiedBy = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "3"
                    }
                },
                CertificationRequired = "4",
                Penalty = new MoneyOrPercentage
                {
                    MoneyOrPercentageIndicator = "5"
                },
                CertificationDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                CertificationModifyDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                Operator = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "8"
                    }
                },
                CertificationBeginDate = new DateTime(2020, 9, 9),
                CertificationEndDate = new DateTime(2020, 10, 10),
                Days = new DayTypeAndNumber
                {
                    DayType = new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                NonConcurCodeDescription = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                NonConcurEffectiveDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                PhysicianReviewer = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "14"
                    }
                },
                CertificationContact = "15",
                CertificationContactPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "16"
                    }
                },
                AppealReason = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                CertificationAgency = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                CertificationAgencyPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "19"
                    }
                },
                PreCertificationRequirement = new InsuranceCertificationDefinition[]
                {
                    new InsuranceCertificationDefinition
                    {
                        CertificationPatientType = new CodedWithExceptions
                        {
                            Identifier = "20"
                        }
                    }
                },
                CaseManager = "21",
                SecondOpinionDate = new DateTime(2020, 2, 2),
                SecondOpinionStatus = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                SecondOpinionDocumentationReceived = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "24"
                    }
                },
                SecondOpinionPhysician = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "25"
                    }
                },
                CertificationType = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                CertificationCategory = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                OnlineVerificationDateTime = new DateTime(2020, 1, 28, 0, 0, 28),
                OnlineVerificationResult = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                OnlineVerificationResultErrorCode = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                OnlineVerificationResultCheckDigit = "31"
            };

            string expected = "IN3|1|2|3|4|5|20200606000006|20200707000007|8|20200909|20201010|11|12|20200113000013|14|15|16|17|18|19|20|21|20200202|23|24|25|26|27|20200128000028|29|30|31";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
