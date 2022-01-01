namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0569 - Adjustment Action.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0569</remarks>
    public enum CodeAdjustmentAction
    {
        /// <summary>
        /// EOB - Print on EOB.
        /// </summary>
        PrintOnEob,

        /// <summary>
        /// PAT - Inform Patient.
        /// </summary>
        InformPatient,

        /// <summary>
        /// PRO - Inform Provider.
        /// </summary>
        InformProvider
    }
}
