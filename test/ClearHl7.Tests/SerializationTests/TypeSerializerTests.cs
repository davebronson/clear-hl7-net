using ClearHl7.Serialization;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SerializationTests
{
    public class TypeSerializerTests
    {
        /// <summary>
        /// Validates that Deserialize() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void Deserialize_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new Address()
            {
                StreetAddress = "1",
                OtherDesignation = "2",
                City = "3",
                StateOrProvince = "4",
                ZipOrPostalCode = "5",
                Country = "6",
                AddressType = "7",
                OtherGeographicDesignation = "8"
            };

            string delimitedString = "1^2^3^4^5^6^7^8";
            IType actual = TypeSerializer.Deserialize<Address>(delimitedString, false, null);

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that Serialize() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void Serialize_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            Address hl7Type = new()
            {
                StreetAddress = "1",
                OtherDesignation = "2",
                City = "3",
                StateOrProvince = "4",
                ZipOrPostalCode = "5",
                Country = "6",
                AddressType = "7",
                OtherGeographicDesignation = "8"
            };

            string expected = "1^2^3^4^5^6^7^8";
            string actual = TypeSerializer.Serialize(hl7Type);

            Assert.Equal(expected, actual);
        }
    }
}
