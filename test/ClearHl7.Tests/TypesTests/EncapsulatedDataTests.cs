using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class EncapsulatedDataTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new EncapsulatedData
            {
                SourceApplication = new HierarchicDesignator
                {
                    NamespaceId = "1"
                },
                TypeOfData = "2",
                DataSubtype = "3",
                Encoding = "4",
                Data = new Text
                {
                    Value = "5"
                }
            };

            string expected = "1^2^3^4^5";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
