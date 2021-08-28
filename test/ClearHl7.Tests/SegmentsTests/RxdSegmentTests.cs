using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RxdSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RxdSegment
            {
                DispenseSubIdCounter = 1,
                DispenseGiveCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                DateTimeDispensed = new DateTime(2020, 3, 3, 0, 0, 3),
                ActualDispenseAmount = 4,
                ActualDispenseUnits = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ActualDosageForm = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                PrescriptionNumber = "7",
                NumberOfRefillsRemaining = 8,
                DispenseNotes = new string[]
                {
                    "9"
                },
                DispensingProvider = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "10"
                    }
                },
                SubstitutionStatus = "11",
                TotalDailyDose = new CompositeQuantityWithUnits
                {
                    Quantity = 12
                },
                DispenseToLocation = "13",
                NeedsHumanReview = "14",
                SpecialDispensingInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "15"
                    }
                },
                ActualStrength = 16,
                ActualStrengthUnit = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                SubstanceLotNumber = new string[]
                {
                    "18"
                },
                SubstanceExpirationDate = new DateTime[]
                {
                    new DateTime(2020, 1, 19, 0, 0, 19)
                },
                SubstanceManufacturerName = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "20"
                    }
                },
                Indication = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "21"
                    }
                },
                DispensePackageSize = 22,
                DispensePackageSizeUnit = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                DispensePackageMethod = "24",
                SupplementaryCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "25"
                    }
                },
                InitiatingLocation = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                PackagingAssemblyLocation = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                ActualDrugStrengthVolume = 28,
                ActualDrugStrengthVolumeUnits = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                DispenseToPharmacy = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                DispenseToPharmacyAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "31"
                    }
                },
                PharmacyOrderType = "32",
                DispenseType = new CodedWithExceptions
                {
                    Identifier = "33"
                },
                PharmacyPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "34"
                    }
                },
                DispenseTagIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "35"
                    }
                }
            };

            ISegment actual = new RxdSegment();
            actual.FromDelimitedString("RXD|1|2|20200303000003|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|20200119000019|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35");

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
                ISegment hl7Segment = new RxdSegment();
                hl7Segment.FromDelimitedString("RXA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RxdSegment
            {
                DispenseSubIdCounter = 1,
                DispenseGiveCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                DateTimeDispensed = new DateTime(2020, 3, 3, 0, 0, 3),
                ActualDispenseAmount = 4,
                ActualDispenseUnits = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ActualDosageForm = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                PrescriptionNumber = "7",
                NumberOfRefillsRemaining = 8,
                DispenseNotes = new string[]
                {
                    "9"
                },
                DispensingProvider = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "10"
                    }
                },
                SubstitutionStatus = "11",
                TotalDailyDose = new CompositeQuantityWithUnits
                {
                    Quantity = 12
                },
                DispenseToLocation = "13",
                NeedsHumanReview = "14",
                SpecialDispensingInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "15"
                    }
                },
                ActualStrength = 16,
                ActualStrengthUnit = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                SubstanceLotNumber = new string[]
                {
                    "18"
                },
                SubstanceExpirationDate = new DateTime[]
                {
                    new DateTime(2020, 1, 19, 0, 0, 19)
                },
                SubstanceManufacturerName = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "20"
                    }
                },
                Indication = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "21"
                    }
                },
                DispensePackageSize = 22,
                DispensePackageSizeUnit = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                DispensePackageMethod = "24",
                SupplementaryCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "25"
                    }
                },
                InitiatingLocation = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                PackagingAssemblyLocation = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                ActualDrugStrengthVolume = 28,
                ActualDrugStrengthVolumeUnits = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                DispenseToPharmacy = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                DispenseToPharmacyAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "31"
                    }
                },
                PharmacyOrderType = "32",
                DispenseType = new CodedWithExceptions
                {
                    Identifier = "33"
                },
                PharmacyPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "34"
                    }
                },
                DispenseTagIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "35"
                    }
                }
            };

            string expected = "RXD|1|2|20200303000003|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|20200119000019|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
