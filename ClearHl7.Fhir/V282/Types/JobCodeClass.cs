using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 JCC - Job Code Class.
    /// </summary>
    public class JobCodeClass
    {
        /// <summary>
        /// JCC.1 - Job Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0327</remarks>
        public CodedWithExceptions JobCode { get; set; }

        /// <summary>
        /// JCC.2 - Job Class.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0328</remarks>
        public CodedWithExceptions JobClass { get; set; }

        /// <summary>
        /// JCC.3 - Job Description Text.
        /// </summary>
        public string JobDescriptionText { get; set; }
    }
}
