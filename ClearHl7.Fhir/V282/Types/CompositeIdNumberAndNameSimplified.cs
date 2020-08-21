using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CNN - Composite Id Number And Name Simplified.
    /// </summary>
    public class CompositeIdNumberAndNameSimplified
    {
        /// <summary>
        /// CNN.1 - ID Number.
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// CNN.2 - Family Name.
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// CNN.3 - Given Name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// CNN.4 - Second and Further Given Names or Initials Thereof.
        /// </summary>
        public string SecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

        /// <summary>
        /// CNN.5 - Suffix (e.g., JR or III).
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// CNN.6 - Prefix (e.g., DR).
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// CNN.7 - Degree (e.g., MD).
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0360</remarks>
        public string Degree { get; set; }

        /// <summary>
        /// CNN.8 - Source Table.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0297</remarks>
        public string SourceTable { get; set; }

        /// <summary>
        /// CNN.9 - Assigning Authority - Namespace ID.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0363</remarks>
        public string AssigningAuthorityNamespaceId { get; set; }

        /// <summary>
        /// CNN.10 - Assigning Authority - Universal ID.
        /// </summary>
        public string AssigningAuthorityUniversalId { get; set; }

        /// <summary>
        /// CNN.11 - Assigning Authority - Universal ID Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0301</remarks>
        public string AssigningAuthorityUniversalIdType { get; set; }
    }
}
