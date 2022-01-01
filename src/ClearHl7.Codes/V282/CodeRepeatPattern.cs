namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0335 - Repeat Pattern.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0335</remarks>
    public enum CodeRepeatPattern
    {
        /// <summary>
        /// A - Ante (before).
        /// </summary>
        AnteBefore,

        /// <summary>
        /// BID - twice a day at institution-specified times.
        /// </summary>
        TwiceADay,

        /// <summary>
        /// C - service is provided continuously between start time and stop time.
        /// </summary>
        ServiceProvidedContinuouslyBetweenStartAndStopTime,

        /// <summary>
        /// D - Cibus Diurnus (lunch).
        /// </summary>
        CibusDiurnusLunch,

        /// <summary>
        /// I - Inter.
        /// </summary>
        Inter,

        /// <summary>
        /// M - Cibus Matutinus (breakfast).
        /// </summary>
        CibusMatutinusBreakfast,

        /// <summary>
        /// Meal Related Timings - timingC ("cum")meal.
        /// </summary>
        TimingcCumMeal,

        /// <summary>
        /// Once - one time only.
        /// </summary>
        OneTimeOnly,

        /// <summary>
        /// P - Post (after).
        /// </summary>
        PostAfter,

        /// <summary>
        /// PRN - given as needed.
        /// </summary>
        GivenAsNeeded,

        /// <summary>
        /// PRNxxx - where xxx is some frequency code.
        /// </summary>
        WhereXxxIsSomeFrequencyCode,

        /// <summary>
        /// QintegerD - every integer days.
        /// </summary>
        EveryIntegerDays,

        /// <summary>
        /// QintegerH - every integer hours.
        /// </summary>
        EveryIntegerHours,

        /// <summary>
        /// QintegerJday# - repeats on a particular day of the week,.
        /// </summary>
        RepeatsOnParticularDayOfTheWeek,

        /// <summary>
        /// QintegerL - every integer months (Lunar cycle).
        /// </summary>
        EveryIntegerMonthsLunarCycle,

        /// <summary>
        /// QintegerM - every integer minutes.
        /// </summary>
        EveryIntegerMinutes,

        /// <summary>
        /// QintegerS - every integer seconds.
        /// </summary>
        EveryIntegerSeconds,

        /// <summary>
        /// QintegerW - every integer weeks.
        /// </summary>
        EveryIntegerWeeks,

        /// <summary>
        /// QAM - in the morning at institution-specified time.
        /// </summary>
        InTheMorning,

        /// <summary>
        /// QHS - every day before the hour of sleep.
        /// </summary>
        EveryDayBeforeTheHourOfSleep,

        /// <summary>
        /// QID - four times a day at institution-specified times.
        /// </summary>
        FourTimesDay,

        /// <summary>
        /// QOD - every other day.
        /// </summary>
        EveryOtherDay,

        /// <summary>
        /// QPM - in the evening at institution-specified time.
        /// </summary>
        InTheEvening,

        /// <summary>
        /// QSHIFT - during each of three eight-hour shifts at institution-specified times.
        /// </summary>
        DuringEachOfThreeEightHourShifts,

        /// <summary>
        /// TID - three times a day at institution-specified times.
        /// </summary>
        ThreeTimesADay,

        /// <summary>
        /// U spec - for future use, where spec is an interval specification as defined by the UNIX cron specification.
        /// </summary>
        UnixCron,

        /// <summary>
        /// V - Cibus Vespertinus (dinner).
        /// </summary>
        CibusVespertinusDinner,

        /// <summary>
        /// xID - "X" times per day at institution-specified times, where X is a numeral 5 or greater.
        /// </summary>
        XTimesPerDay
    }
}
