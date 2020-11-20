using System;

namespace ClearHl7.Fhir.V240.Types
{
    /// <summary>
    /// HL7 Version 2 SPS - Speciment Source.
    /// </summary>
    public class SpecimentSource : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SPS.1 - Specimen Source Name or Code.
        /// </summary>
        public CodedElement SpecimenSourceNameOrCode { get; set; }

        /// <summary>
        /// SPS.2 - Additives.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0371</remarks>
        public CodedWithExceptions Additives { get; set; }

        /// <summary>
        /// SPS.3 - Specimen Collection Method.
        /// </summary>
        public Text SpecimenCollectionMethod { get; set; }

        /// <summary>
        /// SPS.4 - Body Site.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0163</remarks>
        public CodedElement BodySite { get; set; }

        /// <summary>
        /// SPS.5 - Site Modifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0495</remarks>
        public CodedElement SiteModifier { get; set; }

        /// <summary>
        /// SPS.6 - Collection Method Modifier Code.
        /// </summary>
        public CodedElement CollectionMethodModifierCode { get; set; }

        /// <summary>
        /// SPS.7 - Specimen Role.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0369</remarks>
        public CodedElement SpecimenRole { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}&{4}&{5}&{6}" : "{0}^{1}^{2}^{3}^{4}^{5}^{6}",
                                SpecimenSourceNameOrCode?.ToDelimitedString(),
                                Additives?.ToDelimitedString(),
                                SpecimenCollectionMethod?.ToDelimitedString(),
                                BodySite?.ToDelimitedString(),
                                SiteModifier?.ToDelimitedString(),
                                CollectionMethodModifierCode?.ToDelimitedString(),
                                SpecimenRole?.ToDelimitedString()
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
