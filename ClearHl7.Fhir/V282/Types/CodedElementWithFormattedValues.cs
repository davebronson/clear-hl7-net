using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CF - Coded Element With Formatted Values.
    /// </summary>
    public class CodedElementWithFormattedValues
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
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
        /// Returns a pipe-delimited representation of this instance. 
        /// </summary>
        /// <returns>A string.</returns>
        public string ToPipeString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                IsSubcomponent ? "{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}&{9}&{10}&{11}&{12}&{13}&{14}&{15}&{16}&{17}&{18}&{19}&{20}&{21}" : "{0}^{1}^{2}^{3}^{4}^{5}^{6}^{7}^{8}^{9}^{10}^{11}^{12}^{13}^{14}^{15}^{16}^{17}^{18}^{19}^{20}^{21}",
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
                                ValueSetVersionId.HasValue ? ValueSetVersionId.Value.ToString(Consts.DateFormat, culture) : null,
                                AlternateCodingSystemOid,
                                AlternateValueSetOid,
                                AlternateValueSetVersionId.HasValue ? AlternateValueSetVersionId.Value.ToString(Consts.DateFormat, culture) : null,
                                SecondAlternateCodingSystemOid,
                                SecondAlternateValueSetOid,
                                SecondAlternateValueSetVersionId.HasValue ? SecondAlternateValueSetVersionId.Value.ToString(Consts.DateFormat, culture) : null
                                ).TrimEnd(IsSubcomponent ? '&' : '^');
        }
    }
}
