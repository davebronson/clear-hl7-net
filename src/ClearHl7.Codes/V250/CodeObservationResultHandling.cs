namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0507 - Observation Result Handling.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0507</remarks>
    public enum CodeObservationResultHandling
    {
        /// <summary>
        /// F - Film-with-patient.
        /// </summary>
        FilmWithPatient,

        /// <summary>
        /// N - Notify provider when ready.
        /// </summary>
        NotifyProviderWhenReady
    }
}
