using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 DIN - Date And Institution Name.
    /// </summary>
    public class DateAndInstitutionName
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
        public CodedWithExceptions InstitutionName { get; set; }

        /// <summary>
        /// Returns a pipe-delimited representation of this instance. 
        /// </summary>
        /// <returns>A string.</returns>
        public string ToPipeString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}" : "{0}^{1}",
                                Date.HasValue ? Date.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                InstitutionName?.ToPipeString()
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
