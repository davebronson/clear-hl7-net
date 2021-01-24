using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class EntityIdentifierPairTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new EntityIdentifierPair
            {
                PlacerAssignedIdentifier = new EntityIdentifier
                {
                    EntityId = "1"
                },
                FillerAssignedIdentifier = new EntityIdentifier
                {
                    EntityId = "2"
                }
            };

            string expected = "1^2";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
