namespace ClearHl7.Fhir.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0116 - Bed Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0116</remarks>
    public enum BedStatus
    {
        /// <summary>
        /// C - Closed.
        /// </summary>
        Closed,
        
        /// <summary>
        /// H - Housekeeping.
        /// </summary>
        Housekeeping,
        
        /// <summary>
        /// I - Isolated.
        /// </summary>
        Isolated,
        
        /// <summary>
        /// K - Contaminated.
        /// </summary>
        Contaminated,
        
        /// <summary>
        /// O - Occupied.
        /// </summary>
        Occupied,
        
        /// <summary>
        /// U - Unoccupied.
        /// </summary>
        Unoccupied
    }
}