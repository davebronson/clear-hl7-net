using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RxoSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RxoSegment
            {
                RequestedGiveCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                RequestedGiveAmountMinimum = 2,
                RequestedGiveAmountMaximum = 3,
                RequestedGiveUnits = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                RequestedDosageForm = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ProvidersPharmacyTreatmentInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "6"
                    }
                },
                ProvidersAdministrationInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                DeliverToLocation = "8",
                AllowSubstitutions = "9",
                RequestedDispenseCode = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                RequestedDispenseAmount = 11,
                RequestedDispenseUnits = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                NumberOfRefills = 13,
                OrderingProvidersDeaNumber = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "14"
                },
                PharmacistTreatmentSuppliersVerifierId = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "15"
                    }
                },
                NeedsHumanReview = "16",
                RequestedGivePerTimeUnit = "17",
                RequestedGiveStrength = 18,
                RequestedGiveStrengthUnits = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                Indication = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "20"
                    }
                },
                RequestedGiveRateAmount = "21",
                RequestedGiveRateUnits = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                TotalDailyDose = new CompositeQuantityWithUnits
                {
                    Quantity = 23
                },
                SupplementaryCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "24"
                    }
                },
                RequestedDrugStrengthVolume = 25,
                RequestedDrugStrengthVolumeUnits = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                PharmacyOrderType = "27",
                DispensingInterval = 28,
                MedicationInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "29"
                },
                SegmentInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "30"
                },
                MoodCode = new CodedWithNoExceptions
                {
                    Identifier = "31"
                },
                DispensingPharmacy = new CodedWithExceptions
                {
                    Identifier = "32"
                },
                DispensingPharmacyAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "33"
                    }
                },
                DeliverToPatientLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "34"
                    }
                },
                DeliverToAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "35"
                    }
                },
                PharmacyPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "36"
                    }
                }
            };

            ISegment actual = new RxoSegment();
            actual.FromDelimitedString("RXO|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RxoSegment
            {
                RequestedGiveCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                RequestedGiveAmountMinimum = 2,
                RequestedGiveAmountMaximum = 3,
                RequestedGiveUnits = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                RequestedDosageForm = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ProvidersPharmacyTreatmentInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "6"
                    }
                },
                ProvidersAdministrationInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                DeliverToLocation = "8",
                AllowSubstitutions = "9",
                RequestedDispenseCode = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                RequestedDispenseAmount = 11,
                RequestedDispenseUnits = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                NumberOfRefills = 13,
                OrderingProvidersDeaNumber = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "14"
                },
                PharmacistTreatmentSuppliersVerifierId = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "15"
                    }
                },
                NeedsHumanReview = "16",
                RequestedGivePerTimeUnit = "17",
                RequestedGiveStrength = 18,
                RequestedGiveStrengthUnits = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                Indication = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "20"
                    }
                },
                RequestedGiveRateAmount = "21",
                RequestedGiveRateUnits = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                TotalDailyDose = new CompositeQuantityWithUnits
                {
                    Quantity = 23
                },
                SupplementaryCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "24"
                    }
                },
                RequestedDrugStrengthVolume = 25,
                RequestedDrugStrengthVolumeUnits = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                PharmacyOrderType = "27",
                DispensingInterval = 28,
                MedicationInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "29"
                },
                SegmentInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "30"
                },
                MoodCode = new CodedWithNoExceptions
                {
                    Identifier = "31"
                },
                DispensingPharmacy = new CodedWithExceptions
                {
                    Identifier = "32"
                },
                DispensingPharmacyAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "33"
                    }
                },
                DeliverToPatientLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "34"
                    }
                },
                DeliverToAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "35"
                    }
                },
                PharmacyPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "36"
                    }
                }
            };

            string expected = "RXO|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
