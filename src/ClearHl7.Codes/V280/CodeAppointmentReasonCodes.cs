namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0276 - Appointment Reason Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0276</remarks>
    public enum CodeAppointmentReasonCodes
    {
        /// <summary>
        /// CHECKUP - A routine check-up, such as an annual physical.
        /// </summary>
        ARoutineCheckUpSuchAsAnAnnualPhysical,

        /// <summary>
        /// EMERGENCY - Emergency appointment.
        /// </summary>
        EmergencyAppointment,

        /// <summary>
        /// FOLLOWUP - A follow up visit from a previous appointment.
        /// </summary>
        AFollowUpVisitFromAPreviousAppointment,

        /// <summary>
        /// ROUTINE - Routine appointment - default if not valued.
        /// </summary>
        RoutineAppointmentDefaultIfNotValued,

        /// <summary>
        /// WALKIN - A previously unscheduled walk-in visit.
        /// </summary>
        APreviouslyUnscheduledWalkInVisit
    }
}
