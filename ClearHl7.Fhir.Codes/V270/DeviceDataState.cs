using System;

namespace ClearHl7.Fhir.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0667 - Device Data State.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0667</remarks>
    public enum DeviceDataState
    {
        /// <summary>
        /// 0 - Real Time Values.
        /// </summary>
        RealTimeValues,
        
        /// <summary>
        /// 1 - Historic Values.
        /// </summary>
        HistoricValues
    }
}