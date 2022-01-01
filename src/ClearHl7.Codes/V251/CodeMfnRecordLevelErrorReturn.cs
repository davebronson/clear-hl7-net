namespace ClearHl7.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0181 - MFN Record-Level Error Return.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0181</remarks>
    public enum CodeMfnRecordLevelErrorReturn
    {
        /// <summary>
        /// S - Successful posting of the record defined by the MFE segment.
        /// </summary>
        SuccessfulPostingOfTheRecord,

        /// <summary>
        /// U - Unsuccessful posting of the record defined by the MFE segment.
        /// </summary>
        UnsuccessfulPostingOfTheRecord
    }
}
