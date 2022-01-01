namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0778 - Item Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0778</remarks>
    public enum CodeItemType
    {
        /// <summary>
        /// EQP - Equipment.
        /// </summary>
        Equipment,

        /// <summary>
        /// IMP - Implant.
        /// </summary>
        Implant,

        /// <summary>
        /// MED - Medication.
        /// </summary>
        Medication,

        /// <summary>
        /// SUP - Supply.
        /// </summary>
        Supply,

        /// <summary>
        /// TDC - Tubes, Drains, and Catheters.
        /// </summary>
        TubesDrainsAndCatheters
    }
}
