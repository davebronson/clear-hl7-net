namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0417 - Tissue Type Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0417</remarks>
    public enum CodeTissueTypeCode
    {
        /// <summary>
        /// 0 - No tissue expected.
        /// </summary>
        NoTissueExpected,

        /// <summary>
        /// 1 - Insufficient Tissue.
        /// </summary>
        InsufficientTissue,

        /// <summary>
        /// 2 - Not abnormal.
        /// </summary>
        NotAbnormal,

        /// <summary>
        /// 3 - Abnormal-not categorized.
        /// </summary>
        AbnormalNotCategorized,

        /// <summary>
        /// 4 - Mechanical abnormal.
        /// </summary>
        MechanicalAbnormal,

        /// <summary>
        /// 5 - Growth alteration.
        /// </summary>
        GrowthAlteration,

        /// <summary>
        /// 6 - Degeneration  necrosis.
        /// </summary>
        DegenerationNecrosis,

        /// <summary>
        /// 7 - Non-acute inflammation.
        /// </summary>
        NonAcuteInflammation,

        /// <summary>
        /// 8 - Non-malignant neoplasm.
        /// </summary>
        NonMalignantNeoplasm,

        /// <summary>
        /// 9 - Malignant neoplasm.
        /// </summary>
        MalignantNeoplasm,

        /// <summary>
        /// B - Basal cell carcinoma.
        /// </summary>
        BasalCellCarcinoma,

        /// <summary>
        /// C - Carcinoma-unspecified type.
        /// </summary>
        CarcinomaUnspecifiedType,

        /// <summary>
        /// G - Additional tissue required.
        /// </summary>
        AdditionalTissueRequired
    }
}
