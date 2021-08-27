using System; 
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V280.Types
{
    /// <summary>
    /// HL7 Version 2 DLT - Delta.
    /// </summary>
    public class Delta : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// DLT.1 - Normal Range.
        /// </summary>
        public NumericRange NormalRange { get; set; }

        /// <summary>
        /// DLT.2 - Numeric Threshold.
        /// </summary>
        public decimal? NumericThreshold { get; set; }

        /// <summary>
        /// DLT.3 - Change Computation.
        /// <para>Suggested: 0523 Computation Type -&gt; ClearHl7.Codes.V280.CodeComputationType</para>
        /// </summary>
        public string ChangeComputation { get; set; }

        /// <summary>
        /// DLT.4 - Days Retained.
        /// </summary>
        public decimal? DaysRetained { get; set; }

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
                ? new string[] { }
                : delimitedString.Split(separator, StringSplitOptions.None);

            NormalRange = segments.Length > 0 && segments[0].Length > 0 ? TypeHelper.Deserialize<NumericRange>(segments[0], true) : null;
            NumericThreshold = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            ChangeComputation = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            DaysRetained = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
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
                                NormalRange?.ToDelimitedString(),
                                NumericThreshold.HasValue ? NumericThreshold.Value.ToString(Consts.NumericFormat, culture) : null,
                                ChangeComputation,
                                DaysRetained.HasValue ? DaysRetained.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
