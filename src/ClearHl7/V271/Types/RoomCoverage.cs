﻿using System;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 RMC - Room Coverage.
    /// </summary>
    public class RoomCoverage : IType
    {
        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RMC.1 - Room Type.
        /// <para>Suggested: 0145 Room Type -&gt; ClearHl7.Codes.V271.CodeRoomType</para>
        /// </summary>
        public CodedWithExceptions RoomType { get; set; }

        /// <summary>
        /// RMC.2 - Amount Type.
        /// <para>Suggested: 0146 Amount Type -&gt; ClearHl7.Codes.V271.CodeAmountType</para>
        /// </summary>
        public CodedWithExceptions AmountType { get; set; }

        /// <summary>
        /// RMC.3 - Coverage Amount.
        /// </summary>
        public decimal? CoverageAmount { get; set; }

        /// <summary>
        /// RMC.4 - Money or Percentage.
        /// </summary>
        public MoneyOrPercentage MoneyOrPercentage { get; set; }

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

            RoomType = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[0], true, seps) : null;
            AmountType = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], true, seps) : null;
            CoverageAmount = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            MoneyOrPercentage = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<MoneyOrPercentage>(segments[3], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                RoomType?.ToDelimitedString(),
                                AmountType?.ToDelimitedString(),
                                CoverageAmount.HasValue ? CoverageAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                MoneyOrPercentage?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
