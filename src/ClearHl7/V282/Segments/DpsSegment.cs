using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DPS - Diagnosis And Procedure Code.
    /// </summary>
    public class DpsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DPS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// DPS.1 - Diagnosis Code - MCP.
        /// <para>Suggested: 0051 Diagnosis Code</para>
        /// </summary>
        public CodedWithExceptions DiagnosisCodeMcp { get; set; }

        /// <summary>
        /// DPS.2 - Procedure Code.
        /// <para>Suggested: 0941 Procedure Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ProcedureCode { get; set; }

        /// <summary>
        /// DPS.3 - Effective Date/Time.
        /// </summary>
        public DateTime? EffectiveDateTime { get; set; }

        /// <summary>
        /// DPS.4 - Expiration Date/Time.
        /// </summary>
        public DateTime? ExpirationDateTime { get; set; }

        /// <summary>
        /// DPS.5 - Type of Limitation.
        /// <para>Suggested: 0940 Type of Limitation</para>
        /// </summary>
        public CodedWithNoExceptions TypeOfLimitation { get; set; }

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
                                DiagnosisCodeMcp?.ToDelimitedString(),
                                ProcedureCode != null ? string.Join(Configuration.FieldRepeatSeparator, ProcedureCode.Select(x => x.ToDelimitedString())) : null,
                                EffectiveDateTime.HasValue ? EffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpirationDateTime.HasValue ? ExpirationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                TypeOfLimitation?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}