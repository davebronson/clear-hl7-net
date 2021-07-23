using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V270.Types
{
    /// <summary>
    /// HL7 Version 2 CP - Composite Price.
    /// </summary>
    public class CompositePrice : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CP.1 - Price.
        /// </summary>
        public Money Price { get; set; }

        /// <summary>
        /// CP.2 - Price Type.
        /// <para>Suggested: 0205 Price Type -&gt; ClearHl7.Codes.V270.CodePriceType</para>
        /// </summary>
        public string PriceType { get; set; }

        /// <summary>
        /// CP.3 - From Value.
        /// </summary>
        public decimal? FromValue { get; set; }

        /// <summary>
        /// CP.4 - To Value.
        /// </summary>
        public decimal? ToValue { get; set; }

        /// <summary>
        /// CP.5 - Range Units.
        /// </summary>
        public CodedWithExceptions RangeUnits { get; set; }

        /// <summary>
        /// CP.6 - Range Type.
        /// <para>Suggested: 0298 CP Range Type -&gt; ClearHl7.Codes.V270.CodeCpRangeType</para>
        /// </summary>
        public string RangeType { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            Price = segments.Length > 0 ? TypeHelper.Deserialize<Money>(segments.ElementAtOrDefault(0), true) : null;
            PriceType = segments.ElementAtOrDefault(1);
            FromValue = segments.ElementAtOrDefault(2)?.ToNullableDecimal();
            ToValue = segments.ElementAtOrDefault(3)?.ToNullableDecimal();
            RangeUnits = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), true) : null;
            RangeType = segments.ElementAtOrDefault(5);
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
                                StringHelper.StringFormatSequence(0, 6, separator),
                                Price?.ToDelimitedString(),
                                PriceType,
                                FromValue.HasValue ? FromValue.Value.ToString(Consts.NumericFormat, culture) : null,
                                ToValue.HasValue ? ToValue.Value.ToString(Consts.NumericFormat, culture) : null,
                                RangeUnits?.ToDelimitedString(),
                                RangeType
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
