namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0256 - Time Delay Post Challenge.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0256</remarks>
    public enum CodeTimeDelayPostChallenge
    {
        /// <summary>
        /// 10D - 10 days.
        /// </summary>
        TenDays,

        /// <summary>
        /// 10M - 10 minutes post challenge.
        /// </summary>
        TenMinutesPostChallenge,

        /// <summary>
        /// 12H - 12 hours post challenge.
        /// </summary>
        TwelveHoursPostChallenge,

        /// <summary>
        /// 15M - 15 minutes post challenge.
        /// </summary>
        FifteenMinutesPostChallenge,

        /// <summary>
        /// 1H - 1 hour post challenge.
        /// </summary>
        OneHourPostChallenge,

        /// <summary>
        /// 1L - 1 month (30 days) post challenge.
        /// </summary>
        OneMonthPostChallenge,

        /// <summary>
        /// 1M - 1 minute post challenge.
        /// </summary>
        OneMinutePostChallenge,

        /// <summary>
        /// 1W - 1 week.
        /// </summary>
        OneWeek,

        /// <summary>
        /// 2.5H - 2 1/2 hours post challenge.
        /// </summary>
        TwoAndAHalfHoursPostChallenge,

        /// <summary>
        /// 20M - 20 minutes post challenge.
        /// </summary>
        TwentyMinutesPostChallenge,

        /// <summary>
        /// 24H - 24 hours post challenge.
        /// </summary>
        TwentyFourHoursPostChallenge,

        /// <summary>
        /// 25M - 25 minutes post challenge.
        /// </summary>
        TwentyFiveMinutesPostChallenge,

        /// <summary>
        /// 2D - 2 days.
        /// </summary>
        TwoDays,

        /// <summary>
        /// 2H - 2 hours post challenge.
        /// </summary>
        TwoHoursPostChallenge,

        /// <summary>
        /// 2L - 2 months (60 days) post challenge.
        /// </summary>
        TwoMonthsPostChallenge,

        /// <summary>
        /// 2M - 2 minutes post challenge.
        /// </summary>
        TwoMinutesPostChallenge,

        /// <summary>
        /// 2W - 2 weeks.
        /// </summary>
        TwoWeeks,

        /// <summary>
        /// 30M - 30 minutes post challenge.
        /// </summary>
        ThirtyMinutesPostChallenge,

        /// <summary>
        /// 3D - 3 days.
        /// </summary>
        ThreeDays,

        /// <summary>
        /// 3H - 3 hours post challenge.
        /// </summary>
        ThreeHoursPostChallenge,

        /// <summary>
        /// 3L - 3 months (90 days) post challenge.
        /// </summary>
        ThreeMonthsPostChallenge,

        /// <summary>
        /// 3M - 3 minutes post challenge.
        /// </summary>
        ThreeMinutesPostChallenge,

        /// <summary>
        /// 3W - 3 weeks.
        /// </summary>
        ThreeWeeks,

        /// <summary>
        /// 4D - 4 days.
        /// </summary>
        FourDays,

        /// <summary>
        /// 4H - 4 hours post challenge.
        /// </summary>
        FourHoursPostChallenge,

        /// <summary>
        /// 4M - 4 minutes post challenge.
        /// </summary>
        FourMinutesPostChallenge,

        /// <summary>
        /// 4W - 4 weeks.
        /// </summary>
        FourWeeks,

        /// <summary>
        /// 5D - 5 days.
        /// </summary>
        FiveDays,

        /// <summary>
        /// 5H - 5  hours post challenge.
        /// </summary>
        FiveHoursPostChallenge,

        /// <summary>
        /// 5M - 5 minutes post challenge.
        /// </summary>
        FiveMinutesPostChallenge,

        /// <summary>
        /// 6D - 6 days.
        /// </summary>
        SixDays,

        /// <summary>
        /// 6H - 6 hours post challenge.
        /// </summary>
        SixHoursPostChallenge,

        /// <summary>
        /// 6M - 6 minutes post challenge.
        /// </summary>
        SixMinutesPostChallenge,

        /// <summary>
        /// 7D - 7 days.
        /// </summary>
        SevenDays,

        /// <summary>
        /// 7H - 7 hours post challenge.
        /// </summary>
        SevenHoursPostChallenge,

        /// <summary>
        /// 7M - 7 minutes post challenge.
        /// </summary>
        SevenMinutesPostChallenge,

        /// <summary>
        /// 8H - 8 hours post challenge.
        /// </summary>
        EightHoursPostChallenge,

        /// <summary>
        /// 8H SHIFT - 8 hours aligned on nursing shifts.
        /// </summary>
        EightHoursAlignedOnNursingShifts,

        /// <summary>
        /// 8M - 8 minutes post challenge.
        /// </summary>
        EightMinutesPostChallenge,

        /// <summary>
        /// 9M - 9 minutes post challenge.
        /// </summary>
        NineMinutesPostChallenge,

        /// <summary>
        /// BS - Baseline (time just before the challenge).
        /// </summary>
        Baseline,

        /// <summary>
        /// PEAK - The time post drug dose at which the highest drug level is reached (differs by drug).
        /// </summary>
        TimePostDrugDoseHighestDrugLevelReached,

        /// <summary>
        /// RANDOM - Time from the challenge, or dose not specified. (random).
        /// </summary>
        TimeFromChallengeOrDoseNotSpecified,

        /// <summary>
        /// TROUGH - The time post drug dose at which the lowest drug level is reached (varies with drug).
        /// </summary>
        TimePostDrugDoseLowestDrugLevelReached
    }
}
