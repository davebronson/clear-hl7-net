using System;
using System.Collections.Generic;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V230.Types;

namespace ClearHl7.Fhir.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MSH - Message Header.
    /// </summary>
    public class MshSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "MSH";

        /// <summary>
        /// Gets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.  This property is read-only.
        /// </summary>
        public int Ordinal { get; } = int.MinValue;

        /// <summary>
        /// MSH.1 - Field Separator.  This property is read-only.
        /// </summary>
        public char FieldSeparator => Configuration.FieldSeparator;

        /// <summary>
        /// MSH.2 - Encoding Characters.  This property is read-only.
        /// </summary>
        public string EncodingCharacters => $"{ Configuration.ComponentSeparator }{ Configuration.FieldRepeatSeparator }{ Configuration.EscapeCharacter }{ Configuration.SubcomponentSeparator }";

        /// <summary>
        /// MSH.3 - Sending Application.
        /// </summary>
        public HierarchicDesignator SendingApplication { get; set; }

        /// <summary>
        /// MSH.4 - Sending Facility.
        /// </summary>
        public HierarchicDesignator SendingFacility { get; set; }

        /// <summary>
        /// MSH.5 - Receiving Application.
        /// </summary>
        public HierarchicDesignator ReceivingApplication { get; set; }

        /// <summary>
        /// MSH.6 - Receiving Facility.
        /// </summary>
        public HierarchicDesignator ReceivingFacility { get; set; }

        /// <summary>
        /// MSH.7 - Date/Time of Message.
        /// </summary>
        public DateTime? DateTimeOfMessage { get; set; }

        /// <summary>
        /// MSH.8 - Security.
        /// </summary>
        public string Security { get; set; }

        /// <summary>
        /// MSH.9 - Message Type.
        /// </summary>
        public MessageType MessageType { get; set; }

        /// <summary>
        /// MSH.10 - Message Control ID.
        /// </summary>
        public string MessageControlId { get; set; }

        /// <summary>
        /// MSH.11 - Processing ID.
        /// </summary>
        public ProcessingType ProcessingId { get; set; }

        /// <summary>
        /// MSH.12 - Version ID.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0104</remarks>
        public string VersionId { get; set; } = "2.3";

        /// <summary>
        /// MSH.13 - Sequence Number.
        /// </summary>
        public decimal? SequenceNumber { get; set; }

        /// <summary>
        /// MSH.14 - Continuation Pointer.
        /// </summary>
        public string ContinuationPointer { get; set; }

        /// <summary>
        /// MSH.15 - Accept Acknowledgment Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0155</remarks>
        public string AcceptAcknowledgmentType { get; set; }

        /// <summary>
        /// MSH.16 - Application Acknowledgment Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0155</remarks>
        public string ApplicationAcknowledgmentType { get; set; }

        /// <summary>
        /// MSH.17 - Country Code.
        /// </summary>
        /// <remarks>https://www.iso.org/iso-3166-country-codes.html</remarks>
        public string CountryCode { get; set; }

        /// <summary>
        /// MSH.18 - Character Set.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0211</remarks>
        public IEnumerable<string> CharacterSet { get; set; }

        /// <summary>
        /// MSH.19 - Principal Language Of Message.
        /// </summary>
        public CodedElement PrincipalLanguageOfMessage { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                $"{{0}}{{1}}{ StringHelper.StringFormatSequence(2, 18, Configuration.FieldSeparator) }",
                                Id,
                                FieldSeparator,
                                EncodingCharacters,
                                SendingApplication?.ToDelimitedString(),
                                SendingFacility?.ToDelimitedString(),
                                ReceivingApplication?.ToDelimitedString(),
                                ReceivingFacility?.ToDelimitedString(),
                                DateTimeOfMessage.HasValue ? DateTimeOfMessage.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                Security,
                                MessageType?.ToDelimitedString(),
                                MessageControlId,
                                ProcessingId?.ToDelimitedString(),
                                VersionId,
                                SequenceNumber.HasValue ? SequenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                ContinuationPointer,
                                AcceptAcknowledgmentType,
                                ApplicationAcknowledgmentType,
                                CountryCode,
                                CharacterSet != null ? string.Join(Configuration.FieldRepeatSeparator, CharacterSet) : null,
                                PrincipalLanguageOfMessage?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}