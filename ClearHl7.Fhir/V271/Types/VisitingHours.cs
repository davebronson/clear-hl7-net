using System;
using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V271.Types
{
    /// <summary>
    /// HL7 Version 2 VH - Visiting Hours.
    /// </summary>
    public class VisitingHours : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// VH.1 - Start Day Range.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0267</remarks>
        public string StartDayRange { get; set; }

        /// <summary>
        /// VH.2 - End Day Range.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0267</remarks>
        public string EndDayRange { get; set; }

        /// <summary>
        /// VH.3 - Start Hour Range.
        /// </summary>
        public DateTime? StartHourRange { get; set; }

        /// <summary>
        /// VH.4 - End Hour Range.
        /// </summary>
        public DateTime? EndHourRange { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            char separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                StartDayRange,
                                EndDayRange,
                                StartHourRange.HasValue ? StartHourRange.Value.ToString(Consts.TimeFormatPrecisionSecond, culture) : null,
                                EndHourRange.HasValue ? EndHourRange.Value.ToString(Consts.TimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(separator);
        }
    }
}
