namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0517 - Inform Person Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0517</remarks>
    public enum CodeInformPersonCode
    {
        /// <summary>
        /// HD - Inform help desk.
        /// </summary>
        InformHelpDesk,

        /// <summary>
        /// NPAT - Do NOT inform patient.
        /// </summary>
        DoNotInformPatient,

        /// <summary>
        /// PAT - Inform patient.
        /// </summary>
        InformPatient,

        /// <summary>
        /// USR - Inform User.
        /// </summary>
        InformUser
    }
}
