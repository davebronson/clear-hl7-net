namespace ClearHl7.Codes.V231
{
    /// <summary>
    /// HL7 Version 2 Table 0277 - Appointment Type Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0277</remarks>
    public enum CodeAppointmentTypeCodes
    {
        /// <summary>
        /// Complete - A request to add a completed appointment, used to maintain records of completed appointments that did not appear in the schedule (e.g., STAT, walk-in, etc.).
        /// </summary>
        RequestToAddCompletedAppointment,

        /// <summary>
        /// Normal - Routine schedule request type â€“ default if not valued.
        /// </summary>
        RoutineScheduleRequestTypeDefaultIfNotValued,

        /// <summary>
        /// Tentative - A request for a tentative (e.g., â€œpenciled inâ€) appointment.
        /// </summary>
        RequestForTentativeAppointment
    }
}
