namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0298 - CP Range Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0298</remarks>
    public enum CodeCpRangeType
    {
        /// <summary>
        /// F - Flat-rate. Apply the entire price to this interval, do not pro-rate the price if the full interval has not occurred/been consumed.
        /// </summary>
        FlatRate,

        /// <summary>
        /// P - Pro-rate. Apply this price to this interval, pro-rated by whatever portion of the interval has occurred/been consumed.
        /// </summary>
        ProRate
    }
}
