using System;

namespace ClearHl7.Fhir.Codes.V220
{
    /// <summary>
    /// HL7 Version 2 Table 0191 - Type Of Referenced Data.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0191</remarks>
    public enum TypeOfReferencedData
    {
        /// <summary>
        /// FT - Formatted text (HL7 V2.2 only).
        /// </summary>
        FormattedText,
        
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
        /// TX - Machine readable text document (HL7 V2.2 only).
        /// </summary>
        MachineReadableTextDocument
    }
}