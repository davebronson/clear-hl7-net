using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class ItmSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new ItmSegment
            {
                ItemIdentifier = new EntityIdentifier
                {
                    EntityId = "1"
                },
                ItemDescription = "2",
                ItemStatus = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ItemType = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                ItemCategory = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                SubjectToExpirationIndicator = new CodedWithNoExceptions
                {
                    Identifier = "6"
                },
                ManufacturerIdentifier = new EntityIdentifier
                {
                    EntityId = "7"
                },
                ManufacturerName = "8",
                ManufacturerCatalogNumber = "9",
                ManufacturerLabelerIdentificationCode = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                PatientChargeableIndicator = new CodedWithNoExceptions
                {
                    Identifier = "11"
                },
                TransactionCode = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                TransactionAmountUnit = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 13
                    }
                },
                StockedItemIndicator = new CodedWithNoExceptions
                {
                    Identifier = "14"
                },
                SupplyRiskCodes = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                ApprovingRegulatoryAgency = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "16"
                    }
                },
                LatexIndicator = new CodedWithNoExceptions
                {
                    Identifier = "17"
                },
                RulingAct = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "18"
                    }
                },
                ItemNaturalAccountCode = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                ApprovedToBuyQuantity = 20,
                ApprovedToBuyPrice = new Money
                {
                    Quantity = 21
                },
                TaxableItemIndicator = new CodedWithNoExceptions
                {
                    Identifier = "22"
                },
                FreightChargeIndicator = new CodedWithNoExceptions
                {
                    Identifier = "23"
                },
                ItemSetIndicator = new CodedWithNoExceptions
                {
                    Identifier = "24"
                },
                ItemSetIdentifier = new EntityIdentifier
                {
                    EntityId = "25"
                },
                TrackDepartmentUsageIndicator = new CodedWithNoExceptions
                {
                    Identifier = "26"
                },
                ProcedureCode = new CodedWithNoExceptions
                {
                    Identifier = "27"
                },
                ProcedureCodeModifier = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "28"
                    }
                },
                SpecialHandlingCode = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                HazardousIndicator = new CodedWithNoExceptions
                {
                    Identifier = "30"
                },
                SterileIndicator = new CodedWithNoExceptions
                {
                    Identifier = "31"
                },
                MaterialDataSafetySheetNumber = new EntityIdentifier
                {
                    EntityId = "32"
                },
                UnitedNationsStandardProductsAndServicesCode = new CodedWithExceptions
                {
                    Identifier = "33"
                },
                ContractDate = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 3, 4, 0, 0, 34)
                },
                ManufacturerContactName = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "35"
                    }
                },
                ManufacturerContactInformation = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "36"
                },
                ClassOfTrade = "37",
                FieldLevelEventCode = "38"
            };

            ISegment actual = new ItmSegment();
            actual.FromDelimitedString("ITM|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|20200304000034|35|36|37|38");

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
                ISegment hl7Segment = new ItmSegment();
                hl7Segment.FromDelimitedString("ITA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ItmSegment
            {
                ItemIdentifier = new EntityIdentifier
                {
                    EntityId = "1"
                },
                ItemDescription = "2",
                ItemStatus = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ItemType = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                ItemCategory = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                SubjectToExpirationIndicator = new CodedWithNoExceptions
                {
                    Identifier = "6"
                },
                ManufacturerIdentifier = new EntityIdentifier
                {
                    EntityId = "7"
                },
                ManufacturerName = "8",
                ManufacturerCatalogNumber = "9",
                ManufacturerLabelerIdentificationCode = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                PatientChargeableIndicator = new CodedWithNoExceptions
                {
                    Identifier = "11"
                },
                TransactionCode = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                TransactionAmountUnit = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 13
                    }
                },
                StockedItemIndicator = new CodedWithNoExceptions
                {
                    Identifier = "14"
                },
                SupplyRiskCodes = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                ApprovingRegulatoryAgency = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "16"
                    }
                },
                LatexIndicator = new CodedWithNoExceptions
                {
                    Identifier = "17"
                },
                RulingAct = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "18"
                    }
                },
                ItemNaturalAccountCode = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                ApprovedToBuyQuantity = 20,
                ApprovedToBuyPrice = new Money
                {
                    Quantity = 21
                },
                TaxableItemIndicator = new CodedWithNoExceptions
                {
                    Identifier = "22"
                },
                FreightChargeIndicator = new CodedWithNoExceptions
                {
                    Identifier = "23"
                },
                ItemSetIndicator = new CodedWithNoExceptions
                {
                    Identifier = "24"
                },
                ItemSetIdentifier = new EntityIdentifier
                {
                    EntityId = "25"
                },
                TrackDepartmentUsageIndicator = new CodedWithNoExceptions
                {
                    Identifier = "26"
                },
                ProcedureCode = new CodedWithNoExceptions
                {
                    Identifier = "27"
                },
                ProcedureCodeModifier = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "28"
                    }
                },
                SpecialHandlingCode = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                HazardousIndicator = new CodedWithNoExceptions
                {
                    Identifier = "30"
                },
                SterileIndicator = new CodedWithNoExceptions
                {
                    Identifier = "31"
                },
                MaterialDataSafetySheetNumber = new EntityIdentifier
                {
                    EntityId = "32"
                },
                UnitedNationsStandardProductsAndServicesCode = new CodedWithExceptions
                {
                    Identifier = "33"
                },
                ContractDate = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 3, 4, 0, 0, 34)
                },
                ManufacturerContactName = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "35"
                    }
                },
                ManufacturerContactInformation = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "36"
                },
                ClassOfTrade = "37",
                FieldLevelEventCode = "38"
            };

            string expected = "ITM|1|2|3|4|5|6|7|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|20200304000034|35|36|37|38";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
