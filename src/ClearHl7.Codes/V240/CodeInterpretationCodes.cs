namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0078 - Interpretation Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0078</remarks>
    public enum CodeInterpretationCodes
    {
        /// <summary>
        ///  - Off scale low.
        /// </summary>
        OffScaleLow,

        /// <summary>
        ///  - Off scale high.
        /// </summary>
        OffScaleHigh,

        /// <summary>
        /// A - Abnormal.
        /// </summary>
        Abnormal,

        /// <summary>
        /// AA - Critically abnormal.
        /// </summary>
        CriticallyAbnormal,

        /// <summary>
        /// B - Better.
        /// </summary>
        Better,

        /// <summary>
        /// D - Significant change down.
        /// </summary>
        SignificantChangeDown,

        /// <summary>
        /// H - High.
        /// </summary>
        High,

        /// <summary>
        /// HH - Critically high.
        /// </summary>
        CriticallyHigh,

        /// <summary>
        /// I - Intermediate.
        /// </summary>
        Intermediate,

        /// <summary>
        /// L - Low.
        /// </summary>
        Low,

        /// <summary>
        /// LL - Critically low.
        /// </summary>
        CriticallyLow,

        /// <summary>
        /// MS - Moderately susceptible. Indicates for microbiology susceptibilities only.
        /// </summary>
        ModeratelySusceptible,

        /// <summary>
        /// N - Normal.
        /// </summary>
        Normal,

        /// <summary>
        /// null - No range defined, or normal ranges don't apply.
        /// </summary>
        NoRangeDefinedOrNormalRangesDontApply,

        /// <summary>
        /// R - Resistant.
        /// </summary>
        Resistant,

        /// <summary>
        /// S - Susceptible.
        /// </summary>
        Susceptible,

        /// <summary>
        /// U - Significant change up.
        /// </summary>
        SignificantChangeUp,

        /// <summary>
        /// VS - Very susceptible. Indicates for microbiology susceptibilities only.
        /// </summary>
        VerySusceptible,

        /// <summary>
        /// W - Worse.
        /// </summary>
        Worse
    }
}
