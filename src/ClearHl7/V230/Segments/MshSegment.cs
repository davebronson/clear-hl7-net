using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        /// <para>Suggested: 0104 Version ID -&gt; ClearHl7.Codes.V230.CodeVersionId</para>
        /// </summary>
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
        /// <para>Suggested: 0155 Accept/Application Acknowledgment Conditions -&gt; ClearHl7.Codes.V230.CodeAcceptApplicationAcknowledgmentConditions</para>
        /// </summary>
        public string AcceptAcknowledgmentType { get; set; }

        /// <summary>
        /// MSH.16 - Application Acknowledgment Type.
        /// <para>Suggested: 0155 Accept/Application Acknowledgment Conditions -&gt; ClearHl7.Codes.V230.CodeAcceptApplicationAcknowledgmentConditions</para>
        /// </summary>
        public string ApplicationAcknowledgmentType { get; set; }

        /// <summary>
        /// MSH.17 - Country Code.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// MSH.18 - Character Set.
        /// <para>Suggested: 0211 Alternate Character Sets -&gt; ClearHl7.Codes.V230.CodeAlternateCharacterSets</para>
        /// </summary>
        public IEnumerable<string> CharacterSet { get; set; }

        /// <summary>
        /// MSH.19 - Principal Language Of Message.
        /// </summary>
        public CodedElement PrincipalLanguageOfMessage { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            //FieldSeparator = ;
            //EncodingCharacters = ;
            SendingApplication = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[2], false) : null;
            SendingFacility = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[3], false) : null;
            ReceivingApplication = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[4], false) : null;
            ReceivingFacility = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[5], false) : null;
            DateTimeOfMessage = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            Security = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            MessageType = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<MessageType>(segments[8], false) : null;
            MessageControlId = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            ProcessingId = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<ProcessingType>(segments[10], false) : null;
            VersionId = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            SequenceNumber = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDecimal() : null;
            ContinuationPointer = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            AcceptAcknowledgmentType = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            ApplicationAcknowledgmentType = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            CountryCode = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            CharacterSet = segments.Length > 17 && segments[17].Length > 0 ? segments[17].Split(separator) : null;
            PrincipalLanguageOfMessage = segments.Length > 18 && segments[18].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[18], false) : null;
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
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}