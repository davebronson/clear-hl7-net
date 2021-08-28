using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RxeSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RxeSegment
            {
                QuantityTiming = "1",
                GiveCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                GiveAmountMinimum = 3,
                GiveAmountMaximum = 4,
                GiveUnits = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                GiveDosageForm = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                ProvidersAdministrationInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                DeliverToLocation = "8",
                SubstitutionStatus = "9",
                DispenseAmount = 10,
                DispenseUnits = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                NumberOfRefills = 12,
                OrderingProvidersDeaNumber = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "13"
                    }
                },
                PharmacistTreatmentSuppliersVerifierId = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "14"
                    }
                },
                PrescriptionNumber = "15",
                NumberOfRefillsRemaining = 16,
                NumberOfRefillsDosesDispensed = 17,
                DateTimeOfMostRecentRefillOrDoseDispensed = new DateTime(2020, 1, 18, 0, 0, 18),
                TotalDailyDose = new CompositeQuantityWithUnits
                {
                    Quantity = 19
                },
                NeedsHumanReview = "20",
                SpecialDispensingInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "21"
                    }
                },
                GivePerTimeUnit = "22",
                GiveRateAmount = "23",
                GiveRateUnits = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                GiveStrength = 25,
                GiveStrengthUnits = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                GiveIndication = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "27"
                    }
                },
                DispensePackageSize = 28,
                DispensePackageSizeUnit = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                DispensePackageMethod = "30",
                SupplementaryCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "31"
                    }
                },
                OriginalOrderDateTime = new DateTime(2020, 3, 2, 0, 0, 32),
                GiveDrugStrengthVolume = 33,
                GiveDrugStrengthVolumeUnits = new CodedWithExceptions
                {
                    Identifier = "34"
                },
                ControlledSubstanceSchedule = new CodedWithExceptions
                {
                    Identifier = "35"
                },
                FormularyStatus = "36",
                PharmaceuticalSubstanceAlternative = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "37"
                    }
                },
                PharmacyOfMostRecentFill = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                InitialDispenseAmount = 39,
                DispensingPharmacy = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                DispensingPharmacyAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "41"
                    }
                },
                DeliverToPatientLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "42"
                    }
                },
                DeliverToAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "43"
                    }
                },
                PharmacyOrderType = "44",
                PharmacyPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "45"
                    }
                }
            };

            ISegment actual = new RxeSegment();
            actual.FromDelimitedString("RXE|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|20200118000018|19|20|21|22|23|24|25|26|27|28|29|30|31|20200302000032|33|34|35|36|37|38|39|40|41|42|43|44|45");

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
                ISegment hl7Segment = new RxeSegment();
                hl7Segment.FromDelimitedString("RXA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RxeSegment
            {
                QuantityTiming = "1",
                GiveCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                GiveAmountMinimum = 3,
                GiveAmountMaximum = 4,
                GiveUnits = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                GiveDosageForm = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                ProvidersAdministrationInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "7"
                    }
                },
                DeliverToLocation = "8",
                SubstitutionStatus = "9",
                DispenseAmount = 10,
                DispenseUnits = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                NumberOfRefills = 12,
                OrderingProvidersDeaNumber = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "13"
                    }
                },
                PharmacistTreatmentSuppliersVerifierId = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "14"
                    }
                },
                PrescriptionNumber = "15",
                NumberOfRefillsRemaining = 16,
                NumberOfRefillsDosesDispensed = 17,
                DateTimeOfMostRecentRefillOrDoseDispensed = new DateTime(2020, 1, 18, 0, 0, 18),
                TotalDailyDose = new CompositeQuantityWithUnits
                {
                    Quantity = 19
                },
                NeedsHumanReview = "20",
                SpecialDispensingInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "21"
                    }
                },
                GivePerTimeUnit = "22",
                GiveRateAmount = "23",
                GiveRateUnits = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                GiveStrength = 25,
                GiveStrengthUnits = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                GiveIndication = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "27"
                    }
                },
                DispensePackageSize = 28,
                DispensePackageSizeUnit = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                DispensePackageMethod = "30",
                SupplementaryCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "31"
                    }
                },
                OriginalOrderDateTime = new DateTime(2020, 3, 2, 0, 0, 32),
                GiveDrugStrengthVolume = 33,
                GiveDrugStrengthVolumeUnits = new CodedWithExceptions
                {
                    Identifier = "34"
                },
                ControlledSubstanceSchedule = new CodedWithExceptions
                {
                    Identifier = "35"
                },
                FormularyStatus = "36",
                PharmaceuticalSubstanceAlternative = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "37"
                    }
                },
                PharmacyOfMostRecentFill = new CodedWithExceptions
                {
                    Identifier = "38"
                },
                InitialDispenseAmount = 39,
                DispensingPharmacy = new CodedWithExceptions
                {
                    Identifier = "40"
                },
                DispensingPharmacyAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "41"
                    }
                },
                DeliverToPatientLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "42"
                    }
                },
                DeliverToAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "43"
                    }
                },
                PharmacyOrderType = "44",
                PharmacyPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "45"
                    }
                }
            };

            string expected = "RXE|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|20200118000018|19|20|21|22|23|24|25|26|27|28|29|30|31|20200302000032|33|34|35|36|37|38|39|40|41|42|43|44|45";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
