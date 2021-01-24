using System;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ExtendedTelecommunicationNumberTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ExtendedTelecommunicationNumber
            {
                TelephoneNumber = "1",
                TelecommunicationUseCode = "2",
                TelecommunicationEquipmentType = "3",
                CommunicationAddress = "4",
                CountryCode = 5,
                AreaCityCode = 6,
                LocalNumber = 7,
                Extension = 8,
                AnyText = "9",
                ExtensionPrefix = "10",
                SpeedDialCode = "11",
                UnformattedTelephoneNumber = "12",
                EffectiveStartDate = new DateTime(2020, 1, 13, 0, 0, 13),
                ExpirationDate = new DateTime(2020, 1, 14, 0, 0, 14),
                ExpirationReason = new CodedWithExceptions
                {
                    Identifier = "15"
                },
                ProtectionCode = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                SharedTelecommunicationIdentifier = new EntityIdentifier
                {
                    EntityId = "17"
                },
                PreferenceOrder = 18
            };

            string expected = "1^2^3^4^5^6^7^8^9^10^11^12^20200113000013^20200114000014^15^16^17^18";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
