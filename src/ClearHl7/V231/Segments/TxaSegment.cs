using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment TXA - Transcription Document Header.
    /// </summary>
    public class TxaSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TxaSegment"/> class.
        /// </summary>
        public TxaSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TxaSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public TxaSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "TXA";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// TXA.1 - Set ID- TXA.
        /// </summary>
        public uint? SetIdTxa { get; set; }

        /// <summary>
        /// TXA.2 - Document Type.
        /// <para>Suggested: 0270 Document Type -&gt; ClearHl7.Codes.V231.CodeDocumentType</para>
        /// </summary>
        public string DocumentType { get; set; }

        /// <summary>
        /// TXA.3 - Document Content Presentation.
        /// <para>Suggested: 0191 Type Of Referenced Data -&gt; ClearHl7.Codes.V231.CodeTypeOfReferencedData</para>
        /// </summary>
        public string DocumentContentPresentation { get; set; }

        /// <summary>
        /// TXA.4 - Activity Date/Time.
        /// </summary>
        public DateTime? ActivityDateTime { get; set; }

        /// <summary>
        /// TXA.5 - Primary Activity Provider Code/Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> PrimaryActivityProviderCodeName { get; set; }

        /// <summary>
        /// TXA.6 - Origination Date/Time.
        /// </summary>
        public DateTime? OriginationDateTime { get; set; }

        /// <summary>
        /// TXA.7 - Transcription Date/Time.
        /// </summary>
        public DateTime? TranscriptionDateTime { get; set; }

        /// <summary>
        /// TXA.8 - Edit Date/Time.
        /// </summary>
        public IEnumerable<DateTime> EditDateTime { get; set; }

        /// <summary>
        /// TXA.9 - Originator Code/Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> OriginatorCodeName { get; set; }

        /// <summary>
        /// TXA.10 - Assigned Document Authenticator.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> AssignedDocumentAuthenticator { get; set; }

        /// <summary>
        /// TXA.11 - Transcriptionist Code/Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> TranscriptionistCodeName { get; set; }

        /// <summary>
        /// TXA.12 - Unique Document Number.
        /// </summary>
        public EntityIdentifier UniqueDocumentNumber { get; set; }

        /// <summary>
        /// TXA.13 - Parent Document Number.
        /// </summary>
        public EntityIdentifier ParentDocumentNumber { get; set; }

        /// <summary>
        /// TXA.14 - Placer Order Number.
        /// </summary>
        public IEnumerable<EntityIdentifier> PlacerOrderNumber { get; set; }

        /// <summary>
        /// TXA.15 - Filler Order Number.
        /// </summary>
        public EntityIdentifier FillerOrderNumber { get; set; }

        /// <summary>
        /// TXA.16 - Unique Document File Name.
        /// </summary>
        public string UniqueDocumentFileName { get; set; }

        /// <summary>
        /// TXA.17 - Document Completion Status.
        /// <para>Suggested: 0271 Document Completion Status -&gt; ClearHl7.Codes.V231.CodeDocumentCompletionStatus</para>
        /// </summary>
        public string DocumentCompletionStatus { get; set; }

        /// <summary>
        /// TXA.18 - Document Confidentiality Status.
        /// <para>Suggested: 0272 Document Confidentiality Status -&gt; ClearHl7.Codes.V231.CodeDocumentConfidentialityStatus</para>
        /// </summary>
        public string DocumentConfidentialityStatus { get; set; }

        /// <summary>
        /// TXA.19 - Document Availability Status.
        /// <para>Suggested: 0273 Document Availability Status -&gt; ClearHl7.Codes.V231.CodeDocumentAvailabilityStatus</para>
        /// </summary>
        public string DocumentAvailabilityStatus { get; set; }

        /// <summary>
        /// TXA.20 - Document Storage Status.
        /// <para>Suggested: 0275 Document Storage Status -&gt; ClearHl7.Codes.V231.CodeDocumentStorageStatus</para>
        /// </summary>
        public string DocumentStorageStatus { get; set; }

        /// <summary>
        /// TXA.21 - Document Change Reason.
        /// </summary>
        public string DocumentChangeReason { get; set; }

        /// <summary>
        /// TXA.22 - Authentication Person, Time Stamp (set).
        /// </summary>
        public IEnumerable<PerformingPersonTimeStamp> AuthenticationPersonTimeStampSet { get; set; }

        /// <summary>
        /// TXA.23 - Distributed Copies (Code and Name of Recipient(s) ).
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> DistributedCopiesCodeAndNameOfRecipients { get; set; }

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

            SetIdTxa = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            DocumentType = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            DocumentContentPresentation = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            ActivityDateTime = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            PrimaryActivityProviderCodeName = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            OriginationDateTime = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            TranscriptionDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            EditDateTime = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDateTime()) : null;
            OriginatorCodeName = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            AssignedDocumentAuthenticator = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            TranscriptionistCodeName = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            UniqueDocumentNumber = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[12], false, seps) : null;
            ParentDocumentNumber = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[13], false, seps) : null;
            PlacerOrderNumber = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            FillerOrderNumber = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[15], false, seps) : null;
            UniqueDocumentFileName = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            DocumentCompletionStatus = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
            DocumentConfidentialityStatus = segments.Length > 18 && segments[18].Length > 0 ? segments[18] : null;
            DocumentAvailabilityStatus = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            DocumentStorageStatus = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            DocumentChangeReason = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            AuthenticationPersonTimeStampSet = segments.Length > 22 && segments[22].Length > 0 ? segments[22].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<PerformingPersonTimeStamp>(x, false, seps)) : null;
            DistributedCopiesCodeAndNameOfRecipients = segments.Length > 23 && segments[23].Length > 0 ? segments[23].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 24, Configuration.FieldSeparator),
                                Id,
                                SetIdTxa.HasValue ? SetIdTxa.Value.ToString(culture) : null,
                                DocumentType,
                                DocumentContentPresentation,
                                ActivityDateTime.ToHl7DateTimeString(typeof(TxaSegment), nameof(ActivityDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                PrimaryActivityProviderCodeName != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryActivityProviderCodeName.Select(x => x.ToDelimitedString())) : null,
                                OriginationDateTime.ToHl7DateTimeString(typeof(TxaSegment), nameof(OriginationDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                TranscriptionDateTime.ToHl7DateTimeString(typeof(TxaSegment), nameof(TranscriptionDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EditDateTime != null ? string.Join(Configuration.FieldRepeatSeparator, EditDateTime.Select(x => x.ToString(Consts.DateTimeFormatPrecisionSecond, culture))) : null,
                                OriginatorCodeName != null ? string.Join(Configuration.FieldRepeatSeparator, OriginatorCodeName.Select(x => x.ToDelimitedString())) : null,
                                AssignedDocumentAuthenticator != null ? string.Join(Configuration.FieldRepeatSeparator, AssignedDocumentAuthenticator.Select(x => x.ToDelimitedString())) : null,
                                TranscriptionistCodeName != null ? string.Join(Configuration.FieldRepeatSeparator, TranscriptionistCodeName.Select(x => x.ToDelimitedString())) : null,
                                UniqueDocumentNumber?.ToDelimitedString(),
                                ParentDocumentNumber?.ToDelimitedString(),
                                PlacerOrderNumber != null ? string.Join(Configuration.FieldRepeatSeparator, PlacerOrderNumber.Select(x => x.ToDelimitedString())) : null,
                                FillerOrderNumber?.ToDelimitedString(),
                                UniqueDocumentFileName,
                                DocumentCompletionStatus,
                                DocumentConfidentialityStatus,
                                DocumentAvailabilityStatus,
                                DocumentStorageStatus,
                                DocumentChangeReason,
                                AuthenticationPersonTimeStampSet != null ? string.Join(Configuration.FieldRepeatSeparator, AuthenticationPersonTimeStampSet.Select(x => x.ToDelimitedString())) : null,
                                DistributedCopiesCodeAndNameOfRecipients != null ? string.Join(Configuration.FieldRepeatSeparator, DistributedCopiesCodeAndNameOfRecipients.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
