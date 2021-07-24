using ClearHl7.V240.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ParentOrderTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new ParentOrder
            {
                PlacerAssignedIdentifier = new EntityIdentifier
                {
                    IsSubcomponent = true,
                    EntityId = "1"
                },
                FillerAssignedIdentifier = new EntityIdentifier
                {
                    IsSubcomponent = true,
                    EntityId = "2"
                }
            };

            IType actual = new ParentOrder();
            actual.FromDelimitedString("1^2");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ParentOrder
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
