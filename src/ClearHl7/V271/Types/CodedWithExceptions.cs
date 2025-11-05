using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 CWE - Coded With Exceptions.
    /// </summary>
    public class CodedWithExceptions : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodedWithExceptions"/> class.
        /// </summary>
        public CodedWithExceptions()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodedWithExceptions"/> class.
        /// </summary>
        /// <param name="identifier">CWE.1 - Identifier.</param>
        public CodedWithExceptions(string identifier)
        {
            Identifier = identifier;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CWE.1 - Identifier.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// CWE.2 - Text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// CWE.3 - Name of Coding System.
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V271.CodeCodingSystem</para>
        /// </summary>
        public string NameOfCodingSystem { get; set; }

        /// <summary>
        /// CWE.4 - Alternate Identifier.
        /// </summary>
        public string AlternateIdentifier { get; set; }

        /// <summary>
        /// CWE.5 - Alternate Text.
        /// </summary>
        public string AlternateText { get; set; }

        /// <summary>
        /// CWE.6 - Name of Alternate Coding System.
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V271.CodeCodingSystem</para>
        /// </summary>
        public string NameOfAlternateCodingSystem { get; set; }

        /// <summary>
        /// CWE.7 - Coding System Version ID.
        /// </summary>
        public string CodingSystemVersionId { get; set; }

        /// <summary>
        /// CWE.8 - Alternate Coding System Version ID.
        /// </summary>
        public string AlternateCodingSystemVersionId { get; set; }

        /// <summary>
        /// CWE.9 - Original Text.
        /// </summary>
        public string OriginalText { get; set; }

        /// <summary>
        /// CWE.10 - Second Alternate Identifier.
        /// </summary>
        public string SecondAlternateIdentifier { get; set; }

        /// <summary>
        /// CWE.11 - Second Alternate Text.
        /// </summary>
        public string SecondAlternateText { get; set; }

        /// <summary>
        /// CWE.12 - Name of Second Alternate Coding System.
        /// <para>Suggested: 0396 Coding System -&gt; ClearHl7.Codes.V271.CodeCodingSystem</para>
        /// </summary>
        public string NameOfSecondAlternateCodingSystem { get; set; }

        /// <summary>
        /// CWE.13 - Second Alternate Coding System Version ID.
        /// </summary>
        public string SecondAlternateCodingSystemVersionId { get; set; }

        /// <summary>
        /// CWE.14 - Coding System OID.
        /// </summary>
        public string CodingSystemOid { get; set; }

        /// <summary>
        /// CWE.15 - Value Set OID.
        /// </summary>
        public string ValueSetOid { get; set; }

        /// <summary>
        /// CWE.16 - Value Set Version ID.
        /// </summary>
        public DateTime? ValueSetVersionId { get; set; }

        /// <summary>
        /// CWE.17 - Alternate Coding System OID.
        /// </summary>
        public string AlternateCodingSystemOid { get; set; }

        /// <summary>
        /// CWE.18 - Alternate Value Set OID.
        /// </summary>
        public string AlternateValueSetOid { get; set; }

        /// <summary>
        /// CWE.19 - Alternate Value Set Version ID.
        /// </summary>
        public DateTime? AlternateValueSetVersionId { get; set; }

        /// <summary>
        /// CWE.20 - Second Alternate Coding System OID.
        /// </summary>
        public string SecondAlternateCodingSystemOid { get; set; }

        /// <summary>
        /// CWE.21 - Second Alternate Value Set OID.
        /// </summary>
        public string SecondAlternateValueSetOid { get; set; }

        /// <summary>
        /// CWE.22 - Second Alternate Value Set Version ID.
        /// </summary>
        public DateTime? SecondAlternateValueSetVersionId { get; set; }

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

            Identifier = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            Text = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            NameOfCodingSystem = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            AlternateIdentifier = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            AlternateText = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            NameOfAlternateCodingSystem = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            CodingSystemVersionId = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            AlternateCodingSystemVersionId = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            OriginalText = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            SecondAlternateIdentifier = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            SecondAlternateText = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            NameOfSecondAlternateCodingSystem = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            SecondAlternateCodingSystemVersionId = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            CodingSystemOid = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            ValueSetOid = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            ValueSetVersionId = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDateTime() : null;
            AlternateCodingSystemOid = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            AlternateValueSetOid = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
            AlternateValueSetVersionId = segments.Length > 18 && segments[18].Length > 0 ? segments[18].ToNullableDateTime() : null;
            SecondAlternateCodingSystemOid = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            SecondAlternateValueSetOid = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            SecondAlternateValueSetVersionId = segments.Length > 21 && segments[21].Length > 0 ? segments[21].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 22, separator),
                                Identifier,
                                Text,
                                NameOfCodingSystem,
                                AlternateIdentifier,
                                AlternateText,
                                NameOfAlternateCodingSystem,
                                CodingSystemVersionId,
                                AlternateCodingSystemVersionId,
                                OriginalText,
                                SecondAlternateIdentifier,
                                SecondAlternateText,
                                NameOfSecondAlternateCodingSystem,
                                SecondAlternateCodingSystemVersionId,
                                CodingSystemOid,
                                ValueSetOid,
                                ValueSetVersionId?.ToHl7DateTimeString(typeof(CodedWithExceptions), nameof(ValueSetVersionId), Consts.DateFormatPrecisionDay, culture),
                                AlternateCodingSystemOid,
                                AlternateValueSetOid,
                                AlternateValueSetVersionId?.ToHl7DateTimeString(typeof(CodedWithExceptions), nameof(AlternateValueSetVersionId), Consts.DateFormatPrecisionDay, culture),
                                SecondAlternateCodingSystemOid,
                                SecondAlternateValueSetOid,
                                SecondAlternateValueSetVersionId?.ToHl7DateTimeString(typeof(CodedWithExceptions), nameof(SecondAlternateValueSetVersionId), Consts.DateFormatPrecisionDay, culture)
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
