namespace ClearHl7.Codes.V280
{
    /// <summary>
    /// HL7 Version 2 Table 0236 - Event Reported To.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0236</remarks>
    public enum CodeEventReportedTo
    {
        /// <summary>
        /// D - Distributor.
        /// </summary>
        Distributor,

        /// <summary>
        /// L - Local facility/user facility.
        /// </summary>
        LocalFacilityUserFacility,

        /// <summary>
        /// M - Manufacturer.
        /// </summary>
        Manufacturer,

        /// <summary>
        /// R - Regulatory agency.
        /// </summary>
        RegulatoryAgency
    }
}
