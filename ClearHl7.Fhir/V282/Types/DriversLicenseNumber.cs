using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 DLN - Drivers License Number.
    /// </summary>
    public class DriversLicenseNumber
    {
        /// <summary>
        /// DLN.1 - License Number.
        /// </summary>
        public string LicenseNumber { get; set; }

        /// <summary>
        /// DLN.2 - Issuing State, Province, Country.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0333</remarks>
        public CodedWithExceptions IssuingStateProvinceCountry { get; set; }

        /// <summary>
        /// DLN.3 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }
    }
}
