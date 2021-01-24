using Xunit;

namespace ClearHl7.Tests.FormatTests
{
    public class NumericFormatTests
    {
        /// <summary>
        /// Validates that passing the Consts.NumericFormat string to decimal.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithWholeNumber_ReturnsCorrectlyFormattedString()
        {
            string expected = "115";
            string actual = 115M.ToString(Consts.NumericFormat, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.NumericFormat string to decimal.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithFractionalNumberOverOne_ReturnsCorrectlyFormattedString()
        {
            string expected = "115.055";
            string actual = 115.055M.ToString(Consts.NumericFormat, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.NumericFormat string to decimal.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithFractionalNumberOverOneAndTrailingZeros_ReturnsCorrectlyFormattedString()
        {
            string expected = "115.055";
            string actual = 115.05500000M.ToString(Consts.NumericFormat, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates that passing the Consts.NumericFormat string to decimal.ToString() results in the expected output.
        /// </summary>
        [Fact]
        public void ToString_WithFractionalNumberUnderOne_ReturnsCorrectlyFormattedString()
        {
            string expected = "0.012";
            string actual = .012M.ToString(Consts.NumericFormat, System.Globalization.CultureInfo.CurrentCulture);

            Assert.Equal(expected, actual);
        }
    }
}
