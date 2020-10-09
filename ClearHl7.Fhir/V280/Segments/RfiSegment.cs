using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V280.Types;

namespace ClearHl7.Fhir.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RFI - Request For Information.
    /// </summary>
    public class RfiSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RFI";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RFI.1 - Request Date.
        /// </summary>
        public DateTime? RequestDate { get; set; }

        /// <summary>
        /// RFI.2 - Response Due Date.
        /// </summary>
        public DateTime? ResponseDueDate { get; set; }

        /// <summary>
        /// RFI.3 - Patient Consent.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string PatientConsent { get; set; }

        /// <summary>
        /// RFI.4 - Date Additional Information Was Submitted.
        /// </summary>
        public DateTime? DateAdditionalInformationWasSubmitted { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}",
                                Id,
                                RequestDate.HasValue ? RequestDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ResponseDueDate.HasValue ? ResponseDueDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PatientConsent,
                                DateAdditionalInformationWasSubmitted.HasValue ? DateAdditionalInformationWasSubmitted.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd('|');
        }
    }
}