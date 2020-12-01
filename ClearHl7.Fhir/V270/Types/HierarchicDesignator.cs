using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V270.Types
{
    /// <summary>
    /// HL7 Version 2 HD - Hierarchic Designator.
    /// </summary>
    public class HierarchicDesignator : IType
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
                                StringHelper.StringFormatSequence(0, 3, separator),
                                NamespaceId,
                                UniversalId,
                                UniversalIdType
                                ).TrimEnd(separator);
        }
    }
}
