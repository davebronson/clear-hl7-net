using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ODT - Diet Tray Instructions.
    /// </summary>
    public class OdtSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ODT";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ODT.1 - Tray Type.
        /// <para>Suggested: 0160 Tray Type -&gt; ClearHl7.Codes.V250.CodeTrayType</para>
        /// </summary>
        public CodedElement TrayType { get; set; }

        /// <summary>
        /// ODT.2 - Service Period.
        /// </summary>
        public IEnumerable<CodedElement> ServicePeriod { get; set; }

        /// <summary>
        /// ODT.3 - Text Instruction.
        /// </summary>
        public string TextInstruction { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                TrayType?.ToDelimitedString(),
                                ServicePeriod != null ? string.Join(Configuration.FieldRepeatSeparator, ServicePeriod.Select(x => x.ToDelimitedString())) : null,
                                TextInstruction
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}