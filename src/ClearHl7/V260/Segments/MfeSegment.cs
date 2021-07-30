using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MFE - Master File Entry.
    /// </summary>
    public class MfeSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "MFE";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// MFE.1 - Record-Level Event Code.
        /// <para>Suggested: 0180 Masterfile Action Code -&gt; ClearHl7.Codes.V260.CodeMasterfileActionCode</para>
        /// </summary>
        public string RecordLevelEventCode { get; set; }

        /// <summary>
        /// MFE.2 - MFN Control ID.
        /// </summary>
        public string MfnControlId { get; set; }

        /// <summary>
        /// MFE.3 - Effective Date/Time.
        /// </summary>
        public DateTime? EffectiveDateTime { get; set; }

        /// <summary>
        /// MFE.4 - Primary Key Value - MFE.
        /// </summary>
        public IEnumerable<string> PrimaryKeyValueMfe { get; set; }

        /// <summary>
        /// MFE.5 - Primary Key Value Type.
        /// <para>Suggested: 0355 Primary Key Value Type -&gt; ClearHl7.Codes.V260.CodePrimaryKeyValueType</para>
        /// </summary>
        public IEnumerable<string> PrimaryKeyValueType { get; set; }

        /// <summary>
        /// MFE.6 - Entered Date/Time.
        /// </summary>
        public DateTime? EnteredDateTime { get; set; }

        /// <summary>
        /// MFE.7 - Entered By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons EnteredBy { get; set; }

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
            EffectiveDateTime = segments.ElementAtOrDefault(3)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            PrimaryKeyValueMfe = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator) : null;
            PrimaryKeyValueType = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator) : null;
            EnteredDateTime = segments.ElementAtOrDefault(6)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EnteredBy = segments.Length > 7 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(7), false) : null;
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
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                RecordLevelEventCode,
                                MfnControlId,
                                EffectiveDateTime.HasValue ? EffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PrimaryKeyValueMfe != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryKeyValueMfe) : null,
                                PrimaryKeyValueType != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryKeyValueType) : null,
                                EnteredDateTime.HasValue ? EnteredDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EnteredBy?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}