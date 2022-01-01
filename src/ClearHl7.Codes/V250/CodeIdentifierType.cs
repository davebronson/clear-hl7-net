namespace ClearHl7.Codes.V250
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
        /// ANC - Account number Creditor.
        /// </summary>
        AccountNumberCreditor,

        /// <summary>
        /// AND - Account number debitor.
        /// </summary>
        AccountNumberDebitor,

        /// <summary>
        /// ANON - Anonymous identifier.
        /// </summary>
        AnonymousIdentifier,

        /// <summary>
        /// ANT - Temporary Account Number.
        /// </summary>
        TemporaryAccountNumber,

        /// <summary>
        /// APRN - Advanced Practice Registered Nurse number.
        /// </summary>
        AdvancedPracticeRegisteredNurseNumber,

        /// <summary>
        /// BA - Bank Account Number.
        /// </summary>
        BankAccountNumber,

        /// <summary>
        /// BC - Bank Card Number.
        /// </summary>
        BankCardNumber,

        /// <summary>
        /// BR - Birth registry number.
        /// </summary>
        BirthRegistryNumber,

        /// <summary>
        /// BRN - Breed Registry Number.
        /// </summary>
        BreedRegistryNumber,

        /// <summary>
        /// CC - Cost Center number.
        /// </summary>
        CostCenterNumber,

        /// <summary>
        /// CY - County number.
        /// </summary>
        CountyNumber,

        /// <summary>
        /// DDS - Dentist license number.
        /// </summary>
        DentistLicenseNumber,

        /// <summary>
        /// DEA - Drug Enforcement Administration registration number.
        /// </summary>
        DrugEnforceAdminRegistrationNumber,

        /// <summary>
        /// DFN - Drug Furnishing or prescriptive authority Number.
        /// </summary>
        DrugFurnishingOrPrescriptiveAuthorityNumber,

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
        /// DO - Osteopathic License number.
        /// </summary>
        OsteopathicLicenseNumber,

        /// <summary>
        /// DPM - Podiatrist license number.
        /// </summary>
        PodiatristLicenseNumber,

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
        /// GL - General ledger number.
        /// </summary>
        GeneralLedgerNumber,

        /// <summary>
        /// GN - Guarantor external  identifier.
        /// </summary>
        GuarantorExternalIdentifier,

        /// <summary>
        /// HC - Health Card Number.
        /// </summary>
        HealthCardNumber,

        /// <summary>
        /// IND - Indigenous/Aboriginal.
        /// </summary>
        IndigenousAboriginal,

        /// <summary>
        /// JHN - Jurisdictional health number (Canada).
        /// </summary>
        JurisdictionalHealthNumberCanada,

        /// <summary>
        /// LI - Labor and industries number.
        /// </summary>
        LaborAndIndustriesNumber,

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
        /// MB - Member Number.
        /// </summary>
        MemberNumber,

        /// <summary>
        /// MC - Patient's Medicare number.
        /// </summary>
        PatientsMedicareNumber,

        /// <summary>
        /// MCD - Practitioner Medicaid number.
        /// </summary>
        PractitionerMedicaidNumber,

        /// <summary>
        /// MCN - Microchip Number.
        /// </summary>
        MicrochipNumber,

        /// <summary>
        /// MCR - Practitioner Medicare number.
        /// </summary>
        PractitionerMedicareNumber,

        /// <summary>
        /// MD - Medical License number.
        /// </summary>
        MedicalLicenseNumber,

        /// <summary>
        /// MI - Military ID number.
        /// </summary>
        MilitaryIdNumber,

        /// <summary>
        /// MR - Medical record number.
        /// </summary>
        MedicalRecordNumber,

        /// <summary>
        /// MRT - Temporary Medical Record Number.
        /// </summary>
        TemporaryMedicalRecordNumber,

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
        /// NII - National Insurance Organization Identifier.
        /// </summary>
        NationalInsuranceOrganizationId,

        /// <summary>
        /// NIIP - National Insurance Payor Identifier (Payor).
        /// </summary>
        NationalInsurancePayorId,

        /// <summary>
        /// NNxxx - National Person Identifier where the xxx is the ISO table 3166 3-character (alphabetic) country code.
        /// </summary>
        NationalPersonIdentifier,

        /// <summary>
        /// NP - Nurse practitioner number.
        /// </summary>
        NursePractitionerNumber,

        /// <summary>
        /// NPI - National provider identifier.
        /// </summary>
        NationalProviderIdentifier,

        /// <summary>
        /// OD - Optometrist license number.
        /// </summary>
        OptometristLicenseNumber,

        /// <summary>
        /// PA - Physician Assistant number.
        /// </summary>
        PhysicianAssistantNumber,

        /// <summary>
        /// PCN - Penitentiary/correctional institution Number.
        /// </summary>
        PenitentiaryCorrectionalInstitutionNumber,

        /// <summary>
        /// PE - Living Subject Enterprise Number.
        /// </summary>
        LivingSubjectEnterpriseNumber,

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
        /// PNT - Temporary Living Subject Number.
        /// </summary>
        TemporaryLivingSubjectNumber,

        /// <summary>
        /// PPN - Passport number.
        /// </summary>
        PassportNumber,

        /// <summary>
        /// PRC - Permanent Resident Card Number.
        /// </summary>
        PermanentResidentCardNumber,

        /// <summary>
        /// PRN - Provider number.
        /// </summary>
        ProviderNumber,

        /// <summary>
        /// PT - Patient external identifier.
        /// </summary>
        PatientExternalIdentifier,

        /// <summary>
        /// QA - QA number.
        /// </summary>
        QaNumber,

        /// <summary>
        /// RI - Resource identifier.
        /// </summary>
        ResourceIdentifier,

        /// <summary>
        /// RN - Registered Nurse Number.
        /// </summary>
        RegisteredNurseNumber,

        /// <summary>
        /// RPH - Pharmacist license number.
        /// </summary>
        PharmacistLicenseNumber,

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
        /// SN - Subscriber Number.
        /// </summary>
        SubscriberNumber,

        /// <summary>
        /// SR - State registry ID.
        /// </summary>
        StateRegistryId,

        /// <summary>
        /// SS - Social Security number.
        /// </summary>
        SocialSecurityNumber,

        /// <summary>
        /// TAX - Tax ID number.
        /// </summary>
        TaxIdNumber,

        /// <summary>
        /// TN - Treaty Number/ (Canada).
        /// </summary>
        TreatyNumberCanada,

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
