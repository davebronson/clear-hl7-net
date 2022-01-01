namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0272 - Document Confidentiality Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0272</remarks>
    public enum CodeDocumentConfidentialityStatus
    {
        /// <summary>
        /// 1 - ASTM Level 1.
        /// </summary>
        AstmLevel1,

        /// <summary>
        /// 2 - ASTM Level 2.
        /// </summary>
        AstmLevel2,

        /// <summary>
        /// 3 - ASTM Level 3.
        /// </summary>
        AstmLevel3,

        /// <summary>
        /// RE - Restricted.
        /// </summary>
        Restricted,

        /// <summary>
        /// UC - Usual control.
        /// </summary>
        UsualControl,

        /// <summary>
        /// VR - Very restricted.
        /// </summary>
        VeryRestricted
    }
}
