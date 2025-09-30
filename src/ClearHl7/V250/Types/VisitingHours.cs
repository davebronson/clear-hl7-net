using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V250.Types
{
    /// <summary>
    /// HL7 Version 2 VH - Visiting Hours.
    /// </summary>
    public class VisitingHours : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisitingHours"/> class.
        /// </summary>
        public VisitingHours()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitingHours"/> class.
        /// </summary>
        /// <param name="startHourRange">VH.3 - Start Hour Range.</param>
        /// <param name="endHourRange">VH.4 - End Hour Range.</param>
        public VisitingHours(DateTime startHourRange, DateTime endHourRange)
        {
            StartHourRange = startHourRange;
            EndHourRange = endHourRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitingHours"/> class.
        /// </summary>
        /// <param name="startDayRange">VH.1 - Start Day Range.</param>
        /// <param name="endDayRange">VH.2 - End Day Range.</param>
        /// <param name="startHourRange">VH.3 - Start Hour Range.</param>
        /// <param name="endHourRange">VH.4 - End Hour Range.</param>
        public VisitingHours(string startDayRange, string endDayRange, DateTime startHourRange, DateTime endHourRange)
        {
            StartDayRange = startDayRange;
            EndDayRange = endDayRange;
            StartHourRange = startHourRange;
            EndHourRange = endHourRange;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// VH.1 - Start Day Range.
        /// <para>Suggested: 0267 Days Of The Week -&gt; ClearHl7.Codes.V250.CodeDaysOfTheWeek</para>
        /// </summary>
        public string StartDayRange { get; set; }

        /// <summary>
        /// VH.2 - End Day Range.
        /// <para>Suggested: 0267 Days Of The Week -&gt; ClearHl7.Codes.V250.CodeDaysOfTheWeek</para>
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

            StartDayRange = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            EndDayRange = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            StartHourRange = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            EndHourRange = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                StartDayRange,
                                EndDayRange,
                                StartHourRange?.ToHl7DateTimeString(typeof(VisitingHours), nameof(StartHourRange), Consts.TimeFormatPrecisionSecond, culture),
                                EndHourRange?.ToHl7DateTimeString(typeof(VisitingHours), nameof(EndHourRange), Consts.TimeFormatPrecisionSecond, culture)
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
