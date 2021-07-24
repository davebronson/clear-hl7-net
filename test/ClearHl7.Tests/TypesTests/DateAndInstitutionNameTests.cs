using System;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class DateAndInstitutionNameTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new DateAndInstitutionName
            {
                Date = new DateTime(2020, 1, 1),
                InstitutionName = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "2"
                }
            };

            IType actual = new DateAndInstitutionName();
            actual.FromDelimitedString("20200101^2");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new DateAndInstitutionName
            {
                Date = new DateTime(2020, 1, 1),
                InstitutionName = new CodedWithExceptions
                {
                    Identifier = "2"
                }
            };

            string expected = "20200101^2";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
