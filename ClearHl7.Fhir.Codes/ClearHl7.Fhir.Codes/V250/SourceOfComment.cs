using System;

namespace ClearHl7.Fhir.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0105 - Source Of Comment.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0105</remarks>
    public enum SourceOfComment
    {
        /// <summary>
        /// L - Ancillary (filler) department is source of comment.
        /// </summary>
        AncillaryDepartmentIsSourceOfComment,
        
        /// <summary>
        /// O - Other system is source of comment.
        /// </summary>
        OtherSystemIsSourceOfComment,
        
        /// <summary>
        /// P - Orderer (placer) is source of comment.
        /// </summary>
        OrdererIsSourceOfComment
    }
}