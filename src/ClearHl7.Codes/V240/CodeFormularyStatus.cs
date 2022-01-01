namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0473 - Formulary Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0473</remarks>
    public enum CodeFormularyStatus
    {
        /// <summary>
        /// G - This observation/service is on the formulary, and has guidelines.
        /// </summary>
        ThisObservationServiceIsOnFormularyAndHasGuidelines,

        /// <summary>
        /// N - This observation/service is not on the formulary.
        /// </summary>
        ThisObservationServiceIsNotOnFormulary,

        /// <summary>
        /// R - This observation/service is on the formulary, but is restricted.
        /// </summary>
        ThisObservationServiceIsOnFormularyButIsRestricted,

        /// <summary>
        /// Y - This observation/service is on the formulary.
        /// </summary>
        ThisObservationServiceIsOnFormulary
    }
}
