namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0527 - Calendar Alignment.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0527</remarks>
    public enum CodeCalendarAlignment
    {
        /// <summary>
        /// DM - day of the month.
        /// </summary>
        DayOfTheMonth,

        /// <summary>
        /// DW - day of the week (begins with Monday).
        /// </summary>
        DayOfTheWeekBeginsWithMonday,

        /// <summary>
        /// DY - day of the year.
        /// </summary>
        DayOfTheYear,

        /// <summary>
        /// HD - hour of the day.
        /// </summary>
        HourOfTheDay,

        /// <summary>
        /// MY - month of the year.
        /// </summary>
        MonthOfTheYear,

        /// <summary>
        /// NH - minute of the hour.
        /// </summary>
        MinuteOfTheHour,

        /// <summary>
        /// SN - second of the minute.
        /// </summary>
        SecondOfTheMinute,

        /// <summary>
        /// WY - week of the year.
        /// </summary>
        WeekOfTheYear
    }
}
