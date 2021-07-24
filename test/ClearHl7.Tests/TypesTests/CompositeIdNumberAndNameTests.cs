using ClearHl7.V240.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class CompositeIdNumberAndNameTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new CompositeIdNumberAndName
            {
                IdNumber = "1",
                FamilyName = "2",
                GivenName = "3",
                SecondAndFurtherGivenNamesOrInitialsThereof = "4",
                Suffix = "5",
                Prefix = "6",
                Degree = "7",
                SourceTable = "8",
                AssigningAuthority = new HierarchicDesignator
                {
                    IsSubcomponent = true,
                    NamespaceId = "9"
                }
            };

            IType actual = new CompositeIdNumberAndName();
            actual.FromDelimitedString("1^2^3^4^5^6^7^8^9");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new CompositeIdNumberAndName
            {
                IdNumber = "1",
                FamilyName = "2",
                GivenName = "3",
                SecondAndFurtherGivenNamesOrInitialsThereof = "4",
                Suffix = "5",
                Prefix = "6",
                Degree = "7",
                SourceTable = "8",
                AssigningAuthority = new HierarchicDesignator
                {
                    NamespaceId = "9"
                }
            };

            string expected = "1^2^3^4^5^6^7^8^9";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
