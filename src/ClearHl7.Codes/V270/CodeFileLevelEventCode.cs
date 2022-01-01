namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0178 - File Level Event Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0178</remarks>
    public enum CodeFileLevelEventCode
    {
        /// <summary>
        /// REP - Replace current version of this master file with the version contained in this message.
        /// </summary>
        ReplaceCurrentVersionOfMasterFile,

        /// <summary>
        /// UPD - Change file records as defined in the record-level event codes for each record that follows.
        /// </summary>
        ChangeFileRecordsAsDefined
    }
}
