namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0430 - Mode Of Arrival Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0430</remarks>
    public enum CodeModeOfArrivalCode
    {
        /// <summary>
        /// A - Ambulance.
        /// </summary>
        Ambulance,

        /// <summary>
        /// C - Car.
        /// </summary>
        Car,

        /// <summary>
        /// F - On foot.
        /// </summary>
        OnFoot,

        /// <summary>
        /// H - Helicopter.
        /// </summary>
        Helicopter,

        /// <summary>
        /// O - Other.
        /// </summary>
        Other,

        /// <summary>
        /// P - Public Transport.
        /// </summary>
        PublicTransport,

        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown
    }
}
