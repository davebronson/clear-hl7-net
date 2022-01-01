namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0324 - Location Characteristic ID.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0324</remarks>
    public enum CodeLocationCharacteristicId
    {
        /// <summary>
        /// GEN - Gender of patient(s).
        /// </summary>
        GenderOfPatientS,

        /// <summary>
        /// IMP - Implant: can be used for radiation implant patients.
        /// </summary>
        Implant,

        /// <summary>
        /// INF - Infectious disease: this location can be used for isolation.
        /// </summary>
        InfectiousDisease,

        /// <summary>
        /// LCR - Level of care.
        /// </summary>
        LevelOfCare,

        /// <summary>
        /// LIC - Licensed.
        /// </summary>
        Licensed,

        /// <summary>
        /// OVR - Overflow.
        /// </summary>
        Overflow,

        /// <summary>
        /// PRL - Privacy level: indicating the level of private versus non-private room.
        /// </summary>
        PrivacyLevel,

        /// <summary>
        /// SET - Bed is set up.
        /// </summary>
        BedIsSetUp,

        /// <summary>
        /// SHA - Shadow: a temporary holding location that does not physically exist.
        /// </summary>
        Shadow,

        /// <summary>
        /// SMK - Smoking.
        /// </summary>
        Smoking,

        /// <summary>
        /// STF - Bed is staffed.
        /// </summary>
        BedIsStaffed,

        /// <summary>
        /// TEA - Teaching location.
        /// </summary>
        TeachingLocation
    }
}
