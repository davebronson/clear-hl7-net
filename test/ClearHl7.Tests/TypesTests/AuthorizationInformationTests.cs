using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class AuthorizationInformationTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new AuthorizationInformation
            {
                AuthorizationNumber = "1",
                Date = new DateTime(2020, 2, 1),
                Source = "3"
            };

            IType actual = new AuthorizationInformation();
            actual.FromDelimitedString("1^20200201^3");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new AuthorizationInformation
            {
                AuthorizationNumber = "1",
                Date = new DateTime(2020, 2, 1),
                Source = "3"
            };

            string expected = "1^20200201^3";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
