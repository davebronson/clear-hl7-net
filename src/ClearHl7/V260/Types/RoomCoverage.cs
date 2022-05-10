using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V260.Types
{
    /// <summary>
    /// HL7 Version 2 RMC - Room Coverage.
    /// </summary>
    public class RoomCoverage : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomCoverage"/> class.
        /// </summary>
        public RoomCoverage()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomCoverage"/> class.
        /// </summary>
        /// <param name="roomType">RMC.1 - Room Type.</param>
        public RoomCoverage(string roomType)
        {
            RoomType = roomType;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RMC.1 - Room Type.
        /// <para>Suggested: 0145 Room Type -&gt; ClearHl7.Codes.V260.CodeRoomType</para>
        /// </summary>
        public string RoomType { get; set; }

        /// <summary>
        /// RMC.2 - Amount Type.
        /// <para>Suggested: 0146 Amount Type -&gt; ClearHl7.Codes.V260.CodeAmountType</para>
        /// </summary>
        public string AmountType { get; set; }

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

            RoomType = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            AmountType = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            CoverageAmount = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            MoneyOrPercentage = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<MoneyOrPercentage>(segments[3], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                RoomType,
                                AmountType,
                                CoverageAmount.HasValue ? CoverageAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                MoneyOrPercentage?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
