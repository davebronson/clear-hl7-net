using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 SAD - Street Address.
    /// </summary>
    public class StreetAddress : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreetAddress"/> class.
        /// </summary>
        public StreetAddress()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreetAddress"/> class.
        /// </summary>
        /// <param name="streetOrMailingAddress">SAD.1 - Street or Mailing Address.</param>
        public StreetAddress(string streetOrMailingAddress)
        {
            StreetOrMailingAddress = streetOrMailingAddress;
        }

        /// <inheritdoc/>
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

            StreetOrMailingAddress = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            StreetName = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            DwellingNumber = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
