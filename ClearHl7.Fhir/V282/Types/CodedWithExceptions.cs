using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CWE - Coded With Exceptions.
    /// </summary>
    public class CodedWithExceptions
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
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
