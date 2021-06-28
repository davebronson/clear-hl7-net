using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class CtrSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new CtrSegment
            {
                ContractIdentifier = new EntityIdentifier
                {
                    EntityId = "1"
                },
                ContractDescription = "2",
                ContractStatus = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                EffectiveDate = new DateTime(2020, 4, 4, 0, 0, 4),
                ExpirationDate = new DateTime(2020, 5, 5, 0, 0, 5),
                ContractOwnerName = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "6"
                    }
                },
                ContractOriginatorName = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "7"
                    }
                },
                SupplierType = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                ContractType = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                FreeOnBoardFreightTerms = new CodedWithNoExceptions
                {
                    Identifier = "10"
                },
                PriceProtectionDate = new DateTime(2020, 11, 11, 0, 0, 11),
                FixedPriceContractIndicator = new CodedWithNoExceptions
                {
                    Identifier = "12"
                },
                GroupPurchasingOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "13"
                },
                MaximumMarkup = new MoneyOrPercentage
                {
                    MoneyOrPercentageIndicator = "14"
                },
                ActualMarkup = new MoneyOrPercentage
                {
                    MoneyOrPercentageIndicator = "15"
                },
                Corporation = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "16"
                    }
                },
                ParentOfCorporation = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "17"
                },
                PricingTierLevel = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                ContractPriority = "19",
                ClassOfTrade = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                AssociatedContractId = new EntityIdentifier
                {
                    EntityId = "21"
                }
            };
            ISegment actual = new CtrSegment().FromDelimitedString("CTR|1|2|3|20200404000004|20200505000005|6|7|8|9|10|20201111000011|12|13|14|15|16|17|18|19|20|21");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new CtrSegment
            {
                ContractIdentifier = new EntityIdentifier
                {
                    EntityId = "1"
                },
                ContractDescription = "2",
                ContractStatus = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                EffectiveDate = new DateTime(2020, 4, 4, 0, 0, 4),
                ExpirationDate = new DateTime(2020, 5, 5, 0, 0, 5),
                ContractOwnerName = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "6"
                    }
                },
                ContractOriginatorName = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "7"
                    }
                },
                SupplierType = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                ContractType = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                FreeOnBoardFreightTerms = new CodedWithNoExceptions
                {
                    Identifier = "10"
                },
                PriceProtectionDate = new DateTime(2020, 11, 11, 0, 0, 11),
                FixedPriceContractIndicator = new CodedWithNoExceptions
                {
                    Identifier = "12"
                },
                GroupPurchasingOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "13"
                },
                MaximumMarkup = new MoneyOrPercentage
                {
                    MoneyOrPercentageIndicator = "14"
                },
                ActualMarkup = new MoneyOrPercentage
                {
                    MoneyOrPercentageIndicator = "15"
                },
                Corporation = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "16"
                    }
                },
                ParentOfCorporation = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "17"
                },
                PricingTierLevel = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                ContractPriority = "19",
                ClassOfTrade = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                AssociatedContractId = new EntityIdentifier
                {
                    EntityId = "21"
                }
            };

            string expected = "CTR|1|2|3|20200404000004|20200505000005|6|7|8|9|10|20201111000011|12|13|14|15|16|17|18|19|20|21";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
