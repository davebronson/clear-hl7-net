using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 DR - Date/Time Range.
    /// </summary>
    public class DateTimeRange
    {
        /// <summary>
        /// DR.1 - Range Start Date/Time.
        /// </summary>
        public DateTime? RangeStartDateTime { get; set; }

        /// <summary>
        /// DR.2 - Range End Date/Time.
        /// </summary>
        public DateTime? RangeEndDateTime { get; set; }
    }
}
