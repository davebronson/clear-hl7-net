using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RxaSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RxaSegment
            {
                GiveSubIdCounter = 1,
                AdministrationSubIdCounter = 2,
                DateTimeStartOfAdministration = new DateTime(2020, 3, 3, 0, 0, 3),
                DateTimeEndOfAdministration = new DateTime(2020, 4, 4, 0, 0, 4),
                AdministeredCode = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                AdministeredAmount = 6,
                AdministeredUnits = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                AdministeredDosageForm = new CodedWithExceptions
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
                AdministeringProvider = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "10"
                    }
                },
                AdministeredAtLocation = "11",
                AdministeredPerTimeUnit = "12",
                AdministeredStrength = 13,
                AdministeredStrengthUnits = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                SubstanceLotNumber = new string[]
                {
                    "15"
                },
                SubstanceExpirationDate = new DateTime[]
                {
                    new DateTime(2020,1,16,0,0,16)
                },
                SubstanceManufacturerName = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "17"
                    }
                },
                SubstanceTreatmentRefusalReason = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "18"
                    }
                },
                Indication = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "19"
                    }
                },
                CompletionStatus = "20",
                ActionCodeRxa = "21",
                SystemEntryDateTime = new DateTime(2020, 1, 22, 0, 0, 22),
                AdministeredDrugStrengthVolume = 23,
                AdministeredDrugStrengthVolumeUnits = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                AdministeredBarcodeIdentifier = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                PharmacyOrderType = "26",
                AdministerAt = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "27"
                    }
                },
                AdministeredAtAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "28"
                    }
                },
                AdministeredTagIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "29"
                    }
                }
            };

            ISegment actual = new RxaSegment();
            actual.FromDelimitedString("RXA|1|2|20200303000003|20200404000004|5|6|7|8|9|10|11|12|13|14|15|20200116000016|17|18|19|20|21|20200122000022|23|24|25|26|27|28|29");

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
                ISegment hl7Segment = new RxaSegment();
                hl7Segment.FromDelimitedString("RAA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RxaSegment
            {
                GiveSubIdCounter = 1,
                AdministrationSubIdCounter = 2,
                DateTimeStartOfAdministration = new DateTime(2020, 3, 3, 0, 0, 3),
                DateTimeEndOfAdministration = new DateTime(2020, 4, 4, 0, 0, 4),
                AdministeredCode = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                AdministeredAmount = 6,
                AdministeredUnits = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                AdministeredDosageForm = new CodedWithExceptions
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
                AdministeringProvider = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "10"
                    }
                },
                AdministeredAtLocation = "11",
                AdministeredPerTimeUnit = "12",
                AdministeredStrength = 13,
                AdministeredStrengthUnits = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                SubstanceLotNumber = new string[]
                {
                    "15"
                },
                SubstanceExpirationDate = new DateTime[]
                {
                    new DateTime(2020,1,16,0,0,16)
                },
                SubstanceManufacturerName = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "17"
                    }
                },
                SubstanceTreatmentRefusalReason = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "18"
                    }
                },
                Indication = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "19"
                    }
                },
                CompletionStatus = "20",
                ActionCodeRxa = "21",
                SystemEntryDateTime = new DateTime(2020, 1, 22, 0, 0, 22),
                AdministeredDrugStrengthVolume = 23,
                AdministeredDrugStrengthVolumeUnits = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                AdministeredBarcodeIdentifier = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                PharmacyOrderType = "26",
                AdministerAt = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "27"
                    }
                },
                AdministeredAtAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "28"
                    }
                },
                AdministeredTagIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "29"
                    }
                }
            };

            string expected = "RXA|1|2|20200303000003|20200404000004|5|6|7|8|9|10|11|12|13|14|15|20200116000016|17|18|19|20|21|20200122000022|23|24|25|26|27|28|29";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
