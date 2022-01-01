namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0376 - Special Handling Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0376</remarks>
    public enum CodeSpecialHandlingCode
    {
        /// <summary>
        /// AMB - Ambient temperature.
        /// </summary>
        AmbientTemperature,

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
        /// DFRZ - Deep frozen.
        /// </summary>
        DeepFrozen,

        /// <summary>
        /// DRY - Dry.
        /// </summary>
        Dry,

        /// <summary>
        /// FRZ - Frozen temperature.
        /// </summary>
        FrozenTemperature,

        /// <summary>
        /// MTLF - Metal Free.
        /// </summary>
        MetalFree,

        /// <summary>
        /// NTR - Liquid nitrogen.
        /// </summary>
        LiquidNitrogen,

        /// <summary>
        /// PRTL - Protect from light.
        /// </summary>
        ProtectFromLight,

        /// <summary>
        /// PSA - Do not shake.
        /// </summary>
        DoNotShake,

        /// <summary>
        /// PSO - No shock.
        /// </summary>
        NoShock,

        /// <summary>
        /// REF - Refrigerated temperature.
        /// </summary>
        RefrigeratedTemperature,

        /// <summary>
        /// UFRZ - Ultra frozen.
        /// </summary>
        UltraFrozen,

        /// <summary>
        /// UPR - Upright.
        /// </summary>
        Upright
    }
}
