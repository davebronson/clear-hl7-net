using System;
using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(separator, StringSplitOptions.None);

            StreetOrMailingAddress = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            StreetName = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            DwellingNumber = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
        }

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
