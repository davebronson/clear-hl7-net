namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0009 - Ambulatory Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0009</remarks>
    public enum CodeAmbulatoryStatus
    {
        /// <summary>
        /// A0 - No functional limitations.
        /// </summary>
        NoFunctionalLimitations,

        /// <summary>
        /// A1 - Ambulates with assistive device.
        /// </summary>
        AmbulatesWithAssistiveDevice,

        /// <summary>
        /// A2 - Wheelchair/stretcher bound.
        /// </summary>
        WheelchairStretcherBound,

        /// <summary>
        /// A3 - Comatose; non-responsive.
        /// </summary>
        ComatoseNonResponsive,

        /// <summary>
        /// A4 - Disoriented.
        /// </summary>
        Disoriented,

        /// <summary>
        /// A5 - Vision impaired.
        /// </summary>
        VisionImpaired,

        /// <summary>
        /// A6 - Hearing impaired.
        /// </summary>
        HearingImpaired,

        /// <summary>
        /// A7 - Speech impaired.
        /// </summary>
        SpeechImpaired,

        /// <summary>
        /// A8 - Non-English speaking.
        /// </summary>
        NonEnglishSpeaking,

        /// <summary>
        /// A9 - Functional level unknown.
        /// </summary>
        FunctionalLevelUnknown,

        /// <summary>
        /// B1 - Oxygen therapy.
        /// </summary>
        OxygenTherapy,

        /// <summary>
        /// B2 - Special equipment (tubes, IVs, catheters).
        /// </summary>
        SpecialEquipmentTubesIvsCatheters,

        /// <summary>
        /// B3 - Amputee.
        /// </summary>
        Amputee,

        /// <summary>
        /// B4 - Mastectomy.
        /// </summary>
        Mastectomy,

        /// <summary>
        /// B5 - Paraplegic.
        /// </summary>
        Paraplegic,

        /// <summary>
        /// B6 - Pregnant.
        /// </summary>
        Pregnant
    }
}
