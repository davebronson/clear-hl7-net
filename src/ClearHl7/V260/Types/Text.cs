using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V260.Types
{
    /// <summary>
    /// HL7 Version 2 TX - Text.
    /// </summary>
    public class Text : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Text"/> class.
        /// </summary>
        public Text()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Text"/> class.
        /// </summary>
        /// <param name="value">TX.1 - Value.</param>
        public Text(string value)
        {
            Value = value;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// TX.1 - Value.
        /// </summary>
        public string Value { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            Value = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 1, separator),
                                Value
                                );
        }
    }
}
