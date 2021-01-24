using ClearHl7.Fhir.Helpers;
using Xunit;

namespace ClearHl7.Fhir.Tests.HelpersTests
{
    public class StringHelperTests
    {
        /// <summary>
        /// Validates that StringFormatSequence() returns the correct string sequence.
        /// </summary>
        [Fact]
        public void StringFormatSequence_WithPipeZeroToFour_ReturnsCorrectSequence()
        {
            string expected = "{0}|{1}|{2}|{3}|{4}";
            string actual = StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that StringFormatSequence() returns the correct string sequence.
        /// </summary>
        [Fact]
        public void StringFormatSequence_WithPipeTwoToSeven_ReturnsCorrectSequence()
        {
            string expected = "{2}|{3}|{4}|{5}|{6}|{7}";
            string actual = StringHelper.StringFormatSequence(2, 6, Configuration.FieldSeparator);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that Escape() returns the input string with the proper control character replacements.
        /// </summary>
        [Fact]
        public void Escape_WithAllControlChars_ReturnsEscapedString()
        {
            string expected = @"Test \E\ \T\ \R\ \S\ \F\ End";
            string actual = StringHelper.Escape(@"Test \ & ~ ^ | End");

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that Unescape() returns the input string with escaped control characters restored to their normal, unescaped state.
        /// </summary>
        [Fact]
        public void Unescape_WithAllControlChars_ReturnsUnescapedString()
        {
            string expected = @"Test \ & ~ ^ | End";
            string actual = StringHelper.Unescape(@"Test \E\ \T\ \R\ \S\ \F\ End");

            Assert.Equal(expected, actual);
        }
    }
}
