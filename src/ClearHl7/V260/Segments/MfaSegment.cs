using System;
using System.Collections.Generic;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MFA - Master File Acknowledgment.
    /// </summary>
    public class MfaSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MfaSegment"/> class.
        /// </summary>
        public MfaSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MfaSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public MfaSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "MFA";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// MFA.1 - Record-Level Event Code.
        /// <para>Suggested: 0180 Masterfile Action Code -&gt; ClearHl7.Codes.V260.CodeMasterfileActionCode</para>
        /// </summary>
        public string RecordLevelEventCode { get; set; }

        /// <summary>
        /// MFA.2 - MFN Control ID.
        /// </summary>
        public string MfnControlId { get; set; }

        /// <summary>
        /// MFA.3 - Event Completion Date/Time.
        /// </summary>
        public DateTime? EventCompletionDateTime { get; set; }

        /// <summary>
        /// MFA.4 - MFN Record Level Error Return.
        /// <para>Suggested: 0181 MFN Record-Level Error Return -&gt; ClearHl7.Codes.V260.CodeMfnRecordLevelErrorReturn</para>
        /// </summary>
        public CodedWithExceptions MfnRecordLevelErrorReturn { get; set; }

        /// <summary>
        /// MFA.5 - Primary Key Value - MFA.
        /// </summary>
        public IEnumerable<string> PrimaryKeyValueMfa { get; set; }

        /// <summary>
        /// MFA.6 - Primary Key Value Type - MFA.
        /// <para>Suggested: 0355 Primary Key Value Type -&gt; ClearHl7.Codes.V260.CodePrimaryKeyValueType</para>
        /// </summary>
        public IEnumerable<string> PrimaryKeyValueTypeMfa { get; set; }

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
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            RecordLevelEventCode = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            MfnControlId = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            EventCompletionDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            MfnRecordLevelErrorReturn = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            PrimaryKeyValueMfa = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            PrimaryKeyValueTypeMfa = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                RecordLevelEventCode,
                                MfnControlId,
                                EventCompletionDateTime?.ToHl7DateTimeString(typeof(MfaSegment), nameof(EventCompletionDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                MfnRecordLevelErrorReturn?.ToDelimitedString(),
                                PrimaryKeyValueMfa != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryKeyValueMfa) : null,
                                PrimaryKeyValueTypeMfa != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryKeyValueTypeMfa) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
