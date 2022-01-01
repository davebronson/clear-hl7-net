namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0442 - Location Service Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0442</remarks>
    public enum CodeLocationServiceCode
    {
        /// <summary>
        /// D - Diagnostic.
        /// </summary>
        Diagnostic,

        /// <summary>
        /// E - Emergency Room Casualty.
        /// </summary>
        EmergencyRoomCasualty,

        /// <summary>
        /// P - Primary Care.
        /// </summary>
        PrimaryCare,

        /// <summary>
        /// T - Therapeutic.
        /// </summary>
        Therapeutic
    }
}
