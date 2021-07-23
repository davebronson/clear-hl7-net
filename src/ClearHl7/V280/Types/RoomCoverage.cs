using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V280.Types
{
    /// <summary>
    /// HL7 Version 2 RMC - Room Coverage.
    /// </summary>
    public class RoomCoverage : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// RMC.1 - Room Type.
        /// <para>Suggested: 0145 Room Type -&gt; ClearHl7.Codes.V280.CodeRoomType</para>
        /// </summary>
        public CodedWithExceptions RoomType { get; set; }

        /// <summary>
        /// RMC.2 - Amount Type.
        /// <para>Suggested: 0146 Amount Type -&gt; ClearHl7.Codes.V280.CodeAmountType</para>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            RoomType = segments.Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(0), true) : null;
            AmountType = segments.Length > 1 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(1), true) : null;
            CoverageAmount = segments.ElementAtOrDefault(2)?.ToNullableDecimal();
            MoneyOrPercentage = segments.Length > 3 ? TypeHelper.Deserialize<MoneyOrPercentage>(segments.ElementAtOrDefault(3), true) : null;
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
                                RoomType?.ToDelimitedString(),
                                AmountType?.ToDelimitedString(),
                                CoverageAmount.HasValue ? CoverageAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                MoneyOrPercentage?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
