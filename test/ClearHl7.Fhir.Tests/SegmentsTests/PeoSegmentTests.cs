using System;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class PeoSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PeoSegment
            {
                EventIdentifiersUsed = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "1"
                    }
                },
                EventSymptomDiagnosisCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                EventOnsetDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                EventExacerbationDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                EventImprovedDateTime = new DateTime(2020, 5, 5, 0, 0, 5),
                EventEndedDataTime = new DateTime(2020, 6, 6, 0, 0, 6),
                EventLocationOccurredAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "7"
                        }
                    }
                },
                EventQualification = new string[]
                {
                    "8"
                },
                EventSerious = "9",
                EventExpected = "10",
                EventOutcome = new string[]
                {
                    "11"
                },
                PatientOutcome = "12",
                EventDescriptionFromOthers = new string[]
                {
                    "13"
                },
                EventDescriptionFromOriginalReporter = new string[]
                {
                    "14"
                },
                EventDescriptionFromPatient = new string[]
                {
                    "15"
                },
                EventDescriptionFromPractitioner = new string[]
                {
                    "16"
                },
                EventDescriptionFromAutopsy = new string[]
                {
                    "17"
                },
                CauseOfDeath = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "18"
                    }
                },
                PrimaryObserverName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "19"
                        }
                    }
                },
                PrimaryObserverAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "20"
                        }
                    }
                },
                PrimaryObserverTelephone = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "21"
                    }
                },
                PrimaryObserversQualification = "22",
                ConfirmationProvidedBy = "23",
                PrimaryObserverAwareDateTime = new DateTime(2020, 1, 24, 0, 0, 24),
                PrimaryObserversIdentityMayBeDivulged = "25"
            };

            string expected = "PEO|1|2|20200303000003|20200404000004|20200505000005|20200606000006|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|20200124000024|25";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
