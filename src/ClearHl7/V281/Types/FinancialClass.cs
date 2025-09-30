using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V281.Types
{
    /// <summary>
    /// HL7 Version 2 FC - Financial Class.
    /// </summary>
    public class FinancialClass : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialClass"/> class.
        /// </summary>
        public FinancialClass()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialClass"/> class.
        /// </summary>
        /// <param name="financialClassCode">FC.1 - Financial Class Code.</param>
        public FinancialClass(CodedWithExceptions financialClassCode)
        {
            FinancialClassCode = financialClassCode;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// FC.1 - Financial Class Code.
        /// <para>Suggested: 0064 Financial Class Code</para>
        /// </summary>
        public CodedWithExceptions FinancialClassCode { get; set; }

        /// <summary>
        /// FC.2 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

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

            FinancialClassCode = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[0], true, seps) : null;
            EffectiveDate = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                FinancialClassCode?.ToDelimitedString(),
                                EffectiveDate?.ToHl7DateTimeString(typeof(FinancialClass), nameof(EffectiveDate), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
