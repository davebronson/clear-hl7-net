﻿using System; 
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V231.Types
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
        /// <para>Suggested: 0205 Price Type -&gt; ClearHl7.Codes.V231.CodePriceType</para>
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
        public CodedElement RangeUnits { get; set; }

        /// <summary>
        /// CP.6 - Range Type.
        /// <para>Suggested: 0298 CP Range Type -&gt; ClearHl7.Codes.V231.CodeCpRangeType</para>
        /// </summary>
        public string RangeType { get; set; }

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

            Price = segments.Length > 0 && segments[0].Length > 0 ? TypeHelper.Deserialize<Money>(segments[0], true) : null;
            PriceType = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            FromValue = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            ToValue = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            RangeUnits = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[4], true) : null;
            RangeType = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
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
