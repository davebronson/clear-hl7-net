namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0124 - Transportation Mode.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0124</remarks>
    public enum CodeTransportationMode
    {
        /// <summary>
        /// CART - Cart - patient travels on cart or gurney.
        /// </summary>
        CartPatientTravelsOnCartOrGurney,

        /// <summary>
        /// PORT - The examining device goes to patient's location.
        /// </summary>
        TheExaminingDeviceGoesToPatientsLocation,

        /// <summary>
        /// WALK - Patient walks to diagnostic service.
        /// </summary>
        PatientWalksToDiagnosticService,

        /// <summary>
        /// WHLC - Wheelchair.
        /// </summary>
        Wheelchair
    }
}
