using System;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class ObxSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ObxSegment
            {
                SetIdObx = 1,
                ValueType = "2",
                ObservationIdentifier = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ObservationSubId = new ObservationGrouper
                {
                    OriginalSubIdentifier = "4"
                },
                ObservationValue = new string[]
                {
                    "5"
                },
                Units = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                ReferencesRange = "7",
                InterpretationCodes = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "8"
                    }
                },
                Probability = 9,
                NatureOfAbnormalTest = new string[]
                {
                    "10"
                },
                ObservationResultStatus = "11",
                EffectiveDateOfReferenceRange = new DateTime(2020, 12, 12, 0, 0, 12),
                UserDefinedAccessChecks = "13",
                DateTimeOfTheObservation = new DateTime(2020, 1, 14, 0, 0, 14),
                ProducersId = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                ResponsibleObserver = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "16"
                    }
                },
                ObservationMethod = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "17"
                    }
                },
                EquipmentInstanceIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "18"
                    }
                },
                DateTimeOfTheAnalysis = new DateTime(2020, 1, 19, 0, 0, 19),
                ObservationSite = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "20"
                    }
                },
                ObservationInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "21"
                },
                MoodCode = new CodedWithNoExceptions
                {
                    Identifier = "22"
                },
                PerformingOrganizationName = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "23"
                },
                PerformingOrganizationAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "24"
                    }
                },
                PerformingOrganizationMedicalDirector = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "25"
                },
                PatientResultsReleaseCategory = "26",
                RootCause = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                LocalProcessControl = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "28"
                    }
                },
                ObservationType = "29",
                ObservationSubType = "30"
            };

            string expected = "OBX|1|2|3|4|5|6|7|8|9|10|11|20201212000012|13|20200114000014|15|16|17|18|20200119000019|20|21|22|23|24|25|26|27|28|29|30";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
