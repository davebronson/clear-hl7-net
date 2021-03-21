using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
{
    /// <summary>
    /// HL7 Version 2 CE - Coded Element.
    /// </summary>
    public class CodedElement : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
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
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V240.CodeCodingSystem</para>
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
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V240.CodeCodingSystem</para>
        /// </summary>
        public string NameOfAlternateCodingSystem { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
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
