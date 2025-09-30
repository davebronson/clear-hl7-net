using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V281.Types
{
    /// <summary>
    /// HL7 Version 2 XPN - Extended Person Name.
    /// </summary>
    public class ExtendedPersonName : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedPersonName"/> class.
        /// </summary>
        public ExtendedPersonName()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedPersonName"/> class.
        /// </summary>
        /// <param name="familyName">XPN.1 - Family Name.</param>
        /// <param name="givenName">XPN.2 - Given Name.</param>
        public ExtendedPersonName(FamilyName familyName, string givenName)
        {
            FamilyName = familyName;
            GivenName = givenName;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// XPN.1 - Family Name.
        /// </summary>
        public FamilyName FamilyName { get; set; }

        /// <summary>
        /// XPN.2 - Given Name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// XPN.3 - Second and Further Given Names or Initials Thereof.
        /// </summary>
        public string SecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

        /// <summary>
        /// XPN.4 - Suffix (e.g., JR or III).
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// XPN.5 - Prefix (e.g., DR).
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// XPN.6 - Degree (e.g., MD).
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// XPN.7 - Name Type Code.
        /// <para>Suggested: 0200 Name Type -&gt; ClearHl7.Codes.V281.CodeNameType</para>
        /// </summary>
        public string NameTypeCode { get; set; }

        /// <summary>
        /// XPN.8 - Name Representation Code.
        /// <para>Suggested: 0465 Name/Address Representation -&gt; ClearHl7.Codes.V281.CodeNameAddressRepresentation</para>
        /// </summary>
        public string NameRepresentationCode { get; set; }

        /// <summary>
        /// XPN.9 - Name Context.
        /// <para>Suggested: 0448 Name Context</para>
        /// </summary>
        public CodedWithExceptions NameContext { get; set; }

        /// <summary>
        /// XPN.10 - Name Validity Range.
        /// </summary>
        public DateTimeRange NameValidityRange { get; set; }

        /// <summary>
        /// XPN.11 - Name Assembly Order.
        /// <para>Suggested: 0444 Name Assembly Order -&gt; ClearHl7.Codes.V281.CodeNameAssemblyOrder</para>
        /// </summary>
        public string NameAssemblyOrder { get; set; }

        /// <summary>
        /// XPN.12 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// XPN.13 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// XPN.14 - Professional Suffix.
        /// </summary>
        public string ProfessionalSuffix { get; set; }

        /// <summary>
        /// XPN.15 - Called By.
        /// </summary>
        public string CalledBy { get; set; }

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

            FamilyName = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<FamilyName>(segments[0], true, seps) : null;
            GivenName = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            SecondAndFurtherGivenNamesOrInitialsThereof = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            Suffix = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            Prefix = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            Degree = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            NameTypeCode = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            NameRepresentationCode = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            NameContext = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[8], true, seps) : null;
            NameValidityRange = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<DateTimeRange>(segments[9], true, seps) : null;
            NameAssemblyOrder = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            EffectiveDate = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDateTime() : null;
            ExpirationDate = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDateTime() : null;
            ProfessionalSuffix = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            CalledBy = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 15, separator),
                                FamilyName?.ToDelimitedString(),
                                GivenName,
                                SecondAndFurtherGivenNamesOrInitialsThereof,
                                Suffix,
                                Prefix,
                                Degree,
                                NameTypeCode,
                                NameRepresentationCode,
                                NameContext?.ToDelimitedString(),
                                NameValidityRange?.ToDelimitedString(),
                                NameAssemblyOrder,
                                EffectiveDate?.ToHl7DateTimeString(typeof(ExtendedPersonName), nameof(EffectiveDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ExpirationDate?.ToHl7DateTimeString(typeof(ExtendedPersonName), nameof(ExpirationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ProfessionalSuffix,
                                CalledBy
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
