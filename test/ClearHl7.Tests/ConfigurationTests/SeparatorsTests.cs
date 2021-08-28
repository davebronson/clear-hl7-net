using Xunit;
using FluentAssertions;
using System;

namespace ClearHl7.Tests.ConfigurationTests
{
    public class SeparatorsTests
    {
        /// <summary>
        /// Validates that calling UsingConfigurationValues() with default inputs results in the expected output.
        /// </summary>
        [Fact]
        public void UsingConfigurationValues_WithDefaultInput_InitializesPropertiesWithConfigurationValues()
        {
            Separators expected = new()
            {
                ComponentSeparator = new[] { Configuration.ComponentSeparator },
                FieldRepeatSeparator = new[] { Configuration.FieldRepeatSeparator },
                EscapeCharacter = new[] { Configuration.EscapeCharacter },
                SubcomponentSeparator = new[] { Configuration.SubcomponentSeparator },
            };

            Separators actual = new Separators().UsingConfigurationValues();

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that calling UsingInput() with a string input containing 4 characters results in the expected output.
        /// </summary>
        [Fact]
        public void UsingInput_WithFourCharInput_InitializesPropertiesCorrectly()
        {
            Separators expected = new()
            {
                ComponentSeparator = new[] { "A" },
                FieldRepeatSeparator = new[] { "B" },
                EscapeCharacter = new[] { "C" },
                SubcomponentSeparator = new[] { "D" },
            };

            Separators actual = new Separators().UsingInput("ABCD");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that calling UsingInput() with a string input containing three characters results in an ArgumentException being thrown.
        /// </summary>
        [Fact]
        public void UsingInput_WithThreeCharInput_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Separators().UsingInput("ABC"));
        }

        /// <summary>
        /// Validates that calling UsingInput() with a string input containing five characters results in an ArgumentException being thrown.
        /// </summary>
        [Fact]
        public void UsingInput_WithFiveCharInput_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Separators().UsingInput("ABCDE"));
        }
    }
}
