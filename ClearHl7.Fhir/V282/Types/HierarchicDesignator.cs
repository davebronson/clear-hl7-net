using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 HD - Hierarchic Designator.
    /// </summary>
    public class HierarchicDesignator
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// HD.1 - Namespace ID.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0300</remarks>
        public string NamespaceId { get; set; }

        /// <summary>
        /// HD.2 - Universal ID.
        /// </summary>
        public string UniversalId { get; set; }

        /// <summary>
        /// HD.3 - Universal ID Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0301</remarks>
        public string UniversalIdType { get; set; }
    }
}
