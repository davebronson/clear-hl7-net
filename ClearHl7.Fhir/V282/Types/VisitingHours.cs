using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 VH - Visiting Hours.
    /// </summary>
    public class VisitingHours
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
    }
}
