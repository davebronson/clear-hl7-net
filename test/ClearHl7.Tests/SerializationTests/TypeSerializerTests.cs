using System;
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
            IType actual = TypeSerializer.Deserialize<Address>(delimitedString, false);

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that calling Deserialize() with a null input results in an ArgumentNullException being thrown.
        /// </summary>
        [Fact]
        public void DeserializeOverload1_WithNullInput_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                IType result = TypeSerializer.Deserialize<Address>(null, false);
            });
        }

        /// <summary>
        /// Validates that calling Deserialize() with a null input results in an ArgumentNullException being thrown.
        /// </summary>
        [Fact]
        public void DeserializeOverload2_WithNullInput_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                IType result = TypeSerializer.Deserialize<Address>(null, false, null);
            });
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

        /// <summary>
        /// Validates that calling Serialize() with a null input results in an ArgumentNullException being thrown.
        /// </summary>
        [Fact]
        public void Serialize_WithNullInput_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                string result = TypeSerializer.Serialize(null);
            });
        }
    }
}
