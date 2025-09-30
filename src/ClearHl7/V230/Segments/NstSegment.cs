using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NST - Application Control Level Statistics.
    /// </summary>
    public class NstSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NstSegment"/> class.
        /// </summary>
        public NstSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NstSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public NstSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "NST";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// NST.1 - Statistics Available.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V230.CodeYesNoIndicator</para>
        /// </summary>
        public string StatisticsAvailable { get; set; }

        /// <summary>
        /// NST.2 - Source Identifier.
        /// </summary>
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// NST.3 - Source Type.
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

            StatisticsAvailable = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            SourceIdentifier = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            SourceType = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            StatisticsStart = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            StatisticsEnd = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            ReceiveCharacterCount = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            SendCharacterCount = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDecimal() : null;
            MessagesReceived = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            MessagesSent = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDecimal() : null;
            ChecksumErrorsReceived = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
            LengthErrorsReceived = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDecimal() : null;
            OtherErrorsReceived = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDecimal() : null;
            ConnectTimeouts = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDecimal() : null;
            ReceiveTimeouts = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDecimal() : null;
            ApplicationControlLevelErrors = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
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
                                StatisticsStart?.ToHl7DateTimeString(typeof(NstSegment), nameof(StatisticsStart), Consts.DateTimeFormatPrecisionSecond, culture),
                                StatisticsEnd?.ToHl7DateTimeString(typeof(NstSegment), nameof(StatisticsEnd), Consts.DateTimeFormatPrecisionSecond, culture),
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
