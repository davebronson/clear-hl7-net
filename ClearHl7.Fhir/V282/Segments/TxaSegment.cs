using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// TXA.1 - Set ID- TXA.
        ///// </summary>
        //public SetIdTxa { get; set; }

        ///// <summary>
        ///// TXA.2 - Document Type.
        ///// </summary>
        //public DocumentType { get; set; }

        ///// <summary>
        ///// TXA.3 - Document Content Presentation.
        ///// </summary>
        //public DocumentContentPresentation { get; set; }

        ///// <summary>
        ///// TXA.4 - Activity Date/Time.
        ///// </summary>
        //public ActivityDateTime { get; set; }

        ///// <summary>
        ///// TXA.5 - Primary Activity Provider Code/Name.
        ///// </summary>
        //public PrimaryActivityProviderCodeName { get; set; }

        ///// <summary>
        ///// TXA.6 - Origination Date/Time.
        ///// </summary>
        //public OriginationDateTime { get; set; }

        ///// <summary>
        ///// TXA.7 - Transcription Date/Time.
        ///// </summary>
        //public TranscriptionDateTime { get; set; }

        ///// <summary>
        ///// TXA.8 - Edit Date/Time.
        ///// </summary>
        //public EditDateTime { get; set; }

        ///// <summary>
        ///// TXA.9 - Originator Code/Name.
        ///// </summary>
        //public OriginatorCodeName { get; set; }

        ///// <summary>
        ///// TXA.10 - Assigned Document Authenticator.
        ///// </summary>
        //public AssignedDocumentAuthenticator { get; set; }

        ///// <summary>
        ///// TXA.11 - Transcriptionist Code/Name.
        ///// </summary>
        //public TranscriptionistCodeName { get; set; }

        ///// <summary>
        ///// TXA.12 - Unique Document Number.
        ///// </summary>
        //public UniqueDocumentNumber { get; set; }

        ///// <summary>
        ///// TXA.13 - Parent Document Number.
        ///// </summary>
        //public ParentDocumentNumber { get; set; }

        ///// <summary>
        ///// TXA.14 - Placer Order Number.
        ///// </summary>
        //public PlacerOrderNumber { get; set; }

        ///// <summary>
        ///// TXA.15 - Filler Order Number.
        ///// </summary>
        //public FillerOrderNumber { get; set; }

        ///// <summary>
        ///// TXA.16 - Unique Document File Name.
        ///// </summary>
        //public UniqueDocumentFileName { get; set; }

        ///// <summary>
        ///// TXA.17 - Document Completion Status.
        ///// </summary>
        //public DocumentCompletionStatus { get; set; }

        ///// <summary>
        ///// TXA.18 - Document Confidentiality Status.
        ///// </summary>
        //public DocumentConfidentialityStatus { get; set; }

        ///// <summary>
        ///// TXA.19 - Document Availability Status.
        ///// </summary>
        //public DocumentAvailabilityStatus { get; set; }

        ///// <summary>
        ///// TXA.20 - Document Storage Status.
        ///// </summary>
        //public DocumentStorageStatus { get; set; }

        ///// <summary>
        ///// TXA.21 - Document Change Reason.
        ///// </summary>
        //public DocumentChangeReason { get; set; }

        ///// <summary>
        ///// TXA.22 - Authentication Person, Time Stamp (set).
        ///// </summary>
        //public AuthenticationPersonTimeStampSet { get; set; }

        ///// <summary>
        ///// TXA.23 - Distributed Copies (Code and Name of Recipient(s) ).
        ///// </summary>
        //public DistributedCopiesCodeAndNameOfRecipientS { get; set; }

        ///// <summary>
        ///// TXA.24 - Folder Assignment.
        ///// </summary>
        //public FolderAssignment { get; set; }

        ///// <summary>
        ///// TXA.25 - Document Title.
        ///// </summary>
        //public DocumentTitle { get; set; }

        ///// <summary>
        ///// TXA.26 - Agreed Due Date/Time.
        ///// </summary>
        //public AgreedDueDateTime { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}"
                                ).TrimEnd('|');
        }
    }
}