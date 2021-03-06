﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        /// <para>Suggested: 0180 Masterfile Action Code -&gt; ClearHl7.Codes.V230.CodeMasterfileActionCode</para>
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
        /// <para>Suggested: 0181 MFN Record-Level Error Return -&gt; ClearHl7.Codes.V230.CodeMfnRecordLevelErrorReturn</para>
        /// </summary>
        public CodedElement MfnRecordLevelErrorReturn { get; set; }

        /// <summary>
        /// MFA.5 - Primary Key Value - MFA.
        /// </summary>
        public IEnumerable<CodedElement> PrimaryKeyValueMfa { get; set; }

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
                                EventCompletionDateTime.HasValue ? EventCompletionDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                MfnRecordLevelErrorReturn?.ToDelimitedString(),
                                PrimaryKeyValueMfa != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryKeyValueMfa.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}