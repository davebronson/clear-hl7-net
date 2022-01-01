namespace ClearHl7.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0544 - Container Condition.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0544</remarks>
    public enum CodeContainerCondition
    {
        /// <summary>
        /// CC - Container Cracked.
        /// </summary>
        ContainerCracked,

        /// <summary>
        /// CL - Container Leaking.
        /// </summary>
        ContainerLeaking,

        /// <summary>
        /// CT - Container Torn.
        /// </summary>
        ContainerTorn,

        /// <summary>
        /// SB - Seal Broken.
        /// </summary>
        SealBroken,

        /// <summary>
        /// XAMB - Not Ambient temperature.
        /// </summary>
        NotAmbientTemperature,

        /// <summary>
        /// XC37 - Not Body temperature.
        /// </summary>
        NotBodyTemperature,

        /// <summary>
        /// XCAMB - Not Critical ambient temperature.
        /// </summary>
        NotCriticalAmbientTemperature,

        /// <summary>
        /// XCATM - Exposed to Air.
        /// </summary>
        ExposedToAir,

        /// <summary>
        /// XCFRZ - Not Critical frozen temperature.
        /// </summary>
        NotCriticalFrozenTemperature,

        /// <summary>
        /// XCREF - Not Critical refrigerated temperature.
        /// </summary>
        NotCriticalRefrigeratedTemperature,

        /// <summary>
        /// XDFRZ - Not Deep frozen.
        /// </summary>
        NotDeepFrozen,

        /// <summary>
        /// XDRY - Not Dry.
        /// </summary>
        NotDry,

        /// <summary>
        /// XFRZ - Not Frozen temperature.
        /// </summary>
        NotFrozenTemperature,

        /// <summary>
        /// XMTLF - Metal Exposed.
        /// </summary>
        MetalExposed,

        /// <summary>
        /// XNTR - Not Liquid nitrogen.
        /// </summary>
        NotLiquidNitrogen,

        /// <summary>
        /// XPRTL - Not Protected from light.
        /// </summary>
        NotProtectedFromLight,

        /// <summary>
        /// XPSA - Shaken.
        /// </summary>
        Shaken,

        /// <summary>
        /// XPSO - Exposed to shock.
        /// </summary>
        ExposedToShock,

        /// <summary>
        /// XREF - Not Refrigerated temperature.
        /// </summary>
        NotRefrigeratedTemperature,

        /// <summary>
        /// XUFRZ - Not Ultra frozen.
        /// </summary>
        NotUltraFrozen,

        /// <summary>
        /// XUPR - Not Upright.
        /// </summary>
        NotUpright
    }
}
