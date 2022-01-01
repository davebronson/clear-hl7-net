namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0294 - Time Selection Criteria Parameter Class Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0294</remarks>
    public enum CodeTimeSelectionCriteriaParameterClassCodes
    {
        /// <summary>
        /// Fri - An indicator that Friday is or is not preferred for the day on which the appointment will occur.
        /// </summary>
        Friday,

        /// <summary>
        /// Mon - An indicator that Monday is or is not preferred for the day on which the appointment will occur.
        /// </summary>
        Monday,

        /// <summary>
        /// Prefend - An indicator that there is a preferred end time for the appointment request, service or resource.
        /// </summary>
        IsPreferredEndTime,

        /// <summary>
        /// Prefstart - An indicator that there is a preferred start time for the appointment request, service or resource.
        /// </summary>
        IsPreferredStartTime,

        /// <summary>
        /// Sat - An indicator that Saturday is or is not preferred for the day on which the appointment will occur.
        /// </summary>
        Saturday,

        /// <summary>
        /// Sun - An indicator that Sunday is or is not preferred for the day on which the appointment will occur.
        /// </summary>
        Sunday,

        /// <summary>
        /// Thu - An indicator that Thursday is or is not preferred for the day on which the appointment will occur.
        /// </summary>
        Thursday,

        /// <summary>
        /// Tue - An indicator that Tuesday is or is not preferred for the day on which the appointment will occur.
        /// </summary>
        Tuesday,

        /// <summary>
        /// Wed - An indicator that Wednesday is or is not preferred for the day on which the appointment will occur.
        /// </summary>
        Wednesday
    }
}
