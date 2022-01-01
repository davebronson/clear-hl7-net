namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0924 - Cumulative Dosage Limit UoM.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0924</remarks>
    public enum CodeCumulativeDosageLimitUom
    {
        /// <summary>
        /// A - Annual.
        /// </summary>
        Annual,

        /// <summary>
        /// D - Per Day.
        /// </summary>
        PerDay,

        /// <summary>
        /// M - Per Month.
        /// </summary>
        PerMonth,

        /// <summary>
        /// O - Duration of the Order.
        /// </summary>
        DurationOfTheOrder,

        /// <summary>
        /// PL - Patients Lifetime.
        /// </summary>
        PatientsLifetime,

        /// <summary>
        /// WK - Per Week.
        /// </summary>
        PerWeek
    }
}
