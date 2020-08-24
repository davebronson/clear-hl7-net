using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 RI - Repeat Interval.
    /// </summary>
    public class RepeatInterval
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RI.1 - Repeat Pattern.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0335</remarks>
        public CodedWithExceptions RepeatPattern { get; set; }

        /// <summary>
        /// RI.2 - Explicit Time Interval.
        /// </summary>
        public string ExplicitTimeInterval { get; set; }
    }
}
