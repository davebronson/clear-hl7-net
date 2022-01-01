namespace ClearHl7.Codes.V271
{
    /// <summary>
    /// HL7 Version 2 Table 0496 - Consent Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0496</remarks>
    public enum CodeConsentType
    {
        /// <summary>
        /// 001 - Release of Information/MR / Authorization to Disclosure Protected Health Information.
        /// </summary>
        ReleaseOfInfoToDisclosePhi,

        /// <summary>
        /// 002 - Medical Procedure (invasive).
        /// </summary>
        MedicalProcedureInvasive,

        /// <summary>
        /// 003 - Acknowledge Receipt of Privacy Notice.
        /// </summary>
        AcknowledgeReceiptOfPrivacyNotice,

        /// <summary>
        /// 004 - Abortion.
        /// </summary>
        Abortion,

        /// <summary>
        /// 005 - Abortion/Laminaria.
        /// </summary>
        AbortionLaminaria,

        /// <summary>
        /// 006 - Accutane - Information.
        /// </summary>
        AccutaneInformation,

        /// <summary>
        /// 007 - Accutane - Woman.
        /// </summary>
        AccutaneWoman,

        /// <summary>
        /// 008 - Advanced Beneficiary Notice.
        /// </summary>
        AdvancedBeneficiaryNotice,

        /// <summary>
        /// 009 - AFP (Alpha Fetoprotein) Screening.
        /// </summary>
        AfpAlphaFetoproteinScreening,

        /// <summary>
        /// 010 - Amniocentesis (consent  refusal).
        /// </summary>
        AmniocentesisConsentRefusal,

        /// <summary>
        /// 011 - Anatomical Gift (organ donation).
        /// </summary>
        AnatomicalGiftOrganDonation,

        /// <summary>
        /// 012 - Anesthesia - Complications.
        /// </summary>
        AnesthesiaComplications,

        /// <summary>
        /// 013 - Anesthesia - Questionnaire.
        /// </summary>
        AnesthesiaQuestionnaire,

        /// <summary>
        /// 014 - Angiogram.
        /// </summary>
        Angiogram,

        /// <summary>
        /// 015 - Angioplasty.
        /// </summary>
        Angioplasty,

        /// <summary>
        /// 016 - Anticancer Drugs.
        /// </summary>
        AnticancerDrugs,

        /// <summary>
        /// 017 - Antipsychotic Medications.
        /// </summary>
        AntipsychoticMedications,

        /// <summary>
        /// 018 - Arthrogram.
        /// </summary>
        Arthrogram,

        /// <summary>
        /// 019 - Autopsy.
        /// </summary>
        Autopsy,

        /// <summary>
        /// 020 - AZT Therapy.
        /// </summary>
        AztTherapy,

        /// <summary>
        /// 021 - Biliary Drainage.
        /// </summary>
        BiliaryDrainage,

        /// <summary>
        /// 022 - Biliary Stone Extraction.
        /// </summary>
        BiliaryStoneExtraction,

        /// <summary>
        /// 023 - Biopsy.
        /// </summary>
        Biopsy,

        /// <summary>
        /// 024 - Bleeding Time Test.
        /// </summary>
        BleedingTimeTest,

        /// <summary>
        /// 025 - Bronchogram.
        /// </summary>
        Bronchogram,

        /// <summary>
        /// 026 - Cardiac Catheterization.
        /// </summary>
        CardiacCatheterization,

        /// <summary>
        /// 027 - Coronary Angiography.
        /// </summary>
        CoronaryAngiography,

        /// <summary>
        /// 028 - Coronary Angiography w/o Surgery Capability.
        /// </summary>
        CoronaryAngiographyWOSurgeryCapability,

        /// <summary>
        /// 029 - Cataract Op/Implant of FDA Aprvd Lens.
        /// </summary>
        CataractOpImplantOfFdaAprvdLens,

        /// <summary>
        /// 030 - Cataract Op/Implant of Investigational Lens.
        /// </summary>
        CataractOpImplantOfInvestigationalLens,

        /// <summary>
        /// 031 - Cataract Surgery.
        /// </summary>
        CataractSurgery,

        /// <summary>
        /// 032 - Cholera Immunization.
        /// </summary>
        CholeraImmunization,

        /// <summary>
        /// 033 - Cholesterol Screening.
        /// </summary>
        CholesterolScreening,

        /// <summary>
        /// 034 - Circumcision - Newborn.
        /// </summary>
        CircumcisionNewborn,

        /// <summary>
        /// 035 - Colonoscopy.
        /// </summary>
        Colonoscopy,

        /// <summary>
        /// 036 - Contact Lenses.
        /// </summary>
        ContactLenses,

        /// <summary>
        /// 037 - CT Scan - Cervical  Lumbar.
        /// </summary>
        CtScanCervicalLumbar,

        /// <summary>
        /// 038 - CT Scan w/ IV Contrast Media into Vein.
        /// </summary>
        CtScanWIvContrastMediaIntoVein,

        /// <summary>
        /// 039 - CVS (Chorionic Villus) Sampling.
        /// </summary>
        CvsChorionicVillusSampling,

        /// <summary>
        /// 040 - Cystospy.
        /// </summary>
        Cystospy,

        /// <summary>
        /// 041 - Disclosure of Protected Health Information to Family/Friends.
        /// </summary>
        DisclosureOfPhiToFamilyFriends,

        /// <summary>
        /// 042 - D  C and Conization.
        /// </summary>
        DCAndConization,

        /// <summary>
        /// 043 - Dacryocystogram.
        /// </summary>
        Dacryocystogram,

        /// <summary>
        /// 044 - Diagnostic Isotope.
        /// </summary>
        DiagnosticIsotope,

        /// <summary>
        /// 045 - Drainage of an Abscess.
        /// </summary>
        DrainageOfAnAbscess,

        /// <summary>
        /// 046 - Drug Screening.
        /// </summary>
        DrugScreening,

        /// <summary>
        /// 047 - Electronic Monitoring of Labor - Refusal.
        /// </summary>
        ElectronicMonitoringOfLaborRefusal,

        /// <summary>
        /// 048 - Endometrial Biopsy.
        /// </summary>
        EndometrialBiopsy,

        /// <summary>
        /// 049 - Endoscopy/Sclerosis of Esophageal Varices.
        /// </summary>
        EndoscopySclerosisOfEsophagealVarices,

        /// <summary>
        /// 050 - ERCP.
        /// </summary>
        Ercp,

        /// <summary>
        /// 051 - Exposure to reportable Communicable Disease.
        /// </summary>
        ExposureToReportableCommunicableDisease,

        /// <summary>
        /// 052 - External Version.
        /// </summary>
        ExternalVersion,

        /// <summary>
        /// 053 - Fluorescein Angioscopy.
        /// </summary>
        FluoresceinAngioscopy,

        /// <summary>
        /// 054 - Hepatitis B - Consent/Declination.
        /// </summary>
        HepatitisBConsentDeclination,

        /// <summary>
        /// 055 - Herniogram.
        /// </summary>
        Herniogram,

        /// <summary>
        /// 056 - HIV Test - Consent Refusal.
        /// </summary>
        HivTestConsentRefusal,

        /// <summary>
        /// 057 - HIV Test - Disclosure.
        /// </summary>
        HivTestDisclosure,

        /// <summary>
        /// 058 - HIV Test - Prenatal.
        /// </summary>
        HivTestPrenatal,

        /// <summary>
        /// 059 - Home IV Treatment Program.
        /// </summary>
        HomeIvTreatmentProgram,

        /// <summary>
        /// 060 - Home Parenteral Treatment Program.
        /// </summary>
        HomeParenteralTreatmentProgram,

        /// <summary>
        /// 061 - Hysterectomy.
        /// </summary>
        Hysterectomy,

        /// <summary>
        /// 062 - Hysterosalpingogram.
        /// </summary>
        Hysterosalpingogram,

        /// <summary>
        /// 063 - Injection Slip/ Consent.
        /// </summary>
        InjectionSlipConsent,

        /// <summary>
        /// 064 - Intrauterine Device.
        /// </summary>
        IntrauterineDevice,

        /// <summary>
        /// 065 - Intrauterine Device/Sterilization.
        /// </summary>
        IntrauterineDeviceSterilization,

        /// <summary>
        /// 066 - Intravascular Infusion of Streptokinase/Urokinase.
        /// </summary>
        IntravascularInfusionOfStreptokinaseUrokinase,

        /// <summary>
        /// 067 - Intravenous Cholangiogram.
        /// </summary>
        IntravenousCholangiogram,

        /// <summary>
        /// 068 - Intravenous Digital Angiography.
        /// </summary>
        IntravenousDigitalAngiography,

        /// <summary>
        /// 069 - Iodine Administration.
        /// </summary>
        IodineAdministration,

        /// <summary>
        /// 070 - ISG.
        /// </summary>
        Isg,

        /// <summary>
        /// 071 - IVP.
        /// </summary>
        Ivp,

        /// <summary>
        /// 072 - Laser Photocoagulation.
        /// </summary>
        LaserPhotocoagulation,

        /// <summary>
        /// 073 - Laser treatment.
        /// </summary>
        LaserTreatment,

        /// <summary>
        /// 074 - Lithium Carbonate.
        /// </summary>
        LithiumCarbonate,

        /// <summary>
        /// 075 - Liver Biopsy.
        /// </summary>
        LiverBiopsy,

        /// <summary>
        /// 076 - Lumbar Puncture.
        /// </summary>
        LumbarPuncture,

        /// <summary>
        /// 077 - Lymphangiogram.
        /// </summary>
        Lymphangiogram,

        /// <summary>
        /// 078 - MAO Inhibitors.
        /// </summary>
        MaoInhibitors,

        /// <summary>
        /// 079 - Med, Psych, and/or Drug/Alcohol.
        /// </summary>
        MedPsychAndOrDrugAlcohol,

        /// <summary>
        /// 080 - Medical Treatment - Refusal.
        /// </summary>
        MedicalTreatmentRefusal,

        /// <summary>
        /// 081 - Morning-after Pill.
        /// </summary>
        MorningAfterPill,

        /// <summary>
        /// 082 - MRI - Adult.
        /// </summary>
        MriAdult,

        /// <summary>
        /// 083 - MRI - Pediatric.
        /// </summary>
        MriPediatric,

        /// <summary>
        /// 084 - Myelogram.
        /// </summary>
        Myelogram,

        /// <summary>
        /// 085 - Needle Biopsy.
        /// </summary>
        NeedleBiopsy,

        /// <summary>
        /// 086 - Needle Biopsy of Lung.
        /// </summary>
        NeedleBiopsyOfLung,

        /// <summary>
        /// 087 - Newborn Treatment and Release.
        /// </summary>
        NewbornTreatmentAndRelease,

        /// <summary>
        /// 088 - Norplant Subdermal Birth Control Implant.
        /// </summary>
        NorplantSubdermalBirthControlImplant,

        /// <summary>
        /// 089 - Operations, Anesthesia, Transfusions.
        /// </summary>
        OperationsAnesthesiaTransfusions,

        /// <summary>
        /// 090 - Oral Contraceptives.
        /// </summary>
        OralContraceptives,

        /// <summary>
        /// 091 - Organ Donation.
        /// </summary>
        OrganDonation,

        /// <summary>
        /// 092 - Patient Permits, Consents.
        /// </summary>
        PatientPermitsConsents,

        /// <summary>
        /// 093 - Patient Treatment Permit, Release  Admission.
        /// </summary>
        PatientTreatmentPermitReleaseAdmission,

        /// <summary>
        /// 094 - Penile Injections.
        /// </summary>
        PenileInjections,

        /// <summary>
        /// 095 - Percutaneous Nephrostomy.
        /// </summary>
        PercutaneousNephrostomy,

        /// <summary>
        /// 096 - Percutaneous Transhepatic Cholangiogram.
        /// </summary>
        PercutaneousTranshepaticCholangiogram,

        /// <summary>
        /// 097 - Photographs.
        /// </summary>
        Photographs,

        /// <summary>
        /// 098 - Photographs - Employee.
        /// </summary>
        PhotographsEmployee,

        /// <summary>
        /// 099 - Photographs - Medical Research.
        /// </summary>
        PhotographsMedicalResearch,

        /// <summary>
        /// 100 - Photographs - news Media.
        /// </summary>
        PhotographsNewsMedia,

        /// <summary>
        /// 101 - Psychiatric Admission - Next of Kin.
        /// </summary>
        PsychiatricAdmissionNextOfKin,

        /// <summary>
        /// 102 - Psychiatric Information During Hospital Stay.
        /// </summary>
        PsychiatricInformationDuringHospitalStay,

        /// <summary>
        /// 103 - Public Release of Information.
        /// </summary>
        PublicReleaseOfInformation,

        /// <summary>
        /// 104 - Radiologic Procedure.
        /// </summary>
        RadiologicProcedure,

        /// <summary>
        /// 105 - Refusal of Treatment.
        /// </summary>
        RefusalOfTreatment,

        /// <summary>
        /// 106 - Release of Body.
        /// </summary>
        ReleaseOfBody,

        /// <summary>
        /// 107 - Release of Limb.
        /// </summary>
        ReleaseOfLimb,

        /// <summary>
        /// 108 - Rh Immune Globulin.
        /// </summary>
        RhImmuneGlobulin,

        /// <summary>
        /// 109 - Rights of Medical Research Participants.
        /// </summary>
        RightsOfMedicalResearchParticipants,

        /// <summary>
        /// 110 - Request to Restrict Access/Disclosure to Medical Record/Protected Health Information.
        /// </summary>
        RequestToRestrictAccessToPhi,

        /// <summary>
        /// 111 - Request for Remain Anonymous.
        /// </summary>
        RequestForRemainAnonymous,

        /// <summary>
        /// 112 - Seat Belt Exemption.
        /// </summary>
        SeatBeltExemption,

        /// <summary>
        /// 113 - Sialogram.
        /// </summary>
        Sialogram,

        /// <summary>
        /// 1137 - Voiding Cystogram.
        /// </summary>
        VoidingCystogram,

        /// <summary>
        /// 114 - Sigmoidoscopy.
        /// </summary>
        Sigmoidoscopy,

        /// <summary>
        /// 115 - Sterilization - Anesthesia  Medical Services.
        /// </summary>
        SterilizationAnesthesiaMedicalServices,

        /// <summary>
        /// 116 - Sterilization -Federally Funded.
        /// </summary>
        SterilizationFederallyFunded,

        /// <summary>
        /// 117 - Sterilization - Female.
        /// </summary>
        SterilizationFemale,

        /// <summary>
        /// 118 - Sterilization - Laparoscopy/Pomeroy.
        /// </summary>
        SterilizationLaparoscopyPomeroy,

        /// <summary>
        /// 119 - Sterilization - Non-Federally Funded.
        /// </summary>
        SterilizationNonFederallyFunded,

        /// <summary>
        /// 120 - Sterilization - Secondary.
        /// </summary>
        SterilizationSecondary,

        /// <summary>
        /// 121 - Tranquilizers.
        /// </summary>
        Tranquilizers,

        /// <summary>
        /// 122 - Transfer - Acknowledgement.
        /// </summary>
        TransferAcknowledgement,

        /// <summary>
        /// 123 - Transfer - Authorization.
        /// </summary>
        TransferAuthorization,

        /// <summary>
        /// 124 - Transfer Certification - Physician.
        /// </summary>
        TransferCertificationPhysician,

        /// <summary>
        /// 125 - Transfer/Discharge Request.
        /// </summary>
        TransferDischargeRequest,

        /// <summary>
        /// 126 - Transfer for Non-Medical Reasons.
        /// </summary>
        TransferForNonMedicalReasons,

        /// <summary>
        /// 127 - Transfer - Interfaculty Neonatal.
        /// </summary>
        TransferInterfacultyNeonatal,

        /// <summary>
        /// 128 - Transfer Refusal.
        /// </summary>
        TransferRefusal,

        /// <summary>
        /// 129 - Transfer Refusal of Further Treatment.
        /// </summary>
        TransferRefusalOfFurtherTreatment,

        /// <summary>
        /// 130 - Treadmill  EKG.
        /// </summary>
        TreadmillEkg,

        /// <summary>
        /// 131 - Treadmill, Thallium-201.
        /// </summary>
        TreadmillThallium201,

        /// <summary>
        /// 132 - Typhoid.
        /// </summary>
        Typhoid,

        /// <summary>
        /// 133 - Use of Investigational Device.
        /// </summary>
        UseOfInvestigationalDevice,

        /// <summary>
        /// 134 - Use of Investigational Drug.
        /// </summary>
        UseOfInvestigationalDrug,

        /// <summary>
        /// 135 - Venogram.
        /// </summary>
        Venogram,

        /// <summary>
        /// 136 - Videotape.
        /// </summary>
        Videotape
    }
}
