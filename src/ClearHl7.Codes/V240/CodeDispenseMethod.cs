namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0321 - Dispense Method.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0321</remarks>
    public enum CodeDispenseMethod
    {
        /// <summary>
        /// AD - Automatic Dispensing.
        /// </summary>
        AutomaticDispensing,

        /// <summary>
        /// F - Floor Stock.
        /// </summary>
        FloorStock,

        /// <summary>
        /// TR - Traditional.
        /// </summary>
        Traditional,

        /// <summary>
        /// UD - Unit Dose.
        /// </summary>
        UnitDose
    }
}
