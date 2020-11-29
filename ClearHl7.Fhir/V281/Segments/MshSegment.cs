using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V281.Types;

namespace ClearHl7.Fhir.V281.Segments
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
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// MSH.1 - Field Separator.  This property is read-only.
        /// </summary>
        public char FieldSeparator
        {
            get
            {
                return Configuration.FieldSeparator;
            }
        }

        /// <summary>
        /// MSH.2 - Encoding Characters.  This property is read-only.
        /// </summary>
        public string EncodingCharacters 
        {
            get
            {
                return $"{ Configuration.ComponentSeparator }{ Configuration.FieldRepeatSeparator }{ Configuration.EscapeCharacter }{ Configuration.SubcomponentSeparator }";
            }
        }

        /// <summary>
        /// MSH.3 - Sending Application.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0361</remarks>
        public HierarchicDesignator SendingApplication { get; set; }

        /// <summary>
        /// MSH.4 - Sending Facility.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0362</remarks>
        public HierarchicDesignator SendingFacility { get; set; }

        /// <summary>
        /// MSH.5 - Receiving Application.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0361</remarks>
        public HierarchicDesignator ReceivingApplication { get; set; }

        /// <summary>
        /// MSH.6 - Receiving Facility.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0362</remarks>
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
        public VersionIdentifier VersionId { get; set; } = new VersionIdentifier { VersionId = "2.8.1" };

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
        public CodedWithExceptions PrincipalLanguageOfMessage { get; set; }

        /// <summary>
        /// MSH.20 - Alternate Character Set Handling Scheme.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0356</remarks>
        public string AlternateCharacterSetHandlingScheme { get; set; }

        /// <summary>
        /// MSH.21 - Message Profile Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> MessageProfileIdentifier { get; set; }

        /// <summary>
        /// MSH.22 - Sending Responsible Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations SendingResponsibleOrganization { get; set; }

        /// <summary>
        /// MSH.23 - Receiving Responsible Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations ReceivingResponsibleOrganization { get; set; }

        /// <summary>
        /// MSH.24 - Sending Network Address.
        /// </summary>
        public HierarchicDesignator SendingNetworkAddress { get; set; }

        /// <summary>
        /// MSH.25 - Receiving Network Address.
        /// </summary>
        public HierarchicDesignator ReceivingNetworkAddress { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}{1}{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}",
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
                                VersionId?.ToDelimitedString(),
                                SequenceNumber.HasValue ? SequenceNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                ContinuationPointer,
                                AcceptAcknowledgmentType,
                                ApplicationAcknowledgmentType,
                                CountryCode,
                                CharacterSet != null ? string.Join("~", CharacterSet) : null,
                                PrincipalLanguageOfMessage?.ToDelimitedString(),
                                AlternateCharacterSetHandlingScheme,
                                MessageProfileIdentifier != null ? string.Join("~", MessageProfileIdentifier.Select(x => x.ToDelimitedString())) : null,
                                SendingResponsibleOrganization?.ToDelimitedString(),
                                ReceivingResponsibleOrganization?.ToDelimitedString(),
                                SendingNetworkAddress?.ToDelimitedString(),
                                ReceivingNetworkAddress?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}