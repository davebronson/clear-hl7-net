using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V282.Types
{
    /// <summary>
    /// HL7 Version 2 DLT - Delta.
    /// </summary>
    public class Delta : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Delta"/> class.
        /// </summary>
        public Delta()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Delta"/> class.
        /// </summary>
        /// <param name="normalRange">DLT.1 - Normal Range.</param>
        public Delta(NumericRange normalRange)
        {
            NormalRange = normalRange;
        }

        /// <inheritdoc/>
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
        /// <para>Suggested: 0523 Computation Type -&gt; ClearHl7.Codes.V282.CodeComputationType</para>
        /// </summary>
        public string ChangeComputation { get; set; }

        /// <summary>
        /// DLT.4 - Days Retained.
        /// </summary>
        public decimal? DaysRetained { get; set; }

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

            NormalRange = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<NumericRange>(segments[0], true, seps) : null;
            NumericThreshold = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            ChangeComputation = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            DaysRetained = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
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
