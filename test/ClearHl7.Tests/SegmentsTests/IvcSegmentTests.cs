using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class IvcSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new IvcSegment
            {
                ProviderInvoiceNumber = new EntityIdentifier
                {
                    EntityId = "1"
                },
                PayerInvoiceNumber = new EntityIdentifier
                {
                    EntityId = "2"
                },
                ContractAgreementNumber = new EntityIdentifier
                {
                    EntityId = "3"
                },
                InvoiceControl = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                InvoiceReason = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                InvoiceType = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                InvoiceDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                InvoiceAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 8
                    }
                },
                PaymentTerms = "9",
                ProviderOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "10"
                },
                PayerOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "11"
                },
                Attention = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "12"
                },
                LastInvoiceIndicator = "13",
                InvoiceBookingPeriod = new DateTime(2020, 1, 14, 0, 0, 14),
                Origin = "15",
                InvoiceFixedAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 16
                    }
                },
                SpecialCosts = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 17
                    }
                },
                AmountForDoctorsTreatment = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 18
                    }
                },
                ResponsiblePhysician = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "19"
                },
                CostCenter = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "20"
                },
                InvoicePrepaidAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 21
                    }
                },
                TotalInvoiceAmountWithoutPrepaidAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 22
                    }
                },
                TotalAmountOfVat = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 23
                    }
                },
                VatRatesApplied = new decimal[]
                {
                    24
                },
                BenefitGroup = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                ProviderTaxId = "26",
                PayerTaxId = "27",
                ProviderTaxStatus = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                PayerTaxStatus = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                SalesTaxId = "30"
            };

            ISegment actual = new IvcSegment();
            actual.FromDelimitedString("IVC|1|2|3|4|5|6|20200707000007|8|9|10|11|12|13|20200114000014|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30");

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
                ISegment hl7Segment = new IvcSegment();
                hl7Segment.FromDelimitedString("IVA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new IvcSegment
            {
                ProviderInvoiceNumber = new EntityIdentifier
                {
                    EntityId = "1"
                },
                PayerInvoiceNumber = new EntityIdentifier
                {
                    EntityId = "2"
                },
                ContractAgreementNumber = new EntityIdentifier
                {
                    EntityId = "3"
                },
                InvoiceControl = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                InvoiceReason = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                InvoiceType = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                InvoiceDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                InvoiceAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 8
                    }
                },
                PaymentTerms = "9",
                ProviderOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "10"
                },
                PayerOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "11"
                },
                Attention = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "12"
                },
                LastInvoiceIndicator = "13",
                InvoiceBookingPeriod = new DateTime(2020, 1, 14, 0, 0, 14),
                Origin = "15",
                InvoiceFixedAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 16
                    }
                },
                SpecialCosts = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 17
                    }
                },
                AmountForDoctorsTreatment = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 18
                    }
                },
                ResponsiblePhysician = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "19"
                },
                CostCenter = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "20"
                },
                InvoicePrepaidAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 21
                    }
                },
                TotalInvoiceAmountWithoutPrepaidAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 22
                    }
                },
                TotalAmountOfVat = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 23
                    }
                },
                VatRatesApplied = new decimal[]
                {
                    24
                },
                BenefitGroup = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                ProviderTaxId = "26",
                PayerTaxId = "27",
                ProviderTaxStatus = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                PayerTaxStatus = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                SalesTaxId = "30"
            };

            string expected = "IVC|1|2|3|4|5|6|20200707000007|8|9|10|11|12|13|20200114000014|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
