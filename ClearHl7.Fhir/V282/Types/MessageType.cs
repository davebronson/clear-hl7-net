using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 MSG - Message Type.
    /// </summary>
    public class MessageType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// MSG.1 - Message Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0076</remarks>
        public string MessageCode { get; set; }

        /// <summary>
        /// MSG.2 - Trigger Event.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0003</remarks>
        public string TriggerEvent { get; set; }

        /// <summary>
        /// MSG.3 - Message Structure.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0354</remarks>
        public string MessageStructure { get; set; }
    }
}
