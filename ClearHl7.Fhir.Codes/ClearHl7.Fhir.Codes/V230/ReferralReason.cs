using System;

namespace ClearHl7.Fhir.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0336 - Referral Reason.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0336</remarks>
    public enum ReferralReason
    {
        /// <summary>
        /// O - Provider Ordered.
        /// </summary>
        ProviderOrdered,
        
        /// <summary>
        /// P - Patient Preference.
        /// </summary>
        PatientPreference,
        
        /// <summary>
        /// S - Second Opinion.
        /// </summary>
        SecondOpinion,
        
        /// <summary>
        /// W - Work Load.
        /// </summary>
        WorkLoad
    }
}