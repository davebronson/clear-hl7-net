using ClearHl7.V260.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class OrderSequenceDefinitionTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new OrderSequenceDefinition
            {
                SequenceResultsFlag = "1",
                PlacerOrderNumberEntityIdentifier = "2",
                PlacerOrderNumberNamespaceId = "3",
                FillerOrderNumberEntityIdentifier = "4",
                FillerOrderNumberNamespaceId = "5",
                SequenceConditionValue = "6",
                MaximumNumberOfRepeats = 7M,
                PlacerOrderNumberUniversalId = "8",
                PlacerOrderNumberUniversalIdType = "9",
                FillerOrderNumberUniversalId = "10",
                FillerOrderNumberUniversalIdType = "11"
            };

            IType actual = new OrderSequenceDefinition();
            actual.FromDelimitedString("1^2^3^4^5^6^7^8^9^10^11");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new OrderSequenceDefinition
            {
                SequenceResultsFlag = "1",
                PlacerOrderNumberEntityIdentifier = "2",
                PlacerOrderNumberNamespaceId = "3",
                FillerOrderNumberEntityIdentifier = "4",
                FillerOrderNumberNamespaceId = "5",
                SequenceConditionValue = "6",
                MaximumNumberOfRepeats = 7M,
                PlacerOrderNumberUniversalId = "8",
                PlacerOrderNumberUniversalIdType = "9",
                FillerOrderNumberUniversalId = "10",
                FillerOrderNumberUniversalIdType = "11"
            };

            string expected = "1^2^3^4^5^6^7^8^9^10^11";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
