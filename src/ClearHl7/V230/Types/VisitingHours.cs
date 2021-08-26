using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Types
{
    /// <summary>
    /// HL7 Version 2 VH - Visiting Hours.
    /// </summary>
    public class VisitingHours : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// VH.1 - Start Day Range.
        /// <para>Suggested: 0267 Days Of The Week -&gt; ClearHl7.Codes.V230.CodeDaysOfTheWeek</para>
        /// </summary>
        public string StartDayRange { get; set; }

        /// <summary>
        /// VH.2 - End Day Range.
        /// <para>Suggested: 0267 Days Of The Week -&gt; ClearHl7.Codes.V230.CodeDaysOfTheWeek</para>
        /// </summary>
        public string EndDayRange { get; set; }

        /// <summary>
        /// VH.3 - Start Hour Range.
        /// </summary>
        public DateTime? StartHourRange { get; set; }

        /// <summary>
        /// VH.4 - End Hour Range.
        /// </summary>
        public DateTime? EndHourRange { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(separator, StringSplitOptions.None);

            StartDayRange = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            EndDayRange = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            StartHourRange = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            EndHourRange = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
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
                                StringHelper.StringFormatSequence(0, 4, separator),
                                StartDayRange,
                                EndDayRange,
                                StartHourRange.HasValue ? StartHourRange.Value.ToString(Consts.TimeFormatPrecisionSecond, culture) : null,
                                EndHourRange.HasValue ? EndHourRange.Value.ToString(Consts.TimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
