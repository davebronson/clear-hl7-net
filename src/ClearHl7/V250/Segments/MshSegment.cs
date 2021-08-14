using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
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
        public string FieldSeparator => Configuration.FieldSeparator;

        /// <summary>
        /// MSH.2 - Encoding Characters.  This property is read-only.
        /// </summary>
        public string EncodingCharacters => $"{ Configuration.ComponentSeparator }{ Configuration.FieldRepeatSeparator }{ Configuration.EscapeCharacter }{ Configuration.SubcomponentSeparator }";

        /// <summary>
        /// MSH.3 - Sending Application.
        /// <para>Suggested: 0361 Application</para>
        /// </summary>
        public HierarchicDesignator SendingApplication { get; set; }

        /// <summary>
        /// MSH.4 - Sending Facility.
        /// <para>Suggested: 0362 Facility</para>
        /// </summary>
        public HierarchicDesignator SendingFacility { get; set; }

        /// <summary>
        /// MSH.5 - Receiving Application.
        /// <para>Suggested: 0361 Application</para>
        /// </summary>
        public HierarchicDesignator ReceivingApplication { get; set; }

        /// <summary>
        /// MSH.6 - Receiving Facility.
        /// <para>Suggested: 0362 Facility</para>
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
        public VersionIdentifier VersionId { get; set; } = new VersionIdentifier { VersionId = "2.5" };

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
        /// <para>Suggested: 0155 Accept/Application Acknowledgment Conditions -&gt; ClearHl7.Codes.V250.CodeAcceptApplicationAcknowledgmentConditions</para>
        /// </summary>
        public string AcceptAcknowledgmentType { get; set; }

        /// <summary>
        /// MSH.16 - Application Acknowledgment Type.
        /// <para>Suggested: 0155 Accept/Application Acknowledgment Conditions -&gt; ClearHl7.Codes.V250.CodeAcceptApplicationAcknowledgmentConditions</para>
        /// </summary>
        public string ApplicationAcknowledgmentType { get; set; }

        /// <summary>
        /// MSH.17 - Country Code.
        /// <para>Suggested: 0399 Country Code -&gt; https://www.iso.org/iso-3166-country-codes.html</para>
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// MSH.18 - Character Set.
        /// <para>Suggested: 0211 Alternate Character Sets -&gt; ClearHl7.Codes.V250.CodeAlternateCharacterSets</para>
        /// </summary>
        public IEnumerable<string> CharacterSet { get; set; }

        /// <summary>
        /// MSH.19 - Principal Language Of Message.
        /// </summary>
        public CodedElement PrincipalLanguageOfMessage { get; set; }

        /// <summary>
        /// MSH.20 - Alternate Character Set Handling Scheme.
        /// <para>Suggested: 0356 Alternate Character Set Handling Scheme -&gt; ClearHl7.Codes.V250.CodeAlternateCharacterSetHandlingScheme</para>
        /// </summary>
        public string AlternateCharacterSetHandlingScheme { get; set; }

        /// <summary>
        /// MSH.21 - Message Profile Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> MessageProfileIdentifier { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            //FieldSeparator = ;
            //EncodingCharacters = ;
            SendingApplication = segments.Length > 2 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(2), false) : null;
            SendingFacility = segments.Length > 3 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(3), false) : null;
            ReceivingApplication = segments.Length > 4 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(4), false) : null;
            ReceivingFacility = segments.Length > 5 ? TypeHelper.Deserialize<HierarchicDesignator>(segments.ElementAtOrDefault(5), false) : null;
            DateTimeOfMessage = segments.ElementAtOrDefault(6)?.ToNullableDateTime();
            Security = segments.ElementAtOrDefault(7);
            MessageType = segments.Length > 8 ? TypeHelper.Deserialize<MessageType>(segments.ElementAtOrDefault(8), false) : null;
            MessageControlId = segments.ElementAtOrDefault(9);
            ProcessingId = segments.Length > 10 ? TypeHelper.Deserialize<ProcessingType>(segments.ElementAtOrDefault(10), false) : null;
            VersionId = segments.Length > 11 ? TypeHelper.Deserialize<VersionIdentifier>(segments.ElementAtOrDefault(11), false) : null;
            SequenceNumber = segments.ElementAtOrDefault(12)?.ToNullableDecimal();
            ContinuationPointer = segments.ElementAtOrDefault(13);
            AcceptAcknowledgmentType = segments.ElementAtOrDefault(14);
            ApplicationAcknowledgmentType = segments.ElementAtOrDefault(15);
            CountryCode = segments.ElementAtOrDefault(16);
            CharacterSet = segments.Length > 17 ? segments.ElementAtOrDefault(17).Split(separator) : null;
            PrincipalLanguageOfMessage = segments.Length > 18 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(18), false) : null;
            AlternateCharacterSetHandlingScheme = segments.ElementAtOrDefault(19);
            MessageProfileIdentifier = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
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
                                $"{{0}}{{1}}{ StringHelper.StringFormatSequence(2, 20, Configuration.FieldSeparator) }",
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
                                CharacterSet != null ? string.Join(Configuration.FieldRepeatSeparator, CharacterSet) : null,
                                PrincipalLanguageOfMessage?.ToDelimitedString(),
                                AlternateCharacterSetHandlingScheme,
                                MessageProfileIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, MessageProfileIdentifier.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}