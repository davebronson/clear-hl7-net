namespace ClearHl7.Codes.V282
{
    /// <summary>
    /// HL7 Version 2 Table 0190 - Address Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0190</remarks>
    public enum CodeAddressType
    {
        /// <summary>
        /// B - Firm/Business.
        /// </summary>
        FirmBusiness,

        /// <summary>
        /// BA - Bad address.
        /// </summary>
        BadAddress,

        /// <summary>
        /// BDL - Birth delivery location  (address where birth occurred).
        /// </summary>
        BirthDeliveryLocation,

        /// <summary>
        /// BI - Billing Address.
        /// </summary>
        BillingAddress,

        /// <summary>
        /// BR - Residence at birth (home address at time of birth).
        /// </summary>
        ResidenceAtBirth,

        /// <summary>
        /// C - Current Or Temporary.
        /// </summary>
        CurrentOrTemporary,

        /// <summary>
        /// F - Country Of Origin.
        /// </summary>
        CountryOfOrigin,

        /// <summary>
        /// H - Home.
        /// </summary>
        Home,

        /// <summary>
        /// L - Legal Address.
        /// </summary>
        LegalAddress,

        /// <summary>
        /// M - Mailing.
        /// </summary>
        Mailing,

        /// <summary>
        /// N - Birth (nee)  (birth address, not otherwise specified).
        /// </summary>
        BirthNee,

        /// <summary>
        /// O - Office/Business.
        /// </summary>
        OfficeBusiness,

        /// <summary>
        /// P - Permanent.
        /// </summary>
        Permanent,

        /// <summary>
        /// RH - Registry home. Refers to the information system, typically managed by a public health agency, that stores patient information such as immunization histories or cancer data, regardless of where the patient obtains services.
        /// </summary>
        RegistryHome,

        /// <summary>
        /// S - Service Location.
        /// </summary>
        ServiceLocation,

        /// <summary>
        /// SH - Shipping Address.
        /// </summary>
        ShippingAddress,

        /// <summary>
        /// TM - Tube Address.
        /// </summary>
        TubeAddress,

        /// <summary>
        /// V - Vacation.
        /// </summary>
        Vacation
    }
}
