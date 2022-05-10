using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
{
    /// <summary>
    /// HL7 Version 2 MSG - Message Type.
    /// </summary>
    public class MessageType : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageType"/> class.
        /// </summary>
        public MessageType()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageType"/> class.
        /// </summary>
        /// <param name="messageCode">MSG.1 - Message Code.</param>
        /// <param name="triggerEvent">MSG.2 - Trigger Event.</param>
        /// <param name="messageStructure">MSG.3 - Message Structure.</param>
        public MessageType(string messageCode, string triggerEvent, string messageStructure)
        {
            MessageCode = messageCode;
            TriggerEvent = triggerEvent;
            MessageStructure = messageStructure;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// MSG.1 - Message Code.
        /// <para>Suggested: 0076 Message Type -&gt; ClearHl7.Codes.V240.CodeMessageType</para>
        /// </summary>
        public string MessageCode { get; set; }

        /// <summary>
        /// MSG.2 - Trigger Event.
        /// <para>Suggested: 0003 Event Type Code -&gt; ClearHl7.Codes.V240.CodeEventTypeCode</para>
        /// </summary>
        public string TriggerEvent { get; set; }

        /// <summary>
        /// MSG.3 - Message Structure.
        /// <para>Suggested: 0354 Message Structure -&gt; ClearHl7.Codes.V240.CodeMessageStructure</para>
        /// </summary>
        public string MessageStructure { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            MessageCode = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            TriggerEvent = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            MessageStructure = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
