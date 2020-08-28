using System;

namespace ClearHl7.Fhir.Codes.V251
{
    /// <summary>
    /// HL7 Version 2 Table 0529 - Precision.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0529</remarks>
    public enum Precision
    {
        /// <summary>
        /// D - day.
        /// </summary>
        Day,
        
        /// <summary>
        /// H - hour.
        /// </summary>
        Hour,
        
        /// <summary>
        /// L - month.
        /// </summary>
        Month,
        
        /// <summary>
        /// M - minute.
        /// </summary>
        Minute,
        
        /// <summary>
        /// S - second.
        /// </summary>
        Second,
        
        /// <summary>
        /// Y - year.
        /// </summary>
        Year
    }
}