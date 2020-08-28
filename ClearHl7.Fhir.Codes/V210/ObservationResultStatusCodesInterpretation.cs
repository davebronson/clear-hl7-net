using System;

namespace ClearHl7.Fhir.Codes.V210
{
    /// <summary>
    /// HL7 Version 2 Table 0085 - Observation Result Status Codes Interpretation.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0085</remarks>
    public enum ObservationResultStatusCodesInterpretation
    {
        /// <summary>
        /// D - Deletes the OBX record.
        /// </summary>
        DeletesTheObxRecord,
        
        /// <summary>
        /// F - Final results.
        /// </summary>
        FinalResults,
        
        /// <summary>
        /// I - Specimen in lab; results pending.
        /// </summary>
        SpecimenInLabResultsPending,
        
        /// <summary>
        /// R - Results entered -- not verified.
        /// </summary>
        ResultsEnteredNotVerified,
        
        /// <summary>
        /// S - Partial results.   Deprecated. Retained only for backward compatibility as of V2.6..
        /// </summary>
        PartialResults
    }
}