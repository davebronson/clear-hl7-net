using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 EI - Entity Identifier.
    /// </summary>
    public class EntityIdentifier
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// EI.1 - Entity Id.
        /// </summary>
        public string EntityId { get; set; }

        /// <summary>
        /// EI.2 - Namespace ID.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0363</remarks>
        public string NamespaceId { get; set; }

        /// <summary>
        /// EI.3 - Universal ID.
        /// </summary>
        public string UniversalId { get; set; }

        /// <summary>
        /// EI.4 - Universal ID Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0301</remarks>
        public string UniversalIdType { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}" : "{0}^{1}^{2}^{3}",
                                EntityId,
                                NamespaceId,
                                UniversalId,
                                UniversalIdType
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
