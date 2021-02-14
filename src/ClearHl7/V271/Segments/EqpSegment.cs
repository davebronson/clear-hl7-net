using System;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment EQP - Equipment Log Service.
    /// </summary>
    public class EqpSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "EQP";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// EQP.1 - Event type.
        /// <para>Suggested: 0450 Event Type -&gt; ClearHl7.Codes.V271.CodeEventType</para>
        /// </summary>
        public CodedWithExceptions EventType { get; set; }

        /// <summary>
        /// EQP.2 - File Name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// EQP.3 - Start Date/Time.
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// EQP.4 - End Date/Time.
        /// </summary>
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// EQP.5 - Transaction Data.
        /// </summary>
        public string TransactionData { get; set; }
        
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
                                EventType?.ToDelimitedString(),
                                FileName,
                                StartDateTime.HasValue ? StartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EndDateTime.HasValue ? EndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                TransactionData
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}