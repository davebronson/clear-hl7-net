using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V260.Types
{
    /// <summary>
    /// HL7 Version 2 NA - Numeric Array.
    /// </summary>
    public class NumericArray : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumericArray"/> class.
        /// </summary>
        public NumericArray()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericArray"/> class.
        /// </summary>
        /// <param name="value1">NA.1 - Value1.</param>
        public NumericArray(decimal value1)
        {
            Value1 = value1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericArray"/> class.
        /// </summary>
        /// <param name="value1">NA.1 - Value1.</param>
        /// <param name="value2">NA.2 - Value2.</param>
        public NumericArray(decimal value1, decimal value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericArray"/> class.
        /// </summary>
        /// <param name="value1">NA.1 - Value1.</param>
        /// <param name="value2">NA.2 - Value2.</param>
        /// <param name="value3">NA.3 - Value3.</param>
        public NumericArray(decimal value1, decimal value2, decimal value3)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericArray"/> class.
        /// </summary>
        /// <param name="value1">NA.1 - Value1.</param>
        /// <param name="value2">NA.2 - Value2.</param>
        /// <param name="value3">NA.3 - Value3.</param>
        /// <param name="value4">NA.4 - Value4.</param>
        public NumericArray(decimal value1, decimal value2, decimal value3, decimal value4)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// NA.1 - Value1.
        /// </summary>
        public decimal? Value1 { get; set; }

        /// <summary>
        /// NA.2 - Value2.
        /// </summary>
        public decimal? Value2 { get; set; }

        /// <summary>
        /// NA.3 - Value3.
        /// </summary>
        public decimal? Value3 { get; set; }

        /// <summary>
        /// NA.4 - Value4.
        /// </summary>
        public decimal? Value4 { get; set; }

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

            Value1 = segments.Length > 0 && segments[0].Length > 0 ? segments[0].ToNullableDecimal() : null;
            Value2 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            Value3 = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            Value4 = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                Value1.HasValue ? Value1.Value.ToString(Consts.NumericFormat, culture) : null,
                                Value2.HasValue ? Value2.Value.ToString(Consts.NumericFormat, culture) : null,
                                Value3.HasValue ? Value3.Value.ToString(Consts.NumericFormat, culture) : null,
                                Value4.HasValue ? Value4.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
