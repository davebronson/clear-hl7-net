using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment EQP - Equipment Log Service.
    /// </summary>
    public class EqpSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EqpSegment"/> class.
        /// </summary>
        public EqpSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EqpSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public EqpSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "EQP";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// EQP.1 - Event type.
        /// <para>Suggested: 0450 Event Type -&gt; ClearHl7.Codes.V282.CodeEventType</para>
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

            EventType = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            FileName = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            StartDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            EndDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            TransactionData = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                EventType?.ToDelimitedString(),
                                FileName,
                                StartDateTime.ToHl7DateTimeString(typeof(EqpSegment), nameof(StartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EndDateTime.ToHl7DateTimeString(typeof(EqpSegment), nameof(EndDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                TransactionData
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
