﻿using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        public string ErrorCodeAndLocation { get; set; }

        /// <summary>
        /// ERR.2 - Error Location.
        /// </summary>
        public IEnumerable<MessageLocation> ErrorLocation { get; set; }

        /// <summary>
        /// ERR.3 - HL7 Error Code.
        /// <para>Suggested: 0357 Message Error Condition Codes -&gt; ClearHl7.Codes.V290.CodeMessageErrorConditionCodes</para>
        /// </summary>
        public CodedWithExceptions Hl7ErrorCode { get; set; }

        /// <summary>
        /// ERR.4 - Severity.
        /// <para>Suggested: 0516 Error Severity -&gt; ClearHl7.Codes.V290.CodeErrorSeverity</para>
        /// </summary>
        public string Severity { get; set; }

        /// <summary>
        /// ERR.5 - Application Error Code.
        /// <para>Suggested: 0533 Application Error Code</para>
        /// </summary>
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
        /// <para>Suggested: 0517 Inform Person Code -&gt; ClearHl7.Codes.V290.CodeInformPersonCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> InformPersonIndicator { get; set; }

        /// <summary>
        /// ERR.10 - Override Type.
        /// <para>Suggested: 0518 Override Type -&gt; ClearHl7.Codes.V290.CodeOverrideType</para>
        /// </summary>
        public CodedWithExceptions OverrideType { get; set; }

        /// <summary>
        /// ERR.11 - Override Reason Code.
        /// <para>Suggested: 0519 Override Reason</para>
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
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                ErrorCodeAndLocation,
                                ErrorLocation != null ? string.Join(Configuration.FieldRepeatSeparator, ErrorLocation.Select(x => x.ToDelimitedString())) : null,
                                Hl7ErrorCode?.ToDelimitedString(),
                                Severity,
                                ApplicationErrorCode?.ToDelimitedString(),
                                ApplicationErrorParameter != null ? string.Join(Configuration.FieldRepeatSeparator, ApplicationErrorParameter) : null,
                                DiagnosticInformation?.ToDelimitedString(),
                                UserMessage?.ToDelimitedString(),
                                InformPersonIndicator != null ? string.Join(Configuration.FieldRepeatSeparator, InformPersonIndicator.Select(x => x.ToDelimitedString())) : null,
                                OverrideType?.ToDelimitedString(),
                                OverrideReasonCode != null ? string.Join(Configuration.FieldRepeatSeparator, OverrideReasonCode.Select(x => x.ToDelimitedString())) : null,
                                HelpDeskContactPoint != null ? string.Join(Configuration.FieldRepeatSeparator, HelpDeskContactPoint.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}