using System;

namespace ClearHl7.Fhir.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0763 - DRG Procedure Relevance.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0763</remarks>
    public enum DrgProcedureRelevance
    {
        /// <summary>
        /// 0 - Neither operation relevant nor non-operation relevant procedure.
        /// </summary>
        NeitherOperationRelevantNorNonOperationRelevantProcedure,
        
        /// <summary>
        /// 1 - Operation relevant procedure.
        /// </summary>
        OperationRelevantProcedure,
        
        /// <summary>
        /// 2 - Non-operation relevant procedure.
        /// </summary>
        NonOperationRelevantProcedure
    }
}