using System;

namespace ClearHl7.Fhir.Codes.V230
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
        /// APA - Account number query, return matching visit.
        /// </summary>
        AccountNumberQuery,
        
        /// <summary>
        /// APM - Medical record number query, returns visits for a medical record number.
        /// </summary>
        MedicalRecordNumberQuery,
        
        /// <summary>
        /// APN - Patient name lookup.
        /// </summary>
        PatientNameLookup,
        
        /// <summary>
        /// APP - Physician lookup.
        /// </summary>
        PhysicianLookup,
        
        /// <summary>
        /// ARN - Nursing unit lookup (returns patients in beds, including empty beds).
        /// </summary>
        NursingUnitLookupIncludingEmptyBeds,
        
        /// <summary>
        /// CAN - Cancel.  Used to cancel a query.
        /// </summary>
        Cancel,
        
        /// <summary>
        /// DEM - Demographics.
        /// </summary>
        Demographics,
        
        /// <summary>
        /// FIN - Financial.
        /// </summary>
        Financial,
        
        /// <summary>
        /// GOL - Goals.
        /// </summary>
        Goals,
        
        /// <summary>
        /// MRI - Most recent inpatient.
        /// </summary>
        MostRecentInpatient,
        
        /// <summary>
        /// MRO - Most recent outpatient.
        /// </summary>
        MostRecentOutpatient,
        
        /// <summary>
        /// NCK - Network clock.
        /// </summary>
        NetworkClock,
        
        /// <summary>
        /// NSC - Network status change.
        /// </summary>
        NetworkStatusChange,
        
        /// <summary>
        /// NST - Network statistic.
        /// </summary>
        NetworkStatistic,
        
        /// <summary>
        /// ORD - Order.
        /// </summary>
        Order,
        
        /// <summary>
        /// OTH - Other.
        /// </summary>
        Other,
        
        /// <summary>
        /// PRB - Problems.
        /// </summary>
        Problems,
        
        /// <summary>
        /// PRO - Procedure.
        /// </summary>
        Procedure,
        
        /// <summary>
        /// RAR - Pharmacy administration information.
        /// </summary>
        PharmacyAdministrationInfo,
        
        /// <summary>
        /// RDR - Pharmacy dispense information.
        /// </summary>
        PharmacyDispenseInfo,
        
        /// <summary>
        /// RER - Pharmacy encoded order information.
        /// </summary>
        PharmacyEncodedOrderInfo,
        
        /// <summary>
        /// RES - Result.
        /// </summary>
        Result,
        
        /// <summary>
        /// RGR - Pharmacy give information.
        /// </summary>
        PharmacyGiveInfo,
        
        /// <summary>
        /// ROR - Pharmacy prescription information.
        /// </summary>
        PharmacyPrescriptionInfo,
        
        /// <summary>
        /// STA - Status.
        /// </summary>
        Status,
        
        /// <summary>
        /// VXI - Vaccine Information.
        /// </summary>
        VaccineInformation
    }
}