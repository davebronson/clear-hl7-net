using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
{
    /// <summary>
    /// HL7 Version 2 CF - Coded Element With Formatted Values.
    /// </summary>
    public class CodedElementWithFormattedValues : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodedElementWithFormattedValues"/> class.
        /// </summary>
        public CodedElementWithFormattedValues()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodedElementWithFormattedValues"/> class.
        /// </summary>
        /// <param name="identifier">CF.1 - Identifier.</param>
        public CodedElementWithFormattedValues(string identifier)
        {
            Identifier = identifier;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CF.1 - Identifier.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// CF.2 - Formatted Text.
        /// </summary>
        public string FormattedText { get; set; }

        /// <summary>
        /// CF.3 - Name of Coding System.
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V240.CodeCodingSystem</para>
        /// </summary>
        public string NameOfCodingSystem { get; set; }

        /// <summary>
        /// CF.4 - Alternate Identifier.
        /// </summary>
        public string AlternateIdentifier { get; set; }

        /// <summary>
        /// CF.5 - Alternate Formatted Text.
        /// </summary>
        public string AlternateFormattedText { get; set; }

        /// <summary>
        /// CF.6 - Name of Alternate Coding System.
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V240.CodeCodingSystem</para>
        /// </summary>
        public string NameOfAlternateCodingSystem { get; set; }

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

            Identifier = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            FormattedText = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            NameOfCodingSystem = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            AlternateIdentifier = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            AlternateFormattedText = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            NameOfAlternateCodingSystem = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, separator),
                                Identifier,
                                FormattedText,
                                NameOfCodingSystem,
                                AlternateIdentifier,
                                AlternateFormattedText,
                                NameOfAlternateCodingSystem
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
