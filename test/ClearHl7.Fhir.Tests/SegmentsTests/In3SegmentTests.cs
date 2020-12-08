using System;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class In3SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
                }
            };

            string expected = "IN3|1|2|3|4|5|20200606000006|20200707000007|8|20200909|20201010|11|12|20200113000013|14|15|16|17|18|19|20|21|20200202|23|24|25|26|27";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
