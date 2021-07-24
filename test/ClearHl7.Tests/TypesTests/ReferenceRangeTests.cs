using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ReferenceRangeTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new ReferenceRange
            {
                NumericRange = new NumericRange
                {
                    IsSubcomponent = true,
                    LowValue = 1
                },
                AdministrativeSex = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "2"
                },
                AgeRange = new NumericRange
                {
                    IsSubcomponent = true,
                    LowValue = 3
                },
                GestationalAgeRange = new NumericRange
                {
                    IsSubcomponent = true,
                    LowValue = 4
                },
                Species = "5",
                RaceSubspecies = "6",
                Conditions = new Text
                {
                    IsSubcomponent = true,
                    Value = "7"
                }
            };

            IType actual = new ReferenceRange();
            actual.FromDelimitedString("1^2^3^4^5^6^7");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ReferenceRange
            {
                NumericRange = new NumericRange
                {
                    LowValue = 1
                },
                AdministrativeSex = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AgeRange = new NumericRange
                {
                    LowValue = 3
                },
                GestationalAgeRange = new NumericRange
                {
                    LowValue = 4
                },
                Species = "5",
                RaceSubspecies = "6",
                Conditions = new Text
                {
                    Value = "7"
                }
            };

            string expected = "1^2^3^4^5^6^7";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
