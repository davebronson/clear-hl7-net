﻿using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.TypesTests
{
    public class VersionIdentifierTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            VersionIdentifier expected = new()
            {
                VersionId = "1",
                InternationalizationCode = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "2"
                },
                InternationalVersionId = new CodedWithExceptions
                {
                    IsSubcomponent = true,
                    Identifier = "3"
                }
            };
            VersionIdentifier actual = new VersionIdentifier().FromDelimitedString("1^2^3");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            IType hl7Type = new VersionIdentifier
            {
                VersionId = "1",
                InternationalizationCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                InternationalVersionId = new CodedWithExceptions
                {
                    Identifier = "3"
                }
            };

            string expected = "1^2^3";
            string actual = hl7Type.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
