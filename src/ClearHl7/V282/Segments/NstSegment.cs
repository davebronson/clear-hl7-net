using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NST - Application Control Level Statistics.
    /// </summary>
    public class NstSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "NST";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// NST.1 - Statistics Available.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string StatisticsAvailable { get; set; }

        /// <summary>
        /// NST.2 - Source Identifier.
        /// </summary>
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// NST.3 - Source Type.
        /// <para>Suggested: 0332 Source Type -&gt; ClearHl7.Codes.V282.CodeSourceType</para>
        /// </summary>
        public string SourceType { get; set; }

        /// <summary>
        /// NST.4 - Statistics Start.
        /// </summary>
        public DateTime? StatisticsStart { get; set; }

        /// <summary>
        /// NST.5 - Statistics End.
        /// </summary>
        public DateTime? StatisticsEnd { get; set; }

        /// <summary>
        /// NST.6 - Receive Character Count.
        /// </summary>
        public decimal? ReceiveCharacterCount { get; set; }

        /// <summary>
        /// NST.7 - Send Character Count.
        /// </summary>
        public decimal? SendCharacterCount { get; set; }

        /// <summary>
        /// NST.8 - Messages Received.
        /// </summary>
        public decimal? MessagesReceived { get; set; }

        /// <summary>
        /// NST.9 - Messages Sent.
        /// </summary>
        public decimal? MessagesSent { get; set; }

        /// <summary>
        /// NST.10 - Checksum Errors Received.
        /// </summary>
        public decimal? ChecksumErrorsReceived { get; set; }

        /// <summary>
        /// NST.11 - Length Errors Received.
        /// </summary>
        public decimal? LengthErrorsReceived { get; set; }

        /// <summary>
        /// NST.12 - Other Errors Received.
        /// </summary>
        public decimal? OtherErrorsReceived { get; set; }

        /// <summary>
        /// NST.13 - Connect Timeouts.
        /// </summary>
        public decimal? ConnectTimeouts { get; set; }

        /// <summary>
        /// NST.14 - Receive Timeouts.
        /// </summary>
        public decimal? ReceiveTimeouts { get; set; }

        /// <summary>
        /// NST.15 - Application control-level Errors.
        /// </summary>
        public decimal? ApplicationControlLevelErrors { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            StatisticsAvailable = segments.ElementAtOrDefault(1);
            SourceIdentifier = segments.ElementAtOrDefault(2);
            SourceType = segments.ElementAtOrDefault(3);
            StatisticsStart = segments.ElementAtOrDefault(4)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            StatisticsEnd = segments.ElementAtOrDefault(5)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ReceiveCharacterCount = segments.ElementAtOrDefault(6)?.ToNullableDecimal();
            SendCharacterCount = segments.ElementAtOrDefault(7)?.ToNullableDecimal();
            MessagesReceived = segments.ElementAtOrDefault(8)?.ToNullableDecimal();
            MessagesSent = segments.ElementAtOrDefault(9)?.ToNullableDecimal();
            ChecksumErrorsReceived = segments.ElementAtOrDefault(10)?.ToNullableDecimal();
            LengthErrorsReceived = segments.ElementAtOrDefault(11)?.ToNullableDecimal();
            OtherErrorsReceived = segments.ElementAtOrDefault(12)?.ToNullableDecimal();
            ConnectTimeouts = segments.ElementAtOrDefault(13)?.ToNullableDecimal();
            ReceiveTimeouts = segments.ElementAtOrDefault(14)?.ToNullableDecimal();
            ApplicationControlLevelErrors = segments.ElementAtOrDefault(15)?.ToNullableDecimal();
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
                                StringHelper.StringFormatSequence(0, 16, Configuration.FieldSeparator),
                                Id,
                                StatisticsAvailable,
                                SourceIdentifier,
                                SourceType,
                                StatisticsStart.HasValue ? StatisticsStart.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                StatisticsEnd.HasValue ? StatisticsEnd.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReceiveCharacterCount.HasValue ? ReceiveCharacterCount.Value.ToString(Consts.NumericFormat, culture) : null,
                                SendCharacterCount.HasValue ? SendCharacterCount.Value.ToString(Consts.NumericFormat, culture) : null,
                                MessagesReceived.HasValue ? MessagesReceived.Value.ToString(Consts.NumericFormat, culture) : null,
                                MessagesSent.HasValue ? MessagesSent.Value.ToString(Consts.NumericFormat, culture) : null,
                                ChecksumErrorsReceived.HasValue ? ChecksumErrorsReceived.Value.ToString(Consts.NumericFormat, culture) : null,
                                LengthErrorsReceived.HasValue ? LengthErrorsReceived.Value.ToString(Consts.NumericFormat, culture) : null,
                                OtherErrorsReceived.HasValue ? OtherErrorsReceived.Value.ToString(Consts.NumericFormat, culture) : null,
                                ConnectTimeouts.HasValue ? ConnectTimeouts.Value.ToString(Consts.NumericFormat, culture) : null,
                                ReceiveTimeouts.HasValue ? ReceiveTimeouts.Value.ToString(Consts.NumericFormat, culture) : null,
                                ApplicationControlLevelErrors.HasValue ? ApplicationControlLevelErrors.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}