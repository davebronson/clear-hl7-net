using System;

namespace ClearHl7.Fhir.Codes.V210
{
    /// <summary>
    /// HL7 Version 2 Table 0048 - What Subject Filter.
    /// </summary>
    /// </remarks>https://www.hl7.org/fhir/v2/0048</remarks>
    public enum WhatSubjectFilter
    {
        /// <summary>
        /// ADV - Advice/diagnosis.
        /// </summary>
        AdviceDiagnosis,
        
        /// <summary>
        /// ANU - Nursing unit lookup (returns patients in beds, excluding empty beds).
        /// </summary>
        NursingUnitLookupExcludingEmptyBeds,
        
        /// <summary>
        /// APN - Patient name lookup.
        /// </summary>
        PatientNameLookup,
        
        /// <summary>
        /// CAN - Cancel.  Used to cancel a query.
        /// </summary>
        Cancel,
        
        /// <summary>
        /// DEM - Demographics.
        /// </summary>
        Demographics,
        
        /// <summary>
        /// MRI - Most recent inpatient.
        /// </summary>
        MostRecentInpatient,
        
        /// <summary>
        /// MRO - Most recent outpatient.
        /// </summary>
        MostRecentOutpatient,
        
        /// <summary>
        /// OTH - Other.
        /// </summary>
        Other,
        
        /// <summary>
        /// PRO - Procedure.
        /// </summary>
        Procedure,
        
        /// <summary>
        /// RES - Result.
        /// </summary>
        Result,
        
        /// <summary>
        /// STA - Status.
        /// </summary>
        Status
    }
}