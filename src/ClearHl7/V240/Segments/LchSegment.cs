using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment LCH - Location Characteristic.
    /// </summary>
    public class LchSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "LCH";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// LCH.1 - Primary Key Value - LCH.
        /// </summary>
        public PersonLocation PrimaryKeyValueLch { get; set; }

        /// <summary>
        /// LCH.2 - Segment Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V240.CodeSegmentActionCode</para>
        /// </summary>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// LCH.3 - Segment Unique Key.
        /// </summary>
        public EntityIdentifier SegmentUniqueKey { get; set; }

        /// <summary>
        /// LCH.4 - Location Characteristic ID.
        /// <para>Suggested: 0324 Location Characteristic ID -&gt; ClearHl7.Codes.V240.CodeLocationCharacteristicId</para>
        /// </summary>
        public CodedElement LocationCharacteristicId { get; set; }

        /// <summary>
        /// LCH.5 - Location Characteristic Value - LCH.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V240.CodeYesNoIndicator</para>
        /// </summary>
        public CodedElement LocationCharacteristicValueLch { get; set; }
        
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
                                PrimaryKeyValueLch?.ToDelimitedString(),
                                SegmentActionCode,
                                SegmentUniqueKey?.ToDelimitedString(),
                                LocationCharacteristicId?.ToDelimitedString(),
                                LocationCharacteristicValueLch?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}