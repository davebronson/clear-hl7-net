namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0191 - Type Of Referenced Data.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0191</remarks>
    public enum CodeTypeOfReferencedData
    {
        /// <summary>
        /// AP - Other application data, typically uninterpreted binary data (HL7 V2.3 and later).
        /// </summary>
        OtherApplicationData,

        /// <summary>
        /// AU - Audio data (HL7 V2.3 and later).
        /// </summary>
        AudioData,

        /// <summary>
        /// FT - Formatted text (HL7 V2.2 only).
        /// </summary>
        FormattedText,

        /// <summary>
        /// IM - Image data (HL7 V2.3 and later).
        /// </summary>
        ImageData,

        /// <summary>
        /// multipart - MIME multipart package.
        /// </summary>
        MimeMultipartPackage,

        /// <summary>
        /// NS - Non-scanned image (HL7 V2.2 only).
        /// </summary>
        NonScannedImage,

        /// <summary>
        /// SD - Scanned document (HL7 V2.2 only).
        /// </summary>
        ScannedDocument,

        /// <summary>
        /// SI - Scanned image (HL7 V2.2 only).
        /// </summary>
        ScannedImage,

        /// <summary>
        /// TEXT - Machine readable text document (HL7 V2.3.1 and later).
        /// </summary>
        MachineReadableTextDocument
    }
}
