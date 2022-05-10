using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 VR - Value Range.
    /// </summary>
    public class ValueRange : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueRange"/> class.
        /// </summary>
        public ValueRange()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueRange"/> class.
        /// </summary>
        /// <param name="firstDataCodeValue">VR.1 - First Data Code Value.</param>
        /// <param name="lastDataCodeValue">VR.2 - Last Data Code Value.</param>
        public ValueRange(string firstDataCodeValue, string lastDataCodeValue)
        {
            FirstDataCodeValue = firstDataCodeValue;
            LastDataCodeValue = lastDataCodeValue;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// VR.1 - First Data Code Value.
        /// </summary>
        public string FirstDataCodeValue { get; set; }

        /// <summary>
        /// VR.2 - Last Data Code Value.
        /// </summary>
        public string LastDataCodeValue { get; set; }

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

            FirstDataCodeValue = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            LastDataCodeValue = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                FirstDataCodeValue,
                                LastDataCodeValue
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
