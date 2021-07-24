using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class JobCodeClassTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            IType expected = new JobCodeClass
            {
                JobCode = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "1"
                },
                JobClass = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "2"
                },
                JobDescriptionText = new Text
                {
                    IsSubcomponent = true,
                    Value = "3"
                }
            };

            IType actual = new JobCodeClass();
            actual.FromDelimitedString("1^2^3");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new JobCodeClass
            {
                JobCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                JobClass = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                JobDescriptionText = new Text
                {
                    Value = "3"
                }
            };

            string expected = "1^2^3";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
