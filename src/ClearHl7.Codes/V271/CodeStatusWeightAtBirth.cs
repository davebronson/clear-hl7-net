namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0755 - Status Weight At Birth.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0755</remarks>
    public enum CodeStatusWeightAtBirth
    {
        /// <summary>
        /// 0 - No weight reported at admission used for grouping.
        /// </summary>
        NoWeightReportedAtAdmissionUsedForGrouping,

        /// <summary>
        /// 1 - Weight reported at admission used for grouping.
        /// </summary>
        WeightReportedAtAdmissionUsedForGrouping,

        /// <summary>
        /// 2 - Default weight (2499g) used for grouping.
        /// </summary>
        DefaultWeight2499GUsedForGrouping
    }
}
