using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class CompositeIdNumberAndNameSimplifiedTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new CompositeIdNumberAndNameSimplified
            {
                IdNumber = "1",
                FamilyName = "2",
                GivenName = "3",
                SecondAndFurtherGivenNamesOrInitialsThereof = "4",
                Suffix = "5",
                Prefix = "6",
                Degree = "7",
                SourceTable = "8",
                AssigningAuthorityNamespaceId = "9",
                AssigningAuthorityUniversalId = "10",
                AssigningAuthorityUniversalIdType = "11"
            };

            IType actual = new CompositeIdNumberAndNameSimplified();
            actual.FromDelimitedString("1^2^3^4^5^6^7^8^9^10^11");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new CompositeIdNumberAndNameSimplified
            {
                IdNumber = "1",
                FamilyName = "2",
                GivenName = "3",
                SecondAndFurtherGivenNamesOrInitialsThereof = "4",
                Suffix = "5",
                Prefix = "6",
                Degree = "7",
                SourceTable = "8",
                AssigningAuthorityNamespaceId = "9",
                AssigningAuthorityUniversalId = "10",
                AssigningAuthorityUniversalIdType = "11"
            };

            string expected = "1^2^3^4^5^6^7^8^9^10^11";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
