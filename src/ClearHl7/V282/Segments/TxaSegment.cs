using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment TXA - Transcription Document Header.
    /// </summary>
    public class TxaSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "TXA";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// TXA.1 - Set ID- TXA.
        /// </summary>
        public uint? SetIdTxa { get; set; }

        /// <summary>
        /// TXA.2 - Document Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0270</remarks>
        public CodedWithExceptions DocumentType { get; set; }

        /// <summary>
        /// TXA.3 - Document Content Presentation.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0191</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0271</remarks>
        public string DocumentCompletionStatus { get; set; }

        /// <summary>
        /// TXA.18 - Document Confidentiality Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0272</remarks>
        public string DocumentConfidentialityStatus { get; set; }

        /// <summary>
        /// TXA.19 - Document Availability Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0273</remarks>
        public string DocumentAvailabilityStatus { get; set; }

        /// <summary>
        /// TXA.20 - Document Storage Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0275</remarks>
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

        /// <summary>
        /// TXA.24 - Folder Assignment.
        /// </summary>
        public IEnumerable<CodedWithExceptions> FolderAssignment { get; set; }

        /// <summary>
        /// TXA.25 - Document Title.
        /// </summary>
        public IEnumerable<string> DocumentTitle { get; set; }

        /// <summary>
        /// TXA.26 - Agreed Due Date/Time.
        /// </summary>
        public DateTime? AgreedDueDateTime { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 27, Configuration.FieldSeparator),
                                Id,
                                SetIdTxa.HasValue ? SetIdTxa.Value.ToString(culture) : null,
                                DocumentType?.ToDelimitedString(),
                                DocumentContentPresentation,
                                ActivityDateTime.HasValue ? ActivityDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PrimaryActivityProviderCodeName != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryActivityProviderCodeName.Select(x => x.ToDelimitedString())) : null,
                                OriginationDateTime.HasValue ? OriginationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                TranscriptionDateTime.HasValue ? TranscriptionDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
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
                                DistributedCopiesCodeAndNameOfRecipients != null ? string.Join(Configuration.FieldRepeatSeparator, DistributedCopiesCodeAndNameOfRecipients.Select(x => x.ToDelimitedString())) : null,
                                FolderAssignment != null ? string.Join(Configuration.FieldRepeatSeparator, FolderAssignment.Select(x => x.ToDelimitedString())) : null,
                                DocumentTitle != null ? string.Join(Configuration.FieldRepeatSeparator, DocumentTitle) : null,
                                AgreedDueDateTime.HasValue ? AgreedDueDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}