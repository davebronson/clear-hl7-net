namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0252 - Causality Observations.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0252</remarks>
    public enum CodeCausalityObservations
    {
        /// <summary>
        /// AW - Abatement of event after product withdrawn.
        /// </summary>
        AbatementOfEventAfterProductWithdrawn,

        /// <summary>
        /// BE - Event recurred after product reintroduced.
        /// </summary>
        EventRecurredAfterProductReintroduced,

        /// <summary>
        /// DR - Dose response observed.
        /// </summary>
        DoseResponseObserved,

        /// <summary>
        /// EX - Alternative explanations for the event available.
        /// </summary>
        AlternativeExplanationForEventAvailable,

        /// <summary>
        /// IN - Event occurred after product introduced.
        /// </summary>
        EventOccurredAfterProductIntroduced,

        /// <summary>
        /// LI - Literature reports association of product with event.
        /// </summary>
        LiteratureReportsAssociationOfProductWithEvent,

        /// <summary>
        /// OE - Occurrence of event was confirmed by objective evidence.
        /// </summary>
        OccurrenceOfEventConfirmedByObjectiveEvidence,

        /// <summary>
        /// OT - Other.
        /// </summary>
        Other,

        /// <summary>
        /// PL - Effect observed when patient receives placebo.
        /// </summary>
        EffectObservedWhenPatientReceivesPlacebo,

        /// <summary>
        /// SE - Similar events in past for this patient.
        /// </summary>
        SimilarEventsInPastForThisPatient,

        /// <summary>
        /// TC - Toxic levels of product documented in blood or body fluids.
        /// </summary>
        ToxicLevelsOfProductDocumented
    }
}
