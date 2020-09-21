using System;

namespace ClearHl7.Fhir.V281.Types
{
    /// <summary>
    /// HL7 Version 2 OSP - Occurrence Span Code And Date.
    /// </summary>
    public class OccurrenceSpanCodeAndDate : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// OSP.1 - Occurrence Span Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0351</remarks>
        public CodedWithNoExceptions OccurrenceSpanCode { get; set; }

        /// <summary>
        /// OSP.2 - Occurrence Span Start Date.
        /// </summary>
        public DateTime? OccurrenceSpanStartDate { get; set; }

        /// <summary>
        /// OSP.3 - Occurrence Span Stop Date.
        /// </summary>
        public DateTime? OccurrenceSpanStopDate { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}" : "{0}^{1}^{2}",
                                OccurrenceSpanCode?.ToDelimitedString(),
                                OccurrenceSpanStartDate.HasValue ? OccurrenceSpanStartDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                OccurrenceSpanStopDate.HasValue ? OccurrenceSpanStopDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
