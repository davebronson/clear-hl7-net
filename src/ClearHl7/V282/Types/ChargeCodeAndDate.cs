using System;
using ClearHl7.Helpers;

namespace ClearHl7.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CCD - Charge Code and Date.
    /// </summary>
    public class ChargeCodeAndDate : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CCD.1 - Invocation Event.
        /// <para>Suggested: 0100 Invocation Event -&gt; ClearHl7.Codes.V282.CodeInvocationEvent</para>
        /// </summary>
        public string InvocationEvent { get; set; }

        /// <summary>
        /// CCD.2 - Date/time.
        /// </summary>
        public DateTime? Datetime { get; set; }

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
                                InvocationEvent,
                                Datetime.HasValue ? Datetime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
