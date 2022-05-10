using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V230.Types
{
    /// <summary>
    /// HL7 Version 2 CK - Composite Id With Check Digit.
    /// </summary>
    public class CompositeIdWithCheckDigit : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeIdWithCheckDigit"/> class.
        /// </summary>
        public CompositeIdWithCheckDigit()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeIdWithCheckDigit"/> class.
        /// </summary>
        /// <param name="idNumber">CK.1 - ID Number.</param>
        public CompositeIdWithCheckDigit(decimal idNumber)
        {
            IdNumber = idNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeIdWithCheckDigit"/> class.
        /// </summary>
        /// <param name="idNumber">CK.1 - ID Number.</param>
        /// <param name="checkDigit">CK.2 - Check Digit.</param>
        public CompositeIdWithCheckDigit(decimal idNumber, string checkDigit)
        {
            IdNumber = idNumber;
            CheckDigit = checkDigit;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CK.1 - ID Number.
        /// </summary>
        public decimal? IdNumber { get; set; }

        /// <summary>
        /// CK.2 - Check Digit.
        /// </summary>
        public string CheckDigit { get; set; }

        /// <summary>
        /// CK.3 - Code Identifying The Check Digit Scheme Employed.
        /// </summary>
        public string CodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

        /// <summary>
        /// CK.4 - Assigning Authority.
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

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

            IdNumber = segments.Length > 0 && segments[0].Length > 0 ? segments[0].ToNullableDecimal() : null;
            CheckDigit = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            CodeIdentifyingTheCheckDigitSchemeEmployed = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            AssigningAuthority = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[3], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                IdNumber.HasValue ? IdNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                CheckDigit,
                                CodeIdentifyingTheCheckDigitSchemeEmployed,
                                AssigningAuthority?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
