namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0240 - Event Consequence.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0240</remarks>
    public enum CodeEventConsequence
    {
        /// <summary>
        /// C - Congenital anomaly/birth defect.
        /// </summary>
        CongenitalAnomalyBirthDefect,

        /// <summary>
        /// D - Death.
        /// </summary>
        Death,

        /// <summary>
        /// H - Caused hospitalized.
        /// </summary>
        CausedHospitalized,

        /// <summary>
        /// I - Incapacity which is significant, persistent or permanent.
        /// </summary>
        Incapacity,

        /// <summary>
        /// J - Disability which is significant, persistent or permanent.
        /// </summary>
        Disability,

        /// <summary>
        /// L - Life threatening.
        /// </summary>
        LifeThreatening,

        /// <summary>
        /// O - Other.
        /// </summary>
        Other,

        /// <summary>
        /// P - Prolonged hospitalization.
        /// </summary>
        ProlongedHospitalization,

        /// <summary>
        /// R - Required intervention to prevent permanent impairment/damage.
        /// </summary>
        RequiredIntervention
    }
}
