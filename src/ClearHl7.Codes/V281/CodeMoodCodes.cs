namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0725 - Mood Codes.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0725</remarks>
    public enum CodeMoodCodes
    {
        /// <summary>
        /// APT - Appointment.
        /// </summary>
        Appointment,

        /// <summary>
        /// ARQ - Appointment Request.
        /// </summary>
        AppointmentRequest,

        /// <summary>
        /// EVN - Event.
        /// </summary>
        Event,

        /// <summary>
        /// EVN.CRT - Event Criterion.
        /// </summary>
        EventCriterion,

        /// <summary>
        /// EXP - Expectation.
        /// </summary>
        Expectation,

        /// <summary>
        /// INT - Intent.
        /// </summary>
        Intent,

        /// <summary>
        /// PRMS - Promise.
        /// </summary>
        Promise,

        /// <summary>
        /// PRP - Proposal.
        /// </summary>
        Proposal,

        /// <summary>
        /// RQO - Request-Order.
        /// </summary>
        RequestOrder
    }
}
