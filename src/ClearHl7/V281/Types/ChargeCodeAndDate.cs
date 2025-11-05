using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V281.Types
{
    /// <summary>
    /// HL7 Version 2 CCD - Charge Code and Date.
    /// </summary>
    public class ChargeCodeAndDate : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeCodeAndDate"/> class.
        /// </summary>
        public ChargeCodeAndDate()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeCodeAndDate"/> class.
        /// </summary>
        /// <param name="invocationEvent">CCD.1 - Invocation Event.</param>
        public ChargeCodeAndDate(string invocationEvent)
        {
            InvocationEvent = invocationEvent;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CCD.1 - Invocation Event.
        /// <para>Suggested: 0100 Invocation Event -&gt; ClearHl7.Codes.V281.CodeInvocationEvent</para>
        /// </summary>
        public string InvocationEvent { get; set; }

        /// <summary>
        /// CCD.2 - Date/time.
        /// </summary>
        public DateTime? Datetime { get; set; }

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

            InvocationEvent = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            Datetime = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                InvocationEvent,
                                Datetime?.ToHl7DateTimeString(typeof(ChargeCodeAndDate), nameof(Datetime), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
