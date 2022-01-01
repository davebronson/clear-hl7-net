namespace ClearHl7.Codes.V240
{
    /// <summary>
    /// HL7 Version 2 Table 0203 - Identifier Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0203</remarks>
    public enum CodeIdentifierType
    {
        /// <summary>
        /// AM - American Express.
        /// </summary>
        AmericanExpress,

        /// <summary>
        /// AN - Account number.
        /// </summary>
        AccountNumber,

        /// <summary>
        /// BA - Bank Account Number.
        /// </summary>
        BankAccountNumber,

        /// <summary>
        /// BR - Birth registry number.
        /// </summary>
        BirthRegistryNumber,

        /// <summary>
        /// BRN - Breed Registry Number.
        /// </summary>
        BreedRegistryNumber,

        /// <summary>
        /// DI - Diner's Club card.
        /// </summary>
        DinersClubCard,

        /// <summary>
        /// DL - Driver's license number.
        /// </summary>
        DriversLicenseNumber,

        /// <summary>
        /// DN - Doctor number.
        /// </summary>
        DoctorNumber,

        /// <summary>
        /// DR - Donor Registration Number.
        /// </summary>
        DonorRegistrationNumber,

        /// <summary>
        /// DS - Discover Card.
        /// </summary>
        DiscoverCard,

        /// <summary>
        /// EI - Employee number.
        /// </summary>
        EmployeeNumber,

        /// <summary>
        /// EN - Employer number.
        /// </summary>
        EmployerNumber,

        /// <summary>
        /// FI - Facility ID.
        /// </summary>
        FacilityId,

        /// <summary>
        /// GI - Guarantor internal identifier.
        /// </summary>
        GuarantorInternalIdentifier,

        /// <summary>
        /// GN - Guarantor external  identifier.
        /// </summary>
        GuarantorExternalIdentifier,

        /// <summary>
        /// HC - Health Card Number.
        /// </summary>
        HealthCardNumber,

        /// <summary>
        /// JHN - Jurisdictional health number (Canada).
        /// </summary>
        JurisdictionalHealthNumberCanada,

        /// <summary>
        /// LN - License number.
        /// </summary>
        LicenseNumber,

        /// <summary>
        /// LR - Local Registry ID.
        /// </summary>
        LocalRegistryId,

        /// <summary>
        /// MA - Patient Medicaid number.
        /// </summary>
        PatientMedicaidNumber,

        /// <summary>
        /// MC - Patient's Medicare number.
        /// </summary>
        PatientsMedicareNumber,

        /// <summary>
        /// MCN - Microchip Number.
        /// </summary>
        MicrochipNumber,

        /// <summary>
        /// MR - Medical record number.
        /// </summary>
        MedicalRecordNumber,

        /// <summary>
        /// MS - MasterCard.
        /// </summary>
        Mastercard,

        /// <summary>
        /// NE - National employer identifier.
        /// </summary>
        NationalEmployerId,

        /// <summary>
        /// NH - National Health Plan Identifier.
        /// </summary>
        NationalHealthPlanId,

        /// <summary>
        /// NI - National unique individual identifier.
        /// </summary>
        NationalUniqueIndividualId,

        /// <summary>
        /// NNxxx - National Person Identifier where the xxx is the ISO table 3166 3-character (alphabetic) country code.
        /// </summary>
        NationalPersonIdentifier,

        /// <summary>
        /// NPI - National provider identifier.
        /// </summary>
        NationalProviderIdentifier,

        /// <summary>
        /// PEN - Pension Number.
        /// </summary>
        PensionNumber,

        /// <summary>
        /// PI - Patient internal identifier.
        /// </summary>
        PatientInternalIdentifier,

        /// <summary>
        /// PN - Person number.
        /// </summary>
        PersonNumber,

        /// <summary>
        /// PRN - Provider number.
        /// </summary>
        ProviderNumber,

        /// <summary>
        /// PT - Patient external identifier.
        /// </summary>
        PatientExternalIdentifier,

        /// <summary>
        /// RR - Railroad Retirement number.
        /// </summary>
        RailroadRetirementNumber,

        /// <summary>
        /// RRI - Regional registry ID.
        /// </summary>
        RegionalRegistryId,

        /// <summary>
        /// SL - State license.
        /// </summary>
        StateLicense,

        /// <summary>
        /// SR - State registry ID.
        /// </summary>
        StateRegistryId,

        /// <summary>
        /// SS - Social Security number.
        /// </summary>
        SocialSecurityNumber,

        /// <summary>
        /// U - Unspecified identifier.
        /// </summary>
        UnspecifiedIdentifier,

        /// <summary>
        /// UPIN - Medicare/CMS (formerly HCFA)'s Universal Physician Identification numbers.
        /// </summary>
        MedicareCmsUniversalPhysicianId,

        /// <summary>
        /// VN - Visit number.
        /// </summary>
        VisitNumber,

        /// <summary>
        /// VS - VISA.
        /// </summary>
        Visa,

        /// <summary>
        /// WC - WIC identifier.
        /// </summary>
        WicIdentifier,

        /// <summary>
        /// WCN - Workers' Comp Number.
        /// </summary>
        WorkersCompNumber,

        /// <summary>
        /// XX - Organization identifier.
        /// </summary>
        OrganizationIdentifier
    }
}
