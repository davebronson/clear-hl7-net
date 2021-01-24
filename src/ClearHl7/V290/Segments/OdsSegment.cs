using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ODS - Dietary Orders, Supplements, And Preferences.
    /// </summary>
    public class OdsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ODS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ODS.1 - Type.
        /// <para>Suggested: 0159 Diet Code Specification Type -&gt; ClearHl7.Codes.V290.CodeDietCodeSpecificationType</para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// ODS.2 - Service Period.
        /// <para>Suggested: 0627 Service Period</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ServicePeriod { get; set; }

        /// <summary>
        /// ODS.3 - Diet, Supplement, or Preference Code.
        /// <para>Suggested: 0628 Diet, Supplement, Or Preference Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> DietSupplementOrPreferenceCode { get; set; }

        /// <summary>
        /// ODS.4 - Text Instruction.
        /// </summary>
        public IEnumerable<string> TextInstruction { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                Type,
                                ServicePeriod != null ? string.Join(Configuration.FieldRepeatSeparator, ServicePeriod.Select(x => x.ToDelimitedString())) : null,
                                DietSupplementOrPreferenceCode != null ? string.Join(Configuration.FieldRepeatSeparator, DietSupplementOrPreferenceCode.Select(x => x.ToDelimitedString())) : null,
                                TextInstruction != null ? string.Join(Configuration.FieldRepeatSeparator, TextInstruction) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}