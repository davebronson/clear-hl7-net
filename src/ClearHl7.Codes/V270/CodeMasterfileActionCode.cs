namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0180 - Masterfile Action Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0180</remarks>
    public enum CodeMasterfileActionCode
    {
        /// <summary>
        /// MAC - Reactivate deactivated record.
        /// </summary>
        ReactivateDeactivatedRecord,

        /// <summary>
        /// MAD - Add record to master file.
        /// </summary>
        AddRecordToMasterFile,

        /// <summary>
        /// MDC - Deactivate: discontinue using record in master file, but do not delete from database.
        /// </summary>
        Deactivate,

        /// <summary>
        /// MDL - Delete record from master file.
        /// </summary>
        DeleteRecordFromMasterFile,

        /// <summary>
        /// MUP - Update record for master file.
        /// </summary>
        UpdateRecordForMasterFile
    }
}
