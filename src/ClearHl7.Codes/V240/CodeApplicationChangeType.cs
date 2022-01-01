namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0409 - Application Change Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0409</remarks>
    public enum CodeApplicationChangeType
    {
        /// <summary>
        /// M - Migrates to different CPU.
        /// </summary>
        MigratesToDifferentCpu,

        /// <summary>
        /// SD - Shut down.
        /// </summary>
        ShutDown,

        /// <summary>
        /// SU - Start up.
        /// </summary>
        StartUp
    }
}
