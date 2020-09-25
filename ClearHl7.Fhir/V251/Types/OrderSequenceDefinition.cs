using System;

namespace ClearHl7.Fhir.V251.Types
{
    /// <summary>
    /// HL7 Version 2 OSD - Order Sequence Definition.
    /// </summary>
    public class OrderSequenceDefinition : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// OSD.1 - Occurrence Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0350</remarks>
        public CodedWithNoExceptions OccurrenceCode { get; set; }

        /// <summary>
        /// OSD.2 - Occurrence Date.
        /// </summary>
        public DateTime? OccurrenceDate { get; set; }

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
                                OccurrenceCode?.ToDelimitedString(),
                                OccurrenceDate.HasValue ? OccurrenceDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
