using System;
using ClearHl7.Helpers;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 AUI - Authorization Information.
    /// </summary>
    public class AuthorizationInformation : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// AUI.1 - Authorization Number.
        /// </summary>
        public string AuthorizationNumber { get; set; }

        /// <summary>
        /// AUI.2 - Date.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// AUI.3 - Source.
        /// </summary>
        public string Source { get; set; }

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
                                AuthorizationNumber,
                                Date.HasValue ? Date.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                Source
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
