using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment MSH - Message Header.
    /// </summary>
    public class MshSegment : ISegment, IMshSegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MshSegment"/> class.
        /// </summary>
        public MshSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MshSegment"/> class.
        /// </summary>
        /// <param name="dateTimeOfMessage">MSH.7 - Date/Time of Message.</param>
        /// <param name="messageType">MSH.9 - Message Type.</param>
        /// <param name="messageControlId">MSH.10 - Message Control ID.</param>
        /// <param name="processingId">MSH.11 - Processing ID.</param>
        public MshSegment(DateTime dateTimeOfMessage, MessageType messageType, string messageControlId, ProcessingType processingId)
        {
            DateTimeOfMessage = dateTimeOfMessage;
            MessageType = messageType;
            MessageControlId = messageControlId;
            ProcessingId = processingId;
        }

        /// <inheritdoc/>
        public string Id => "MSH";

        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.  The default is <see cref="int.MinValue">MinValue</see>.
        /// </summary>
        public int Ordinal { get; set; } = int.MinValue;

        /// <inheritdoc/>
        public string FieldSeparator { get; private set; } = Configuration.FieldSeparator;

        /// <inheritdoc/>
        public string EncodingCharacters { get; private set; } = $"{ Configuration.ComponentSeparator }{ Configuration.FieldRepeatSeparator }{ Configuration.EscapeCharacter }{ Configuration.SubcomponentSeparator }";

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
        /// <para>Suggested: 0076 Message Type -&gt; ClearHl7.Codes.V240.CodeMessageType</para>
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
        /// MSH.12 - Version ID.  The default is &quot;2.4&quot;.
        /// <para>Suggested: 0104 Version ID -&gt; ClearHl7.Codes.V240.CodeVersionId</para>
        /// </summary>
        public VersionIdentifier VersionId { get; set; } = new VersionIdentifier { VersionId = "2.4" };

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
        /// <para>Suggested: 0155 Accept/Application Acknowledgment Conditions -&gt; ClearHl7.Codes.V240.CodeAcceptApplicationAcknowledgmentConditions</para>
        /// </summary>
        public string AcceptAcknowledgmentType { get; set; }

        /// <summary>
        /// MSH.16 - Application Acknowledgment Type.
        /// <para>Suggested: 0155 Accept/Application Acknowledgment Conditions -&gt; ClearHl7.Codes.V240.CodeAcceptApplicationAcknowledgmentConditions</para>
        /// </summary>
        public string ApplicationAcknowledgmentType { get; set; }

        /// <summary>
        /// MSH.17 - Country Code.
        /// <para>Suggested: 0399 Country Code -&gt; https://www.iso.org/iso-3166-country-codes.html</para>
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// MSH.18 - Character Set.
        /// <para>Suggested: 0211 Alternate Character Sets -&gt; ClearHl7.Codes.V240.CodeAlternateCharacterSets</para>
        /// </summary>
        public IEnumerable<string> CharacterSet { get; set; }

        /// <summary>
        /// MSH.19 - Principal Language Of Message.
        /// </summary>
        public CodedElement PrincipalLanguageOfMessage { get; set; }

        /// <summary>
        /// MSH.20 - Alternate Character Set Handling Scheme.
        /// <para>Suggested: 0356 Alternate Character Set Handling Scheme -&gt; ClearHl7.Codes.V240.CodeAlternateCharacterSetHandlingScheme</para>
        /// </summary>
        public string AlternateCharacterSetHandlingScheme { get; set; }

        /// <summary>
        /// MSH.21 - Message Profile Identifier.
        /// <para>Suggested: 0449 Conformance Statements</para>
        /// </summary>
        public IEnumerable<EntityIdentifier> MessageProfileIdentifier { get; set; }

        /// <exception cref="ArgumentException">
        /// delimitedString does not begin with the proper segment Id.
        /// -or-
        /// The encoding characters in delimitedString does not contain exactly four characters.
        /// </exception>
        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <exception cref="ArgumentException">
        /// delimitedString does not begin with the proper segment Id.
        /// -or-
        /// delimitedString does not contain exactly four encoding characters.
        /// </exception>
        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            if (delimitedString != null && delimitedString.Length > 3)
            {
                FieldSeparator = delimitedString[3].ToString();
            }

            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(new[] { FieldSeparator }, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }'.", nameof(delimitedString));
                }
            }

            if (segments.Length < 2 || segments[1].Length != 4)
            {
                throw new ArgumentException($"{ nameof(delimitedString) } does not contain exactly four encoding characters.", nameof(delimitedString));
            }

            EncodingCharacters = segments[1];
            Separators seps = new Separators().UsingInput($"{ FieldSeparator }{ EncodingCharacters }");

            SendingApplication = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[2], false, seps) : null;
            SendingFacility = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[3], false, seps) : null;
            ReceivingApplication = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[4], false, seps) : null;
            ReceivingFacility = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[5], false, seps) : null;
            DateTimeOfMessage = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            Security = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            MessageType = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<MessageType>(segments[8], false, seps) : null;
            MessageControlId = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            ProcessingId = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<ProcessingType>(segments[10], false, seps) : null;
            VersionId = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<VersionIdentifier>(segments[11], false, seps) : null;
            SequenceNumber = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDecimal() : null;
            ContinuationPointer = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            AcceptAcknowledgmentType = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            ApplicationAcknowledgmentType = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            CountryCode = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            CharacterSet = segments.Length > 17 && segments[17].Length > 0 ? segments[17].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            PrincipalLanguageOfMessage = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[18], false, seps) : null;
            AlternateCharacterSetHandlingScheme = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            MessageProfileIdentifier = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<EntityIdentifier>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
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
                                DateTimeOfMessage?.ToHl7DateTimeString(typeof(MshSegment), nameof(DateTimeOfMessage), Consts.DateTimeFormatPrecisionSecond, culture),
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
