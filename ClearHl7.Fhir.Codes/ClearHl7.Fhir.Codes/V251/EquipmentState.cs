using System;

namespace ClearHl7.Fhir.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0365 - Equipment State.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0365</remarks>
    public enum EquipmentState
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
        /// ES - E-stopped.
        /// </summary>
        EStopped,
        
        /// <summary>
        /// ID - Idle.
        /// </summary>
        Idle,
        
        /// <summary>
        /// IN - Initializing.
        /// </summary>
        Initializing,
        
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
        PoweredUp
    }
}