namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0368 - Remote Control Command.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0368</remarks>
    public enum CodeRemoteControlCommand
    {
        /// <summary>
        /// AB - Abort.
        /// </summary>
        Abort,

        /// <summary>
        /// CL - Clear.
        /// </summary>
        Clear,

        /// <summary>
        /// CN - Clear Notification.
        /// </summary>
        ClearNotification,

        /// <summary>
        /// DI - Disable Sending Events.
        /// </summary>
        DisableSendingEvents,

        /// <summary>
        /// EN - Enable Sending Events.
        /// </summary>
        EnableSendingEvents,

        /// <summary>
        /// ES - Emergency -stop.
        /// </summary>
        EmergencyStop,

        /// <summary>
        /// EX - Execute (command specified in field Parameters (ST) 01394).
        /// </summary>
        Execute,

        /// <summary>
        /// IN - Initialize/Initiate.
        /// </summary>
        Initialize,

        /// <summary>
        /// LC - Local Control Request.
        /// </summary>
        LocalControlRequest,

        /// <summary>
        /// LK - Lock.
        /// </summary>
        Lock,

        /// <summary>
        /// LO - Load.
        /// </summary>
        Load,

        /// <summary>
        /// PA - Pause.
        /// </summary>
        Pause,

        /// <summary>
        /// RC - Remote Control Request.
        /// </summary>
        RemoteControlRequest,

        /// <summary>
        /// RE - Resume.
        /// </summary>
        Resume,

        /// <summary>
        /// SA - Sampling.
        /// </summary>
        Sampling,

        /// <summary>
        /// SU - Setup.
        /// </summary>
        Setup,

        /// <summary>
        /// TT - Transport To.
        /// </summary>
        TransportTo,

        /// <summary>
        /// UC - Unlock.
        /// </summary>
        Unlock,

        /// <summary>
        /// UN - Unload.
        /// </summary>
        Unload
    }
}
