namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0230 - Procedure Functional Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0230</remarks>
    public enum CodeProcedureFunctionalType
    {
        /// <summary>
        /// A - Anesthesia.
        /// </summary>
        Anesthesia,

        /// <summary>
        /// D - Diagnostic procedure.
        /// </summary>
        DiagnosticProcedure,

        /// <summary>
        /// I - Invasive procedure not classified elsewhere (e.g., IV, catheter, etc.).
        /// </summary>
        InvasiveProcedureNotClassified,

        /// <summary>
        /// P - Procedure for treatment (therapeutic, including operations).
        /// </summary>
        ProcedureForTreatment
    }
}
