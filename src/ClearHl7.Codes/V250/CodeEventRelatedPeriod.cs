namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0528 - Event Related Period.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0528</remarks>
    public enum CodeEventRelatedPeriod
    {
        /// <summary>
        /// AC - before meal (from lat. ante cibus).
        /// </summary>
        BeforeMealFromLatAnteCibus,

        /// <summary>
        /// ACD - before lunch (from lat. ante cibus diurnus).
        /// </summary>
        BeforeLunchFromLatAnteCibusDiurnus,

        /// <summary>
        /// ACM - before breakfast (from lat. ante cibus matutinus).
        /// </summary>
        BeforeBreakfastFromLatAnteCibusMatutinus,

        /// <summary>
        /// ACV - before dinner (from lat. ante cibus vespertinus).
        /// </summary>
        BeforeDinnerFromLatAnteCibusVespertinus,

        /// <summary>
        /// HS - the hour of sleep (e.g., H18-22).
        /// </summary>
        TheHourOfSleepEGH1822,

        /// <summary>
        /// IC - between meals (from lat. inter cibus).
        /// </summary>
        BetweenMealsFromLatInterCibus,

        /// <summary>
        /// ICD - between lunch and dinner.
        /// </summary>
        BetweenLunchAndDinner,

        /// <summary>
        /// ICM - between breakfast and lunch.
        /// </summary>
        BetweenBreakfastAndLunch,

        /// <summary>
        /// ICV - between dinner and the hour of sleep.
        /// </summary>
        BetweenDinnerAndTheHourOfSleep,

        /// <summary>
        /// PC - after meal (from lat. post cibus).
        /// </summary>
        AfterMealFromLatPostCibus,

        /// <summary>
        /// PCD - after lunch (from lat. post cibus diurnus).
        /// </summary>
        AfterLunchFromLatPostCibusDiurnus,

        /// <summary>
        /// PCM - after breakfast (from lat. post cibus matutinus).
        /// </summary>
        AfterBreakfastFromLatPostCibusMatutinus,

        /// <summary>
        /// PCV - after dinner (from lat. post cibus vespertinus).
        /// </summary>
        AfterDinnerFromLatPostCibusVespertinus
    }
}
