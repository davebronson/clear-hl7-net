using System;

namespace ClearHl7.Fhir.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0657 - Device Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0657</remarks>
    public enum DeviceType
    {
        /// <summary>
        /// 1 - EO Gas Sterilizer.
        /// </summary>
        EoGasSterilizer,
        
        /// <summary>
        /// 2 - Steam Sterilizer.
        /// </summary>
        SteamSterilizer,
        
        /// <summary>
        /// 3 - Peracetic Acid.
        /// </summary>
        PeraceticAcid
    }
}