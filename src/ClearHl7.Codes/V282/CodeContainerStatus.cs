namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0370 - Container Status.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0370</remarks>
    public enum CodeContainerStatus
    {
        /// <summary>
        /// I - Identified.
        /// </summary>
        Identified,

        /// <summary>
        /// L - Left Equipment.
        /// </summary>
        LeftEquipment,

        /// <summary>
        /// M - Missing.
        /// </summary>
        Missing,

        /// <summary>
        /// O - In Process.
        /// </summary>
        InProcess,

        /// <summary>
        /// P - In Position.
        /// </summary>
        InPosition,

        /// <summary>
        /// R - Process Completed.
        /// </summary>
        ProcessCompleted,

        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// X - Container Unavailable.
        /// </summary>
        ContainerUnavailable
    }
}
