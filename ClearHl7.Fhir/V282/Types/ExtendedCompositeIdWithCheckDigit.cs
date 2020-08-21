using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 CX - Extended Composite Id With Check Digit.
    /// </summary>
    public class ExtendedCompositeIdWithCheckDigit
    {
        /// <summary>
        /// CX.1 - ID Number.
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// CX.2 - Identifier Check Digit.
        /// </summary>
        public string IdentifierCheckDigit { get; set; }

        /// <summary>
        /// CX.3 - Check Digit Scheme.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0061</remarks>
        public string CheckDigitScheme { get; set; }

        /// <summary>
        /// CX.4 - Assigning Authority.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0363</remarks>
        public HierarchicDesignator AssigningAuthority { get; set; }

        /// <summary>
        /// CX.5 - Identifier Type Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0203</remarks>
        public string IdentifierTypeCode { get; set; }

        /// <summary>
        /// CX.6 - Assigning Facility.
        /// </summary>
        public HierarchicDesignator AssigningFacility { get; set; }

        /// <summary>
        /// CX.7 - Effective Date.
        /// </summary>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// CX.8 - Expiration Date.
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// CX.9 - Assigning Jurisdiction.
        /// </summary>
        public CodedWithExceptions AssigningJurisdiction { get; set; }

        /// <summary>
        /// CX.10 - Assigning Agency or Department.
        /// </summary>
        public CodedWithExceptions AssigningAgencyOrDepartment { get; set; }

        /// <summary>
        /// CX.11 - Security Check.
        /// </summary>
        public string SecurityCheck { get; set; }

        /// <summary>
        /// CX.12 - Security Check Scheme.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0904</remarks>
        public string SecurityCheckScheme { get; set; }
    }
}
