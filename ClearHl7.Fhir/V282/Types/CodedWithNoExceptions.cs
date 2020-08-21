using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CNE - Coded With No Exceptions.
    /// </summary>
    public class CodedWithNoExceptions
    {
        /// <summary>
        /// CNE.1 - Identifier.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// CNE.2 - Text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// CNE.3 - Name of Coding System.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
        public string NameOfCodingSystem { get; set; }

        /// <summary>
        /// CNE.4 - Alternate Identifier.
        /// </summary>
        public string AlternateIdentifier { get; set; }

        /// <summary>
        /// CNE.5 - Alternate Text.
        /// </summary>
        public string AlternateText { get; set; }

        /// <summary>
        /// CNE.6 - Name of Alternate Coding System.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
        public string NameOfAlternateCodingSystem { get; set; }

        /// <summary>
        /// CNE.7 - Coding System Version ID.
        /// </summary>
        public string CodingSystemVersionId { get; set; }

        /// <summary>
        /// CNE.8 - Alternate Coding System Version ID.
        /// </summary>
        public string AlternateCodingSystemVersionId { get; set; }

        /// <summary>
        /// CNE.9 - Original Text.
        /// </summary>
        public string OriginalText { get; set; }

        /// <summary>
        /// CNE.10 - Second Alternate Identifier.
        /// </summary>
        public string SecondAlternateIdentifier { get; set; }

        /// <summary>
        /// CNE.11 - Second Alternate Text.
        /// </summary>
        public string SecondAlternateText { get; set; }

        /// <summary>
        /// CNE.12 - Name of Second Alternate Coding System.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
        public string NameOfSecondAlternateCodingSystem { get; set; }

        /// <summary>
        /// CNE.13 - econd Alternate Coding System Version ID.
        /// </summary>
        public string SecondAlternateCodingSystemVersionId { get; set; }

        /// <summary>
        /// CNE.14 - Coding System OID.
        /// </summary>
        public string CodingSystemOid { get; set; }

        /// <summary>
        /// CNE.15 - Value Set OID.
        /// </summary>
        public string ValueSetOid { get; set; }

        /// <summary>
        /// CNE.16 - Value Set Version ID.
        /// </summary>
        public DateTime? ValueSetVersionId { get; set; }

        /// <summary>
        /// CNE.17 - Alternate Coding System OID.
        /// </summary>
        public string AlternateCodingSystemOid { get; set; }

        /// <summary>
        /// CNE.18 - Alternate Value Set OID.
        /// </summary>
        public string AlternateValueSetOid { get; set; }

        /// <summary>
        /// CNE.19 - Alternate Value Set Version ID.
        /// </summary>
        public DateTime? AlternateValueSetVersionId { get; set; }

        /// <summary>
        /// CNE.20 - Second Alternate Coding System OID.
        /// </summary>
        public string SecondAlternateCodingSystemOid { get; set; }

        /// <summary>
        /// CNE.21 - Second Alternate Value Set OID.
        /// </summary>
        public string SecondAlternateValueSetOid { get; set; }

        /// <summary>
        /// CNE.22 - Second Alternate Value Set Version ID.
        /// </summary>
        public DateTime? SecondAlternateValueSetVersionId { get; set; }
    }
}
