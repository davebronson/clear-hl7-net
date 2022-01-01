namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0387 - Command Response.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0387</remarks>
    public enum CodeCommandResponse
    {
        /// <summary>
        /// ER - Command cannot be completed because of error condition.
        /// </summary>
        CommandCannotBeCompletedBecauseOfError,

        /// <summary>
        /// OK - Command completed successfully.
        /// </summary>
        CommandCompletedSuccessfully,

        /// <summary>
        /// ST - Command cannot be completed because of the status of the requested equipment.
        /// </summary>
        CommandCannotBeCompletedBecauseOfEquipmentStatus,

        /// <summary>
        /// TI - Command cannot be completed within requested completion time.
        /// </summary>
        CommandCannotBeCompletedWithinRequestedTime,

        /// <summary>
        /// UN - Command cannot be completed for unknown reasons.
        /// </summary>
        CommandCannotBeCompletedForUnknownReasons
    }
}
