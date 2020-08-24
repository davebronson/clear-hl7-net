using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 RP - Reference Pointer.
    /// </summary>
    public class ReferencePointer
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RP.1 - Pointer.
        /// </summary>
        public string Pointer { get; set; }

        /// <summary>
        /// RP.2 - Application ID.
        /// </summary>
        public HierarchicDesignator ApplicationId { get; set; }

        /// <summary>
        /// RP.3 - Type of Data.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0834</remarks>
        public string TypeOfData { get; set; }

        /// <summary>
        /// RP.4 - Subtype.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0291</remarks>
        public string Subtype { get; set; }
    }
}
