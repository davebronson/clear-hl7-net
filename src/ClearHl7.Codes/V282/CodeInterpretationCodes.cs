namespace ClearHl7.Codes.V282
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
        /// AC - Anti-complementary substances present.
        /// </summary>
        AntiComplementarySubstancesPresent,

        /// <summary>
        /// B - Better.
        /// </summary>
        Better,

        /// <summary>
        /// D - Significant change down.
        /// </summary>
        SignificantChangeDown,

        /// <summary>
        /// DET - Detected.
        /// </summary>
        Detected,

        /// <summary>
        /// H - High.
        /// </summary>
        High,

        /// <summary>
        /// HH - Critically high.
        /// </summary>
        CriticallyHigh,

        /// <summary>
        /// HM - Hold for Medical Review.
        /// </summary>
        HoldForMedicalReview,

        /// <summary>
        /// HU - Very high.
        /// </summary>
        VeryHigh,

        /// <summary>
        /// I - Intermediate.
        /// </summary>
        Intermediate,

        /// <summary>
        /// IE - Insufficient evidence.
        /// </summary>
        InsufficientEvidence,

        /// <summary>
        /// IND - Indeterminate.
        /// </summary>
        Indeterminate,

        /// <summary>
        /// L - Low.
        /// </summary>
        Low,

        /// <summary>
        /// LL - Critically low.
        /// </summary>
        CriticallyLow,

        /// <summary>
        /// LU - Very low.
        /// </summary>
        VeryLow,

        /// <summary>
        /// MS - Moderately susceptible. Indicates for microbiology susceptibilities only.
        /// </summary>
        ModeratelySusceptible,

        /// <summary>
        /// N - Normal.
        /// </summary>
        Normal,

        /// <summary>
        /// ND - Not Detected.
        /// </summary>
        NotDetected,

        /// <summary>
        /// NEG - Negative.
        /// </summary>
        Negative,

        /// <summary>
        /// NR - Non-reactive.
        /// </summary>
        NonReactive,

        /// <summary>
        /// NS - Non-susceptible.
        /// </summary>
        NonSusceptible,

        /// <summary>
        /// null - No range defined, or normal ranges don't apply.
        /// </summary>
        NoRangeDefinedOrNormalRangesDontApply,

        /// <summary>
        /// OBX - Interpretation qualifiers in separate OBX segments.
        /// </summary>
        InterpretationQualifiersInSeparateObxSegments,

        /// <summary>
        /// POS - Positive.
        /// </summary>
        Positive,

        /// <summary>
        /// QCF - Quality Control Failure.
        /// </summary>
        QualityControlFailure,

        /// <summary>
        /// R - Resistant.
        /// </summary>
        Resistant,

        /// <summary>
        /// RR - Reactive.
        /// </summary>
        Reactive,

        /// <summary>
        /// S - Susceptible.
        /// </summary>
        Susceptible,

        /// <summary>
        /// SDD - Susceptible-dose dependent.
        /// </summary>
        SusceptibleDoseDependent,

        /// <summary>
        /// SYN-R - Synergy - resistant.
        /// </summary>
        SynergyResistant,

        /// <summary>
        /// SYN-S - Synergy - susceptible.
        /// </summary>
        SynergySusceptible,

        /// <summary>
        /// TOX - Cytotoxic substance present.
        /// </summary>
        CytotoxicSubstancePresent,

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
        Worse,

        /// <summary>
        /// WR - Weakly reactive.
        /// </summary>
        WeaklyReactive
    }
}
