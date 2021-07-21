using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V231.Types
{
    /// <summary>
    /// HL7 Version 2 UVC - Value Code And Amount.
    /// </summary>
    public class ValueCodeAndAmount : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// UVC.1 - Value Code.
        /// <para>Suggested: 0153 Value Code -&gt; ClearHl7.Codes.V231.CodeValueCode</para>
        /// </summary>
        public CodedWithNoExceptions ValueCode { get; set; }

        /// <summary>
        /// UVC.2 - Value Amount.
        /// </summary>
        public Money ValueAmount { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            if (segments.Length > 0)
            {
                ValueCode = new CodedWithNoExceptions { IsSubcomponent = true };
                ValueCode.FromDelimitedString(segments.ElementAtOrDefault(0));
            }
            else
            {
                ValueCode = null;
            }

            if (segments.Length > 1)
            {
                ValueAmount = new Money { IsSubcomponent = true };
                ValueAmount.FromDelimitedString(segments.ElementAtOrDefault(1));
            }
            else
            {
                ValueAmount = null;
            }
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
                                StringHelper.StringFormatSequence(0, 2, separator),
                                ValueCode?.ToDelimitedString(),
                                ValueAmount?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
