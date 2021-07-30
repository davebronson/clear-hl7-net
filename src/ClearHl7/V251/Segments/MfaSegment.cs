using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MFA - Master File Acknowledgment.
    /// </summary>
    public class MfaSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "MFA";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// MFA.1 - Record-Level Event Code.
        /// <para>Suggested: 0180 Masterfile Action Code -&gt; ClearHl7.Codes.V251.CodeMasterfileActionCode</para>
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
        /// <para>Suggested: 0181 MFN Record-Level Error Return -&gt; ClearHl7.Codes.V251.CodeMfnRecordLevelErrorReturn</para>
        /// </summary>
        public CodedElement MfnRecordLevelErrorReturn { get; set; }

        /// <summary>
        /// MFA.5 - Primary Key Value - MFA.
        /// </summary>
        public IEnumerable<string> PrimaryKeyValueMfa { get; set; }

        /// <summary>
        /// MFA.6 - Primary Key Value Type - MFA.
        /// <para>Suggested: 0355 Primary Key Value Type -&gt; ClearHl7.Codes.V251.CodePrimaryKeyValueType</para>
        /// </summary>
        public IEnumerable<string> PrimaryKeyValueTypeMfa { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            RecordLevelEventCode = segments.ElementAtOrDefault(1);
            MfnControlId = segments.ElementAtOrDefault(2);
            EventCompletionDateTime = segments.ElementAtOrDefault(3)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            MfnRecordLevelErrorReturn = segments.Length > 4 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(4), false) : null;
            PrimaryKeyValueMfa = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator) : null;
            PrimaryKeyValueTypeMfa = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                RecordLevelEventCode,
                                MfnControlId,
                                EventCompletionDateTime.HasValue ? EventCompletionDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                MfnRecordLevelErrorReturn?.ToDelimitedString(),
                                PrimaryKeyValueMfa != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryKeyValueMfa) : null,
                                PrimaryKeyValueTypeMfa != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryKeyValueTypeMfa) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}