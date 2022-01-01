namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0156 - Which Date/Time Qualifier.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0156</remarks>
    public enum CodeWhichDateTimeQualifier
    {
        /// <summary>
        /// ANY - Any date/time within a range.
        /// </summary>
        AnyDateTimeWithinRange,

        /// <summary>
        /// COL - Collection date/time, equivalent to film or sample collection date/time.
        /// </summary>
        CollectionDateTime,

        /// <summary>
        /// ORD - Order date/time.
        /// </summary>
        OrderDateTime,

        /// <summary>
        /// RCT - Specimen receipt date/time, receipt of specimen in filling ancillary (Lab).
        /// </summary>
        SpecimenReceiptDateTime,

        /// <summary>
        /// REP - Report date/time, report date/time at filling ancillary (i.e., Lab).
        /// </summary>
        ReportDateTime,

        /// <summary>
        /// SCHED - Schedule date/time.
        /// </summary>
        ScheduleDateTime
    }
}
