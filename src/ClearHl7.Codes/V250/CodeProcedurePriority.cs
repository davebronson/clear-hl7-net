namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0418 - Procedure Priority.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0418</remarks>
    public enum CodeProcedurePriority
    {
        /// <summary>
        /// 0 - the admitting procedure.
        /// </summary>
        TheAdmittingProcedure,

        /// <summary>
        /// 1 - the primary procedure.
        /// </summary>
        ThePrimaryProcedure,

        /// <summary>
        /// 2 - for ranked secondary procedures.
        /// </summary>
        ForRankedSecondaryProcedures
    }
}
