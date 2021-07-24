using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ExtendedAddressTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new ExtendedAddress
            {
                StreetAddress = new StreetAddress
                {
                    IsSubcomponent = true,
                    StreetOrMailingAddress = "1"
                },
                OtherDesignation = "2",
                City = "3",
                StateOrProvince = "4",
                ZipOrPostalCode = "5",
                Country = "6",
                AddressType = "7",
                OtherGeographicDesignation = "8",
                CountyParishCode = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "9"
                },
                CensusTract = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "10"
                },
                AddressRepresentationCode = "11",
                AddressValidityRange = new DateTimeRange
                {
                    IsSubcomponent = true,
                    RangeStartDateTime = new DateTime(2020, 12, 12, 0, 0, 12)
                },
                EffectiveDate = new DateTime(2020, 1, 13, 0, 0, 13),
                ExpirationDate = new DateTime(2020, 1, 14, 0, 0, 14),
                ExpirationReason = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "15"
                },
                TemporaryIndicator = "16",
                BadAddressIndicator = "17",
                AddressUsage = "18",
                Addressee = "19",
                Comment = "20",
                PreferenceOrder = 21,
                ProtectionCode = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "22"
                },
                AddressIdentifier = new EntityIdentifier
                {
                    IsSubcomponent = true,
                    EntityId = "23"
                }
            };

            IType actual = new ExtendedAddress();
            actual.FromDelimitedString("1^2^3^4^5^6^7^8^9^10^11^20201212000012^20200113000013^20200114000014^15^16^17^18^19^20^21^22^23");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ExtendedAddress
            {
                StreetAddress = new StreetAddress
                {
                    StreetOrMailingAddress = "1"
                },
                OtherDesignation = "2",
                City = "3",
                StateOrProvince = "4",
                ZipOrPostalCode = "5",
                Country = "6",
                AddressType = "7",
                OtherGeographicDesignation = "8",
                CountyParishCode = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                CensusTract = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                AddressRepresentationCode = "11",
                AddressValidityRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 12, 12, 0, 0, 12)
                },
                EffectiveDate = new DateTime(2020, 1, 13, 0, 0, 13),
                ExpirationDate = new DateTime(2020, 1, 14, 0, 0, 14),
                ExpirationReason = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                TemporaryIndicator = "16",
                BadAddressIndicator = "17",
                AddressUsage = "18",
                Addressee = "19",
                Comment = "20",
                PreferenceOrder = 21,
                ProtectionCode = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                AddressIdentifier = new EntityIdentifier
                {
                    EntityId = "23"
                }
            };

            string expected = "1^2^3^4^5^6^7^8^9^10^11^20201212000012^20200113000013^20200114000014^15^16^17^18^19^20^21^22^23";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
