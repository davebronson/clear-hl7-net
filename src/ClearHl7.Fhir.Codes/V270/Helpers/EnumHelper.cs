using System;

namespace ClearHl7.Fhir.Codes.V270.Helpers
{
    /// <summary>
    /// Provides helper methods for interacting with enumerations.
    /// </summary>
    public class EnumHelper : IEnumHelper
    {
        /// <summary>
        /// Converts the given AcceptApplicationAcknowledgmentConditions enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AcceptApplicationAcknowledgmentConditions input)
        {
            return input switch
            {
                AcceptApplicationAcknowledgmentConditions.Always => "AL",
                AcceptApplicationAcknowledgmentConditions.ErrorRejectConditionsOnly => "ER",
                AcceptApplicationAcknowledgmentConditions.Never => "NE",
                AcceptApplicationAcknowledgmentConditions.SuccessfulCompletionOnly => "SU",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AccessRestrictionReasonCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AccessRestrictionReasonCode input)
        {
            return input switch
            {
                AccessRestrictionReasonCode.DiagnosisRelated => "DIA",
                AccessRestrictionReasonCode.EmployeeOfThisOrganization => "EMP",
                AccessRestrictionReasonCode.OrganizationalPolicyOrRequirement => "ORG",
                AccessRestrictionReasonCode.PatientRequest => "PAT",
                AccessRestrictionReasonCode.PhysicianRequest => "PHY",
                AccessRestrictionReasonCode.RegulatoryRequirement => "REG",
                AccessRestrictionReasonCode.VeryImportantPersonOrCelebrity => "VIP",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AccessRestrictionValueCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AccessRestrictionValueCode input)
        {
            return input switch
            {
                AccessRestrictionValueCode.All => "ALL",
                AccessRestrictionValueCode.AllDemographicData => "DEM",
                AccessRestrictionValueCode.Drug => "DRG",
                AccessRestrictionValueCode.HivStatusAndResults => "HIV",
                AccessRestrictionValueCode.PatientLocation => "LOC",
                AccessRestrictionValueCode.None => "NO",
                AccessRestrictionValueCode.OptInAllRegistriesHipaa => "OI",
                AccessRestrictionValueCode.OptOutAllRegistriesHipaa => "OO",
                AccessRestrictionValueCode.Religion => "PID-17",
                AccessRestrictionValueCode.DateOfBirth => "PID-7",
                AccessRestrictionValueCode.PsychiatricMentalHealth => "PSY",
                AccessRestrictionValueCode.SensitiveMedicalData => "SMD",
                AccessRestrictionValueCode.SexuallyTransmittedDiseases => "STD",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AcknowledgmentTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AcknowledgmentTypeCode input)
        {
            return input switch
            {
                AcknowledgmentTypeCode.OriginalModeAcceptEnhancedModeAcknowledgmentAccept => "AA",
                AcknowledgmentTypeCode.OriginalModeErrorEnhancedModeAcknowledgmentError => "AE",
                AcknowledgmentTypeCode.OriginalModeRejectEnhancedModeAcknowledgmentReject => "AR",
                AcknowledgmentTypeCode.EnhancedModeAcceptAcknowledgmentCommitAccept => "CA",
                AcknowledgmentTypeCode.EnhancedModeAcceptAcknowledgmentCommitError => "CE",
                AcknowledgmentTypeCode.EnhancedModeAcceptAcknowledgmentCommitReject => "CR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ActionTakenInResponseToTheEventCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ActionTakenInResponseToTheEventCode input)
        {
            return input switch
            {
                ActionTakenInResponseToTheEventCode.ProductDoseIncreased => "DI",
                ActionTakenInResponseToTheEventCode.ProductDoseReduced => "DR",
                ActionTakenInResponseToTheEventCode.None => "N",
                ActionTakenInResponseToTheEventCode.Other => "OT",
                ActionTakenInResponseToTheEventCode.ProductWithdrawnPermanently => "WP",
                ActionTakenInResponseToTheEventCode.ProductWithdrawnTemporarily => "WT",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ActiveInactive enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ActiveInactive input)
        {
            return input switch
            {
                ActiveInactive.ActiveStaff => "A",
                ActiveInactive.InactiveStaff => "I",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ActPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ActPriority input)
        {
            return input switch
            {
                ActPriority.AsSoonAsPossible => "A",
                ActPriority.CallbackResults => "CR",
                ActPriority.CallbackForScheduling => "CS",
                ActPriority.CallbackPlacerForScheduling => "CSP",
                ActPriority.ContactRecipientForScheduling => "CSR",
                ActPriority.Elective => "EL",
                ActPriority.Emergency => "EM",
                ActPriority.Preop => "P",
                ActPriority.AsNeeded => "PRN",
                ActPriority.Routine => "R",
                ActPriority.RushReporting => "RR",
                ActPriority.Stat => "S",
                ActPriority.TimingCritical => "T",
                ActPriority.UseAsDirected => "UD",
                ActPriority.Urgent => "UR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdditivePreservative enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdditivePreservative input)
        {
            return input switch
            {
                AdditivePreservative.AcdSolutionA => "ACDA",
                AdditivePreservative.AcdSolutionB => "ACDB",
                AdditivePreservative.AceticAcid => "ACET",
                AdditivePreservative.AmiesTransportMedium => "AMIES",
                AdditivePreservative.BacterialTransportMedium => "BACTM",
                AdditivePreservative.Buffered10Formalin => "BF10",
                AdditivePreservative.BorateBoricAcid => "BOR",
                AdditivePreservative.BouinsSolution => "BOUIN",
                AdditivePreservative.BufferedSkimMilk => "BSKM",
                AdditivePreservative.ThreePointTwoPercentCitrate => "C32",
                AdditivePreservative.ThreePointEightPercentCitrate => "C38",
                AdditivePreservative.CarsonsModified10Formalin => "CARS",
                AdditivePreservative.CaryBlairMedium => "CARY",
                AdditivePreservative.ChlamydiaTransportMedium => "CHLTM",
                AdditivePreservative.Ctad => "CTAD",
                AdditivePreservative.PotassiumKEdta => "EDTK",
                AdditivePreservative.PotassiumKEdta15 => "EDTK15",
                AdditivePreservative.PotassiumKEdta75 => "EDTK75",
                AdditivePreservative.SodiumNaEdta => "EDTN",
                AdditivePreservative.EntericBacteriaTransportMedium => "ENT",
                AdditivePreservative.EntericPlus => "ENT+",
                AdditivePreservative.TenPercentFormalin => "F10",
                AdditivePreservative.ThrombinNih => "FDP",
                AdditivePreservative.SodiumFluoride10Mg => "FL10",
                AdditivePreservative.SodiumFluoride100Mg => "FL100",
                AdditivePreservative.SixNHcl => "HCL6",
                AdditivePreservative.AmmoniumHeparin => "HEPA",
                AdditivePreservative.LithiumLiHeparin => "HEPL",
                AdditivePreservative.SodiumNaHeparin => "HEPN",
                AdditivePreservative.NitricAcid => "HNO3",
                AdditivePreservative.JonesKendrickMedium => "JKM",
                AdditivePreservative.KarnovskysFixative => "KARN",
                AdditivePreservative.PotassiumOxalate => "KOX",
                AdditivePreservative.LithiumIodoacetate => "LIA",
                AdditivePreservative.M4 => "M4",
                AdditivePreservative.M4Rt => "M4RT",
                AdditivePreservative.M5 => "M5",
                AdditivePreservative.MichelsTransportMedium => "MICHTM",
                AdditivePreservative.MmdTransportMedium => "MMDTM",
                AdditivePreservative.SodiumFluoride => "NAF",
                AdditivePreservative.SodiumPolyanetholSulfonate035 => "NAPS",
                AdditivePreservative.None => "NONE",
                AdditivePreservative.PagessSaline => "PAGE",
                AdditivePreservative.Phenol => "PHENOL",
                AdditivePreservative.PvaPolyvinylalcohol => "PVA",
                AdditivePreservative.ReaganLoweMedium => "RLM",
                AdditivePreservative.SiliceousEarth12Mg => "SILICA",
                AdditivePreservative.Sps => "SPS",
                AdditivePreservative.SerumSeparatorTubePolymerGel => "SST",
                AdditivePreservative.StuartTransportMedium => "STUTM",
                AdditivePreservative.Thrombin => "THROM",
                AdditivePreservative.Thymol => "THYMOL",
                AdditivePreservative.ThyoglycollateBroth => "THYO",
                AdditivePreservative.Toluene => "TOLU",
                AdditivePreservative.UreaplasmaTransportMedium => "URETM",
                AdditivePreservative.ViralTransportMedium => "VIRTM",
                AdditivePreservative.BufferedCitrate => "WEST",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AddressExpirationReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AddressExpirationReason input)
        {
            return input switch
            {
                AddressExpirationReason.Corrected => "C",
                AddressExpirationReason.AddedInError => "E",
                AddressExpirationReason.Moved => "M",
                AddressExpirationReason.OnRequest => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AddressTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AddressTypeCode input)
        {
            return input switch
            {
                AddressTypeCode.FirmBusiness => "B",
                AddressTypeCode.BadAddress => "BA",
                AddressTypeCode.BirthDeliveryLocation => "BDL",
                AddressTypeCode.BillingAddress => "BI",
                AddressTypeCode.ResidenceAtBirth => "BR",
                AddressTypeCode.CurrentOrTemporary => "C",
                AddressTypeCode.CountryOfOrigin => "F",
                AddressTypeCode.Home => "H",
                AddressTypeCode.LegalAddress => "L",
                AddressTypeCode.Mailing => "M",
                AddressTypeCode.BirthNee => "N",
                AddressTypeCode.OfficeBusiness => "O",
                AddressTypeCode.Permanent => "P",
                AddressTypeCode.RegistryHome => "RH",
                AddressTypeCode.ServiceLocation => "S",
                AddressTypeCode.ShippingAddress => "SH",
                AddressTypeCode.TubeAddress => "TM",
                AddressTypeCode.Vacation => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AddressUsageCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AddressUsageCode input)
        {
            return input switch
            {
                AddressUsageCode.Classification => "C",
                AddressUsageCode.Mailing => "M",
                AddressUsageCode.Visit => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdjustmentActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdjustmentActionCode input)
        {
            return input switch
            {
                AdjustmentActionCode.PrintOnEob => "EOB",
                AdjustmentActionCode.InformPatient => "PAT",
                AdjustmentActionCode.InformProvider => "PRO",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdjustmentCategoryCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdjustmentCategoryCode input)
        {
            return input switch
            {
                AdjustmentCategoryCode.EditAdjudicationResponse => "EA",
                AdjustmentCategoryCode.Information => "IN",
                AdjustmentCategoryCode.ProviderAdjustment => "PA",
                AdjustmentCategoryCode.ProcessingResult => "PR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdministrationDeviceCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdministrationDeviceCode input)
        {
            return input switch
            {
                AdministrationDeviceCode.Applicator => "AP",
                AdministrationDeviceCode.Buretrol => "BT",
                AdministrationDeviceCode.HeparinLock => "HL",
                AdministrationDeviceCode.Ippb => "IPPB",
                AdministrationDeviceCode.IvPump => "IVP",
                AdministrationDeviceCode.IvSoluset => "IVS",
                AdministrationDeviceCode.MeteredInhaler => "MI",
                AdministrationDeviceCode.Nebulizer => "NEB",
                AdministrationDeviceCode.PcaPump => "PCA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdministrationMethodCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdministrationMethodCode input)
        {
            return input switch
            {
                AdministrationMethodCode.Chew => "CH",
                AdministrationMethodCode.Dissolve => "DI",
                AdministrationMethodCode.Dust => "DU",
                AdministrationMethodCode.Infiltrate => "IF",
                AdministrationMethodCode.Irrigate => "IR",
                AdministrationMethodCode.Insert => "IS",
                AdministrationMethodCode.IvPush => "IVP",
                AdministrationMethodCode.IvPiggyback => "IVPB",
                AdministrationMethodCode.Nebulized => "NB",
                AdministrationMethodCode.Perfuse => "PF",
                AdministrationMethodCode.Paint => "PT",
                AdministrationMethodCode.Shampoo => "SH",
                AdministrationMethodCode.Soak => "SO",
                AdministrationMethodCode.Wash => "WA",
                AdministrationMethodCode.Wipe => "WI",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdministrativeSex enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdministrativeSex input)
        {
            return input switch
            {
                AdministrativeSex.Ambiguous => "A",
                AdministrativeSex.Female => "F",
                AdministrativeSex.Male => "M",
                AdministrativeSex.NotApplicable => "N",
                AdministrativeSex.Other => "O",
                AdministrativeSex.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdmissionLevelOfCareCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdmissionLevelOfCareCode input)
        {
            return input switch
            {
                AdmissionLevelOfCareCode.Acute => "AC",
                AdmissionLevelOfCareCode.Chronic => "CH",
                AdmissionLevelOfCareCode.Comatose => "CO",
                AdmissionLevelOfCareCode.Critical => "CR",
                AdmissionLevelOfCareCode.Improved => "IM",
                AdmissionLevelOfCareCode.Moribund => "MO",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdmissionType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdmissionType input)
        {
            return input switch
            {
                AdmissionType.Accident => "A",
                AdmissionType.Elective => "C",
                AdmissionType.Emergency => "E",
                AdmissionType.LaborAndDelivery => "L",
                AdmissionType.NewbornBirthInHealthcareFacility => "N",
                AdmissionType.Routine => "R",
                AdmissionType.Urgent => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdmitSource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdmitSource input)
        {
            return input switch
            {
                AdmitSource.NoSuggestedValuesDefined => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdvancedBeneficiaryNoticeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdvancedBeneficiaryNoticeCode input)
        {
            return input switch
            {
                AdvancedBeneficiaryNoticeCode.ServiceSubjectToMedicalNecessity => "1",
                AdvancedBeneficiaryNoticeCode.PatientHasBeenInformedAndAgreesToPayForService => "2",
                AdvancedBeneficiaryNoticeCode.PatientHasBeenInformedAndAsksThatPayerBeBilled => "3",
                AdvancedBeneficiaryNoticeCode.AdvancedBeneficiaryNoticeHasNotBeenSigned => "4",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdvanceDirectiveCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdvanceDirectiveCode input)
        {
            return input switch
            {
                AdvanceDirectiveCode.DoNotResuscitate => "DNR",
                AdvanceDirectiveCode.NoDirective => "N",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AlertDeviceCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AlertDeviceCode input)
        {
            return input switch
            {
                AlertDeviceCode.Bracelet => "B",
                AlertDeviceCode.Necklace => "N",
                AlertDeviceCode.WalletCard => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AlertLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AlertLevel input)
        {
            return input switch
            {
                AlertLevel.NullNoLevelChangeADeprecated => "...",
                AlertLevel.Critical => "C",
                AlertLevel.Normal => "N",
                AlertLevel.Serious => "S",
                AlertLevel.Warning => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AllergenType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AllergenType input)
        {
            return input switch
            {
                AllergenType.AnimalAllergy => "AA",
                AllergenType.DrugAllergy => "DA",
                AllergenType.EnvironmentalAllergy => "EA",
                AllergenType.FoodAllergy => "FA",
                AllergenType.PollenAllergy => "LA",
                AllergenType.MiscellaneousAllergy => "MA",
                AllergenType.MiscellaneousContraindication => "MC",
                AllergenType.PlantAllergy => "PA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AllergyClinicalStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AllergyClinicalStatus input)
        {
            return input switch
            {
                AllergyClinicalStatus.ConfirmedOrVerified => "C",
                AllergyClinicalStatus.DoubtRaised => "D",
                AllergyClinicalStatus.Erroneous => "E",
                AllergyClinicalStatus.ConfirmedButInactive => "I",
                AllergyClinicalStatus.Pending => "P",
                AllergyClinicalStatus.Suspect => "S",
                AllergyClinicalStatus.Unconfirmed => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AllergySeverity enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AllergySeverity input)
        {
            return input switch
            {
                AllergySeverity.Mild => "MI",
                AllergySeverity.Moderate => "MO",
                AllergySeverity.Severe => "SV",
                AllergySeverity.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AllowSubstitution enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AllowSubstitution input)
        {
            return input switch
            {
                AllowSubstitution.AllowGenericSubstitutions => "G",
                AllowSubstitution.SubstitutionsAreNotAuthorized => "N",
                AllowSubstitution.AllowTherapeuticSubstitutions => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AllowSubstitutionCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AllowSubstitutionCodes input)
        {
            return input switch
            {
                AllowSubstitutionCodes.ContactPlacerPriorToSubstitution => "Confirm",
                AllowSubstitutionCodes.SubstitutionIsNotAllowed => "No",
                AllowSubstitutionCodes.NotifyPlacerThatSubstitutionHasBeenMade => "Notify",
                AllowSubstitutionCodes.SubstitutionOfThisResourceIsAllowed => "Yes",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AlternateCharacterSetHandlingScheme enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AlternateCharacterSetHandlingScheme input)
        {
            return input switch
            {
                AlternateCharacterSetHandlingScheme.CharacterSetSwitchingXpnExtendedPersonName => "2.3",
                AlternateCharacterSetHandlingScheme.NoCharacterSetSwitching => "null",
                AlternateCharacterSetHandlingScheme.Iso20221994 => "ISO 2022-1994",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AlternateCharacterSets enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AlternateCharacterSets input)
        {
            return input switch
            {
                AlternateCharacterSets.Iso88591CharacterSet => "8859/1",
                AlternateCharacterSets.Iso885915Latin15 => "8859/15",
                AlternateCharacterSets.Iso88592CharacterSet => "8859/2",
                AlternateCharacterSets.Iso88593CharacterSet => "8859/3",
                AlternateCharacterSets.Iso88594CharacterSet => "8859/4",
                AlternateCharacterSets.Iso88595CharacterSet => "8859/5",
                AlternateCharacterSets.Iso88596CharacterSet => "8859/6",
                AlternateCharacterSets.Iso88597CharacterSet => "8859/7",
                AlternateCharacterSets.Iso88598CharacterSet => "8859/8",
                AlternateCharacterSets.Iso88599CharacterSet => "8859/9",
                AlternateCharacterSets.Seven7BitAsciiCharacterSet => "ASCII",
                AlternateCharacterSets.TaiwaneseBig5 => "BIG-5",
                AlternateCharacterSets.TaiwaneseCns116431992 => "CNS 11643-1992",
                AlternateCharacterSets.ChineseGb180302000 => "GB 18030-2000",
                AlternateCharacterSets.InfoExchangeOneByteJisX02011976 => "ISO IR14",
                AlternateCharacterSets.JapaneseGraphicJisX02121990 => "ISO IR159",
                AlternateCharacterSets.AsciiGraphic94Characters => "ISO IR6",
                AlternateCharacterSets.JapaneseGraphicJisX02081990 => "ISO IR87",
                AlternateCharacterSets.KoreanKsX1001 => "KS X 1001",
                AlternateCharacterSets.IsoIec1064611993 => "UNICODE",
                AlternateCharacterSets.UcsTransformationFormat16Bit => "UNICODE UTF-16",
                AlternateCharacterSets.UcsTransformationFormat32Bit => "UNICODE UTF-32",
                AlternateCharacterSets.UcsTransformationFormat8Bit => "UNICODE UTF-8",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AmbulatoryPaymentClassificationCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AmbulatoryPaymentClassificationCode input)
        {
            return input switch
            {
                AmbulatoryPaymentClassificationCode.NoSuggestedValuesDefined => "...",
                AmbulatoryPaymentClassificationCode.DentalProcedures => "031",
                AmbulatoryPaymentClassificationCode.ExcisionBiopsy => "163",
                AmbulatoryPaymentClassificationCode.Level1SkinRepair => "181",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AmbulatoryStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AmbulatoryStatus input)
        {
            return input switch
            {
                AmbulatoryStatus.NoFunctionalLimitations => "A0",
                AmbulatoryStatus.AmbulatesWithAssistiveDevice => "A1",
                AmbulatoryStatus.WheelchairStretcherBound => "A2",
                AmbulatoryStatus.ComatoseNonResponsive => "A3",
                AmbulatoryStatus.Disoriented => "A4",
                AmbulatoryStatus.VisionImpaired => "A5",
                AmbulatoryStatus.HearingImpaired => "A6",
                AmbulatoryStatus.SpeechImpaired => "A7",
                AmbulatoryStatus.NonEnglishSpeaking => "A8",
                AmbulatoryStatus.FunctionalLevelUnknown => "A9",
                AmbulatoryStatus.OxygenTherapy => "B1",
                AmbulatoryStatus.SpecialEquipmentTubesIvsCatheters => "B2",
                AmbulatoryStatus.Amputee => "B3",
                AmbulatoryStatus.Mastectomy => "B4",
                AmbulatoryStatus.Paraplegic => "B5",
                AmbulatoryStatus.Pregnant => "B6",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AmountClass enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AmountClass input)
        {
            return input switch
            {
                AmountClass.Amount => "AT",
                AmountClass.Limit => "LM",
                AmountClass.Percentage => "PC",
                AmountClass.Unlimited => "UL",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AmountType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AmountType input)
        {
            return input switch
            {
                AmountType.Differential => "DF",
                AmountType.Limit => "LM",
                AmountType.Percentage => "PC",
                AmountType.Rate => "RT",
                AmountType.Unlimited => "UL",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AnalyteRepeatStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AnalyteRepeatStatus input)
        {
            return input switch
            {
                AnalyteRepeatStatus.RepeatedWithDilution => "D",
                AnalyteRepeatStatus.ReflexTest => "F",
                AnalyteRepeatStatus.OriginalFirstRun => "O",
                AnalyteRepeatStatus.RepeatedWithoutDilution => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Annotations enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(Annotations input)
        {
            return input switch
            {
                Annotations.PaceSpike => "9900",
                Annotations.SasMarker => "9901",
                Annotations.SenseMarker => "9902",
                Annotations.BeatMarker => "9903",
                Annotations.Etc => "9904",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ApplicationChangeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ApplicationChangeType input)
        {
            return input switch
            {
                ApplicationChangeType.MigratesToDifferentCpu => "M",
                ApplicationChangeType.ShutDown => "SD",
                ApplicationChangeType.StartUp => "SU",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AppointmentReasonCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AppointmentReasonCodes input)
        {
            return input switch
            {
                AppointmentReasonCodes.ARoutineCheckUpSuchAsAnAnnualPhysical => "CHECKUP",
                AppointmentReasonCodes.EmergencyAppointment => "EMERGENCY",
                AppointmentReasonCodes.AFollowUpVisitFromAPreviousAppointment => "FOLLOWUP",
                AppointmentReasonCodes.RoutineAppointmentDefaultIfNotValued => "ROUTINE",
                AppointmentReasonCodes.APreviouslyUnscheduledWalkInVisit => "WALKIN",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AppointmentTypeCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AppointmentTypeCodes input)
        {
            return input switch
            {
                AppointmentTypeCodes.RequestToAddCompletedAppointment => "Complete",
                AppointmentTypeCodes.RoutineScheduleRequestTypeDefaultIfNotValued => "Normal",
                AppointmentTypeCodes.RequestForTentativeAppointment => "Tentative",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ApprovingRegulatoryAgency enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ApprovingRegulatoryAgency input)
        {
            return input switch
            {
                ApprovingRegulatoryAgency.AmericanMedicalAssociation => "AMA",
                ApprovingRegulatoryAgency.FoodAndDrugAdministration => "FDA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ArtificialBlood enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ArtificialBlood input)
        {
            return input switch
            {
                ArtificialBlood.Fluorocarbons => "FLUR",
                ArtificialBlood.StromalFreeHemoglobinPreparations => "SFHB",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AssigningAuthority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AssigningAuthority input)
        {
            return input switch
            {
                AssigningAuthority.NoSuggestedValuesDefined => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AssignmentOfBenefits enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AssignmentOfBenefits input)
        {
            return input switch
            {
                AssignmentOfBenefits.ModifiedAssignment => "M",
                AssignmentOfBenefits.No => "N",
                AssignmentOfBenefits.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AuthorizationMode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AuthorizationMode input)
        {
            return input switch
            {
                AuthorizationMode.Electronic => "EL",
                AuthorizationMode.EMail => "EM",
                AuthorizationMode.Fax => "FX",
                AuthorizationMode.InPerson => "IP",
                AuthorizationMode.Mail => "MA",
                AuthorizationMode.Paper => "PA",
                AuthorizationMode.Phone => "PH",
                AuthorizationMode.ReflexiveAutomatedSystem => "RE",
                AuthorizationMode.VideoConference => "VC",
                AuthorizationMode.Voice => "VO",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given BedStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(BedStatus input)
        {
            return input switch
            {
                BedStatus.Closed => "C",
                BedStatus.Housekeeping => "H",
                BedStatus.Isolated => "I",
                BedStatus.Contaminated => "K",
                BedStatus.Occupied => "O",
                BedStatus.Unoccupied => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given BenefitGroup enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(BenefitGroup input)
        {
            return input switch
            {
                BenefitGroup.AmbulatoryCare => "AMB",
                BenefitGroup.Dental => "DENT",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given BloodProductCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(BloodProductCode input)
        {
            return input switch
            {
                BloodProductCode.CryoprecipitatedAhf => "CRYO",
                BloodProductCode.PooledCryoprecipitate => "CRYOP",
                BloodProductCode.FreshFrozenPlasma => "FFP",
                BloodProductCode.FreshFrozenPlasmaThawed => "FFPTH",
                BloodProductCode.PackedCells => "PC",
                BloodProductCode.AutologousPackedCells => "PCA",
                BloodProductCode.PackedCellsNeonatal => "PCNEO",
                BloodProductCode.WashedPackedCells => "PCW",
                BloodProductCode.PlateletConcentrate => "PLT",
                BloodProductCode.ReducedVolumePlatelets => "PLTNEO",
                BloodProductCode.PooledPlatelets => "PLTP",
                BloodProductCode.PlateletPheresis => "PLTPH",
                BloodProductCode.LeukoreducedPlateletPheresis => "PLTPHLR",
                BloodProductCode.ReconstitutedWholeBlood => "RWB",
                BloodProductCode.AutologousWholeBlood => "WBA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given BloodProductDispenseStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(BloodProductDispenseStatus input)
        {
            return input switch
            {
                BloodProductDispenseStatus.ReleasedIntoInventory => "CR",
                BloodProductDispenseStatus.DispensedToPatient => "DS",
                BloodProductDispenseStatus.PresumedTransfused => "PT",
                BloodProductDispenseStatus.ReturnedUnused => "RA",
                BloodProductDispenseStatus.ReservedAndReadyToDispense => "RD",
                BloodProductDispenseStatus.ReleasedNoLongerAllocated => "RE",
                BloodProductDispenseStatus.ReceivedIntoInventory => "RI",
                BloodProductDispenseStatus.ReturnedUnusedKeepLinkedToPatient => "RL",
                BloodProductDispenseStatus.RequestToDispenseBloodProduct => "RQ",
                BloodProductDispenseStatus.Reserved => "RS",
                BloodProductDispenseStatus.Wasted => "WA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given BloodProductProcessingRequirements enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(BloodProductProcessingRequirements input)
        {
            return input switch
            {
                BloodProductProcessingRequirements.AutologousUnit => "AU",
                BloodProductProcessingRequirements.CmvNegative => "CM",
                BloodProductProcessingRequirements.CmvSafe => "CS",
                BloodProductProcessingRequirements.DirectedUnit => "DI",
                BloodProductProcessingRequirements.FreshUnit => "FR",
                BloodProductProcessingRequirements.HemoglobinSNegative => "HB",
                BloodProductProcessingRequirements.HlaMatched => "HL",
                BloodProductProcessingRequirements.IgaDeficient => "IG",
                BloodProductProcessingRequirements.Irradiated => "IR",
                BloodProductProcessingRequirements.Leukoreduced => "LR",
                BloodProductProcessingRequirements.Washed => "WA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given BloodProductTransfusionDispositionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(BloodProductTransfusionDispositionStatus input)
        {
            return input switch
            {
                BloodProductTransfusionDispositionStatus.ReturnedUnused => "RA",
                BloodProductTransfusionDispositionStatus.ReturnedUnusedKeepLinkedToPatient => "RL",
                BloodProductTransfusionDispositionStatus.TransfusedWithAdverseReaction => "TR",
                BloodProductTransfusionDispositionStatus.Transfused => "TX",
                BloodProductTransfusionDispositionStatus.Wasted => "WA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given BodyParts enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(BodyParts input)
        {
            return input switch
            {
                BodyParts.Acetabulum => "ACET",
                BodyParts.Achilles => "ACHIL",
                BodyParts.Abdomen => "ADB",
                BodyParts.Adenoids => "ADE",
                BodyParts.Adrenal => "ADR",
                BodyParts.AmnioticFluid => "AMN",
                BodyParts.AmnioticSac => "AMS",
                BodyParts.Anal => "ANAL",
                BodyParts.Ankle => "ANKL",
                BodyParts.Antecubital => "ANTEC",
                BodyParts.AntecubitalFossa => "ANTECF",
                BodyParts.Antrum => "ANTR",
                BodyParts.Anus => "ANUS",
                BodyParts.Aorta => "AORTA",
                BodyParts.Appendix => "APDX",
                BodyParts.AorticRim => "AR",
                BodyParts.Areola => "AREO",
                BodyParts.Arm => "ARM",
                BodyParts.Artery => "ARTE",
                BodyParts.Ascites => "ASCIT",
                BodyParts.AsciticFluid => "ASCT",
                BodyParts.Atrium => "ATR",
                BodyParts.Auricular => "AURI",
                BodyParts.AorticValve => "AV",
                BodyParts.Axilla => "AXI",
                BodyParts.Back => "BACK",
                BodyParts.BartholinDuct => "BARTD",
                BodyParts.BartholinGland => "BARTG",
                BodyParts.BrainCystFluid => "BCYS",
                BodyParts.BodyWhole => "BDY",
                BodyParts.BileDuct => "BID",
                BodyParts.BileFluid => "BIFL",
                BodyParts.Bladder => "BLAD",
                BodyParts.BloodWhole => "BLD",
                BodyParts.BloodArterial => "BLDA",
                BodyParts.BloodCapillary => "BLDC",
                BodyParts.BloodVenous => "BLDV",
                BodyParts.Blood => "BLOOD",
                BodyParts.BoneMarrow => "BMAR",
                BodyParts.Bone => "BON",
                BodyParts.Bowel => "BOWEL",
                BodyParts.BowelLarge => "BOWLA",
                BodyParts.BowelSmall => "BOWSM",
                BodyParts.Basophils => "BPH",
                BodyParts.Brachial => "BRA",
                BodyParts.Brain => "BRAIN",
                BodyParts.Bronchial => "BRO",
                BodyParts.BronchioleBronchiolar => "BROCH",
                BodyParts.BronchusBronchial => "BRONC",
                BodyParts.Eyebrow => "BROW",
                BodyParts.Breast => "BRST",
                BodyParts.BreastFluid => "BRSTFL",
                BodyParts.BartholinGlandFluid => "BRTGF",
                BodyParts.Broviac => "BRV",
                BodyParts.Buccal => "BUCCA",
                BodyParts.Bursa => "BURSA",
                BodyParts.BursaFluid => "BURSF",
                BodyParts.Buttocks => "BUTT",
                BodyParts.Calf => "CALF",
                BodyParts.Canal => "CANAL",
                BodyParts.Canaliculis => "CANLI",
                BodyParts.Canthus => "CANTH",
                BodyParts.Carotid => "CARO",
                BodyParts.Carpal => "CARP",
                BodyParts.Cavity => "CAVIT",
                BodyParts.BloodCord => "CBLD",
                BodyParts.CardiacMuscle => "CDM",
                BodyParts.CommonDuct => "CDUCT",
                BodyParts.CecumCecal => "CECUM",
                BodyParts.CervixUterus => "CERVUT",
                BodyParts.CavityChest => "CHE",
                BodyParts.Cheek => "CHEEK",
                BodyParts.Chest => "CHES",
                BodyParts.ChestTube => "CHEST",
                BodyParts.Chin => "CHIN",
                BodyParts.CircumcisionSite => "CIRCU",
                BodyParts.ClavicleClavicular => "CLAVI",
                BodyParts.Clitoris => "CLIT",
                BodyParts.Clitoral => "CLITO",
                BodyParts.Cannula => "CNL",
                BodyParts.Coccygeal => "COCCG",
                BodyParts.Coccyx => "COCCY",
                BodyParts.Colon => "COLON",
                BodyParts.Colostomy => "COLOS",
                BodyParts.Conjunctiva => "CONJ",
                BodyParts.Cord => "COR",
                BodyParts.Coral => "CORAL",
                BodyParts.CordBlood => "CORD",
                BodyParts.Cornea => "CORN",
                BodyParts.ColostomyStoma => "COS",
                BodyParts.CraniumEthmoid => "CRANE",
                BodyParts.CraniumFrontal => "CRANF",
                BodyParts.CraniumOccipital => "CRANO",
                BodyParts.CraniumParietal => "CRANP",
                BodyParts.CraniumSphenoid => "CRANS",
                BodyParts.CraniumTemporal => "CRANT",
                BodyParts.CerebralSpinalFluid => "CSF",
                BodyParts.Cubitus => "CUBIT",
                BodyParts.Cuff => "CUFF",
                BodyParts.CulDeSac => "CULD",
                BodyParts.Culdocentesis => "CULDO",
                BodyParts.Cervix => "CVX",
                BodyParts.Deltoid => "DELT",
                BodyParts.DentalGingiva => "DEN",
                BodyParts.Dental => "DENTA",
                BodyParts.DialysisFluid => "DIAF",
                BodyParts.Digit => "DIGIT",
                BodyParts.Disc => "DISC",
                BodyParts.DorsumDorsal => "DORS",
                BodyParts.Diaphragm => "DPH",
                BodyParts.DuodenalFluid => "DUFL",
                BodyParts.DuodenumDuodenal => "DUODE",
                BodyParts.Dura => "DUR",
                BodyParts.Ear => "EAR",
                BodyParts.EarBoneIncus => "EARBI",
                BodyParts.EarBoneMalleus => "EARBM",
                BodyParts.EarBoneStapes => "EARBS",
                BodyParts.EarLobe => "EARLO",
                BodyParts.Endocervical => "EC",
                BodyParts.Elbow => "ELBOW",
                BodyParts.ElbowJoint => "ELBOWJ",
                BodyParts.Endocardium => "ENDC",
                BodyParts.Endometrium => "ENDM",
                BodyParts.Endolpthamitis => "EOLPH",
                BodyParts.Eosinophils => "EOS",
                BodyParts.Epididymis => "EPD",
                BodyParts.Epicardial => "EPICA",
                BodyParts.Epicardium => "EPICM",
                BodyParts.Epidural => "EPIDU",
                BodyParts.Epiglottis => "EPIGL",
                BodyParts.Esophagus => "ESO",
                BodyParts.Esophageal => "ESOPG",
                BodyParts.Endotracheal => "ET",
                BodyParts.Ethmoid => "ETHMO",
                BodyParts.Endourethral => "EUR",
                BodyParts.Eye => "EYE",
                BodyParts.Eyelid => "EYELI",
                BodyParts.Face => "FACE",
                BodyParts.FallopianTube => "FALLT",
                BodyParts.FacialBoneInferiorNasalConcha => "FBINC",
                BodyParts.FacialBoneLacrimal => "FBLAC",
                BodyParts.FacialBoneMaxilla => "FBMAX",
                BodyParts.FacialBoneNasal => "FBNAS",
                BodyParts.FacialBonePalatine => "FBPAL",
                BodyParts.FacialBoneVomer => "FBVOM",
                BodyParts.FacialBoneZygomatic => "FBZYG",
                BodyParts.Femoral => "FEMOR",
                BodyParts.Femur => "FEMUR",
                BodyParts.Fetus => "FET",
                BodyParts.Fibula => "FIBU",
                BodyParts.Finger => "FING",
                BodyParts.FingerNail => "FINGN",
                BodyParts.FemoralHead => "FMH",
                BodyParts.Follicle => "FOL",
                BodyParts.Foot => "FOOT",
                BodyParts.Forearm => "FOREA",
                BodyParts.Forehead => "FOREH",
                BodyParts.Foreskin => "FORES",
                BodyParts.Fourchette => "FOURC",
                BodyParts.GallBladder => "GB",
                BodyParts.Genital => "GEN",
                BodyParts.GenitalCervix => "GENC",
                BodyParts.GenitalLochia => "GENL",
                BodyParts.GenitalLesion => "GL",
                BodyParts.Gland => "GLAND",
                BodyParts.Glans => "GLANS",
                BodyParts.Gluteus => "GLUT",
                BodyParts.Gluteal => "GLUTE",
                BodyParts.GluteusMedius => "GLUTM",
                BodyParts.Groin => "GROIN",
                BodyParts.Gum => "GUM",
                BodyParts.GenitalVulva => "GVU",
                BodyParts.Hallux => "HAL",
                BodyParts.Hand => "HAND",
                BodyParts.Hair => "HAR",
                BodyParts.Heart => "HART",
                BodyParts.Head => "HEAD",
                BodyParts.Heel => "HEEL",
                BodyParts.Hemorrhoid => "HEM",
                BodyParts.Hip => "HIP",
                BodyParts.HipJoint => "HIPJ",
                BodyParts.Humerus => "HUMER",
                BodyParts.HeartValve => "HV",
                BodyParts.HeartValveBicuspid => "HVB",
                BodyParts.HeartValveTricuspid => "HVT",
                BodyParts.Hymen => "HYMEN",
                BodyParts.Intracervical => "ICX",
                BodyParts.IlealConduit => "ILC",
                BodyParts.IlicalConduit => "ILCON",
                BodyParts.IliacCrest => "ILCR",
                BodyParts.IlealLoop => "ILE",
                BodyParts.Ileostomy => "ILEOS",
                BodyParts.Ileum => "ILEUM",
                BodyParts.Iliac => "ILIAC",
                BodyParts.Intranasal => "INASA",
                BodyParts.Inguinal => "INGUI",
                BodyParts.IntestineLarge => "INSTL",
                BodyParts.IntestineSmall => "INSTS",
                BodyParts.Intestine => "INT",
                BodyParts.Introitus => "INTRO",
                BodyParts.Intrauterine => "INTRU",
                BodyParts.Ischium => "ISCHI",
                BodyParts.LoopIshial => "ISH",
                BodyParts.Jaw => "JAW",
                BodyParts.JugularExternal => "JUGE",
                BodyParts.JugularInternal => "JUGI",
                BodyParts.KidneyDeprecated => "KIDN",
                BodyParts.Knee => "KNEE",
                BodyParts.KneeFluid => "KNEEF",
                BodyParts.KneeJoint => "KNEEJ",
                BodyParts.Labia => "LABIA",
                BodyParts.LabiaMajora => "LABMA",
                BodyParts.LabiaMinora => "LABMI",
                BodyParts.Lacrimal => "LACRI",
                BodyParts.Lamella => "LAM",
                BodyParts.Larynx => "LARYN",
                BodyParts.Leg => "LEG",
                BodyParts.Lens => "LENS",
                BodyParts.Lingual => "LING",
                BodyParts.Lingula => "LINGU",
                BodyParts.Lip => "LIP",
                BodyParts.Liver => "LIVER",
                BodyParts.Lumen => "LMN",
                BodyParts.LymphNode => "LN",
                BodyParts.LymphNodeGroin => "LNG",
                BodyParts.Lobe => "LOBE",
                BodyParts.Lochia => "LOCH",
                BodyParts.Lumbar => "LUMBA",
                BodyParts.Lung => "LUNG",
                BodyParts.Lymphocytes => "LYM",
                BodyParts.Macrophages => "MAC",
                BodyParts.Malleolus => "MALLE",
                BodyParts.MandibleMandibular => "MANDI",
                BodyParts.Marrow => "MAR",
                BodyParts.Mastoid => "MAST",
                BodyParts.MaxillaMaxillary => "MAXIL",
                BodyParts.MaxillarySinus => "MAXS",
                BodyParts.Meatus => "MEATU",
                BodyParts.Meconium => "MEC",
                BodyParts.Mediastinum => "MEDST",
                BodyParts.Medullary => "MEDU",
                BodyParts.Metacarpal => "METAC",
                BodyParts.Metatarsal => "METAT",
                BodyParts.MilkBreast => "MILK",
                BodyParts.MitralValve => "MITRL",
                BodyParts.Molar => "MOLAR",
                BodyParts.MonsUreteris => "MONSU",
                BodyParts.MonsVenerisMonsPubis => "MONSV",
                BodyParts.Membrane => "MOU",
                BodyParts.Mouth => "MOUTH",
                BodyParts.MonsPubis => "MP",
                BodyParts.Meninges => "MPB",
                BodyParts.Mrsa => "MRSA2",
                BodyParts.Myocardium => "MYO",
                BodyParts.Nail => "NAIL",
                BodyParts.NailBed => "NAILB",
                BodyParts.NailFinger => "NAILF",
                BodyParts.NailToe => "NAILT",
                BodyParts.Nares => "NARES",
                BodyParts.Nasal => "NASL",
                BodyParts.Navel => "NAVEL",
                BodyParts.Neck => "NECK",
                BodyParts.Nerve => "NERVE",
                BodyParts.Nipple => "NIPPL",
                BodyParts.Nasolacrimal => "NLACR",
                BodyParts.NoseNasalPassage => "NOS",
                BodyParts.NoseNoseOutside => "NOSE",
                BodyParts.Nostril => "NOSTR",
                BodyParts.NasopharyngealNasopharynx => "NP",
                BodyParts.NasalSeptum => "NSS",
                BodyParts.Nasotracheal => "NTRAC",
                BodyParts.Occipital => "OCCIP",
                BodyParts.Olecranon => "OLECR",
                BodyParts.Omentum => "OMEN",
                BodyParts.OrbitOrbital => "ORBIT",
                BodyParts.Oropharynx => "ORO",
                BodyParts.OsCoxaPelvicGirdle => "OSCOX",
                BodyParts.Ovary => "OVARY",
                BodyParts.PancreaticFluid => "PAFL",
                BodyParts.Palate => "PALAT",
                BodyParts.Palm => "PALM",
                BodyParts.PerianalPerirectal => "PANAL",
                BodyParts.Pancreas => "PANCR",
                BodyParts.Paratracheal => "PARAT",
                BodyParts.Parietal => "PARIE",
                BodyParts.Paronychia => "PARON",
                BodyParts.ParotidParotidGland => "PAROT",
                BodyParts.Parasternal => "PAS",
                BodyParts.Patella => "PATEL",
                BodyParts.Pericardium => "PCARD",
                BodyParts.Periclitoral => "PCLIT",
                BodyParts.Pelvis => "PELV",
                BodyParts.Penis => "PENIS",
                BodyParts.PenileShaft => "PENSH",
                BodyParts.Peritoneal => "PER",
                BodyParts.PericardialFluid => "PERI",
                BodyParts.Perihepatic => "PERIH",
                BodyParts.PerinealAbscess => "PERIN",
                BodyParts.Perisplenic => "PERIS",
                BodyParts.Peritoneum => "PERIT",
                BodyParts.Periurethal => "PERIU",
                BodyParts.Perivesicular => "PERIV",
                BodyParts.Perirectal => "PERRA",
                BodyParts.PeritonealFluid => "PERT",
                BodyParts.Phalanyx => "PHALA",
                BodyParts.Pilonidal => "PILO",
                BodyParts.Pinna => "PINNA",
                BodyParts.PlacentaFetalSide => "PLACF",
                BodyParts.PlacentaMaternalSide => "PLACM",
                BodyParts.Plantar => "PLANT",
                BodyParts.PalateHard => "PLATH",
                BodyParts.PalateSoft => "PLATS",
                BodyParts.Placenta => "PLC",
                BodyParts.PleuralFluid => "PLEU",
                BodyParts.Pleura => "PLEUR",
                BodyParts.PleuralFluidThoracentesisFld => "PLR",
                BodyParts.Perineal => "PNEAL",
                BodyParts.Perinephric => "PNEPH",
                BodyParts.Perineum => "PNM",
                BodyParts.Popliteal => "POPLI",
                BodyParts.Periorbital => "PORBI",
                BodyParts.Preauricular => "PREAU",
                BodyParts.Prerenal => "PRERE",
                BodyParts.ProstaticFluid => "PROS",
                BodyParts.ProstateGland => "PRST",
                BodyParts.Peritonsillar => "PTONS",
                BodyParts.Pubic => "PUBIC",
                BodyParts.PulmonaryArtery => "PUL",
                BodyParts.Radial => "RADI",
                BodyParts.Radius => "RADIUS",
                BodyParts.RedBloodCells => "RBC",
                BodyParts.Rectal => "RECTL",
                BodyParts.Rectum => "RECTU",
                BodyParts.Renal => "RENL",
                BodyParts.Rib => "RIB",
                BodyParts.RenalPelvis => "RNP",
                BodyParts.Retroperitoneal => "RPERI",
                BodyParts.UterineCulDeSac => "SAC",
                BodyParts.Sacroiliac => "SACIL",
                BodyParts.Sacral => "SACRA",
                BodyParts.Sacrococcygeal => "SACRO",
                BodyParts.Sacrum => "SACRU",
                BodyParts.SalivaryGland => "SALGL",
                BodyParts.Scalp => "SCALP",
                BodyParts.ScapulaScapular => "SCAPU",
                BodyParts.SupraclavicleSupraclavicular => "SCLAV",
                BodyParts.Sclera => "SCLER",
                BodyParts.SubClavian => "SCLV",
                BodyParts.ScrotumScrotal => "SCROT",
                BodyParts.Subdiaphramatic => "SDP",
                BodyParts.SeminalFluid => "SEM",
                BodyParts.Semen => "SEMN",
                BodyParts.SeptumSeptal => "SEPTU",
                BodyParts.Seroma => "SEROM",
                BodyParts.SubgalealFluid => "SGF",
                BodyParts.Shin => "SHIN",
                BodyParts.Shoulder => "SHOL",
                BodyParts.SholderJoint => "SHOLJ",
                BodyParts.Sigmoid => "SIGMO",
                BodyParts.Sinus => "SINUS",
                BodyParts.SkenesGland => "SKENE",
                BodyParts.SkeletalMuscle => "SKM",
                BodyParts.Skull => "SKULL",
                BodyParts.Sole => "SOLE",
                BodyParts.SpinalCord => "SPCOR",
                BodyParts.Sphenoid => "SPHEN",
                BodyParts.Spleen => "SPLN",
                BodyParts.Spermatozoa => "SPRM",
                BodyParts.SupraCervical => "SPX",
                BodyParts.SternumSternal => "STER",
                BodyParts.Stoma => "STOM",
                BodyParts.Stomach => "STOMA",
                BodyParts.LiquidStool => "STOOLL",
                BodyParts.Stump => "STUMP",
                BodyParts.Subdural => "SUB",
                BodyParts.SubduralFluid => "SUBD",
                BodyParts.Submandibular => "SUBM",
                BodyParts.Submental => "SUBME",
                BodyParts.Subphrenic => "SUBPH",
                BodyParts.Submaxillary => "SUBX",
                BodyParts.SuprapubicSpecimen => "SUPB",
                BodyParts.Suprapubic => "SUPRA",
                BodyParts.Sweat => "SWT",
                BodyParts.SweatGland => "SWTG",
                BodyParts.SynovialFluid => "SYN",
                BodyParts.Synovial => "SYNOL",
                BodyParts.Synovium => "SYNOV",
                BodyParts.Tarsal => "TARS",
                BodyParts.Transbronchial => "TBRON",
                BodyParts.TranscarinaAsp => "TCN",
                BodyParts.TearDuct => "TDUCT",
                BodyParts.Tears => "TEAR",
                BodyParts.Temple => "TEMPL",
                BodyParts.Temporal => "TEMPO",
                BodyParts.TesticleTestis => "TESTI",
                BodyParts.Thigh => "THIGH",
                BodyParts.Thymus => "THM",
                BodyParts.ThoraxThoracicThoracentesis => "THORA",
                BodyParts.Throat => "THRB",
                BodyParts.Thumb => "THUMB",
                BodyParts.Thyroid => "THYRD",
                BodyParts.Tibia => "TIBIA",
                BodyParts.TemporalLobe => "TML",
                BodyParts.Thumbnail => "TNL",
                BodyParts.Toe => "TOE",
                BodyParts.ToeNail => "TOEN",
                BodyParts.Tongue => "TONG",
                BodyParts.Tonsil => "TONS",
                BodyParts.Tooth => "TOOTH",
                BodyParts.TracheaTracheal => "TRCHE",
                BodyParts.ToothSocket => "TSK",
                BodyParts.UlnaUlnar => "ULNA",
                BodyParts.UmbilicalBlood => "UMB",
                BodyParts.UmbilicusUmbilical => "UMBL",
                BodyParts.Ureter => "URET",
                BodyParts.Urethra => "URTH",
                BodyParts.StomaUrinary => "USTOM",
                BodyParts.Uterus => "UTER",
                BodyParts.Uterine => "UTERI",
                BodyParts.VaginaVaginal => "VAGIN",
                BodyParts.Valve => "VAL",
                BodyParts.VasDeferens => "VAS",
                BodyParts.VastusLateralis => "VASTL",
                BodyParts.Vault => "VAULT",
                BodyParts.VentricularCsf => "VCSF",
                BodyParts.VaginalCuff => "VCUFF",
                BodyParts.Vein => "VEIN",
                BodyParts.Ventragluteal => "VENTG",
                BodyParts.VermisCerebelli => "VERMI",
                BodyParts.VertebraCervical => "VERTC",
                BodyParts.VertebraLumbar => "VERTL",
                BodyParts.VertebraThoracic => "VERTT",
                BodyParts.Vesicular => "VESCL",
                BodyParts.VesicularFluid => "VESFLD",
                BodyParts.Vesicle => "VESI",
                BodyParts.VestibuleGenital => "VESTI",
                BodyParts.VaginalVault => "VGV",
                BodyParts.VitreousFluid => "VITR",
                BodyParts.VocalCord => "VOC",
                BodyParts.Vulva => "VULVA",
                BodyParts.Leukocytes => "WBC",
                BodyParts.Wrist => "WRIST",
                BodyParts.ExternalJugular => "Ã‚",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given BodySite enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(BodySite input)
        {
            return input switch
            {
                BodySite.BilateralEars => "BE",
                BodySite.BilateralNares => "BN",
                BodySite.Buttock => "BU",
                BodySite.ChestTube => "CT",
                BodySite.LeftArm => "LA",
                BodySite.LeftAnteriorChest => "LAC",
                BodySite.LeftAntecubitalFossa => "LACF",
                BodySite.LeftDeltoid => "LD",
                BodySite.LeftEar => "LE",
                BodySite.LeftExternalJugular => "LEJ",
                BodySite.LeftFoot => "LF",
                BodySite.LeftGluteusMedius => "LG",
                BodySite.LeftHand => "LH",
                BodySite.LeftInternalJugular => "LIJ",
                BodySite.LeftLowerAbdQuadrant => "LLAQ",
                BodySite.LeftLowerForearm => "LLFA",
                BodySite.LeftMidForearm => "LMFA",
                BodySite.LeftNaris => "LN",
                BodySite.LeftPosteriorChest => "LPC",
                BodySite.LeftSubclavian => "LSC",
                BodySite.LeftThigh => "LT",
                BodySite.LeftUpperArm => "LUA",
                BodySite.LeftUpperAbdQuadrant => "LUAQ",
                BodySite.LeftUpperForearm => "LUFA",
                BodySite.LeftVentragluteal => "LVG",
                BodySite.LeftVastusLateralis => "LVL",
                BodySite.Nebulized => "NB",
                BodySite.RightEye => "OD",
                BodySite.LeftEye => "OS",
                BodySite.BilateralEyes => "OU",
                BodySite.Perianal => "PA",
                BodySite.Perineal => "PERIN",
                BodySite.RightArm => "RA",
                BodySite.RightAnteriorChest => "RAC",
                BodySite.RightAntecubitalFossa => "RACF",
                BodySite.RightDeltoid => "RD",
                BodySite.RightEar => "RE",
                BodySite.RightExternalJugular => "REJ",
                BodySite.RightFoot => "RF",
                BodySite.RightGluteusMedius => "RG",
                BodySite.RightHand => "RH",
                BodySite.RightInternalJugular => "RIJ",
                BodySite.RtLowerAbdQuadrant => "RLAQ",
                BodySite.RightLowerForearm => "RLFA",
                BodySite.RightMidForearm => "RMFA",
                BodySite.RightNaris => "RN",
                BodySite.RightPosteriorChest => "RPC",
                BodySite.RightSubclavian => "RSC",
                BodySite.RightThigh => "RT",
                BodySite.RightUpperArm => "RUA",
                BodySite.RightUpperAbdQuadrant => "RUAQ",
                BodySite.RightUpperForearm => "RUFA",
                BodySite.RightVentragluteal => "RVG",
                BodySite.RightVastusLateralis => "RVL",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given BodySiteModifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(BodySiteModifier input)
        {
            return input switch
            {
                BodySiteModifier.Anterior => "ANT",
                BodySiteModifier.Bilateral => "BIL",
                BodySiteModifier.Distal => "DIS",
                BodySiteModifier.External => "EXT",
                BodySiteModifier.Left => "L",
                BodySiteModifier.Lateral => "LAT",
                BodySiteModifier.QuadrantLeftLower => "LLQ",
                BodySiteModifier.Lower => "LOW",
                BodySiteModifier.QuadrantLeftUpper => "LUQ",
                BodySiteModifier.Medial => "MED",
                BodySiteModifier.Posterior => "POS",
                BodySiteModifier.Proximal => "PRO",
                BodySiteModifier.Right => "R",
                BodySiteModifier.QuadrantRightLower => "RLQ",
                BodySiteModifier.QuadrantRightUpper => "RUQ",
                BodySiteModifier.Upper => "UPP",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given BpObservationStatusCodesInterpretation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(BpObservationStatusCodesInterpretation input)
        {
            return input switch
            {
                BpObservationStatusCodesInterpretation.RecordComingOverIsCorrection => "C",
                BpObservationStatusCodesInterpretation.DeletesTheBpxRecord => "D",
                BpObservationStatusCodesInterpretation.FinalStatus => "F",
                BpObservationStatusCodesInterpretation.OrderDetailDescriptionOnly => "O",
                BpObservationStatusCodesInterpretation.PreliminaryStatus => "P",
                BpObservationStatusCodesInterpretation.PostOriginalAsWrong => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CalendarAlignment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CalendarAlignment input)
        {
            return input switch
            {
                CalendarAlignment.DayOfTheMonth => "DM",
                CalendarAlignment.DayOfTheWeekBeginsWithMonday => "DW",
                CalendarAlignment.DayOfTheYear => "DY",
                CalendarAlignment.HourOfTheDay => "HD",
                CalendarAlignment.MonthOfTheYear => "MY",
                CalendarAlignment.MinuteOfTheHour => "NH",
                CalendarAlignment.SecondOfTheMinute => "SN",
                CalendarAlignment.WeekOfTheYear => "WY",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CaseCategoryCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CaseCategoryCode input)
        {
            return input switch
            {
                CaseCategoryCode.DoctorsOfficeClosed => "D",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CausalityObservations enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CausalityObservations input)
        {
            return input switch
            {
                CausalityObservations.AbatementOfEventAfterProductWithdrawn => "AW",
                CausalityObservations.EventRecurredAfterProductReintroduced => "BE",
                CausalityObservations.DoseResponseObserved => "DR",
                CausalityObservations.AlternativeExplanationForEventAvailable => "EX",
                CausalityObservations.EventOccurredAfterProductIntroduced => "IN",
                CausalityObservations.LiteratureReportsAssociationOfProductWithEvent => "LI",
                CausalityObservations.OccurrenceOfEventConfirmedByObjectiveEvidence => "OE",
                CausalityObservations.Other => "OT",
                CausalityObservations.EffectObservedWhenPatientReceivesPlacebo => "PL",
                CausalityObservations.SimilarEventsInPastForThisPatient => "SE",
                CausalityObservations.ToxicLevelsOfProductDocumented => "TC",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CclValue enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CclValue input)
        {
            return input switch
            {
                CclValue.NothingObvious => "0",
                CclValue.Low => "1",
                CclValue.Moderate => "2",
                CclValue.High => "3",
                CclValue.VeryHigh => "4",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CertificateStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CertificateStatus input)
        {
            return input switch
            {
                CertificateStatus.Expired => "E",
                CertificateStatus.Inactive => "I",
                CertificateStatus.Provisional => "P",
                CertificateStatus.Revoked => "R",
                CertificateStatus.ActiveValid => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CertificationPatientType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CertificationPatientType input)
        {
            return input switch
            {
                CertificationPatientType.Emergency => "ER",
                CertificationPatientType.InpatientElective => "IPE",
                CertificationPatientType.OutpatientElective => "OPE",
                CertificationPatientType.Urgent => "UR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CertificationStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CertificationStatus input)
        {
            return input switch
            {
                CertificationStatus.Certified => "C",
                CertificationStatus.Eligible => "E",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ChargeOnIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ChargeOnIndicator input)
        {
            return input switch
            {
                ChargeOnIndicator.ChargeOnOrder => "O",
                ChargeOnIndicator.ChargeOnResult => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ChargeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ChargeType input)
        {
            return input switch
            {
                ChargeType.Charge => "CH",
                ChargeType.Contract => "CO",
                ChargeType.Credit => "CR",
                ChargeType.Department => "DP",
                ChargeType.Grant => "GR",
                ChargeType.NoCharge => "NC",
                ChargeType.Professional => "PC",
                ChargeType.Research => "RS",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ChargeTypeReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ChargeTypeReason input)
        {
            return input switch
            {
                ChargeTypeReason.Allergy => "01",
                ChargeTypeReason.Intolerance => "02",
                ChargeTypeReason.TreatmentFailure => "03",
                ChargeTypeReason.PatientRequest => "04",
                ChargeTypeReason.NoException => "05",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CheckDigitScheme enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CheckDigitScheme input)
        {
            return input switch
            {
                CheckDigitScheme.BankCardValidationNumber => "BCV",
                CheckDigitScheme.Iso70641983 => "ISO",
                CheckDigitScheme.Mod10Algorithm => "M10",
                CheckDigitScheme.Mod11Algorithm => "M11",
                CheckDigitScheme.CheckDigitInTheNationalProviderIdentifier => "NPI",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CodingSystem enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CodingSystem input)
        {
            return input switch
            {
                CodingSystem.LocalGeneralCode99Zzz => "99zzz",
                CodingSystem.AmericanCollegeOfRadiologyFindingCodes => "ACR",
                CodingSystem.GermanAlphaIdV2006 => "ALPHAID2006",
                CodingSystem.GermanAlphaIdV2007 => "ALPHAID2007",
                CodingSystem.GermanAlphaIdV2008 => "ALPHAID2008",
                CodingSystem.GermanAlphaIdV2009 => "ALPHAID2009",
                CodingSystem.GermanAlphaIdV2010 => "ALPHAID2010",
                CodingSystem.GermanAlphaIdV2011 => "ALPHAID2011",
                CodingSystem.Hl7SetOfUnitsOfMeasure => "ANS+",
                CodingSystem.WhoAdverseReactionTerms => "ART",
                CodingSystem.AstmE1238E1467Universal => "AS4",
                CodingSystem.As4NeurophysiologyCodes => "AS4E",
                CodingSystem.AmericanTypeCultureCollection => "ATC",
                CodingSystem.Cpt4 => "C4",
                CodingSystem.CollegeOfAmericanPathologistsElectronicCancerChecklist => "CAPECC",
                CodingSystem.ChemicalAbstractCodes => "CAS",
                CodingSystem.ClinicalCareClassificationSystem => "CCC",
                CodingSystem.Cdt2Codes => "CD2",
                CodingSystem.CdcAnalyteCodes => "CDCA",
                CodingSystem.CdcEmergencyDepartmentAcuity => "CDCEDACUITY",
                CodingSystem.CdcMethodsInstrumentsCodes => "CDCM",
                CodingSystem.CdcBiosenseRtObservationsCensusCdc => "CDCOBS",
                CodingSystem.CdcPhinVocabularyCodingSystem => "CDCPHINVS",
                CodingSystem.RaceEthnicityCdc => "CDCREC",
                CodingSystem.CdcSurveillance => "CDS",
                CodingSystem.CenEcgDiagnosticCodes => "CE (obsolete)",
                CodingSystem.Clip => "CLP",
                CodingSystem.CptModifierCode => "CPTM",
                CodingSystem.Costart => "CST",
                CodingSystem.CdcVaccineCodes => "CVX",
                CodingSystem.DicomControlledTerminology => "DCM",
                CodingSystem.Euclides => "E",
                CodingSystem.EuclidesQuantityCodes => "E5",
                CodingSystem.EuclidesLabMethodCodes => "E6",
                CodingSystem.EuclidesLabEquipmentCodes => "E7",
                CodingSystem.EnzymeCodes => "ENZC",
                CodingSystem.EpaSrs => "EPASRS",
                CodingSystem.UniqueIngredientIdentifierUnii => "FDAUNII",
                CodingSystem.FirstDatabankDrugCodes => "FDDC",
                CodingSystem.FirstDatabankDiagnosticCodes => "FDDX",
                CodingSystem.FdaK10 => "FDK",
                CodingSystem.Fips52State => "FIPS5_2",
                CodingSystem.Fips64County => "FIPS6_4",
                CodingSystem.GDrgGermanDrgCodesV2004 => "GDRG2004",
                CodingSystem.GDrgGermanDrgCodesV2005 => "GDRG2005",
                CodingSystem.GDrgGermanDrgCodesV2006 => "GDRG2006",
                CodingSystem.GDrgGermanDrgCodesV2007 => "GDRG2007",
                CodingSystem.GDrgGermanDrgCodesV2008 => "GDRG2008",
                CodingSystem.GDrgGermanDrgCodesV2009 => "GDRG2009",
                CodingSystem.GermanMajorDiagnosticCodesV2004 => "GMDC2004",
                CodingSystem.GermanMajorDiagnosticCodesV2005 => "GMDC2005",
                CodingSystem.GermanMajorDiagnosticCodesV2006 => "GMDC2006",
                CodingSystem.GermanMajorDiagnosticCodesV2007 => "GMDC2007",
                CodingSystem.GermanMajorDiagnosticCodesV2008 => "GMDC2008",
                CodingSystem.GermanMajorDiagnosticCodesV2009 => "GMDC2009",
                CodingSystem.Hibcc => "HB",
                CodingSystem.CmsFormerlyHcfaCommonProcedureCodingSystem => "HCPCS",
                CodingSystem.HealthCareProviderTaxonomy => "HCPT",
                CodingSystem.HomeHealthCare => "HHC",
                CodingSystem.HealthOutcomes => "HI",
                CodingSystem.Hl7DefinedCodesWhereNnnnIsTheHl7TableNumber => "HL7nnnn",
                CodingSystem.JapaneseNationwideMedicineCode => "HOT",
                CodingSystem.CmsFormerlyHcfaProcedureCodesHcpcs => "HPC",
                CodingSystem.Icd10 => "I10",
                CodingSystem.Icd10Germany2004 => "I10G2004",
                CodingSystem.Icd10Germany2005 => "I10G2005",
                CodingSystem.Icd10Germany2006 => "I10G2006",
                CodingSystem.Icd10ProcedureCodes => "I10P",
                CodingSystem.Icd9 => "I9",
                CodingSystem.Icd9Cm => "I9C",
                CodingSystem.Icd9CmDiagnosisCodes => "I9CDX",
                CodingSystem.Icd9CmProcedureCodes => "I9CP",
                CodingSystem.Isbt => "IBT",
                CodingSystem.Isbt128Codes => "IBTnnnn",
                CodingSystem.Ichppc2 => "IC2",
                CodingSystem.Icd10AustralianModification => "ICD10AM",
                CodingSystem.Icd10Canada => "ICD10CA",
                CodingSystem.Icd10GermanyV2007 => "ICD10GM2007",
                CodingSystem.Icd10GermanyV2008 => "ICD10GM2008",
                CodingSystem.Icd10GermanyV2009 => "ICD10GM2009",
                CodingSystem.Icd10GermanyV2010 => "ICD10GM2010",
                CodingSystem.Icd10GermanyV2011 => "ICD10GM2011",
                CodingSystem.IcdForOncology => "ICDO",
                CodingSystem.IcdForOncologySecondEdition => "ICDO2",
                CodingSystem.IcdForOncologyThirdEdition => "ICDO3",
                CodingSystem.Iccs => "ICS",
                CodingSystem.Icsd => "ICSD",
                CodingSystem.Iso295583UnitsOfMeasure => "ISO",
                CodingSystem.Iso31661CountryCodes => "ISO3166_1",
                CodingSystem.Iso31662CountrySubdivisions => "ISO3166_2",
                CodingSystem.Iso4217CurrencyCodes => "ISO4217",
                CodingSystem.Iso639Language => "ISO639",
                CodingSystem.IsoDefinedCodes => "ISOnnnn (deprecated)",
                CodingSystem.IntegratedTaxonomicInformationSystem => "ITIS",
                CodingSystem.IupacIfccComponentCodes => "IUPC",
                CodingSystem.IupacIfccPropertyCodes => "IUPP",
                CodingSystem.JlacJslmNationwideLaboratoryCode => "JC10",
                CodingSystem.JapaneseChemistry => "JC8",
                CodingSystem.JapaneseImageExaminationCache => "JJ1017",
                CodingSystem.LocalGeneralCodeL => "L",
                CodingSystem.LocalBillingCode => "LB",
                CodingSystem.LogicalObservationIdentifierNamesAndCodesLoinc => "LN",
                CodingSystem.Medicaid => "MCD",
                CodingSystem.Medicare => "MCR",
                CodingSystem.MedicalDeviceCommunication => "MDC",
                CodingSystem.MedispanDiagnosticCodes => "MDDX",
                CodingSystem.MedicalEconomicsDrugCodes => "MEDC",
                CodingSystem.MedicalDictionaryForDrugRegulatoryAffairs => "MEDR",
                CodingSystem.MedicalEconomicsDiagnosticCodes => "MEDX",
                CodingSystem.MedispanGpi => "MGPI",
                CodingSystem.CdcVaccineManufacturerCodes => "MVX",
                CodingSystem.IndustryNaics => "NAICS",
                CodingSystem.NcpdpCodeListForDataElement => "NCPDPnnnnsss",
                CodingSystem.Nanda => "NDA",
                CodingSystem.NationalDrugCodes => "NDC",
                CodingSystem.NdfRtDrugClassification => "NDFRT",
                CodingSystem.NursingInterventionsClassification => "NIC",
                CodingSystem.SourceOfInformationImmunization => "NIP001",
                CodingSystem.SubstanceRefusalReason => "NIP002",
                CodingSystem.Vaccination => "NIP004",
                CodingSystem.VaccinatedAtLocationFacility => "NIP007",
                CodingSystem.VaccinePurchasedWithFunding => "NIP008",
                CodingSystem.ReportedAdverseEventPreviously => "NIP009",
                CodingSystem.VaersReportType => "NIP010",
                CodingSystem.NotifiableEventDiseaseConditionCodeList => "NND",
                CodingSystem.NationalProviderIdentifier => "NPI",
                CodingSystem.NationalUniformBillingCommittee => "NUBC",
                CodingSystem.NullFlavor => "NULLFL",
                CodingSystem.GermanProcedureCodes => "O301",
                CodingSystem.OpsGermanyV2004 => "O3012004",
                CodingSystem.OpsGermanyV2005 => "O3012005",
                CodingSystem.OpsGermanyV2006 => "O3012006",
                CodingSystem.OmahaSystem => "OHA",
                CodingSystem.OpsGermanyV2007 => "OPS2007",
                CodingSystem.OpsGermanyV2008 => "OPS2008",
                CodingSystem.OpsGermanyV2009 => "OPS2009",
                CodingSystem.OpsGermanyV2010 => "OPS2010",
                CodingSystem.OpsGermanyV2011 => "OPS2011",
                CodingSystem.CdcPublicHealthInformationNetworkQuestion => "PHINQUESTION",
                CodingSystem.CdcPhlipLabResultCodes => "PLR",
                CodingSystem.CdcPhlipLabTestCodes => "PLT",
                CodingSystem.PosCodes => "POS",
                CodingSystem.ReadClassification => "RC",
                CodingSystem.Rxnorm => "RXNORM",
                CodingSystem.SnomedClinicalTerms => "SCT",
                CodingSystem.SnomedClinicalTermsAlphanumericCodes => "SCT2",
                CodingSystem.SnomedDicomMicroglossary => "SDM",
                CodingSystem.IndustrySic => "SIC",
                CodingSystem.SystemizedNomenclatureOfMedicineSnomed => "SNM",
                CodingSystem.SnomedInternational => "SNM3",
                CodingSystem.SnomedTopologyCodesAnatomicSites => "SNT",
                CodingSystem.OccupationSoc2000 => "SOC",
                CodingSystem.PriorityTypeOfVisit => "UB04FL14",
                CodingSystem.PointOfOrigin => "UB04FL15",
                CodingSystem.PatientDischargeStatus => "UB04FL17",
                CodingSystem.OccurrenceCode => "UB04FL31",
                CodingSystem.OccurrenceSpan => "UB04FL35",
                CodingSystem.ValueCode => "UB04FL39",
                CodingSystem.Ucds => "UC",
                CodingSystem.UcumCodeSetForUnitsOfMeasureFromRegenstrief => "UCUM",
                CodingSystem.Mdns => "UMD",
                CodingSystem.UnifiedMedicalLanguage => "UML",
                CodingSystem.UniversalProductCode => "UPC",
                CodingSystem.Upin => "UPIN",
                CodingSystem.UnitedStatesPostalService => "USPS",
                CodingSystem.WhoRecordDrugCodes6Digit => "W1",
                CodingSystem.WhoRecordDrugCodes8Digit => "W2",
                CodingSystem.WhoRecordCodeWithAstmExtension => "W4",
                CodingSystem.WhoAtc => "WC",
                CodingSystem.AscX12CodeListNnnn => "X12Dennnn",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CommandResponse enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CommandResponse input)
        {
            return input switch
            {
                CommandResponse.CommandCannotBeCompletedBecauseOfError => "ER",
                CommandResponse.CommandCompletedSuccessfully => "OK",
                CommandResponse.CommandCannotBeCompletedBecauseOfEquipmentStatus => "ST",
                CommandResponse.CommandCannotBeCompletedWithinRequestedTime => "TI",
                CommandResponse.CommandCannotBeCompletedForUnknownReasons => "UN",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CommentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CommentType input)
        {
            return input switch
            {
                CommentType.PrimaryReason => "1R",
                CommentType.SecondaryReason => "2R",
                CommentType.AncillaryInstructions => "AI",
                CommentType.DuplicateInteractionReason => "DR",
                CommentType.GeneralInstructions => "GI",
                CommentType.GeneralReason => "GR",
                CommentType.PatientInstructions => "PI",
                CommentType.Remark => "RE",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CompletionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CompletionStatus input)
        {
            return input switch
            {
                CompletionStatus.Complete => "CP",
                CompletionStatus.NotAdministered => "NA",
                CompletionStatus.PartiallyAdministered => "PA",
                CompletionStatus.Refused => "RE",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ComputationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ComputationType input)
        {
            return input switch
            {
                ComputationType.IndicatesAPercentChange => "%",
                ComputationType.AbsoluteChange => "a",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ConditionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ConditionCode input)
        {
            return input switch
            {
                ConditionCode.NoSuggestedValuesDefined => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Confidentiality enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(Confidentiality input)
        {
            return input switch
            {
                Confidentiality.Business => "B",
                Confidentiality.Celebrity => "C",
                Confidentiality.ClinicianOnly => "D",
                Confidentiality.SubstanceAbuseRelated => "ETH",
                Confidentiality.HivRelated => "HIV",
                Confidentiality.Individual => "I",
                Confidentiality.Low => "L",
                Confidentiality.Normal => "N",
                Confidentiality.PsychiatryRelated => "PSY",
                Confidentiality.Restricted => "R",
                Confidentiality.Sensitive => "S",
                Confidentiality.SexualAndDomesticViolence => "SDV",
                Confidentiality.Taboo => "T",
                Confidentiality.VeryRestricted => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ConfidentialityCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ConfidentialityCode input)
        {
            return input switch
            {
                ConfidentialityCode.AidsPatient => "AID",
                ConfidentialityCode.Employee => "EMP",
                ConfidentialityCode.AlcoholDrugTreatmentPatient => "ETH",
                ConfidentialityCode.HivPatient => "HIV",
                ConfidentialityCode.PsychiatricPatient => "PSY",
                ConfidentialityCode.Restricted => "R",
                ConfidentialityCode.UsualControl => "U",
                ConfidentialityCode.UnwedMother => "UWM",
                ConfidentialityCode.VeryRestricted => "V",
                ConfidentialityCode.VeryImportantPersonOrCelebrity => "VIP",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ConsentBypassReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ConsentBypassReason input)
        {
            return input switch
            {
                ConsentBypassReason.Emergency => "E",
                ConsentBypassReason.ProfessionalJudgment => "PJ",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ConsentDisclosureLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ConsentDisclosureLevel input)
        {
            return input switch
            {
                ConsentDisclosureLevel.FullDisclosure => "F",
                ConsentDisclosureLevel.NoDisclosure => "N",
                ConsentDisclosureLevel.PartialDisclosure => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ConsentMode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ConsentMode input)
        {
            return input switch
            {
                ConsentMode.Telephone => "T",
                ConsentMode.Verbal => "V",
                ConsentMode.Written => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ConsentNonDisclosureReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ConsentNonDisclosureReason input)
        {
            return input switch
            {
                ConsentNonDisclosureReason.Emergency => "E",
                ConsentNonDisclosureReason.PatientRequest => "PR",
                ConsentNonDisclosureReason.RxPrivate => "RX",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ConsentStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ConsentStatus input)
        {
            return input switch
            {
                ConsentStatus.Active => "A",
                ConsentStatus.Bypassed => "B",
                ConsentStatus.Limited => "L",
                ConsentStatus.Pending => "P",
                ConsentStatus.Refused => "R",
                ConsentStatus.Rescinded => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ConsentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ConsentType input)
        {
            return input switch
            {
                ConsentType.ReleaseOfInfoToDisclosePhi => "001",
                ConsentType.MedicalProcedureInvasive => "002",
                ConsentType.AcknowledgeReceiptOfPrivacyNotice => "003",
                ConsentType.Abortion => "004",
                ConsentType.AbortionLaminaria => "005",
                ConsentType.AccutaneInformation => "006",
                ConsentType.AccutaneWoman => "007",
                ConsentType.AdvancedBeneficiaryNotice => "008",
                ConsentType.AfpAlphaFetoproteinScreening => "009",
                ConsentType.AmniocentesisConsentRefusal => "010",
                ConsentType.AnatomicalGiftOrganDonation => "011",
                ConsentType.AnesthesiaComplications => "012",
                ConsentType.AnesthesiaQuestionnaire => "013",
                ConsentType.Angiogram => "014",
                ConsentType.Angioplasty => "015",
                ConsentType.AnticancerDrugs => "016",
                ConsentType.AntipsychoticMedications => "017",
                ConsentType.Arthrogram => "018",
                ConsentType.Autopsy => "019",
                ConsentType.AztTherapy => "020",
                ConsentType.BiliaryDrainage => "021",
                ConsentType.BiliaryStoneExtraction => "022",
                ConsentType.Biopsy => "023",
                ConsentType.BleedingTimeTest => "024",
                ConsentType.Bronchogram => "025",
                ConsentType.CardiacCatheterization => "026",
                ConsentType.CoronaryAngiography => "027",
                ConsentType.CoronaryAngiographyWOSurgeryCapability => "028",
                ConsentType.CataractOpImplantOfFdaAprvdLens => "029",
                ConsentType.CataractOpImplantOfInvestigationalLens => "030",
                ConsentType.CataractSurgery => "031",
                ConsentType.CholeraImmunization => "032",
                ConsentType.CholesterolScreening => "033",
                ConsentType.CircumcisionNewborn => "034",
                ConsentType.Colonoscopy => "035",
                ConsentType.ContactLenses => "036",
                ConsentType.CtScanCervicalLumbar => "037",
                ConsentType.CtScanWIvContrastMediaIntoVein => "038",
                ConsentType.CvsChorionicVillusSampling => "039",
                ConsentType.Cystospy => "040",
                ConsentType.DisclosureOfPhiToFamilyFriends => "041",
                ConsentType.DCAndConization => "042",
                ConsentType.Dacryocystogram => "043",
                ConsentType.DiagnosticIsotope => "044",
                ConsentType.DrainageOfAnAbscess => "045",
                ConsentType.DrugScreening => "046",
                ConsentType.ElectronicMonitoringOfLaborRefusal => "047",
                ConsentType.EndometrialBiopsy => "048",
                ConsentType.EndoscopySclerosisOfEsophagealVarices => "049",
                ConsentType.Ercp => "050",
                ConsentType.ExposureToReportableCommunicableDisease => "051",
                ConsentType.ExternalVersion => "052",
                ConsentType.FluoresceinAngioscopy => "053",
                ConsentType.HepatitisBConsentDeclination => "054",
                ConsentType.Herniogram => "055",
                ConsentType.HivTestConsentRefusal => "056",
                ConsentType.HivTestDisclosure => "057",
                ConsentType.HivTestPrenatal => "058",
                ConsentType.HomeIvTreatmentProgram => "059",
                ConsentType.HomeParenteralTreatmentProgram => "060",
                ConsentType.Hysterectomy => "061",
                ConsentType.Hysterosalpingogram => "062",
                ConsentType.InjectionSlipConsent => "063",
                ConsentType.IntrauterineDevice => "064",
                ConsentType.IntrauterineDeviceSterilization => "065",
                ConsentType.IntravascularInfusionOfStreptokinaseUrokinase => "066",
                ConsentType.IntravenousCholangiogram => "067",
                ConsentType.IntravenousDigitalAngiography => "068",
                ConsentType.IodineAdministration => "069",
                ConsentType.Isg => "070",
                ConsentType.Ivp => "071",
                ConsentType.LaserPhotocoagulation => "072",
                ConsentType.LaserTreatment => "073",
                ConsentType.LithiumCarbonate => "074",
                ConsentType.LiverBiopsy => "075",
                ConsentType.LumbarPuncture => "076",
                ConsentType.Lymphangiogram => "077",
                ConsentType.MaoInhibitors => "078",
                ConsentType.MedPsychAndOrDrugAlcohol => "079",
                ConsentType.MedicalTreatmentRefusal => "080",
                ConsentType.MorningAfterPill => "081",
                ConsentType.MriAdult => "082",
                ConsentType.MriPediatric => "083",
                ConsentType.Myelogram => "084",
                ConsentType.NeedleBiopsy => "085",
                ConsentType.NeedleBiopsyOfLung => "086",
                ConsentType.NewbornTreatmentAndRelease => "087",
                ConsentType.NorplantSubdermalBirthControlImplant => "088",
                ConsentType.OperationsAnesthesiaTransfusions => "089",
                ConsentType.OralContraceptives => "090",
                ConsentType.OrganDonation => "091",
                ConsentType.PatientPermitsConsents => "092",
                ConsentType.PatientTreatmentPermitReleaseAdmission => "093",
                ConsentType.PenileInjections => "094",
                ConsentType.PercutaneousNephrostomy => "095",
                ConsentType.PercutaneousTranshepaticCholangiogram => "096",
                ConsentType.Photographs => "097",
                ConsentType.PhotographsEmployee => "098",
                ConsentType.PhotographsMedicalResearch => "099",
                ConsentType.PhotographsNewsMedia => "100",
                ConsentType.PsychiatricAdmissionNextOfKin => "101",
                ConsentType.PsychiatricInformationDuringHospitalStay => "102",
                ConsentType.PublicReleaseOfInformation => "103",
                ConsentType.RadiologicProcedure => "104",
                ConsentType.RefusalOfTreatment => "105",
                ConsentType.ReleaseOfBody => "106",
                ConsentType.ReleaseOfLimb => "107",
                ConsentType.RhImmuneGlobulin => "108",
                ConsentType.RightsOfMedicalResearchParticipants => "109",
                ConsentType.RequestToRestrictAccessToPhi => "110",
                ConsentType.RequestForRemainAnonymous => "111",
                ConsentType.SeatBeltExemption => "112",
                ConsentType.Sialogram => "113",
                ConsentType.VoidingCystogram => "1137",
                ConsentType.Sigmoidoscopy => "114",
                ConsentType.SterilizationAnesthesiaMedicalServices => "115",
                ConsentType.SterilizationFederallyFunded => "116",
                ConsentType.SterilizationFemale => "117",
                ConsentType.SterilizationLaparoscopyPomeroy => "118",
                ConsentType.SterilizationNonFederallyFunded => "119",
                ConsentType.SterilizationSecondary => "120",
                ConsentType.Tranquilizers => "121",
                ConsentType.TransferAcknowledgement => "122",
                ConsentType.TransferAuthorization => "123",
                ConsentType.TransferCertificationPhysician => "124",
                ConsentType.TransferDischargeRequest => "125",
                ConsentType.TransferForNonMedicalReasons => "126",
                ConsentType.TransferInterfacultyNeonatal => "127",
                ConsentType.TransferRefusal => "128",
                ConsentType.TransferRefusalOfFurtherTreatment => "129",
                ConsentType.TreadmillEkg => "130",
                ConsentType.TreadmillThallium201 => "131",
                ConsentType.Typhoid => "132",
                ConsentType.UseOfInvestigationalDevice => "133",
                ConsentType.UseOfInvestigationalDrug => "134",
                ConsentType.Venogram => "135",
                ConsentType.Videotape => "136",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ContactRole enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ContactRole input)
        {
            return input switch
            {
                ContactRole.EmergencyContact => "C",
                ContactRole.Employer => "E",
                ContactRole.FederalAgency => "F",
                ContactRole.InsuranceCompany => "I",
                ContactRole.NextOfKin => "N",
                ContactRole.Other => "O",
                ContactRole.StateAgency => "S",
                ContactRole.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ContainerCondition enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ContainerCondition input)
        {
            return input switch
            {
                ContainerCondition.ContainerCracked => "CC",
                ContainerCondition.ContainerLeaking => "CL",
                ContainerCondition.ContainerTorn => "CT",
                ContainerCondition.SealBroken => "SB",
                ContainerCondition.NotAmbientTemperature => "XAMB",
                ContainerCondition.NotBodyTemperature => "XC37",
                ContainerCondition.NotCriticalAmbientTemperature => "XCAMB",
                ContainerCondition.ExposedToAir => "XCATM",
                ContainerCondition.NotCriticalFrozenTemperature => "XCFRZ",
                ContainerCondition.NotCriticalRefrigeratedTemperature => "XCREF",
                ContainerCondition.NotDeepFrozen => "XDFRZ",
                ContainerCondition.NotDry => "XDRY",
                ContainerCondition.NotFrozenTemperature => "XFRZ",
                ContainerCondition.MetalExposed => "XMTLF",
                ContainerCondition.NotLiquidNitrogen => "XNTR",
                ContainerCondition.NotProtectedFromLight => "XPRTL",
                ContainerCondition.Shaken => "XPSA",
                ContainerCondition.ExposedToShock => "XPSO",
                ContainerCondition.NotRefrigeratedTemperature => "XREF",
                ContainerCondition.NotUltraFrozen => "XUFRZ",
                ContainerCondition.NotUpright => "XUPR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ContainerStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ContainerStatus input)
        {
            return input switch
            {
                ContainerStatus.Identified => "I",
                ContainerStatus.LeftEquipment => "L",
                ContainerStatus.Missing => "M",
                ContainerStatus.InProcess => "O",
                ContainerStatus.InPosition => "P",
                ContainerStatus.ProcessCompleted => "R",
                ContainerStatus.Unknown => "U",
                ContainerStatus.ContainerUnavailable => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ContinuationStyleCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ContinuationStyleCode input)
        {
            return input switch
            {
                ContinuationStyleCode.Fragmentation => "F",
                ContinuationStyleCode.InteractiveContinuation => "I",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ControlledSubstanceSchedule enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ControlledSubstanceSchedule input)
        {
            return input switch
            {
                ControlledSubstanceSchedule.ScheduleI => "I",
                ControlledSubstanceSchedule.ScheduleIi => "II",
                ControlledSubstanceSchedule.ScheduleIii => "III",
                ControlledSubstanceSchedule.ScheduleIv => "IV",
                ControlledSubstanceSchedule.ScheduleV => "V",
                ControlledSubstanceSchedule.ScheduleVi => "VI",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CoordinationOfBenefits enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CoordinationOfBenefits input)
        {
            return input switch
            {
                CoordinationOfBenefits.Coordination => "CO",
                CoordinationOfBenefits.Independent => "IN",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CoverageType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CoverageType input)
        {
            return input switch
            {
                CoverageType.BothHospitalAndPhysician => "B",
                CoverageType.HospitalInstitutional => "H",
                CoverageType.PhysicianProfessional => "P",
                CoverageType.Pharmacy => "RX",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CpRangeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CpRangeType input)
        {
            return input switch
            {
                CpRangeType.FlatRate => "F",
                CpRangeType.ProRate => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CycleType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CycleType input)
        {
            return input switch
            {
                CycleType.SecondRinse => "2RS",
                CycleType.AnesthesiaRespiratory => "ANR",
                CycleType.Bedpans => "BDP",
                CycleType.BowieDickTest => "BWD",
                CycleType.ChemicalWash => "CMW",
                CycleType.Code => "COD",
                CycleType.CartWash => "CRT",
                CycleType.Decontamination => "DEC",
                CycleType.Dart => "DRT",
                CycleType.DartWarmUpCycle => "DRW",
                CycleType.EoHighTemperature => "EOH",
                CycleType.EoLowTemperature => "EOL",
                CycleType.Express => "EXP",
                CycleType.Flash => "FLS",
                CycleType.Glassware => "GLS",
                CycleType.GenPurpose => "GNP",
                CycleType.Gravity => "GRV",
                CycleType.Gentle => "GTL",
                CycleType.Isothermal => "ISO",
                CycleType.InstrumentWash => "IST",
                CycleType.LeakTest => "LKT",
                CycleType.Liquid => "LQD",
                CycleType.OptionalWash => "OPW",
                CycleType.PeraceticAcid => "PEA",
                CycleType.PlasticGoodsWash => "PLA",
                CycleType.Prevac => "PRV",
                CycleType.Rinse => "RNS",
                CycleType.SteamFlushPressurePulse => "SFP",
                CycleType.Thermal => "THR",
                CycleType.TrayBasin => "TRB",
                CycleType.UtensilWash => "UTL",
                CycleType.WrapSteamFlushPressurePulse => "WFP",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given CyclicEntryExitIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CyclicEntryExitIndicator input)
        {
            return input switch
            {
                CyclicEntryExitIndicator.TheLastServiceRequestInCyclicGroup => "#",
                CyclicEntryExitIndicator.TheFirstServiceRequestInCyclicGroup => "*",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DataTypes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DataTypes input)
        {
            return input switch
            {
                DataTypes.Address => "AD",
                DataTypes.AuthorizationInformation => "AUI",
                DataTypes.ChargeCodeAndDate => "CCD",
                DataTypes.ChannelCalibrationParameters => "CCP",
                DataTypes.ChannelDefinition => "CD",
                DataTypes.CodedElement => "CE",
                DataTypes.CodedElementWithFormattedValues => "CF",
                DataTypes.CompositeIdWithCheckDigit => "CK",
                DataTypes.Composite => "CM",
                DataTypes.CompositeIdNumberAndName => "CN",
                DataTypes.CodedWithNoExceptions => "CNE",
                DataTypes.CompositeIdNumberAndNameSimplified => "CNN",
                DataTypes.CompositePrice => "CP",
                DataTypes.CompositeQuantityWithUnits => "CQ",
                DataTypes.ChannelSensitivityAndUnits => "CSU",
                DataTypes.CodedWithExceptions => "CWE",
                DataTypes.ExtendedCompositeIdWithCheckDigit => "CX",
                DataTypes.DailyDeductibleInformation => "DDI",
                DataTypes.DateAndInstitutionName => "DIN",
                DataTypes.DischargeToLocationAndDate => "DLD",
                DataTypes.DriversLicenseNumber => "DLN",
                DataTypes.Delta => "DLT",
                DataTypes.DateTimeRange => "DR",
                DataTypes.Date => "DT",
                DataTypes.DateTime => "DTM",
                DataTypes.DayTypeAndNumber => "DTN",
                DataTypes.EncapsulatedData => "ED",
                DataTypes.EntityIdentifier => "EI",
                DataTypes.EntityIdentifierPair => "EIP",
                DataTypes.ErrorLocationAndDescription => "ELD",
                DataTypes.ErrorLocation => "ERL",
                DataTypes.FinancialClass => "FC",
                DataTypes.FamilyName => "FN",
                DataTypes.FormattedText => "FT",
                DataTypes.GeneralTimingSpecification => "GTS",
                DataTypes.HierarchicDesignator => "HD",
                DataTypes.InsuranceCertificationDefinition => "ICD",
                DataTypes.CodedValuesForHl7Tables => "ID",
                DataTypes.CodedValueForUserDefinedTables => "IS",
                DataTypes.JobCodeClass => "JCC",
                DataTypes.LocationWithAddressVariation1 => "LA1",
                DataTypes.LocationWithAddressVariation2 => "LA2",
                DataTypes.MultiplexedArray => "MA",
                DataTypes.Money => "MO",
                DataTypes.MoneyAndChargeCode => "MOC",
                DataTypes.MoneyOrPercentage => "MOP",
                DataTypes.MessageType => "MSG",
                DataTypes.NumericArray => "NA",
                DataTypes.NameWithDateAndLocation => "NDL",
                DataTypes.Numeric => "NM",
                DataTypes.NumericRange => "NR",
                DataTypes.OccurrenceCodeAndDate => "OCD",
                DataTypes.OrderSequenceDefinition => "OSD",
                DataTypes.OccurrenceSpanCodeAndDate => "OSP",
                DataTypes.PractitionerInstitutionalPrivileges => "PIP",
                DataTypes.PersonLocation => "PL",
                DataTypes.PractitionerLicenseOrOtherIdNumber => "PLN",
                DataTypes.PersonName => "PN",
                DataTypes.PerformingPersonTimeStamp => "PPN",
                DataTypes.ParentResultLink => "PRL",
                DataTypes.ProcessingType => "PT",
                DataTypes.PolicyTypeAndAmount => "PTA",
                DataTypes.QueryInputParameterList => "QIP",
                DataTypes.QuerySelectionCriteria => "QSC",
                DataTypes.RowColumnDefinition => "RCD",
                DataTypes.ReferenceRange => "RFR",
                DataTypes.RepeatInterval => "RI",
                DataTypes.RoomCoverage => "RMC",
                DataTypes.ReferencePointer => "RP",
                DataTypes.RepeatPattern => "RPT",
                DataTypes.StreetAddress => "SAD",
                DataTypes.SchedulingClassValuePair => "SCV",
                DataTypes.SequenceId => "SI",
                DataTypes.StructuredNumeric => "SN",
                DataTypes.StringOfTelephoneNumberDigits => "SNM",
                DataTypes.SpecialtyDescription => "SPD",
                DataTypes.SpecimenSource => "SPS",
                DataTypes.SortOrder => "SRT",
                DataTypes.StringData => "ST",
                DataTypes.Time => "TM",
                DataTypes.TelephoneNumber => "TN",
                DataTypes.TimingQuantity => "TQ",
                DataTypes.TimeStamp => "TS",
                DataTypes.TextData => "TX",
                DataTypes.UbValueCodeAndAmount => "UVC",
                DataTypes.VisitingHours => "VH",
                DataTypes.VersionIdentifier => "VID",
                DataTypes.ValueRange => "VR",
                DataTypes.ChannelIdentifier => "WVI",
                DataTypes.WaveformSource => "WVS",
                DataTypes.ExtendedAddress => "XAD",
                DataTypes.ExtendedCompositeIdNumberAndNameForPersons => "XCN",
                DataTypes.ExtendedCompositeNameAndIdNumberForOrganizations => "XON",
                DataTypes.ExtendedPersonName => "XPN",
                DataTypes.ExtendedTelecommunicationsNumber => "XTN",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DateFormat enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DateFormat input)
        {
            return input switch
            {
                DateFormat.MmDdYyWithSlashes => "1",
                DateFormat.YyMmDdWithPeriods => "2",
                DateFormat.DdMmYyWithSlashes => "3",
                DateFormat.DdMmYyWithPeriods => "4",
                DateFormat.YyMmDdWithSlashes => "5",
                DateFormat.Yymmdd => "6",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DaysOfTheWeek enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DaysOfTheWeek input)
        {
            return input switch
            {
                DaysOfTheWeek.Friday => "FRI",
                DaysOfTheWeek.Monday => "MON",
                DaysOfTheWeek.Saturday => "SAT",
                DaysOfTheWeek.Sunday => "SUN",
                DaysOfTheWeek.Thursday => "THU",
                DaysOfTheWeek.Tuesday => "TUE",
                DaysOfTheWeek.Wednesday => "WED",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DayType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DayType input)
        {
            return input switch
            {
                DayType.Approved => "AP",
                DayType.Denied => "DE",
                DayType.Pending => "PE",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DegreeLicenseCertificate enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DegreeLicenseCertificate input)
        {
            return input switch
            {
                DegreeLicenseCertificate.AssociateOfArts => "AA",
                DegreeLicenseCertificate.AssociateOfAppliedScience => "AAS",
                DegreeLicenseCertificate.AssociateOfBusinessAdministration => "ABA",
                DegreeLicenseCertificate.AssociateOfEngineering => "AE",
                DegreeLicenseCertificate.AssociateOfScience => "AS",
                DegreeLicenseCertificate.BachelorOfArts => "BA",
                DegreeLicenseCertificate.BachelorOfBusinessAdministration => "BBA",
                DegreeLicenseCertificate.BachelorOrEngineering => "BE",
                DegreeLicenseCertificate.BachelorOfFineArts => "BFA",
                DegreeLicenseCertificate.BachelorOfNursing => "BN",
                DegreeLicenseCertificate.BachelorOfScience => "BS",
                DegreeLicenseCertificate.BachelorOfScienceLaw => "BSL",
                DegreeLicenseCertificate.BachelorOnScienceNursing => "BSN",
                DegreeLicenseCertificate.BachelorOfTheology => "BT",
                DegreeLicenseCertificate.CertifiedAdultNursePractitioner => "CANP",
                DegreeLicenseCertificate.Certificate => "CER",
                DegreeLicenseCertificate.CertifiedMedicalAssistant => "CMA",
                DegreeLicenseCertificate.CertifiedNurseMidwife => "CNM",
                DegreeLicenseCertificate.CertifiedNursePractitioner => "CNP",
                DegreeLicenseCertificate.CertifiedNurseSpecialist => "CNS",
                DegreeLicenseCertificate.CertifiedPediatricNursePractitioner => "CPNP",
                DegreeLicenseCertificate.CertifiedRegisteredNurse => "CRN",
                DegreeLicenseCertificate.DoctorOfBusinessAdministration => "DBA",
                DegreeLicenseCertificate.DoctorOfEducation => "DED",
                DegreeLicenseCertificate.Diploma => "DIP",
                DegreeLicenseCertificate.DoctorOfOsteopathy => "DO",
                DegreeLicenseCertificate.EmergencyMedicalTechnician => "EMT",
                DegreeLicenseCertificate.EmergencyMedicalTechnicianParamedic => "EMTP",
                DegreeLicenseCertificate.FamilyPracticeNursePractitioner => "FPNP",
                DegreeLicenseCertificate.HighSchoolGraduate => "HS",
                DegreeLicenseCertificate.JurisDoctor => "JD",
                DegreeLicenseCertificate.MasterOfArts => "MA",
                DegreeLicenseCertificate.MasterOfBusinessAdministration => "MBA",
                DegreeLicenseCertificate.MasterOfCivilEngineering => "MCE",
                DegreeLicenseCertificate.DoctorOfMedicine => "MD",
                DegreeLicenseCertificate.MedicalAssistant => "MDA",
                DegreeLicenseCertificate.MasterOfDivinity => "MDI",
                DegreeLicenseCertificate.MasterOfEngineering => "ME",
                DegreeLicenseCertificate.MasterOfEducation => "MED",
                DegreeLicenseCertificate.MasterOfElectricalEngineering => "MEE",
                DegreeLicenseCertificate.MasterOfFineArts => "MFA",
                DegreeLicenseCertificate.MasterOfMechanicalEngineering => "MME",
                DegreeLicenseCertificate.MasterOfScience => "MS",
                DegreeLicenseCertificate.MasterOfScienceLaw => "MSL",
                DegreeLicenseCertificate.MasterOfScienceNursing => "MSN",
                DegreeLicenseCertificate.MedicalTechnician => "MT",
                DegreeLicenseCertificate.MasterOfTheology => "MTH",
                DegreeLicenseCertificate.NonGraduate => "NG",
                DegreeLicenseCertificate.NursePractitioner => "NP",
                DegreeLicenseCertificate.PhysicianAssistant => "PA",
                DegreeLicenseCertificate.DoctorOfPhilosophy => "PHD",
                DegreeLicenseCertificate.DoctorOfEngineering => "PHE",
                DegreeLicenseCertificate.DoctorOfScience => "PHS",
                DegreeLicenseCertificate.AdvancedPracticeNurse => "PN",
                DegreeLicenseCertificate.DoctorOfPharmacy => "PharmD",
                DegreeLicenseCertificate.RegisteredMedicalAssistant => "RMA",
                DegreeLicenseCertificate.RegisteredNurse => "RN",
                DegreeLicenseCertificate.RegisteredPharmacist => "RPH",
                DegreeLicenseCertificate.SecretarialCertificate => "SEC",
                DegreeLicenseCertificate.TradeSchoolGraduate => "TS",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DenialOrRejectionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DenialOrRejectionCode input)
        {
            return input switch
            {
                DenialOrRejectionCode.LineItemNotDeniedOrRejected => "0",
                DenialOrRejectionCode.LineItemDeniedOrRejected => "1",
                DenialOrRejectionCode.LineItemIsOnAMultipleDayClaim => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DerivedSpecimen enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DerivedSpecimen input)
        {
            return input switch
            {
                DerivedSpecimen.ChildObservation => "C",
                DerivedSpecimen.NotApplicable => "N",
                DerivedSpecimen.ParentObservation => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DeviceDataState enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DeviceDataState input)
        {
            return input switch
            {
                DeviceDataState.RealTimeValues => "0",
                DeviceDataState.HistoricValues => "1",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DeviceStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DeviceStatus input)
        {
            return input switch
            {
                DeviceStatus.Ready => "0",
                DeviceStatus.NotReady => "1",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DeviceType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DeviceType input)
        {
            return input switch
            {
                DeviceType.EoGasSterilizer => "1",
                DeviceType.SteamSterilizer => "2",
                DeviceType.PeraceticAcid => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DiagnosisClassification enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DiagnosisClassification input)
        {
            return input switch
            {
                DiagnosisClassification.Consultation => "C",
                DiagnosisClassification.Diagnosis => "D",
                DiagnosisClassification.InvasiveProcedureNotClassified => "I",
                DiagnosisClassification.MedicationAntibiotic => "M",
                DiagnosisClassification.Other => "O",
                DiagnosisClassification.RadiologicalScheduling => "R",
                DiagnosisClassification.SignAndSymptom => "S",
                DiagnosisClassification.TissueDiagnosis => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DiagnosisPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DiagnosisPriority input)
        {
            return input switch
            {
                DiagnosisPriority.NoSuggestedValuesDefined => "...",
                DiagnosisPriority.NotIncludedInDiagnosisRanking => "0",
                DiagnosisPriority.ThePrimaryDiagnosis => "1",
                DiagnosisPriority.ForSecondaryDiagnosis => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DiagnosisType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DiagnosisType input)
        {
            return input switch
            {
                DiagnosisType.Admitting => "A",
                DiagnosisType.Final => "F",
                DiagnosisType.Working => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DiagnosticServiceSectionId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DiagnosticServiceSectionId input)
        {
            return input switch
            {
                DiagnosticServiceSectionId.Audiology => "AU",
                DiagnosticServiceSectionId.BloodGases => "BG",
                DiagnosticServiceSectionId.BloodBank => "BLB",
                DiagnosticServiceSectionId.Chemistry => "CH",
                DiagnosticServiceSectionId.Cytopathology => "CP",
                DiagnosticServiceSectionId.CatScan => "CT",
                DiagnosticServiceSectionId.CardiacCatheterization => "CTH",
                DiagnosticServiceSectionId.CardiacUltrasound => "CUS",
                DiagnosticServiceSectionId.Electrocardiac => "EC",
                DiagnosticServiceSectionId.Electroneuro => "EN",
                DiagnosticServiceSectionId.Hematology => "HM",
                DiagnosticServiceSectionId.BedsideIcuMonitoring => "ICU",
                DiagnosticServiceSectionId.Immunology => "IMM",
                DiagnosticServiceSectionId.Laboratory => "LAB",
                DiagnosticServiceSectionId.Microbiology => "MB",
                DiagnosticServiceSectionId.Mycobacteriology => "MCB",
                DiagnosticServiceSectionId.Mycology => "MYC",
                DiagnosticServiceSectionId.NuclearMagneticResonance => "NMR",
                DiagnosticServiceSectionId.NuclearMedicineScan => "NMS",
                DiagnosticServiceSectionId.NursingServiceMeasures => "NRS",
                DiagnosticServiceSectionId.OutsideLab => "OSL",
                DiagnosticServiceSectionId.OccupationalTherapy => "OT",
                DiagnosticServiceSectionId.Other => "OTH",
                DiagnosticServiceSectionId.ObUltrasound => "OUS",
                DiagnosticServiceSectionId.PulmonaryFunction => "PF",
                DiagnosticServiceSectionId.Pharmacy => "PHR",
                DiagnosticServiceSectionId.Physician => "PHY",
                DiagnosticServiceSectionId.PhysicalTherapy => "PT",
                DiagnosticServiceSectionId.Radiology => "RAD",
                DiagnosticServiceSectionId.RespiratoryCareTherapy => "RC",
                DiagnosticServiceSectionId.RadiationTherapy => "RT",
                DiagnosticServiceSectionId.RadiologyUltrasound => "RUS",
                DiagnosticServiceSectionId.Radiograph => "RX",
                DiagnosticServiceSectionId.SurgicalPathology => "SP",
                DiagnosticServiceSectionId.Serology => "SR",
                DiagnosticServiceSectionId.Toxicology => "TX",
                DiagnosticServiceSectionId.Virology => "VR",
                DiagnosticServiceSectionId.VascularUltrasound => "VUS",
                DiagnosticServiceSectionId.Cineradiograph => "XRC",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DietCodeSpecificationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DietCodeSpecificationType input)
        {
            return input switch
            {
                DietCodeSpecificationType.Diet => "D",
                DietCodeSpecificationType.Preference => "P",
                DietCodeSpecificationType.Supplement => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DisabledPersonCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DisabledPersonCode input)
        {
            return input switch
            {
                DisabledPersonCode.AssociatedParty => "AP",
                DisabledPersonCode.Guarantor => "GT",
                DisabledPersonCode.Insured => "IN",
                DisabledPersonCode.Patient => "PT",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DispenseMethod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DispenseMethod input)
        {
            return input switch
            {
                DispenseMethod.AutomaticDispensing => "AD",
                DispenseMethod.FloorStock => "F",
                DispenseMethod.Traditional => "TR",
                DispenseMethod.UnitDose => "UD",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DispenseType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DispenseType input)
        {
            return input switch
            {
                DispenseType.TrialQuantityBalance => "B",
                DispenseType.CompassionateFill => "C",
                DispenseType.NewRenewFullFill => "N",
                DispenseType.NewRenewPartFill => "P",
                DispenseType.RefillPartFill => "Q",
                DispenseType.RefillFullFill => "R",
                DispenseType.ManufacturerSample => "S",
                DispenseType.TrialQuantity => "T",
                DispenseType.NonPrescriptionFill => "Z",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DocumentAvailabilityStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DocumentAvailabilityStatus input)
        {
            return input switch
            {
                DocumentAvailabilityStatus.AvailableForPatientCare => "AV",
                DocumentAvailabilityStatus.Deleted => "CA",
                DocumentAvailabilityStatus.Obsolete => "OB",
                DocumentAvailabilityStatus.UnavailableForPatientCare => "UN",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DocumentCompletionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DocumentCompletionStatus input)
        {
            return input switch
            {
                DocumentCompletionStatus.Authenticated => "AU",
                DocumentCompletionStatus.Dictated => "DI",
                DocumentCompletionStatus.Documented => "DO",
                DocumentCompletionStatus.Incomplete => "IN",
                DocumentCompletionStatus.InProgress => "IP",
                DocumentCompletionStatus.LegallyAuthenticated => "LA",
                DocumentCompletionStatus.PreAuthenticated => "PA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DocumentConfidentialityStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DocumentConfidentialityStatus input)
        {
            return input switch
            {
                DocumentConfidentialityStatus.Restricted => "R",
                DocumentConfidentialityStatus.UsualControl => "U",
                DocumentConfidentialityStatus.VeryRestricted => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DocumentStorageStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DocumentStorageStatus input)
        {
            return input switch
            {
                DocumentStorageStatus.ActiveAndArchived => "AA",
                DocumentStorageStatus.Active => "AC",
                DocumentStorageStatus.Archived => "AR",
                DocumentStorageStatus.Purged => "PU",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DocumentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DocumentType input)
        {
            return input switch
            {
                DocumentType.AutopsyReport => "AR",
                DocumentType.Cardiodiagnostics => "CD",
                DocumentType.Consultation => "CN",
                DocumentType.DiagnosticImaging => "DI",
                DocumentType.DischargeSummary => "DS",
                DocumentType.EmergencyDepartmentReport => "ED",
                DocumentType.HistoryAndPhysicalExamination => "HP",
                DocumentType.OperativeReport => "OP",
                DocumentType.PsychiatricConsultation => "PC",
                DocumentType.PsychiatricHistoryAndPhysicalExamination => "PH",
                DocumentType.ProcedureNote => "PN",
                DocumentType.ProgressNote => "PR",
                DocumentType.SurgicalPathology => "SP",
                DocumentType.TransferSummary => "TS",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DrgDiagnosisDeterminationStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DrgDiagnosisDeterminationStatus input)
        {
            return input switch
            {
                DrgDiagnosisDeterminationStatus.ValidCode => "0",
                DrgDiagnosisDeterminationStatus.InvalidCode => "1",
                DrgDiagnosisDeterminationStatus.TwoPrimaryDiagnosisCodes => "2",
                DrgDiagnosisDeterminationStatus.InvalidForThisGender => "3",
                DrgDiagnosisDeterminationStatus.InvalidForThisAge => "4",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DrgGroupingStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DrgGroupingStatus input)
        {
            return input switch
            {
                DrgGroupingStatus.ValidCodeNotUsedForGrouping => "0",
                DrgGroupingStatus.ValidCodeUsedForGrouping => "1",
                DrgGroupingStatus.InvalidCodeNotUsedForGrouping => "2",
                DrgGroupingStatus.InvalidCodeCodeIsRelevantForGrouping => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DrgPayor enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DrgPayor input)
        {
            return input switch
            {
                DrgPayor.Champus => "C",
                DrgPayor.ManagedCareOrganization => "G",
                DrgPayor.Medicare => "M",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DrgProcedureDeterminationStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DrgProcedureDeterminationStatus input)
        {
            return input switch
            {
                DrgProcedureDeterminationStatus.ValidCode => "0",
                DrgProcedureDeterminationStatus.InvalidCode => "1",
                DrgProcedureDeterminationStatus.NotUsed => "2",
                DrgProcedureDeterminationStatus.InvalidForThisGender => "3",
                DrgProcedureDeterminationStatus.InvalidForThisAge => "4",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DrgProcedureRelevance enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DrgProcedureRelevance input)
        {
            return input switch
            {
                DrgProcedureRelevance.NeitherOperationRelevantNorNonOperationRelevantProcedure => "0",
                DrgProcedureRelevance.OperationRelevantProcedure => "1",
                DrgProcedureRelevance.NonOperationRelevantProcedure => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DrgStatusFinancialCalculation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DrgStatusFinancialCalculation input)
        {
            return input switch
            {
                DrgStatusFinancialCalculation.EffectiveWeightCalculated => "00",
                DrgStatusFinancialCalculation.HospitalSpecificContract => "01",
                DrgStatusFinancialCalculation.EeffectiveWeightForTransferReferralCalculated => "03",
                DrgStatusFinancialCalculation.ReferralFromOtherHospitalBasedOnACooperationNoDrgReimbursement => "04",
                DrgStatusFinancialCalculation.InvalidLengthOfStay => "05",
                DrgStatusFinancialCalculation.NoInformationEntryInCostDataForThisDrg => "10",
                DrgStatusFinancialCalculation.NoRelativeWeightFoundForDepartmentType => "11",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DrgStatusPatient enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DrgStatusPatient input)
        {
            return input switch
            {
                DrgStatusPatient.NormalLengthOfStay => "1",
                DrgStatusPatient.ShortLengthOfStay => "2",
                DrgStatusPatient.LongLengthOfStay => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DrgStatusRespirationMinutes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DrgStatusRespirationMinutes input)
        {
            return input switch
            {
                DrgStatusRespirationMinutes.RespirationMinutesNotUsedForGrouping => "0",
                DrgStatusRespirationMinutes.ListedRespirationMinutesUsedForGrouping => "1",
                DrgStatusRespirationMinutes.OpsCodeValueUsedForGrouping => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DurationCategories enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DurationCategories input)
        {
            return input switch
            {
                DurationCategories.AsteriskLifeOfTheUnit => "*",
                DurationCategories.TwelveHours => "12H",
                DurationCategories.OneHour => "1H",
                DurationCategories.OneMonth => "1L",
                DurationCategories.OneWeek => "1W",
                DurationCategories.TwoAndAHalfHours => "2.5H",
                DurationCategories.TwentyFourHours => "24H",
                DurationCategories.TwoDays => "2D",
                DurationCategories.TwoHours => "2H",
                DurationCategories.TwoMonths => "2L",
                DurationCategories.TwoWeeks => "2W",
                DurationCategories.ThirtyMinutes => "30M",
                DurationCategories.ThreeDays => "3D",
                DurationCategories.ThreeHours => "3H",
                DurationCategories.ThreeMonths => "3L",
                DurationCategories.ThreeWeeks => "3W",
                DurationCategories.FourDays => "4D",
                DurationCategories.FourHours => "4H",
                DurationCategories.FourWeeks => "4W",
                DurationCategories.FiveDays => "5D",
                DurationCategories.FiveHours => "5H",
                DurationCategories.SixDays => "6D",
                DurationCategories.SixHours => "6H",
                DurationCategories.SevenHours => "7H",
                DurationCategories.EightHours => "8H",
                DurationCategories.PointInTime => "PT",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EligibilitySource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EligibilitySource input)
        {
            return input switch
            {
                EligibilitySource.InsuranceCompany => "1",
                EligibilitySource.Employer => "2",
                EligibilitySource.InsuredPresentedPolicy => "3",
                EligibilitySource.InsuredPresentedCard => "4",
                EligibilitySource.SignedStatementOnFile => "5",
                EligibilitySource.VerbalInformation => "6",
                EligibilitySource.None => "7",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EmploymentStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EmploymentStatus input)
        {
            return input switch
            {
                EmploymentStatus.FullTimeEmployed => "1",
                EmploymentStatus.PartTimeEmployed => "2",
                EmploymentStatus.Unemployed => "3",
                EmploymentStatus.SelfEmployed => "4",
                EmploymentStatus.Retired => "5",
                EmploymentStatus.OnActiveMilitaryDuty => "6",
                EmploymentStatus.Unknown => "9",
                EmploymentStatus.ContractPerDiem => "C",
                EmploymentStatus.LeaveOfAbsence => "L",
                EmploymentStatus.Other => "O",
                EmploymentStatus.TemporarilyUnemployed => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Encoding enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(Encoding input)
        {
            return input switch
            {
                Encoding.NoEncoding => "A",
                Encoding.Base64 => "Base64",
                Encoding.Hexadecimal => "Hex",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EquipmentState enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EquipmentState input)
        {
            return input switch
            {
                EquipmentState.NullNoStateChangeADeprecated => "...",
                EquipmentState.Clearing => "CL",
                EquipmentState.Configuring => "CO",
                EquipmentState.EStopped => "ES",
                EquipmentState.Idle => "ID",
                EquipmentState.Initializing => "IN",
                EquipmentState.NormalOperation => "OP",
                EquipmentState.Pausing => "PA",
                EquipmentState.Paused => "PD",
                EquipmentState.PoweredUp => "PU",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ErrorSeverity enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ErrorSeverity input)
        {
            return input switch
            {
                ErrorSeverity.Error => "E",
                ErrorSeverity.FatalError => "F",
                ErrorSeverity.Information => "I",
                ErrorSeverity.Warning => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EscortRequired enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EscortRequired input)
        {
            return input switch
            {
                EscortRequired.NotRequired => "N",
                EscortRequired.Required => "R",
                EscortRequired.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EthnicGroup enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EthnicGroup input)
        {
            return input switch
            {
                EthnicGroup.HispanicOrLatino => "H",
                EthnicGroup.NotHispanicOrLatino => "N",
                EthnicGroup.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EventConsequence enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EventConsequence input)
        {
            return input switch
            {
                EventConsequence.CongenitalAnomalyBirthDefect => "C",
                EventConsequence.Death => "D",
                EventConsequence.CausedHospitalized => "H",
                EventConsequence.Incapacity => "I",
                EventConsequence.Disability => "J",
                EventConsequence.LifeThreatening => "L",
                EventConsequence.Other => "O",
                EventConsequence.ProlongedHospitalization => "P",
                EventConsequence.RequiredIntervention => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EventExpected enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EventExpected input)
        {
            return input switch
            {
                EventExpected.No => "N",
                EventExpected.Unknown => "U",
                EventExpected.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EventQualification enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EventQualification input)
        {
            return input switch
            {
                EventQualification.Abuse => "A",
                EventQualification.UnexpectedBeneficialEffect => "B",
                EventQualification.Dependency => "D",
                EventQualification.Interaction => "I",
                EventQualification.LackOfExpectTherapeuticEffect => "L",
                EventQualification.Misuse => "M",
                EventQualification.Overdose => "O",
                EventQualification.DrugWithdrawal => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EventReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EventReason input)
        {
            return input switch
            {
                EventReason.PatientRequest => "01",
                EventReason.PhysicianHealthPractitionerOrder => "02",
                EventReason.CensusManagement => "03",
                EventReason.Other => "O",
                EventReason.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EventRelatedPeriod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EventRelatedPeriod input)
        {
            return input switch
            {
                EventRelatedPeriod.BeforeMealFromLatAnteCibus => "AC",
                EventRelatedPeriod.BeforeLunchFromLatAnteCibusDiurnus => "ACD",
                EventRelatedPeriod.BeforeBreakfastFromLatAnteCibusMatutinus => "ACM",
                EventRelatedPeriod.BeforeDinnerFromLatAnteCibusVespertinus => "ACV",
                EventRelatedPeriod.TheHourOfSleepEGH1822 => "HS",
                EventRelatedPeriod.BetweenMealsFromLatInterCibus => "IC",
                EventRelatedPeriod.BetweenLunchAndDinner => "ICD",
                EventRelatedPeriod.BetweenBreakfastAndLunch => "ICM",
                EventRelatedPeriod.BetweenDinnerAndTheHourOfSleep => "ICV",
                EventRelatedPeriod.AfterMealFromLatPostCibus => "PC",
                EventRelatedPeriod.AfterLunchFromLatPostCibusDiurnus => "PCD",
                EventRelatedPeriod.AfterBreakfastFromLatPostCibusMatutinus => "PCM",
                EventRelatedPeriod.AfterDinnerFromLatPostCibusVespertinus => "PCV",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EventReportedTo enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EventReportedTo input)
        {
            return input switch
            {
                EventReportedTo.Distributor => "D",
                EventReportedTo.LocalFacilityUserFacility => "L",
                EventReportedTo.Manufacturer => "M",
                EventReportedTo.RegulatoryAgency => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EventSeriousness enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EventSeriousness input)
        {
            return input switch
            {
                EventSeriousness.No => "N",
                EventSeriousness.Significant => "S",
                EventSeriousness.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EventType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EventType input)
        {
            return input switch
            {
                EventType.LogEvent => "LOG",
                EventType.ServiceEvent => "SER",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given EventTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(EventTypeCode input)
        {
            return input switch
            {
                EventTypeCode.AdtAckAdmitVisitNotification => "A01",
                EventTypeCode.AdtAckTransferAPatient => "A02",
                EventTypeCode.AdtAckDischargeEndVisit => "A03",
                EventTypeCode.AdtAckRegisterAPatient => "A04",
                EventTypeCode.AdtAckPreAdmitAPatient => "A05",
                EventTypeCode.AdtAckChangeAnOutpatientToAnInpatient => "A06",
                EventTypeCode.AdtAckChangeAnInpatientToAnOutpatient => "A07",
                EventTypeCode.AdtAckUpdatePatientInformation => "A08",
                EventTypeCode.AdtAckPatientDepartingTracking => "A09",
                EventTypeCode.AdtAckPatientArrivingTracking => "A10",
                EventTypeCode.AdtAckCancelAdmitVisitNotification => "A11",
                EventTypeCode.AdtAckCancelTransfer => "A12",
                EventTypeCode.AdtAckCancelDischargeEndVisit => "A13",
                EventTypeCode.AdtAckPendingAdmit => "A14",
                EventTypeCode.AdtAckPendingTransfer => "A15",
                EventTypeCode.AdtAckPendingDischarge => "A16",
                EventTypeCode.AdtAckSwapPatients => "A17",
                EventTypeCode.AdtAckMergePatientInformation => "A18",
                EventTypeCode.QryAdrPatientQuery => "A19",
                EventTypeCode.AdtAckBedStatusUpdate => "A20",
                EventTypeCode.AdtAckPatientGoesOnALeaveOfAbsence => "A21",
                EventTypeCode.AdtAckPatientReturnsFromALeaveOfAbsence => "A22",
                EventTypeCode.AdtAckDeleteAPatientRecord => "A23",
                EventTypeCode.AdtAckLinkPatientInformation => "A24",
                EventTypeCode.AdtAckCancelPendingDischarge => "A25",
                EventTypeCode.AdtAckCancelPendingTransfer => "A26",
                EventTypeCode.AdtAckCancelPendingAdmit => "A27",
                EventTypeCode.AdtAckAddPersonInformation => "A28",
                EventTypeCode.AdtAckDeletePersonInformation => "A29",
                EventTypeCode.AdtAckMergePersonInformation => "A30",
                EventTypeCode.AdtAckUpdatePersonInformation => "A31",
                EventTypeCode.AdtAckCancelPatientArrivingTracking => "A32",
                EventTypeCode.AdtAckCancelPatientDepartingTracking => "A33",
                EventTypeCode.AdtAckMergePatientInfoPatientId => "A34",
                EventTypeCode.AdtAckMergePatientInfoAccountNumber => "A35",
                EventTypeCode.AdtAckMergePatientInfoPatientIdAccountNumber => "A36",
                EventTypeCode.AdtAckUnlinkPatientInformation => "A37",
                EventTypeCode.AdtAckCancelPreAdmit => "A38",
                EventTypeCode.AdtAckMergePersonPatientId => "A39",
                EventTypeCode.AdtAckMergePatientPatientIdList => "A40",
                EventTypeCode.AdtAckMergeAccountPatientAccountNumber => "A41",
                EventTypeCode.AdtAckMergeVisitVisitNumber => "A42",
                EventTypeCode.AdtAckMovePatientInfoPatientIdList => "A43",
                EventTypeCode.AdtAckMoveAccountInfoPatientAccountNumber => "A44",
                EventTypeCode.AdtAckMoveVisitInfoVisitNumber => "A45",
                EventTypeCode.AdtAckChangePatientId => "A46",
                EventTypeCode.AdtAckChangePatientIdList => "A47",
                EventTypeCode.AdtAckChangeAlternatePatientId => "A48",
                EventTypeCode.AdtAckChangePatientAccountNumber => "A49",
                EventTypeCode.AdtAckChangeVisitNumber => "A50",
                EventTypeCode.AdtAckChangeAlternateVisitId => "A51",
                EventTypeCode.AdtAckCancelLeaveOfAbsenceForAPatient => "A52",
                EventTypeCode.AdtAckCancelPatientReturnsFromLoa => "A53",
                EventTypeCode.AdtAckChangeAttendingDoctor => "A54",
                EventTypeCode.AdtAckCancelChangeAttendingDoctor => "A55",
                EventTypeCode.AdtAckUpdateAllergyInfo => "A60",
                EventTypeCode.AdtAckChangeConsultingDoctor => "A61",
                EventTypeCode.AdtAckCancelChangeConsultingDoctor => "A62",
                EventTypeCode.PmuAckAddPersonnelRecord => "B01",
                EventTypeCode.PmuAckUpdatePersonnelRecord => "B02",
                EventTypeCode.PmuAckDeletePersonnelReCord => "B03",
                EventTypeCode.PmuAckActivePracticingPerson => "B04",
                EventTypeCode.PmuAckDeactivatePracticingPerson => "B05",
                EventTypeCode.PmuAckTerminatePracticingPerson => "B06",
                EventTypeCode.PmuAckGrantCertificatePermission => "B07",
                EventTypeCode.PmuAckRevokeCertificatePermission => "B08",
                EventTypeCode.CrmRegisterPatientOnClinicalTrial => "C01",
                EventTypeCode.CrmCancelPatientRegistrationOnClinicalTrial => "C02",
                EventTypeCode.CrmUpdateRegistrationInformation => "C03",
                EventTypeCode.CrmPatientOffClinicalTrial => "C04",
                EventTypeCode.CrmPatientEntersPhaseOfClinicalTrial => "C05",
                EventTypeCode.CrmCancelPatientEnteringPhase => "C06",
                EventTypeCode.CrmUpdatePhaseInfo => "C07",
                EventTypeCode.CrmPatientHasGoneOffPhaseOfClinicalTrial => "C08",
                EventTypeCode.CsuAutomatedTimeIntervalsForReporting => "C09",
                EventTypeCode.CsuPatientCompletesClinicalTrial => "C10",
                EventTypeCode.CsuPatientCompletesPhaseOfClinicalTrial => "C11",
                EventTypeCode.CsuUpdatePatientOrderResultInfo => "C12",
                EventTypeCode.CancelQuery => "CNQ",
                EventTypeCode.SubmitHealthcareServicesInvoice => "E01",
                EventTypeCode.CancelHealthcareServicesInvoice => "E02",
                EventTypeCode.HealthcareServicesInvoiceStatus => "E03",
                EventTypeCode.ReassessHealthcareServicesInvoiceRequest => "E04",
                EventTypeCode.EditAdjudicationResults => "E10",
                EventTypeCode.RequestAdditionalInformation => "E12",
                EventTypeCode.AdditionalInformationResponse => "E13",
                EventTypeCode.PaymentRemittanceAdvice => "E15",
                EventTypeCode.SubmitAuthorizationRequest => "E20",
                EventTypeCode.CancelAuthorizationRequest => "E21",
                EventTypeCode.AuthorizationRequestStatus => "E22",
                EventTypeCode.AuthorizationResponse => "E24",
                EventTypeCode.SubmitHealthDocumentRelatedToAuthorizationRequest => "E30",
                EventTypeCode.CancelHealthDocumentRelatedToAuthorizationRequest => "E31",
                EventTypeCode.RqiRpiRequestForInsuranceInformation => "I01",
                EventTypeCode.RqiRplRequestReceiptOfPatientSelectionDisplayList => "I02",
                EventTypeCode.RqiRprRequestReceiptOfPatientSelectionList => "I03",
                EventTypeCode.RqdRpiRequestForPatientDemographicData => "I04",
                EventTypeCode.RqcRciRequestForPatientClinicalInformation => "I05",
                EventTypeCode.RqcRclRequestReceiptOfClinicalDataListing => "I06",
                EventTypeCode.PinAckUnsolicitedInsuranceInformation => "I07",
                EventTypeCode.RqaRpaRequestForTreatmentAuthorizationInformation => "I08",
                EventTypeCode.RqaRpaRequestForModificationToAuthorization => "I09",
                EventTypeCode.RqaRpaRequestForResubmissionOfAuthorization => "I10",
                EventTypeCode.RqaRpaRequestForCancellationOfAuthorization => "I11",
                EventTypeCode.RefRriPatientReferral => "I12",
                EventTypeCode.RefRriModifyPatientReferral => "I13",
                EventTypeCode.RefRriCancelPatientReferral => "I14",
                EventTypeCode.RefRriRequestPatientReferralStatus => "I15",
                EventTypeCode.CollaborativeCareReferral => "I16",
                EventTypeCode.ModifyCollaborativeCareReferral => "I17",
                EventTypeCode.CancelCollaborativeCareReferral => "I18",
                EventTypeCode.CollaborativeCareQuery => "I19",
                EventTypeCode.AsynchronousCollaborativeCareUpdate => "I20",
                EventTypeCode.CollaborativeCareMessage => "I21",
                EventTypeCode.CollaborativeCareFetch => "I22",
                EventTypeCode.QcnAckCancelQueryAcknowledgeMessage => "J01",
                EventTypeCode.QsxAckCancelSubscriptionAcknowledgeMessage => "J02",
                EventTypeCode.RspSegmentPatternResponseInResponseToQbpQ11 => "K11",
                EventTypeCode.RtbTabularResponseInResponseToQbpQ13 => "K13",
                EventTypeCode.RdyDisplayResponseInResponseToQbpQ15 => "K15",
                EventTypeCode.RspGetPersonDemographicsResponse => "K21",
                EventTypeCode.RspFindCandidatesResponse => "K22",
                EventTypeCode.RspGetCorrespondingIdentifiersResponse => "K23",
                EventTypeCode.RspAllocateIdentifiersResponse => "K24",
                EventTypeCode.RspPersonnelInformationBySegmentResponse => "K25",
                EventTypeCode.RspDispenseHistoryResponse => "K31",
                EventTypeCode.FindCandidatesIncludingVisitInformationResponse => "K32",
                EventTypeCode.MfnMfkMasterFileNotOtherwiseSpecified => "M01",
                EventTypeCode.MfnMfkMasterFileStaffPractitioner => "M02",
                EventTypeCode.MfnMfkMasterFileTestObservation => "M03",
                EventTypeCode.MfnMfkMasterFilesChargeDescription => "M04",
                EventTypeCode.MfnMfkPatientLocationMasterFile => "M05",
                EventTypeCode.MfnMfkClinicalStudyWithPhasesAndSchedulesMasterFile => "M06",
                EventTypeCode.MfnMfkClinicalStudyWithoutPhasesButWithSchedulesMasterFile => "M07",
                EventTypeCode.MfnMfkTestObservationNumericMasterFile => "M08",
                EventTypeCode.MfnMfkTestObservationCategoricalMasterFile => "M09",
                EventTypeCode.MfnMfkTestObservationBatteriesMasterFile => "M10",
                EventTypeCode.MfnMfkTestCalculatedObservationsMasterFile => "M11",
                EventTypeCode.MfnMfkMasterFileNotificationMessage => "M12",
                EventTypeCode.MfnMfkMasterFileNotificationGeneral => "M13",
                EventTypeCode.MfnMfkMasterFileNotificationSiteDefined => "M14",
                EventTypeCode.MfnMfkInventoryItemMasterFileNotification => "M15",
                EventTypeCode.MfnMfkMasterFileNotificationInventoryItemEnhanced => "M16",
                EventTypeCode.DrgMasterFileMessage => "M17",
                EventTypeCode.NmqNmrApplicationManagementQueryMessage => "N01",
                EventTypeCode.NmdAckApplicationManagementDataMessageUnsolicited => "N02",
                EventTypeCode.OrmOrderMessage => "O01",
                EventTypeCode.OrrOrderResponse => "O02",
                EventTypeCode.OmdDietOrder => "O03",
                EventTypeCode.OrdDietOrderAcknowledgment => "O04",
                EventTypeCode.OmsStockRequisitionOrder => "O05",
                EventTypeCode.OrsStockRequisitionAcknowledgment => "O06",
                EventTypeCode.OmnNonStockRequisitionOrder => "O07",
                EventTypeCode.OrnNonStockRequisitionAcknowledgment => "O08",
                EventTypeCode.OmpPharmacyTreatmentOrder => "O09",
                EventTypeCode.OrpPharmacyTreatmentOrderAcknowledgment => "O10",
                EventTypeCode.RdePharmacyTreatmentEncodedOrder => "O11",
                EventTypeCode.RrePharmacyTreatmentEncodedOrderAcknowledgment => "O12",
                EventTypeCode.RdsPharmacyTreatmentDispense => "O13",
                EventTypeCode.RrdPharmacyTreatmentDispenseAcknowledgment => "O14",
                EventTypeCode.RgvPharmacyTreatmentGive => "O15",
                EventTypeCode.RrgPharmacyTreatmentGiveAcknowledgment => "O16",
                EventTypeCode.RasPharmacyTreatmentAdministration => "O17",
                EventTypeCode.RraPharmacyTreatmentAdministrationAcknowledgment => "O18",
                EventTypeCode.OmgGeneralClinicalOrder => "O19",
                EventTypeCode.OrgOrlGeneralClinicalOrderResponse => "O20",
                EventTypeCode.OmlLaboratoryOrder => "O21",
                EventTypeCode.OrlGeneralLaboratoryOrderResponseMessageToAnyOml => "O22",
                EventTypeCode.OmiImagingOrder => "O23",
                EventTypeCode.OriImagingOrderResponseMessageToAnyOmi => "O24",
                EventTypeCode.RdePharmacyTreatmentRefillAuthorizationRequest => "O25",
                EventTypeCode.RrePharmacyTreatmentRefillAuthorizationAcknowledgement => "O26",
                EventTypeCode.OmbBloodProductOrder => "O27",
                EventTypeCode.OrbBloodProductOrderAcknowledgment => "O28",
                EventTypeCode.BpsBloodProductDispenseStatus => "O29",
                EventTypeCode.BrpBloodProductDispenseStatusAcknowledgment => "O30",
                EventTypeCode.BtsBloodProductTransfusionDisposition => "O31",
                EventTypeCode.BrtBloodProductTransfusionDispositionAcknowledgment => "O32",
                EventTypeCode.OmlLabOrderForMultipleOrdersRelatedToASingleSpecimen => "O33",
                EventTypeCode.OrlLabOrderResponseToMultipleOrderRelatedToSingleSpecimenOml => "O34",
                EventTypeCode.OmlLabOrderForMultipleOrdersRelatedToSingleSpecimen => "O35",
                EventTypeCode.OrlLabOrderResponseToSingleSpecimenOml => "O36",
                EventTypeCode.OplPopulationLocationBasedLabOrder => "O37",
                EventTypeCode.OprPopulationLocationBasedLabOrderAcknowledgment => "O38",
                EventTypeCode.SpecimenShipmentCentricLabOrder => "O39",
                EventTypeCode.SpecimenShipmentCentricLabOrderAcknowledgment => "O40",
                EventTypeCode.BarAckAddPatientAccounts => "P01",
                EventTypeCode.BarAckPurgePatientAccounts => "P02",
                EventTypeCode.DftAckPostDetailFinancialTransaction => "P03",
                EventTypeCode.QryDspGenerateBillAndARStatements => "P04",
                EventTypeCode.BarAckUpdateAccount => "P05",
                EventTypeCode.BarAckEndAccount => "P06",
                EventTypeCode.PexUnsolicitedInitialExperienceReport => "P07",
                EventTypeCode.PexUnsolicitedUpdateExperienceReport => "P08",
                EventTypeCode.SurSummaryExperienceReport => "P09",
                EventTypeCode.BarAckTransmitAmbulatoryPaymentClassificationApc => "P10",
                EventTypeCode.DftAckPostDetailFinancialTransactionsNew => "P11",
                EventTypeCode.BarAckUpdateDiagnosisProcedure => "P12",
                EventTypeCode.PprPcProblemAdd => "PC1",
                EventTypeCode.PprPcProblemUpdate => "PC2",
                EventTypeCode.PprPcProblemDelete => "PC3",
                EventTypeCode.QryPcProblemQuery => "PC4",
                EventTypeCode.PrrPcProblemResponse => "PC5",
                EventTypeCode.PglPcGoalAdd => "PC6",
                EventTypeCode.PglPcGoalUpdate => "PC7",
                EventTypeCode.PglPcGoalDelete => "PC8",
                EventTypeCode.QryPcGoalQuery => "PC9",
                EventTypeCode.PpvPcGoalResponse => "PCA",
                EventTypeCode.PppPcPathwayProblemOrientedAdd => "PCB",
                EventTypeCode.PppPcPathwayProblemOrientedUpdate => "PCC",
                EventTypeCode.PppPcPathwayProblemOrientedDelete => "PCD",
                EventTypeCode.QryPcPathwayProblemOrientedQuery => "PCE",
                EventTypeCode.PtrPcPathwayProblemOrientedQueryResponse => "PCF",
                EventTypeCode.PpgPcPathwayGoalOrientedAdd => "PCG",
                EventTypeCode.PpgPcPathwayGoalOrientedUpdate => "PCH",
                EventTypeCode.PpgPcPathwayGoalOrientedDelete => "PCJ",
                EventTypeCode.QryPcPathwayGoalOrientedQuery => "PCK",
                EventTypeCode.PptPcPathwayGoalOrientedQueryResponse => "PCL",
                EventTypeCode.QryDsrQuerySentForImmediateResponse => "Q01",
                EventTypeCode.QryQckQuerySentForDeferredResponse => "Q02",
                EventTypeCode.DsrAckDeferredResponseToAQuery => "Q03",
                EventTypeCode.UdmAckUnsolicitedDisplayUpdateMessage => "Q05",
                EventTypeCode.OsqOsrQueryForOrderStatus => "Q06",
                EventTypeCode.QbpQueryByParameterRequestingRspSegmentPatternResponse => "Q11",
                EventTypeCode.QbpQueryByParameterRequestingRtbTabularResponse => "Q13",
                EventTypeCode.QbpQueryByParameterRequestingRdyDisplayResponse => "Q15",
                EventTypeCode.QsbCreateSubscription => "Q16",
                EventTypeCode.QvrQueryForPreviousEvents => "Q17",
                EventTypeCode.QbpGetPersonDemographics => "Q21",
                EventTypeCode.QbpFindCandidates => "Q22",
                EventTypeCode.QbpGetCorrespondingIdentifiers => "Q23",
                EventTypeCode.QbpAllocateIdentifiers => "Q24",
                EventTypeCode.QbpPersonnelInformationBySegmentQuery => "Q25",
                EventTypeCode.RorPharmacyTreatmentOrderResponse => "Q26",
                EventTypeCode.RarPharmacyTreatmentAdministrationInformation => "Q27",
                EventTypeCode.RdrPharmacyTreatmentDispenseInformation => "Q28",
                EventTypeCode.RerPharmacyTreatmentEncodedOrderInformation => "Q29",
                EventTypeCode.RgrPharmacyTreatmentDoseInformation => "Q30",
                EventTypeCode.QbpQueryDispenseHistory => "Q31",
                EventTypeCode.FindCandidatesIncludingVisitInformation => "Q32",
                EventTypeCode.OruAckUnsolicitedTransmissionOfObservation => "R01",
                EventTypeCode.QryQueryForResultsOfObservation => "R02",
                EventTypeCode.OrfResponseToQueryTransmissionOfRequestedObservation => "R04",
                EventTypeCode.OulUnsolicitedLaboratoryObservation => "R21",
                EventTypeCode.OulUnsolicitedSpecimenOrientedObservation => "R22",
                EventTypeCode.OulUnsolicitedSpecimenContainerOrientedObservation => "R23",
                EventTypeCode.OulUnsolicitedOrderOrientedObservation => "R24",
                EventTypeCode.OpuUnsolicitedPopulationLocationBasedLabObservation => "R25",
                EventTypeCode.OsmUnsolicitedSpecimenShipmentManifest => "R26",
                EventTypeCode.OruUnsolicitedPointOfCareObservationWithoutExistingOrder => "R30",
                EventTypeCode.OruUnsolicitedNewPointOfCareObservationSearchForOrder => "R31",
                EventTypeCode.OruUnsolicitedPreOrderedPointOfCareObservation => "R32",
                EventTypeCode.OraObservationReportAcknowledgement => "R33",
                EventTypeCode.RorPharmacyPrescriptionOrderQueryResponse => "ROR",
                EventTypeCode.SrmSrrRequestNewAppointmentBooking => "S01",
                EventTypeCode.SrmSrrRequestAppointmentRescheduling => "S02",
                EventTypeCode.SrmSrrRequestAppointmentModification => "S03",
                EventTypeCode.SrmSrrRequestAppointmentCancellation => "S04",
                EventTypeCode.SrmSrrRequestAppointmentDiscontinuation => "S05",
                EventTypeCode.SrmSrrRequestAppointmentDeletion => "S06",
                EventTypeCode.SrmSrrRequestAdditionOfServiceOnAppointment => "S07",
                EventTypeCode.SrmSrrRequestModificationOfServiceOnAppointment => "S08",
                EventTypeCode.SrmSrrRequestCancellationOfServiceOnAppointment => "S09",
                EventTypeCode.SrmSrrRequestDiscontinuationOfServiceOnAppointment => "S10",
                EventTypeCode.SrmSrrRequestDeletionOfServiceOnAppointment => "S11",
                EventTypeCode.SiuAckNotifyNewAppointmentBooking => "S12",
                EventTypeCode.SiuAckNotifyAppointmentRescheduling => "S13",
                EventTypeCode.SiuAckNotifyAppointmentModification => "S14",
                EventTypeCode.SiuAckNotifyAppointmentCancellation => "S15",
                EventTypeCode.SiuAckNotificationOfAppointmentDiscontinuation => "S16",
                EventTypeCode.SiuAckNotifyAppointmentDeletion => "S17",
                EventTypeCode.SiuAckNotifyAdditionOfServiceOnAppointment => "S18",
                EventTypeCode.SiuAckNotifyModificationOfServiceOnAppointment => "S19",
                EventTypeCode.SiuAckNotifyCancellationOfServiceOnAppointment => "S20",
                EventTypeCode.SiuAckNotifyDiscontinuationOfServiceOnAppointment => "S21",
                EventTypeCode.SiuAckNotifyDeletionOfServiceResourceOnAppointment => "S22",
                EventTypeCode.SiuAckNotifyBlockedScheduleTimeSlots => "S23",
                EventTypeCode.SiuAckNotifyOpenedUnblockedScheduleTimeSlots => "S24",
                EventTypeCode.SqmSqrScheduleQueryMessageAndResponse => "S25",
                EventTypeCode.SiuAckNotifyPatientDidNotShowUpForAppointment => "S26",
                EventTypeCode.SiuAckBroadcastScheduledAppointments => "S27",
                EventTypeCode.SlrSlsRequestNewSterilizationLot => "S28",
                EventTypeCode.SlrSlsRequestSterilizationLotDeletion => "S29",
                EventTypeCode.StiStsRequestItem => "S30",
                EventTypeCode.SdrSdsRequestAntiMicrobialDeviceData => "S31",
                EventTypeCode.SmdSmsRequestAntiMicrobialDeviceCycleData => "S32",
                EventTypeCode.StcAckNotifySterilizationConfiguration => "S33",
                EventTypeCode.SlnAckNotifySterilizationLot => "S34",
                EventTypeCode.SlnAckNotifySterilizationLotDeletion => "S35",
                EventTypeCode.SdnAckNotifyAntiMicrobialDeviceData => "S36",
                EventTypeCode.ScnAckNotifyAntiMicrobialDeviceCycleData => "S37",
                EventTypeCode.MdmAckOriginalDocument => "T01",
                EventTypeCode.MdmAckOriginalDocumentNotifyAndContent => "T02",
                EventTypeCode.MdmAckDocumentStatusChange => "T03",
                EventTypeCode.MdmAckDocumentStatusChangeNotifyAndContent => "T04",
                EventTypeCode.MdmAckDocumentAddendum => "T05",
                EventTypeCode.MdmAckDocumentAddendumNotifyAndContent => "T06",
                EventTypeCode.MdmAckDocumentEdit => "T07",
                EventTypeCode.MdmAckDocumentEditNotifyAndContent => "T08",
                EventTypeCode.MdmAckDocumentReplacement => "T09",
                EventTypeCode.MdmAckDocumentReplacementNotifyAndContent => "T10",
                EventTypeCode.MdmAckDocumentCancel => "T11",
                EventTypeCode.QryDocDocumentQuery => "T12",
                EventTypeCode.EsuAckAutomatedEquipmentStatusUpdate => "U01",
                EventTypeCode.EsrAckAutomatedEquipmentStatusRequest => "U02",
                EventTypeCode.SsuAckSpecimenStatusUpdate => "U03",
                EventTypeCode.SsrAckSpecimenStatusRequest => "U04",
                EventTypeCode.InuAckAutomatedEquipmentInventoryUpdate => "U05",
                EventTypeCode.InrAckAutomatedEquipmentInventoryRequest => "U06",
                EventTypeCode.EacAckAutomatedEquipmentCommand => "U07",
                EventTypeCode.EarAckAutomatedEquipmentResponse => "U08",
                EventTypeCode.EanAckAutomatedEquipment => "U09",
                EventTypeCode.TcuAckAutomatedEquipmentTestCodeSettingsUpdate => "U10",
                EventTypeCode.TcrAckAutomatedEquipmentTestCodeSettingsRequest => "U11",
                EventTypeCode.LsuAckAutomatedEquipmentLogServiceUpdate => "U12",
                EventTypeCode.LsrAckAutomatedEquipmentLogServiceRequest => "U13",
                EventTypeCode.VxqQueryForVaccinationRecord => "V01",
                EventTypeCode.VxxResponseToVaccinationQueryMultiplePidMatches => "V02",
                EventTypeCode.VxrVaccinationRecordResponse => "V03",
                EventTypeCode.VxuUnsolicitedVaccinationRecordUpdate => "V04",
                EventTypeCode.MfqMfrMasterFilesQuery => "Varies",
                EventTypeCode.OruWaveformResultUnsolicitedTransmission => "W01",
                EventTypeCode.QrfWaveformResultResponseToQuery => "W02",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ExtendedPriorityCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ExtendedPriorityCodes input)
        {
            return input switch
            {
                ExtendedPriorityCodes.Asap => "A",
                ExtendedPriorityCodes.Callback => "C",
                ExtendedPriorityCodes.Preop => "P",
                ExtendedPriorityCodes.AsNeeded => "PRN",
                ExtendedPriorityCodes.Routine => "R",
                ExtendedPriorityCodes.Stat => "S",
                ExtendedPriorityCodes.TimingCritical => "T",
                ExtendedPriorityCodes.TimingCriticalWithinIntegerDays => "TDinteger",
                ExtendedPriorityCodes.TimingCriticalWithinIntegerHours => "THinteger",
                ExtendedPriorityCodes.TimingCriticalWithinIntegerMonths => "TLinteger",
                ExtendedPriorityCodes.TimingCriticalWithinIntegerMinutes => "TMinteger",
                ExtendedPriorityCodes.TimingCriticalWithinIntegerSeconds => "TSinteger",
                ExtendedPriorityCodes.TimingCriticalWithinIntegerWeeks => "TWinteger",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given FacilityType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(FacilityType input)
        {
            return input switch
            {
                FacilityType.AgentForForeignManufacturer => "A",
                FacilityType.Distributor => "D",
                FacilityType.Manufacturer => "M",
                FacilityType.User => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given FileLevelEventCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(FileLevelEventCode input)
        {
            return input switch
            {
                FileLevelEventCode.ReplaceCurrentVersionOfMasterFile => "REP",
                FileLevelEventCode.ChangeFileRecordsAsDefined => "UPD",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given FillerStatusCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(FillerStatusCodes input)
        {
            return input switch
            {
                FillerStatusCodes.Blocked => "Blocked",
                FillerStatusCodes.Booked => "Booked",
                FillerStatusCodes.Cancelled => "Cancelled",
                FillerStatusCodes.Complete => "Complete",
                FillerStatusCodes.Deleted => "Deleted",
                FillerStatusCodes.Discontinued => "Discontinued",
                FillerStatusCodes.Noshow => "Noshow",
                FillerStatusCodes.Overbook => "Overbook",
                FillerStatusCodes.Pending => "Pending",
                FillerStatusCodes.Started => "Started",
                FillerStatusCodes.Waitlist => "Waitlist",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given FormularyStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(FormularyStatus input)
        {
            return input switch
            {
                FormularyStatus.PharmaceuticalSubstanceIsInFormularyButGuidelinesApply => "G",
                FormularyStatus.PharmaceuticalSubstanceIsNotInFormulary => "N",
                FormularyStatus.PharmaceuticalSubstanceIsInFormularyButRestrictionsApply => "R",
                FormularyStatus.PharmaceuticalSubstanceIsInFormulary => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given GestationCategoryCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(GestationCategoryCode input)
        {
            return input switch
            {
                GestationCategoryCode.PrematurePreTerm => "1",
                GestationCategoryCode.FullTerm => "2",
                GestationCategoryCode.OverduePostTerm => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given GovernmentReimbursementProgram enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(GovernmentReimbursementProgram input)
        {
            return input switch
            {
                GovernmentReimbursementProgram.MediCal => "C",
                GovernmentReimbursementProgram.Medicare => "MM",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given GrouperStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(GrouperStatus input)
        {
            return input switch
            {
                GrouperStatus.NormalGrouping => "0",
                GrouperStatus.InvalidOrMissingPrimaryDiagnosis => "1",
                GrouperStatus.DiagnosisIsNotAllowedToBePrimary => "2",
                GrouperStatus.DataDoesNotFulfillDrgCriteria => "3",
                GrouperStatus.InvalidAgeAdmissionDateDateOfBirthOrDischargeDate => "4",
                GrouperStatus.InvalidGender => "5",
                GrouperStatus.InvalidDischargeStatus => "6",
                GrouperStatus.InvalidWeightAdAdmission => "7",
                GrouperStatus.InvalidLengthOfStay => "8",
                GrouperStatus.InvalidFieldSameDay => "9",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given HospitalService enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(HospitalService input)
        {
            return input switch
            {
                HospitalService.CardiacService => "CAR",
                HospitalService.MedicalService => "MED",
                HospitalService.PulmonaryService => "PUL",
                HospitalService.SurgicalService => "SUR",
                HospitalService.UrologyService => "URO",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given IdentifierType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(IdentifierType input)
        {
            return input switch
            {
                IdentifierType.AccessionId => "ACSN",
                IdentifierType.AmericanExpress => "AM",
                IdentifierType.AmericanMedicalAssociationNumber => "AMA",
                IdentifierType.AccountNumber => "AN",
                IdentifierType.AccountNumberCreditor => "ANC",
                IdentifierType.AccountNumberDebitor => "AND",
                IdentifierType.AnonymousIdentifier => "ANON",
                IdentifierType.TemporaryAccountNumber => "ANT",
                IdentifierType.AdvancedPracticeRegisteredNurseNumber => "APRN",
                IdentifierType.AncestorSpecimenId => "ASID",
                IdentifierType.BankAccountNumber => "BA",
                IdentifierType.BankCardNumber => "BC",
                IdentifierType.BirthCertificate => "BCT",
                IdentifierType.BirthRegistryNumber => "BR",
                IdentifierType.BreedRegistryNumber => "BRN",
                IdentifierType.PrimaryPhysicianOfficeNumber => "BSNR",
                IdentifierType.CostCenterNumber => "CC",
                IdentifierType.ChangeOfNameDocument => "CONM",
                IdentifierType.CountyNumber => "CY",
                IdentifierType.CitizenshipCard => "CZ",
                IdentifierType.DentistLicenseNumber => "DDS",
                IdentifierType.DrugEnforceAdminRegistrationNumber => "DEA",
                IdentifierType.DrugFurnishingOrPrescriptiveAuthorityNumber => "DFN",
                IdentifierType.DinersClubCard => "DI",
                IdentifierType.DriversLicenseNumber => "DL",
                IdentifierType.DoctorNumber => "DN",
                IdentifierType.OsteopathicLicenseNumber => "DO",
                IdentifierType.DiplomaticPassport => "DP",
                IdentifierType.PodiatristLicenseNumber => "DPM",
                IdentifierType.DonorRegistrationNumber => "DR",
                IdentifierType.DiscoverCard => "DS",
                IdentifierType.EmployeeNumber => "EI",
                IdentifierType.EmployerNumber => "EN",
                IdentifierType.StaffEnterpriseNumber => "ESN",
                IdentifierType.FacilityId => "FI",
                IdentifierType.GuarantorInternalIdentifier => "GI",
                IdentifierType.GeneralLedgerNumber => "GL",
                IdentifierType.GuarantorExternalIdentifier => "GN",
                IdentifierType.HealthCardNumber => "HC",
                IdentifierType.IndigenousAboriginal => "IND",
                IdentifierType.JurisdictionalHealthNumberCanada => "JHN",
                IdentifierType.LaboratoryAccessionId => "LACSN",
                IdentifierType.LifelongPhysicianNumber => "LANR",
                IdentifierType.LaborAndIndustriesNumber => "LI",
                IdentifierType.LicenseNumber => "LN",
                IdentifierType.LocalRegistryId => "LR",
                IdentifierType.PatientMedicaidNumber => "MA",
                IdentifierType.MemberNumber => "MB",
                IdentifierType.PatientsMedicareNumber => "MC",
                IdentifierType.PractitionerMedicaidNumber => "MCD",
                IdentifierType.MicrochipNumber => "MCN",
                IdentifierType.PractitionerMedicareNumber => "MCR",
                IdentifierType.MarriageCertificate => "MCT",
                IdentifierType.MedicalLicenseNumber => "MD",
                IdentifierType.MilitaryIdNumber => "MI",
                IdentifierType.MedicalRecordNumber => "MR",
                IdentifierType.TemporaryMedicalRecordNumber => "MRT",
                IdentifierType.Mastercard => "MS",
                IdentifierType.SecondaryPhysicianOfficeNumber => "NBSNR",
                IdentifierType.NaturalizationCertificate => "NCT",
                IdentifierType.NationalEmployerId => "NE",
                IdentifierType.NationalHealthPlanId => "NH",
                IdentifierType.NationalUniqueIndividualId => "NI",
                IdentifierType.NationalInsuranceOrganizationId => "NII",
                IdentifierType.NationalInsurancePayorId => "NIIP",
                IdentifierType.NationalPersonIdentifier => "NNxxx",
                IdentifierType.NursePractitionerNumber => "NP",
                IdentifierType.NationalProviderIdentifier => "NPI",
                IdentifierType.OptometristLicenseNumber => "OD",
                IdentifierType.PhysicianAssistantNumber => "PA",
                IdentifierType.ParoleCard => "PC",
                IdentifierType.PenitentiaryCorrectionalInstitutionNumber => "PCN",
                IdentifierType.LivingSubjectEnterpriseNumber => "PE",
                IdentifierType.PensionNumber => "PEN",
                IdentifierType.PatientInternalIdentifier => "PI",
                IdentifierType.PersonNumber => "PN",
                IdentifierType.TemporaryLivingSubjectNumber => "PNT",
                IdentifierType.MedicareCmsPerformingProviderIdNumber => "PPIN",
                IdentifierType.PassportNumber => "PPN",
                IdentifierType.PermanentResidentCardNumber => "PRC",
                IdentifierType.ProviderNumber => "PRN",
                IdentifierType.PatientExternalIdentifier => "PT",
                IdentifierType.QaNumber => "QA",
                IdentifierType.ResourceIdentifier => "RI",
                IdentifierType.RegisteredNurseNumber => "RN",
                IdentifierType.PharmacistLicenseNumber => "RPH",
                IdentifierType.RailroadRetirementNumber => "RR",
                IdentifierType.RegionalRegistryId => "RRI",
                IdentifierType.RailroadRetirementProvider => "RRP",
                IdentifierType.SpecimenId => "SID",
                IdentifierType.StateLicense => "SL",
                IdentifierType.SubscriberNumber => "SN",
                IdentifierType.StudyPermit => "SP",
                IdentifierType.StateRegistryId => "SR",
                IdentifierType.SocialSecurityNumber => "SS",
                IdentifierType.TaxIdNumber => "TAX",
                IdentifierType.TreatyNumberCanada => "TN",
                IdentifierType.TemporaryPermanentResidentCanada => "TPR",
                IdentifierType.UnspecifiedIdentifier => "U",
                IdentifierType.MedicareCmsUniversalPhysicianId => "UPIN",
                IdentifierType.UniqueSpecimenId => "USID",
                IdentifierType.VisitNumber => "VN",
                IdentifierType.VisitorPermit => "VP",
                IdentifierType.Visa => "VS",
                IdentifierType.WicIdentifier => "WC",
                IdentifierType.WorkersCompNumber => "WCN",
                IdentifierType.WorkPermit => "WP",
                IdentifierType.OrganizationIdentifier => "XX",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given IdentityMayBeDivulged enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(IdentityMayBeDivulged input)
        {
            return input switch
            {
                IdentityMayBeDivulged.No => "N",
                IdentityMayBeDivulged.NotApplicable => "NA",
                IdentityMayBeDivulged.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given IdentityReliabilityCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(IdentityReliabilityCode input)
        {
            return input switch
            {
                IdentityReliabilityCode.PatientPersonNameIsAnAlias => "AL",
                IdentityReliabilityCode.UnknownDefaultAddress => "UA",
                IdentityReliabilityCode.UnknownDefaultDateOfBirth => "UD",
                IdentityReliabilityCode.UnknownDefaultSocialSecurityNumber => "US",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ImmunizationRegistryStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ImmunizationRegistryStatus input)
        {
            return input switch
            {
                ImmunizationRegistryStatus.Active => "A",
                ImmunizationRegistryStatus.Inactive => "I",
                ImmunizationRegistryStatus.InactiveLostToFollowUp => "L",
                ImmunizationRegistryStatus.InactiveMovedOrGoneElsewhere => "M",
                ImmunizationRegistryStatus.Other => "O",
                ImmunizationRegistryStatus.InactivePermanently => "P",
                ImmunizationRegistryStatus.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given InactiveReasonCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(InactiveReasonCode input)
        {
            return input switch
            {
                InactiveReasonCode.LeaveOfAbsence => "L",
                InactiveReasonCode.Retired => "R",
                InactiveReasonCode.Termination => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given IncidentTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(IncidentTypeCode input)
        {
            return input switch
            {
                IncidentTypeCode.Other => "O",
                IncidentTypeCode.Preventable => "P",
                IncidentTypeCode.UserError => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given IndirectExposureMechanism enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(IndirectExposureMechanism input)
        {
            return input switch
            {
                IndirectExposureMechanism.BreastMilk => "B",
                IndirectExposureMechanism.Father => "F",
                IndirectExposureMechanism.Other => "O",
                IndirectExposureMechanism.Transplacental => "P",
                IndirectExposureMechanism.BloodProduct => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given InformPersonCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(InformPersonCode input)
        {
            return input switch
            {
                InformPersonCode.InformHelpDesk => "HD",
                InformPersonCode.DoNotInformPatient => "NPAT",
                InformPersonCode.InformPatient => "PAT",
                InformPersonCode.InformUser => "USR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given InstitutionRelationshipType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(InstitutionRelationshipType input)
        {
            return input switch
            {
                InstitutionRelationshipType.Contractor => "CON",
                InstitutionRelationshipType.Consultant => "CST",
                InstitutionRelationshipType.Employee => "EMP",
                InstitutionRelationshipType.Volunteer => "VOL",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given InsuranceCompanyContactReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(InsuranceCompanyContactReason input)
        {
            return input switch
            {
                InsuranceCompanyContactReason.MedicareClaimStatus => "01",
                InsuranceCompanyContactReason.MedicaidClaimStatus => "02",
                InsuranceCompanyContactReason.NameAddressChange => "03",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given InterpretationCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(InterpretationCodes input)
        {
            return input switch
            {
                InterpretationCodes.OffScaleLow => "",
                InterpretationCodes.OffScaleHigh => "",
                InterpretationCodes.Abnormal => "A",
                InterpretationCodes.CriticallyAbnormal => "AA",
                InterpretationCodes.AntiComplementarySubstancesPresent => "AC",
                InterpretationCodes.Better => "B",
                InterpretationCodes.SignificantChangeDown => "D",
                InterpretationCodes.Detected => "DET",
                InterpretationCodes.High => "H",
                InterpretationCodes.CriticallyHigh => "HH",
                InterpretationCodes.Intermediate => "I",
                InterpretationCodes.Indeterminate => "IND",
                InterpretationCodes.Low => "L",
                InterpretationCodes.CriticallyLow => "LL",
                InterpretationCodes.ModeratelySusceptible => "MS",
                InterpretationCodes.Normal => "N",
                InterpretationCodes.NotDetected => "ND",
                InterpretationCodes.Negative => "NEG",
                InterpretationCodes.NonReactive => "NR",
                InterpretationCodes.NoRangeDefinedOrNormalRangesDontApply => "null",
                InterpretationCodes.Positive => "POS",
                InterpretationCodes.QualityControlFailure => "QCF",
                InterpretationCodes.Resistant => "R",
                InterpretationCodes.Reactive => "RR",
                InterpretationCodes.Susceptible => "S",
                InterpretationCodes.CytotoxicSubstancePresent => "TOX",
                InterpretationCodes.SignificantChangeUp => "U",
                InterpretationCodes.VerySusceptible => "VS",
                InterpretationCodes.Worse => "W",
                InterpretationCodes.WeaklyReactive => "WR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given InvocationEvent enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(InvocationEvent input)
        {
            return input switch
            {
                InvocationEvent.OnDischarge => "D",
                InvocationEvent.OnReceiptOfOrder => "O",
                InvocationEvent.AtTimeServiceIsCompleted => "R",
                InvocationEvent.AtTimeServiceIsStarted => "S",
                InvocationEvent.AtDesignatedDateTime => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given InvoiceControlCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(InvoiceControlCode input)
        {
            return input switch
            {
                InvoiceControlCode.AuthorizationRequestForAdmission => "AA",
                InvoiceControlCode.CombinedAuthorizationAndAdjudicationRequest => "AI",
                InvoiceControlCode.CancelAuthorizationRequest => "CA",
                InvoiceControlCode.CancelInvoiceProductServiceGroup => "CG",
                InvoiceControlCode.CancelInvoiceProductServiceLineItem => "CL",
                InvoiceControlCode.CancelInvoice => "CN",
                InvoiceControlCode.CopyOfInvoice => "CP",
                InvoiceControlCode.CoverageRegisterQuery => "CQ",
                InvoiceControlCode.AuthorizationRequestForInpatientStayExtension => "EA",
                InvoiceControlCode.OriginalAuthorization => "OA",
                InvoiceControlCode.OriginalInvoice => "OR",
                InvoiceControlCode.PreAuthorization => "PA",
                InvoiceControlCode.PreDeterminationInvoice => "PD",
                InvoiceControlCode.ReAssessment => "RA",
                InvoiceControlCode.ReferralPreAuthorization => "RC",
                InvoiceControlCode.ReferralAuthorization => "RU",
                InvoiceControlCode.SpecialAuthorization => "SA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given InvoiceProcessingResultsStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(InvoiceProcessingResultsStatus input)
        {
            return input switch
            {
                InvoiceProcessingResultsStatus.Acknowledge => "ACK",
                InvoiceProcessingResultsStatus.AdjudicatedWithAdjustments => "ADJ",
                InvoiceProcessingResultsStatus.AdjudicatedAsSubmitted => "ADJSUB",
                InvoiceProcessingResultsStatus.AdjudicatedToZero => "ADJZER",
                InvoiceProcessingResultsStatus.Paid => "PAID",
                InvoiceProcessingResultsStatus.Pending => "PEND",
                InvoiceProcessingResultsStatus.PreDetermination => "PRED",
                InvoiceProcessingResultsStatus.Reject => "REJECT",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given InvoiceReasonCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(InvoiceReasonCodes input)
        {
            return input switch
            {
                InvoiceReasonCodes.LateInvoice => "LATE",
                InvoiceReasonCodes.NormalSubmission => "NORM",
                InvoiceReasonCodes.SubscriberCoverageProblem => "SUB",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given InvoiceType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(InvoiceType input)
        {
            return input switch
            {
                InvoiceType.Block => "BK",
                InvoiceType.Final => "FN",
                InvoiceType.FeeForService => "FS",
                InvoiceType.Group => "GP",
                InvoiceType.InformationOnly => "IN",
                InvoiceType.NonPatient => "NP",
                InvoiceType.Partial => "PA",
                InvoiceType.Salary => "SL",
                InvoiceType.BySession => "SS",
                InvoiceType.Supplemental => "SU",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ItemImportanceCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ItemImportanceCodes input)
        {
            return input switch
            {
                ItemImportanceCodes.Critical => "CRT",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ItemStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ItemStatus input)
        {
            return input switch
            {
                ItemStatus.Active => "A",
                ItemStatus.Inactive => "I",
                ItemStatus.PendingInactive => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ItemStatusCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ItemStatusCodes input)
        {
            return input switch
            {
                ItemStatusCodes.Active => "1",
                ItemStatusCodes.PendingInactive => "2",
                ItemStatusCodes.Inactive => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ItemType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ItemType input)
        {
            return input switch
            {
                ItemType.Equipment => "EQP",
                ItemType.Implant => "IMP",
                ItemType.Medication => "MED",
                ItemType.Supply => "SUP",
                ItemType.TubesDrainsAndCatheters => "TDC",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given JobStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(JobStatus input)
        {
            return input switch
            {
                JobStatus.Other => "O",
                JobStatus.Permanent => "P",
                JobStatus.Temporary => "T",
                JobStatus.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given JurisdictionalBreadth enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(JurisdictionalBreadth input)
        {
            return input switch
            {
                JurisdictionalBreadth.CountyParish => "C",
                JurisdictionalBreadth.Country => "N",
                JurisdictionalBreadth.StateProvince => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given KindOfQuantity enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(KindOfQuantity input)
        {
            return input switch
            {
                KindOfQuantity.Absorbance => "ABS",
                KindOfQuantity.ConcentrationArbitrarySubstance => "ACNC",
                KindOfQuantity.Activity => "ACT",
                KindOfQuantity.Appearance => "APER",
                KindOfQuantity.Arbitrary => "ARB",
                KindOfQuantity.Area => "AREA",
                KindOfQuantity.Aspect => "ASPECT",
                KindOfQuantity.CatalyticActivity => "CACT",
                KindOfQuantity.CatalyticContent => "CCNT",
                KindOfQuantity.CatalyticConcentrationRatio => "CCRTO",
                KindOfQuantity.CatalyticFraction => "CFR",
                KindOfQuantity.Class => "CLAS",
                KindOfQuantity.CatalyticConcentration => "CNC",
                KindOfQuantity.Constant => "CNST",
                KindOfQuantity.Coefficient => "COEF",
                KindOfQuantity.Color => "COLOR",
                KindOfQuantity.Consistency => "CONS",
                KindOfQuantity.CatalyticRate => "CRAT",
                KindOfQuantity.CatalyticRatio => "CRTO",
                KindOfQuantity.Density => "DEN",
                KindOfQuantity.Device => "DEV",
                KindOfQuantity.Difference => "DIFF",
                KindOfQuantity.Elasticity => "ELAS",
                KindOfQuantity.ElectricalPotential => "ELPOT",
                KindOfQuantity.ElectricalCurrent => "ELRAT",
                KindOfQuantity.ElectricalResistance => "ELRES",
                KindOfQuantity.Energy => "ENGR",
                KindOfQuantity.Entitic => "ENT",
                KindOfQuantity.EntiticCatalyticActivity => "ENTCAT",
                KindOfQuantity.EntiticNumber => "ENTNUM",
                KindOfQuantity.EntiticSubstanceOfAmount => "ENTSUB",
                KindOfQuantity.EntiticVolume => "ENTVOL",
                KindOfQuantity.Equilibrium => "EQL",
                KindOfQuantity.MechanicalForce => "FORCE",
                KindOfQuantity.Frequency => "FREQ",
                KindOfQuantity.ImpressionInterpretationOfStudy => "IMP",
                KindOfQuantity.KinematicViscosity => "KINV",
                KindOfQuantity.Length => "LEN",
                KindOfQuantity.LengthIncrement => "LINC",
                KindOfQuantity.Liquefaction => "LIQ",
                KindOfQuantity.Mass => "MASS",
                KindOfQuantity.MassConcentration => "MCNC",
                KindOfQuantity.MassContent => "MCNT",
                KindOfQuantity.MassConcentrationRatio => "MCRTO",
                KindOfQuantity.MassFraction => "MFR",
                KindOfQuantity.MagneticFlux => "MGFLUX",
                KindOfQuantity.MassIncrement => "MINC",
                KindOfQuantity.Morphology => "MORPH",
                KindOfQuantity.Motility => "MOTIL",
                KindOfQuantity.MassRate => "MRAT",
                KindOfQuantity.MassRatio => "MRTO",
                KindOfQuantity.NumberConcentration => "NCNC",
                KindOfQuantity.NumberContent => "NCNT",
                KindOfQuantity.NumberFraction => "NFR",
                KindOfQuantity.NumberRatio => "NRTO",
                KindOfQuantity.Number => "NUM",
                KindOfQuantity.OpticalDensity => "OD",
                KindOfQuantity.Osmolality => "OSMOL",
                KindOfQuantity.Pressure => "PRES",
                KindOfQuantity.PresenceIdentityExistence => "PRID",
                KindOfQuantity.PowerWattage => "PWR",
                KindOfQuantity.Ranges => "RANGE",
                KindOfQuantity.Ratios => "RATIO",
                KindOfQuantity.ReciprocalRelativeTime => "RCRLTM",
                KindOfQuantity.RelativeDensity => "RDEN",
                KindOfQuantity.Relative => "REL",
                KindOfQuantity.RelativeMassConcentration => "RLMCNC",
                KindOfQuantity.RelativeSubstanceConcentration => "RLSCNC",
                KindOfQuantity.RelativeTime => "RLTM",
                KindOfQuantity.SaturationFraction => "SATFR",
                KindOfQuantity.SubstanceConcentration => "SCNC",
                KindOfQuantity.SubstanceConcentrationIncrement => "SCNCIN",
                KindOfQuantity.SubstanceContent => "SCNT",
                KindOfQuantity.SubstanceContentRate => "SCNTR",
                KindOfQuantity.SubstanceConcentrationRatio => "SCRTO",
                KindOfQuantity.SubstanceFraction => "SFR",
                KindOfQuantity.Shape => "SHAPE",
                KindOfQuantity.Smell => "SMELL",
                KindOfQuantity.SubstanceRate => "SRAT",
                KindOfQuantity.SubstanceRatio => "SRTO",
                KindOfQuantity.SubstanceAmount => "SUB",
                KindOfQuantity.Susceptibility => "SUSC",
                KindOfQuantity.Taste => "TASTE",
                KindOfQuantity.Temperature => "TEMP",
                KindOfQuantity.TemperatureDifference => "TEMPDF",
                KindOfQuantity.TemperatureIncrement => "TEMPIN",
                KindOfQuantity.ThresholdMassConcentration => "THRMCNC",
                KindOfQuantity.ThresholdSubstanceConcentration => "THRSCNC",
                KindOfQuantity.Time => "TIME",
                KindOfQuantity.DilutionFactor => "TITR",
                KindOfQuantity.TimeDifference => "TMDF",
                KindOfQuantity.TimeStampDateAndTime => "TMSTP",
                KindOfQuantity.TimeRatio => "TRTO",
                KindOfQuantity.Type => "TYPE",
                KindOfQuantity.VolumeContent => "VCNT",
                KindOfQuantity.Velocity => "VEL",
                KindOfQuantity.VelocityRatio => "VELRT",
                KindOfQuantity.VolumeFraction => "VFR",
                KindOfQuantity.Viscosity => "VISC",
                KindOfQuantity.Volume => "VOL",
                KindOfQuantity.VolumeRate => "VRAT",
                KindOfQuantity.VolumeRatio => "VRTO",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LaborCalculationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LaborCalculationType input)
        {
            return input switch
            {
                LaborCalculationType.Cost => "CST",
                LaborCalculationType.Time => "TME",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LanguageAbility enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LanguageAbility input)
        {
            return input switch
            {
                LanguageAbility.Read => "1",
                LanguageAbility.Write => "2",
                LanguageAbility.Speak => "3",
                LanguageAbility.Understand => "4",
                LanguageAbility.Sign => "5",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LanguageProficiency enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LanguageProficiency input)
        {
            return input switch
            {
                LanguageProficiency.Excellent => "1",
                LanguageProficiency.Good => "2",
                LanguageProficiency.Fair => "3",
                LanguageProficiency.Poor => "4",
                LanguageProficiency.SomeLevelUnknown => "5",
                LanguageProficiency.None => "6",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LevelOfCare enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LevelOfCare input)
        {
            return input switch
            {
                LevelOfCare.Ambulatory => "A",
                LevelOfCare.CriticalCare => "C",
                LevelOfCare.Emergency => "E",
                LevelOfCare.Isolation => "F",
                LevelOfCare.IntensiveCare => "N",
                LevelOfCare.Routine => "R",
                LevelOfCare.Surgery => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LivingArrangement enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LivingArrangement input)
        {
            return input switch
            {
                LivingArrangement.Alone => "A",
                LivingArrangement.Family => "F",
                LivingArrangement.Institution => "I",
                LivingArrangement.Relative => "R",
                LivingArrangement.SpouseOnly => "S",
                LivingArrangement.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LivingDependency enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LivingDependency input)
        {
            return input switch
            {
                LivingDependency.SmallChildrenDependent => "C",
                LivingDependency.MedicalSupervisionRequired => "M",
                LivingDependency.Other => "O",
                LivingDependency.SpouseDependent => "S",
                LivingDependency.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LivingWillCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LivingWillCode input)
        {
            return input switch
            {
                LivingWillCode.YesPatientHasLivingWillButNotOnFile => "F",
                LivingWillCode.NoPatientDoesNotHaveLivingWillButInfoWasProvided => "I",
                LivingWillCode.NoPatientDoesNotHaveLivingWillAndNoInfoWasProvided => "N",
                LivingWillCode.Unknown => "U",
                LivingWillCode.YesPatientHasLivingWill => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LoadStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LoadStatus input)
        {
            return input switch
            {
                LoadStatus.LoadIsComplete => "LCC",
                LoadStatus.LoadCanceled => "LCN",
                LoadStatus.LoadInProcess => "LCP",
                LoadStatus.BuildingALoad => "LLD",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LocalRemoteControlState enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LocalRemoteControlState input)
        {
            return input switch
            {
                LocalRemoteControlState.NullNoStateChangeADeprecated => "...",
                LocalRemoteControlState.Local => "L",
                LocalRemoteControlState.Remote => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LocationCharacteristicId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LocationCharacteristicId input)
        {
            return input switch
            {
                LocationCharacteristicId.GenderOfPatientS => "GEN",
                LocationCharacteristicId.Implant => "IMP",
                LocationCharacteristicId.InfectiousDisease => "INF",
                LocationCharacteristicId.LevelOfCare => "LCR",
                LocationCharacteristicId.Licensed => "LIC",
                LocationCharacteristicId.Overflow => "OVR",
                LocationCharacteristicId.PrivacyLevel => "PRL",
                LocationCharacteristicId.BedIsSetUp => "SET",
                LocationCharacteristicId.Shadow => "SHA",
                LocationCharacteristicId.Smoking => "SMK",
                LocationCharacteristicId.BedIsStaffed => "STF",
                LocationCharacteristicId.TeachingLocation => "TEA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LocationEquipment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LocationEquipment input)
        {
            return input switch
            {
                LocationEquipment.ElectroEncephalogram => "EEG",
                LocationEquipment.ElectroCardiogram => "EKG",
                LocationEquipment.InfusionPump => "INF",
                LocationEquipment.IvPump => "IVP",
                LocationEquipment.Oxygen => "OXY",
                LocationEquipment.Suction => "SUC",
                LocationEquipment.Ventilator => "VEN",
                LocationEquipment.VitalSignsMonitor => "VIT",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LocationRelationshipId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LocationRelationshipId input)
        {
            return input switch
            {
                LocationRelationshipId.LocationAliasEs => "ALI",
                LocationRelationshipId.NearestDietaryLocation => "DTY",
                LocationRelationshipId.NearestLab => "LAB",
                LocationRelationshipId.SecondNearestLab => "LB2",
                LocationRelationshipId.ParentLocation => "PAR",
                LocationRelationshipId.NearestPharmacy => "RX",
                LocationRelationshipId.SecondNearestPharmacy => "RX2",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LocationServiceCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LocationServiceCode input)
        {
            return input switch
            {
                LocationServiceCode.Diagnostic => "D",
                LocationServiceCode.EmergencyRoomCasualty => "E",
                LocationServiceCode.PrimaryCare => "P",
                LocationServiceCode.Therapeutic => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given LotControl enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LotControl input)
        {
            return input switch
            {
                LotControl.OrModeWithoutOperator => "1",
                LotControl.OrModeWithOperator => "2",
                LotControl.CpdModeWithoutOperator => "3",
                LotControl.CpdModeWithOperator => "4",
                LotControl.OfflineMode => "5",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MailClaimParty enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MailClaimParty input)
        {
            return input switch
            {
                MailClaimParty.Employer => "E",
                MailClaimParty.Guarantor => "G",
                MailClaimParty.InsuranceCompany => "I",
                MailClaimParty.Other => "O",
                MailClaimParty.Patient => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ManufacturersOfVaccines enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ManufacturersOfVaccines input)
        {
            return input switch
            {
                ManufacturersOfVaccines.AbbottLaboratories => "AB",
                ManufacturersOfVaccines.AdamsLaboratoriesInc => "AD",
                ManufacturersOfVaccines.AlphaTherapeuticCorporation => "ALP",
                ManufacturersOfVaccines.Armour => "AR",
                ManufacturersOfVaccines.AventisBehringLLC => "AVB",
                ManufacturersOfVaccines.Aviron => "AVI",
                ManufacturersOfVaccines.BaxterHealthcareCorporationDeprecated => "BA",
                ManufacturersOfVaccines.BaxterHealthcareCorporation => "BAH",
                ManufacturersOfVaccines.BayerCorporation => "BAY",
                ManufacturersOfVaccines.BernaProducts => "BP",
                ManufacturersOfVaccines.BernaProductsCorporation => "BPC",
                ManufacturersOfVaccines.CenteonLLC => "CEN",
                ManufacturersOfVaccines.ChironCorporation => "CHI",
                ManufacturersOfVaccines.CelltechMedevaPharmaceuticals => "CMP",
                ManufacturersOfVaccines.CangeneCorporation => "CNJ",
                ManufacturersOfVaccines.Connaught => "CON",
                ManufacturersOfVaccines.DynportVaccineCompanyLlc => "DVC",
                ManufacturersOfVaccines.EvansMedicalLimited => "EVN",
                ManufacturersOfVaccines.GeovaxLabsInc => "GEO",
                ManufacturersOfVaccines.GreerLaboratoriesInc => "GRE",
                ManufacturersOfVaccines.ImmunoInternationalAg => "IAG",
                ManufacturersOfVaccines.Merieux => "IM",
                ManufacturersOfVaccines.ImmunoUSInc => "IUS",
                ManufacturersOfVaccines.ResearchFoundationForMicrobialDiseasesOfOsaka => "JPN",
                ManufacturersOfVaccines.KoreaGreenCrossCorporation => "KGC",
                ManufacturersOfVaccines.Lederle => "LED",
                ManufacturersOfVaccines.MassachusettsPublicHealthBiologicLabs => "MA",
                ManufacturersOfVaccines.MassachusettsBiologicLabs => "MBL",
                ManufacturersOfVaccines.MedimmuneInc => "MED",
                ManufacturersOfVaccines.Miles => "MIL",
                ManufacturersOfVaccines.BioportCorporation => "MIP",
                ManufacturersOfVaccines.MerckCoInc => "MSD",
                ManufacturersOfVaccines.Nabi => "NAB",
                ManufacturersOfVaccines.NorthAmericanVaccineInc => "NAV",
                ManufacturersOfVaccines.NovartisPharmaceuticalCorporation => "NOV",
                ManufacturersOfVaccines.NovavaxInc => "NVX",
                ManufacturersOfVaccines.NewYorkBloodCenter => "NYB",
                ManufacturersOfVaccines.OrthoClinicalDiagnostics => "ORT",
                ManufacturersOfVaccines.OrganonTeknikaCorporation => "OTC",
                ManufacturersOfVaccines.OtherManufacturer => "OTH",
                ManufacturersOfVaccines.ParkedalePharmaceuticals => "PD",
                ManufacturersOfVaccines.SanofiPasteur => "PMC",
                ManufacturersOfVaccines.PraxisBiologics => "PRX",
                ManufacturersOfVaccines.PowderjectPharmaceuticals => "PWJ",
                ManufacturersOfVaccines.SclavoInc => "SCL",
                ManufacturersOfVaccines.SwissSerumAndVaccineInst => "SI",
                ManufacturersOfVaccines.Glaxosmithkline => "SKB",
                ManufacturersOfVaccines.SolvayPharmaceuticals => "SOL",
                ManufacturersOfVaccines.TalecrisBiotherapeutics => "TAL",
                ManufacturersOfVaccines.UnknownManufacturer => "UNK",
                ManufacturersOfVaccines.UsArmyMedicalResearchAndMaterialCommand => "USA",
                ManufacturersOfVaccines.Vaxgen => "VXG",
                ManufacturersOfVaccines.WyethAyerstDeprecated => "WA",
                ManufacturersOfVaccines.WyethAyerst => "WAL",
                ManufacturersOfVaccines.ZlbBehring => "ZLB",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MaritalStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MaritalStatus input)
        {
            return input switch
            {
                MaritalStatus.Separated => "A",
                MaritalStatus.Unmarried => "B",
                MaritalStatus.CommonLaw => "C",
                MaritalStatus.Divorced => "D",
                MaritalStatus.LegallySeparated => "E",
                MaritalStatus.LivingTogether => "G",
                MaritalStatus.Interlocutory => "I",
                MaritalStatus.Married => "M",
                MaritalStatus.Annulled => "N",
                MaritalStatus.Other => "O",
                MaritalStatus.DomesticPartner => "P",
                MaritalStatus.RegisteredDomesticPartner => "R",
                MaritalStatus.Single => "S",
                MaritalStatus.Unreported => "T",
                MaritalStatus.Unknown => "U",
                MaritalStatus.Widowed => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MarketingBasis enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MarketingBasis input)
        {
            return input switch
            {
                MarketingBasis.Basis510KExempt => "510E",
                MarketingBasis.Basis510K => "510K",
                MarketingBasis.PostMarketingStudy522 => "522S",
                MarketingBasis.PremarketingAuthorization => "PMA",
                MarketingBasis.Preamendment => "PRE",
                MarketingBasis.Transitional => "TXN",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MasterfileActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MasterfileActionCode input)
        {
            return input switch
            {
                MasterfileActionCode.ReactivateDeactivatedRecord => "MAC",
                MasterfileActionCode.AddRecordToMasterFile => "MAD",
                MasterfileActionCode.Deactivate => "MDC",
                MasterfileActionCode.DeleteRecordFromMasterFile => "MDL",
                MasterfileActionCode.UpdateRecordForMasterFile => "MUP",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MasterFileIdentifierCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MasterFileIdentifierCode input)
        {
            return input switch
            {
                MasterFileIdentifierCode.ChargeDescriptionMasterFile => "CDM",
                MasterFileIdentifierCode.ClinicMasterFile => "CLN",
                MasterFileIdentifierCode.ClinicalStudyWithPhasesAndScheduledMasterFile => "CMA",
                MasterFileIdentifierCode.ClinicalStudyWithoutPhasesButWithScheduledMasterFile => "CMB",
                MasterFileIdentifierCode.InventoryMasterFile => "INV",
                MasterFileIdentifierCode.LocationMasterFile => "LOC",
                MasterFileIdentifierCode.NumericalObservationMasterFile => "OMA",
                MasterFileIdentifierCode.CategoricalObservationMasterFile => "OMB",
                MasterFileIdentifierCode.ObservationBatteriesMasterFile => "OMC",
                MasterFileIdentifierCode.CalculatedObservationsMasterFile => "OMD",
                MasterFileIdentifierCode.OtherObservationServiceItemMasterFile => "OME",
                MasterFileIdentifierCode.PractitionerMasterFile => "PRA",
                MasterFileIdentifierCode.StaffMasterFile => "STF",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MatchAlgorithms enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MatchAlgorithms input)
        {
            return input switch
            {
                MatchAlgorithms.ProprietaryAlgorithmForLinksoftV201 => "LINKSOFT_2.01",
                MatchAlgorithms.ProprietaryAlgorithmForMatchwareV12 => "MATCHWARE_1.2",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MatchReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MatchReason input)
        {
            return input switch
            {
                MatchReason.MatchOnDateOfBirth => "DB",
                MatchReason.MatchOnNameAlphaMatch => "NA",
                MatchReason.MatchOnNamePhoneticMatch => "NP",
                MatchReason.MatchOnSocialSecurityNumber => "SS",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MedicalRoleExecutingPhysician enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MedicalRoleExecutingPhysician input)
        {
            return input switch
            {
                MedicalRoleExecutingPhysician.Employed => "E",
                MedicalRoleExecutingPhysician.SelfEmployed => "SE",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MessageErrorConditionCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MessageErrorConditionCodes input)
        {
            return input switch
            {
                MessageErrorConditionCodes.MessageAccepted => "0",
                MessageErrorConditionCodes.SegmentSequenceError => "100",
                MessageErrorConditionCodes.RequiredFieldMissing => "101",
                MessageErrorConditionCodes.DataTypeError => "102",
                MessageErrorConditionCodes.TableValueNotFound => "103",
                MessageErrorConditionCodes.ValueTooLong => "104",
                MessageErrorConditionCodes.UnsupportedMessageType => "200",
                MessageErrorConditionCodes.UnsupportedEventCode => "201",
                MessageErrorConditionCodes.UnsupportedProcessingId => "202",
                MessageErrorConditionCodes.UnsupportedVersionId => "203",
                MessageErrorConditionCodes.UnknownKeyIdentifier => "204",
                MessageErrorConditionCodes.DuplicateKeyIdentifier => "205",
                MessageErrorConditionCodes.ApplicationRecordLocked => "206",
                MessageErrorConditionCodes.ApplicationError => "207",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MessageStructure enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MessageStructure input)
        {
            return input switch
            {
                MessageStructure.Varies => "ACK",
                MessageStructure.AdrA19Deprecated => "ADR_A19",
                MessageStructure.A01A04A08A13 => "ADT_A01",
                MessageStructure.A02 => "ADT_A02",
                MessageStructure.A03 => "ADT_A03",
                MessageStructure.A05A14A28A31 => "ADT_A05",
                MessageStructure.A06A07 => "ADT_A06",
                MessageStructure.A09A10A11 => "ADT_A09",
                MessageStructure.A12 => "ADT_A12",
                MessageStructure.A15 => "ADT_A15",
                MessageStructure.A16 => "ADT_A16",
                MessageStructure.A17 => "ADT_A17",
                MessageStructure.AdtA18Deprecated => "ADT_A18",
                MessageStructure.A20 => "ADT_A20",
                MessageStructure.A21A22A23A25A26A27A29A32A33 => "ADT_A21",
                MessageStructure.A24 => "ADT_A24",
                MessageStructure.AdtA30Deprecated => "ADT_A30",
                MessageStructure.A37 => "ADT_A37",
                MessageStructure.A38 => "ADT_A38",
                MessageStructure.A39A40A41A42 => "ADT_A39",
                MessageStructure.A43 => "ADT_A43",
                MessageStructure.A44 => "ADT_A44",
                MessageStructure.A45 => "ADT_A45",
                MessageStructure.A50A51 => "ADT_A50",
                MessageStructure.A52A53 => "ADT_A52",
                MessageStructure.A54A55 => "ADT_A54",
                MessageStructure.A60 => "ADT_A60",
                MessageStructure.A61A62 => "ADT_A61",
                MessageStructure.P01 => "BAR_P01",
                MessageStructure.P02 => "BAR_P02",
                MessageStructure.P05 => "BAR_P05",
                MessageStructure.P06 => "BAR_P06",
                MessageStructure.P10 => "BAR_P10",
                MessageStructure.P12 => "BAR_P12",
                MessageStructure.O29 => "BPS_O29",
                MessageStructure.O30 => "BRP_O30",
                MessageStructure.O32 => "BRT_O32",
                MessageStructure.O31 => "BTS_O31",
                MessageStructure.I22CCF => "CCF_I22",
                MessageStructure.I22CCI => "CCI_I22",
                MessageStructure.I21 => "CCM_I21",
                MessageStructure.I19CCQ => "CCQ_I19",
                MessageStructure.I161718 => "CCR_I16",
                MessageStructure.I20 => "CCU_I20",
                MessageStructure.I19CQU => "CQU_I19",
                MessageStructure.C01C02C03C04C05C06C07C08 => "CRM_C01",
                MessageStructure.C09C10C11C12 => "CSU_C09",
                MessageStructure.P03 => "DFT_P03",
                MessageStructure.P11 => "DFT_P11",
                MessageStructure.DocT12Deprecated => "DOC_T12",
                MessageStructure.U07 => "EAC_U07",
                MessageStructure.U09 => "EAN_U09",
                MessageStructure.U08 => "EAR_U08",
                MessageStructure.E01 => "EHC_E01",
                MessageStructure.E02 => "EHC_E02",
                MessageStructure.E04 => "EHC_E04",
                MessageStructure.E10 => "EHC_E10",
                MessageStructure.E12 => "EHC_E12",
                MessageStructure.E13 => "EHC_E13",
                MessageStructure.E15 => "EHC_E15",
                MessageStructure.E20 => "EHC_E20",
                MessageStructure.E21 => "EHC_E21",
                MessageStructure.E24 => "EHC_E24",
                MessageStructure.U02 => "ESR_U02",
                MessageStructure.U01 => "ESU_U01",
                MessageStructure.U06 => "INR_U06",
                MessageStructure.U05 => "INU_U05",
                MessageStructure.U12U13 => "LSU_U12",
                MessageStructure.T01T03T05T07T09T11 => "MDM_T01",
                MessageStructure.T02T04T06T08T10 => "MDM_T02",
                MessageStructure.M01M02M03M04M05M06M07M08M09M10M11 => "MFK_M01",
                MessageStructure.MfnM01Deprecated => "MFN_M01",
                MessageStructure.M02 => "MFN_M02",
                MessageStructure.M03Deprecated => "MFN_M03",
                MessageStructure.M04 => "MFN_M04",
                MessageStructure.M05 => "MFN_M05",
                MessageStructure.M06 => "MFN_M06",
                MessageStructure.M07 => "MFN_M07",
                MessageStructure.M08 => "MFN_M08",
                MessageStructure.M09 => "MFN_M09",
                MessageStructure.M10 => "MFN_M10",
                MessageStructure.M11 => "MFN_M11",
                MessageStructure.M12 => "MFN_M12",
                MessageStructure.M13 => "MFN_M13",
                MessageStructure.M15 => "MFN_M15",
                MessageStructure.M16 => "MFN_M16",
                MessageStructure.M17 => "MFN_M17",
                MessageStructure.M01M02M03M04M05M06Deprecated => "MFQ_M01",
                MessageStructure.M01M02M03Deprecated => "MFR_M01",
                MessageStructure.M04Deprecated => "MFR_M04",
                MessageStructure.M05Deprecated => "MFR_M05",
                MessageStructure.M06Deprecated => "MFR_M06",
                MessageStructure.M07Deprecated => "MFR_M07",
                MessageStructure.N02 => "NMD_N02",
                MessageStructure.N01NMQDeprecated => "NMQ_N01",
                MessageStructure.N01NMRDeprecated => "NMR_N01",
                MessageStructure.O27 => "OMB_O27",
                MessageStructure.O03 => "OMD_O03",
                MessageStructure.O19 => "OMG_O19",
                MessageStructure.O23 => "OMI_O23",
                MessageStructure.O21 => "OML_O21",
                MessageStructure.O33OML => "OML_O33",
                MessageStructure.O35 => "OML_O35",
                MessageStructure.O39 => "OML_O39",
                MessageStructure.O07 => "OMN_O07",
                MessageStructure.O09 => "OMP_O09",
                MessageStructure.O05 => "OMS_O05",
                MessageStructure.O37 => "OPL_O37",
                MessageStructure.O38 => "OPR_O38",
                MessageStructure.R25 => "OPU_R25",
                MessageStructure.R33 => "ORA_R33",
                MessageStructure.O28 => "ORB_O28",
                MessageStructure.O04 => "ORD_O04",
                MessageStructure.R04Deprecated => "ORF_R04",
                MessageStructure.O20 => "ORG_O20",
                MessageStructure.O24 => "ORI_O24",
                MessageStructure.O22 => "ORL_O22",
                MessageStructure.O34ORL => "ORL_O34",
                MessageStructure.O36 => "ORL_O36",
                MessageStructure.O40 => "ORL_O40",
                MessageStructure.O01ORMDeprecated => "ORM_O01",
                MessageStructure.O08 => "ORN_O08",
                MessageStructure.O10 => "ORP_O10",
                MessageStructure.O02ORRDeprecated => "ORR_O02",
                MessageStructure.O06 => "ORS_O06",
                MessageStructure.R01 => "ORU_R01",
                MessageStructure.R30 => "ORU_R30",
                MessageStructure.W01Deprecated => "ORU_W01",
                MessageStructure.R26 => "OSM_R26",
                MessageStructure.Q06OSQDeprecated => "OSQ_Q06",
                MessageStructure.Q06OSRDeprecated => "OSR_Q06",
                MessageStructure.R21Deprecated => "OUL_R21",
                MessageStructure.R22 => "OUL_R22",
                MessageStructure.R23 => "OUL_R23",
                MessageStructure.R24 => "OUL_R24",
                MessageStructure.P07P08 => "PEX_P07",
                MessageStructure.Pc6Pc7Pc8 => "PGL_PC6",
                MessageStructure.B01B02 => "PMU_B01",
                MessageStructure.B03 => "PMU_B03",
                MessageStructure.B04B05B06 => "PMU_B04",
                MessageStructure.B07 => "PMU_B07",
                MessageStructure.B08 => "PMU_B08",
                MessageStructure.PccPcgPchPcj => "PPG_PCG",
                MessageStructure.PcbPcd => "PPP_PCB",
                MessageStructure.Pc1Pc2Pc3 => "PPR_PC1",
                MessageStructure.PclDeprecated => "PPT_PCL",
                MessageStructure.PcaDeprecated => "PPV_PCA",
                MessageStructure.Pc5Deprecated => "PRR_PC5",
                MessageStructure.PcfDeprecated => "PTR_PCF",
                MessageStructure.E03QBP => "QBP_E03",
                MessageStructure.E22QBP => "QBP_E22",
                MessageStructure.Q11 => "QBP_Q11",
                MessageStructure.Q13 => "QBP_Q13",
                MessageStructure.Q15 => "QBP_Q15",
                MessageStructure.Q21Q22Q23Q24Q25 => "QBP_Q21",
                MessageStructure.QnnDeprecated => "QBP_Qnn",
                MessageStructure.Z73Deprecated => "QBP_Z73",
                MessageStructure.Q02QCKDeprecated => "QCK_Q02",
                MessageStructure.J01J02 => "QCN_J01",
                MessageStructure.W02Deprecated => "QRF_W02",
                MessageStructure.A19QRYDeprecated => "QRY_A19",
                MessageStructure.Pc4Pc9PcePckDeprecated => "QRY_PC4",
                MessageStructure.Q01Q26Q27Q28Q29Q30Deprecated => "QRY_Q01",
                MessageStructure.Q02QRYDeprecated => "QRY_Q02",
                MessageStructure.R02Deprecated => "QRY_R02",
                MessageStructure.T12Deprecated => "QRY_T12",
                MessageStructure.Q16 => "QSB_Q16",
                MessageStructure.Q17 => "QVR_Q17",
                MessageStructure.RarDeprecated => "RAR_RAR",
                MessageStructure.O17 => "RAS_O17",
                MessageStructure.I05Deprecated => "RCI_I05",
                MessageStructure.I06RCLDeprecated => "RCL_I06",
                MessageStructure.O11O25 => "RDE_O11",
                MessageStructure.Rdr => "RDR_RDR",
                MessageStructure.O13 => "RDS_O13",
                MessageStructure.K15 => "RDY_K15",
                MessageStructure.I12I13I14I15REF => "REF_I12",
                MessageStructure.RerDeprecated => "RER_RER",
                MessageStructure.RgrDeprecated => "RGR_RGR",
                MessageStructure.O15 => "RGV_O15",
                MessageStructure.RorDeprecated => "ROR_ROR",
                MessageStructure.I08I09I10I11RPA => "RPA_I08",
                MessageStructure.I01I04 => "RPI_I01",
                MessageStructure.I04RPI => "RPI_I04",
                MessageStructure.I02 => "RPL_I02",
                MessageStructure.I03 => "RPR_I03",
                MessageStructure.I08I09I10I11RQA => "RQA_I08",
                MessageStructure.I05I06Deprecated => "RQC_I05",
                MessageStructure.I01I02I03I07 => "RQI_I01",
                MessageStructure.I04RQP => "RQP_I04",
                MessageStructure.O18 => "RRA_O18",
                MessageStructure.O14 => "RRD_O14",
                MessageStructure.O12O26 => "RRE_O12",
                MessageStructure.O16 => "RRG_O16",
                MessageStructure.I12I13I14I15RRI => "RRI_I12",
                MessageStructure.E03RSP => "RSP_E03",
                MessageStructure.E22RSP => "RSP_E22",
                MessageStructure.K11 => "RSP_K11",
                MessageStructure.K21 => "RSP_K21",
                MessageStructure.K22 => "RSP_K22",
                MessageStructure.K23K24 => "RSP_K23",
                MessageStructure.K25 => "RSP_K25",
                MessageStructure.K31 => "RSP_K31",
                MessageStructure.K32 => "RSP_K32",
                MessageStructure.Q11Deprecated => "RSP_Q11",
                MessageStructure.Z82Deprecated => "RSP_Z82",
                MessageStructure.Z86Deprecated => "RSP_Z86",
                MessageStructure.Z88Deprecated => "RSP_Z88",
                MessageStructure.Z90Deprecated => "RSP_Z90",
                MessageStructure.K13 => "RTB_K13",
                MessageStructure.KnnDeprecated => "RTB_Knn",
                MessageStructure.Z74Deprecated => "RTB_Z74",
                MessageStructure.S31S36 => "SDR_S31",
                MessageStructure.S32S37 => "SDR_S32",
                MessageStructure.S12S13S14S15S16S17S18S19S20S21S22S23S24S26 => "SIU_S12",
                MessageStructure.S28S29S30S34S35 => "SLR_S28",
                MessageStructure.S25SQMDeprecated => "SQM_S25",
                MessageStructure.S25SQRDeprecated => "SQR_S25",
                MessageStructure.S01S02S03S04S05S06S07S08S09S10S11SRM => "SRM_S01",
                MessageStructure.S01S02S03S04S05S06S07S08S09S10S11SRR => "SRR_S01",
                MessageStructure.U04 => "SSR_U04",
                MessageStructure.U03 => "SSU_U03",
                MessageStructure.S33 => "STC_S33",
                MessageStructure.P09SURDeprecated => "SUR_P09",
                MessageStructure.U10U11 => "TCU_U10",
                MessageStructure.Q05 => "UDM_Q05",
                MessageStructure.V01Deprecated => "VXQ_V01",
                MessageStructure.V03Deprecated => "VXR_V03",
                MessageStructure.V04 => "VXU_V04",
                MessageStructure.V02Deprecated => "VXX_V02",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MessageType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MessageType input)
        {
            return input switch
            {
                MessageType.GeneralAcknowledgment => "ACK",
                MessageType.AdtResponseDeprecated => "ADR",
                MessageType.AdtMessage => "ADT",
                MessageType.AddChangeBillingAccount => "BAR",
                MessageType.BloodProductDispenseStatus => "BPS",
                MessageType.BloodProductDispenseStatusAcknowledgement => "BRP",
                MessageType.BloodProductTransfusionDispositionAcknowledgement => "BRT",
                MessageType.BloodProductTransfusionDisposition => "BTS",
                MessageType.CollaborativeCareFetch => "CCF",
                MessageType.CollaborativeCareInformation => "CCI",
                MessageType.CollaborativeCare => "CCM",
                MessageType.CollaborativeCareReferralCcq => "CCQ",
                MessageType.CollaborativeCareReferralCcu => "CCU",
                MessageType.CollaborativeCareReferralCqu => "CQU",
                MessageType.ClinicalStudyRegistration => "CRM",
                MessageType.UnsolicitedStudyData => "CSU",
                MessageType.DetailFinancialTransactions => "DFT",
                MessageType.DocumentResponseDeprecated => "DOC",
                MessageType.DisplayResponseDeprecated => "DSR",
                MessageType.AutomatedEquipmentCommand => "EAC",
                MessageType.AutomatedEquipmentNotification => "EAN",
                MessageType.AutomatedEquipmentResponse => "EAR",
                MessageType.HealthCareInvoice => "EHC",
                MessageType.AutomatedEquipmentStatusUpdateAcknowledgment => "ESR",
                MessageType.AutomatedEquipmentStatusUpdate => "ESU",
                MessageType.AutomatedEquipmentInventoryRequest => "INR",
                MessageType.AutomatedEquipmentInventoryUpdate => "INU",
                MessageType.AutomatedEquipmentLogServiceRequest => "LSR",
                MessageType.AutomatedEquipmentLogServiceUpdate => "LSU",
                MessageType.MedicalDocumentManagement => "MDM",
                MessageType.MasterFilesDelayedApplicationAcknowledgmentDeprecated => "MFD",
                MessageType.MasterFilesApplicationAcknowledgment => "MFK",
                MessageType.MasterFilesNotification => "MFN",
                MessageType.MasterFilesQueryDeprecated => "MFQ",
                MessageType.MasterFilesResponseDeprecated => "MFR",
                MessageType.ApplicationManagementData => "NMD",
                MessageType.ApplicationManagementQueryDeprecated => "NMQ",
                MessageType.ApplicationManagementResponseDeprecated => "NMR",
                MessageType.BloodProductOrder => "OMB",
                MessageType.DietaryOrder => "OMD",
                MessageType.GeneralClinicalOrder => "OMG",
                MessageType.ImagingOrder => "OMI",
                MessageType.LaboratoryOrder => "OML",
                MessageType.NonStockRequisitionOrder => "OMN",
                MessageType.PharmacyTreatmentOrder => "OMP",
                MessageType.StockRequisitionOrder => "OMS",
                MessageType.PopulationLocationBasedLaboratoryOrder => "OPL",
                MessageType.PopulationLocationBasedLaboratoryOrderAcknowledgment => "OPR",
                MessageType.UnsolicitedPopulationLocationBasedLaboratoryObservation => "OPU",
                MessageType.ObservationReportAcknowledgment => "ORA",
                MessageType.BloodProductOrderAcknowledgement => "ORB",
                MessageType.DietaryOrderAcknowledgment => "ORD",
                MessageType.QueryForResultsOfObservationDeprecated => "ORF",
                MessageType.GeneralClinicalOrderAcknowledgment => "ORG",
                MessageType.ImagingOrderAcknowledgement => "ORI",
                MessageType.LaboratoryAcknowledgmentUnsolicited => "ORL",
                MessageType.PharmacyTreatmentOrderDeprecated => "ORM",
                MessageType.NonStockRequisitionGeneralOrderAcknowledgment => "ORN",
                MessageType.PharmacyTreatmentOrderAcknowledgment => "ORP",
                MessageType.GeneralOrderResponseToAnyOrmDeprecated => "ORR",
                MessageType.StockRequisitionOrderAcknowledgment => "ORS",
                MessageType.UnsolicitedTransmissionOfObservation => "ORU",
                MessageType.SpecimenShipment => "OSM",
                MessageType.QueryResponseForOrderStatusOsqDeprecated => "OSQ",
                MessageType.QueryResponseForOrderStatusOsrDeprecated => "OSR",
                MessageType.UnsolicitedLaboratoryObservation => "OUL",
                MessageType.ProductExperience => "PEX",
                MessageType.PatientGoalMessage => "PGL",
                MessageType.PatientInsuranceInformation => "PIN",
                MessageType.AddPersonnelRecord => "PMU",
                MessageType.PatientPathwayGoalOriented => "PPG",
                MessageType.PatientPathwayProblemOriented => "PPP",
                MessageType.PatientProblem => "PPR",
                MessageType.PatientPathwayGoalOrientedResponseDeprecated => "PPT",
                MessageType.PatientGoalResponseDeprecated => "PPV",
                MessageType.PatientProblemResponseDeprecated => "PRR",
                MessageType.PatientPathwayProblemOrientedResponseDeprecated => "PTR",
                MessageType.QueryByParameter => "QBP",
                MessageType.QueryGeneralAcknowledgmentDeprecated => "QCK",
                MessageType.CancelQuery => "QCN",
                MessageType.QueryOriginalMode => "QRY",
                MessageType.CreateSubscription => "QSB",
                MessageType.CancelSubscriptionAcknowledge => "QSX",
                MessageType.QueryForPreviousEvents => "QVR",
                MessageType.PharmacyTreatmentAdministrationInfoDeprecated => "RAR",
                MessageType.PharmacyTreatmentAdministration => "RAS",
                MessageType.ReturnClinicalInformation => "RCI",
                MessageType.ReturnClinicalList => "RCL",
                MessageType.PharmacyTreatmentEncodedOrder => "RDE",
                MessageType.PharmacyTreatmentDispenseInfo => "RDR",
                MessageType.PharmacyTreatmentDispense => "RDS",
                MessageType.DisplayBasedResponse => "RDY",
                MessageType.PatientReferral => "REF",
                MessageType.PharmacyTreatmentEncodedOrderInformationDeprecated => "RER",
                MessageType.PharmacyTreatmentDoseInformationDeprecated => "RGR",
                MessageType.PharmacyTreatmentGive => "RGV",
                MessageType.PharmacyTreatmentOrderResponseDeprecated => "ROR",
                MessageType.ReturnPatientAuthorization => "RPA",
                MessageType.ReturnPatientInfo => "RPI",
                MessageType.ReturnPatientDisplayList => "RPL",
                MessageType.ReturnPatientList => "RPR",
                MessageType.RequestPatientAuthorization => "RQA",
                MessageType.RequestClinicalInformation => "RQC",
                MessageType.RequestPatientInformation => "RQI",
                MessageType.RequestPatientDemographics => "RQP",
                MessageType.PharmacyTreatmentAdministrationAcknowledgment => "RRA",
                MessageType.PharmacyTreatmentDispenseAcknowledgment => "RRD",
                MessageType.PharmacyTreatmentEncodedOrderAcknowledgment => "RRE",
                MessageType.PharmacyTreatmentGiveAcknowledgment => "RRG",
                MessageType.ReturnReferralInfo => "RRI",
                MessageType.SegmentPatternResponse => "RSP",
                MessageType.TabularResponse => "RTB",
                MessageType.NotificationOfAntiMicrobialDeviceCycleData => "SCN",
                MessageType.NotificationOfAntiMicrobialDeviceData => "SDN",
                MessageType.SterilizationAntiMicrobialDeviceDataRequest => "SDR",
                MessageType.ScheduleInfoUnsolicited => "SIU",
                MessageType.NotificationOfNewSterilizationLot => "SLN",
                MessageType.SterilizationLotRequest => "SLR",
                MessageType.SterilizationAntiMicrobialDeviceCycleDataRequest => "SMD",
                MessageType.ScheduleQueryMessageDeprecated => "SQM",
                MessageType.ScheduleQueryResponseDeprecated => "SQR",
                MessageType.ScheduleRequestMessage => "SRM",
                MessageType.ScheduledRequestResponse => "SRR",
                MessageType.SpecimenStatusRequestMessage => "SSR",
                MessageType.SpecimenStatusUpdateMessage => "SSU",
                MessageType.NotificationOfSterilizationConfiguration => "STC",
                MessageType.SterilizationItemRequest => "STI",
                MessageType.SummaryProductExperienceReportDeprecated => "SUR",
                MessageType.TabularDataResponseDeprecated => "TBR",
                MessageType.AutomatedEquipmentTestCodeSettingsRequest => "TCR",
                MessageType.AutomatedEquipmentTestCodeSettingsUpdate => "TCU",
                MessageType.UnsolicitedDisplayUpdateMessage => "UDM",
                MessageType.QueryForVaccinationRecordDeprecated => "VXQ",
                MessageType.VaccinationRecordResponseDeprecated => "VXR",
                MessageType.UnsolicitedVaccinationRecordUpdate => "VXU",
                MessageType.ResponseForVaccinationQueryWithMultiplePidMatchesDeprecated => "VXX",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MessageWaitingPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MessageWaitingPriority input)
        {
            return input switch
            {
                MessageWaitingPriority.High => "H",
                MessageWaitingPriority.Low => "L",
                MessageWaitingPriority.Medium => "M",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MfnRecordLevelErrorReturn enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MfnRecordLevelErrorReturn input)
        {
            return input switch
            {
                MfnRecordLevelErrorReturn.SuccessfulPostingOfTheRecord => "S",
                MfnRecordLevelErrorReturn.UnsuccessfulPostingOfTheRecord => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MilitaryRankGrade enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MilitaryRankGrade input)
        {
            return input switch
            {
                MilitaryRankGrade.Enlisted1 => "E1",
                MilitaryRankGrade.Enlisted1To9 => "E1... E9",
                MilitaryRankGrade.Enlisted2 => "E2",
                MilitaryRankGrade.Enlisted3 => "E3",
                MilitaryRankGrade.Enlisted4 => "E4",
                MilitaryRankGrade.Enlisted5 => "E5",
                MilitaryRankGrade.Enlisted6 => "E6",
                MilitaryRankGrade.Enlisted7 => "E7",
                MilitaryRankGrade.Enlisted8 => "E8",
                MilitaryRankGrade.Enlisted9 => "E9",
                MilitaryRankGrade.Officers1 => "O1",
                MilitaryRankGrade.Officers => "O1 ... O9",
                MilitaryRankGrade.Officers2 => "O2",
                MilitaryRankGrade.Officers3 => "O3",
                MilitaryRankGrade.Officers4 => "O4",
                MilitaryRankGrade.Officers5 => "O5",
                MilitaryRankGrade.Officers6 => "O6",
                MilitaryRankGrade.Officers7 => "O7",
                MilitaryRankGrade.Officers8 => "O8",
                MilitaryRankGrade.Officers9 => "O9",
                MilitaryRankGrade.WarrantOfficers1 => "W1",
                MilitaryRankGrade.WarrantOfficers => "W1 ... W4",
                MilitaryRankGrade.WarrantOfficers2 => "W2",
                MilitaryRankGrade.WarrantOfficers3 => "W3",
                MilitaryRankGrade.WarrantOfficers4 => "W4",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MilitaryService enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MilitaryService input)
        {
            return input switch
            {
                MilitaryService.AustralianArmy => "AUSA",
                MilitaryService.AustralianAirForce => "AUSAF",
                MilitaryService.AustralianNavy => "AUSN",
                MilitaryService.Nato => "NATO",
                MilitaryService.Noaa => "NOAA",
                MilitaryService.UsArmy => "USA",
                MilitaryService.UsAirForce => "USAF",
                MilitaryService.UsCoastGuard => "USCG",
                MilitaryService.UsMarineCorps => "USMC",
                MilitaryService.UsNavy => "USN",
                MilitaryService.UsPublicHealthService => "USPHS",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MilitaryStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MilitaryStatus input)
        {
            return input switch
            {
                MilitaryStatus.ActiveDuty => "ACT",
                MilitaryStatus.Deceased => "DEC",
                MilitaryStatus.Retired => "RET",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MimeTypes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MimeTypes input)
        {
            return input switch
            {
                MimeTypes.ApplicationData => "application",
                MimeTypes.AudioData => "audio",
                MimeTypes.ImageData => "image",
                MimeTypes.ModelData => "model",
                MimeTypes.MimeMultipartPackage => "multipart",
                MimeTypes.TextData => "text",
                MimeTypes.VideoData => "video",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Modality enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(Modality input)
        {
            return input switch
            {
                Modality.Angioscopy => "AS",
                Modality.BiomagneticImaging => "BS",
                Modality.ColorFlowDoppler => "CD",
                Modality.Colposcopy => "CP",
                Modality.ComputedRadiography => "CR",
                Modality.Cystoscopy => "CS",
                Modality.ComputedTomography => "CT",
                Modality.DuplexDoppler => "DD",
                Modality.Diapanography => "DG",
                Modality.DigitalMicroscopy => "DM",
                Modality.Echocardiography => "EC",
                Modality.Endoscopy => "ES",
                Modality.FluoresceinAngiography => "FA",
                Modality.Fundoscopy => "FS",
                Modality.Laparoscopy => "LP",
                Modality.LaserSurfaceScan => "LS",
                Modality.MagneticResonanceAngiography => "MA",
                Modality.MagneticResonanceSpectroscopy => "MS",
                Modality.NuclearMedicine => "NM",
                Modality.Other => "OT",
                Modality.PositronEmissionTomography => "PT",
                Modality.RadioFluoroscopy => "RF",
                Modality.SinglePhotonEmissionComputedTomography => "ST",
                Modality.Thermography => "TG",
                Modality.Ultrasound => "US",
                Modality.XRayAngiography => "XA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ModeOfArrivalCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ModeOfArrivalCode input)
        {
            return input switch
            {
                ModeOfArrivalCode.Ambulance => "A",
                ModeOfArrivalCode.Car => "C",
                ModeOfArrivalCode.OnFoot => "F",
                ModeOfArrivalCode.Helicopter => "H",
                ModeOfArrivalCode.Other => "O",
                ModeOfArrivalCode.PublicTransport => "P",
                ModeOfArrivalCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ModifyIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ModifyIndicator input)
        {
            return input switch
            {
                ModifyIndicator.ModifiedSubscription => "M",
                ModifyIndicator.NewSubscription => "N",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MoneyOrPercentageIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MoneyOrPercentageIndicator input)
        {
            return input switch
            {
                MoneyOrPercentageIndicator.CurrencyAmount => "AT",
                MoneyOrPercentageIndicator.Percentage => "PC",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MoodCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MoodCodes input)
        {
            return input switch
            {
                MoodCodes.Appointment => "APT",
                MoodCodes.AppointmentRequest => "ARQ",
                MoodCodes.Event => "EVN",
                MoodCodes.EventCriterion => "EVN.CRT",
                MoodCodes.Expectation => "EXP",
                MoodCodes.Intent => "INT",
                MoodCodes.Promise => "PRMS",
                MoodCodes.Proposal => "PRP",
                MoodCodes.RequestOrder => "RQO",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given NameAddressRepresentation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(NameAddressRepresentation input)
        {
            return input switch
            {
                NameAddressRepresentation.Alphabetic => "A",
                NameAddressRepresentation.Ideographic => "I",
                NameAddressRepresentation.Phonetic => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given NameAssemblyOrder enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(NameAssemblyOrder input)
        {
            return input switch
            {
                NameAssemblyOrder.PrefixFamilyMiddleGivenSuffix => "F",
                NameAssemblyOrder.PrefixGivenMiddleFamilySuffix => "G",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given NameType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(NameType input)
        {
            return input switch
            {
                NameType.Assigned => "A",
                NameType.BirthName => "B",
                NameType.BadName => "BAD",
                NameType.AdoptedName => "C",
                NameType.CustomaryName => "D",
                NameType.LicensingName => "I",
                NameType.BusinessName => "K",
                NameType.OfficialRegistryName => "L",
                NameType.MaidenName => "M",
                NameType.Masked => "MSK",
                NameType.Nickname => "N",
                NameType.TemporarilyUnavailable => "NAV",
                NameType.NewbornName => "NB",
                NameType.NoLongerToBeUsed => "NOUSE",
                NameType.NameOfPartnerSpouse => "P",
                NameType.RegisteredName => "R",
                NameType.Religious => "REL",
                NameType.Pseudonym => "S",
                NameType.IndigenousTribal => "T",
                NameType.TemporaryName => "TEMP",
                NameType.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given NatureOfAbnormalTesting enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(NatureOfAbnormalTesting input)
        {
            return input switch
            {
                NatureOfAbnormalTesting.AgeBasedPopulation => "A",
                NatureOfAbnormalTesting.Breed => "B",
                NatureOfAbnormalTesting.None => "N",
                NatureOfAbnormalTesting.RaceBasedPopulation => "R",
                NatureOfAbnormalTesting.SexBasedPopulation => "S",
                NatureOfAbnormalTesting.Species => "SP",
                NatureOfAbnormalTesting.Strain => "ST",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given NatureOfChallenge enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(NatureOfChallenge input)
        {
            return input switch
            {
                NatureOfChallenge.FastingForPeriodSpecified => "CFST",
                NatureOfChallenge.ExerciseCanBeQuantified => "EXCZ",
                NatureOfChallenge.NoFluidIntakeForPeriodSpecified => "FFST",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given NatureOfServiceTestObservation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(NatureOfServiceTestObservation input)
        {
            return input switch
            {
                NatureOfServiceTestObservation.AtomicServiceTestObservation => "A",
                NatureOfServiceTestObservation.SingleObservation => "C",
                NatureOfServiceTestObservation.FunctionalProcedure => "F",
                NatureOfServiceTestObservation.ProfileFromAtomicObservation => "P",
                NatureOfServiceTestObservation.Superset => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given NewbornCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(NewbornCode input)
        {
            return input switch
            {
                NewbornCode.BornInFacility => "1",
                NewbornCode.TransferIn => "2",
                NewbornCode.BornEnRoute => "3",
                NewbornCode.Other => "4",
                NewbornCode.BornAtHome => "5",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given NonSubjectConsenterReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(NonSubjectConsenterReason input)
        {
            return input switch
            {
                NonSubjectConsenterReason.LegallyMandated => "LM",
                NonSubjectConsenterReason.SubjectIsAMinor => "MIN",
                NonSubjectConsenterReason.SubjectIsNotCompetentToConsent => "NC",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given NotifyClergyCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(NotifyClergyCode input)
        {
            return input switch
            {
                NotifyClergyCode.LastRitesOnly => "L",
                NotifyClergyCode.No => "N",
                NotifyClergyCode.Other => "O",
                NotifyClergyCode.Unknown => "U",
                NotifyClergyCode.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ObservationResultHandling enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ObservationResultHandling input)
        {
            return input switch
            {
                ObservationResultHandling.FilmWithPatient => "F",
                ObservationResultHandling.NotifyProviderWhenReady => "N",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ObservationResultStatusCodesInterpretation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ObservationResultStatusCodesInterpretation input)
        {
            return input switch
            {
                ObservationResultStatusCodesInterpretation.RecordIsCorrection => "C",
                ObservationResultStatusCodesInterpretation.DeletesTheObxRecord => "D",
                ObservationResultStatusCodesInterpretation.FinalResults => "F",
                ObservationResultStatusCodesInterpretation.SpecimenInLabResultsPending => "I",
                ObservationResultStatusCodesInterpretation.NotAsked => "N",
                ObservationResultStatusCodesInterpretation.OrderDetailDescription => "O",
                ObservationResultStatusCodesInterpretation.PreliminaryResults => "P",
                ObservationResultStatusCodesInterpretation.ResultsEnteredNotVerified => "R",
                ObservationResultStatusCodesInterpretation.PartialResults => "S",
                ObservationResultStatusCodesInterpretation.ResultsChangeToFinalWithoutRetransmit => "U",
                ObservationResultStatusCodesInterpretation.PostOriginalAsWrongEGTransmittedForWrongPatient => "W",
                ObservationResultStatusCodesInterpretation.ResultsCannotBeObtainedForThisObservation => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given OccurrenceCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(OccurrenceCode input)
        {
            return input switch
            {
                OccurrenceCode.UseNubcCodes => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given OccurrenceSpan enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(OccurrenceSpan input)
        {
            return input switch
            {
                OccurrenceSpan.UseNubcCodes => "...",
                OccurrenceSpan.UseNubcCodesDeprecated => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given OrderControlCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(OrderControlCodes input)
        {
            return input switch
            {
                OrderControlCodes.OrderServiceRefillRequestApproval => "AF",
                OrderControlCodes.CancelOrderServiceRequest => "CA",
                OrderControlCodes.ChildOrderService => "CH",
                OrderControlCodes.CombinedResult => "CN",
                OrderControlCodes.CanceledAsRequested => "CR",
                OrderControlCodes.DiscontinueOrderServiceRequest => "DC",
                OrderControlCodes.DataErrors => "DE",
                OrderControlCodes.OrderServiceRefillRequestDenied => "DF",
                OrderControlCodes.DiscontinuedAsRequested => "DR",
                OrderControlCodes.OrderServiceRefilledUnsolicited => "FU",
                OrderControlCodes.HoldOrderRequest => "HD",
                OrderControlCodes.OnHoldAsRequested => "HR",
                OrderControlCodes.LinkOrderToPatientCareProblemOrGoal => "LI",
                OrderControlCodes.MiscellaneousChargeNotAssociatedWithOrder => "MC",
                OrderControlCodes.NumberAssigned => "NA",
                OrderControlCodes.NewOrderService => "NW",
                OrderControlCodes.OrderServiceCanceled => "OC",
                OrderControlCodes.OrderServiceDiscontinued => "OD",
                OrderControlCodes.OrderServiceReleased => "OE",
                OrderControlCodes.OrderServiceRefilledAsRequested => "OF",
                OrderControlCodes.OrderServiceHeld => "OH",
                OrderControlCodes.OrderServiceAcceptedOk => "OK",
                OrderControlCodes.NotificationOfOrderForOutsideDispense => "OP",
                OrderControlCodes.ReleasedAsRequested => "OR",
                OrderControlCodes.ParentOrderService => "PA",
                OrderControlCodes.PreviousResultsWithNewOrderService => "PR",
                OrderControlCodes.NotificationOfReplacementOrderForOutsideDispense => "PY",
                OrderControlCodes.ObservationsPerformedServiceToFollow => "RE",
                OrderControlCodes.RefillOrderServiceRequest => "RF",
                OrderControlCodes.ReleasePreviousHold => "RL",
                OrderControlCodes.ReplacementOrder => "RO",
                OrderControlCodes.OrderServiceReplaceRequest => "RP",
                OrderControlCodes.ReplacedAsRequested => "RQ",
                OrderControlCodes.RequestReceived => "RR",
                OrderControlCodes.ReplacedUnsolicited => "RU",
                OrderControlCodes.StatusChanged => "SC",
                OrderControlCodes.SendOrderServiceNumber => "SN",
                OrderControlCodes.ResponseToSendOrderServiceStatusRequest => "SR",
                OrderControlCodes.SendOrderServiceStatusRequest => "SS",
                OrderControlCodes.UnableToAcceptOrderService => "UA",
                OrderControlCodes.UnableToCancel => "UC",
                OrderControlCodes.UnableToDiscontinue => "UD",
                OrderControlCodes.UnableToRefill => "UF",
                OrderControlCodes.UnableToPutOnHold => "UH",
                OrderControlCodes.UnableToReplace => "UM",
                OrderControlCodes.UnlinkOrderServiceFromPatientCareProblemOrGoal => "UN",
                OrderControlCodes.UnableToRelease => "UR",
                OrderControlCodes.UnableToChange => "UX",
                OrderControlCodes.ChangeOrderServiceRequest => "XO",
                OrderControlCodes.ChangedAsRequested => "XR",
                OrderControlCodes.OrderServiceChangedUnsol => "XX",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given OrderStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(OrderStatus input)
        {
            return input switch
            {
                OrderStatus.SomeButNotAllResultsAvailable => "A",
                OrderStatus.OrderWasCanceled => "CA",
                OrderStatus.OrderIsCompleted => "CM",
                OrderStatus.OrderWasDiscontinued => "DC",
                OrderStatus.ErrorOrderNotFound => "ER",
                OrderStatus.OrderIsOnHold => "HD",
                OrderStatus.InProcessUnspecified => "IP",
                OrderStatus.OrderHasBeenReplaced => "RP",
                OrderStatus.InProcessScheduled => "SC",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given OrderType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(OrderType input)
        {
            return input switch
            {
                OrderType.InpatientOrder => "I",
                OrderType.OutpatientOrder => "O",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given OrganDonorCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(OrganDonorCode input)
        {
            return input switch
            {
                OrganDonorCode.YesPatientIsDonorButDocumentationNotOnFile => "F",
                OrganDonorCode.NoPatientIsNotDonorButInfoWasProvided => "I",
                OrganDonorCode.NoPatientHasNotAgreedToBeDonor => "N",
                OrganDonorCode.PatientLeavesOrganDonationDecisionToSpecificPerson => "P",
                OrganDonorCode.PatientLeavesOrganDonationDecisionToRelatives => "R",
                OrganDonorCode.Unknown => "U",
                OrganDonorCode.YesPatientIsDocumentedDonorAndDocumentationIsOnFile => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given OrganizationAgencyDepartment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(OrganizationAgencyDepartment input)
        {
            return input switch
            {
                OrganizationAgencyDepartment.AmericanExpress => "AE",
                OrganizationAgencyDepartment.DrugEnforcementAgency => "DEA",
                OrganizationAgencyDepartment.DepartmentOfDefense => "DOD",
                OrganizationAgencyDepartment.MasterCard => "MC",
                OrganizationAgencyDepartment.VeteransAffairs => "VA",
                OrganizationAgencyDepartment.Visa => "VI",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given OrganizationalNameType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(OrganizationalNameType input)
        {
            return input switch
            {
                OrganizationalNameType.AliasName => "A",
                OrganizationalNameType.DisplayName => "D",
                OrganizationalNameType.LegalName => "L",
                OrganizationalNameType.StockExchangeListingName => "SL",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given OtherEnvironmentalFactors enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(OtherEnvironmentalFactors input)
        {
            return input switch
            {
                OtherEnvironmentalFactors.OpenedContainerIndoorAtmosphere60MinutesDuration => "A60",
                OtherEnvironmentalFactors.OpenedContainerAtmosphereAndDurationUnspecified => "ATM",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given OutlierType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(OutlierType input)
        {
            return input switch
            {
                OutlierType.OutlierCost => "C",
                OutlierType.OutlierDays => "D",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given OverallClaimDispositionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(OverallClaimDispositionCode input)
        {
            return input switch
            {
                OverallClaimDispositionCode.NoEditsPresentOnClaim => "0",
                OverallClaimDispositionCode.EditsPresentAreForLineItemDenialOrRejection => "1",
                OverallClaimDispositionCode.MultipleDayClaimWithDaysDeniedOrRejected => "2",
                OverallClaimDispositionCode.ClaimDeniedWithOnlyPostPaymentEdits => "3",
                OverallClaimDispositionCode.ClaimDeniedWithOnlyPrePaymentEdits => "4",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Override enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(Override input)
        {
            return input switch
            {
                Override.OverrideAllowed => "A",
                Override.OverrideRequired => "R",
                Override.OverrideNotAllowed => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given OverrideType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(OverrideType input)
        {
            return input switch
            {
                OverrideType.EquivalenceOverride => "EQV",
                OverrideType.ExtensionOverride => "EXTN",
                OverrideType.IntervalOverride => "INLV",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Package enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(Package input)
        {
            return input switch
            {
                Package.Box => "BX",
                Package.Case => "CS",
                Package.Each => "EA",
                Package.Set => "SET",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PackagingStatusCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PackagingStatusCode input)
        {
            return input switch
            {
                PackagingStatusCode.NotPackaged => "0",
                PackagingStatusCode.PackagedService => "1",
                PackagingStatusCode.PackagedAsPartOfPerDiem => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ParticipantOrganizationUnitType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ParticipantOrganizationUnitType input)
        {
            return input switch
            {
                ParticipantOrganizationUnitType.Hospital => "1",
                ParticipantOrganizationUnitType.PhysicianClinic => "2",
                ParticipantOrganizationUnitType.LongTermCare => "3",
                ParticipantOrganizationUnitType.AcuteCare => "4",
                ParticipantOrganizationUnitType.Other => "5",
                ParticipantOrganizationUnitType.Home => "H",
                ParticipantOrganizationUnitType.Office => "O",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Participation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(Participation input)
        {
            return input switch
            {
                Participation.AdmittingProvider => "AD",
                Participation.AssistantAlternateInterpreter => "AI",
                Participation.AdministeringProvider => "AP",
                Participation.AssistantResultInterpreter => "ARI",
                Participation.AttendingProvider => "AT",
                Participation.AuthorEventInitiator => "AUT",
                Participation.ConsultingProvider => "CP",
                Participation.DispensingProvider => "DP",
                Participation.EnteringPerson => "EP",
                Participation.Equipment => "EQUIP",
                Participation.FamilyHealthCareProfessional => "FHCP",
                Participation.MedicalDirector => "MDIR",
                Participation.OrderingProvider => "OP",
                Participation.PackedBy => "PB",
                Participation.Pharmacist => "PH",
                Participation.PrimaryInterpreter => "PI",
                Participation.PerformingOrganization => "PO",
                Participation.PerformingOrganizationMedicalDirector => "POMD",
                Participation.PrimaryCareProvider => "PP",
                Participation.PrincipalResultInterpreter => "PRI",
                Participation.ResultsCopiesTo => "RCT",
                Participation.ResponsibleObserver => "RO",
                Participation.ReferringProvider => "RP",
                Participation.ReferredToProvider => "RT",
                Participation.SendBy => "SB",
                Participation.SpecimenCollector => "SC",
                Participation.Technician => "TN",
                Participation.Transcriptionist => "TR",
                Participation.VerifierVerifyingPerson => "VP",
                Participation.VerifyingPharmaceuticalSupplier => "VPS",
                Participation.VerifyingTreatmentSupplier => "VTS",
                Participation.Waypoint => "WAY",
                Participation.WaypointRecipient => "WAYR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PatientClass enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PatientClass input)
        {
            return input switch
            {
                PatientClass.Obstetrics => "B",
                PatientClass.CommercialAccount => "C",
                PatientClass.Emergency => "E",
                PatientClass.Inpatient => "I",
                PatientClass.NotApplicable => "N",
                PatientClass.Outpatient => "O",
                PatientClass.Preadmit => "P",
                PatientClass.RecurringPatient => "R",
                PatientClass.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PatientConditionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PatientConditionCode input)
        {
            return input switch
            {
                PatientConditionCode.Satisfactory => "A",
                PatientConditionCode.Critical => "C",
                PatientConditionCode.Other => "O",
                PatientConditionCode.Poor => "P",
                PatientConditionCode.Stable => "S",
                PatientConditionCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PatientLocationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PatientLocationType input)
        {
            return input switch
            {
                PatientLocationType.Bed => "B",
                PatientLocationType.Clinic => "C",
                PatientLocationType.Department => "D",
                PatientLocationType.ExamRoom => "E",
                PatientLocationType.OtherLocation => "L",
                PatientLocationType.NursingUnit => "N",
                PatientLocationType.OperatingRoom => "O",
                PatientLocationType.Room => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PatientOutcome enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PatientOutcome input)
        {
            return input switch
            {
                PatientOutcome.Died => "D",
                PatientOutcome.FullyRecovered => "F",
                PatientOutcome.NotRecoveringUnchanged => "N",
                PatientOutcome.Recovering => "R",
                PatientOutcome.Sequelae => "S",
                PatientOutcome.Unknown => "U",
                PatientOutcome.Worsening => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PatientResultsReleaseCategorizationScheme enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PatientResultsReleaseCategorizationScheme input)
        {
            return input switch
            {
                PatientResultsReleaseCategorizationScheme.ShareIn1Day => "SID",
                PatientResultsReleaseCategorizationScheme.ShareIn1DayConditionally => "SIDC",
                PatientResultsReleaseCategorizationScheme.ShareImmediately => "SIMM",
                PatientResultsReleaseCategorizationScheme.ShareToBeDetermined => "STBD",
                PatientResultsReleaseCategorizationScheme.ShareWithinNormalLimits => "SWNL",
                PatientResultsReleaseCategorizationScheme.ShareWithhold => "SWTH",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PatientsRelationshiptoInsured enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PatientsRelationshiptoInsured input)
        {
            return input switch
            {
                PatientsRelationshiptoInsured.PatientIsInsured => "01",
                PatientsRelationshiptoInsured.Spouse => "02",
                PatientsRelationshiptoInsured.NaturalChildInsuredFinancialResponsibility => "03",
                PatientsRelationshiptoInsured.NaturalChildInsuredDoesNotHaveFinancialResponsibility => "04",
                PatientsRelationshiptoInsured.StepChild => "05",
                PatientsRelationshiptoInsured.FosterChild => "06",
                PatientsRelationshiptoInsured.WardOfTheCourt => "07",
                PatientsRelationshiptoInsured.Employee => "08",
                PatientsRelationshiptoInsured.Unknown => "09",
                PatientsRelationshiptoInsured.HandicappedDependent => "10",
                PatientsRelationshiptoInsured.OrganDonor => "11",
                PatientsRelationshiptoInsured.CadaverDonor => "12",
                PatientsRelationshiptoInsured.Grandchild => "13",
                PatientsRelationshiptoInsured.NieceNephew => "14",
                PatientsRelationshiptoInsured.InjuredPlaintiff => "15",
                PatientsRelationshiptoInsured.SponsoredDependent => "16",
                PatientsRelationshiptoInsured.MinorDependentOfAMinorDependent => "17",
                PatientsRelationshiptoInsured.Parent => "18",
                PatientsRelationshiptoInsured.Grandparent => "19",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PatientStatusCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PatientStatusCode input)
        {
            return input switch
            {
                PatientStatusCode.ActiveInpatient => "AI",
                PatientStatusCode.DischargedInpatient => "DI",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PayeeRelationshipToInvoice enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PayeeRelationshipToInvoice input)
        {
            return input switch
            {
                PayeeRelationshipToInvoice.FamilyMember => "FM",
                PayeeRelationshipToInvoice.Guarantor => "GT",
                PayeeRelationshipToInvoice.Patient => "PT",
                PayeeRelationshipToInvoice.Subscriber => "SB",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PayeeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PayeeType input)
        {
            return input switch
            {
                PayeeType.Employer => "EMPL",
                PayeeType.PayeeOrganization => "ORG",
                PayeeType.Person => "PERS",
                PayeeType.PayPerson => "PPER",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PaymentAdjustmentCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PaymentAdjustmentCode input)
        {
            return input switch
            {
                PaymentAdjustmentCode.NoPaymentAdjustment => "1",
                PaymentAdjustmentCode.DesignatedDrugOrBiologicalPaymentAdjustmentAppliesToApc => "2",
                PaymentAdjustmentCode.DesignatedNewDevicePaymentAdjustmentAppliesToApc => "3",
                PaymentAdjustmentCode.DesignatedNewDrugOrNewBiologicalPaymentAdjustmentAppliesToApc => "4",
                PaymentAdjustmentCode.DeductibleNotApplicable => "5",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PaymentMethodCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PaymentMethodCode input)
        {
            return input switch
            {
                PaymentMethodCode.Cash => "CASH",
                PaymentMethodCode.CreditCard => "CCCA",
                PaymentMethodCode.CashiersCheck => "CCHK",
                PaymentMethodCode.CreditDebitAccount => "CDAC",
                PaymentMethodCode.Check => "CHCK",
                PaymentMethodCode.DirectDeposit => "DDPO",
                PaymentMethodCode.DebitCard => "DEBC",
                PaymentMethodCode.SocietyForWorldwideInterbankFinancialTelecom => "SWFT",
                PaymentMethodCode.TravelersCheck => "TRAC",
                PaymentMethodCode.VisaSpecialElectronicFundsTransferNetwork => "VISN",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PersonLocationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PersonLocationType input)
        {
            return input switch
            {
                PersonLocationType.Clinic => "C",
                PersonLocationType.Department => "D",
                PersonLocationType.Home => "H",
                PersonLocationType.NursingUnit => "N",
                PersonLocationType.ProvidersOffice => "O",
                PersonLocationType.Phone => "P",
                PersonLocationType.Snf => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PharmacyOrderTypes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PharmacyOrderTypes input)
        {
            return input switch
            {
                PharmacyOrderTypes.Medication => "M",
                PharmacyOrderTypes.OtherSolutionAsMedicationOrders => "O",
                PharmacyOrderTypes.IvLargeVolumeSolutions => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PolicyType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PolicyType input)
        {
            return input switch
            {
                PolicyType.SecondAncillary => "2ANC",
                PolicyType.SecondMajorMedical => "2MMD",
                PolicyType.ThirdMajorMedical => "3MMD",
                PolicyType.Ancillary => "ANC",
                PolicyType.MajorMedical => "MMD",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PractitionerIdNumberType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PractitionerIdNumberType input)
        {
            return input switch
            {
                PractitionerIdNumberType.CountyNumber => "CY",
                PractitionerIdNumberType.DrugEnforcementAgencyNo => "DEA",
                PractitionerIdNumberType.GeneralLedgerNumber => "GL",
                PractitionerIdNumberType.LaborAndIndustriesNumberDeprecated => "L&I",
                PractitionerIdNumberType.LaborAndIndustriesNumber => "LI",
                PractitionerIdNumberType.MedicaidNumber => "MCD",
                PractitionerIdNumberType.MedicareNumber => "MCR",
                PractitionerIdNumberType.QaNumber => "QA",
                PractitionerIdNumberType.StateLicenseNumber => "SL",
                PractitionerIdNumberType.TaxIdNumber => "TAX",
                PractitionerIdNumberType.TrainingLicenseNumber => "TRL",
                PractitionerIdNumberType.UniquePhysicianIdNo => "UPIN",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PractitionerOrganizationUnitType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PractitionerOrganizationUnitType input)
        {
            return input switch
            {
                PractitionerOrganizationUnitType.Department => "D",
                PractitionerOrganizationUnitType.Facility => "F",
                PractitionerOrganizationUnitType.Subdivision => "S",
                PractitionerOrganizationUnitType.Subdepartment => "U",
                PractitionerOrganizationUnitType.Division => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PrecautionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PrecautionCode input)
        {
            return input switch
            {
                PrecautionCode.Aggressive => "A",
                PrecautionCode.Blind => "B",
                PrecautionCode.Confused => "C",
                PrecautionCode.Deaf => "D",
                PrecautionCode.OnIv => "I",
                PrecautionCode.DoNotResuscitate => "N",
                PrecautionCode.Other => "O",
                PrecautionCode.Paraplegic => "P",
                PrecautionCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PreferredMethodOfContact enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PreferredMethodOfContact input)
        {
            return input switch
            {
                PreferredMethodOfContact.BeeperNumber => "B",
                PreferredMethodOfContact.CellularPhoneNumber => "C",
                PreferredMethodOfContact.EmailAddress => "E",
                PreferredMethodOfContact.FaxNumber => "F",
                PreferredMethodOfContact.HomePhoneNumber => "H",
                PreferredMethodOfContact.OfficePhoneNumber => "O",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PresentOnAdmissionIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PresentOnAdmissionIndicator input)
        {
            return input switch
            {
                PresentOnAdmissionIndicator.Exempt => "E",
                PresentOnAdmissionIndicator.No => "N",
                PresentOnAdmissionIndicator.Unknown => "U",
                PresentOnAdmissionIndicator.NotApplicable => "W",
                PresentOnAdmissionIndicator.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PriceType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PriceType input)
        {
            return input switch
            {
                PriceType.AdministrativePriceOrHandlingFee => "AP",
                PriceType.DirectUnitCost => "DC",
                PriceType.IndirectUnitCost => "IC",
                PriceType.ProfessionalFeeForPerformingProvider => "PF",
                PriceType.TechnologyFeeForUseOfEquipment => "TF",
                PriceType.TotalPrice => "TP",
                PriceType.UnitPrice => "UP",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PrimaryKeyValueType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PrimaryKeyValueType input)
        {
            return input switch
            {
                PrimaryKeyValueType.CodedElement => "CE",
                PrimaryKeyValueType.CodedWithExceptions => "CWE",
                PrimaryKeyValueType.PersonLocation => "PL",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PrimaryObserversQualification enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PrimaryObserversQualification input)
        {
            return input switch
            {
                PrimaryObserversQualification.HealthCareConsumerPatient => "C",
                PrimaryObserversQualification.OtherHealthProfessional => "H",
                PrimaryObserversQualification.LawyerAttorney => "L",
                PrimaryObserversQualification.MidLevelProfessional => "M",
                PrimaryObserversQualification.OtherNonHealthProfessional => "O",
                PrimaryObserversQualification.PhysicianOsteopathHomeopath => "P",
                PrimaryObserversQualification.Pharmacist => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Priority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(Priority input)
        {
            return input switch
            {
                Priority.AsSoonAsPossible => "A",
                Priority.Preoperative => "P",
                Priority.Routine => "R",
                Priority.Stat => "S",
                Priority.TimingCritical => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PrivacyLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PrivacyLevel input)
        {
            return input switch
            {
                PrivacyLevel.Isolation => "F",
                PrivacyLevel.PrivateRoomMedicallyJustified => "J",
                PrivacyLevel.PrivateRoom => "P",
                PrivacyLevel.PrivateRoomDueToOverflow => "Q",
                PrivacyLevel.SemiPrivateRoom => "S",
                PrivacyLevel.Ward => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProblemGoalActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProblemGoalActionCode input)
        {
            return input switch
            {
                ProblemGoalActionCode.Add => "AD",
                ProblemGoalActionCode.Correct => "CO",
                ProblemGoalActionCode.Delete => "DE",
                ProblemGoalActionCode.Link => "LI",
                ProblemGoalActionCode.Unchanged => "UC",
                ProblemGoalActionCode.Unlink => "UN",
                ProblemGoalActionCode.Update => "UP",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProcedureDrgType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProcedureDrgType input)
        {
            return input switch
            {
                ProcedureDrgType.FirstNonOperative => "1",
                ProcedureDrgType.SecondNonOperative => "2",
                ProcedureDrgType.MajorOperative => "3",
                ProcedureDrgType.SecondOperative => "4",
                ProcedureDrgType.ThirdOperative => "5",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProcedureFunctionalType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProcedureFunctionalType input)
        {
            return input switch
            {
                ProcedureFunctionalType.Anesthesia => "A",
                ProcedureFunctionalType.DiagnosticProcedure => "D",
                ProcedureFunctionalType.InvasiveProcedureNotClassified => "I",
                ProcedureFunctionalType.ProcedureForTreatment => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProcedurePriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProcedurePriority input)
        {
            return input switch
            {
                ProcedurePriority.NoSuggestedValuesDefined => "...",
                ProcedurePriority.TheAdmittingProcedure => "0",
                ProcedurePriority.ThePrimaryProcedure => "1",
                ProcedurePriority.ForRankedSecondaryProcedures => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProcessingConsiderationCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProcessingConsiderationCodes input)
        {
            return input switch
            {
                ProcessingConsiderationCodes.DeferredAdjudicationProcessing => "DFADJ",
                ProcessingConsiderationCodes.ElectronicFormToFollow => "EFORM",
                ProcessingConsiderationCodes.FaxToFollow => "FAX",
                ProcessingConsiderationCodes.PaperDocumentationToFollow => "PAPER",
                ProcessingConsiderationCodes.DelayedByAPreviousPayer => "PYRDELAY",
                ProcessingConsiderationCodes.RealTimeAdjudicationProcessing => "RTADJ",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProcessingId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProcessingId input)
        {
            return input switch
            {
                ProcessingId.Debugging => "D",
                ProcessingId.Production => "P",
                ProcessingId.Training => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProcessingMode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProcessingMode input)
        {
            return input switch
            {
                ProcessingMode.Archive => "A",
                ProcessingMode.InitialLoad => "I",
                ProcessingMode.NotPresent => "Not present",
                ProcessingMode.RestoreFromArchive => "R",
                ProcessingMode.CurrentProcessing => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProcessingPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProcessingPriority input)
        {
            return input switch
            {
                ProcessingPriority.AsSoonAsPossible => "A",
                ProcessingPriority.DoAtBedsideOrPortable => "B",
                ProcessingPriority.MeasureContinuously => "C",
                ProcessingPriority.Preoperative => "P",
                ProcessingPriority.Routine => "R",
                ProcessingPriority.Stat => "S",
                ProcessingPriority.TimingCritical => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProcessingType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProcessingType input)
        {
            return input switch
            {
                ProcessingType.Evaluation => "E",
                ProcessingType.RegularProduction => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProductionClassCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProductionClassCode input)
        {
            return input switch
            {
                ProductionClassCode.BreedingGeneticStock => "BR",
                ProductionClassCode.Dairy => "DA",
                ProductionClassCode.Draft => "DR",
                ProductionClassCode.DualPurpose => "DU",
                ProductionClassCode.LayerIncludesMultiplierFlocks => "LY",
                ProductionClassCode.Meat => "MT",
                ProductionClassCode.NotApplicable => "NA",
                ProductionClassCode.Other => "OT",
                ProductionClassCode.Pleasure => "PL",
                ProductionClassCode.Racing => "RA",
                ProductionClassCode.Show => "SH",
                ProductionClassCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProductServicesClarificationCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProductServicesClarificationCodes input)
        {
            return input switch
            {
                ProductServicesClarificationCodes.ClaimCenter => "CLCTR",
                ProductServicesClarificationCodes.DiagnosticApprovalNumber => "DGAPP",
                ProductServicesClarificationCodes.DataCenterNumber => "DTCTR",
                ProductServicesClarificationCodes.EncounterNumber => "ENC",
                ProductServicesClarificationCodes.GoodFaithIndicator => "GFTH",
                ProductServicesClarificationCodes.OutOfProvinceIndicator => "OOP",
                ProductServicesClarificationCodes.SequenceNumber => "SEQ",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProductServiceStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProductServiceStatus input)
        {
            return input switch
            {
                ProductServiceStatus.Denied => "D",
                ProductServiceStatus.Processed => "P",
                ProductServiceStatus.Rejected => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProductSource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProductSource input)
        {
            return input switch
            {
                ProductSource.ActualProductWasEvaluated => "A",
                ProductSource.ProductFromSameLotWasEvaluated => "L",
                ProductSource.ProductFromNonRelatedInventoryWasEvaluated => "N",
                ProductSource.ProductFromReserveWasEvaluated => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProtectionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProtectionCode input)
        {
            return input switch
            {
                ProtectionCode.Listed => "LI",
                ProtectionCode.UnlistedShouldNotAppearInDirectories => "UL",
                ProtectionCode.Unpublished => "UP",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProviderAdjustmentReasonCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProviderAdjustmentReasonCode input)
        {
            return input switch
            {
                ProviderAdjustmentReasonCode.DispensingFee => "DISP",
                ProviderAdjustmentReasonCode.GoodsAndServicesTax => "GST",
                ProviderAdjustmentReasonCode.HarmonizedSalesTax => "HST",
                ProviderAdjustmentReasonCode.MarkUpFee => "MKUP",
                ProviderAdjustmentReasonCode.ProvincialSalesTax => "PST",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProviderBilling enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProviderBilling input)
        {
            return input switch
            {
                ProviderBilling.InstitutionBillsForProvider => "I",
                ProviderBilling.ProviderDoesOwnBilling => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProviderRole enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProviderRole input)
        {
            return input switch
            {
                ProviderRole.Admitting => "AD",
                ProviderRole.AssistantAlternateInterpreter => "AI",
                ProviderRole.AdministeringProvider => "AP",
                ProviderRole.Attending => "AT",
                ProviderRole.CollectingProvider => "CLP",
                ProviderRole.ConsultingProvider => "CP",
                ProviderRole.DispensingProvider => "DP",
                ProviderRole.EnteringProvider => "EP",
                ProviderRole.FamilyHealthCareProfessional => "FHCP",
                ProviderRole.InitiatingProviderAsInActionBy => "IP",
                ProviderRole.MedicalDirector => "MDIR",
                ProviderRole.OrderingProvider => "OP",
                ProviderRole.Pharmacist => "PH",
                ProviderRole.PrimaryInterpreter => "PI",
                ProviderRole.PrimaryCareProvider => "PP",
                ProviderRole.ResponsibleObserver => "RO",
                ProviderRole.ReferringProvider => "RP",
                ProviderRole.ReferredToProvider => "RT",
                ProviderRole.Technician => "TN",
                ProviderRole.Transcriptionist => "TR",
                ProviderRole.VerifyingProvider => "VP",
                ProviderRole.VerifyingPharmaceuticalSupplier => "VPS",
                ProviderRole.VerifyingTreatmentSupplier => "VTS",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PublicityCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PublicityCode input)
        {
            return input switch
            {
                PublicityCode.FamilyOnly => "F",
                PublicityCode.NoPublicity => "N",
                PublicityCode.Other => "O",
                PublicityCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given PurgeStatusCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PurgeStatusCode input)
        {
            return input switch
            {
                PurgeStatusCode.VisitMarkedForDeletion => "D",
                PurgeStatusCode.VisitMarkedInactive => "I",
                PurgeStatusCode.MarkedForPurge => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given QuantityLimitedRequest enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(QuantityLimitedRequest input)
        {
            return input switch
            {
                QuantityLimitedRequest.Characters => "CH",
                QuantityLimitedRequest.Lines => "LI",
                QuantityLimitedRequest.Pages => "PG",
                QuantityLimitedRequest.Records => "RD",
                QuantityLimitedRequest.LocallyDefined => "ZO",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given QuantityMethod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(QuantityMethod input)
        {
            return input switch
            {
                QuantityMethod.ActualCount => "A",
                QuantityMethod.EstimatedSeeComment => "E",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given QueryPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(QueryPriority input)
        {
            return input switch
            {
                QueryPriority.Deferred => "D",
                QueryPriority.Immediate => "I",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given QueryResponseStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(QueryResponseStatus input)
        {
            return input switch
            {
                QueryResponseStatus.ApplicationError => "AE",
                QueryResponseStatus.ApplicationReject => "AR",
                QueryResponseStatus.NoDataFoundNoErrors => "NF",
                QueryResponseStatus.DataFoundNoErrors => "OK",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReadmissionIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReadmissionIndicator input)
        {
            return input switch
            {
                ReadmissionIndicator.ReAdmission => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RecreationalDrugUseCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RecreationalDrugUseCode input)
        {
            return input switch
            {
                RecreationalDrugUseCode.Alcohol => "A",
                RecreationalDrugUseCode.TobaccoChewed => "C",
                RecreationalDrugUseCode.Kava => "K",
                RecreationalDrugUseCode.Marijuana => "M",
                RecreationalDrugUseCode.Other => "O",
                RecreationalDrugUseCode.TobaccoSmoked => "T",
                RecreationalDrugUseCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReferralCategory enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReferralCategory input)
        {
            return input switch
            {
                ReferralCategory.Ambulatory => "A",
                ReferralCategory.Emergency => "E",
                ReferralCategory.Inpatient => "I",
                ReferralCategory.Outpatient => "O",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReferralDisposition enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReferralDisposition input)
        {
            return input switch
            {
                ReferralDisposition.AssumeManagement => "AM",
                ReferralDisposition.ReturnPatientAfterEvaluation => "RP",
                ReferralDisposition.SecondOpinion => "SO",
                ReferralDisposition.SendWrittenReport => "WR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReferralPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReferralPriority input)
        {
            return input switch
            {
                ReferralPriority.Asap => "A",
                ReferralPriority.Routine => "R",
                ReferralPriority.Stat => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReferralReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReferralReason input)
        {
            return input switch
            {
                ReferralReason.ProviderOrdered => "O",
                ReferralReason.PatientPreference => "P",
                ReferralReason.SecondOpinion => "S",
                ReferralReason.WorkLoad => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReferralStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReferralStatus input)
        {
            return input switch
            {
                ReferralStatus.Accepted => "A",
                ReferralStatus.Expired => "E",
                ReferralStatus.Pending => "P",
                ReferralStatus.Rejected => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReferralType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReferralType input)
        {
            return input switch
            {
                ReferralType.HomeCare => "Hom",
                ReferralType.Laboratory => "Lab",
                ReferralType.Medical => "Med",
                ReferralType.Psychiatric => "Psy",
                ReferralType.Radiology => "Rad",
                ReferralType.SkilledNursing => "Skn",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReimbursementActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReimbursementActionCode input)
        {
            return input switch
            {
                ReimbursementActionCode.OceLineItemDenialOrRejectionIsNotIgnored => "0",
                ReimbursementActionCode.OceLineItemDenialOrRejectionIsIgnored => "1",
                ReimbursementActionCode.ExternalLineItemDenial => "2",
                ReimbursementActionCode.ExternalLineItemRejection => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReimbursementTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReimbursementTypeCode input)
        {
            return input switch
            {
                ReimbursementTypeCode.CornealTissueApc => "Crnl",
                ReimbursementTypeCode.DurableMedicalEquipment => "DME",
                ReimbursementTypeCode.Epotein => "EPO",
                ReimbursementTypeCode.ClinicalLaboratoryApc => "Lab",
                ReimbursementTypeCode.ScreeningMammographyApc => "Mamm",
                ReimbursementTypeCode.ThisApcIsNotPaid => "NoPay",
                ReimbursementTypeCode.OutpatientProspectivePaymentSystem => "OPPS",
                ReimbursementTypeCode.PartialHospitalizationApc => "PartH",
                ReimbursementTypeCode.PackagedApc => "Pckg",
                ReimbursementTypeCode.TherapyApc => "Thrpy",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RelatednessAssessment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RelatednessAssessment input)
        {
            return input switch
            {
                RelatednessAssessment.HighlyProbable => "H",
                RelatednessAssessment.Improbable => "I",
                RelatednessAssessment.ModeratelyProbable => "M",
                RelatednessAssessment.NotRelated => "N",
                RelatednessAssessment.SomewhatProbable => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RelationalConjunction enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RelationalConjunction input)
        {
            return input switch
            {
                RelationalConjunction.Default => "AND",
                RelationalConjunction.Or => "OR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RelationalOperator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RelationalOperator input)
        {
            return input switch
            {
                RelationalOperator.Contains => "CT",
                RelationalOperator.Equal => "EQ",
                RelationalOperator.GreaterThanOrEqual => "GE",
                RelationalOperator.Generic => "GN",
                RelationalOperator.GreaterThan => "GT",
                RelationalOperator.LessThanOrEqual => "LE",
                RelationalOperator.LessThan => "LT",
                RelationalOperator.NotEqual => "NE",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Relationship enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(Relationship input)
        {
            return input switch
            {
                Relationship.Associate => "ASC",
                Relationship.Brother => "BRO",
                Relationship.CareGiver => "CGV",
                Relationship.Child => "CHD",
                Relationship.HandicappedDependent => "DEP",
                Relationship.LifePartner => "DOM",
                Relationship.EmergencyContact => "EMC",
                Relationship.Employee => "EME",
                Relationship.Employer => "EMR",
                Relationship.ExtendedFamily => "EXF",
                Relationship.FosterChild => "FCH",
                Relationship.Friend => "FND",
                Relationship.Father => "FTH",
                Relationship.Grandchild => "GCH",
                Relationship.Guardian => "GRD",
                Relationship.Grandparent => "GRP",
                Relationship.Manager => "MGR",
                Relationship.Mother => "MTH",
                Relationship.NaturalChild => "NCH",
                Relationship.None => "NON",
                Relationship.OtherAdult => "OAD",
                Relationship.Other => "OTH",
                Relationship.Owner => "OWN",
                Relationship.Parent => "PAR",
                Relationship.Stepchild => "SCH",
                Relationship.Self => "SEL",
                Relationship.Sibling => "SIB",
                Relationship.Sister => "SIS",
                Relationship.Spouse => "SPO",
                Relationship.Trainer => "TRA",
                Relationship.Unknown => "UNK",
                Relationship.WardOfCourt => "WRD",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RelationshipModifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RelationshipModifier input)
        {
            return input switch
            {
                RelationshipModifier.BloodProductUnit => "BPU",
                RelationshipModifier.Control => "CONTROL",
                RelationshipModifier.Donor => "DONOR",
                RelationshipModifier.Patient => "PATIENT",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Religion enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(Religion input)
        {
            return input switch
            {
                Religion.ChristianAmericanBaptistChurch => "ABC",
                Religion.Agnostic => "AGN",
                Religion.ChristianAfricanMethodistEpiscopalZion => "AME",
                Religion.ChristianAfricanMethodistEpiscopal => "AMT",
                Religion.ChristianAnglican => "ANG",
                Religion.ChristianAssemblyOfGod => "AOG",
                Religion.Atheist => "ATH",
                Religion.Bahai => "BAH",
                Religion.ChristianBaptist => "BAP",
                Religion.BuddhistMahayana => "BMA",
                Religion.BuddhistOther => "BOT",
                Religion.Brethren => "BRE",
                Religion.BuddhistTantrayana => "BTA",
                Religion.BuddhistTheravada => "BTH",
                Religion.Buddhist => "BUD",
                Religion.ChristianRomanCatholic => "CAT",
                Religion.ChineseFolkReligionist => "CFR",
                Religion.Christian => "CHR",
                Religion.ChristianChristianScience => "CHS",
                Religion.ChristianChristianMissionaryAlliance => "CMA",
                Religion.Confucian => "CNF",
                Religion.ChristianChurchOfChrist => "COC",
                Religion.ChristianChurchOfGod => "COG",
                Religion.ChristianChurchOfGodInChrist => "COI",
                Religion.ChristianCongregational => "COL",
                Religion.ChristianCommunity => "COM",
                Religion.ChristianOtherPentecostal => "COP",
                Religion.ChristianOther => "COT",
                Religion.ChristianChristianReformed => "CRR",
                Religion.DisciplesOfChrist => "DOC",
                Religion.ChristianEasternOrthodox => "EOT",
                Religion.ChristianEpiscopalian => "EPI",
                Religion.EthnicReligionist => "ERL",
                Religion.ChristianEvangelicalChurch => "EVC",
                Religion.ChristianFriends => "FRQ",
                Religion.ChristianFullGospel => "FUL",
                Religion.ChristianFreeWillBaptist => "FWB",
                Religion.ChristianGreekOrthodox => "GRE",
                Religion.Hindu => "HIN",
                Religion.HinduOther => "HOT",
                Religion.HinduShaivites => "HSH",
                Religion.HinduVaishnavites => "HVA",
                Religion.Jain => "JAI",
                Religion.JewishConservative => "JCO",
                Religion.Jewish => "JEW",
                Religion.JewishOrthodox => "JOR",
                Religion.JewishOther => "JOT",
                Religion.JewishReconstructionist => "JRC",
                Religion.JewishReform => "JRF",
                Religion.JewishRenewal => "JRN",
                Religion.ChristianJehovahsWitness => "JWN",
                Religion.ChristianLutheranMissouriSynod => "LMS",
                Religion.ChristianLutheran => "LUT",
                Religion.ChristianMennonite => "MEN",
                Religion.ChristianMethodist => "MET",
                Religion.ChristianLatterDaySaints => "MOM",
                Religion.Muslim => "MOS",
                Religion.MuslimOther => "MOT",
                Religion.MuslimShiite => "MSH",
                Religion.MuslimSunni => "MSU",
                Religion.NativeAmerican => "NAM",
                Religion.ChristianChurchOfTheNazarene => "NAZ",
                Religion.Nonreligious => "NOE",
                Religion.NewReligionist => "NRL",
                Religion.ChristianOrthodox => "ORT",
                Religion.Other => "OTH",
                Religion.ChristianPentecostal => "PEN",
                Religion.ChristianOtherProtestant => "PRC",
                Religion.ChristianPresbyterian => "PRE",
                Religion.ChristianProtestant => "PRO",
                Religion.ChristianReformedChurch => "REC",
                Religion.ChristianReorganizedChurchOfJesusChristLds => "REO",
                Religion.ChristianSalvationArmy => "SAA",
                Religion.ChristianSeventhDayAdventist => "SEV",
                Religion.Shintoist => "SHN",
                Religion.Sikh => "SIK",
                Religion.ChristianSouthernBaptist => "SOU",
                Religion.Spiritist => "SPI",
                Religion.ChristianUnitedChurchOfChrist => "UCC",
                Religion.ChristianUnitedMethodist => "UMD",
                Religion.ChristianUnitarian => "UNI",
                Religion.ChristianUnitarianUniversalist => "UNU",
                Religion.Unknown => "VAR",
                Religion.ChristianWesleyan => "WES",
                Religion.ChristianWesleyanMethodist => "WMC",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RemoteControlCommand enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RemoteControlCommand input)
        {
            return input switch
            {
                RemoteControlCommand.Abort => "AB",
                RemoteControlCommand.Clear => "CL",
                RemoteControlCommand.ClearNotification => "CN",
                RemoteControlCommand.DisableSendingEvents => "DI",
                RemoteControlCommand.EnableSendingEvents => "EN",
                RemoteControlCommand.EmergencyStop => "ES",
                RemoteControlCommand.Execute => "EX",
                RemoteControlCommand.Initialize => "IN",
                RemoteControlCommand.LocalControlRequest => "LC",
                RemoteControlCommand.Lock => "LK",
                RemoteControlCommand.Load => "LO",
                RemoteControlCommand.Pause => "PA",
                RemoteControlCommand.RemoteControlRequest => "RC",
                RemoteControlCommand.Resume => "RE",
                RemoteControlCommand.Sampling => "SA",
                RemoteControlCommand.Setup => "SU",
                RemoteControlCommand.TransportTo => "TT",
                RemoteControlCommand.Unlock => "UC",
                RemoteControlCommand.Unload => "UN",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReorderTheoryCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReorderTheoryCodes input)
        {
            return input switch
            {
                ReorderTheoryCodes.DopDoq => "D",
                ReorderTheoryCodes.MinMax => "M",
                ReorderTheoryCodes.Override => "O",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RepeatPattern enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RepeatPattern input)
        {
            return input switch
            {
                RepeatPattern.AnteBefore => "A",
                RepeatPattern.TwiceADay => "BID",
                RepeatPattern.ServiceProvidedContinuouslyBetweenStartAndStopTime => "C",
                RepeatPattern.CibusDiurnusLunch => "D",
                RepeatPattern.Inter => "I",
                RepeatPattern.CibusMatutinusBreakfast => "M",
                RepeatPattern.TimingcCumMeal => "Meal Related Timings",
                RepeatPattern.OneTimeOnly => "Once",
                RepeatPattern.PostAfter => "P",
                RepeatPattern.GivenAsNeeded => "PRN",
                RepeatPattern.WhereXxxIsSomeFrequencyCode => "PRNxxx",
                RepeatPattern.EveryIntegerDays => "QintegerD",
                RepeatPattern.EveryIntegerHours => "QintegerH",
                RepeatPattern.RepeatsOnParticularDayOfTheWeek => "QintegerJday#",
                RepeatPattern.EveryIntegerMonthsLunarCycle => "QintegerL",
                RepeatPattern.EveryIntegerMinutes => "QintegerM",
                RepeatPattern.EveryIntegerSeconds => "QintegerS",
                RepeatPattern.EveryIntegerWeeks => "QintegerW",
                RepeatPattern.InTheMorning => "QAM",
                RepeatPattern.EveryDayBeforeTheHourOfSleep => "QHS",
                RepeatPattern.FourTimesDay => "QID",
                RepeatPattern.EveryOtherDay => "QOD",
                RepeatPattern.InTheEvening => "QPM",
                RepeatPattern.DuringEachOfThreeEightHourShifts => "QSHIFT",
                RepeatPattern.ThreeTimesADay => "TID",
                RepeatPattern.UnixCron => "U spec",
                RepeatPattern.CibusVespertinusDinner => "V",
                RepeatPattern.XTimesPerDay => "xID",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReportingPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReportingPriority input)
        {
            return input switch
            {
                ReportingPriority.CallBackResults => "C",
                ReportingPriority.RushReporting => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReportSource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReportSource input)
        {
            return input switch
            {
                ReportSource.ClinicalTrial => "C",
                ReportSource.DatabaseRegistryPoisonControlCenter => "D",
                ReportSource.Distributor => "E",
                ReportSource.HealthProfessional => "H",
                ReportSource.Literature => "L",
                ReportSource.ManufacturerMarketingAuthorityHolder => "M",
                ReportSource.NonHealthcareProfessional => "N",
                ReportSource.Other => "O",
                ReportSource.Patient => "P",
                ReportSource.RegulatoryAgency => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ReportTiming enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReportTiming input)
        {
            return input switch
            {
                ReportTiming.TenDayReport => "10D",
                ReportTiming.FifteenDayReport => "15D",
                ReportTiming.ThirtyDayReport => "30D",
                ReportTiming.ThreeDayReport => "3D",
                ReportTiming.SevenDayReport => "7D",
                ReportTiming.AdditionalInformation => "AD",
                ReportTiming.Correction => "CO",
                ReportTiming.DeviceEvaluation => "DE",
                ReportTiming.Periodic => "PD",
                ReportTiming.RequestedInformation => "RQ",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ResponseFlag enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ResponseFlag input)
        {
            return input switch
            {
                ResponseFlag.AlsoOtherAssociatedSegments => "D",
                ResponseFlag.ReportExceptionsOnly => "E",
                ResponseFlag.PlusConfirmationsExplicitly => "F",
                ResponseFlag.OnlyMsaSegmentIsReturned => "N",
                ResponseFlag.ReplacementAndParentChild => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ResponseLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ResponseLevel input)
        {
            return input switch
            {
                ResponseLevel.Always => "AL",
                ResponseLevel.ErrorReject => "ER",
                ResponseLevel.Never => "NE",
                ResponseLevel.Success => "SU",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ResponseModality enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ResponseModality input)
        {
            return input switch
            {
                ResponseModality.Batch => "B",
                ResponseModality.RealTime => "R",
                ResponseModality.Bolus => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ResultStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ResultStatus input)
        {
            return input switch
            {
                ResultStatus.SomeResultsAvailable => "A",
                ResultStatus.CorrectedFinal => "C",
                ResultStatus.FinalResults => "F",
                ResultStatus.NoResultsAvailableSpecimenReceivedProcedureIncomplete => "I",
                ResultStatus.OrderReceivedSpecimenNotYetReceived => "O",
                ResultStatus.Preliminary => "P",
                ResultStatus.ResultsStoredNotYetVerified => "R",
                ResultStatus.NoResultsAvailableProcedureScheduledButNotDone => "S",
                ResultStatus.NoResultsAvailableOrderCanceled => "X",
                ResultStatus.NoOrderOnRecordForThisTest => "Y",
                ResultStatus.NoRecordOfThisPatient => "Z",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RevenueCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RevenueCode input)
        {
            return input switch
            {
                RevenueCode.NoSuggestedValuesDefined => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RiskCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RiskCodes input)
        {
            return input switch
            {
                RiskCodes.Aggressive => "AGG",
                RiskCodes.Biohazard => "BHZ",
                RiskCodes.Biological => "BIO",
                RiskCodes.Corrosive => "COR",
                RiskCodes.EscapeRisk => "ESC",
                RiskCodes.Explosive => "EXP",
                RiskCodes.Materialdangerinflammable => "IFL",
                RiskCodes.Materialdangerinfectious => "INF",
                RiskCodes.InjuryHazard => "INJ",
                RiskCodes.Poison => "POI",
                RiskCodes.Radioactive => "RAD",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RiskManagementIncidentCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RiskManagementIncidentCode input)
        {
            return input switch
            {
                RiskManagementIncidentCode.BodyFluidExposure => "B",
                RiskManagementIncidentCode.ContaminatedSubstance => "C",
                RiskManagementIncidentCode.DietErrors => "D",
                RiskManagementIncidentCode.EquipmentProblem => "E",
                RiskManagementIncidentCode.PatientFellNotFromBed => "F",
                RiskManagementIncidentCode.PatientFellFromBed => "H",
                RiskManagementIncidentCode.InfusionError => "I",
                RiskManagementIncidentCode.ForeignObjectLeftDuringSurgery => "J",
                RiskManagementIncidentCode.SterilePrecautionViolated => "K",
                RiskManagementIncidentCode.Other => "O",
                RiskManagementIncidentCode.ProcedureError => "P",
                RiskManagementIncidentCode.PharmaceuticalError => "R",
                RiskManagementIncidentCode.SuicideAttempt => "S",
                RiskManagementIncidentCode.TransfusionError => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RoleExecutingPhysician enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RoleExecutingPhysician input)
        {
            return input switch
            {
                RoleExecutingPhysician.Both => "B",
                RoleExecutingPhysician.ProfessionalPart => "P",
                RoleExecutingPhysician.TechnicalPart => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RoomType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RoomType input)
        {
            return input switch
            {
                RoomType.SecondIntensiveCareUnit => "2ICU",
                RoomType.SecondPrivateRoom => "2PRI",
                RoomType.SecondSemiPrivateRoom => "2SPR",
                RoomType.IntensiveCareUnit => "ICU",
                RoomType.PrivateRoom => "PRI",
                RoomType.SemiPrivateRoom => "SPR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RouteOfAdministration enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RouteOfAdministration input)
        {
            return input switch
            {
                RouteOfAdministration.ApplyExternally => "AP",
                RouteOfAdministration.Buccal => "B",
                RouteOfAdministration.Dental => "DT",
                RouteOfAdministration.Epidural => "EP",
                RouteOfAdministration.EndotrachialTube => "ET",
                RouteOfAdministration.GastrostomyTube => "GTT",
                RouteOfAdministration.GuIrrigant => "GU",
                RouteOfAdministration.IntraArterial => "IA",
                RouteOfAdministration.Intrabursal => "IB",
                RouteOfAdministration.Intracardiac => "IC",
                RouteOfAdministration.Intracervical => "ICV",
                RouteOfAdministration.Intradermal => "ID",
                RouteOfAdministration.Inhalation => "IH",
                RouteOfAdministration.IntrahepaticArtery => "IHA",
                RouteOfAdministration.Intramuscular => "IM",
                RouteOfAdministration.ImmerseBodyPart => "IMR",
                RouteOfAdministration.Intranasal => "IN",
                RouteOfAdministration.Intraocular => "IO",
                RouteOfAdministration.Intraperitoneal => "IP",
                RouteOfAdministration.Intrasynovial => "IS",
                RouteOfAdministration.Intrathecal => "IT",
                RouteOfAdministration.Intrauterine => "IU",
                RouteOfAdministration.Intravenous => "IV",
                RouteOfAdministration.MucousMembrane => "MM",
                RouteOfAdministration.MouthThroat => "MTH",
                RouteOfAdministration.Nasogastric => "NG",
                RouteOfAdministration.NasalProngs => "NP",
                RouteOfAdministration.Nasal => "NS",
                RouteOfAdministration.NasotrachialTube => "NT",
                RouteOfAdministration.Ophthalmic => "OP",
                RouteOfAdministration.Otic => "OT",
                RouteOfAdministration.OtherMiscellaneous => "OTH",
                RouteOfAdministration.Perfusion => "PF",
                RouteOfAdministration.Oral => "PO",
                RouteOfAdministration.Rectal => "PR",
                RouteOfAdministration.RebreatherMask => "RM",
                RouteOfAdministration.Subcutaneous => "SC",
                RouteOfAdministration.SoakedDressing => "SD",
                RouteOfAdministration.Sublingual => "SL",
                RouteOfAdministration.Transdermal => "TD",
                RouteOfAdministration.Translingual => "TL",
                RouteOfAdministration.Topical => "TP",
                RouteOfAdministration.Tracheostomy => "TRA",
                RouteOfAdministration.Urethral => "UR",
                RouteOfAdministration.Vaginal => "VG",
                RouteOfAdministration.Ventimask => "VM",
                RouteOfAdministration.Wound => "WND",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RulingAct enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RulingAct input)
        {
            return input switch
            {
                RulingAct.SafeMedicalDevicesAct => "SMDA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RXComponentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(RXComponentType input)
        {
            return input switch
            {
                RXComponentType.Additive => "A",
                RXComponentType.Base => "B",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SchoolType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SchoolType input)
        {
            return input switch
            {
                SchoolType.Dental => "D",
                SchoolType.Graduate => "G",
                SchoolType.Medical => "M",
                SchoolType.Undergraduate => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SecurityCheckScheme enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SecurityCheckScheme input)
        {
            return input switch
            {
                SecurityCheckScheme.BankCardValidationNumber => "BCV",
                SecurityCheckScheme.CreditCardSecurityCode => "CCS",
                SecurityCheckScheme.VersionId => "VID",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SegmentActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SegmentActionCode input)
        {
            return input switch
            {
                SegmentActionCode.AddInsert => "A",
                SegmentActionCode.Delete => "D",
                SegmentActionCode.Update => "U",
                SegmentActionCode.NoChange => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SegmentGroup enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SegmentGroup input)
        {
            return input switch
            {
                SegmentGroup.Administration => "ADMINISTRATION",
                SegmentGroup.Allergy => "ALLERGY",
                SegmentGroup.AppStats => "APP_STATS",
                SegmentGroup.AppStatus => "APP_STATUS",
                SegmentGroup.AssociatedPerson => "ASSOCIATED_PERSON",
                SegmentGroup.AssociatedRxAdmin => "ASSOCIATED_RX_ADMIN",
                SegmentGroup.AssociatedRxOrder => "ASSOCIATED_RX_ORDER",
                SegmentGroup.Authorization => "AUTHORIZATION",
                SegmentGroup.AuthorizationContact => "AUTHORIZATION_CONTACT",
                SegmentGroup.Certificate => "CERTIFICATE",
                SegmentGroup.Clock => "CLOCK",
                SegmentGroup.ClockAndStatistics => "CLOCK_AND_STATISTICS",
                SegmentGroup.ClockAndStatsWithNote => "CLOCK_AND_STATS_WITH_NOTE",
                SegmentGroup.Command => "COMMAND",
                SegmentGroup.CommandResponse => "COMMAND_RESPONSE",
                SegmentGroup.CommonOrder => "COMMON_ORDER",
                SegmentGroup.Component => "COMPONENT",
                SegmentGroup.Components => "COMPONENTS",
                SegmentGroup.Container => "CONTAINER",
                SegmentGroup.Definition => "DEFINITION",
                SegmentGroup.Diet => "DIET",
                SegmentGroup.Dispense => "DISPENSE",
                SegmentGroup.EncodedOrder => "ENCODED_ORDER",
                SegmentGroup.Encoding => "ENCODING",
                SegmentGroup.Experience => "EXPERIENCE",
                SegmentGroup.Financial => "FINANCIAL",
                SegmentGroup.FinancialCommonOrder => "FINANCIAL_COMMON_ORDER",
                SegmentGroup.FinancialInsurance => "FINANCIAL_INSURANCE",
                SegmentGroup.FinancialObservation => "FINANCIAL_OBSERVATION",
                SegmentGroup.FinancialOrder => "FINANCIAL_ORDER",
                SegmentGroup.FinancialProcedure => "FINANCIAL_PROCEDURE",
                SegmentGroup.FinancialTimingQuantity => "FINANCIAL_TIMING_QUANTITY",
                SegmentGroup.GeneralResource => "GENERAL_RESOURCE",
                SegmentGroup.Give => "GIVE",
                SegmentGroup.Goal => "GOAL",
                SegmentGroup.GoalObservation => "GOAL_OBSERVATION",
                SegmentGroup.GoalPathway => "GOAL_PATHWAY",
                SegmentGroup.GoalRole => "GOAL_ROLE",
                SegmentGroup.GuarantorInsurance => "GUARANTOR_INSURANCE",
                SegmentGroup.Insurance => "INSURANCE",
                SegmentGroup.LocationResource => "LOCATION_RESOURCE",
                SegmentGroup.MergeInfo => "MERGE_INFO",
                SegmentGroup.Mf => "MF",
                SegmentGroup.MfCdm => "MF_CDM",
                SegmentGroup.MfClinStudy => "MF_CLIN_STUDY",
                SegmentGroup.MfClinStudySched => "MF_CLIN_STUDY_SCHED",
                SegmentGroup.MfInvItem => "MF_INV_ITEM",
                SegmentGroup.MfLocation => "MF_LOCATION",
                SegmentGroup.MfLocDept => "MF_LOC_DEPT",
                SegmentGroup.MfObsAttributes => "MF_OBS_ATTRIBUTES",
                SegmentGroup.MfPhaseSchedDetail => "MF_PHASE_SCHED_DETAIL",
                SegmentGroup.MfQuery => "MF_QUERY",
                SegmentGroup.MfSiteDefined => "MF_SITE_DEFINED",
                SegmentGroup.MfStaff => "MF_STAFF",
                SegmentGroup.MfTest => "MF_TEST",
                SegmentGroup.MfTestBatteries => "MF_TEST_BATTERIES",
                SegmentGroup.MfTestBattDetail => "MF_TEST_BATT_DETAIL",
                SegmentGroup.MfTestCalculated => "MF_TEST_CALCULATED",
                SegmentGroup.MfTestCalcDetail => "MF_TEST_CALC_DETAIL",
                SegmentGroup.MfTestCategorical => "MF_TEST_CATEGORICAL",
                SegmentGroup.MfTestCatDetail => "MF_TEST_CAT_DETAIL",
                SegmentGroup.MfTestNumeric => "MF_TEST_NUMERIC",
                SegmentGroup.Nk1TimingQty => "NK1_TIMING_QTY",
                SegmentGroup.Notification => "NOTIFICATION",
                SegmentGroup.Observation => "OBSERVATION",
                SegmentGroup.ObservationPrior => "OBSERVATION_PRIOR",
                SegmentGroup.ObservationRequest => "OBSERVATION_REQUEST",
                SegmentGroup.Omservation => "OMSERVATION",
                SegmentGroup.Order => "ORDER",
                SegmentGroup.OrderChoice => "ORDER_CHOICE",
                SegmentGroup.OrderDetail => "ORDER_DETAIL",
                SegmentGroup.OrderDetailSupplement => "ORDER_DETAIL_SUPPLEMENT",
                SegmentGroup.OrderDiet => "ORDER_DIET",
                SegmentGroup.OrderEncoded => "ORDER_ENCODED",
                SegmentGroup.OrderObservation => "ORDER_OBSERVATION",
                SegmentGroup.OrderPrior => "ORDER_PRIOR",
                SegmentGroup.OrderTray => "ORDER_TRAY",
                SegmentGroup.Pathway => "PATHWAY",
                SegmentGroup.PathwayRole => "PATHWAY_ROLE",
                SegmentGroup.Patient => "PATIENT",
                SegmentGroup.PatientPrior => "PATIENT_PRIOR",
                SegmentGroup.PatientResult => "PATIENT_RESULT",
                SegmentGroup.PatientVisit => "PATIENT_VISIT",
                SegmentGroup.PatientVisitPrior => "PATIENT_VISIT_PRIOR",
                SegmentGroup.PersonnelResource => "PERSONNEL_RESOURCE",
                SegmentGroup.PexCause => "PEX_CAUSE",
                SegmentGroup.PexObservation => "PEX_OBSERVATION",
                SegmentGroup.PriorResult => "PRIOR_RESULT",
                SegmentGroup.Problem => "PROBLEM",
                SegmentGroup.ProblemObservation => "PROBLEM_OBSERVATION",
                SegmentGroup.ProblemPathway => "PROBLEM_PATHWAY",
                SegmentGroup.ProblemRole => "PROBLEM_ROLE",
                SegmentGroup.Procedure => "PROCEDURE",
                SegmentGroup.Product => "PRODUCT",
                SegmentGroup.ProductStatus => "PRODUCT_STATUS",
                SegmentGroup.Provider => "PROVIDER",
                SegmentGroup.ProviderContact => "PROVIDER_CONTACT",
                SegmentGroup.Qbp => "QBP",
                SegmentGroup.QryWithDetail => "QRY_WITH_DETAIL",
                SegmentGroup.QueryResponse => "QUERY_RESPONSE",
                SegmentGroup.QueryResultCluster => "QUERY_RESULT_CLUSTER",
                SegmentGroup.Request => "REQUEST",
                SegmentGroup.Resource => "RESOURCE",
                SegmentGroup.Resources => "RESOURCES",
                SegmentGroup.Response => "RESPONSE",
                SegmentGroup.Result => "RESULT",
                SegmentGroup.Results => "RESULTS",
                SegmentGroup.ResultsNotes => "RESULTS_NOTES",
                SegmentGroup.RowDefinition => "ROW_DEFINITION",
                SegmentGroup.RxAdministration => "RX_ADMINISTRATION",
                SegmentGroup.RxOrder => "RX_ORDER",
                SegmentGroup.Schedule => "SCHEDULE",
                SegmentGroup.Service => "SERVICE",
                SegmentGroup.Specimen => "SPECIMEN",
                SegmentGroup.SpecimenContainer => "SPECIMEN_CONTAINER",
                SegmentGroup.Staff => "STAFF",
                SegmentGroup.Study => "STUDY",
                SegmentGroup.StudyObservation => "STUDY_OBSERVATION",
                SegmentGroup.StudyPhase => "STUDY_PHASE",
                SegmentGroup.StudySchedule => "STUDY_SCHEDULE",
                SegmentGroup.TestConfiguration => "TEST_CONFIGURATION",
                SegmentGroup.Timing => "TIMING",
                SegmentGroup.TimingDiet => "TIMING_DIET",
                SegmentGroup.TimingEncoded => "TIMING_ENCODED",
                SegmentGroup.TimingGive => "TIMING_GIVE",
                SegmentGroup.TimingPrior => "TIMING_PRIOR",
                SegmentGroup.TimingQty => "TIMING_QTY",
                SegmentGroup.TimingQuantity => "TIMING_QUANTITY",
                SegmentGroup.TimingTray => "TIMING_TRAY",
                SegmentGroup.Treatment => "TREATMENT",
                SegmentGroup.Visit => "VISIT",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SensitivityToCausativeAgentCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SensitivityToCausativeAgentCode input)
        {
            return input switch
            {
                SensitivityToCausativeAgentCode.AdverseReaction => "AD",
                SensitivityToCausativeAgentCode.Allergy => "AL",
                SensitivityToCausativeAgentCode.Contraindication => "CT",
                SensitivityToCausativeAgentCode.Intolerance => "IN",
                SensitivityToCausativeAgentCode.SideEffect => "SE",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SequenceConditionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SequenceConditionCode input)
        {
            return input switch
            {
                SequenceConditionCode.EndRelatedEndCurrent => "EE",
                SequenceConditionCode.EndRelatedStartCurrent => "ES",
                SequenceConditionCode.StartRelatedEndCurrent => "SE",
                SequenceConditionCode.StartRelatedStartCurrent => "SS",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SequenceResultsFlag enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SequenceResultsFlag input)
        {
            return input switch
            {
                SequenceResultsFlag.Cyclical => "C",
                SequenceResultsFlag.ReservedForFutureUse => "R",
                SequenceResultsFlag.Sequential => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Sequencing enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(Sequencing input)
        {
            return input switch
            {
                Sequencing.Ascending => "A",
                Sequencing.AscendingCaseInsensitive => "AN",
                Sequencing.Descending => "D",
                Sequencing.DescendingCaseInsensitive => "DN",
                Sequencing.None => "N",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ServiceRequestRelationship enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ServiceRequestRelationship input)
        {
            return input switch
            {
                ServiceRequestRelationship.Compound => "C",
                ServiceRequestRelationship.Exclusive => "E",
                ServiceRequestRelationship.NursePrerogative => "N",
                ServiceRequestRelationship.Simultaneous => "S",
                ServiceRequestRelationship.Tapering => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SeverityOfIllnessCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SeverityOfIllnessCode input)
        {
            return input switch
            {
                SeverityOfIllnessCode.Mild => "MI",
                SeverityOfIllnessCode.Moderate => "MO",
                SeverityOfIllnessCode.Severe => "SE",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ShipmentStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ShipmentStatus input)
        {
            return input switch
            {
                ShipmentStatus.Inventoried => "INV",
                ShipmentStatus.OnHold => "ONH",
                ShipmentStatus.Processing => "PRC",
                ShipmentStatus.Rejected => "REJ",
                ShipmentStatus.InTransit => "TRN",
                ShipmentStatus.TriagedToLab => "TTL",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SideOfBody enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SideOfBody input)
        {
            return input switch
            {
                SideOfBody.Left => "L",
                SideOfBody.Right => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SignatorysRelationshipToSubject enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SignatorysRelationshipToSubject input)
        {
            return input switch
            {
                SignatorysRelationshipToSubject.Self => "1",
                SignatorysRelationshipToSubject.Parent => "2",
                SignatorysRelationshipToSubject.NextOfKin => "3",
                SignatorysRelationshipToSubject.DurablePowerOfAttorneyInHealthcareAffairs => "4",
                SignatorysRelationshipToSubject.Conservator => "5",
                SignatorysRelationshipToSubject.EmergentPractitioner => "6",
                SignatorysRelationshipToSubject.NonEmergentPractitioner => "7",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SignatureCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SignatureCode input)
        {
            return input switch
            {
                SignatureCode.SignedCms1500ClaimFormOnFile => "C",
                SignatureCode.SignedAuthorizationForAssignmentOfBenefitsOnFile => "M",
                SignatureCode.SignatureGeneratedByProvider => "P",
                SignatureCode.SignedAuthorizationForReleaseOfAnyMedicalOrOtherInfoOnFile => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SourceOfComment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SourceOfComment input)
        {
            return input switch
            {
                SourceOfComment.AncillaryDepartmentIsSourceOfComment => "L",
                SourceOfComment.OtherSystemIsSourceOfComment => "O",
                SourceOfComment.OrdererIsSourceOfComment => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SourceType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SourceType input)
        {
            return input switch
            {
                SourceType.Accept => "A",
                SourceType.Initiate => "I",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecialHandlingCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecialHandlingCode input)
        {
            return input switch
            {
                SpecialHandlingCode.AmbientTemperature => "AMB",
                SpecialHandlingCode.BodyTemperature => "C37",
                SpecialHandlingCode.CriticalAmbientTemperature => "CAMB",
                SpecialHandlingCode.ProtectFromAir => "CATM",
                SpecialHandlingCode.CriticalFrozenTemperature => "CFRZ",
                SpecialHandlingCode.CriticalRefrigeratedTemperature => "CREF",
                SpecialHandlingCode.DeepFrozen => "DFRZ",
                SpecialHandlingCode.Dry => "DRY",
                SpecialHandlingCode.FrozenTemperature => "FRZ",
                SpecialHandlingCode.MetalFree => "MTLF",
                SpecialHandlingCode.LiquidNitrogen => "NTR",
                SpecialHandlingCode.ProtectFromLight => "PRTL",
                SpecialHandlingCode.DoNotShake => "PSA",
                SpecialHandlingCode.NoShock => "PSO",
                SpecialHandlingCode.RefrigeratedTemperature => "REF",
                SpecialHandlingCode.UltraFrozen => "UFRZ",
                SpecialHandlingCode.Upright => "UPR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecialProgramCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecialProgramCode input)
        {
            return input switch
            {
                SpecialProgramCode.ChildHealthAssistance => "CH",
                SpecialProgramCode.ElectiveSurgeryProgram => "ES",
                SpecialProgramCode.FamilyPlanning => "FP",
                SpecialProgramCode.Other => "O",
                SpecialProgramCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecialtyType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecialtyType input)
        {
            return input switch
            {
                SpecialtyType.Allergy => "ALC",
                SpecialtyType.Ambulatory => "AMB",
                SpecialtyType.Cancer => "CAN",
                SpecialtyType.CoronaryCardiacCare => "CAR",
                SpecialtyType.CriticalCare => "CCR",
                SpecialtyType.Chiropractic => "CHI",
                SpecialtyType.Education => "EDI",
                SpecialtyType.Emergency => "EMR",
                SpecialtyType.FamilyPlanning => "FPC",
                SpecialtyType.IntensiveCare => "INT",
                SpecialtyType.Isolation => "ISO",
                SpecialtyType.Naturopathic => "NAT",
                SpecialtyType.NewbornNurseryInfants => "NBI",
                SpecialtyType.ObstetricsGynecology => "OBG",
                SpecialtyType.Observation => "OBS",
                SpecialtyType.OtherSpecialty => "OTH",
                SpecialtyType.Pediatrics => "PED",
                SpecialtyType.GeneralFamilyPractice => "PHY",
                SpecialtyType.PediatricNeonatalIntensiveCare => "PIN",
                SpecialtyType.PediatricPsychiatric => "PPS",
                SpecialtyType.PediatricRehabilitation => "PRE",
                SpecialtyType.PsychiatricIntensiveCare => "PSI",
                SpecialtyType.Psychiatric => "PSY",
                SpecialtyType.Rehabilitation => "REH",
                SpecialtyType.Surgery => "SUR",
                SpecialtyType.WalkInClinic => "WIC",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecimenActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecimenActionCode input)
        {
            return input switch
            {
                SpecimenActionCode.AddOrderedTestsToExistingSpecimen => "A",
                SpecimenActionCode.GeneratedOrderReflexOrder => "G",
                SpecimenActionCode.LabToObtainSpecimenFromPatient => "L",
                SpecimenActionCode.SpecimenObtainedByServiceOtherThanLab => "O",
                SpecimenActionCode.PendingSpecimenOrderSentPriorToDelivery => "P",
                SpecimenActionCode.RevisedOrder => "R",
                SpecimenActionCode.ScheduleTheTestsSpecifiedBelow => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecimenAppropriateness enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecimenAppropriateness input)
        {
            return input switch
            {
                SpecimenAppropriateness.InappropriateDueTo => "??",
                SpecimenAppropriateness.Appropriate => "A",
                SpecimenAppropriateness.Inappropriate => "I",
                SpecimenAppropriateness.Preferred => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecimenChildRole enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecimenChildRole input)
        {
            return input switch
            {
                SpecimenChildRole.Aliquot => "A",
                SpecimenChildRole.Component => "C",
                SpecimenChildRole.ModifiedFromOriginalSpecimen => "M",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecimenCollectionMethod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecimenCollectionMethod input)
        {
            return input switch
            {
                SpecimenCollectionMethod.PlatesAnaerobic => "ANP",
                SpecimenCollectionMethod.PlatesBloodAgar => "BAP",
                SpecimenCollectionMethod.BloodCultureAerobicBottle => "BCAE",
                SpecimenCollectionMethod.BloodCultureAnaerobicBottle => "BCAN",
                SpecimenCollectionMethod.BloodCulturePediatricBottle => "BCPD",
                SpecimenCollectionMethod.Biopsy => "BIO",
                SpecimenCollectionMethod.CapillarySpecimen => "CAP",
                SpecimenCollectionMethod.Catheterized => "CATH",
                SpecimenCollectionMethod.LineCvp => "CVP",
                SpecimenCollectionMethod.EnvironmentalPlate => "EPLA",
                SpecimenCollectionMethod.EnvironmentalSwab => "ESWA",
                SpecimenCollectionMethod.AspirationFineNeedle => "FNA",
                SpecimenCollectionMethod.PlateCough => "KOFFP",
                SpecimenCollectionMethod.LineArterial => "LNA",
                SpecimenCollectionMethod.LineVenous => "LNV",
                SpecimenCollectionMethod.MartinLewisAgar => "MARTL",
                SpecimenCollectionMethod.ModMartinLewisAgar => "ML11",
                SpecimenCollectionMethod.PlateMartinLewis => "MLP",
                SpecimenCollectionMethod.PlateNewYorkCity => "NYP",
                SpecimenCollectionMethod.PaceGenProbe => "PACE",
                SpecimenCollectionMethod.PinwormPrep => "PIN",
                SpecimenCollectionMethod.ArterialPuncture => "PNA",
                SpecimenCollectionMethod.PumpPrime => "PRIME",
                SpecimenCollectionMethod.PumpSpecimen => "PUMP",
                SpecimenCollectionMethod.QualityControlForMicro => "QC5",
                SpecimenCollectionMethod.ScalpFetalVein => "SCLP",
                SpecimenCollectionMethod.Scrapings => "SCRAPS",
                SpecimenCollectionMethod.Shaving => "SHA",
                SpecimenCollectionMethod.Swab => "SWA",
                SpecimenCollectionMethod.SwabDacronTipped => "SWD",
                SpecimenCollectionMethod.TransportMediaAnaerobic => "TMAN",
                SpecimenCollectionMethod.TransportMediaChalamydia => "TMCH",
                SpecimenCollectionMethod.TransportMediaM4 => "TMM4",
                SpecimenCollectionMethod.TransportMediaMycoplasma => "TMMY",
                SpecimenCollectionMethod.TransportMedia => "TMOT",
                SpecimenCollectionMethod.PlateThayerMartin => "TMP",
                SpecimenCollectionMethod.TransportMediaPva => "TMPV",
                SpecimenCollectionMethod.TransportMediaStoolCulture => "TMSC",
                SpecimenCollectionMethod.TransportMediaUreaplasma => "TMUP",
                SpecimenCollectionMethod.TransportMediaViral => "TMVI",
                SpecimenCollectionMethod.Venipuncture => "VENIP",
                SpecimenCollectionMethod.SwabWoodenShaft => "WOOD",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecimenComponent enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecimenComponent input)
        {
            return input switch
            {
                SpecimenComponent.WholeBloodHomogeneous => "BLD",
                SpecimenComponent.WholeBloodSeparated => "BSEP",
                SpecimenComponent.Plasma => "PLAS",
                SpecimenComponent.PlateletPoorPlasma => "PPP",
                SpecimenComponent.PlateletRichPlasma => "PRP",
                SpecimenComponent.Sediment => "SED",
                SpecimenComponent.SerumNosNotOtherwiseSpecified => "SER",
                SpecimenComponent.Supernatant => "SUP",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecimenCondition enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecimenCondition input)
        {
            return input switch
            {
                SpecimenCondition.Autolyzed => "AUT",
                SpecimenCondition.Clotted => "CLOT",
                SpecimenCondition.Contaminated => "CON",
                SpecimenCondition.Cool => "COOL",
                SpecimenCondition.Frozen => "FROZ",
                SpecimenCondition.Hemolyzed => "HEM",
                SpecimenCondition.Live => "LIVE",
                SpecimenCondition.RoomTemperature => "ROOM",
                SpecimenCondition.SampleNotReceived => "SNR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecimenQuality enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecimenQuality input)
        {
            return input switch
            {
                SpecimenQuality.Excellent => "E",
                SpecimenQuality.Fair => "F",
                SpecimenQuality.Good => "G",
                SpecimenQuality.Poor => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecimenRejectReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecimenRejectReason input)
        {
            return input switch
            {
                SpecimenRejectReason.Expired => "EX",
                SpecimenRejectReason.QuantityNotSufficient => "QS",
                SpecimenRejectReason.MissingPatientIdNumber => "RA",
                SpecimenRejectReason.BrokenContainer => "RB",
                SpecimenRejectReason.Clotting => "RC",
                SpecimenRejectReason.MissingCollectionDate => "RD",
                SpecimenRejectReason.MissingPatientName => "RE",
                SpecimenRejectReason.Hemolysis => "RH",
                SpecimenRejectReason.IdentificationProblem => "RI",
                SpecimenRejectReason.Labeling => "RM",
                SpecimenRejectReason.Contamination => "RN",
                SpecimenRejectReason.MissingPhlebotomistId => "RP",
                SpecimenRejectReason.ImproperStorage => "RR",
                SpecimenRejectReason.NameMisspelling => "RS",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecimenRole enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecimenRole input)
        {
            return input switch
            {
                SpecimenRole.BlindSample => "B",
                SpecimenRole.Calibrator => "C",
                SpecimenRole.ElectronicQc => "E",
                SpecimenRole.SpecimenUsedForTestingProficiency => "F",
                SpecimenRole.Group => "G",
                SpecimenRole.Pool => "L",
                SpecimenRole.SpecimenUsedForTestingOperatorProficiency => "O",
                SpecimenRole.Patient => "P",
                SpecimenRole.ControlSpecimen => "Q",
                SpecimenRole.Replicate => "R",
                SpecimenRole.VerifyingCalibrator => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecimenType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecimenType input)
        {
            return input switch
            {
                SpecimenType.Abscess => "ABS",
                SpecimenType.TissueAcne => "ACNE",
                SpecimenType.FluidAcne => "ACNFLD",
                SpecimenType.AirSample => "AIRS",
                SpecimenType.Allograft => "ALL",
                SpecimenType.Amputation => "AMP",
                SpecimenType.CatheterTipAngio => "ANGI",
                SpecimenType.CatheterTipArterial => "ARTC",
                SpecimenType.SerumAcute => "ASERU",
                SpecimenType.Aspirate => "ASP",
                SpecimenType.EnvironmentAttest => "ATTE",
                SpecimenType.EnvironmentalAutoclaveAmpule => "AUTOA",
                SpecimenType.EnvironmentalAutoclaveCapsule => "AUTOC",
                SpecimenType.Autopsy => "AUTP",
                SpecimenType.BloodBag => "BBL",
                SpecimenType.CystBakers => "BCYST",
                SpecimenType.Bite => "BITE",
                SpecimenType.Bleb => "BLEB",
                SpecimenType.Blister => "BLIST",
                SpecimenType.Boil => "BOIL",
                SpecimenType.Bone => "BON",
                SpecimenType.BowelContents => "BOWL",
                SpecimenType.BloodProductUnit => "BPU",
                SpecimenType.Burn => "BRN",
                SpecimenType.Brush => "BRSH",
                SpecimenType.BreathUseExhld => "BRTH",
                SpecimenType.Brushing => "BRUS",
                SpecimenType.Bubo => "BUB",
                SpecimenType.BullaBullae => "BULLA",
                SpecimenType.Biopsy => "BX",
                SpecimenType.CalculusStone => "CALC",
                SpecimenType.Carbuncle => "CARBU",
                SpecimenType.Catheter => "CAT",
                SpecimenType.BiteCat => "CBITE",
                SpecimenType.Clippings => "CLIPP",
                SpecimenType.Conjunctiva => "CNJT",
                SpecimenType.Colostrum => "COL",
                SpecimenType.BiospyCone => "CONE",
                SpecimenType.ScratchCat => "CSCR",
                SpecimenType.SerumConvalescent => "CSERU",
                SpecimenType.CatheterInsertionSite => "CSITE",
                SpecimenType.FluidCystostomyTube => "CSMY",
                SpecimenType.FluidCyst => "CST",
                SpecimenType.BloodCellSaver => "CSVR",
                SpecimenType.CatheterTip => "CTP",
                SpecimenType.SiteCvp => "CVPS",
                SpecimenType.CatheterTipCvp => "CVPT",
                SpecimenType.NoduleCystic => "CYN",
                SpecimenType.Cyst => "CYST",
                SpecimenType.BiteDog => "DBITE",
                SpecimenType.SputumDeepCough => "DCS",
                SpecimenType.UlcerDecubitus => "DEC",
                SpecimenType.EnvironmentalWaterDeionized => "DEION",
                SpecimenType.Dialysate => "DIA",
                SpecimenType.Discharge => "DISCHG",
                SpecimenType.Diverticulum => "DIV",
                SpecimenType.Drain => "DRN",
                SpecimenType.DrainageTube => "DRNG",
                SpecimenType.DrainagePenrose => "DRNGP",
                SpecimenType.EarWaxCerumen => "EARW",
                SpecimenType.BrushEsophageal => "EBRUSH",
                SpecimenType.EnvironmentalEyeWash => "EEYE",
                SpecimenType.EnvironmentalEffluent => "EFF",
                SpecimenType.Effusion => "EFFUS",
                SpecimenType.EnvironmentalFood => "EFOD",
                SpecimenType.EnvironmentalIsolette => "EISO",
                SpecimenType.Electrode => "ELT",
                SpecimenType.EnvironmentalUnidentifiedSubstance => "ENVIR",
                SpecimenType.EnvironmentalOtherSubstance => "EOTH",
                SpecimenType.EnvironmentalSoil => "ESOI",
                SpecimenType.EnvironmentalSolutionSterile => "ESOS",
                SpecimenType.AspirateEndotrach => "ETA",
                SpecimenType.CatheterTipEndotracheal => "ETTP",
                SpecimenType.TubeEndotracheal => "ETTUB",
                SpecimenType.EnvironmentalWhirlpool => "EWHI",
                SpecimenType.GasExhaledBreath => "EXG",
                SpecimenType.ShuntExternal => "EXS",
                SpecimenType.Exudate => "EXUDTE",
                SpecimenType.EnvironmentalWaterWell => "FAW",
                SpecimenType.BloodFetal => "FBLOOD",
                SpecimenType.FluidAbdomen => "FGA",
                SpecimenType.Fistula => "FIST",
                SpecimenType.FluidOther => "FLD",
                SpecimenType.Filter => "FLT",
                SpecimenType.FluidBodyUnsp => "FLU",
                SpecimenType.Fluid => "FLUID",
                SpecimenType.CatheterTipFoley => "FOLEY",
                SpecimenType.FluidRespiratory => "FRS",
                SpecimenType.ScalpFetal => "FSCLP",
                SpecimenType.Furuncle => "FUR",
                SpecimenType.Gas => "GAS",
                SpecimenType.AspirateGastric => "GASA",
                SpecimenType.AntrumGastric => "GASAN",
                SpecimenType.BrushingGastric => "GASBR",
                SpecimenType.DrainageGastric => "GASD",
                SpecimenType.FluidContentsGastric => "GAST",
                SpecimenType.GenitalVaginal => "GENV",
                SpecimenType.Graft => "GRAFT",
                SpecimenType.GraftSite => "GRAFTS",
                SpecimenType.Granuloma => "GRANU",
                SpecimenType.CatheterGroshong => "GROSH",
                SpecimenType.SolutionGastrostomy => "GSOL",
                SpecimenType.BiopsyGastric => "GSPEC",
                SpecimenType.TubeGastric => "GT",
                SpecimenType.DrainageTubeDrainageGastrostomy => "GTUBE",
                SpecimenType.BiteHuman => "HBITE",
                SpecimenType.BloodAutopsy => "HBLUD",
                SpecimenType.CatheterTipHemaquit => "HEMAQ",
                SpecimenType.CatheterTipHemovac => "HEMO",
                SpecimenType.TissueHerniated => "HERNI",
                SpecimenType.DrainHemovac => "HEV",
                SpecimenType.CatheterHickman => "HIC",
                SpecimenType.FluidHydrocele => "HYDC",
                SpecimenType.BiteInsect => "IBITE",
                SpecimenType.CystInclusion => "ICYST",
                SpecimenType.CatheterTipIndwelling => "IDC",
                SpecimenType.GasInhaled => "IHG",
                SpecimenType.DrainageIleostomy => "ILEO",
                SpecimenType.SourceOfSpecimenIsIllegible => "ILLEG",
                SpecimenType.Implant => "IMP",
                SpecimenType.SiteIncisionSurgical => "INCI",
                SpecimenType.Infiltrate => "INFIL",
                SpecimenType.Insect => "INS",
                SpecimenType.CatheterTipIntroducer => "INTRD",
                SpecimenType.IntubationTube => "IT",
                SpecimenType.IntrauterineDevice => "IUD",
                SpecimenType.CatheterTipIv => "IVCAT",
                SpecimenType.FluidIv => "IVFLD",
                SpecimenType.TubingTipIv => "IVTIP",
                SpecimenType.DrainageJejunal => "JEJU",
                SpecimenType.FluidJoint => "JNTFLD",
                SpecimenType.DrainageJacksonPratt => "JP",
                SpecimenType.Lavage => "KELOI",
                SpecimenType.FluidKidney => "KIDFLD",
                SpecimenType.LavageBronhial => "LAVG",
                SpecimenType.LavageGastric => "LAVGG",
                SpecimenType.LavagePeritoneal => "LAVGP",
                SpecimenType.LavagePreBronch => "LAVPG",
                SpecimenType.ContactLens => "LENS1",
                SpecimenType.ContactLensCase => "LENS2",
                SpecimenType.Lesion => "LESN",
                SpecimenType.LiquidUnspecified => "LIQ",
                SpecimenType.LiquidOther => "LIQO",
                SpecimenType.FluidLumbarSac => "LSAC",
                SpecimenType.CatheterTipMakurkour => "MAHUR",
                SpecimenType.Mass => "MASS",
                SpecimenType.BloodMenstrual => "MBLD",
                SpecimenType.Mucosa => "MUCOS",
                SpecimenType.Mucus => "MUCUS",
                SpecimenType.DrainageNasal => "NASDR",
                SpecimenType.Needle => "NEDL",
                SpecimenType.SiteNephrostomy => "NEPH",
                SpecimenType.AspirateNasogastric => "NGASP",
                SpecimenType.DrainageNasogastric => "NGAST",
                SpecimenType.SiteNasoGastric => "NGS",
                SpecimenType.NoduleS => "NODUL",
                SpecimenType.SecretionNasal => "NSECR",
                SpecimenType.Other => "ORH",
                SpecimenType.LesionOral => "ORL",
                SpecimenType.SourceOther => "OTH",
                SpecimenType.Pacemaker => "PACEM",
                SpecimenType.FluidPericardial => "PCFL",
                SpecimenType.SitePeritonealDialysis => "PDSIT",
                SpecimenType.SitePeritonealDialysisTunnel => "PDTS",
                SpecimenType.AbscessPelvic => "PELVA",
                SpecimenType.LesionPenile => "PENIL",
                SpecimenType.AbscessPerianal => "PERIA",
                SpecimenType.CystPilonidal => "PILOC",
                SpecimenType.SitePin => "PINS",
                SpecimenType.SitePacemakerInsetion => "PIS",
                SpecimenType.PlantMaterial => "PLAN",
                SpecimenType.Plasma => "PLAS",
                SpecimenType.PlasmaBag => "PLB",
                SpecimenType.SerumPeakLevel => "PLEVS",
                SpecimenType.DrainagePenile => "PND",
                SpecimenType.Polyps => "POL",
                SpecimenType.GraftSitePopliteal => "POPGS",
                SpecimenType.GraftPopliteal => "POPLG",
                SpecimenType.SitePoplitealVein => "POPLV",
                SpecimenType.CatheterPorta => "PORTA",
                SpecimenType.PlasmaPlateletPoor => "PPP",
                SpecimenType.ProstheticDevice => "PROST",
                SpecimenType.PlasmaPlateletRich => "PRP",
                SpecimenType.Pseudocyst => "PSC",
                SpecimenType.WoundPuncture => "PUNCT",
                SpecimenType.Pus => "PUS",
                SpecimenType.Pustule => "PUSFR",
                SpecimenType.PusCondition => "PUST",
                SpecimenType.QualityControl => "QC3",
                SpecimenType.UrineRandom => "RANDU",
                SpecimenType.BiteReptile => "RBITE",
                SpecimenType.DrainageRectal => "RECT",
                SpecimenType.AbscessRectal => "RECTA",
                SpecimenType.CystRenal => "RENALC",
                SpecimenType.FluidRenalCyst => "RENC",
                SpecimenType.Respiratory => "RES",
                SpecimenType.Saliva => "SAL",
                SpecimenType.TissueKeloidScar => "SCAR",
                SpecimenType.CatheterTipSubclavian => "SCLV",
                SpecimenType.AbscessScrotal => "SCROA",
                SpecimenType.SecretionS => "SECRE",
                SpecimenType.Serum => "SER",
                SpecimenType.SiteShunt => "SHU",
                SpecimenType.FluidShunt => "SHUNF",
                SpecimenType.Shunt => "SHUNT",
                SpecimenType.Site => "SITE",
                SpecimenType.BiopsySkin => "SKBP",
                SpecimenType.Skin => "SKN",
                SpecimenType.MassSubMandibular => "SMM",
                SpecimenType.FluidSynovialJointFluid => "SNV",
                SpecimenType.Spermatozoa => "SPRM",
                SpecimenType.CatheterTipSuprapubic => "SPRP",
                SpecimenType.CathetherTipSuprapubic => "SPRPB",
                SpecimenType.EnvironmentalSporeStrip => "SPS",
                SpecimenType.Sputum => "SPT",
                SpecimenType.SputumCoughed => "SPTC",
                SpecimenType.SputumTrachealAspirate => "SPTT",
                SpecimenType.SputumSimulated => "SPUT1",
                SpecimenType.SputumInducted => "SPUTIN",
                SpecimenType.SputumSpontaneous => "SPUTSP",
                SpecimenType.EnvironmentalSterrad => "STER",
                SpecimenType.StoolFecal => "STL",
                SpecimenType.StoneKidney => "STONE",
                SpecimenType.AbscessSubmandibular => "SUBMA",
                SpecimenType.AbscessSubmaxillary => "SUBMX",
                SpecimenType.DrainageSump => "SUMP",
                SpecimenType.SuprapubicTap => "SUP",
                SpecimenType.Suture => "SUTUR",
                SpecimenType.CatheterTipSwanGantz => "SWGZ",
                SpecimenType.AspirateTracheal => "TASP",
                SpecimenType.Tissue => "TISS",
                SpecimenType.TissueUlcer => "TISU",
                SpecimenType.CathetherTipTripleLumen => "TLC",
                SpecimenType.SiteTracheostomy => "TRAC",
                SpecimenType.Transudate => "TRANS",
                SpecimenType.SerumTrough => "TSERU",
                SpecimenType.AbscessTesticular => "TSTES",
                SpecimenType.AspirateTranstracheal => "TTRA",
                SpecimenType.Tubes => "TUBES",
                SpecimenType.Tumor => "TUMOR",
                SpecimenType.SmearTzanck => "TZANC",
                SpecimenType.SourceUnidentified => "UDENT",
                SpecimenType.Urine => "UR",
                SpecimenType.UrineCleanCatch => "URC",
                SpecimenType.UrineBladderWashings => "URINB",
                SpecimenType.UrineCatheterized => "URINC",
                SpecimenType.UrineMidstream => "URINM",
                SpecimenType.UrineNephrostomy => "URINN",
                SpecimenType.UrinePedibag => "URINP",
                SpecimenType.UrineCatheter => "URT",
                SpecimenType.UrineCystoscopy => "USCOP",
                SpecimenType.SourceUnspecified => "USPEC",
                SpecimenType.CatheterTipVas => "VASTIP",
                SpecimenType.CatheterTipVentricular => "VENT",
                SpecimenType.VitreousFluid => "VITF",
                SpecimenType.Vomitus => "VOM",
                SpecimenType.Wash => "WASH",
                SpecimenType.WashingEGBronchialWashing => "WASI",
                SpecimenType.Water => "WAT",
                SpecimenType.BloodWhole => "WB",
                SpecimenType.Wen => "WEN",
                SpecimenType.Wick => "WICK",
                SpecimenType.Wound => "WND",
                SpecimenType.WoundAbscess => "WNDA",
                SpecimenType.WoundDrainage => "WNDD",
                SpecimenType.WoundExudate => "WNDE",
                SpecimenType.Worm => "WORM",
                SpecimenType.Wart => "WRT",
                SpecimenType.EnvironmentalWater => "WWA",
                SpecimenType.EnvironmentalWaterOcean => "WWO",
                SpecimenType.EnvironmentalWaterTap => "WWT",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given StatusAdmission enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(StatusAdmission input)
        {
            return input switch
            {
                StatusAdmission.AdmissionStatusIsValidUsedForGrouping => "0",
                StatusAdmission.AdmissionStatusIsValidNotUsedForGrouping => "1",
                StatusAdmission.AdmissionStatusIsInvalidNotUsedForGrouping => "2",
                StatusAdmission.AdmissionStatusIsInvalidDefaultValueUsedForGrouping => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given StatusOfEvaluation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(StatusOfEvaluation input)
        {
            return input switch
            {
                StatusOfEvaluation.EvaluationAnticipatedNotYetBegun => "A",
                StatusOfEvaluation.ProductReceivedInConditionWhichMadeAnalysisImpossible => "C",
                StatusOfEvaluation.ProductDiscardedNoFollowUp => "D",
                StatusOfEvaluation.ProductRemainsImplantedNoFollowUp => "I",
                StatusOfEvaluation.ProblemAlreadyKnownNoEvaluation => "K",
                StatusOfEvaluation.Other => "O",
                StatusOfEvaluation.EvaluationInProgress => "P",
                StatusOfEvaluation.ProductUnderQuarantineNoFollowUp => "Q",
                StatusOfEvaluation.ProductUnderRecall => "R",
                StatusOfEvaluation.ProductUnavailableForFollowUp => "U",
                StatusOfEvaluation.ProductNotMadeByCompany => "X",
                StatusOfEvaluation.EvaluationCompleted => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given StatusWeightAtBirth enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(StatusWeightAtBirth input)
        {
            return input switch
            {
                StatusWeightAtBirth.NoWeightReportedAtAdmissionUsedForGrouping => "0",
                StatusWeightAtBirth.WeightReportedAtAdmissionUsedForGrouping => "1",
                StatusWeightAtBirth.DefaultWeight2499GUsedForGrouping => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SterilizationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SterilizationType input)
        {
            return input switch
            {
                SterilizationType.EthyleneOxideGas => "EOG",
                SterilizationType.PeraceticAcid => "PCA",
                SterilizationType.Steam => "STM",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given StudentStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(StudentStatus input)
        {
            return input switch
            {
                StudentStatus.FullTimeStudent => "F",
                StudentStatus.NotAStudent => "N",
                StudentStatus.PartTimeStudent => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SubstanceStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SubstanceStatus input)
        {
            return input switch
            {
                SubstanceStatus.CalibrationError => "CE",
                SubstanceStatus.CalibrationWarning => "CW",
                SubstanceStatus.ExpiredError => "EE",
                SubstanceStatus.ExpiredWarning => "EW",
                SubstanceStatus.NotAvailableError => "NE",
                SubstanceStatus.NotAvailableWarning => "NW",
                SubstanceStatus.OtherError => "OE",
                SubstanceStatus.OkStatus => "OK",
                SubstanceStatus.OtherWarning => "OW",
                SubstanceStatus.QcError => "QE",
                SubstanceStatus.QcWarning => "QW",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SubstanceType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SubstanceType input)
        {
            return input switch
            {
                SubstanceType.ControlReagent => "CO",
                SubstanceType.Diluent => "DI",
                SubstanceType.MeasurableLiquidItem => "LI",
                SubstanceType.LiquidWaste => "LW",
                SubstanceType.MultipleTestReagent => "MR",
                SubstanceType.Other => "OT",
                SubstanceType.Pretreatment => "PT",
                SubstanceType.PurifiedWater => "PW",
                SubstanceType.ReagentCalibrator => "RC",
                SubstanceType.CountableSolidItem => "SC",
                SubstanceType.SingleTestReagent => "SR",
                SubstanceType.SolidWaste => "SW",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SubstitutionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SubstitutionStatus input)
        {
            return input switch
            {
                SubstitutionStatus.NoProductSelectionIndicated => "0",
                SubstitutionStatus.SubstitutionNotAllowedByPrescriber => "1",
                SubstitutionStatus.SubstitutionAllowedPatientRequested => "2",
                SubstitutionStatus.SubstitutionAllowedPharmacistSelected => "3",
                SubstitutionStatus.SubstitutionAllowedGenericDrugNotInStock => "4",
                SubstitutionStatus.SubstitutionAllowedDispensedAsGeneric => "5",
                SubstitutionStatus.SubstitutionNotAllowedBrandMandatedByLaw => "7",
                SubstitutionStatus.SubstitutionAllowedGenericNotAvailable => "8",
                SubstitutionStatus.AGenericSubstitutionWasDispensed => "G",
                SubstitutionStatus.NoSubstituteWasDispensed => "N",
                SubstitutionStatus.TherapeuticSubstitutionWasDispensed => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SubtypeOfReferencedData enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SubtypeOfReferencedData input)
        {
            return input switch
            {
                SubtypeOfReferencedData.SourceRfc2046ADeprecated => "...",
                SubtypeOfReferencedData.IsdnPcmAudioData => "BASIC",
                SubtypeOfReferencedData.DigitalImagingAndCommunicationsInMedicine => "DICOM",
                SubtypeOfReferencedData.FacsimileData => "FAX",
                SubtypeOfReferencedData.GraphicsInterchangeFormat => "GIF",
                SubtypeOfReferencedData.HypertextMarkupLanguage => "HTML",
                SubtypeOfReferencedData.ElectronicInkDataJot10Standard => "JOT",
                SubtypeOfReferencedData.JointPhotographicExpertsGroup => "JPEG",
                SubtypeOfReferencedData.UninterpretedBinaryData => "Octet-stream",
                SubtypeOfReferencedData.PictFormatImageData => "PICT",
                SubtypeOfReferencedData.PostscriptProgram => "PostScript",
                SubtypeOfReferencedData.RichTextFormat => "RTF",
                SubtypeOfReferencedData.SgmlStandardGeneralizedMarkupLanguage => "SGML",
                SubtypeOfReferencedData.TiffImageData => "TIFF",
                SubtypeOfReferencedData.Hl7ClinicalDocumentArchitectureLevelOne => "x-hl7-cda-level-one",
                SubtypeOfReferencedData.XmlExtensibleMarkupLanguage => "XML",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SupplementalServiceInformationValues enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SupplementalServiceInformationValues input)
        {
            return input switch
            {
                SupplementalServiceInformationValues.NoSuggestedValuesDefined => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SupplyRiskCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SupplyRiskCodes input)
        {
            return input switch
            {
                SupplyRiskCodes.Corrosive => "COR",
                SupplyRiskCodes.Explosive => "EXP",
                SupplyRiskCodes.Flammable => "FLA",
                SupplyRiskCodes.InjuryHazard => "INJ",
                SupplyRiskCodes.Radioactive => "RAD",
                SupplyRiskCodes.Toxic => "TOX",
                SupplyRiskCodes.Unknown => "UNK",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SystemInducedContaminants enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SystemInducedContaminants input)
        {
            return input switch
            {
                SystemInducedContaminants.PresentTypeOfContaminationUnspecified => "CNTM",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TaxStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TaxStatus input)
        {
            return input switch
            {
                TaxStatus.RegisteredInVatRegister => "RVAT",
                TaxStatus.UnregisteredInVatRegister => "UVAT",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TelecommunicationEquipmentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TelecommunicationEquipmentType input)
        {
            return input switch
            {
                TelecommunicationEquipmentType.Beeper => "BP",
                TelecommunicationEquipmentType.CellularOrMobilePhone => "CP",
                TelecommunicationEquipmentType.Fax => "FX",
                TelecommunicationEquipmentType.InternetAddress => "Internet",
                TelecommunicationEquipmentType.Modem => "MD",
                TelecommunicationEquipmentType.Telephone => "PH",
                TelecommunicationEquipmentType.SatellitePhone => "SAT",
                TelecommunicationEquipmentType.TelecommunicationsDeviceForTheDeaf => "TDD",
                TelecommunicationEquipmentType.Teletypewriter => "TTY",
                TelecommunicationEquipmentType.X400EmailAddress => "X.400",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TelecommunicationExpirationReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TelecommunicationExpirationReason input)
        {
            return input switch
            {
                TelecommunicationExpirationReason.Corrected => "C",
                TelecommunicationExpirationReason.AddedInError => "E",
                TelecommunicationExpirationReason.Moved => "M",
                TelecommunicationExpirationReason.NoLongerInService => "N",
                TelecommunicationExpirationReason.OnRequest => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TelecommunicationUseCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TelecommunicationUseCode input)
        {
            return input switch
            {
                TelecommunicationUseCode.AnsweringServiceNumber => "ASN",
                TelecommunicationUseCode.BeeperNumber => "BPN",
                TelecommunicationUseCode.EmergencyNumber => "EMR",
                TelecommunicationUseCode.NetworkEmailAddress => "NET",
                TelecommunicationUseCode.OtherResidenceNumber => "ORN",
                TelecommunicationUseCode.PrimaryResidenceNumber => "PRN",
                TelecommunicationUseCode.Personal => "PRS",
                TelecommunicationUseCode.VacationHomeNumber => "VHN",
                TelecommunicationUseCode.WorkNumber => "WPN",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TimeDelayPostChallenge enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TimeDelayPostChallenge input)
        {
            return input switch
            {
                TimeDelayPostChallenge.TenDays => "10D",
                TimeDelayPostChallenge.TenMinutesPostChallenge => "10M",
                TimeDelayPostChallenge.TwelveHoursPostChallenge => "12H",
                TimeDelayPostChallenge.FifteenMinutesPostChallenge => "15M",
                TimeDelayPostChallenge.OneHourPostChallenge => "1H",
                TimeDelayPostChallenge.OneMonthPostChallenge => "1L",
                TimeDelayPostChallenge.OneMinutePostChallenge => "1M",
                TimeDelayPostChallenge.OneWeek => "1W",
                TimeDelayPostChallenge.TwoAndAHalfHoursPostChallenge => "2.5H",
                TimeDelayPostChallenge.TwentyMinutesPostChallenge => "20M",
                TimeDelayPostChallenge.TwentyFourHoursPostChallenge => "24H",
                TimeDelayPostChallenge.TwentyFiveMinutesPostChallenge => "25M",
                TimeDelayPostChallenge.TwoDays => "2D",
                TimeDelayPostChallenge.TwoHoursPostChallenge => "2H",
                TimeDelayPostChallenge.TwoMonthsPostChallenge => "2L",
                TimeDelayPostChallenge.TwoMinutesPostChallenge => "2M",
                TimeDelayPostChallenge.TwoWeeks => "2W",
                TimeDelayPostChallenge.ThirtyMinutesPostChallenge => "30M",
                TimeDelayPostChallenge.ThreeDays => "3D",
                TimeDelayPostChallenge.ThreeHoursPostChallenge => "3H",
                TimeDelayPostChallenge.ThreeMonthsPostChallenge => "3L",
                TimeDelayPostChallenge.ThreeMinutesPostChallenge => "3M",
                TimeDelayPostChallenge.ThreeWeeks => "3W",
                TimeDelayPostChallenge.FourDays => "4D",
                TimeDelayPostChallenge.FourHoursPostChallenge => "4H",
                TimeDelayPostChallenge.FourMinutesPostChallenge => "4M",
                TimeDelayPostChallenge.FourWeeks => "4W",
                TimeDelayPostChallenge.FiveDays => "5D",
                TimeDelayPostChallenge.FiveHoursPostChallenge => "5H",
                TimeDelayPostChallenge.FiveMinutesPostChallenge => "5M",
                TimeDelayPostChallenge.SixDays => "6D",
                TimeDelayPostChallenge.SixHoursPostChallenge => "6H",
                TimeDelayPostChallenge.SixMinutesPostChallenge => "6M",
                TimeDelayPostChallenge.SevenDays => "7D",
                TimeDelayPostChallenge.SevenHoursPostChallenge => "7H",
                TimeDelayPostChallenge.SevenMinutesPostChallenge => "7M",
                TimeDelayPostChallenge.EightHoursPostChallenge => "8H",
                TimeDelayPostChallenge.EightHoursAlignedOnNursingShifts => "8H SHIFT",
                TimeDelayPostChallenge.EightMinutesPostChallenge => "8M",
                TimeDelayPostChallenge.NineMinutesPostChallenge => "9M",
                TimeDelayPostChallenge.Baseline => "BS",
                TimeDelayPostChallenge.TimePostDrugDoseHighestDrugLevelReached => "PEAK",
                TimeDelayPostChallenge.TimeFromChallengeOrDoseNotSpecified => "RANDOM",
                TimeDelayPostChallenge.TimePostDrugDoseLowestDrugLevelReached => "TROUGH",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TimeSelectionCriteriaParameterClassCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TimeSelectionCriteriaParameterClassCodes input)
        {
            return input switch
            {
                TimeSelectionCriteriaParameterClassCodes.Friday => "Fri",
                TimeSelectionCriteriaParameterClassCodes.Monday => "Mon",
                TimeSelectionCriteriaParameterClassCodes.IsPreferredEndTime => "Prefend",
                TimeSelectionCriteriaParameterClassCodes.IsPreferredStartTime => "Prefstart",
                TimeSelectionCriteriaParameterClassCodes.Saturday => "Sat",
                TimeSelectionCriteriaParameterClassCodes.Sunday => "Sun",
                TimeSelectionCriteriaParameterClassCodes.Thursday => "Thu",
                TimeSelectionCriteriaParameterClassCodes.Tuesday => "Tue",
                TimeSelectionCriteriaParameterClassCodes.Wednesday => "Wed",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TissueTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TissueTypeCode input)
        {
            return input switch
            {
                TissueTypeCode.NoTissueExpected => "0",
                TissueTypeCode.InsufficientTissue => "1",
                TissueTypeCode.NotAbnormal => "2",
                TissueTypeCode.AbnormalNotCategorized => "3",
                TissueTypeCode.MechanicalAbnormal => "4",
                TissueTypeCode.GrowthAlteration => "5",
                TissueTypeCode.DegenerationNecrosis => "6",
                TissueTypeCode.NonAcuteInflammation => "7",
                TissueTypeCode.NonMalignantNeoplasm => "8",
                TissueTypeCode.MalignantNeoplasm => "9",
                TissueTypeCode.BasalCellCarcinoma => "B",
                TissueTypeCode.CarcinomaUnspecifiedType => "C",
                TissueTypeCode.AdditionalTissueRequired => "G",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TqConjunctionId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TqConjunctionId input)
        {
            return input switch
            {
                TqConjunctionId.Asynchronous => "A",
                TqConjunctionId.ActuationTime => "C",
                TqConjunctionId.Synchronous => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TransactionType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TransactionType input)
        {
            return input switch
            {
                TransactionType.Adjustment => "AJ",
                TransactionType.Credit => "CD",
                TransactionType.Charge => "CG",
                TransactionType.CoPayment => "CO",
                TransactionType.Payment => "PY",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TransferType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TransferType input)
        {
            return input switch
            {
                TransferType.DrgExempt => "E",
                TransferType.DrgNonExempt => "N",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TransfusionAdverseReaction enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TransfusionAdverseReaction input)
        {
            return input switch
            {
                TransfusionAdverseReaction.AboIncompatibleTransfusionReaction => "ABOINC",
                TransfusionAdverseReaction.AcuteHemolyticTransfusionReaction => "ACUTHEHTR",
                TransfusionAdverseReaction.AllergicReactionFirst => "ALLERGIC1",
                TransfusionAdverseReaction.AllergicReactionRecurrent => "ALLERGIC2",
                TransfusionAdverseReaction.AllergicReactionRepeating => "ALLERGICR",
                TransfusionAdverseReaction.AnaphylacticReaction => "ANAPHYLAC",
                TransfusionAdverseReaction.ReactionToBacterialContamination => "BACTCONTAM",
                TransfusionAdverseReaction.DelayedHemolyticTransfusionReaction => "DELAYEDHTR",
                TransfusionAdverseReaction.DelayedSerologicalTransfusionReaction => "DELAYEDSTR",
                TransfusionAdverseReaction.GraftVsHostDiseaseTransfusionAssociated => "GVHD",
                TransfusionAdverseReaction.NonHemolyticHypotensiveReaction => "HYPOTENS",
                TransfusionAdverseReaction.NonHemolyticFeverChillTransfusionReactionFirst => "NONHTR1",
                TransfusionAdverseReaction.NonHemolyticFeverChillTransfusionReactionRecurrent => "NONHTR2",
                TransfusionAdverseReaction.NonHemolyticFeverChillTransfusionReactionRepeating => "NONHTRREC",
                TransfusionAdverseReaction.NonImmuneHemolysis => "NONIMMUNE",
                TransfusionAdverseReaction.NonSpecificNonHemolyticTransfusionReaction => "NONSPEC",
                TransfusionAdverseReaction.NoEvidenceOfTransfusionReaction => "NORXN",
                TransfusionAdverseReaction.PosttransfusionPurpura => "PTP",
                TransfusionAdverseReaction.SymptomsMostLikelyDueToVolumeOverload => "VOLOVER",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TransportArranged enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TransportArranged input)
        {
            return input switch
            {
                TransportArranged.Arranged => "A",
                TransportArranged.NotArranged => "N",
                TransportArranged.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TransportationMode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TransportationMode input)
        {
            return input switch
            {
                TransportationMode.CartPatientTravelsOnCartOrGurney => "CART",
                TransportationMode.TheExaminingDeviceGoesToPatientsLocation => "PORT",
                TransportationMode.PatientWalksToDiagnosticService => "WALK",
                TransportationMode.Wheelchair => "WHLC",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TrayType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TrayType input)
        {
            return input switch
            {
                TrayType.EarlyTray => "EARLY",
                TrayType.GuestTray => "GUEST",
                TrayType.LateTray => "LATE",
                TrayType.TrayMessageOnly => "MSG",
                TrayType.NoTray => "NO",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Treatment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(Treatment input)
        {
            return input switch
            {
                Treatment.Acidification => "ACID",
                Treatment.Alkalization => "ALK",
                Treatment.Defibrination => "DEFB",
                Treatment.Filtration => "FILT",
                Treatment.LdlPrecipitation => "LDLP",
                Treatment.Neutralization => "NEUT",
                Treatment.Recalification => "RECA",
                Treatment.Ultrafiltration => "UFIL",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TriageCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TriageCode input)
        {
            return input switch
            {
                TriageCode.NonAcute => "1",
                TriageCode.Acute => "2",
                TriageCode.Urgent => "3",
                TriageCode.Severe => "4",
                TriageCode.DeadOnArrivalDoa => "5",
                TriageCode.Other => "99",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TypeOfAgreement enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TypeOfAgreement input)
        {
            return input switch
            {
                TypeOfAgreement.Maternity => "M",
                TypeOfAgreement.Standard => "S",
                TypeOfAgreement.Unified => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TypeOfBillCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TypeOfBillCode input)
        {
            return input switch
            {
                TypeOfBillCode.NoSuggestedValuesDefined => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given TypeOfReferencedData enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(TypeOfReferencedData input)
        {
            return input switch
            {
                TypeOfReferencedData.OtherApplicationData => "AP",
                TypeOfReferencedData.AudioData => "AU",
                TypeOfReferencedData.FormattedText => "FT",
                TypeOfReferencedData.ImageData => "IM",
                TypeOfReferencedData.MimeMultipartPackage => "multipart",
                TypeOfReferencedData.NonScannedImage => "NS",
                TypeOfReferencedData.ScannedDocument => "SD",
                TypeOfReferencedData.ScannedImage => "SI",
                TypeOfReferencedData.MachineReadableTextDocument => "TEXT",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given UniversalIdType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(UniversalIdType input)
        {
            return input switch
            {
                UniversalIdType.ClinicalLaboratoryImprovementAmendments => "CLIA",
                UniversalIdType.ClinicalLaboratoryImprovementProgram => "CLIP",
                UniversalIdType.DomainNameSystem => "DNS",
                UniversalIdType.Ieee64BitExtendedUniqueIdentifier => "EUI64",
                UniversalIdType.GloballyUniqueIdentifier => "GUID",
                UniversalIdType.CenHealthcareCodingIdentifier => "HCD",
                UniversalIdType.Hl7RegistrationSchemes => "HL7",
                UniversalIdType.IsoObjectIdentifier => "ISO",
                UniversalIdType.LocalL => "L",
                UniversalIdType.LocalLMN => "L,M,N",
                UniversalIdType.LocalM => "M",
                UniversalIdType.LocalN => "N",
                UniversalIdType.Random => "Random",
                UniversalIdType.UniformResourceIdentifier => "URI",
                UniversalIdType.UniversalUniqueIdentifier => "UUID",
                UniversalIdType.X400MhsIdentifier => "x400",
                UniversalIdType.X500DirectoryName => "x500",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given UserAuthenticationCredentialTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(UserAuthenticationCredentialTypeCode input)
        {
            return input switch
            {
                UserAuthenticationCredentialTypeCode.KerberosServiceTicket => "KERB",
                UserAuthenticationCredentialTypeCode.AuthenticatedUserIdentityAssertion => "SAML",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given VaccinesAdministered enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(VaccinesAdministered input)
        {
            return input switch
            {
                VaccinesAdministered.Dtp => "01",
                VaccinesAdministered.Opv => "02",
                VaccinesAdministered.Mmr => "03",
                VaccinesAdministered.MR => "04",
                VaccinesAdministered.Measles => "05",
                VaccinesAdministered.Rubella => "06",
                VaccinesAdministered.Mumps => "07",
                VaccinesAdministered.HepBAdolescentOrPediatric => "08",
                VaccinesAdministered.TdAdult09 => "09",
                VaccinesAdministered.Ipv => "10",
                VaccinesAdministered.PneumococcalConjugate => "100",
                VaccinesAdministered.TyphoidVicps => "101",
                VaccinesAdministered.DtpHibHepB => "102",
                VaccinesAdministered.MeningococcalCConjugate => "103",
                VaccinesAdministered.HepAHepB => "104",
                VaccinesAdministered.VacciniaSmallpoxDiluted => "105",
                VaccinesAdministered.Dtap5PertussisAntigens6 => "106",
                VaccinesAdministered.DtapNos => "107",
                VaccinesAdministered.MeningococcalNos => "108",
                VaccinesAdministered.PneumococcalNos => "109",
                VaccinesAdministered.Pertussis => "11",
                VaccinesAdministered.DtapHepBIpv => "110",
                VaccinesAdministered.InfluenzaLiveIntranasal => "111",
                VaccinesAdministered.TetanusToxoidNos => "112",
                VaccinesAdministered.TdAdult113 => "113",
                VaccinesAdministered.MeningococcalACYW135DiphtheriaConjugate => "114",
                VaccinesAdministered.Tdap => "115",
                VaccinesAdministered.RotavirusPentavalent => "116",
                VaccinesAdministered.VzigInd => "117",
                VaccinesAdministered.HpvBivalent => "118",
                VaccinesAdministered.RotavirusMonovalent => "119",
                VaccinesAdministered.DiphtheriaAntitoxin => "12",
                VaccinesAdministered.DtapHibIpv => "120",
                VaccinesAdministered.Zoster => "121",
                VaccinesAdministered.RotavirusNos1 => "122",
                VaccinesAdministered.Tig => "13",
                VaccinesAdministered.IgNos => "14",
                VaccinesAdministered.InfluenzaSplitInclPurifiedSurfaceAntigen => "15",
                VaccinesAdministered.InfluenzaWhole => "16",
                VaccinesAdministered.HibNos => "17",
                VaccinesAdministered.RabiesIntramuscularInjection => "18",
                VaccinesAdministered.Bcg => "19",
                VaccinesAdministered.Dtap => "20",
                VaccinesAdministered.Varicella => "21",
                VaccinesAdministered.DtpHib => "22",
                VaccinesAdministered.Plague => "23",
                VaccinesAdministered.Anthrax => "24",
                VaccinesAdministered.TyphoidOral => "25",
                VaccinesAdministered.Cholera => "26",
                VaccinesAdministered.BotulinumAntitoxin => "27",
                VaccinesAdministered.DtPediatric => "28",
                VaccinesAdministered.Cmvig => "29",
                VaccinesAdministered.Hbig => "30",
                VaccinesAdministered.HepAPediatricNos => "31",
                VaccinesAdministered.Meningococcal => "32",
                VaccinesAdministered.Pneumococcal => "33",
                VaccinesAdministered.Rig => "34",
                VaccinesAdministered.TetanusToxoid => "35",
                VaccinesAdministered.Vzig => "36",
                VaccinesAdministered.YellowFever => "37",
                VaccinesAdministered.RubellaMumps => "38",
                VaccinesAdministered.JapaneseEncephalitis => "39",
                VaccinesAdministered.RabiesIntradermalInjection => "40",
                VaccinesAdministered.TyphoidParenteral => "41",
                VaccinesAdministered.HepBAdolescentHighRiskInfant2 => "42",
                VaccinesAdministered.HepBAdult4 => "43",
                VaccinesAdministered.HepBDialysis => "44",
                VaccinesAdministered.HepBNos => "45",
                VaccinesAdministered.HibPrpD => "46",
                VaccinesAdministered.HibHboc => "47",
                VaccinesAdministered.HibPrpT => "48",
                VaccinesAdministered.HibPrpOmp => "49",
                VaccinesAdministered.DtapHib => "50",
                VaccinesAdministered.HibHepB => "51",
                VaccinesAdministered.HepAAdult => "52",
                VaccinesAdministered.TyphoidParenteralAkdUSMilitary => "53",
                VaccinesAdministered.AdenovirusType4 => "54",
                VaccinesAdministered.AdenovirusType7 => "55",
                VaccinesAdministered.DengueFever => "56",
                VaccinesAdministered.Hantavirus => "57",
                VaccinesAdministered.HepC => "58",
                VaccinesAdministered.HepE => "59",
                VaccinesAdministered.HerpesSimplex2 => "60",
                VaccinesAdministered.Hiv => "61",
                VaccinesAdministered.HpvQuadrivalent => "62",
                VaccinesAdministered.JuninVirus => "63",
                VaccinesAdministered.Leishmaniasis => "64",
                VaccinesAdministered.Leprosy => "65",
                VaccinesAdministered.LymeDisease => "66",
                VaccinesAdministered.Malaria => "67",
                VaccinesAdministered.Melanoma => "68",
                VaccinesAdministered.Parainfluenza3 => "69",
                VaccinesAdministered.QFever => "70",
                VaccinesAdministered.RsvIgiv => "71",
                VaccinesAdministered.RheumaticFever => "72",
                VaccinesAdministered.RiftValleyFever => "73",
                VaccinesAdministered.RotavirusTetravalent => "74",
                VaccinesAdministered.VacciniaSmallpox => "75",
                VaccinesAdministered.StaphylococcusBacterioLysate => "76",
                VaccinesAdministered.TickBorneEncephalitis => "77",
                VaccinesAdministered.TularemiaVaccine => "78",
                VaccinesAdministered.VacciniaImmuneGlobulin => "79",
                VaccinesAdministered.VeeLive => "80",
                VaccinesAdministered.VeeInactivated => "81",
                VaccinesAdministered.AdenovirusNos1 => "82",
                VaccinesAdministered.HepAPedAdol2Dose => "83",
                VaccinesAdministered.HepAPedAdol3Dose => "84",
                VaccinesAdministered.HepANos => "85",
                VaccinesAdministered.Ig => "86",
                VaccinesAdministered.Igiv => "87",
                VaccinesAdministered.InfluenzaNos => "88",
                VaccinesAdministered.PolioNos => "89",
                VaccinesAdministered.RabiesNos => "90",
                VaccinesAdministered.TyphoidNos => "91",
                VaccinesAdministered.VeeNos => "92",
                VaccinesAdministered.RsvMab => "93",
                VaccinesAdministered.Mmrv => "94",
                VaccinesAdministered.TstOtTineTest => "95",
                VaccinesAdministered.TstPpdIntradermal => "96",
                VaccinesAdministered.TstPpdTineTest => "97",
                VaccinesAdministered.TstNos => "98",
                VaccinesAdministered.ReservedDoNotUse3 => "99",
                VaccinesAdministered.NoVaccineAdministered5 => "998",
                VaccinesAdministered.Unknown => "999",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ValueCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ValueCode input)
        {
            return input switch
            {
                ValueCode.SeeNubcCodesADeprecated => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given VersionId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(VersionId input)
        {
            return input switch
            {
                VersionId.Release20 => "2.0",
                VersionId.Demo20 => "2.0D",
                VersionId.Release21 => "2.1",
                VersionId.Release22 => "2.2",
                VersionId.Release23 => "2.3",
                VersionId.Release231 => "2.3.1",
                VersionId.Release24 => "2.4",
                VersionId.Release25 => "2.5",
                VersionId.Release251 => "2.5.1",
                VersionId.Release26 => "2.6",
                VersionId.Release27 => "2.7",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given VisitIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(VisitIndicator input)
        {
            return input switch
            {
                VisitIndicator.AccountLevel => "A",
                VisitIndicator.VisitLevel => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given VisitPriorityCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(VisitPriorityCode input)
        {
            return input switch
            {
                VisitPriorityCode.Emergency => "1",
                VisitPriorityCode.Urgent => "2",
                VisitPriorityCode.Elective => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given VisitUserCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(VisitUserCode input)
        {
            return input switch
            {
                VisitUserCode.Home => "HO",
                VisitUserCode.MobileUnit => "MO",
                VisitUserCode.Phone => "PH",
                VisitUserCode.Teaching => "TE",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given YesNoIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(YesNoIndicator input)
        {
            return input switch
            {
                YesNoIndicator.No => "N",
                YesNoIndicator.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }
    }
}