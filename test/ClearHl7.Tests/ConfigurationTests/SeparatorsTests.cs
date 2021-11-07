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
                FieldSeparator = new[] { Configuration.FieldSeparator },
                ComponentSeparator = new[] { Configuration.ComponentSeparator },
                FieldRepeatSeparator = new[] { Configuration.FieldRepeatSeparator },
                EscapeCharacter = new[] { Configuration.EscapeCharacter },
                SubcomponentSeparator = new[] { Configuration.SubcomponentSeparator },
            };

            Separators actual = new Separators().UsingConfigurationValues();

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that calling UsingInput() with a string input containing five characters results in the expected output.
        /// </summary>
        [Fact]
        public void UsingInput_WithFiveCharInput_InitializesPropertiesCorrectly()
        {
            Separators expected = new()
            {
                FieldSeparator = new[] { "A" },
                ComponentSeparator = new[] { "B" },
                FieldRepeatSeparator = new[] { "C" },
                EscapeCharacter = new[] { "D" },
                SubcomponentSeparator = new[] { "E" },
            };

            Separators actual = new Separators().UsingInput("ABCDE");

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
        /// Validates that calling UsingInput() with a string input containing six characters results in an ArgumentException being thrown.
        /// </summary>
        [Fact]
        public void UsingInput_WithSixCharInput_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Separators().UsingInput("ABCDEF"));
        }
    }
}
