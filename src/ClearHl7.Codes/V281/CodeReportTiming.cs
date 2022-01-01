namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0234 - Report Timing.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0234</remarks>
    public enum CodeReportTiming
    {
        /// <summary>
        /// 10D - 10 day report.
        /// </summary>
        TenDayReport,

        /// <summary>
        /// 15D - 15 day report.
        /// </summary>
        FifteenDayReport,

        /// <summary>
        /// 30D - 30 day report.
        /// </summary>
        ThirtyDayReport,

        /// <summary>
        /// 3D - 3 day report.
        /// </summary>
        ThreeDayReport,

        /// <summary>
        /// 7D - 7 day report.
        /// </summary>
        SevenDayReport,

        /// <summary>
        /// AD - Additional information.
        /// </summary>
        AdditionalInformation,

        /// <summary>
        /// CO - Correction.
        /// </summary>
        Correction,

        /// <summary>
        /// DE - Device evaluation.
        /// </summary>
        DeviceEvaluation,

        /// <summary>
        /// PD - Periodic.
        /// </summary>
        Periodic,

        /// <summary>
        /// RQ - Requested information.
        /// </summary>
        RequestedInformation
    }
}
