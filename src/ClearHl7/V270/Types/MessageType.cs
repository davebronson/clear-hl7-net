using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V270.Types
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
        /// <para>Suggested: 0076 Message Type -&gt; ClearHl7.Codes.V270.CodeMessageType</para>
        /// </summary>
        public string MessageCode { get; set; }

        /// <summary>
        /// MSG.2 - Trigger Event.
        /// <para>Suggested: 0003 Event Type Code -&gt; ClearHl7.Codes.V270.CodeEventTypeCode</para>
        /// </summary>
        public string TriggerEvent { get; set; }

        /// <summary>
        /// MSG.3 - Message Structure.
        /// <para>Suggested: 0354 Message Structure -&gt; ClearHl7.Codes.V270.CodeMessageStructure</para>
        /// </summary>
        public string MessageStructure { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            MessageCode = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            TriggerEvent = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            MessageStructure = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
        }

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
