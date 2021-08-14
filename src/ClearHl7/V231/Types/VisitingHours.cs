using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V231.Types
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
        /// <para>Suggested: 0267 Days Of The Week -&gt; ClearHl7.Codes.V231.CodeDaysOfTheWeek</para>
        /// </summary>
        public string StartDayRange { get; set; }

        /// <summary>
        /// VH.2 - End Day Range.
        /// <para>Suggested: 0267 Days Of The Week -&gt; ClearHl7.Codes.V231.CodeDaysOfTheWeek</para>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            StartDayRange = segments.ElementAtOrDefault(0);
            EndDayRange = segments.ElementAtOrDefault(1);
            StartHourRange = segments.ElementAtOrDefault(2)?.ToNullableDateTime();
            EndHourRange = segments.ElementAtOrDefault(3)?.ToNullableDateTime();
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
