namespace ClearHl7.Codes.V260
{
    /// <summary>
    /// HL7 Version 2 Table 0301 - Universal ID Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0301</remarks>
    public enum CodeUniversalIdType
    {
        /// <summary>
        /// DNS - Domain Name System.
        /// </summary>
        DomainNameSystem,

        /// <summary>
        /// GUID - globally unique identifier.
        /// </summary>
        GloballyUniqueIdentifier,

        /// <summary>
        /// HCD - CEN Healthcare Coding Identifier.
        /// </summary>
        CenHealthcareCodingIdentifier,

        /// <summary>
        /// HL7 - HL7 registration schemes.
        /// </summary>
        Hl7RegistrationSchemes,

        /// <summary>
        /// ISO - ISO Object Identifier.
        /// </summary>
        IsoObjectIdentifier,

        /// <summary>
        /// L - Local.
        /// </summary>
        LocalL,

        /// <summary>
        /// L,M,N - Local.
        /// </summary>
        LocalLMN,

        /// <summary>
        /// M - Local.
        /// </summary>
        LocalM,

        /// <summary>
        /// N - Local.
        /// </summary>
        LocalN,

        /// <summary>
        /// Random - Random.
        /// </summary>
        Random,

        /// <summary>
        /// URI - Uniform Resource Identifier.
        /// </summary>
        UniformResourceIdentifier,

        /// <summary>
        /// UUID - Universal Unique Identifier.
        /// </summary>
        UniversalUniqueIdentifier,

        /// <summary>
        /// x400 - X.400 MHS identifier.
        /// </summary>
        X400MhsIdentifier,

        /// <summary>
        /// x500 - X500 directory Name.
        /// </summary>
        X500DirectoryName
    }
}
