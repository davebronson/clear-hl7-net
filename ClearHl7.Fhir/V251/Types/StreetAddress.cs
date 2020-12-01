using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V251.Types
{
    /// <summary>
    /// HL7 Version 2 SAD - Street Address.
    /// </summary>
    public class StreetAddress : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SAD.1 - Street or Mailing Address.
        /// </summary>
        public string StreetOrMailingAddress { get; set; }

        /// <summary>
        /// SAD.2 - Street Name.
        /// </summary>
        public string StreetName { get; set; }

        /// <summary>
        /// SAD.3 - Dwelling Number.
        /// </summary>
        public string DwellingNumber { get; set; }

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
                                StringHelper.StringFormatSequence(0, 3, separator),
                                StreetOrMailingAddress,
                                StreetName,
                                DwellingNumber
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
