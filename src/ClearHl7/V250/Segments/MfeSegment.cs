﻿using System;
using System.Collections.Generic;
using ClearHl7.Helpers;

namespace ClearHl7.V250.Segments
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
        /// <para>Suggested: 0180 Masterfile Action Code -&gt; ClearHl7.Codes.V250.CodeMasterfileActionCode</para>
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
        /// <para>Suggested: 0355 Primary Key Value Type -&gt; ClearHl7.Codes.V250.CodePrimaryKeyValueType</para>
        /// </summary>
        public IEnumerable<string> PrimaryKeyValueType { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                RecordLevelEventCode,
                                MfnControlId,
                                EffectiveDateTime.HasValue ? EffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PrimaryKeyValueMfe != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryKeyValueMfe) : null,
                                PrimaryKeyValueType != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryKeyValueType) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}