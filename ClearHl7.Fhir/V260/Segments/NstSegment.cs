using System;

namespace ClearHl7.Fhir.V260.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string StatisticsAvailable { get; set; }

        /// <summary>
        /// NST.2 - Source Identifier.
        /// </summary>
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// NST.3 - Source Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0332</remarks>
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}",
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
                                ).TrimEnd('|');
        }
    }
}