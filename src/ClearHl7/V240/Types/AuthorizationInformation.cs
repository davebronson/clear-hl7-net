﻿using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
{
    /// <summary>
    /// HL7 Version 2 AUI - Authorization Information.
    /// </summary>
    public class AuthorizationInformation : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// AUI.1 - Authorization Number.
        /// </summary>
        public string AuthorizationNumber { get; set; }

        /// <summary>
        /// AUI.2 - Date.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// AUI.3 - Source.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public AuthorizationInformation FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            AuthorizationNumber = segments.ElementAtOrDefault(0);
            Date = segments.ElementAtOrDefault(1)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            Source = segments.ElementAtOrDefault(2);

            return this;
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
                                AuthorizationNumber,
                                Date.HasValue ? Date.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                Source
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
