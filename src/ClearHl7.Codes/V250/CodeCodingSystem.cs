namespace ClearHl7.Codes.V250
{
    /// <summary>
    /// HL7 Version 2 Table 0396 - Coding System.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0396</remarks>
    public enum CodeCodingSystem
    {
        /// <summary>
        /// 99zzz or L - Local general code (where z is an alphanumeric character).
        /// </summary>
        LocalGeneralCode99ZzzOrL,

        /// <summary>
        /// ACR - American College of Radiology finding codes.
        /// </summary>
        AmericanCollegeOfRadiologyFindingCodes,

        /// <summary>
        /// ANS+ - HL7 set of units of measure.
        /// </summary>
        Hl7SetOfUnitsOfMeasure,

        /// <summary>
        /// ART - WHO Adverse Reaction Terms.
        /// </summary>
        WhoAdverseReactionTerms,

        /// <summary>
        /// AS4 - ASTM E1238/ E1467 Universal.
        /// </summary>
        AstmE1238E1467Universal,

        /// <summary>
        /// AS4E - AS4 Neurophysiology Codes.
        /// </summary>
        As4NeurophysiologyCodes,

        /// <summary>
        /// ATC - American Type Culture Collection.
        /// </summary>
        AmericanTypeCultureCollection,

        /// <summary>
        /// C4 - CPT-4.
        /// </summary>
        Cpt4,

        /// <summary>
        /// C5 - CPT-5.
        /// </summary>
        Cpt5,

        /// <summary>
        /// CAS - Chemical abstract codes.
        /// </summary>
        ChemicalAbstractCodes,

        /// <summary>
        /// CD2 - CDT-2 Codes.
        /// </summary>
        Cdt2Codes,

        /// <summary>
        /// CDCA - CDC Analyte Codes.
        /// </summary>
        CdcAnalyteCodes,

        /// <summary>
        /// CDCM - CDC Methods/Instruments Codes.
        /// </summary>
        CdcMethodsInstrumentsCodes,

        /// <summary>
        /// CDS - CDC Surveillance.
        /// </summary>
        CdcSurveillance,

        /// <summary>
        /// CE - CEN ECG diagnostic codes.
        /// </summary>
        CenEcgDiagnosticCodes,

        /// <summary>
        /// CLP - CLIP.
        /// </summary>
        Clip,

        /// <summary>
        /// CPTM - CPT Modifier Code.
        /// </summary>
        CptModifierCode,

        /// <summary>
        /// CST - COSTART.
        /// </summary>
        Costart,

        /// <summary>
        /// CVX - CDC Vaccine Codes.
        /// </summary>
        CdcVaccineCodes,

        /// <summary>
        /// DCM - DICOM Controlled Terminology.
        /// </summary>
        DicomControlledTerminology,

        /// <summary>
        /// E - EUCLIDES.
        /// </summary>
        Euclides,

        /// <summary>
        /// E5 - Euclides  quantity codes.
        /// </summary>
        EuclidesQuantityCodes,

        /// <summary>
        /// E6 - Euclides Lab method codes.
        /// </summary>
        EuclidesLabMethodCodes,

        /// <summary>
        /// E7 - Euclides Lab equipment codes.
        /// </summary>
        EuclidesLabEquipmentCodes,

        /// <summary>
        /// ENZC - Enzyme Codes.
        /// </summary>
        EnzymeCodes,

        /// <summary>
        /// FDDC - First DataBank Drug Codes.
        /// </summary>
        FirstDatabankDrugCodes,

        /// <summary>
        /// FDDX - First DataBank Diagnostic Codes.
        /// </summary>
        FirstDatabankDiagnosticCodes,

        /// <summary>
        /// FDK - FDA K10.
        /// </summary>
        FdaK10,

        /// <summary>
        /// HB - HIBCC.
        /// </summary>
        Hibcc,

        /// <summary>
        /// HCPCS - CMS (formerly HCFA)  Common Procedure Coding System.
        /// </summary>
        CmsFormerlyHcfaCommonProcedureCodingSystem,

        /// <summary>
        /// HCPT - Health Care Provider Taxonomy.
        /// </summary>
        HealthCareProviderTaxonomy,

        /// <summary>
        /// HHC - Home Health Care.
        /// </summary>
        HomeHealthCare,

        /// <summary>
        /// HI - Health Outcomes.
        /// </summary>
        HealthOutcomes,

        /// <summary>
        /// HL7nnnn - HL7 Defined Codes where nnnn is the HL7 table number.
        /// </summary>
        Hl7DefinedCodesWhereNnnnIsTheHl7TableNumber,

        /// <summary>
        /// HOT - Japanese Nationwide Medicine Code.
        /// </summary>
        JapaneseNationwideMedicineCode,

        /// <summary>
        /// HPC - CMS (formerly HCFA )Procedure Codes (HCPCS).
        /// </summary>
        CmsFormerlyHcfaProcedureCodesHcpcs,

        /// <summary>
        /// I10 - ICD-10.
        /// </summary>
        Icd10,

        /// <summary>
        /// I10P - ICD-10  Procedure Codes.
        /// </summary>
        Icd10ProcedureCodes,

        /// <summary>
        /// I9 - ICD9.
        /// </summary>
        Icd9,

        /// <summary>
        /// I9C - ICD-9CM.
        /// </summary>
        Icd9Cm,

        /// <summary>
        /// IBT - ISBT.
        /// </summary>
        Isbt,

        /// <summary>
        /// IBTnnnn - ISBT 128 codes where nnnn  specifies a specific table within ISBT 128.
        /// </summary>
        Isbt128Codes,

        /// <summary>
        /// IC2 - ICHPPC-2.
        /// </summary>
        Ichppc2,

        /// <summary>
        /// ICD10AM - ICD-10 Australian modification.
        /// </summary>
        Icd10AustralianModification,

        /// <summary>
        /// ICD10CA - ICD-10 Canada.
        /// </summary>
        Icd10Canada,

        /// <summary>
        /// ICDO - International Classification of Diseases for Oncology.
        /// </summary>
        IcdForOncology,

        /// <summary>
        /// ICS - ICCS.
        /// </summary>
        Iccs,

        /// <summary>
        /// ICSD - International Classification of Sleep Disorders.
        /// </summary>
        Icsd,

        /// <summary>
        /// ISO+ - ISO 2955.83 (units of measure) with HL7 extensions.
        /// </summary>
        Iso295583UnitsOfMeasure,

        /// <summary>
        /// ISOnnnn - ISO Defined Codes where nnnn is the ISO table number.
        /// </summary>
        IsoDefinedCodes,

        /// <summary>
        /// IUPC - IUPAC/IFCC Component Codes.
        /// </summary>
        IupacIfccComponentCodes,

        /// <summary>
        /// IUPP - IUPAC/IFCC Property Codes.
        /// </summary>
        IupacIfccPropertyCodes,

        /// <summary>
        /// JC10 - JLAC/JSLM, nationwide laboratory code.
        /// </summary>
        JlacJslmNationwideLaboratoryCode,

        /// <summary>
        /// JC8 - Japanese Chemistry.
        /// </summary>
        JapaneseChemistry,

        /// <summary>
        /// JJ1017 - Japanese Image Examination Cache.
        /// </summary>
        JapaneseImageExaminationCache,

        /// <summary>
        /// LB - Local billing code.
        /// </summary>
        LocalBillingCode,

        /// <summary>
        /// LN - Logical Observation Identifier Names and Codes (LOINCA).
        /// </summary>
        LogicalObservationIdentifierNamesAndCodesLoinc,

        /// <summary>
        /// MCD - Medicaid.
        /// </summary>
        Medicaid,

        /// <summary>
        /// MCR - Medicare.
        /// </summary>
        Medicare,

        /// <summary>
        /// MDDX - Medispan Diagnostic Codes.
        /// </summary>
        MedispanDiagnosticCodes,

        /// <summary>
        /// MEDC - Medical Economics Drug Codes.
        /// </summary>
        MedicalEconomicsDrugCodes,

        /// <summary>
        /// MEDR - Medical Dictionary for Drug Regulatory Affairs (MEDDRA).
        /// </summary>
        MedicalDictionaryForDrugRegulatoryAffairs,

        /// <summary>
        /// MEDX - Medical Economics Diagnostic Codes.
        /// </summary>
        MedicalEconomicsDiagnosticCodes,

        /// <summary>
        /// MGPI - Medispan GPI.
        /// </summary>
        MedispanGpi,

        /// <summary>
        /// MVX - CDC Vaccine Manufacturer Codes.
        /// </summary>
        CdcVaccineManufacturerCodes,

        /// <summary>
        /// NDA - NANDA.
        /// </summary>
        Nanda,

        /// <summary>
        /// NDC - National drug codes.
        /// </summary>
        NationalDrugCodes,

        /// <summary>
        /// NIC - Nursing Interventions Classification.
        /// </summary>
        NursingInterventionsClassification,

        /// <summary>
        /// NPI - National Provider Identifier.
        /// </summary>
        NationalProviderIdentifier,

        /// <summary>
        /// NUBC - National Uniform Billing Committee.
        /// </summary>
        NationalUniformBillingCommittee,

        /// <summary>
        /// OHA - Omaha System.
        /// </summary>
        OmahaSystem,

        /// <summary>
        /// POS - POS Codes.
        /// </summary>
        PosCodes,

        /// <summary>
        /// RC - Read Classification.
        /// </summary>
        ReadClassification,

        /// <summary>
        /// SDM - SNOMED- DICOM Microglossary.
        /// </summary>
        SnomedDicomMicroglossary,

        /// <summary>
        /// SNM - Systemized Nomenclature of Medicine (SNOMED).
        /// </summary>
        SystemizedNomenclatureOfMedicineSnomed,

        /// <summary>
        /// SNM3 - SNOMED International.
        /// </summary>
        SnomedInternational,

        /// <summary>
        /// SNT - SNOMED topology codes (anatomic sites).
        /// </summary>
        SnomedTopologyCodesAnatomicSites,

        /// <summary>
        /// UC - UCDS.
        /// </summary>
        Ucds,

        /// <summary>
        /// UMD - MDNS.
        /// </summary>
        Mdns,

        /// <summary>
        /// UML - Unified Medical Language.
        /// </summary>
        UnifiedMedicalLanguage,

        /// <summary>
        /// UPC - Universal Product Code.
        /// </summary>
        UniversalProductCode,

        /// <summary>
        /// UPIN - UPIN.
        /// </summary>
        Upin,

        /// <summary>
        /// USPS - United States Postal Service.
        /// </summary>
        UnitedStatesPostalService,

        /// <summary>
        /// W1 - WHO record # drug codes (6 digit).
        /// </summary>
        WhoRecordDrugCodes6Digit,

        /// <summary>
        /// W2 - WHO record # drug codes (8 digit).
        /// </summary>
        WhoRecordDrugCodes8Digit,

        /// <summary>
        /// W4 - WHO record # code with ASTM extension.
        /// </summary>
        WhoRecordCodeWithAstmExtension,

        /// <summary>
        /// WC - WHO ATC.
        /// </summary>
        WhoAtc
    }
}
