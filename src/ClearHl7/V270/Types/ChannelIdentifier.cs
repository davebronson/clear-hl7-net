﻿using System;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V270.Types
{
    /// <summary>
    /// HL7 Version 2 WVI - Channel Identifier.
    /// </summary>
    public class ChannelIdentifier : IType
    {
        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// WVI.1 - Channel Number.
        /// </summary>
        public decimal? ChannelNumber { get; set; }

        /// <summary>
        /// WVI.2 - Channel Name.
        /// </summary>
        public string ChannelName { get; set; }

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

            ChannelNumber = segments.Length > 0 && segments[0].Length > 0 ? segments[0].ToNullableDecimal() : null;
            ChannelName = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                ChannelNumber.HasValue ? ChannelNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                ChannelName
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
