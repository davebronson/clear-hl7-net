using ClearHl7.Fhir.Helpers;

namespace ClearHl7.Fhir.V290.Types
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
        /// <para>Suggested: 0076 Message Type -&gt; ClearHl7.Fhir.Codes.V290.CodeMessageType</para>
        /// </summary>
        public string MessageCode { get; set; }

        /// <summary>
        /// MSG.2 - Trigger Event.
        /// <para>Suggested: 0003 Event Type -&gt; ClearHl7.Fhir.Codes.V290.CodeEventType</para>
        /// </summary>
        public string TriggerEvent { get; set; }

        /// <summary>
        /// MSG.3 - Message Structure.
        /// <para>Suggested: 0354 Message Structure -&gt; ClearHl7.Fhir.Codes.V290.CodeMessageStructure</para>
        /// </summary>
        public string MessageStructure { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                MessageCode,
                                TriggerEvent,
                                MessageStructure
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
