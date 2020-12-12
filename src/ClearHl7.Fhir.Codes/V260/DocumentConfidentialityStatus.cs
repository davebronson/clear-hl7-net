namespace ClearHl7.Fhir.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0272 - Document Confidentiality Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0272</remarks>
    public enum DocumentConfidentialityStatus
    {
        /// <summary>
        /// R - Restricted.
        /// </summary>
        Restricted,
        
        /// <summary>
        /// U - Usual control.
        /// </summary>
        UsualControl,
        
        /// <summary>
        /// V - Very restricted.
        /// </summary>
        VeryRestricted
    }
}