using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ERR - Error.
    /// </summary>
    public class ErrSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "ERR";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// ERR.1 - Error Code and Location.
        /// </summary>
        public string ErrorCodeAndLocation { get; set; }

        /// <summary>
        /// ERR.2 - Error Location.
        /// </summary>
        public IEnumerable<ErrorLocation> ErrorLocation { get; set; }

        /// <summary>
        /// ERR.3 - HL7 Error Code.
        /// <para>Suggested: 0357 Message Error Condition Codes -&gt; ClearHl7.Codes.V282.CodeMessageErrorConditionCodes</para>
        /// </summary>
        public CodedWithExceptions Hl7ErrorCode { get; set; }

        /// <summary>
        /// ERR.4 - Severity.
        /// <para>Suggested: 0516 Error Severity -&gt; ClearHl7.Codes.V282.CodeErrorSeverity</para>
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
        /// <para>Suggested: 0517 Inform Person Code -&gt; ClearHl7.Codes.V282.CodeInformPersonCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> InformPersonIndicator { get; set; }

        /// <summary>
        /// ERR.10 - Override Type.
        /// <para>Suggested: 0518 Override Type -&gt; ClearHl7.Codes.V282.CodeOverrideType</para>
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

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ErrorCodeAndLocation = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            ErrorLocation = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ErrorLocation>(x, false, seps)) : null;
            Hl7ErrorCode = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            Severity = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            ApplicationErrorCode = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            ApplicationErrorParameter = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            DiagnosticInformation = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[7], false, seps) : null;
            UserMessage = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[8], false, seps) : null;
            InformPersonIndicator = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            OverrideType = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[10], false, seps) : null;
            OverrideReasonCode = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            HelpDeskContactPoint = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
