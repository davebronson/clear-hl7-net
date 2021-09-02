using System; 
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V250.Types
{
    /// <summary>
    /// HL7 Version 2 SN - Structured Numeric.
    /// </summary>
    public class StructuredNumeric : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// SN.1 - Comparator.
        /// </summary>
        public string Comparator { get; set; }

        /// <summary>
        /// SN.2 - Num1.
        /// </summary>
        public decimal? Num1 { get; set; }

        /// <summary>
        /// SN.3 - Separator/Suffix.
        /// </summary>
        public string SeparatorSuffix { get; set; }

        /// <summary>
        /// SN.4 - Num2.
        /// </summary>
        public decimal? Num2 { get; set; }

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
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            Comparator = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            Num1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            SeparatorSuffix = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            Num2 = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
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
                                Comparator,
                                Num1.HasValue ? Num1.Value.ToString(Consts.NumericFormat, culture) : null,
                                SeparatorSuffix,
                                Num2.HasValue ? Num2.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
