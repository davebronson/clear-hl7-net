using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class OccurrenceCodeAndDateTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new OccurrenceCodeAndDate
            {
                OccurrenceCode = new CodedWithNoExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "1"
                },
                OccurrenceDate = new DateTime(2020, 2, 22)
            };

            IType actual = new OccurrenceCodeAndDate();
            actual.FromDelimitedString("1^20200222");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new OccurrenceCodeAndDate
            {
                OccurrenceCode = new CodedWithNoExceptions
                {
                    Identifier = "1"
                },
                OccurrenceDate = new DateTime(2020, 2, 22)
            };

            string expected = "1^20200222";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
