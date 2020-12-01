using System;
using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V240.Types
{
    /// <summary>
    /// HL7 Version 2 DIN - Date And Institution Name.
    /// </summary>
    public class DateAndInstitutionName : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// DIN.1 - Date.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// DIN.2 - Institution Name.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0531</remarks>
        public CodedElement InstitutionName { get; set; }

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
                                StringHelper.StringFormatSequence(0, 2, separator),
                                Date.HasValue ? Date.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                InstitutionName?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
