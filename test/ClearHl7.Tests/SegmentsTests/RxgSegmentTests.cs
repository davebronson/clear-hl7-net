using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RxgSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RxgSegment
            {
                GiveSubIdCounter = 1,
                DispenseSubIdCounter = 2,
                QuantityTiming = "3",
                GiveCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                GiveAmountMinimum = 5,
                GiveAmountMaximum = 6,
                GiveUnits = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                GiveDosageForm = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                AdministrationNotes = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                SubstitutionStatus = "10",
                DispenseToLocation = "11",
                NeedsHumanReview = "12",
                SpecialAdministrationInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                },
                GivePerTimeUnit = "14",
                GiveRateAmount = "15",
                GiveRateUnits = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                GiveStrength = 17,
                GiveStrengthUnits = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                SubstanceLotNumber = new string[]
                {
                    "19"
                },
                SubstanceExpirationDate = new DateTime[]
                {
                    new DateTime(2020, 1, 20, 0, 0, 20)
                },
                SubstanceManufacturerName = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "21"
                    }
                },
                Indication = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "22"
                    }
                },
                GiveDrugStrengthVolume = 23,
                GiveDrugStrengthVolumeUnits = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                GiveBarcodeIdentifier = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                PharmacyOrderType = "26",
                DispenseToPharmacy = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                DispenseToPharmacyAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "28"
                    }
                },
                DeliverToPatientLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "29"
                    }
                },
                DeliverToAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "30"
                    }
                },
                GiveTagIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "31"
                    }
                },
                DispenseAmount = 32,
                DispenseUnits = new CodedWithExceptions
                {
                    Identifier = "33"
                }
            };

            ISegment actual = new RxgSegment();
            actual.FromDelimitedString("RXG|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20200120000020|21|22|23|24|25|26|27|28|29|30|31|32|33");

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
                ISegment hl7Segment = new RxgSegment();
                hl7Segment.FromDelimitedString("RXA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RxgSegment
            {
                GiveSubIdCounter = 1,
                DispenseSubIdCounter = 2,
                QuantityTiming = "3",
                GiveCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                GiveAmountMinimum = 5,
                GiveAmountMaximum = 6,
                GiveUnits = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                GiveDosageForm = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                AdministrationNotes = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                SubstitutionStatus = "10",
                DispenseToLocation = "11",
                NeedsHumanReview = "12",
                SpecialAdministrationInstructions = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                },
                GivePerTimeUnit = "14",
                GiveRateAmount = "15",
                GiveRateUnits = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                GiveStrength = 17,
                GiveStrengthUnits = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                SubstanceLotNumber = new string[]
                {
                    "19"
                },
                SubstanceExpirationDate = new DateTime[]
                {
                    new DateTime(2020, 1, 20, 0, 0, 20)
                },
                SubstanceManufacturerName = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "21"
                    }
                },
                Indication = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "22"
                    }
                },
                GiveDrugStrengthVolume = 23,
                GiveDrugStrengthVolumeUnits = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                GiveBarcodeIdentifier = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                PharmacyOrderType = "26",
                DispenseToPharmacy = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                DispenseToPharmacyAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "28"
                    }
                },
                DeliverToPatientLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "29"
                    }
                },
                DeliverToAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "30"
                    }
                },
                GiveTagIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "31"
                    }
                },
                DispenseAmount = 32,
                DispenseUnits = new CodedWithExceptions
                {
                    Identifier = "33"
                }
            };

            string expected = "RXG|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20200120000020|21|22|23|24|25|26|27|28|29|30|31|32|33";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
