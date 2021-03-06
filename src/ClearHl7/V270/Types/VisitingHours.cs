﻿using System;
using ClearHl7.Helpers;

namespace ClearHl7.V270.Types
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
        /// <para>Suggested: 0267 Days Of The Week -&gt; ClearHl7.Codes.V270.CodeDaysOfTheWeek</para>
        /// </summary>
        public string StartDayRange { get; set; }

        /// <summary>
        /// VH.2 - End Day Range.
        /// <para>Suggested: 0267 Days Of The Week -&gt; ClearHl7.Codes.V270.CodeDaysOfTheWeek</para>
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
