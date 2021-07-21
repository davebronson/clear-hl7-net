using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V270.Types
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
        /// <para>Suggested: 0523 Computation Type -&gt; ClearHl7.Codes.V270.CodeComputationType</para>
        /// </summary>
        public string ChangeComputation { get; set; }

        /// <summary>
        /// DLT.4 - Days Retained.
        /// </summary>
        public decimal? DaysRetained { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            if (segments.Length > 0)
            {
                NormalRange = new NumericRange { IsSubcomponent = true };
                NormalRange.FromDelimitedString(segments.ElementAtOrDefault(0));
            }
            else
            {
                NormalRange = null;
            }

            NumericThreshold = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            ChangeComputation = segments.ElementAtOrDefault(2);
            DaysRetained = segments.ElementAtOrDefault(3)?.ToNullableDecimal();
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
