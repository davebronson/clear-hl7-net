using ClearHl7.V260.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class SpecimentSourceTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new SpecimentSource
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
