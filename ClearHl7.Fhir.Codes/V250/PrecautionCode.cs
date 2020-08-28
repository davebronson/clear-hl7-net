using System;

namespace ClearHl7.Fhir.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0433 - Precaution Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0433</remarks>
    public enum PrecautionCode
    {
        /// <summary>
        /// A - Aggressive.
        /// </summary>
        Aggressive,
        
        /// <summary>
        /// B - Blind.
        /// </summary>
        Blind,
        
        /// <summary>
        /// C - Confused.
        /// </summary>
        Confused,
        
        /// <summary>
        /// D - Deaf.
        /// </summary>
        Deaf,
        
        /// <summary>
        /// I - On IV.
        /// </summary>
        OnIv,
        
        /// <summary>
        /// N - Do not resuscitate.
        /// </summary>
        DoNotResuscitate,
        
        /// <summary>
        /// O - Other.
        /// </summary>
        Other,
        
        /// <summary>
        /// P - Paraplegic.
        /// </summary>
        Paraplegic,
        
        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown
    }
}