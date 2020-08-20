using System;

namespace ClearHl7.Fhir.Codes.V270
{
    /// <summary>
    /// HL7 Version 2 Table 0555 - Invoice Type.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0555</remarks>
    public enum InvoiceType
    {
        /// <summary>
        /// BK - Block.
        /// </summary>
        Block,
        
        /// <summary>
        /// FN - Final.
        /// </summary>
        Final,
        
        /// <summary>
        /// FS - Fee for Service.
        /// </summary>
        FeeForService,
        
        /// <summary>
        /// GP - Group.
        /// </summary>
        Group,
        
        /// <summary>
        /// IN - Information Only.
        /// </summary>
        InformationOnly,
        
        /// <summary>
        /// NP - Non Patient.
        /// </summary>
        NonPatient,
        
        /// <summary>
        /// PA - Partial.
        /// </summary>
        Partial,
        
        /// <summary>
        /// SL - Salary.
        /// </summary>
        Salary,
        
        /// <summary>
        /// SS - By Session.
        /// </summary>
        BySession,
        
        /// <summary>
        /// SU - Supplemental.
        /// </summary>
        Supplemental
    }
}