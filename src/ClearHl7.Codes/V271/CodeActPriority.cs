namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0906 - ActPriority.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0906</remarks>
    public enum CodeActPriority
    {
        /// <summary>
        /// A - ASAP - As soon as possible, next highest priority after stat.
        /// </summary>
        AsSoonAsPossible,

        /// <summary>
        /// CR - Callback results - filler should contact the placer as soon as results are available, even for preliminary results.
        /// </summary>
        CallbackResults,

        /// <summary>
        /// CS - Callback for scheduling - Filler should contact the placer (or target) to schedule the service.
        /// </summary>
        CallbackForScheduling,

        /// <summary>
        /// CSP - Callback placer for scheduling - filler should contact the placer to schedule the service.
        /// </summary>
        CallbackPlacerForScheduling,

        /// <summary>
        /// CSR - Contact recipient for scheduling - Filler should contact the service recipient (target) to schedule the service.
        /// </summary>
        ContactRecipientForScheduling,

        /// <summary>
        /// EL - Elective - Beneficial to the patient but not essential for survival.
        /// </summary>
        Elective,

        /// <summary>
        /// EM - Emergency - An unforeseen combination of circumstances or the resulting state that calls for immediate action.
        /// </summary>
        Emergency,

        /// <summary>
        /// P - Preop - Used to indicate that a service is to be performed prior to a scheduled surgery.  When ordering a service and using the pre-op priority, a check is done to see the amount of time that must be allowed for performance of the service.  When the order.
        /// </summary>
        Preop,

        /// <summary>
        /// PRN - As needed - An "as needed" order should be accompanied by a description of what constitutes a need.  This description is represented by an observation service predicate as a precondition.
        /// </summary>
        AsNeeded,

        /// <summary>
        /// R - Routine - Routine service, do at usual work hours.
        /// </summary>
        Routine,

        /// <summary>
        /// RR - Rush reporting - A report should be prepared and sent as quickly as possible.
        /// </summary>
        RushReporting,

        /// <summary>
        /// S - Stat - With highest priority (e.g. emergency).
        /// </summary>
        Stat,

        /// <summary>
        /// T - Timing critical - It is critical to come as close as possible to the requested time (e.g. for a through antimicrobial level).
        /// </summary>
        TimingCritical,

        /// <summary>
        /// UD - Use as directed - Drug is to be used as directed by the prescriber.
        /// </summary>
        UseAsDirected,

        /// <summary>
        /// UR - Urgent - Calls for prompt action.
        /// </summary>
        Urgent
    }
}
