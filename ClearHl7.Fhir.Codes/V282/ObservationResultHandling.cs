namespace ClearHl7.Fhir.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0507 - Observation Result Handling.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0507</remarks>
    public enum ObservationResultHandling
    {
        /// <summary>
        /// A - Alert provider when abnormal.
        /// </summary>
        AlertProviderWhenAbnormal,
        
        /// <summary>
        /// BCC - Blind copy.
        /// </summary>
        BlindCopy,
        
        /// <summary>
        /// CC - Copies requested.
        /// </summary>
        CopiesRequested,
        
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