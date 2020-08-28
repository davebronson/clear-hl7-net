using System;

namespace ClearHl7.Fhir.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0004 - Patient Class .
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0004</remarks>
    public enum PatientClass
    {
        /// <summary>
        /// B - Obstetrics.
        /// </summary>
        Obstetrics,
        
        /// <summary>
        /// C - Commercial Account.
        /// </summary>
        CommercialAccount,
        
        /// <summary>
        /// E - Emergency.
        /// </summary>
        Emergency,
        
        /// <summary>
        /// I - Inpatient.
        /// </summary>
        Inpatient,
        
        /// <summary>
        /// N - Not Applicable.
        /// </summary>
        NotApplicable,
        
        /// <summary>
        /// O - Outpatient.
        /// </summary>
        Outpatient,
        
        /// <summary>
        /// P - Preadmit.
        /// </summary>
        Preadmit,
        
        /// <summary>
        /// R - Recurring patient.
        /// </summary>
        RecurringPatient,
        
        /// <summary>
        /// U - Unknown.
        /// </summary>
        Unknown
    }
}