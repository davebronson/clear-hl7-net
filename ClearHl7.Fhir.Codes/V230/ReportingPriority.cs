using System;

namespace ClearHl7.Fhir.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0169 - Reporting Priority.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0169</remarks>
    public enum ReportingPriority
    {
        /// <summary>
        /// C - Call back results.
        /// </summary>
        CallBackResults,
        
        /// <summary>
        /// R - Rush reporting.
        /// </summary>
        RushReporting
    }
}