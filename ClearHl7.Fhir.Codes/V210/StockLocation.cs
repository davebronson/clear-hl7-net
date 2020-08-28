using System;

namespace ClearHl7.Fhir.Codes.V210
{
    /// <summary>
    /// HL7 Version 2 Table 0012 - Stock Location.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0012</remarks>
    public enum StockLocation
    {
        /// <summary>
        /// AN - Filled from ancillary department stock.
        /// </summary>
        FilledFromAncillaryDepartmentStock,
        
        /// <summary>
        /// FL - Filled from floor stock.
        /// </summary>
        FilledFromFloorStock
    }
}