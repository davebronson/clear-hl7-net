using ClearHl7.V260.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class SpecimenSourceTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new SpecimenSource
            {
                SpecimenSourceNameOrCode = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "1"
                },
                Additives = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "2"
                },
                SpecimenCollectionMethod = new Text
                {
                    IsSubcomponent = true,
                    Value = "3"
                },
                BodySite = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "4"
                },
                SiteModifier = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "5"
                },
                CollectionMethodModifierCode = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "6"
                },
                SpecimenRole = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "7"
                }
            };

            IType actual = new SpecimenSource();
            actual.FromDelimitedString("1^2^3^4^5^6^7");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new SpecimenSource
            {
                SpecimenSourceNameOrCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                Additives = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                SpecimenCollectionMethod = new Text
                {
                    Value = "3"
                },
                BodySite = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                SiteModifier = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                CollectionMethodModifierCode = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                SpecimenRole = new CodedWithExceptions
                {
                    Identifier = "7"
                }
            };

            string expected = "1^2^3^4^5^6^7";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
