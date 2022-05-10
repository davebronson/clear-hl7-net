using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V260.Types
{
    /// <summary>
    /// HL7 Version 2 CE - Coded Element.
    /// </summary>
    public class CodedElement : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodedElement"/> class.
        /// </summary>
        public CodedElement()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodedElement"/> class.
        /// </summary>
        /// <param name="identifier">CE.1 - Identifier.</param>
        public CodedElement(string identifier)
        {
            Identifier = identifier;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CE.1 - Identifier.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// CE.2 - Text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// CE.3 - Name of Coding System.
        /// </summary>
        public string NameOfCodingSystem { get; set; }

        /// <summary>
        /// CE.4 - Alternate Identifier.
        /// </summary>
        public string AlternateIdentifier { get; set; }

        /// <summary>
        /// CE.5 - Alternate Text.
        /// </summary>
        public string AlternateText { get; set; }

        /// <summary>
        /// CE.6 - Name of Alternate Coding System.
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
            Text = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            NameOfCodingSystem = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            AlternateIdentifier = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            AlternateText = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
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
                                Text,
                                NameOfCodingSystem,
                                AlternateIdentifier,
                                AlternateText,
                                NameOfAlternateCodingSystem
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
