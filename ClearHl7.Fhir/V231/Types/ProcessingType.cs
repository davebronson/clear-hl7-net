using System;

namespace ClearHl7.Fhir.V231.Types
{
    /// <summary>
    /// HL7 Version 2 PT - Processing Type.
    /// </summary>
    public class ProcessingType : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PT.1 - Processing ID.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0103</remarks>
        public string ProcessingId { get; set; }

        /// <summary>
        /// PT.2 - Processing Mode.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0207</remarks>
        public string ProcessingMode { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}" : "{0}^{1}",
                                ProcessingId,
                                ProcessingMode
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
