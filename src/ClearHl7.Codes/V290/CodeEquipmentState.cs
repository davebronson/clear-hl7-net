namespace ClearHl7.Codes.V290
{
    /// <summary>
    /// HL7 Version 2 Table 0365 - Equipment State.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0365</remarks>
    public enum CodeEquipmentState
    {
        /// <summary>
        /// CL - Clearing.
        /// </summary>
        Clearing,

        /// <summary>
        /// CO - Configuring.
        /// </summary>
        Configuring,

        /// <summary>
        /// DI - Diagnose.
        /// </summary>
        Diagnose,

        /// <summary>
        /// ES - E-stopped.
        /// </summary>
        EStopped,

        /// <summary>
        /// FL - Failure.
        /// </summary>
        Failure,

        /// <summary>
        /// ID - Idle.
        /// </summary>
        Idle,

        /// <summary>
        /// IN - Initializing.
        /// </summary>
        Initializing,

        /// <summary>
        /// LT - Limited test menu.
        /// </summary>
        LimitedTestMenu,

        /// <summary>
        /// MA - Maintenance.
        /// </summary>
        Maintenance,

        /// <summary>
        /// OP - Normal Operation.
        /// </summary>
        NormalOperation,

        /// <summary>
        /// PA - Pausing.
        /// </summary>
        Pausing,

        /// <summary>
        /// PD - Paused.
        /// </summary>
        Paused,

        /// <summary>
        /// PU - Powered Up.
        /// </summary>
        PoweredUp,

        /// <summary>
        /// RS - Ready to start.
        /// </summary>
        ReadyToStart,

        /// <summary>
        /// SD - Shutting down.
        /// </summary>
        ShuttingDown,

        /// <summary>
        /// SS - Sampling stopped.
        /// </summary>
        SamplingStopped,

        /// <summary>
        /// TS - Transport stopped.
        /// </summary>
        TransportStopped,

        /// <summary>
        /// UNK - Unknown.
        /// </summary>
        Unknown
    }
}
