using ClearHl7.Helpers;

namespace ClearHl7.V250.Types
{
    /// <summary>
    /// HL7 Version 2 EI - Entity Identifier.
    /// </summary>
    public class EntityIdentifier : IType
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
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                EntityId,
                                NamespaceId,
                                UniversalId,
                                UniversalIdType
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
