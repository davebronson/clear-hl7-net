using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CWE - Coded With Exceptions.
    /// </summary>
    public class CodedWithExceptions
    {
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
        public DateTime AlternateValueSetVersionId { get; set; }

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
    }
}
