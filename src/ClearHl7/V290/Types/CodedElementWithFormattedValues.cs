using System;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 CF - Coded Element With Formatted Values.
    /// </summary>
    public class CodedElementWithFormattedValues : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CF.1 - Identifier.
        /// </summary>
        public string Identifier{ get; set; }

        /// <summary>
        /// CF.2 - Formatted Text.
        /// </summary>
        public string FormattedText { get; set; }

        /// <summary>
        /// CF.3 - Name of Coding System.
        /// <para>Suggested: 0396 Coding System</para>
        /// </summary>
        public string NameOfCodingSystem { get; set; }

        /// <summary>
        /// CF.4 - Alternate Identifier.
        /// </summary>
        public string AlternateIdentifier { get; set; }

        /// <summary>
        /// CF.5 - Alternate Formatted Text.
        /// </summary>
        public string AlternateFormattedText { get; set; }

        /// <summary>
        /// CF.6 - Name of Alternate Coding System.
        /// <para>Suggested: 0396 Coding System</para>
        /// </summary>
        public string NameOfAlternateCodingSystem { get; set; }

        /// <summary>
        /// CF.7 - Coding System Version ID.
        /// </summary>
        public string CodingSystemVersionId { get; set; }

        /// <summary>
        /// CF.8 - Alternate Coding System Version ID.
        /// </summary>
        public string AlternateCodingSystemVersionId { get; set; }

        /// <summary>
        /// CF.9 - Original Text.
        /// </summary>
        public string OriginalText { get; set; }

        /// <summary>
        /// CF.10 - Second Alternate Identifier.
        /// </summary>
        public string SecondAlternateIdentifier { get; set; }

        /// <summary>
        /// CF.11 - Second Alternate Formatted Text.
        /// </summary>
        public string SecondAlternateFormattedText { get; set; }

        /// <summary>
        /// CF.12 - Name of Second Alternate Coding System.
        /// <para>Suggested: 0396 Coding System</para>
        /// </summary>
        public string NameOfSecondAlternateCodingSystem { get; set; }

        /// <summary>
        /// CF.13 - Second Alternate Coding System Version ID.
        /// </summary>
        public string SecondAlternateCodingSystemVersionId { get; set; }

        /// <summary>
        /// CF.14 - Coding System OID.
        /// </summary>
        public string CodingSystemOid { get; set; }

        /// <summary>
        /// CF.15 - Value Set OID.
        /// </summary>
        public string ValueSetOid { get; set; }

        /// <summary>
        /// CF.16 - Value Set Version ID.
        /// </summary>
        public DateTime? ValueSetVersionId { get; set; }

        /// <summary>
        /// CF.17 - Alternate Coding System OID.
        /// </summary>
        public string AlternateCodingSystemOid { get; set; }

        /// <summary>
        /// CF.18 - Alternate Value Set OID.
        /// </summary>
        public string AlternateValueSetOid { get; set; }

        /// <summary>
        /// CF.19 - Alternate Value Set Version ID.
        /// </summary>
        public DateTime? AlternateValueSetVersionId { get; set; }

        /// <summary>
        /// CF.20 - Second Alternate Coding System OID.
        /// </summary>
        public string SecondAlternateCodingSystemOid { get; set; }

        /// <summary>
        /// CF.21 - Second Alternate Value Set OID.
        /// </summary>
        public string SecondAlternateValueSetOid { get; set; }

        /// <summary>
        /// CF.22 - Second Alternate Value Set Version ID.
        /// </summary>
        public DateTime? SecondAlternateValueSetVersionId { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            Identifier = segments.ElementAtOrDefault(0);
            FormattedText = segments.ElementAtOrDefault(1);
            NameOfCodingSystem = segments.ElementAtOrDefault(2);
            AlternateIdentifier = segments.ElementAtOrDefault(3);
            AlternateFormattedText = segments.ElementAtOrDefault(4);
            NameOfAlternateCodingSystem = segments.ElementAtOrDefault(5);
            CodingSystemVersionId = segments.ElementAtOrDefault(6);
            AlternateCodingSystemVersionId = segments.ElementAtOrDefault(7);
            OriginalText = segments.ElementAtOrDefault(8);
            SecondAlternateIdentifier = segments.ElementAtOrDefault(9);
            SecondAlternateFormattedText = segments.ElementAtOrDefault(10);
            NameOfSecondAlternateCodingSystem = segments.ElementAtOrDefault(11);
            SecondAlternateCodingSystemVersionId = segments.ElementAtOrDefault(12);
            CodingSystemOid = segments.ElementAtOrDefault(13);
            ValueSetOid = segments.ElementAtOrDefault(14);
            ValueSetVersionId = segments.ElementAtOrDefault(15)?.ToNullableDateTime();
            AlternateCodingSystemOid = segments.ElementAtOrDefault(16);
            AlternateValueSetOid = segments.ElementAtOrDefault(17);
            AlternateValueSetVersionId = segments.ElementAtOrDefault(18)?.ToNullableDateTime();
            SecondAlternateCodingSystemOid = segments.ElementAtOrDefault(19);
            SecondAlternateValueSetOid = segments.ElementAtOrDefault(20);
            SecondAlternateValueSetVersionId = segments.ElementAtOrDefault(21)?.ToNullableDateTime();
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
                                StringHelper.StringFormatSequence(0, 22, separator),
                                Identifier,
                                FormattedText,
                                NameOfCodingSystem,
                                AlternateIdentifier,
                                AlternateFormattedText,
                                NameOfAlternateCodingSystem,
                                CodingSystemVersionId,
                                AlternateCodingSystemVersionId,
                                OriginalText,
                                SecondAlternateIdentifier,
                                SecondAlternateFormattedText,
                                NameOfSecondAlternateCodingSystem,
                                SecondAlternateCodingSystemVersionId,
                                CodingSystemOid,
                                ValueSetOid,
                                ValueSetVersionId.HasValue ? ValueSetVersionId.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                AlternateCodingSystemOid,
                                AlternateValueSetOid,
                                AlternateValueSetVersionId.HasValue ? AlternateValueSetVersionId.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                SecondAlternateCodingSystemOid,
                                SecondAlternateValueSetOid,
                                SecondAlternateValueSetVersionId.HasValue ? SecondAlternateValueSetVersionId.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
