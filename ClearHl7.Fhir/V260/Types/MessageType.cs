using System;

namespace ClearHl7.Fhir.V260.Types
{
    /// <summary>
    /// HL7 Version 2 MSG - Message Type.
    /// </summary>
    public class MessageType : IType
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

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}" : "{0}^{1}^{2}",
                                MessageCode,
                                TriggerEvent,
                                MessageStructure
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
