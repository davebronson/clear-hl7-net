using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V260.Types;

namespace ClearHl7.Fhir.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ERR - Error.
    /// </summary>
    public class ErrSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ERR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ERR.1 - Error Code and Location.
        /// </summary>
        public IEnumerable<ErrorLocationAndDescription> ErrorCodeAndLocation { get; set; }

        /// <summary>
        /// ERR.2 - Error Location.
        /// </summary>
        public IEnumerable<ErrorLocation> ErrorLocation { get; set; }

        /// <summary>
        /// ERR.3 - HL7 Error Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0357</remarks>
        public CodedWithExceptions Hl7ErrorCode { get; set; }

        /// <summary>
        /// ERR.4 - Severity.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0516</remarks>
        public string Severity { get; set; }

        /// <summary>
        /// ERR.5 - Application Error Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0533</remarks>
        public CodedWithExceptions ApplicationErrorCode { get; set; }

        /// <summary>
        /// ERR.6 - Application Error Parameter.
        /// </summary>
        public IEnumerable<string> ApplicationErrorParameter { get; set; }

        /// <summary>
        /// ERR.7 - Diagnostic Information.
        /// </summary>
        public Text DiagnosticInformation { get; set; }

        /// <summary>
        /// ERR.8 - User Message.
        /// </summary>
        public Text UserMessage { get; set; }

        /// <summary>
        /// ERR.9 - Inform Person Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0517</remarks>
        public IEnumerable<string> InformPersonIndicator { get; set; }

        /// <summary>
        /// ERR.10 - Override Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0518</remarks>
        public CodedWithExceptions OverrideType { get; set; }

        /// <summary>
        /// ERR.11 - Ove
        /// <remarks>https://www.hl7.org/fhir/v2/0519</remarks>rride Reason Code.
        /// </summary>
        public IEnumerable<CodedWithExceptions> OverrideReasonCode { get; set; }

        /// <summary>
        /// ERR.12 - Help Desk Contact Point.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> HelpDeskContactPoint { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}",
                                Id,
                                ErrorCodeAndLocation != null ? string.Join("~", ErrorCodeAndLocation.Select(x => x.ToDelimitedString())) : null,
                                ErrorLocation != null ? string.Join("~", ErrorLocation.Select(x => x.ToDelimitedString())) : null,
                                Hl7ErrorCode?.ToDelimitedString(),
                                Severity,
                                ApplicationErrorCode?.ToDelimitedString(),
                                ApplicationErrorParameter != null ? string.Join("~", ApplicationErrorParameter) : null,
                                DiagnosticInformation?.ToDelimitedString(),
                                UserMessage?.ToDelimitedString(),
                                InformPersonIndicator != null ? string.Join("~", InformPersonIndicator) : null,
                                OverrideType?.ToDelimitedString(),
                                OverrideReasonCode != null ? string.Join("~", OverrideReasonCode.Select(x => x.ToDelimitedString())) : null,
                                HelpDeskContactPoint != null ? string.Join("~", HelpDeskContactPoint.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd('|');
        }
    }
}