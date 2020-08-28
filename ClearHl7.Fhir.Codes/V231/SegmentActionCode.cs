using System;

namespace ClearHl7.Fhir.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0206 - Segment Action Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0206</remarks>
    public enum SegmentActionCode
    {
        /// <summary>
        /// A - Add/Insert.
        /// </summary>
        AddInsert,
        
        /// <summary>
        /// D - Delete.
        /// </summary>
        Delete,
        
        /// <summary>
        /// U - Update.
        /// </summary>
        Update
    }
}