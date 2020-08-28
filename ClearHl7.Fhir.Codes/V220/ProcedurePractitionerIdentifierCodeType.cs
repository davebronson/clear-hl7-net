using System;

namespace ClearHl7.Fhir.Codes.V220
{
    /// <summary>
    /// HL7 Version 2 Table 0133 - Procedure Practitioner Identifier Code Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0133</remarks>
    public enum ProcedurePractitionerIdentifierCodeType
    {
        /// <summary>
        /// AN - Anesthesiologist/Anesthetist.
        /// </summary>
        AnesthesiologistAnesthetist,
        
        /// <summary>
        /// CM - Certified Nurse Midwife.
        /// </summary>
        CertifiedNurseMidwife,
        
        /// <summary>
        /// NP - Nurse Practitioner.
        /// </summary>
        NursePractitioner,
        
        /// <summary>
        /// PR - Procedure MD/ Surgeon.
        /// </summary>
        ProcedureMdSurgeon,
        
        /// <summary>
        /// RD - Radiologist.
        /// </summary>
        Radiologist,
        
        /// <summary>
        /// RS - Resident.
        /// </summary>
        Resident
    }
}