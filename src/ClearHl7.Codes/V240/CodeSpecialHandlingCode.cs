namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0376 - Special Handling Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0376</remarks>
    public enum CodeSpecialHandlingCode
    {
        /// <summary>
        /// C37 - Body temperature.
        /// </summary>
        BodyTemperature,

        /// <summary>
        /// CAMB - Critical ambient temperature.
        /// </summary>
        CriticalAmbientTemperature,

        /// <summary>
        /// CATM - Protect from air.
        /// </summary>
        ProtectFromAir,

        /// <summary>
        /// CFRZ - Critical frozen temperature.
        /// </summary>
        CriticalFrozenTemperature,

        /// <summary>
        /// CREF - Critical refrigerated temperature.
        /// </summary>
        CriticalRefrigeratedTemperature,

        /// <summary>
        /// PRTL - Protect from light.
        /// </summary>
        ProtectFromLight
    }
}
