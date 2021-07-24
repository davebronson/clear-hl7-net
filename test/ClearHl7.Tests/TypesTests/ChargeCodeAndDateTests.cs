using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class ChargeCodeAndDateTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new ChargeCodeAndDate
            {
                InvocationEvent = "1",
                Datetime = new DateTime(2020, 2, 1, 0, 0, 0)
            };
            IType actual = new ChargeCodeAndDate();
            actual.FromDelimitedString("1^20200201000000");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new ChargeCodeAndDate
            {
                InvocationEvent = "1",
                Datetime = new DateTime(2020, 2, 1, 0, 0, 0)
            };

            string expected = "1^20200201000000";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
