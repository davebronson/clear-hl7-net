using System;

namespace ClearHl7.Fhir.V251.Types
{
    /// <summary>
    /// HL7 Version 2 RP - Reference Pointer.
    /// </summary>
    public class ReferencePointer : IType
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
        /// <remarks>https://www.hl7.org/fhir/v2/0191</remarks>
        public string TypeOfData { get; set; }

        /// <summary>
        /// RP.4 - Subtype.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0291</remarks>
        public string Subtype { get; set; }

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
                                Pointer,
                                ApplicationId?.ToDelimitedString(),
                                TypeOfData,
                                Subtype
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
