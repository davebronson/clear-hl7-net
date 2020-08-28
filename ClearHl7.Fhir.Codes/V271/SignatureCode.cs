using System;

namespace ClearHl7.Fhir.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0535 - Signature Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0535</remarks>
    public enum SignatureCode
    {
        /// <summary>
        /// C - Signed CMS-1500 claim form on file, e.g., authorization for release of any medical or other information necessary to process this claim and assignment of benefits..
        /// </summary>
        SignedCms1500ClaimFormOnFile,
        
        /// <summary>
        /// M - Signed authorization for assignment of benefits on file..
        /// </summary>
        SignedAuthorizationForAssignmentOfBenefitsOnFile,
        
        /// <summary>
        /// P - Signature generated by provider because the patient was not physically present for services..
        /// </summary>
        SignatureGeneratedByProvider,
        
        /// <summary>
        /// S - Signed authorization for release of any medical or other information necessary to process this claim on file..
        /// </summary>
        SignedAuthorizationForReleaseOfAnyMedicalOrOtherInfoOnFile
    }
}