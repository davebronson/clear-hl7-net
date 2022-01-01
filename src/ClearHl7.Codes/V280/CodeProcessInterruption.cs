namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0923 - Process Interruption.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0923</remarks>
    public enum CodeProcessInterruption
    {
        /// <summary>
        /// ABR - Aborted Run: Process interrupted after the Phlebotomist inserts the needle in the Donor's arm.
        /// </summary>
        AbortedRun,

        /// <summary>
        /// NIN - Process was not interrupted.
        /// </summary>
        ProcessWasNotInterrupted,

        /// <summary>
        /// WOT - Walk Out: Process interrupted before the Phlebotomist inserts the needle in the Donor's arm.
        /// </summary>
        WalkOut
    }
}
