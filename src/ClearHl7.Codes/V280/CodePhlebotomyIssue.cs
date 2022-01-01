namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0925 - Phlebotomy Issue.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0925</remarks>
    public enum CodePhlebotomyIssue
    {
        /// <summary>
        /// ACN - Air Contamination.
        /// </summary>
        AirContamination,

        /// <summary>
        /// CLT - Clotted.
        /// </summary>
        Clotted,

        /// <summary>
        /// COL - Collapse.
        /// </summary>
        Collapse,

        /// <summary>
        /// DAK - Defective Apheresis Kit.
        /// </summary>
        DefectiveApheresisKit,

        /// <summary>
        /// DBG - Defective Bag.
        /// </summary>
        DefectiveBag,

        /// <summary>
        /// DMT - Defective Instrument.
        /// </summary>
        DefectiveInstrument,

        /// <summary>
        /// DND - Defective Needle.
        /// </summary>
        DefectiveNeedle,

        /// <summary>
        /// INF - Infiltration.
        /// </summary>
        Infiltration,

        /// <summary>
        /// IPF - Instrument Power Failure.
        /// </summary>
        InstrumentPowerFailure,

        /// <summary>
        /// MIS - Missed / in tissue.
        /// </summary>
        MissedInTissue,

        /// <summary>
        /// NAD - Needle adjustment (this may not end a procedure, if successful will impact component production).
        /// </summary>
        NeedleAdjustment,

        /// <summary>
        /// PFL - Poor flow.
        /// </summary>
        PoorFlow,

        /// <summary>
        /// VSM - Vein Spasm.
        /// </summary>
        VeinSpasm
    }
}
