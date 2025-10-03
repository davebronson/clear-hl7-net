using System;

namespace ClearHl7.Codes.V271.Helpers
{
    /// <summary>
    /// Provides helper methods for interacting with enumerations.
    /// Static methods are available for optimal performance.
    /// </summary>
    public class EnumHelper : IEnumHelper
    {
        /// <summary>
        /// Converts the given CodeAcceptApplicationAcknowledgmentConditions enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAcceptApplicationAcknowledgmentConditions input)
        {
            return input switch
            {
                CodeAcceptApplicationAcknowledgmentConditions.Always => "AL",
                CodeAcceptApplicationAcknowledgmentConditions.ErrorRejectConditionsOnly => "ER",
                CodeAcceptApplicationAcknowledgmentConditions.Never => "NE",
                CodeAcceptApplicationAcknowledgmentConditions.SuccessfulCompletionOnly => "SU",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAcceptApplicationAcknowledgmentConditions input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAccessRestrictionReasonCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAccessRestrictionReasonCode input)
        {
            return input switch
            {
                CodeAccessRestrictionReasonCode.DiagnosisRelated => "DIA",
                CodeAccessRestrictionReasonCode.EmployeeOfThisOrganization => "EMP",
                CodeAccessRestrictionReasonCode.OrganizationalPolicyOrRequirement => "ORG",
                CodeAccessRestrictionReasonCode.PatientRequest => "PAT",
                CodeAccessRestrictionReasonCode.PhysicianRequest => "PHY",
                CodeAccessRestrictionReasonCode.RegulatoryRequirement => "REG",
                CodeAccessRestrictionReasonCode.VeryImportantPersonOrCelebrity => "VIP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAccessRestrictionReasonCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAccessRestrictionValue enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAccessRestrictionValue input)
        {
            return input switch
            {
                CodeAccessRestrictionValue.All => "ALL",
                CodeAccessRestrictionValue.AllDemographicData => "DEM",
                CodeAccessRestrictionValue.Drug => "DRG",
                CodeAccessRestrictionValue.HivStatusAndResults => "HIV",
                CodeAccessRestrictionValue.PatientLocation => "LOC",
                CodeAccessRestrictionValue.None => "NO",
                CodeAccessRestrictionValue.OptInAllRegistriesHipaa => "OI",
                CodeAccessRestrictionValue.OptOutAllRegistriesHipaa => "OO",
                CodeAccessRestrictionValue.Religion => "PID-17",
                CodeAccessRestrictionValue.DateOfBirth => "PID-7",
                CodeAccessRestrictionValue.PsychiatricMentalHealth => "PSY",
                CodeAccessRestrictionValue.SensitiveMedicalData => "SMD",
                CodeAccessRestrictionValue.SexuallyTransmittedDiseases => "STD",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAccessRestrictionValue input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAcknowledgmentCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAcknowledgmentCode input)
        {
            return input switch
            {
                CodeAcknowledgmentCode.OriginalModeAcceptEnhancedModeAcknowledgmentAccept => "AA",
                CodeAcknowledgmentCode.OriginalModeErrorEnhancedModeAcknowledgmentError => "AE",
                CodeAcknowledgmentCode.OriginalModeRejectEnhancedModeAcknowledgmentReject => "AR",
                CodeAcknowledgmentCode.EnhancedModeAcceptAcknowledgmentCommitAccept => "CA",
                CodeAcknowledgmentCode.EnhancedModeAcceptAcknowledgmentCommitError => "CE",
                CodeAcknowledgmentCode.EnhancedModeAcceptAcknowledgmentCommitReject => "CR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAcknowledgmentCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeActionTakenInResponseToTheEvent enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeActionTakenInResponseToTheEvent input)
        {
            return input switch
            {
                CodeActionTakenInResponseToTheEvent.ProductDoseIncreased => "DI",
                CodeActionTakenInResponseToTheEvent.ProductDoseReduced => "DR",
                CodeActionTakenInResponseToTheEvent.None => "N",
                CodeActionTakenInResponseToTheEvent.Other => "OT",
                CodeActionTakenInResponseToTheEvent.ProductWithdrawnPermanently => "WP",
                CodeActionTakenInResponseToTheEvent.ProductWithdrawnTemporarily => "WT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeActionTakenInResponseToTheEvent input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeActiveInactive enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeActiveInactive input)
        {
            return input switch
            {
                CodeActiveInactive.ActiveStaff => "A",
                CodeActiveInactive.InactiveStaff => "I",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeActiveInactive input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeActPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeActPriority input)
        {
            return input switch
            {
                CodeActPriority.AsSoonAsPossible => "A",
                CodeActPriority.CallbackResults => "CR",
                CodeActPriority.CallbackForScheduling => "CS",
                CodeActPriority.CallbackPlacerForScheduling => "CSP",
                CodeActPriority.ContactRecipientForScheduling => "CSR",
                CodeActPriority.Elective => "EL",
                CodeActPriority.Emergency => "EM",
                CodeActPriority.Preop => "P",
                CodeActPriority.AsNeeded => "PRN",
                CodeActPriority.Routine => "R",
                CodeActPriority.RushReporting => "RR",
                CodeActPriority.Stat => "S",
                CodeActPriority.TimingCritical => "T",
                CodeActPriority.UseAsDirected => "UD",
                CodeActPriority.Urgent => "UR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeActPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdditivePreservative enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdditivePreservative input)
        {
            return input switch
            {
                CodeAdditivePreservative.AcdSolutionA => "ACDA",
                CodeAdditivePreservative.AcdSolutionB => "ACDB",
                CodeAdditivePreservative.AceticAcid => "ACET",
                CodeAdditivePreservative.AmiesTransportMedium => "AMIES",
                CodeAdditivePreservative.BacterialTransportMedium => "BACTM",
                CodeAdditivePreservative.Buffered10Formalin => "BF10",
                CodeAdditivePreservative.BorateBoricAcid => "BOR",
                CodeAdditivePreservative.BouinsSolution => "BOUIN",
                CodeAdditivePreservative.BufferedSkimMilk => "BSKM",
                CodeAdditivePreservative.ThreePointTwoPercentCitrate => "C32",
                CodeAdditivePreservative.ThreePointEightPercentCitrate => "C38",
                CodeAdditivePreservative.CarsonsModified10Formalin => "CARS",
                CodeAdditivePreservative.CaryBlairMedium => "CARY",
                CodeAdditivePreservative.ChlamydiaTransportMedium => "CHLTM",
                CodeAdditivePreservative.Ctad => "CTAD",
                CodeAdditivePreservative.PotassiumKEdta => "EDTK",
                CodeAdditivePreservative.PotassiumKEdta15 => "EDTK15",
                CodeAdditivePreservative.PotassiumKEdta75 => "EDTK75",
                CodeAdditivePreservative.SodiumNaEdta => "EDTN",
                CodeAdditivePreservative.EntericBacteriaTransportMedium => "ENT",
                CodeAdditivePreservative.EntericPlus => "ENT+",
                CodeAdditivePreservative.TenPercentFormalin => "F10",
                CodeAdditivePreservative.ThrombinNih => "FDP",
                CodeAdditivePreservative.SodiumFluoride10Mg => "FL10",
                CodeAdditivePreservative.SodiumFluoride100Mg => "FL100",
                CodeAdditivePreservative.SixNHcl => "HCL6",
                CodeAdditivePreservative.AmmoniumHeparin => "HEPA",
                CodeAdditivePreservative.LithiumLiHeparin => "HEPL",
                CodeAdditivePreservative.SodiumNaHeparin => "HEPN",
                CodeAdditivePreservative.NitricAcid => "HNO3",
                CodeAdditivePreservative.JonesKendrickMedium => "JKM",
                CodeAdditivePreservative.KarnovskysFixative => "KARN",
                CodeAdditivePreservative.PotassiumOxalate => "KOX",
                CodeAdditivePreservative.LithiumIodoacetate => "LIA",
                CodeAdditivePreservative.M4 => "M4",
                CodeAdditivePreservative.M4Rt => "M4RT",
                CodeAdditivePreservative.M5 => "M5",
                CodeAdditivePreservative.MichelsTransportMedium => "MICHTM",
                CodeAdditivePreservative.MmdTransportMedium => "MMDTM",
                CodeAdditivePreservative.SodiumFluoride => "NAF",
                CodeAdditivePreservative.SodiumPolyanetholSulfonate035 => "NAPS",
                CodeAdditivePreservative.None => "NONE",
                CodeAdditivePreservative.PagessSaline => "PAGE",
                CodeAdditivePreservative.Phenol => "PHENOL",
                CodeAdditivePreservative.PvaPolyvinylalcohol => "PVA",
                CodeAdditivePreservative.ReaganLoweMedium => "RLM",
                CodeAdditivePreservative.SiliceousEarth12Mg => "SILICA",
                CodeAdditivePreservative.Sps => "SPS",
                CodeAdditivePreservative.SerumSeparatorTubePolymerGel => "SST",
                CodeAdditivePreservative.StuartTransportMedium => "STUTM",
                CodeAdditivePreservative.Thrombin => "THROM",
                CodeAdditivePreservative.Thymol => "THYMOL",
                CodeAdditivePreservative.ThyoglycollateBroth => "THYO",
                CodeAdditivePreservative.Toluene => "TOLU",
                CodeAdditivePreservative.UreaplasmaTransportMedium => "URETM",
                CodeAdditivePreservative.ViralTransportMedium => "VIRTM",
                CodeAdditivePreservative.BufferedCitrate => "WEST",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdditivePreservative input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAddressExpirationReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAddressExpirationReason input)
        {
            return input switch
            {
                CodeAddressExpirationReason.Corrected => "C",
                CodeAddressExpirationReason.AddedInError => "E",
                CodeAddressExpirationReason.Moved => "M",
                CodeAddressExpirationReason.OnRequest => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAddressExpirationReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAddressType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAddressType input)
        {
            return input switch
            {
                CodeAddressType.FirmBusiness => "B",
                CodeAddressType.BadAddress => "BA",
                CodeAddressType.BirthDeliveryLocation => "BDL",
                CodeAddressType.BillingAddress => "BI",
                CodeAddressType.ResidenceAtBirth => "BR",
                CodeAddressType.CurrentOrTemporary => "C",
                CodeAddressType.CountryOfOrigin => "F",
                CodeAddressType.Home => "H",
                CodeAddressType.LegalAddress => "L",
                CodeAddressType.Mailing => "M",
                CodeAddressType.BirthNee => "N",
                CodeAddressType.OfficeBusiness => "O",
                CodeAddressType.Permanent => "P",
                CodeAddressType.RegistryHome => "RH",
                CodeAddressType.ServiceLocation => "S",
                CodeAddressType.ShippingAddress => "SH",
                CodeAddressType.TubeAddress => "TM",
                CodeAddressType.Vacation => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAddressType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAddressUsage enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAddressUsage input)
        {
            return input switch
            {
                CodeAddressUsage.Classification => "C",
                CodeAddressUsage.Mailing => "M",
                CodeAddressUsage.Visit => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAddressUsage input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdjustmentAction enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdjustmentAction input)
        {
            return input switch
            {
                CodeAdjustmentAction.PrintOnEob => "EOB",
                CodeAdjustmentAction.InformPatient => "PAT",
                CodeAdjustmentAction.InformProvider => "PRO",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdjustmentAction input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdjustmentCategoryCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdjustmentCategoryCode input)
        {
            return input switch
            {
                CodeAdjustmentCategoryCode.EditAdjudicationResponse => "EA",
                CodeAdjustmentCategoryCode.Information => "IN",
                CodeAdjustmentCategoryCode.ProviderAdjustment => "PA",
                CodeAdjustmentCategoryCode.ProcessingResult => "PR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdjustmentCategoryCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdministrationDevice enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdministrationDevice input)
        {
            return input switch
            {
                CodeAdministrationDevice.Applicator => "AP",
                CodeAdministrationDevice.Buretrol => "BT",
                CodeAdministrationDevice.HeparinLock => "HL",
                CodeAdministrationDevice.Ippb => "IPPB",
                CodeAdministrationDevice.IvPump => "IVP",
                CodeAdministrationDevice.IvSoluset => "IVS",
                CodeAdministrationDevice.MeteredInhaler => "MI",
                CodeAdministrationDevice.Nebulizer => "NEB",
                CodeAdministrationDevice.PcaPump => "PCA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdministrationDevice input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdministrationMethod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdministrationMethod input)
        {
            return input switch
            {
                CodeAdministrationMethod.Chew => "CH",
                CodeAdministrationMethod.Dissolve => "DI",
                CodeAdministrationMethod.Dust => "DU",
                CodeAdministrationMethod.Infiltrate => "IF",
                CodeAdministrationMethod.Irrigate => "IR",
                CodeAdministrationMethod.Insert => "IS",
                CodeAdministrationMethod.IvPush => "IVP",
                CodeAdministrationMethod.IvPiggyback => "IVPB",
                CodeAdministrationMethod.Nebulized => "NB",
                CodeAdministrationMethod.Perfuse => "PF",
                CodeAdministrationMethod.Paint => "PT",
                CodeAdministrationMethod.Shampoo => "SH",
                CodeAdministrationMethod.Soak => "SO",
                CodeAdministrationMethod.Wash => "WA",
                CodeAdministrationMethod.Wipe => "WI",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdministrationMethod input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdministrativeSex enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdministrativeSex input)
        {
            return input switch
            {
                CodeAdministrativeSex.Ambiguous => "A",
                CodeAdministrativeSex.Female => "F",
                CodeAdministrativeSex.Male => "M",
                CodeAdministrativeSex.NotApplicable => "N",
                CodeAdministrativeSex.Other => "O",
                CodeAdministrativeSex.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdministrativeSex input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdmissionLevelOfCareCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdmissionLevelOfCareCode input)
        {
            return input switch
            {
                CodeAdmissionLevelOfCareCode.Acute => "AC",
                CodeAdmissionLevelOfCareCode.Chronic => "CH",
                CodeAdmissionLevelOfCareCode.Comatose => "CO",
                CodeAdmissionLevelOfCareCode.Critical => "CR",
                CodeAdmissionLevelOfCareCode.Improved => "IM",
                CodeAdmissionLevelOfCareCode.Moribund => "MO",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdmissionLevelOfCareCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdmissionType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdmissionType input)
        {
            return input switch
            {
                CodeAdmissionType.Accident => "A",
                CodeAdmissionType.Elective => "C",
                CodeAdmissionType.Emergency => "E",
                CodeAdmissionType.LaborAndDelivery => "L",
                CodeAdmissionType.NewbornBirthInHealthcareFacility => "N",
                CodeAdmissionType.Routine => "R",
                CodeAdmissionType.Urgent => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdmissionType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdmitSource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdmitSource input)
        {
            return input switch
            {
                CodeAdmitSource.NoSuggestedValuesDefined => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdmitSource input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdvancedBeneficiaryNoticeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdvancedBeneficiaryNoticeCode input)
        {
            return input switch
            {
                CodeAdvancedBeneficiaryNoticeCode.ServiceSubjectToMedicalNecessity => "1",
                CodeAdvancedBeneficiaryNoticeCode.PatientHasBeenInformedAndAgreesToPayForService => "2",
                CodeAdvancedBeneficiaryNoticeCode.PatientHasBeenInformedAndAsksThatPayerBeBilled => "3",
                CodeAdvancedBeneficiaryNoticeCode.AdvancedBeneficiaryNoticeHasNotBeenSigned => "4",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdvancedBeneficiaryNoticeCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdvanceDirectiveCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdvanceDirectiveCode input)
        {
            return input switch
            {
                CodeAdvanceDirectiveCode.DoNotResuscitate => "DNR",
                CodeAdvanceDirectiveCode.NoDirective => "N",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdvanceDirectiveCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAlertDeviceCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAlertDeviceCode input)
        {
            return input switch
            {
                CodeAlertDeviceCode.Bracelet => "B",
                CodeAlertDeviceCode.Necklace => "N",
                CodeAlertDeviceCode.WalletCard => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAlertDeviceCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAlertLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAlertLevel input)
        {
            return input switch
            {
                CodeAlertLevel.NullNoLevelChangeADeprecated => "...",
                CodeAlertLevel.Critical => "C",
                CodeAlertLevel.Normal => "N",
                CodeAlertLevel.Serious => "S",
                CodeAlertLevel.Warning => "W",
                CodeAlertLevel.NullNoLevelChangeBDeprecated => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAlertLevel input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAllergenType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAllergenType input)
        {
            return input switch
            {
                CodeAllergenType.AnimalAllergy => "AA",
                CodeAllergenType.DrugAllergy => "DA",
                CodeAllergenType.EnvironmentalAllergy => "EA",
                CodeAllergenType.FoodAllergy => "FA",
                CodeAllergenType.PollenAllergy => "LA",
                CodeAllergenType.MiscellaneousAllergy => "MA",
                CodeAllergenType.MiscellaneousContraindication => "MC",
                CodeAllergenType.PlantAllergy => "PA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAllergenType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAllergyClinicalStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAllergyClinicalStatus input)
        {
            return input switch
            {
                CodeAllergyClinicalStatus.ConfirmedOrVerified => "C",
                CodeAllergyClinicalStatus.DoubtRaised => "D",
                CodeAllergyClinicalStatus.Erroneous => "E",
                CodeAllergyClinicalStatus.ConfirmedButInactive => "I",
                CodeAllergyClinicalStatus.Pending => "P",
                CodeAllergyClinicalStatus.Suspect => "S",
                CodeAllergyClinicalStatus.Unconfirmed => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAllergyClinicalStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAllergySeverity enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAllergySeverity input)
        {
            return input switch
            {
                CodeAllergySeverity.Mild => "MI",
                CodeAllergySeverity.Moderate => "MO",
                CodeAllergySeverity.Severe => "SV",
                CodeAllergySeverity.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAllergySeverity input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAllowSubstitution enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAllowSubstitution input)
        {
            return input switch
            {
                CodeAllowSubstitution.AllowGenericSubstitutions => "G",
                CodeAllowSubstitution.SubstitutionsAreNotAuthorized => "N",
                CodeAllowSubstitution.AllowTherapeuticSubstitutions => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAllowSubstitution input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAllowSubstitutionCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAllowSubstitutionCodes input)
        {
            return input switch
            {
                CodeAllowSubstitutionCodes.ContactPlacerPriorToSubstitution => "Confirm",
                CodeAllowSubstitutionCodes.SubstitutionIsNotAllowed => "No",
                CodeAllowSubstitutionCodes.NotifyPlacerThatSubstitutionHasBeenMade => "Notify",
                CodeAllowSubstitutionCodes.SubstitutionOfThisResourceIsAllowed => "Yes",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAllowSubstitutionCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAlternateCharacterSetHandlingScheme enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAlternateCharacterSetHandlingScheme input)
        {
            return input switch
            {
                CodeAlternateCharacterSetHandlingScheme.CharacterSetSwitchingXpnExtendedPersonName => "2.3",
                CodeAlternateCharacterSetHandlingScheme.NoCharacterSetSwitching => "null",
                CodeAlternateCharacterSetHandlingScheme.Iso20221994 => "ISO 2022-1994",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAlternateCharacterSetHandlingScheme input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAlternateCharacterSets enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAlternateCharacterSets input)
        {
            return input switch
            {
                CodeAlternateCharacterSets.Iso88591CharacterSet => "8859/1",
                CodeAlternateCharacterSets.Iso885915Latin15 => "8859/15",
                CodeAlternateCharacterSets.Iso88592CharacterSet => "8859/2",
                CodeAlternateCharacterSets.Iso88593CharacterSet => "8859/3",
                CodeAlternateCharacterSets.Iso88594CharacterSet => "8859/4",
                CodeAlternateCharacterSets.Iso88595CharacterSet => "8859/5",
                CodeAlternateCharacterSets.Iso88596CharacterSet => "8859/6",
                CodeAlternateCharacterSets.Iso88597CharacterSet => "8859/7",
                CodeAlternateCharacterSets.Iso88598CharacterSet => "8859/8",
                CodeAlternateCharacterSets.Iso88599CharacterSet => "8859/9",
                CodeAlternateCharacterSets.Seven7BitAsciiCharacterSet => "ASCII",
                CodeAlternateCharacterSets.TaiwaneseBig5 => "BIG-5",
                CodeAlternateCharacterSets.TaiwaneseCns116431992 => "CNS 11643-1992",
                CodeAlternateCharacterSets.ChineseGb180302000 => "GB 18030-2000",
                CodeAlternateCharacterSets.InfoExchangeOneByteJisX02011976 => "ISO IR14",
                CodeAlternateCharacterSets.JapaneseGraphicJisX02121990 => "ISO IR159",
                CodeAlternateCharacterSets.AsciiGraphic94Characters => "ISO IR6",
                CodeAlternateCharacterSets.JapaneseGraphicJisX02081990 => "ISO IR87",
                CodeAlternateCharacterSets.KoreanKsX1001 => "KS X 1001",
                CodeAlternateCharacterSets.IsoIec1064611993 => "UNICODE",
                CodeAlternateCharacterSets.UcsTransformationFormat16Bit => "UNICODE UTF-16",
                CodeAlternateCharacterSets.UcsTransformationFormat32Bit => "UNICODE UTF-32",
                CodeAlternateCharacterSets.UcsTransformationFormat8Bit => "UNICODE UTF-8",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAlternateCharacterSets input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAmbulatoryPaymentClassificationCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAmbulatoryPaymentClassificationCode input)
        {
            return input switch
            {
                CodeAmbulatoryPaymentClassificationCode.NoSuggestedValuesDefined => "...",
                CodeAmbulatoryPaymentClassificationCode.DentalProcedures => "031",
                CodeAmbulatoryPaymentClassificationCode.ExcisionBiopsy => "163",
                CodeAmbulatoryPaymentClassificationCode.Level1SkinRepair => "181",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAmbulatoryPaymentClassificationCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAmbulatoryStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAmbulatoryStatus input)
        {
            return input switch
            {
                CodeAmbulatoryStatus.NoFunctionalLimitations => "A0",
                CodeAmbulatoryStatus.AmbulatesWithAssistiveDevice => "A1",
                CodeAmbulatoryStatus.WheelchairStretcherBound => "A2",
                CodeAmbulatoryStatus.ComatoseNonResponsive => "A3",
                CodeAmbulatoryStatus.Disoriented => "A4",
                CodeAmbulatoryStatus.VisionImpaired => "A5",
                CodeAmbulatoryStatus.HearingImpaired => "A6",
                CodeAmbulatoryStatus.SpeechImpaired => "A7",
                CodeAmbulatoryStatus.NonEnglishSpeaking => "A8",
                CodeAmbulatoryStatus.FunctionalLevelUnknown => "A9",
                CodeAmbulatoryStatus.OxygenTherapy => "B1",
                CodeAmbulatoryStatus.SpecialEquipmentTubesIvsCatheters => "B2",
                CodeAmbulatoryStatus.Amputee => "B3",
                CodeAmbulatoryStatus.Mastectomy => "B4",
                CodeAmbulatoryStatus.Paraplegic => "B5",
                CodeAmbulatoryStatus.Pregnant => "B6",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAmbulatoryStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAmountClass enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAmountClass input)
        {
            return input switch
            {
                CodeAmountClass.Amount => "AT",
                CodeAmountClass.Limit => "LM",
                CodeAmountClass.Percentage => "PC",
                CodeAmountClass.Unlimited => "UL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAmountClass input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAmountType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAmountType input)
        {
            return input switch
            {
                CodeAmountType.Differential => "DF",
                CodeAmountType.Limit => "LM",
                CodeAmountType.Percentage => "PC",
                CodeAmountType.Rate => "RT",
                CodeAmountType.Unlimited => "UL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAmountType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAnalyteRepeatStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAnalyteRepeatStatus input)
        {
            return input switch
            {
                CodeAnalyteRepeatStatus.RepeatedWithDilution => "D",
                CodeAnalyteRepeatStatus.ReflexTest => "F",
                CodeAnalyteRepeatStatus.OriginalFirstRun => "O",
                CodeAnalyteRepeatStatus.RepeatedWithoutDilution => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAnalyteRepeatStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAnnotations enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAnnotations input)
        {
            return input switch
            {
                CodeAnnotations.PaceSpike => "9900",
                CodeAnnotations.SasMarker => "9901",
                CodeAnnotations.SenseMarker => "9902",
                CodeAnnotations.BeatMarker => "9903",
                CodeAnnotations.Etc => "9904",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAnnotations input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeApplicationChangeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeApplicationChangeType input)
        {
            return input switch
            {
                CodeApplicationChangeType.MigratesToDifferentCpu => "M",
                CodeApplicationChangeType.ShutDown => "SD",
                CodeApplicationChangeType.StartUp => "SU",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeApplicationChangeType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAppointmentReasonCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAppointmentReasonCodes input)
        {
            return input switch
            {
                CodeAppointmentReasonCodes.ARoutineCheckUpSuchAsAnAnnualPhysical => "CHECKUP",
                CodeAppointmentReasonCodes.EmergencyAppointment => "EMERGENCY",
                CodeAppointmentReasonCodes.AFollowUpVisitFromAPreviousAppointment => "FOLLOWUP",
                CodeAppointmentReasonCodes.RoutineAppointmentDefaultIfNotValued => "ROUTINE",
                CodeAppointmentReasonCodes.APreviouslyUnscheduledWalkInVisit => "WALKIN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAppointmentReasonCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAppointmentTypeCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAppointmentTypeCodes input)
        {
            return input switch
            {
                CodeAppointmentTypeCodes.RequestToAddCompletedAppointment => "Complete",
                CodeAppointmentTypeCodes.RoutineScheduleRequestTypeDefaultIfNotValued => "Normal",
                CodeAppointmentTypeCodes.RequestForTentativeAppointment => "Tentative",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAppointmentTypeCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeApprovingRegulatoryAgency enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeApprovingRegulatoryAgency input)
        {
            return input switch
            {
                CodeApprovingRegulatoryAgency.AmericanMedicalAssociation => "AMA",
                CodeApprovingRegulatoryAgency.FoodAndDrugAdministration => "FDA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeApprovingRegulatoryAgency input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeArtificialBlood enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeArtificialBlood input)
        {
            return input switch
            {
                CodeArtificialBlood.Fluorocarbons => "FLUR",
                CodeArtificialBlood.StromalFreeHemoglobinPreparations => "SFHB",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeArtificialBlood input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAssigningAuthority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAssigningAuthority input)
        {
            return input switch
            {
                CodeAssigningAuthority.NoSuggestedValuesDefined => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAssigningAuthority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAssignmentOfBenefits enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAssignmentOfBenefits input)
        {
            return input switch
            {
                CodeAssignmentOfBenefits.ModifiedAssignment => "M",
                CodeAssignmentOfBenefits.No => "N",
                CodeAssignmentOfBenefits.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAssignmentOfBenefits input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAuthorizationMode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAuthorizationMode input)
        {
            return input switch
            {
                CodeAuthorizationMode.Electronic => "EL",
                CodeAuthorizationMode.EMail => "EM",
                CodeAuthorizationMode.Fax => "FX",
                CodeAuthorizationMode.InPerson => "IP",
                CodeAuthorizationMode.Mail => "MA",
                CodeAuthorizationMode.Paper => "PA",
                CodeAuthorizationMode.Phone => "PH",
                CodeAuthorizationMode.ReflexiveAutomatedSystem => "RE",
                CodeAuthorizationMode.VideoConference => "VC",
                CodeAuthorizationMode.Voice => "VO",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAuthorizationMode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeBedStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeBedStatus input)
        {
            return input switch
            {
                CodeBedStatus.Closed => "C",
                CodeBedStatus.Housekeeping => "H",
                CodeBedStatus.Isolated => "I",
                CodeBedStatus.Contaminated => "K",
                CodeBedStatus.Occupied => "O",
                CodeBedStatus.Unoccupied => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeBedStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeBenefitGroup enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeBenefitGroup input)
        {
            return input switch
            {
                CodeBenefitGroup.AmbulatoryCare => "AMB",
                CodeBenefitGroup.Dental => "DENT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeBenefitGroup input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeBloodProductCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeBloodProductCode input)
        {
            return input switch
            {
                CodeBloodProductCode.CryoprecipitatedAhf => "CRYO",
                CodeBloodProductCode.PooledCryoprecipitate => "CRYOP",
                CodeBloodProductCode.FreshFrozenPlasma => "FFP",
                CodeBloodProductCode.FreshFrozenPlasmaThawed => "FFPTH",
                CodeBloodProductCode.PackedCells => "PC",
                CodeBloodProductCode.AutologousPackedCells => "PCA",
                CodeBloodProductCode.PackedCellsNeonatal => "PCNEO",
                CodeBloodProductCode.WashedPackedCells => "PCW",
                CodeBloodProductCode.PlateletConcentrate => "PLT",
                CodeBloodProductCode.ReducedVolumePlatelets => "PLTNEO",
                CodeBloodProductCode.PooledPlatelets => "PLTP",
                CodeBloodProductCode.PlateletPheresis => "PLTPH",
                CodeBloodProductCode.LeukoreducedPlateletPheresis => "PLTPHLR",
                CodeBloodProductCode.ReconstitutedWholeBlood => "RWB",
                CodeBloodProductCode.AutologousWholeBlood => "WBA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeBloodProductCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeBloodProductDispenseStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeBloodProductDispenseStatus input)
        {
            return input switch
            {
                CodeBloodProductDispenseStatus.ReleasedIntoInventory => "CR",
                CodeBloodProductDispenseStatus.DispensedToPatient => "DS",
                CodeBloodProductDispenseStatus.PresumedTransfused => "PT",
                CodeBloodProductDispenseStatus.ReturnedUnused => "RA",
                CodeBloodProductDispenseStatus.ReservedAndReadyToDispense => "RD",
                CodeBloodProductDispenseStatus.ReleasedNoLongerAllocated => "RE",
                CodeBloodProductDispenseStatus.ReceivedIntoInventory => "RI",
                CodeBloodProductDispenseStatus.ReturnedUnusedKeepLinkedToPatient => "RL",
                CodeBloodProductDispenseStatus.RequestToDispenseBloodProduct => "RQ",
                CodeBloodProductDispenseStatus.Reserved => "RS",
                CodeBloodProductDispenseStatus.Wasted => "WA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeBloodProductDispenseStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeBloodProductProcessingRequirements enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeBloodProductProcessingRequirements input)
        {
            return input switch
            {
                CodeBloodProductProcessingRequirements.AutologousUnit => "AU",
                CodeBloodProductProcessingRequirements.CmvNegative => "CM",
                CodeBloodProductProcessingRequirements.CmvSafe => "CS",
                CodeBloodProductProcessingRequirements.DirectedUnit => "DI",
                CodeBloodProductProcessingRequirements.FreshUnit => "FR",
                CodeBloodProductProcessingRequirements.HemoglobinSNegative => "HB",
                CodeBloodProductProcessingRequirements.HlaMatched => "HL",
                CodeBloodProductProcessingRequirements.IgaDeficient => "IG",
                CodeBloodProductProcessingRequirements.Irradiated => "IR",
                CodeBloodProductProcessingRequirements.Leukoreduced => "LR",
                CodeBloodProductProcessingRequirements.Washed => "WA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeBloodProductProcessingRequirements input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeBloodProductTransfusionDispositionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeBloodProductTransfusionDispositionStatus input)
        {
            return input switch
            {
                CodeBloodProductTransfusionDispositionStatus.ReturnedUnused => "RA",
                CodeBloodProductTransfusionDispositionStatus.ReturnedUnusedKeepLinkedToPatient => "RL",
                CodeBloodProductTransfusionDispositionStatus.TransfusedWithAdverseReaction => "TR",
                CodeBloodProductTransfusionDispositionStatus.Transfused => "TX",
                CodeBloodProductTransfusionDispositionStatus.Wasted => "WA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeBloodProductTransfusionDispositionStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeBodyParts enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeBodyParts input)
        {
            return input switch
            {
                CodeBodyParts.Acetabulum => "ACET",
                CodeBodyParts.Achilles => "ACHIL",
                CodeBodyParts.Abdomen => "ADB",
                CodeBodyParts.Adenoids => "ADE",
                CodeBodyParts.Adrenal => "ADR",
                CodeBodyParts.AmnioticFluid => "AMN",
                CodeBodyParts.AmnioticSac => "AMS",
                CodeBodyParts.Anal => "ANAL",
                CodeBodyParts.Ankle => "ANKL",
                CodeBodyParts.Antecubital => "ANTEC",
                CodeBodyParts.AntecubitalFossa => "ANTECF",
                CodeBodyParts.Antrum => "ANTR",
                CodeBodyParts.Anus => "ANUS",
                CodeBodyParts.Aorta => "AORTA",
                CodeBodyParts.Appendix => "APDX",
                CodeBodyParts.AorticRim => "AR",
                CodeBodyParts.Areola => "AREO",
                CodeBodyParts.Arm => "ARM",
                CodeBodyParts.Artery => "ARTE",
                CodeBodyParts.Ascites => "ASCIT",
                CodeBodyParts.AsciticFluid => "ASCT",
                CodeBodyParts.Atrium => "ATR",
                CodeBodyParts.Auricular => "AURI",
                CodeBodyParts.AorticValve => "AV",
                CodeBodyParts.Axilla => "AXI",
                CodeBodyParts.Back => "BACK",
                CodeBodyParts.BartholinDuct => "BARTD",
                CodeBodyParts.BartholinGland => "BARTG",
                CodeBodyParts.BrainCystFluid => "BCYS",
                CodeBodyParts.BodyWhole => "BDY",
                CodeBodyParts.BileDuct => "BID",
                CodeBodyParts.BileFluid => "BIFL",
                CodeBodyParts.Bladder => "BLAD",
                CodeBodyParts.BloodWhole => "BLD",
                CodeBodyParts.BloodArterial => "BLDA",
                CodeBodyParts.BloodCapillary => "BLDC",
                CodeBodyParts.BloodVenous => "BLDV",
                CodeBodyParts.Blood => "BLOOD",
                CodeBodyParts.BoneMarrow => "BMAR",
                CodeBodyParts.Bone => "BON",
                CodeBodyParts.Bowel => "BOWEL",
                CodeBodyParts.BowelLarge => "BOWLA",
                CodeBodyParts.BowelSmall => "BOWSM",
                CodeBodyParts.Basophils => "BPH",
                CodeBodyParts.Brachial => "BRA",
                CodeBodyParts.Brain => "BRAIN",
                CodeBodyParts.Bronchial => "BRO",
                CodeBodyParts.BronchioleBronchiolar => "BROCH",
                CodeBodyParts.BronchusBronchial => "BRONC",
                CodeBodyParts.Eyebrow => "BROW",
                CodeBodyParts.Breast => "BRST",
                CodeBodyParts.BreastFluid => "BRSTFL",
                CodeBodyParts.BartholinGlandFluid => "BRTGF",
                CodeBodyParts.Broviac => "BRV",
                CodeBodyParts.Buccal => "BUCCA",
                CodeBodyParts.Bursa => "BURSA",
                CodeBodyParts.BursaFluid => "BURSF",
                CodeBodyParts.Buttocks => "BUTT",
                CodeBodyParts.Calf => "CALF",
                CodeBodyParts.Canal => "CANAL",
                CodeBodyParts.Canaliculis => "CANLI",
                CodeBodyParts.Canthus => "CANTH",
                CodeBodyParts.Carotid => "CARO",
                CodeBodyParts.Carpal => "CARP",
                CodeBodyParts.Cavity => "CAVIT",
                CodeBodyParts.BloodCord => "CBLD",
                CodeBodyParts.CardiacMuscle => "CDM",
                CodeBodyParts.CommonDuct => "CDUCT",
                CodeBodyParts.CecumCecal => "CECUM",
                CodeBodyParts.CervixUterus => "CERVUT",
                CodeBodyParts.CavityChest => "CHE",
                CodeBodyParts.Cheek => "CHEEK",
                CodeBodyParts.Chest => "CHES",
                CodeBodyParts.ChestTube => "CHESTÃ‚",
                CodeBodyParts.Chin => "CHIN",
                CodeBodyParts.CircumcisionSite => "CIRCU",
                CodeBodyParts.ClavicleClavicular => "CLAVI",
                CodeBodyParts.Clitoris => "CLIT",
                CodeBodyParts.Clitoral => "CLITO",
                CodeBodyParts.Cannula => "CNL",
                CodeBodyParts.Coccygeal => "COCCG",
                CodeBodyParts.Coccyx => "COCCY",
                CodeBodyParts.Colon => "COLON",
                CodeBodyParts.Colostomy => "COLOS",
                CodeBodyParts.Conjunctiva => "CONJ",
                CodeBodyParts.Cord => "COR",
                CodeBodyParts.Coral => "CORAL",
                CodeBodyParts.CordBlood => "CORD",
                CodeBodyParts.Cornea => "CORN",
                CodeBodyParts.ColostomyStoma => "COS",
                CodeBodyParts.CraniumEthmoid => "CRANE",
                CodeBodyParts.CraniumFrontal => "CRANF",
                CodeBodyParts.CraniumOccipital => "CRANO",
                CodeBodyParts.CraniumParietal => "CRANP",
                CodeBodyParts.CraniumSphenoid => "CRANS",
                CodeBodyParts.CraniumTemporal => "CRANT",
                CodeBodyParts.CerebralSpinalFluid => "CSF",
                CodeBodyParts.Cubitus => "CUBIT",
                CodeBodyParts.Cuff => "CUFF",
                CodeBodyParts.CulDeSac => "CULD",
                CodeBodyParts.Culdocentesis => "CULDO",
                CodeBodyParts.Cervix => "CVX",
                CodeBodyParts.Deltoid => "DELT",
                CodeBodyParts.DentalGingiva => "DEN",
                CodeBodyParts.Dental => "DENTA",
                CodeBodyParts.DialysisFluid => "DIAF",
                CodeBodyParts.Digit => "DIGIT",
                CodeBodyParts.Disc => "DISC",
                CodeBodyParts.DorsumDorsal => "DORS",
                CodeBodyParts.Diaphragm => "DPH",
                CodeBodyParts.DuodenalFluid => "DUFL",
                CodeBodyParts.DuodenumDuodenal => "DUODE",
                CodeBodyParts.Dura => "DUR",
                CodeBodyParts.Ear => "EAR",
                CodeBodyParts.EarBoneIncus => "EARBI",
                CodeBodyParts.EarBoneMalleus => "EARBM",
                CodeBodyParts.EarBoneStapes => "EARBS",
                CodeBodyParts.EarLobe => "EARLO",
                CodeBodyParts.Endocervical => "EC",
                CodeBodyParts.Elbow => "ELBOW",
                CodeBodyParts.ElbowJoint => "ELBOWJ",
                CodeBodyParts.Endocardium => "ENDC",
                CodeBodyParts.Endometrium => "ENDM",
                CodeBodyParts.Endolpthamitis => "EOLPH",
                CodeBodyParts.Eosinophils => "EOS",
                CodeBodyParts.Epididymis => "EPD",
                CodeBodyParts.Epicardial => "EPICA",
                CodeBodyParts.Epicardium => "EPICM",
                CodeBodyParts.Epidural => "EPIDU",
                CodeBodyParts.Epiglottis => "EPIGL",
                CodeBodyParts.Esophagus => "ESO",
                CodeBodyParts.Esophageal => "ESOPG",
                CodeBodyParts.Endotracheal => "ET",
                CodeBodyParts.Ethmoid => "ETHMO",
                CodeBodyParts.Endourethral => "EUR",
                CodeBodyParts.Eye => "EYE",
                CodeBodyParts.Eyelid => "EYELI",
                CodeBodyParts.Face => "FACE",
                CodeBodyParts.FallopianTube => "FALLT",
                CodeBodyParts.FacialBoneInferiorNasalConcha => "FBINC",
                CodeBodyParts.FacialBoneLacrimal => "FBLAC",
                CodeBodyParts.FacialBoneMaxilla => "FBMAX",
                CodeBodyParts.FacialBoneNasal => "FBNAS",
                CodeBodyParts.FacialBonePalatine => "FBPAL",
                CodeBodyParts.FacialBoneVomer => "FBVOM",
                CodeBodyParts.FacialBoneZygomatic => "FBZYG",
                CodeBodyParts.Femoral => "FEMOR",
                CodeBodyParts.Femur => "FEMUR",
                CodeBodyParts.Fetus => "FET",
                CodeBodyParts.Fibula => "FIBU",
                CodeBodyParts.Finger => "FING",
                CodeBodyParts.FingerNail => "FINGN",
                CodeBodyParts.FemoralHead => "FMH",
                CodeBodyParts.Follicle => "FOL",
                CodeBodyParts.Foot => "FOOT",
                CodeBodyParts.Forearm => "FOREA",
                CodeBodyParts.Forehead => "FOREH",
                CodeBodyParts.Foreskin => "FORES",
                CodeBodyParts.Fourchette => "FOURC",
                CodeBodyParts.GallBladder => "GB",
                CodeBodyParts.Genital => "GEN",
                CodeBodyParts.GenitalCervix => "GENC",
                CodeBodyParts.GenitalLochia => "GENL",
                CodeBodyParts.GenitalLesion => "GL",
                CodeBodyParts.Gland => "GLAND",
                CodeBodyParts.Glans => "GLANS",
                CodeBodyParts.Gluteus => "GLUT",
                CodeBodyParts.Gluteal => "GLUTE",
                CodeBodyParts.GluteusMedius => "GLUTM",
                CodeBodyParts.Groin => "GROIN",
                CodeBodyParts.Gum => "GUM",
                CodeBodyParts.GenitalVulva => "GVU",
                CodeBodyParts.Hallux => "HAL",
                CodeBodyParts.Hand => "HAND",
                CodeBodyParts.Hair => "HAR",
                CodeBodyParts.Heart => "HART",
                CodeBodyParts.Head => "HEAD",
                CodeBodyParts.Heel => "HEEL",
                CodeBodyParts.Hemorrhoid => "HEM",
                CodeBodyParts.Hip => "HIP",
                CodeBodyParts.HipJoint => "HIPJ",
                CodeBodyParts.Humerus => "HUMER",
                CodeBodyParts.HeartValve => "HV",
                CodeBodyParts.HeartValveBicuspid => "HVB",
                CodeBodyParts.HeartValveTricuspid => "HVT",
                CodeBodyParts.Hymen => "HYMEN",
                CodeBodyParts.Intracervical => "ICX",
                CodeBodyParts.IlealConduit => "ILC",
                CodeBodyParts.IlicalConduit => "ILCON",
                CodeBodyParts.IliacCrest => "ILCR",
                CodeBodyParts.IlealLoop => "ILE",
                CodeBodyParts.Ileostomy => "ILEOS",
                CodeBodyParts.Ileum => "ILEUM",
                CodeBodyParts.Iliac => "ILIAC",
                CodeBodyParts.Intranasal => "INASA",
                CodeBodyParts.Inguinal => "INGUI",
                CodeBodyParts.IntestineLarge => "INSTL",
                CodeBodyParts.IntestineSmall => "INSTS",
                CodeBodyParts.Intestine => "INT",
                CodeBodyParts.Introitus => "INTRO",
                CodeBodyParts.Intrauterine => "INTRU",
                CodeBodyParts.Ischium => "ISCHI",
                CodeBodyParts.LoopIshial => "ISH",
                CodeBodyParts.Jaw => "JAW",
                CodeBodyParts.JugularExternal => "JUGE",
                CodeBodyParts.JugularInternal => "JUGI",
                CodeBodyParts.KidneyDeprecated => "KIDN",
                CodeBodyParts.Kidney => "KIDNÃ‚",
                CodeBodyParts.Knee => "KNEE",
                CodeBodyParts.KneeFluid => "KNEEF",
                CodeBodyParts.KneeJoint => "KNEEJ",
                CodeBodyParts.Labia => "LABIA",
                CodeBodyParts.LabiaMajora => "LABMA",
                CodeBodyParts.LabiaMinora => "LABMI",
                CodeBodyParts.Lacrimal => "LACRI",
                CodeBodyParts.Lamella => "LAM",
                CodeBodyParts.Larynx => "LARYN",
                CodeBodyParts.Leg => "LEG",
                CodeBodyParts.Lens => "LENS",
                CodeBodyParts.Lingual => "LING",
                CodeBodyParts.Lingula => "LINGU",
                CodeBodyParts.Lip => "LIP",
                CodeBodyParts.Liver => "LIVER",
                CodeBodyParts.Lumen => "LMN",
                CodeBodyParts.LymphNode => "LN",
                CodeBodyParts.LymphNodeGroin => "LNG",
                CodeBodyParts.Lobe => "LOBE",
                CodeBodyParts.Lochia => "LOCH",
                CodeBodyParts.Lumbar => "LUMBA",
                CodeBodyParts.Lung => "LUNG",
                CodeBodyParts.Lymphocytes => "LYM",
                CodeBodyParts.Macrophages => "MAC",
                CodeBodyParts.Malleolus => "MALLE",
                CodeBodyParts.MandibleMandibular => "MANDI",
                CodeBodyParts.Marrow => "MAR",
                CodeBodyParts.Mastoid => "MAST",
                CodeBodyParts.MaxillaMaxillary => "MAXIL",
                CodeBodyParts.MaxillarySinus => "MAXS",
                CodeBodyParts.Meatus => "MEATU",
                CodeBodyParts.Meconium => "MEC",
                CodeBodyParts.Mediastinum => "MEDST",
                CodeBodyParts.Medullary => "MEDU",
                CodeBodyParts.Metacarpal => "METAC",
                CodeBodyParts.Metatarsal => "METAT",
                CodeBodyParts.MilkBreast => "MILK",
                CodeBodyParts.MitralValve => "MITRL",
                CodeBodyParts.Molar => "MOLAR",
                CodeBodyParts.MonsUreteris => "MONSU",
                CodeBodyParts.MonsVenerisMonsPubis => "MONSV",
                CodeBodyParts.Membrane => "MOU",
                CodeBodyParts.Mouth => "MOUTH",
                CodeBodyParts.MonsPubis => "MP",
                CodeBodyParts.Meninges => "MPB",
                CodeBodyParts.Mrsa => "MRSA2",
                CodeBodyParts.Myocardium => "MYO",
                CodeBodyParts.Nail => "NAIL",
                CodeBodyParts.NailBed => "NAILB",
                CodeBodyParts.NailFinger => "NAILF",
                CodeBodyParts.NailToe => "NAILT",
                CodeBodyParts.Nares => "NARES",
                CodeBodyParts.Nasal => "NASL",
                CodeBodyParts.Navel => "NAVEL",
                CodeBodyParts.Neck => "NECK",
                CodeBodyParts.Nerve => "NERVE",
                CodeBodyParts.Nipple => "NIPPL",
                CodeBodyParts.Nasolacrimal => "NLACR",
                CodeBodyParts.NoseNasalPassage => "NOS",
                CodeBodyParts.NoseNoseOutside => "NOSE",
                CodeBodyParts.Nostril => "NOSTR",
                CodeBodyParts.NasopharyngealNasopharynx => "NP",
                CodeBodyParts.NasalSeptum => "NSS",
                CodeBodyParts.Nasotracheal => "NTRAC",
                CodeBodyParts.Occipital => "OCCIP",
                CodeBodyParts.Olecranon => "OLECR",
                CodeBodyParts.Omentum => "OMEN",
                CodeBodyParts.OrbitOrbital => "ORBIT",
                CodeBodyParts.Oropharynx => "ORO",
                CodeBodyParts.OsCoxaPelvicGirdle => "OSCOX",
                CodeBodyParts.Ovary => "OVARY",
                CodeBodyParts.PancreaticFluid => "PAFL",
                CodeBodyParts.Palate => "PALAT",
                CodeBodyParts.Palm => "PALM",
                CodeBodyParts.PerianalPerirectal => "PANAL",
                CodeBodyParts.Pancreas => "PANCR",
                CodeBodyParts.Paratracheal => "PARAT",
                CodeBodyParts.Parietal => "PARIE",
                CodeBodyParts.Paronychia => "PARON",
                CodeBodyParts.ParotidParotidGland => "PAROT",
                CodeBodyParts.Parasternal => "PAS",
                CodeBodyParts.Patella => "PATEL",
                CodeBodyParts.Pericardium => "PCARD",
                CodeBodyParts.Periclitoral => "PCLIT",
                CodeBodyParts.Pelvis => "PELV",
                CodeBodyParts.Penis => "PENIS",
                CodeBodyParts.PenileShaft => "PENSH",
                CodeBodyParts.Peritoneal => "PER",
                CodeBodyParts.PericardialFluid => "PERI",
                CodeBodyParts.Perihepatic => "PERIH",
                CodeBodyParts.PerinealAbscess => "PERIN",
                CodeBodyParts.Perisplenic => "PERIS",
                CodeBodyParts.Peritoneum => "PERIT",
                CodeBodyParts.Periurethal => "PERIU",
                CodeBodyParts.Perivesicular => "PERIV",
                CodeBodyParts.Perirectal => "PERRA",
                CodeBodyParts.PeritonealFluid => "PERT",
                CodeBodyParts.Phalanyx => "PHALA",
                CodeBodyParts.Pilonidal => "PILO",
                CodeBodyParts.Pinna => "PINNA",
                CodeBodyParts.PlacentaFetalSide => "PLACF",
                CodeBodyParts.PlacentaMaternalSide => "PLACM",
                CodeBodyParts.Plantar => "PLANT",
                CodeBodyParts.PalateHard => "PLATH",
                CodeBodyParts.PalateSoft => "PLATS",
                CodeBodyParts.Placenta => "PLC",
                CodeBodyParts.PleuralFluid => "PLEU",
                CodeBodyParts.Pleura => "PLEUR",
                CodeBodyParts.PleuralFluidThoracentesisFld => "PLR",
                CodeBodyParts.Perineal => "PNEAL",
                CodeBodyParts.Perinephric => "PNEPH",
                CodeBodyParts.Perineum => "PNM",
                CodeBodyParts.Popliteal => "POPLI",
                CodeBodyParts.Periorbital => "PORBI",
                CodeBodyParts.Preauricular => "PREAU",
                CodeBodyParts.Prerenal => "PRERE",
                CodeBodyParts.ProstaticFluid => "PROS",
                CodeBodyParts.ProstateGland => "PRST",
                CodeBodyParts.Peritonsillar => "PTONS",
                CodeBodyParts.Pubic => "PUBIC",
                CodeBodyParts.PulmonaryArtery => "PUL",
                CodeBodyParts.Radial => "RADI",
                CodeBodyParts.Radius => "RADIUS",
                CodeBodyParts.RedBloodCells => "RBC",
                CodeBodyParts.Rectal => "RECTL",
                CodeBodyParts.Rectum => "RECTU",
                CodeBodyParts.Renal => "RENL",
                CodeBodyParts.Rib => "RIB",
                CodeBodyParts.RenalPelvis => "RNP",
                CodeBodyParts.Retroperitoneal => "RPERI",
                CodeBodyParts.UterineCulDeSac => "SAC",
                CodeBodyParts.Sacroiliac => "SACIL",
                CodeBodyParts.Sacral => "SACRA",
                CodeBodyParts.Sacrococcygeal => "SACRO",
                CodeBodyParts.Sacrum => "SACRU",
                CodeBodyParts.SalivaryGland => "SALGL",
                CodeBodyParts.Scalp => "SCALP",
                CodeBodyParts.ScapulaScapular => "SCAPU",
                CodeBodyParts.SupraclavicleSupraclavicular => "SCLAV",
                CodeBodyParts.Sclera => "SCLER",
                CodeBodyParts.SubClavian => "SCLV",
                CodeBodyParts.ScrotumScrotal => "SCROT",
                CodeBodyParts.Subdiaphramatic => "SDP",
                CodeBodyParts.SeminalFluid => "SEM",
                CodeBodyParts.Semen => "SEMN",
                CodeBodyParts.SeptumSeptal => "SEPTU",
                CodeBodyParts.Seroma => "SEROM",
                CodeBodyParts.SubgalealFluid => "SGF",
                CodeBodyParts.Shin => "SHIN",
                CodeBodyParts.Shoulder => "SHOL",
                CodeBodyParts.SholderJoint => "SHOLJ",
                CodeBodyParts.Sigmoid => "SIGMO",
                CodeBodyParts.Sinus => "SINUS",
                CodeBodyParts.SkenesGland => "SKENE",
                CodeBodyParts.SkeletalMuscle => "SKM",
                CodeBodyParts.Skull => "SKULL",
                CodeBodyParts.Sole => "SOLE",
                CodeBodyParts.SpinalCord => "SPCOR",
                CodeBodyParts.Sphenoid => "SPHEN",
                CodeBodyParts.Spleen => "SPLN",
                CodeBodyParts.Spermatozoa => "SPRM",
                CodeBodyParts.SupraCervical => "SPX",
                CodeBodyParts.SternumSternal => "STER",
                CodeBodyParts.Stoma => "STOM",
                CodeBodyParts.Stomach => "STOMA",
                CodeBodyParts.LiquidStool => "STOOLL",
                CodeBodyParts.Stump => "STUMP",
                CodeBodyParts.Subdural => "SUB",
                CodeBodyParts.SubduralFluid => "SUBD",
                CodeBodyParts.Submandibular => "SUBM",
                CodeBodyParts.Submental => "SUBME",
                CodeBodyParts.Subphrenic => "SUBPH",
                CodeBodyParts.Submaxillary => "SUBX",
                CodeBodyParts.SuprapubicSpecimen => "SUPB",
                CodeBodyParts.Suprapubic => "SUPRA",
                CodeBodyParts.Sweat => "SWT",
                CodeBodyParts.SweatGland => "SWTG",
                CodeBodyParts.SynovialFluid => "SYN",
                CodeBodyParts.Synovial => "SYNOL",
                CodeBodyParts.Synovium => "SYNOV",
                CodeBodyParts.Tarsal => "TARS",
                CodeBodyParts.Transbronchial => "TBRON",
                CodeBodyParts.TranscarinaAsp => "TCN",
                CodeBodyParts.TearDuct => "TDUCT",
                CodeBodyParts.Tears => "TEAR",
                CodeBodyParts.Temple => "TEMPL",
                CodeBodyParts.Temporal => "TEMPO",
                CodeBodyParts.TesticleTestis => "TESTI",
                CodeBodyParts.Thigh => "THIGH",
                CodeBodyParts.Thymus => "THM",
                CodeBodyParts.ThoraxThoracicThoracentesis => "THORA",
                CodeBodyParts.Throat => "THRB",
                CodeBodyParts.Thumb => "THUMB",
                CodeBodyParts.Thyroid => "THYRD",
                CodeBodyParts.Tibia => "TIBIA",
                CodeBodyParts.TemporalLobe => "TML",
                CodeBodyParts.Thumbnail => "TNL",
                CodeBodyParts.Toe => "TOE",
                CodeBodyParts.ToeNail => "TOEN",
                CodeBodyParts.Tongue => "TONG",
                CodeBodyParts.Tonsil => "TONS",
                CodeBodyParts.Tooth => "TOOTH",
                CodeBodyParts.TracheaTracheal => "TRCHE",
                CodeBodyParts.ToothSocket => "TSK",
                CodeBodyParts.UlnaUlnar => "ULNA",
                CodeBodyParts.UmbilicalBlood => "UMB",
                CodeBodyParts.UmbilicusUmbilical => "UMBL",
                CodeBodyParts.Ureter => "URET",
                CodeBodyParts.Urethra => "URTH",
                CodeBodyParts.StomaUrinary => "USTOM",
                CodeBodyParts.Uterus => "UTER",
                CodeBodyParts.Uterine => "UTERI",
                CodeBodyParts.VaginaVaginal => "VAGIN",
                CodeBodyParts.Valve => "VAL",
                CodeBodyParts.VasDeferens => "VAS",
                CodeBodyParts.VastusLateralis => "VASTL",
                CodeBodyParts.Vault => "VAULT",
                CodeBodyParts.VentricularCsf => "VCSF",
                CodeBodyParts.VaginalCuff => "VCUFF",
                CodeBodyParts.Vein => "VEIN",
                CodeBodyParts.Ventragluteal => "VENTG",
                CodeBodyParts.VermisCerebelli => "VERMI",
                CodeBodyParts.VertebraCervical => "VERTC",
                CodeBodyParts.VertebraLumbar => "VERTL",
                CodeBodyParts.VertebraThoracic => "VERTT",
                CodeBodyParts.Vesicular => "VESCL",
                CodeBodyParts.VesicularFluid => "VESFLD",
                CodeBodyParts.Vesicle => "VESI",
                CodeBodyParts.VestibuleGenital => "VESTI",
                CodeBodyParts.VaginalVault => "VGV",
                CodeBodyParts.VitreousFluid => "VITR",
                CodeBodyParts.VocalCord => "VOC",
                CodeBodyParts.Vulva => "VULVA",
                CodeBodyParts.Leukocytes => "WBC",
                CodeBodyParts.Wrist => "WRIST",
                CodeBodyParts.ExternalJugular => "Ã‚",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeBodyParts input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeBodySite enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeBodySite input)
        {
            return input switch
            {
                CodeBodySite.BilateralEars => "BE",
                CodeBodySite.BilateralNares => "BN",
                CodeBodySite.Buttock => "BU",
                CodeBodySite.ChestTube => "CT",
                CodeBodySite.LeftArm => "LA",
                CodeBodySite.LeftAnteriorChest => "LAC",
                CodeBodySite.LeftAntecubitalFossa => "LACF",
                CodeBodySite.LeftDeltoid => "LD",
                CodeBodySite.LeftEar => "LE",
                CodeBodySite.LeftExternalJugular => "LEJ",
                CodeBodySite.LeftFoot => "LF",
                CodeBodySite.LeftGluteusMedius => "LG",
                CodeBodySite.LeftHand => "LH",
                CodeBodySite.LeftInternalJugular => "LIJ",
                CodeBodySite.LeftLowerAbdQuadrant => "LLAQ",
                CodeBodySite.LeftLowerForearm => "LLFA",
                CodeBodySite.LeftMidForearm => "LMFA",
                CodeBodySite.LeftNaris => "LN",
                CodeBodySite.LeftPosteriorChest => "LPC",
                CodeBodySite.LeftSubclavian => "LSC",
                CodeBodySite.LeftThigh => "LT",
                CodeBodySite.LeftUpperArm => "LUA",
                CodeBodySite.LeftUpperAbdQuadrant => "LUAQ",
                CodeBodySite.LeftUpperForearm => "LUFA",
                CodeBodySite.LeftVentragluteal => "LVG",
                CodeBodySite.LeftVastusLateralis => "LVL",
                CodeBodySite.Nebulized => "NB",
                CodeBodySite.RightEye => "OD",
                CodeBodySite.LeftEye => "OS",
                CodeBodySite.BilateralEyes => "OU",
                CodeBodySite.Perianal => "PA",
                CodeBodySite.Perineal => "PERIN",
                CodeBodySite.RightArm => "RA",
                CodeBodySite.RightAnteriorChest => "RAC",
                CodeBodySite.RightAntecubitalFossa => "RACF",
                CodeBodySite.RightDeltoid => "RD",
                CodeBodySite.RightEar => "RE",
                CodeBodySite.RightExternalJugular => "REJ",
                CodeBodySite.RightFoot => "RF",
                CodeBodySite.RightGluteusMedius => "RG",
                CodeBodySite.RightHand => "RH",
                CodeBodySite.RightInternalJugular => "RIJ",
                CodeBodySite.RtLowerAbdQuadrant => "RLAQ",
                CodeBodySite.RightLowerForearm => "RLFA",
                CodeBodySite.RightMidForearm => "RMFA",
                CodeBodySite.RightNaris => "RN",
                CodeBodySite.RightPosteriorChest => "RPC",
                CodeBodySite.RightSubclavian => "RSC",
                CodeBodySite.RightThigh => "RT",
                CodeBodySite.RightUpperArm => "RUA",
                CodeBodySite.RightUpperAbdQuadrant => "RUAQ",
                CodeBodySite.RightUpperForearm => "RUFA",
                CodeBodySite.RightVentragluteal => "RVG",
                CodeBodySite.RightVastusLateralis => "RVL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeBodySite input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeBodySiteModifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeBodySiteModifier input)
        {
            return input switch
            {
                CodeBodySiteModifier.Anterior => "ANT",
                CodeBodySiteModifier.Bilateral => "BIL",
                CodeBodySiteModifier.Distal => "DIS",
                CodeBodySiteModifier.External => "EXT",
                CodeBodySiteModifier.Left => "L",
                CodeBodySiteModifier.Lateral => "LAT",
                CodeBodySiteModifier.QuadrantLeftLower => "LLQ",
                CodeBodySiteModifier.Lower => "LOW",
                CodeBodySiteModifier.QuadrantLeftUpper => "LUQ",
                CodeBodySiteModifier.Medial => "MED",
                CodeBodySiteModifier.Posterior => "POS",
                CodeBodySiteModifier.Proximal => "PRO",
                CodeBodySiteModifier.Right => "R",
                CodeBodySiteModifier.QuadrantRightLower => "RLQ",
                CodeBodySiteModifier.QuadrantRightUpper => "RUQ",
                CodeBodySiteModifier.Upper => "UPP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeBodySiteModifier input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeBpObservationStatusCodesInterpretation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeBpObservationStatusCodesInterpretation input)
        {
            return input switch
            {
                CodeBpObservationStatusCodesInterpretation.RecordComingOverIsCorrection => "C",
                CodeBpObservationStatusCodesInterpretation.DeletesTheBpxRecord => "D",
                CodeBpObservationStatusCodesInterpretation.FinalStatus => "F",
                CodeBpObservationStatusCodesInterpretation.OrderDetailDescriptionOnly => "O",
                CodeBpObservationStatusCodesInterpretation.PreliminaryStatus => "P",
                CodeBpObservationStatusCodesInterpretation.PostOriginalAsWrong => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeBpObservationStatusCodesInterpretation input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCalendarAlignment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCalendarAlignment input)
        {
            return input switch
            {
                CodeCalendarAlignment.DayOfTheMonth => "DM",
                CodeCalendarAlignment.DayOfTheWeekBeginsWithMonday => "DW",
                CodeCalendarAlignment.DayOfTheYear => "DY",
                CodeCalendarAlignment.HourOfTheDay => "HD",
                CodeCalendarAlignment.MonthOfTheYear => "MY",
                CodeCalendarAlignment.MinuteOfTheHour => "NH",
                CodeCalendarAlignment.SecondOfTheMinute => "SN",
                CodeCalendarAlignment.WeekOfTheYear => "WY",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCalendarAlignment input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCaseCategoryCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCaseCategoryCode input)
        {
            return input switch
            {
                CodeCaseCategoryCode.DoctorsOfficeClosed => "D",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCaseCategoryCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCausalityObservations enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCausalityObservations input)
        {
            return input switch
            {
                CodeCausalityObservations.AbatementOfEventAfterProductWithdrawn => "AW",
                CodeCausalityObservations.EventRecurredAfterProductReintroduced => "BE",
                CodeCausalityObservations.DoseResponseObserved => "DR",
                CodeCausalityObservations.AlternativeExplanationForEventAvailable => "EX",
                CodeCausalityObservations.EventOccurredAfterProductIntroduced => "IN",
                CodeCausalityObservations.LiteratureReportsAssociationOfProductWithEvent => "LI",
                CodeCausalityObservations.OccurrenceOfEventConfirmedByObjectiveEvidence => "OE",
                CodeCausalityObservations.Other => "OT",
                CodeCausalityObservations.EffectObservedWhenPatientReceivesPlacebo => "PL",
                CodeCausalityObservations.SimilarEventsInPastForThisPatient => "SE",
                CodeCausalityObservations.ToxicLevelsOfProductDocumented => "TC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCausalityObservations input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCclValue enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCclValue input)
        {
            return input switch
            {
                CodeCclValue.NothingObvious => "0",
                CodeCclValue.Low => "1",
                CodeCclValue.Moderate => "2",
                CodeCclValue.High => "3",
                CodeCclValue.VeryHigh => "4",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCclValue input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCertificateStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCertificateStatus input)
        {
            return input switch
            {
                CodeCertificateStatus.Expired => "E",
                CodeCertificateStatus.Inactive => "I",
                CodeCertificateStatus.Provisional => "P",
                CodeCertificateStatus.Revoked => "R",
                CodeCertificateStatus.ActiveValid => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCertificateStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCertificationPatientType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCertificationPatientType input)
        {
            return input switch
            {
                CodeCertificationPatientType.Emergency => "ER",
                CodeCertificationPatientType.InpatientElective => "IPE",
                CodeCertificationPatientType.OutpatientElective => "OPE",
                CodeCertificationPatientType.Urgent => "UR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCertificationPatientType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCertificationStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCertificationStatus input)
        {
            return input switch
            {
                CodeCertificationStatus.Certified => "C",
                CodeCertificationStatus.Eligible => "E",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCertificationStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeChargeOnIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeChargeOnIndicator input)
        {
            return input switch
            {
                CodeChargeOnIndicator.ChargeOnOrder => "O",
                CodeChargeOnIndicator.ChargeOnResult => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeChargeOnIndicator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeChargeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeChargeType input)
        {
            return input switch
            {
                CodeChargeType.Charge => "CH",
                CodeChargeType.Contract => "CO",
                CodeChargeType.Credit => "CR",
                CodeChargeType.Department => "DP",
                CodeChargeType.Grant => "GR",
                CodeChargeType.NoCharge => "NC",
                CodeChargeType.Professional => "PC",
                CodeChargeType.Research => "RS",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeChargeType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeChargeTypeReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeChargeTypeReason input)
        {
            return input switch
            {
                CodeChargeTypeReason.Allergy => "01",
                CodeChargeTypeReason.Intolerance => "02",
                CodeChargeTypeReason.TreatmentFailure => "03",
                CodeChargeTypeReason.PatientRequest => "04",
                CodeChargeTypeReason.NoException => "05",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeChargeTypeReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCheckDigitScheme enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCheckDigitScheme input)
        {
            return input switch
            {
                CodeCheckDigitScheme.BankCardValidationNumber => "BCV",
                CodeCheckDigitScheme.Iso70641983 => "ISO",
                CodeCheckDigitScheme.Mod10Algorithm => "M10",
                CodeCheckDigitScheme.Mod11Algorithm => "M11",
                CodeCheckDigitScheme.CheckDigitInTheNationalProviderIdentifier => "NPI",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCheckDigitScheme input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCodingSystem enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCodingSystem input)
        {
            return input switch
            {
                CodeCodingSystem.LocalGeneralCode99Zzz => "99zzz",
                CodeCodingSystem.AmericanCollegeOfRadiologyFindingCodes => "ACR",
                CodeCodingSystem.GermanAlphaIdV2006 => "ALPHAID2006",
                CodeCodingSystem.GermanAlphaIdV2007 => "ALPHAID2007",
                CodeCodingSystem.GermanAlphaIdV2008 => "ALPHAID2008",
                CodeCodingSystem.GermanAlphaIdV2009 => "ALPHAID2009",
                CodeCodingSystem.GermanAlphaIdV2010 => "ALPHAID2010",
                CodeCodingSystem.GermanAlphaIdV2011 => "ALPHAID2011",
                CodeCodingSystem.Hl7SetOfUnitsOfMeasure => "ANS+",
                CodeCodingSystem.WhoAdverseReactionTerms => "ART",
                CodeCodingSystem.AstmE1238E1467Universal => "AS4",
                CodeCodingSystem.As4NeurophysiologyCodes => "AS4E",
                CodeCodingSystem.AmericanTypeCultureCollection => "ATC",
                CodeCodingSystem.Cpt4 => "C4",
                CodeCodingSystem.CollegeOfAmericanPathologistsElectronicCancerChecklist => "CAPECC",
                CodeCodingSystem.ChemicalAbstractCodes => "CAS",
                CodeCodingSystem.ClinicalCareClassificationSystem => "CCC",
                CodeCodingSystem.Cdt2Codes => "CD2",
                CodeCodingSystem.CdcAnalyteCodes => "CDCA",
                CodeCodingSystem.CdcEmergencyDepartmentAcuity => "CDCEDACUITY",
                CodeCodingSystem.CdcMethodsInstrumentsCodes => "CDCM",
                CodeCodingSystem.CdcBiosenseRtObservationsCensusCdc => "CDCOBS",
                CodeCodingSystem.CdcPhinVocabularyCodingSystem => "CDCPHINVS",
                CodeCodingSystem.RaceEthnicityCdc => "CDCREC",
                CodeCodingSystem.CdcSurveillance => "CDS",
                CodeCodingSystem.CenEcgDiagnosticCodes => "CE (obsolete)",
                CodeCodingSystem.Clip => "CLP",
                CodeCodingSystem.CptModifierCode => "CPTM",
                CodeCodingSystem.Costart => "CST",
                CodeCodingSystem.CdcVaccineCodes => "CVX",
                CodeCodingSystem.DicomControlledTerminology => "DCM",
                CodeCodingSystem.Euclides => "E",
                CodeCodingSystem.EuclidesQuantityCodes => "E5",
                CodeCodingSystem.EuclidesLabMethodCodes => "E6",
                CodeCodingSystem.EuclidesLabEquipmentCodes => "E7",
                CodeCodingSystem.EnzymeCodes => "ENZC",
                CodeCodingSystem.EpaSrs => "EPASRS",
                CodeCodingSystem.UniqueIngredientIdentifierUnii => "FDAUNII",
                CodeCodingSystem.FirstDatabankDrugCodes => "FDDC",
                CodeCodingSystem.FirstDatabankDiagnosticCodes => "FDDX",
                CodeCodingSystem.FdaK10 => "FDK",
                CodeCodingSystem.Fips52State => "FIPS5_2",
                CodeCodingSystem.Fips64County => "FIPS6_4",
                CodeCodingSystem.GDrgGermanDrgCodesV2004 => "GDRG2004",
                CodeCodingSystem.GDrgGermanDrgCodesV2005 => "GDRG2005",
                CodeCodingSystem.GDrgGermanDrgCodesV2006 => "GDRG2006",
                CodeCodingSystem.GDrgGermanDrgCodesV2007 => "GDRG2007",
                CodeCodingSystem.GDrgGermanDrgCodesV2008 => "GDRG2008",
                CodeCodingSystem.GDrgGermanDrgCodesV2009 => "GDRG2009",
                CodeCodingSystem.Active => "General code",
                CodeCodingSystem.GermanMajorDiagnosticCodesV2004 => "GMDC2004",
                CodeCodingSystem.GermanMajorDiagnosticCodesV2005 => "GMDC2005",
                CodeCodingSystem.GermanMajorDiagnosticCodesV2006 => "GMDC2006",
                CodeCodingSystem.GermanMajorDiagnosticCodesV2007 => "GMDC2007",
                CodeCodingSystem.GermanMajorDiagnosticCodesV2008 => "GMDC2008",
                CodeCodingSystem.GermanMajorDiagnosticCodesV2009 => "GMDC2009",
                CodeCodingSystem.Hibcc => "HB",
                CodeCodingSystem.CmsFormerlyHcfaCommonProcedureCodingSystem => "HCPCS",
                CodeCodingSystem.HealthCareProviderTaxonomy => "HCPT",
                CodeCodingSystem.HomeHealthCare => "HHC",
                CodeCodingSystem.HealthOutcomes => "HI",
                CodeCodingSystem.Hl7DefinedCodesWhereNnnnIsTheHl7TableNumber => "HL7nnnn",
                CodeCodingSystem.JapaneseNationwideMedicineCode => "HOT",
                CodeCodingSystem.CmsFormerlyHcfaProcedureCodesHcpcs => "HPC",
                CodeCodingSystem.Icd10 => "I10",
                CodeCodingSystem.Icd10Germany2004 => "I10G2004",
                CodeCodingSystem.Icd10Germany2005 => "I10G2005",
                CodeCodingSystem.Icd10Germany2006 => "I10G2006",
                CodeCodingSystem.Icd10ProcedureCodes => "I10P",
                CodeCodingSystem.Icd9 => "I9",
                CodeCodingSystem.Icd9Cm => "I9C",
                CodeCodingSystem.Icd9CmDiagnosisCodes => "I9CDX",
                CodeCodingSystem.Icd9CmProcedureCodes => "I9CP",
                CodeCodingSystem.Isbt => "IBT",
                CodeCodingSystem.Isbt128Codes => "IBTnnnn",
                CodeCodingSystem.Ichppc2 => "IC2",
                CodeCodingSystem.Icd10AustralianModification => "ICD10AM",
                CodeCodingSystem.Icd10Canada => "ICD10CA",
                CodeCodingSystem.Icd10GermanyV2007 => "ICD10GM2007",
                CodeCodingSystem.Icd10GermanyV2008 => "ICD10GM2008",
                CodeCodingSystem.Icd10GermanyV2009 => "ICD10GM2009",
                CodeCodingSystem.Icd10GermanyV2010 => "ICD10GM2010",
                CodeCodingSystem.Icd10GermanyV2011 => "ICD10GM2011",
                CodeCodingSystem.IcdForOncology => "ICDO",
                CodeCodingSystem.IcdForOncologySecondEdition => "ICDO2",
                CodeCodingSystem.IcdForOncologyThirdEdition => "ICDO3",
                CodeCodingSystem.Iccs => "ICS",
                CodeCodingSystem.Icsd => "ICSD",
                CodeCodingSystem.Iso295583UnitsOfMeasure => "ISO",
                CodeCodingSystem.Iso31661CountryCodes => "ISO3166_1",
                CodeCodingSystem.Iso31662CountrySubdivisions => "ISO3166_2",
                CodeCodingSystem.Iso4217CurrencyCodes => "ISO4217",
                CodeCodingSystem.Iso639Language => "ISO639",
                CodeCodingSystem.IsoDefinedCodes => "ISOnnnn (deprecated)",
                CodeCodingSystem.IntegratedTaxonomicInformationSystem => "ITIS",
                CodeCodingSystem.IupacIfccComponentCodes => "IUPC",
                CodeCodingSystem.IupacIfccPropertyCodes => "IUPP",
                CodeCodingSystem.JlacJslmNationwideLaboratoryCode => "JC10",
                CodeCodingSystem.JapaneseChemistry => "JC8",
                CodeCodingSystem.JapaneseImageExaminationCache => "JJ1017",
                CodeCodingSystem.LocalGeneralCodeL => "L",
                CodeCodingSystem.LocalBillingCode => "LB",
                CodeCodingSystem.LogicalObservationIdentifierNamesAndCodesLoinc => "LN",
                CodeCodingSystem.Medicaid => "MCD",
                CodeCodingSystem.Medicare => "MCR",
                CodeCodingSystem.MedicalDeviceCommunication => "MDC",
                CodeCodingSystem.MedispanDiagnosticCodes => "MDDX",
                CodeCodingSystem.MedicalEconomicsDrugCodes => "MEDC",
                CodeCodingSystem.MedicalDictionaryForDrugRegulatoryAffairs => "MEDR",
                CodeCodingSystem.MedicalEconomicsDiagnosticCodes => "MEDX",
                CodeCodingSystem.MedispanGpi => "MGPI",
                CodeCodingSystem.CdcVaccineManufacturerCodes => "MVX",
                CodeCodingSystem.IndustryNaics => "NAICS",
                CodeCodingSystem.NcpdpCodeListForDataElement => "NCPDPnnnnsss",
                CodeCodingSystem.Nanda => "NDA",
                CodeCodingSystem.NationalDrugCodes => "NDC",
                CodeCodingSystem.NdfRtDrugClassification => "NDFRT",
                CodeCodingSystem.NursingInterventionsClassification => "NIC",
                CodeCodingSystem.SourceOfInformationImmunization => "NIP001",
                CodeCodingSystem.SubstanceRefusalReason => "NIP002",
                CodeCodingSystem.Vaccination => "NIP004",
                CodeCodingSystem.VaccinatedAtLocationFacility => "NIP007",
                CodeCodingSystem.VaccinePurchasedWithFunding => "NIP008",
                CodeCodingSystem.ReportedAdverseEventPreviously => "NIP009",
                CodeCodingSystem.VaersReportType => "NIP010",
                CodeCodingSystem.NotifiableEventDiseaseConditionCodeList => "NND",
                CodeCodingSystem.NationalProviderIdentifier => "NPI",
                CodeCodingSystem.NationalUniformBillingCommittee => "NUBC",
                CodeCodingSystem.NullFlavor => "NULLFL",
                CodeCodingSystem.GermanProcedureCodes => "O301",
                CodeCodingSystem.OpsGermanyV2004 => "O3012004",
                CodeCodingSystem.OpsGermanyV2005 => "O3012005",
                CodeCodingSystem.OpsGermanyV2006 => "O3012006",
                CodeCodingSystem.OmahaSystem => "OHA",
                CodeCodingSystem.OpsGermanyV2007 => "OPS2007",
                CodeCodingSystem.OpsGermanyV2008 => "OPS2008",
                CodeCodingSystem.OpsGermanyV2009 => "OPS2009",
                CodeCodingSystem.OpsGermanyV2010 => "OPS2010",
                CodeCodingSystem.OpsGermanyV2011 => "OPS2011",
                CodeCodingSystem.CdcPublicHealthInformationNetworkQuestion => "PHINQUESTION",
                CodeCodingSystem.CdcPhlipLabResultCodes => "PLR",
                CodeCodingSystem.CdcPhlipLabTestCodes => "PLT",
                CodeCodingSystem.PosCodes => "POS",
                CodeCodingSystem.ReadClassification => "RC",
                CodeCodingSystem.Rxnorm => "RXNORM",
                CodeCodingSystem.SnomedClinicalTerms => "SCT",
                CodeCodingSystem.SnomedClinicalTermsAlphanumericCodes => "SCT2",
                CodeCodingSystem.SnomedDicomMicroglossary => "SDM",
                CodeCodingSystem.IndustrySic => "SIC",
                CodeCodingSystem.SystemizedNomenclatureOfMedicineSnomed => "SNM",
                CodeCodingSystem.SnomedInternational => "SNM3",
                CodeCodingSystem.SnomedTopologyCodesAnatomicSites => "SNT",
                CodeCodingSystem.OccupationSoc2000 => "SOC",
                CodeCodingSystem.PriorityTypeOfVisit => "UB04FL14",
                CodeCodingSystem.PointOfOrigin => "UB04FL15",
                CodeCodingSystem.PatientDischargeStatus => "UB04FL17",
                CodeCodingSystem.OccurrenceCode => "UB04FL31",
                CodeCodingSystem.OccurrenceSpan => "UB04FL35",
                CodeCodingSystem.ValueCode => "UB04FL39",
                CodeCodingSystem.Ucds => "UC",
                CodeCodingSystem.UcumCodeSetForUnitsOfMeasureFromRegenstrief => "UCUM",
                CodeCodingSystem.Mdns => "UMD",
                CodeCodingSystem.UnifiedMedicalLanguage => "UML",
                CodeCodingSystem.UniversalProductCode => "UPC",
                CodeCodingSystem.Upin => "UPIN",
                CodeCodingSystem.UnitedStatesPostalService => "USPS",
                CodeCodingSystem.WhoRecordDrugCodes6Digit => "W1",
                CodeCodingSystem.WhoRecordDrugCodes8Digit => "W2",
                CodeCodingSystem.WhoRecordCodeWithAstmExtension => "W4",
                CodeCodingSystem.WhoAtc => "WC",
                CodeCodingSystem.AscX12CodeListNnnn => "X12Dennnn",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCodingSystem input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCommandResponse enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCommandResponse input)
        {
            return input switch
            {
                CodeCommandResponse.CommandCannotBeCompletedBecauseOfError => "ER",
                CodeCommandResponse.CommandCompletedSuccessfully => "OK",
                CodeCommandResponse.CommandCannotBeCompletedBecauseOfEquipmentStatus => "ST",
                CodeCommandResponse.CommandCannotBeCompletedWithinRequestedTime => "TI",
                CodeCommandResponse.CommandCannotBeCompletedForUnknownReasons => "UN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCommandResponse input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCommentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCommentType input)
        {
            return input switch
            {
                CodeCommentType.PrimaryReason => "1R",
                CodeCommentType.SecondaryReason => "2R",
                CodeCommentType.AncillaryInstructions => "AI",
                CodeCommentType.DuplicateInteractionReason => "DR",
                CodeCommentType.GeneralInstructions => "GI",
                CodeCommentType.GeneralReason => "GR",
                CodeCommentType.PatientInstructions => "PI",
                CodeCommentType.Remark => "RE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCommentType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCompletionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCompletionStatus input)
        {
            return input switch
            {
                CodeCompletionStatus.Complete => "CP",
                CodeCompletionStatus.NotAdministered => "NA",
                CodeCompletionStatus.PartiallyAdministered => "PA",
                CodeCompletionStatus.Refused => "RE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCompletionStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeComputationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeComputationType input)
        {
            return input switch
            {
                CodeComputationType.IndicatesAPercentChange => "%",
                CodeComputationType.AbsoluteChange => "a",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeComputationType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeConditionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeConditionCode input)
        {
            return input switch
            {
                CodeConditionCode.NoSuggestedValuesDefined => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeConditionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeConfidentiality enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeConfidentiality input)
        {
            return input switch
            {
                CodeConfidentiality.Business => "B",
                CodeConfidentiality.Celebrity => "C",
                CodeConfidentiality.ClinicianOnly => "D",
                CodeConfidentiality.SubstanceAbuseRelated => "ETH",
                CodeConfidentiality.HivRelated => "HIV",
                CodeConfidentiality.Individual => "I",
                CodeConfidentiality.Low => "L",
                CodeConfidentiality.Normal => "N",
                CodeConfidentiality.PsychiatryRelated => "PSY",
                CodeConfidentiality.Restricted => "R",
                CodeConfidentiality.Sensitive => "S",
                CodeConfidentiality.SexualAndDomesticViolence => "SDV",
                CodeConfidentiality.Taboo => "T",
                CodeConfidentiality.VeryRestricted => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeConfidentiality input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeConfidentialityCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeConfidentialityCode input)
        {
            return input switch
            {
                CodeConfidentialityCode.AidsPatient => "AID",
                CodeConfidentialityCode.Employee => "EMP",
                CodeConfidentialityCode.AlcoholDrugTreatmentPatient => "ETH",
                CodeConfidentialityCode.HivPatient => "HIV",
                CodeConfidentialityCode.PsychiatricPatient => "PSY",
                CodeConfidentialityCode.Restricted => "R",
                CodeConfidentialityCode.UsualControl => "U",
                CodeConfidentialityCode.UnwedMother => "UWM",
                CodeConfidentialityCode.VeryRestricted => "V",
                CodeConfidentialityCode.VeryImportantPersonOrCelebrity => "VIP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeConfidentialityCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeConsentBypassReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeConsentBypassReason input)
        {
            return input switch
            {
                CodeConsentBypassReason.Emergency => "E",
                CodeConsentBypassReason.ProfessionalJudgment => "PJ",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeConsentBypassReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeConsentDisclosureLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeConsentDisclosureLevel input)
        {
            return input switch
            {
                CodeConsentDisclosureLevel.FullDisclosure => "F",
                CodeConsentDisclosureLevel.NoDisclosure => "N",
                CodeConsentDisclosureLevel.PartialDisclosure => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeConsentDisclosureLevel input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeConsentMode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeConsentMode input)
        {
            return input switch
            {
                CodeConsentMode.Telephone => "T",
                CodeConsentMode.Verbal => "V",
                CodeConsentMode.Written => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeConsentMode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeConsentNonDisclosureReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeConsentNonDisclosureReason input)
        {
            return input switch
            {
                CodeConsentNonDisclosureReason.Emergency => "E",
                CodeConsentNonDisclosureReason.PatientRequest => "PR",
                CodeConsentNonDisclosureReason.RxPrivate => "RX",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeConsentNonDisclosureReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeConsentStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeConsentStatus input)
        {
            return input switch
            {
                CodeConsentStatus.Active => "A",
                CodeConsentStatus.Bypassed => "B",
                CodeConsentStatus.Limited => "L",
                CodeConsentStatus.Pending => "P",
                CodeConsentStatus.Refused => "R",
                CodeConsentStatus.Rescinded => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeConsentStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeConsentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeConsentType input)
        {
            return input switch
            {
                CodeConsentType.ReleaseOfInfoToDisclosePhi => "001",
                CodeConsentType.MedicalProcedureInvasive => "002",
                CodeConsentType.AcknowledgeReceiptOfPrivacyNotice => "003",
                CodeConsentType.Abortion => "004",
                CodeConsentType.AbortionLaminaria => "005",
                CodeConsentType.AccutaneInformation => "006",
                CodeConsentType.AccutaneWoman => "007",
                CodeConsentType.AdvancedBeneficiaryNotice => "008",
                CodeConsentType.AfpAlphaFetoproteinScreening => "009",
                CodeConsentType.AmniocentesisConsentRefusal => "010",
                CodeConsentType.AnatomicalGiftOrganDonation => "011",
                CodeConsentType.AnesthesiaComplications => "012",
                CodeConsentType.AnesthesiaQuestionnaire => "013",
                CodeConsentType.Angiogram => "014",
                CodeConsentType.Angioplasty => "015",
                CodeConsentType.AnticancerDrugs => "016",
                CodeConsentType.AntipsychoticMedications => "017",
                CodeConsentType.Arthrogram => "018",
                CodeConsentType.Autopsy => "019",
                CodeConsentType.AztTherapy => "020",
                CodeConsentType.BiliaryDrainage => "021",
                CodeConsentType.BiliaryStoneExtraction => "022",
                CodeConsentType.Biopsy => "023",
                CodeConsentType.BleedingTimeTest => "024",
                CodeConsentType.Bronchogram => "025",
                CodeConsentType.CardiacCatheterization => "026",
                CodeConsentType.CoronaryAngiography => "027",
                CodeConsentType.CoronaryAngiographyWOSurgeryCapability => "028",
                CodeConsentType.CataractOpImplantOfFdaAprvdLens => "029",
                CodeConsentType.CataractOpImplantOfInvestigationalLens => "030",
                CodeConsentType.CataractSurgery => "031",
                CodeConsentType.CholeraImmunization => "032",
                CodeConsentType.CholesterolScreening => "033",
                CodeConsentType.CircumcisionNewborn => "034",
                CodeConsentType.Colonoscopy => "035",
                CodeConsentType.ContactLenses => "036",
                CodeConsentType.CtScanCervicalLumbar => "037",
                CodeConsentType.CtScanWIvContrastMediaIntoVein => "038",
                CodeConsentType.CvsChorionicVillusSampling => "039",
                CodeConsentType.Cystospy => "040",
                CodeConsentType.DisclosureOfPhiToFamilyFriends => "041",
                CodeConsentType.DCAndConization => "042",
                CodeConsentType.Dacryocystogram => "043",
                CodeConsentType.DiagnosticIsotope => "044",
                CodeConsentType.DrainageOfAnAbscess => "045",
                CodeConsentType.DrugScreening => "046",
                CodeConsentType.ElectronicMonitoringOfLaborRefusal => "047",
                CodeConsentType.EndometrialBiopsy => "048",
                CodeConsentType.EndoscopySclerosisOfEsophagealVarices => "049",
                CodeConsentType.Ercp => "050",
                CodeConsentType.ExposureToReportableCommunicableDisease => "051",
                CodeConsentType.ExternalVersion => "052",
                CodeConsentType.FluoresceinAngioscopy => "053",
                CodeConsentType.HepatitisBConsentDeclination => "054",
                CodeConsentType.Herniogram => "055",
                CodeConsentType.HivTestConsentRefusal => "056",
                CodeConsentType.HivTestDisclosure => "057",
                CodeConsentType.HivTestPrenatal => "058",
                CodeConsentType.HomeIvTreatmentProgram => "059",
                CodeConsentType.HomeParenteralTreatmentProgram => "060",
                CodeConsentType.Hysterectomy => "061",
                CodeConsentType.Hysterosalpingogram => "062",
                CodeConsentType.InjectionSlipConsent => "063",
                CodeConsentType.IntrauterineDevice => "064",
                CodeConsentType.IntrauterineDeviceSterilization => "065",
                CodeConsentType.IntravascularInfusionOfStreptokinaseUrokinase => "066",
                CodeConsentType.IntravenousCholangiogram => "067",
                CodeConsentType.IntravenousDigitalAngiography => "068",
                CodeConsentType.IodineAdministration => "069",
                CodeConsentType.Isg => "070",
                CodeConsentType.Ivp => "071",
                CodeConsentType.LaserPhotocoagulation => "072",
                CodeConsentType.LaserTreatment => "073",
                CodeConsentType.LithiumCarbonate => "074",
                CodeConsentType.LiverBiopsy => "075",
                CodeConsentType.LumbarPuncture => "076",
                CodeConsentType.Lymphangiogram => "077",
                CodeConsentType.MaoInhibitors => "078",
                CodeConsentType.MedPsychAndOrDrugAlcohol => "079",
                CodeConsentType.MedicalTreatmentRefusal => "080",
                CodeConsentType.MorningAfterPill => "081",
                CodeConsentType.MriAdult => "082",
                CodeConsentType.MriPediatric => "083",
                CodeConsentType.Myelogram => "084",
                CodeConsentType.NeedleBiopsy => "085",
                CodeConsentType.NeedleBiopsyOfLung => "086",
                CodeConsentType.NewbornTreatmentAndRelease => "087",
                CodeConsentType.NorplantSubdermalBirthControlImplant => "088",
                CodeConsentType.OperationsAnesthesiaTransfusions => "089",
                CodeConsentType.OralContraceptives => "090",
                CodeConsentType.OrganDonation => "091",
                CodeConsentType.PatientPermitsConsents => "092",
                CodeConsentType.PatientTreatmentPermitReleaseAdmission => "093",
                CodeConsentType.PenileInjections => "094",
                CodeConsentType.PercutaneousNephrostomy => "095",
                CodeConsentType.PercutaneousTranshepaticCholangiogram => "096",
                CodeConsentType.Photographs => "097",
                CodeConsentType.PhotographsEmployee => "098",
                CodeConsentType.PhotographsMedicalResearch => "099",
                CodeConsentType.PhotographsNewsMedia => "100",
                CodeConsentType.PsychiatricAdmissionNextOfKin => "101",
                CodeConsentType.PsychiatricInformationDuringHospitalStay => "102",
                CodeConsentType.PublicReleaseOfInformation => "103",
                CodeConsentType.RadiologicProcedure => "104",
                CodeConsentType.RefusalOfTreatment => "105",
                CodeConsentType.ReleaseOfBody => "106",
                CodeConsentType.ReleaseOfLimb => "107",
                CodeConsentType.RhImmuneGlobulin => "108",
                CodeConsentType.RightsOfMedicalResearchParticipants => "109",
                CodeConsentType.RequestToRestrictAccessToPhi => "110",
                CodeConsentType.RequestForRemainAnonymous => "111",
                CodeConsentType.SeatBeltExemption => "112",
                CodeConsentType.Sialogram => "113",
                CodeConsentType.VoidingCystogram => "1137",
                CodeConsentType.Sigmoidoscopy => "114",
                CodeConsentType.SterilizationAnesthesiaMedicalServices => "115",
                CodeConsentType.SterilizationFederallyFunded => "116",
                CodeConsentType.SterilizationFemale => "117",
                CodeConsentType.SterilizationLaparoscopyPomeroy => "118",
                CodeConsentType.SterilizationNonFederallyFunded => "119",
                CodeConsentType.SterilizationSecondary => "120",
                CodeConsentType.Tranquilizers => "121",
                CodeConsentType.TransferAcknowledgement => "122",
                CodeConsentType.TransferAuthorization => "123",
                CodeConsentType.TransferCertificationPhysician => "124",
                CodeConsentType.TransferDischargeRequest => "125",
                CodeConsentType.TransferForNonMedicalReasons => "126",
                CodeConsentType.TransferInterfacultyNeonatal => "127",
                CodeConsentType.TransferRefusal => "128",
                CodeConsentType.TransferRefusalOfFurtherTreatment => "129",
                CodeConsentType.TreadmillEkg => "130",
                CodeConsentType.TreadmillThallium201 => "131",
                CodeConsentType.Typhoid => "132",
                CodeConsentType.UseOfInvestigationalDevice => "133",
                CodeConsentType.UseOfInvestigationalDrug => "134",
                CodeConsentType.Venogram => "135",
                CodeConsentType.Videotape => "136",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeConsentType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeContactRole enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeContactRole input)
        {
            return input switch
            {
                CodeContactRole.EmergencyContact => "C",
                CodeContactRole.Employer => "E",
                CodeContactRole.FederalAgency => "F",
                CodeContactRole.InsuranceCompany => "I",
                CodeContactRole.NextOfKin => "N",
                CodeContactRole.Other => "O",
                CodeContactRole.StateAgency => "S",
                CodeContactRole.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeContactRole input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeContainerCondition enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeContainerCondition input)
        {
            return input switch
            {
                CodeContainerCondition.ContainerCracked => "CC",
                CodeContainerCondition.ContainerLeaking => "CL",
                CodeContainerCondition.ContainerTorn => "CT",
                CodeContainerCondition.SealBroken => "SB",
                CodeContainerCondition.NotAmbientTemperature => "XAMB",
                CodeContainerCondition.NotBodyTemperature => "XC37",
                CodeContainerCondition.NotCriticalAmbientTemperature => "XCAMB",
                CodeContainerCondition.ExposedToAir => "XCATM",
                CodeContainerCondition.NotCriticalFrozenTemperature => "XCFRZ",
                CodeContainerCondition.NotCriticalRefrigeratedTemperature => "XCREF",
                CodeContainerCondition.NotDeepFrozen => "XDFRZ",
                CodeContainerCondition.NotDry => "XDRY",
                CodeContainerCondition.NotFrozenTemperature => "XFRZ",
                CodeContainerCondition.MetalExposed => "XMTLF",
                CodeContainerCondition.NotLiquidNitrogen => "XNTR",
                CodeContainerCondition.NotProtectedFromLight => "XPRTL",
                CodeContainerCondition.Shaken => "XPSA",
                CodeContainerCondition.ExposedToShock => "XPSO",
                CodeContainerCondition.NotRefrigeratedTemperature => "XREF",
                CodeContainerCondition.NotUltraFrozen => "XUFRZ",
                CodeContainerCondition.NotUpright => "XUPR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeContainerCondition input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeContainerStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeContainerStatus input)
        {
            return input switch
            {
                CodeContainerStatus.Identified => "I",
                CodeContainerStatus.LeftEquipment => "L",
                CodeContainerStatus.Missing => "M",
                CodeContainerStatus.InProcess => "O",
                CodeContainerStatus.InPosition => "P",
                CodeContainerStatus.ProcessCompleted => "R",
                CodeContainerStatus.Unknown => "U",
                CodeContainerStatus.ContainerUnavailable => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeContainerStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeContinuationStyleCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeContinuationStyleCode input)
        {
            return input switch
            {
                CodeContinuationStyleCode.Fragmentation => "F",
                CodeContinuationStyleCode.InteractiveContinuation => "I",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeContinuationStyleCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeControlledSubstanceSchedule enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeControlledSubstanceSchedule input)
        {
            return input switch
            {
                CodeControlledSubstanceSchedule.ScheduleI => "I",
                CodeControlledSubstanceSchedule.ScheduleIi => "II",
                CodeControlledSubstanceSchedule.ScheduleIii => "III",
                CodeControlledSubstanceSchedule.ScheduleIv => "IV",
                CodeControlledSubstanceSchedule.ScheduleV => "V",
                CodeControlledSubstanceSchedule.ScheduleVi => "VI",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeControlledSubstanceSchedule input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCoordinationOfBenefits enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCoordinationOfBenefits input)
        {
            return input switch
            {
                CodeCoordinationOfBenefits.Coordination => "CO",
                CodeCoordinationOfBenefits.Independent => "IN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCoordinationOfBenefits input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCoverageType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCoverageType input)
        {
            return input switch
            {
                CodeCoverageType.BothHospitalAndPhysician => "B",
                CodeCoverageType.HospitalInstitutional => "H",
                CodeCoverageType.PhysicianProfessional => "P",
                CodeCoverageType.Pharmacy => "RX",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCoverageType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCpRangeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCpRangeType input)
        {
            return input switch
            {
                CodeCpRangeType.FlatRate => "F",
                CodeCpRangeType.ProRate => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCpRangeType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCycleType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCycleType input)
        {
            return input switch
            {
                CodeCycleType.SecondRinse => "2RS",
                CodeCycleType.AnesthesiaRespiratory => "ANR",
                CodeCycleType.Bedpans => "BDP",
                CodeCycleType.BowieDickTest => "BWD",
                CodeCycleType.ChemicalWash => "CMW",
                CodeCycleType.Code => "COD",
                CodeCycleType.CartWash => "CRT",
                CodeCycleType.Decontamination => "DEC",
                CodeCycleType.Dart => "DRT",
                CodeCycleType.DartWarmUpCycle => "DRW",
                CodeCycleType.EoHighTemperature => "EOH",
                CodeCycleType.EoLowTemperature => "EOL",
                CodeCycleType.Express => "EXP",
                CodeCycleType.Flash => "FLS",
                CodeCycleType.Glassware => "GLS",
                CodeCycleType.GenPurpose => "GNP",
                CodeCycleType.Gravity => "GRV",
                CodeCycleType.Gentle => "GTL",
                CodeCycleType.Isothermal => "ISO",
                CodeCycleType.InstrumentWash => "IST",
                CodeCycleType.LeakTest => "LKT",
                CodeCycleType.Liquid => "LQD",
                CodeCycleType.OptionalWash => "OPW",
                CodeCycleType.PeraceticAcid => "PEA",
                CodeCycleType.PlasticGoodsWash => "PLA",
                CodeCycleType.Prevac => "PRV",
                CodeCycleType.Rinse => "RNS",
                CodeCycleType.SteamFlushPressurePulse => "SFP",
                CodeCycleType.Thermal => "THR",
                CodeCycleType.TrayBasin => "TRB",
                CodeCycleType.UtensilWash => "UTL",
                CodeCycleType.WrapSteamFlushPressurePulse => "WFP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCycleType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCyclicEntryExitIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCyclicEntryExitIndicator input)
        {
            return input switch
            {
                CodeCyclicEntryExitIndicator.TheLastServiceRequestInCyclicGroup => "#",
                CodeCyclicEntryExitIndicator.TheFirstServiceRequestInCyclicGroup => "*",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCyclicEntryExitIndicator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDataTypes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDataTypes input)
        {
            return input switch
            {
                CodeDataTypes.Address => "AD",
                CodeDataTypes.AuthorizationInformation => "AUI",
                CodeDataTypes.ChargeCodeAndDate => "CCD",
                CodeDataTypes.ChannelCalibrationParameters => "CCP",
                CodeDataTypes.ChannelDefinition => "CD",
                CodeDataTypes.CodedElement => "CE",
                CodeDataTypes.CodedElementWithFormattedValues => "CF",
                CodeDataTypes.CompositeIdWithCheckDigit => "CK",
                CodeDataTypes.Composite => "CM",
                CodeDataTypes.CompositeIdNumberAndName => "CN",
                CodeDataTypes.CodedWithNoExceptions => "CNE",
                CodeDataTypes.CompositeIdNumberAndNameSimplified => "CNN",
                CodeDataTypes.CompositePrice => "CP",
                CodeDataTypes.CompositeQuantityWithUnits => "CQ",
                CodeDataTypes.ChannelSensitivityAndUnits => "CSU",
                CodeDataTypes.CodedWithExceptions => "CWE",
                CodeDataTypes.ExtendedCompositeIdWithCheckDigit => "CX",
                CodeDataTypes.DailyDeductibleInformation => "DDI",
                CodeDataTypes.DateAndInstitutionName => "DIN",
                CodeDataTypes.DischargeToLocationAndDate => "DLD",
                CodeDataTypes.DriversLicenseNumber => "DLN",
                CodeDataTypes.Delta => "DLT",
                CodeDataTypes.DateTimeRange => "DR",
                CodeDataTypes.Date => "DT",
                CodeDataTypes.DateTime => "DTM",
                CodeDataTypes.DayTypeAndNumber => "DTN",
                CodeDataTypes.EncapsulatedData => "ED",
                CodeDataTypes.EntityIdentifier => "EI",
                CodeDataTypes.EntityIdentifierPair => "EIP",
                CodeDataTypes.ErrorLocationAndDescription => "ELD",
                CodeDataTypes.ErrorLocation => "ERL",
                CodeDataTypes.FinancialClass => "FC",
                CodeDataTypes.FamilyName => "FN",
                CodeDataTypes.FormattedText => "FT",
                CodeDataTypes.GeneralTimingSpecification => "GTS",
                CodeDataTypes.HierarchicDesignator => "HD",
                CodeDataTypes.InsuranceCertificationDefinition => "ICD",
                CodeDataTypes.CodedValuesForHl7Tables => "ID",
                CodeDataTypes.CodedValueForUserDefinedTables => "IS",
                CodeDataTypes.JobCodeClass => "JCC",
                CodeDataTypes.LocationWithAddressVariation1 => "LA1",
                CodeDataTypes.LocationWithAddressVariation2 => "LA2",
                CodeDataTypes.MultiplexedArray => "MA",
                CodeDataTypes.Money => "MO",
                CodeDataTypes.MoneyAndChargeCode => "MOC",
                CodeDataTypes.MoneyOrPercentage => "MOP",
                CodeDataTypes.MessageType => "MSG",
                CodeDataTypes.NumericArray => "NA",
                CodeDataTypes.NameWithDateAndLocation => "NDL",
                CodeDataTypes.Numeric => "NM",
                CodeDataTypes.NumericRange => "NR",
                CodeDataTypes.OccurrenceCodeAndDate => "OCD",
                CodeDataTypes.OrderSequenceDefinition => "OSD",
                CodeDataTypes.OccurrenceSpanCodeAndDate => "OSP",
                CodeDataTypes.PractitionerInstitutionalPrivileges => "PIP",
                CodeDataTypes.PersonLocation => "PL",
                CodeDataTypes.PractitionerLicenseOrOtherIdNumber => "PLN",
                CodeDataTypes.PersonName => "PN",
                CodeDataTypes.PerformingPersonTimeStamp => "PPN",
                CodeDataTypes.ParentResultLink => "PRL",
                CodeDataTypes.ProcessingType => "PT",
                CodeDataTypes.PolicyTypeAndAmount => "PTA",
                CodeDataTypes.QueryInputParameterList => "QIP",
                CodeDataTypes.QuerySelectionCriteria => "QSC",
                CodeDataTypes.RowColumnDefinition => "RCD",
                CodeDataTypes.ReferenceRange => "RFR",
                CodeDataTypes.RepeatInterval => "RI",
                CodeDataTypes.RoomCoverage => "RMC",
                CodeDataTypes.ReferencePointer => "RP",
                CodeDataTypes.RepeatPattern => "RPT",
                CodeDataTypes.StreetAddress => "SAD",
                CodeDataTypes.SchedulingClassValuePair => "SCV",
                CodeDataTypes.SequenceId => "SI",
                CodeDataTypes.StructuredNumeric => "SN",
                CodeDataTypes.StringOfTelephoneNumberDigits => "SNM",
                CodeDataTypes.SpecialtyDescription => "SPD",
                CodeDataTypes.SpecimenSource => "SPS",
                CodeDataTypes.SortOrder => "SRT",
                CodeDataTypes.StringData => "ST",
                CodeDataTypes.Time => "TM",
                CodeDataTypes.TelephoneNumber => "TN",
                CodeDataTypes.TimingQuantity => "TQ",
                CodeDataTypes.TimeStamp => "TS",
                CodeDataTypes.TextData => "TX",
                CodeDataTypes.UbValueCodeAndAmount => "UVC",
                CodeDataTypes.VisitingHours => "VH",
                CodeDataTypes.VersionIdentifier => "VID",
                CodeDataTypes.ValueRange => "VR",
                CodeDataTypes.ChannelIdentifier => "WVI",
                CodeDataTypes.WaveformSource => "WVS",
                CodeDataTypes.ExtendedAddress => "XAD",
                CodeDataTypes.ExtendedCompositeIdNumberAndNameForPersons => "XCN",
                CodeDataTypes.ExtendedCompositeNameAndIdNumberForOrganizations => "XON",
                CodeDataTypes.ExtendedPersonName => "XPN",
                CodeDataTypes.ExtendedTelecommunicationsNumber => "XTN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDataTypes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDateFormat enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDateFormat input)
        {
            return input switch
            {
                CodeDateFormat.MmDdYyWithSlashes => "1",
                CodeDateFormat.YyMmDdWithPeriods => "2",
                CodeDateFormat.DdMmYyWithSlashes => "3",
                CodeDateFormat.DdMmYyWithPeriods => "4",
                CodeDateFormat.YyMmDdWithSlashes => "5",
                CodeDateFormat.Yymmdd => "6",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDateFormat input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDaysOfTheWeek enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDaysOfTheWeek input)
        {
            return input switch
            {
                CodeDaysOfTheWeek.Friday => "FRI",
                CodeDaysOfTheWeek.Monday => "MON",
                CodeDaysOfTheWeek.Saturday => "SAT",
                CodeDaysOfTheWeek.Sunday => "SUN",
                CodeDaysOfTheWeek.Thursday => "THU",
                CodeDaysOfTheWeek.Tuesday => "TUE",
                CodeDaysOfTheWeek.Wednesday => "WED",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDaysOfTheWeek input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDayType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDayType input)
        {
            return input switch
            {
                CodeDayType.Approved => "AP",
                CodeDayType.Denied => "DE",
                CodeDayType.Pending => "PE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDayType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDegreeLicenseCertificate enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDegreeLicenseCertificate input)
        {
            return input switch
            {
                CodeDegreeLicenseCertificate.AssociateOfArts => "AA",
                CodeDegreeLicenseCertificate.AssociateOfAppliedScience => "AAS",
                CodeDegreeLicenseCertificate.AssociateOfBusinessAdministration => "ABA",
                CodeDegreeLicenseCertificate.AssociateOfEngineering => "AE",
                CodeDegreeLicenseCertificate.AssociateOfScience => "AS",
                CodeDegreeLicenseCertificate.BachelorOfArts => "BA",
                CodeDegreeLicenseCertificate.BachelorOfBusinessAdministration => "BBA",
                CodeDegreeLicenseCertificate.BachelorOrEngineering => "BE",
                CodeDegreeLicenseCertificate.BachelorOfFineArts => "BFA",
                CodeDegreeLicenseCertificate.BachelorOfNursing => "BN",
                CodeDegreeLicenseCertificate.BachelorOfScience => "BS",
                CodeDegreeLicenseCertificate.BachelorOfScienceLaw => "BSL",
                CodeDegreeLicenseCertificate.BachelorOnScienceNursing => "BSN",
                CodeDegreeLicenseCertificate.BachelorOfTheology => "BT",
                CodeDegreeLicenseCertificate.CertifiedAdultNursePractitioner => "CANP",
                CodeDegreeLicenseCertificate.Certificate => "CER",
                CodeDegreeLicenseCertificate.CertifiedMedicalAssistant => "CMA",
                CodeDegreeLicenseCertificate.CertifiedNurseMidwife => "CNM",
                CodeDegreeLicenseCertificate.CertifiedNursePractitioner => "CNP",
                CodeDegreeLicenseCertificate.CertifiedNurseSpecialist => "CNS",
                CodeDegreeLicenseCertificate.CertifiedPediatricNursePractitioner => "CPNP",
                CodeDegreeLicenseCertificate.CertifiedRegisteredNurse => "CRN",
                CodeDegreeLicenseCertificate.DoctorOfBusinessAdministration => "DBA",
                CodeDegreeLicenseCertificate.DoctorOfEducation => "DED",
                CodeDegreeLicenseCertificate.Diploma => "DIP",
                CodeDegreeLicenseCertificate.DoctorOfOsteopathy => "DO",
                CodeDegreeLicenseCertificate.EmergencyMedicalTechnician => "EMT",
                CodeDegreeLicenseCertificate.EmergencyMedicalTechnicianParamedic => "EMTP",
                CodeDegreeLicenseCertificate.FamilyPracticeNursePractitioner => "FPNP",
                CodeDegreeLicenseCertificate.HighSchoolGraduate => "HS",
                CodeDegreeLicenseCertificate.JurisDoctor => "JD",
                CodeDegreeLicenseCertificate.MasterOfArts => "MA",
                CodeDegreeLicenseCertificate.MasterOfBusinessAdministration => "MBA",
                CodeDegreeLicenseCertificate.MasterOfCivilEngineering => "MCE",
                CodeDegreeLicenseCertificate.DoctorOfMedicine => "MD",
                CodeDegreeLicenseCertificate.MedicalAssistant => "MDA",
                CodeDegreeLicenseCertificate.MasterOfDivinity => "MDI",
                CodeDegreeLicenseCertificate.MasterOfEngineering => "ME",
                CodeDegreeLicenseCertificate.MasterOfEducation => "MED",
                CodeDegreeLicenseCertificate.MasterOfElectricalEngineering => "MEE",
                CodeDegreeLicenseCertificate.MasterOfFineArts => "MFA",
                CodeDegreeLicenseCertificate.MasterOfMechanicalEngineering => "MME",
                CodeDegreeLicenseCertificate.MasterOfScience => "MS",
                CodeDegreeLicenseCertificate.MasterOfScienceLaw => "MSL",
                CodeDegreeLicenseCertificate.MasterOfScienceNursing => "MSN",
                CodeDegreeLicenseCertificate.MedicalTechnician => "MT",
                CodeDegreeLicenseCertificate.MasterOfTheology => "MTH",
                CodeDegreeLicenseCertificate.NonGraduate => "NG",
                CodeDegreeLicenseCertificate.NursePractitioner => "NP",
                CodeDegreeLicenseCertificate.PhysicianAssistant => "PA",
                CodeDegreeLicenseCertificate.DoctorOfPhilosophy => "PHD",
                CodeDegreeLicenseCertificate.DoctorOfEngineering => "PHE",
                CodeDegreeLicenseCertificate.DoctorOfScience => "PHS",
                CodeDegreeLicenseCertificate.AdvancedPracticeNurse => "PN",
                CodeDegreeLicenseCertificate.DoctorOfPharmacy => "PharmD",
                CodeDegreeLicenseCertificate.RegisteredMedicalAssistant => "RMA",
                CodeDegreeLicenseCertificate.RegisteredNurse => "RN",
                CodeDegreeLicenseCertificate.RegisteredPharmacist => "RPH",
                CodeDegreeLicenseCertificate.SecretarialCertificate => "SEC",
                CodeDegreeLicenseCertificate.TradeSchoolGraduate => "TS",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDegreeLicenseCertificate input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDenialOrRejectionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDenialOrRejectionCode input)
        {
            return input switch
            {
                CodeDenialOrRejectionCode.LineItemNotDeniedOrRejected => "0",
                CodeDenialOrRejectionCode.LineItemDeniedOrRejected => "1",
                CodeDenialOrRejectionCode.LineItemIsOnAMultipleDayClaim => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDenialOrRejectionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDerivedSpecimen enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDerivedSpecimen input)
        {
            return input switch
            {
                CodeDerivedSpecimen.ChildObservation => "C",
                CodeDerivedSpecimen.NotApplicable => "N",
                CodeDerivedSpecimen.ParentObservation => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDerivedSpecimen input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDeviceDataState enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDeviceDataState input)
        {
            return input switch
            {
                CodeDeviceDataState.RealTimeValues => "0",
                CodeDeviceDataState.HistoricValues => "1",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDeviceDataState input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDeviceStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDeviceStatus input)
        {
            return input switch
            {
                CodeDeviceStatus.Ready => "0",
                CodeDeviceStatus.NotReady => "1",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDeviceStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDeviceType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDeviceType input)
        {
            return input switch
            {
                CodeDeviceType.EoGasSterilizer => "1",
                CodeDeviceType.SteamSterilizer => "2",
                CodeDeviceType.PeraceticAcid => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDeviceType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDiagnosisClassification enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDiagnosisClassification input)
        {
            return input switch
            {
                CodeDiagnosisClassification.Consultation => "C",
                CodeDiagnosisClassification.Diagnosis => "D",
                CodeDiagnosisClassification.InvasiveProcedureNotClassified => "I",
                CodeDiagnosisClassification.MedicationAntibiotic => "M",
                CodeDiagnosisClassification.Other => "O",
                CodeDiagnosisClassification.RadiologicalScheduling => "R",
                CodeDiagnosisClassification.SignAndSymptom => "S",
                CodeDiagnosisClassification.TissueDiagnosis => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDiagnosisClassification input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDiagnosisPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDiagnosisPriority input)
        {
            return input switch
            {
                CodeDiagnosisPriority.NoSuggestedValuesDefined => "...",
                CodeDiagnosisPriority.NotIncludedInDiagnosisRanking => "0",
                CodeDiagnosisPriority.ThePrimaryDiagnosis => "1",
                CodeDiagnosisPriority.ForSecondaryDiagnosis => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDiagnosisPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDiagnosisType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDiagnosisType input)
        {
            return input switch
            {
                CodeDiagnosisType.Admitting => "A",
                CodeDiagnosisType.Final => "F",
                CodeDiagnosisType.Working => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDiagnosisType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDiagnosticServiceSectionId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDiagnosticServiceSectionId input)
        {
            return input switch
            {
                CodeDiagnosticServiceSectionId.Audiology => "AU",
                CodeDiagnosticServiceSectionId.BloodGases => "BG",
                CodeDiagnosticServiceSectionId.BloodBank => "BLB",
                CodeDiagnosticServiceSectionId.Chemistry => "CH",
                CodeDiagnosticServiceSectionId.Cytopathology => "CP",
                CodeDiagnosticServiceSectionId.CatScan => "CT",
                CodeDiagnosticServiceSectionId.CardiacCatheterization => "CTH",
                CodeDiagnosticServiceSectionId.CardiacUltrasound => "CUS",
                CodeDiagnosticServiceSectionId.Electrocardiac => "EC",
                CodeDiagnosticServiceSectionId.Electroneuro => "EN",
                CodeDiagnosticServiceSectionId.Hematology => "HM",
                CodeDiagnosticServiceSectionId.BedsideIcuMonitoring => "ICU",
                CodeDiagnosticServiceSectionId.Immunology => "IMM",
                CodeDiagnosticServiceSectionId.Laboratory => "LAB",
                CodeDiagnosticServiceSectionId.Microbiology => "MB",
                CodeDiagnosticServiceSectionId.Mycobacteriology => "MCB",
                CodeDiagnosticServiceSectionId.Mycology => "MYC",
                CodeDiagnosticServiceSectionId.NuclearMagneticResonance => "NMR",
                CodeDiagnosticServiceSectionId.NuclearMedicineScan => "NMS",
                CodeDiagnosticServiceSectionId.NursingServiceMeasures => "NRS",
                CodeDiagnosticServiceSectionId.OutsideLab => "OSL",
                CodeDiagnosticServiceSectionId.OccupationalTherapy => "OT",
                CodeDiagnosticServiceSectionId.Other => "OTH",
                CodeDiagnosticServiceSectionId.ObUltrasound => "OUS",
                CodeDiagnosticServiceSectionId.PulmonaryFunction => "PF",
                CodeDiagnosticServiceSectionId.Pharmacy => "PHR",
                CodeDiagnosticServiceSectionId.Physician => "PHY",
                CodeDiagnosticServiceSectionId.PhysicalTherapy => "PT",
                CodeDiagnosticServiceSectionId.Radiology => "RAD",
                CodeDiagnosticServiceSectionId.RespiratoryCareTherapy => "RC",
                CodeDiagnosticServiceSectionId.RadiationTherapy => "RT",
                CodeDiagnosticServiceSectionId.RadiologyUltrasound => "RUS",
                CodeDiagnosticServiceSectionId.Radiograph => "RX",
                CodeDiagnosticServiceSectionId.SurgicalPathology => "SP",
                CodeDiagnosticServiceSectionId.Serology => "SR",
                CodeDiagnosticServiceSectionId.Toxicology => "TX",
                CodeDiagnosticServiceSectionId.Virology => "VR",
                CodeDiagnosticServiceSectionId.VascularUltrasound => "VUS",
                CodeDiagnosticServiceSectionId.Cineradiograph => "XRC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDiagnosticServiceSectionId input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDietCodeSpecificationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDietCodeSpecificationType input)
        {
            return input switch
            {
                CodeDietCodeSpecificationType.Diet => "D",
                CodeDietCodeSpecificationType.Preference => "P",
                CodeDietCodeSpecificationType.Supplement => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDietCodeSpecificationType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDisabledPersonCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDisabledPersonCode input)
        {
            return input switch
            {
                CodeDisabledPersonCode.AssociatedParty => "AP",
                CodeDisabledPersonCode.Guarantor => "GT",
                CodeDisabledPersonCode.Insured => "IN",
                CodeDisabledPersonCode.Patient => "PT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDisabledPersonCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDispenseMethod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDispenseMethod input)
        {
            return input switch
            {
                CodeDispenseMethod.AutomaticDispensing => "AD",
                CodeDispenseMethod.FloorStock => "F",
                CodeDispenseMethod.Traditional => "TR",
                CodeDispenseMethod.UnitDose => "UD",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDispenseMethod input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDispenseType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDispenseType input)
        {
            return input switch
            {
                CodeDispenseType.TrialQuantityBalance => "B",
                CodeDispenseType.CompassionateFill => "C",
                CodeDispenseType.NewRenewFullFill => "N",
                CodeDispenseType.NewRenewPartFill => "P",
                CodeDispenseType.RefillPartFill => "Q",
                CodeDispenseType.RefillFullFill => "R",
                CodeDispenseType.ManufacturerSample => "S",
                CodeDispenseType.TrialQuantity => "T",
                CodeDispenseType.NonPrescriptionFill => "Z",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDispenseType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDocumentAvailabilityStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDocumentAvailabilityStatus input)
        {
            return input switch
            {
                CodeDocumentAvailabilityStatus.AvailableForPatientCare => "AV",
                CodeDocumentAvailabilityStatus.Deleted => "CA",
                CodeDocumentAvailabilityStatus.Obsolete => "OB",
                CodeDocumentAvailabilityStatus.UnavailableForPatientCare => "UN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDocumentAvailabilityStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDocumentCompletionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDocumentCompletionStatus input)
        {
            return input switch
            {
                CodeDocumentCompletionStatus.Authenticated => "AU",
                CodeDocumentCompletionStatus.Dictated => "DI",
                CodeDocumentCompletionStatus.Documented => "DO",
                CodeDocumentCompletionStatus.Incomplete => "IN",
                CodeDocumentCompletionStatus.InProgress => "IP",
                CodeDocumentCompletionStatus.LegallyAuthenticated => "LA",
                CodeDocumentCompletionStatus.PreAuthenticated => "PA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDocumentCompletionStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDocumentConfidentialityStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDocumentConfidentialityStatus input)
        {
            return input switch
            {
                CodeDocumentConfidentialityStatus.Restricted => "R",
                CodeDocumentConfidentialityStatus.UsualControl => "U",
                CodeDocumentConfidentialityStatus.VeryRestricted => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDocumentConfidentialityStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDocumentStorageStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDocumentStorageStatus input)
        {
            return input switch
            {
                CodeDocumentStorageStatus.ActiveAndArchived => "AA",
                CodeDocumentStorageStatus.Active => "AC",
                CodeDocumentStorageStatus.Archived => "AR",
                CodeDocumentStorageStatus.Purged => "PU",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDocumentStorageStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDocumentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDocumentType input)
        {
            return input switch
            {
                CodeDocumentType.AutopsyReport => "AR",
                CodeDocumentType.Cardiodiagnostics => "CD",
                CodeDocumentType.Consultation => "CN",
                CodeDocumentType.DiagnosticImaging => "DI",
                CodeDocumentType.DischargeSummary => "DS",
                CodeDocumentType.EmergencyDepartmentReport => "ED",
                CodeDocumentType.HistoryAndPhysicalExamination => "HP",
                CodeDocumentType.OperativeReport => "OP",
                CodeDocumentType.PsychiatricConsultation => "PC",
                CodeDocumentType.PsychiatricHistoryAndPhysicalExamination => "PH",
                CodeDocumentType.ProcedureNote => "PN",
                CodeDocumentType.ProgressNote => "PR",
                CodeDocumentType.SurgicalPathology => "SP",
                CodeDocumentType.TransferSummary => "TS",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDocumentType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDrgDiagnosisDeterminationStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDrgDiagnosisDeterminationStatus input)
        {
            return input switch
            {
                CodeDrgDiagnosisDeterminationStatus.ValidCode => "0",
                CodeDrgDiagnosisDeterminationStatus.InvalidCode => "1",
                CodeDrgDiagnosisDeterminationStatus.TwoPrimaryDiagnosisCodes => "2",
                CodeDrgDiagnosisDeterminationStatus.InvalidForThisGender => "3",
                CodeDrgDiagnosisDeterminationStatus.InvalidForThisAge => "4",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDrgDiagnosisDeterminationStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDrgGroupingStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDrgGroupingStatus input)
        {
            return input switch
            {
                CodeDrgGroupingStatus.ValidCodeNotUsedForGrouping => "0",
                CodeDrgGroupingStatus.ValidCodeUsedForGrouping => "1",
                CodeDrgGroupingStatus.InvalidCodeNotUsedForGrouping => "2",
                CodeDrgGroupingStatus.InvalidCodeCodeIsRelevantForGrouping => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDrgGroupingStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDrgPayor enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDrgPayor input)
        {
            return input switch
            {
                CodeDrgPayor.Champus => "C",
                CodeDrgPayor.ManagedCareOrganization => "G",
                CodeDrgPayor.Medicare => "M",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDrgPayor input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDrgProcedureDeterminationStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDrgProcedureDeterminationStatus input)
        {
            return input switch
            {
                CodeDrgProcedureDeterminationStatus.ValidCode => "0",
                CodeDrgProcedureDeterminationStatus.InvalidCode => "1",
                CodeDrgProcedureDeterminationStatus.NotUsed => "2",
                CodeDrgProcedureDeterminationStatus.InvalidForThisGender => "3",
                CodeDrgProcedureDeterminationStatus.InvalidForThisAge => "4",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDrgProcedureDeterminationStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDrgProcedureRelevance enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDrgProcedureRelevance input)
        {
            return input switch
            {
                CodeDrgProcedureRelevance.NeitherOperationRelevantNorNonOperationRelevantProcedure => "0",
                CodeDrgProcedureRelevance.OperationRelevantProcedure => "1",
                CodeDrgProcedureRelevance.NonOperationRelevantProcedure => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDrgProcedureRelevance input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDrgStatusFinancialCalculation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDrgStatusFinancialCalculation input)
        {
            return input switch
            {
                CodeDrgStatusFinancialCalculation.EffectiveWeightCalculated => "00",
                CodeDrgStatusFinancialCalculation.HospitalSpecificContract => "01",
                CodeDrgStatusFinancialCalculation.EeffectiveWeightForTransferReferralCalculated => "03",
                CodeDrgStatusFinancialCalculation.ReferralFromOtherHospitalBasedOnACooperationNoDrgReimbursement => "04",
                CodeDrgStatusFinancialCalculation.InvalidLengthOfStay => "05",
                CodeDrgStatusFinancialCalculation.NoInformationEntryInCostDataForThisDrg => "10",
                CodeDrgStatusFinancialCalculation.NoRelativeWeightFoundForDepartmentType => "11",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDrgStatusFinancialCalculation input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDrgStatusPatient enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDrgStatusPatient input)
        {
            return input switch
            {
                CodeDrgStatusPatient.NormalLengthOfStay => "1",
                CodeDrgStatusPatient.ShortLengthOfStay => "2",
                CodeDrgStatusPatient.LongLengthOfStay => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDrgStatusPatient input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDrgStatusRespirationMinutes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDrgStatusRespirationMinutes input)
        {
            return input switch
            {
                CodeDrgStatusRespirationMinutes.RespirationMinutesNotUsedForGrouping => "0",
                CodeDrgStatusRespirationMinutes.ListedRespirationMinutesUsedForGrouping => "1",
                CodeDrgStatusRespirationMinutes.OpsCodeValueUsedForGrouping => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDrgStatusRespirationMinutes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDurationCategories enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDurationCategories input)
        {
            return input switch
            {
                CodeDurationCategories.AsteriskLifeOfTheUnit => "*",
                CodeDurationCategories.TwelveHours => "12H",
                CodeDurationCategories.OneHour => "1H",
                CodeDurationCategories.OneMonth => "1L",
                CodeDurationCategories.OneWeek => "1W",
                CodeDurationCategories.TwoAndAHalfHours => "2.5H",
                CodeDurationCategories.TwentyFourHours => "24H",
                CodeDurationCategories.TwoDays => "2D",
                CodeDurationCategories.TwoHours => "2H",
                CodeDurationCategories.TwoMonths => "2L",
                CodeDurationCategories.TwoWeeks => "2W",
                CodeDurationCategories.ThirtyMinutes => "30M",
                CodeDurationCategories.ThreeDays => "3D",
                CodeDurationCategories.ThreeHours => "3H",
                CodeDurationCategories.ThreeMonths => "3L",
                CodeDurationCategories.ThreeWeeks => "3W",
                CodeDurationCategories.FourDays => "4D",
                CodeDurationCategories.FourHours => "4H",
                CodeDurationCategories.FourWeeks => "4W",
                CodeDurationCategories.FiveDays => "5D",
                CodeDurationCategories.FiveHours => "5H",
                CodeDurationCategories.SixDays => "6D",
                CodeDurationCategories.SixHours => "6H",
                CodeDurationCategories.SevenHours => "7H",
                CodeDurationCategories.EightHours => "8H",
                CodeDurationCategories.PointInTime => "PT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDurationCategories input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEligibilitySource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEligibilitySource input)
        {
            return input switch
            {
                CodeEligibilitySource.InsuranceCompany => "1",
                CodeEligibilitySource.Employer => "2",
                CodeEligibilitySource.InsuredPresentedPolicy => "3",
                CodeEligibilitySource.InsuredPresentedCard => "4",
                CodeEligibilitySource.SignedStatementOnFile => "5",
                CodeEligibilitySource.VerbalInformation => "6",
                CodeEligibilitySource.None => "7",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEligibilitySource input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEmploymentStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEmploymentStatus input)
        {
            return input switch
            {
                CodeEmploymentStatus.FullTimeEmployed => "1",
                CodeEmploymentStatus.PartTimeEmployed => "2",
                CodeEmploymentStatus.Unemployed => "3",
                CodeEmploymentStatus.SelfEmployed => "4",
                CodeEmploymentStatus.Retired => "5",
                CodeEmploymentStatus.OnActiveMilitaryDuty => "6",
                CodeEmploymentStatus.Unknown => "9",
                CodeEmploymentStatus.ContractPerDiem => "C",
                CodeEmploymentStatus.LeaveOfAbsence => "L",
                CodeEmploymentStatus.Other => "O",
                CodeEmploymentStatus.TemporarilyUnemployed => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEmploymentStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEncoding enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEncoding input)
        {
            return input switch
            {
                CodeEncoding.NoEncoding => "A",
                CodeEncoding.Base64 => "Base64",
                CodeEncoding.Hexadecimal => "Hex",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEncoding input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEquipmentState enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEquipmentState input)
        {
            return input switch
            {
                CodeEquipmentState.NullNoStateChangeADeprecated => "...",
                CodeEquipmentState.Clearing => "CL",
                CodeEquipmentState.Configuring => "CO",
                CodeEquipmentState.EStopped => "ES",
                CodeEquipmentState.Idle => "ID",
                CodeEquipmentState.Initializing => "IN",
                CodeEquipmentState.NormalOperation => "OP",
                CodeEquipmentState.Pausing => "PA",
                CodeEquipmentState.Paused => "PD",
                CodeEquipmentState.PoweredUp => "PU",
                CodeEquipmentState.NullNoStateChangeBDeprecated => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEquipmentState input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeErrorSeverity enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeErrorSeverity input)
        {
            return input switch
            {
                CodeErrorSeverity.Error => "E",
                CodeErrorSeverity.FatalError => "F",
                CodeErrorSeverity.Information => "I",
                CodeErrorSeverity.Warning => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeErrorSeverity input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEscortRequired enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEscortRequired input)
        {
            return input switch
            {
                CodeEscortRequired.NotRequired => "N",
                CodeEscortRequired.Required => "R",
                CodeEscortRequired.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEscortRequired input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEthnicGroup enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEthnicGroup input)
        {
            return input switch
            {
                CodeEthnicGroup.HispanicOrLatino => "H",
                CodeEthnicGroup.NotHispanicOrLatino => "N",
                CodeEthnicGroup.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEthnicGroup input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventConsequence enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventConsequence input)
        {
            return input switch
            {
                CodeEventConsequence.CongenitalAnomalyBirthDefect => "C",
                CodeEventConsequence.Death => "D",
                CodeEventConsequence.CausedHospitalized => "H",
                CodeEventConsequence.Incapacity => "I",
                CodeEventConsequence.Disability => "J",
                CodeEventConsequence.LifeThreatening => "L",
                CodeEventConsequence.Other => "O",
                CodeEventConsequence.ProlongedHospitalization => "P",
                CodeEventConsequence.RequiredIntervention => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventConsequence input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventExpected enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventExpected input)
        {
            return input switch
            {
                CodeEventExpected.No => "N",
                CodeEventExpected.Unknown => "U",
                CodeEventExpected.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventExpected input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventQualification enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventQualification input)
        {
            return input switch
            {
                CodeEventQualification.Abuse => "A",
                CodeEventQualification.UnexpectedBeneficialEffect => "B",
                CodeEventQualification.Dependency => "D",
                CodeEventQualification.Interaction => "I",
                CodeEventQualification.LackOfExpectTherapeuticEffect => "L",
                CodeEventQualification.Misuse => "M",
                CodeEventQualification.Overdose => "O",
                CodeEventQualification.DrugWithdrawal => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventQualification input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventReason input)
        {
            return input switch
            {
                CodeEventReason.PatientRequest => "01",
                CodeEventReason.PhysicianHealthPractitionerOrder => "02",
                CodeEventReason.CensusManagement => "03",
                CodeEventReason.Other => "O",
                CodeEventReason.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventRelatedPeriod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventRelatedPeriod input)
        {
            return input switch
            {
                CodeEventRelatedPeriod.BeforeMealFromLatAnteCibus => "AC",
                CodeEventRelatedPeriod.BeforeLunchFromLatAnteCibusDiurnus => "ACD",
                CodeEventRelatedPeriod.BeforeBreakfastFromLatAnteCibusMatutinus => "ACM",
                CodeEventRelatedPeriod.BeforeDinnerFromLatAnteCibusVespertinus => "ACV",
                CodeEventRelatedPeriod.TheHourOfSleepEGH1822 => "HS",
                CodeEventRelatedPeriod.BetweenMealsFromLatInterCibus => "IC",
                CodeEventRelatedPeriod.BetweenLunchAndDinner => "ICD",
                CodeEventRelatedPeriod.BetweenBreakfastAndLunch => "ICM",
                CodeEventRelatedPeriod.BetweenDinnerAndTheHourOfSleep => "ICV",
                CodeEventRelatedPeriod.AfterMealFromLatPostCibus => "PC",
                CodeEventRelatedPeriod.AfterLunchFromLatPostCibusDiurnus => "PCD",
                CodeEventRelatedPeriod.AfterBreakfastFromLatPostCibusMatutinus => "PCM",
                CodeEventRelatedPeriod.AfterDinnerFromLatPostCibusVespertinus => "PCV",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventRelatedPeriod input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventReportedTo enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventReportedTo input)
        {
            return input switch
            {
                CodeEventReportedTo.Distributor => "D",
                CodeEventReportedTo.LocalFacilityUserFacility => "L",
                CodeEventReportedTo.Manufacturer => "M",
                CodeEventReportedTo.RegulatoryAgency => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventReportedTo input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventSeriousness enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventSeriousness input)
        {
            return input switch
            {
                CodeEventSeriousness.No => "N",
                CodeEventSeriousness.Significant => "S",
                CodeEventSeriousness.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventSeriousness input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventType input)
        {
            return input switch
            {
                CodeEventType.LogEvent => "LOG",
                CodeEventType.ServiceEvent => "SER",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventTypeCode input)
        {
            return input switch
            {
                CodeEventTypeCode.AdtAckAdmitVisitNotification => "A01",
                CodeEventTypeCode.AdtAckTransferAPatient => "A02",
                CodeEventTypeCode.AdtAckDischargeEndVisit => "A03",
                CodeEventTypeCode.AdtAckRegisterAPatient => "A04",
                CodeEventTypeCode.AdtAckPreAdmitAPatient => "A05",
                CodeEventTypeCode.AdtAckChangeAnOutpatientToAnInpatient => "A06",
                CodeEventTypeCode.AdtAckChangeAnInpatientToAnOutpatient => "A07",
                CodeEventTypeCode.AdtAckUpdatePatientInformation => "A08",
                CodeEventTypeCode.AdtAckPatientDepartingTracking => "A09",
                CodeEventTypeCode.AdtAckPatientArrivingTracking => "A10",
                CodeEventTypeCode.AdtAckCancelAdmitVisitNotification => "A11",
                CodeEventTypeCode.AdtAckCancelTransfer => "A12",
                CodeEventTypeCode.AdtAckCancelDischargeEndVisit => "A13",
                CodeEventTypeCode.AdtAckPendingAdmit => "A14",
                CodeEventTypeCode.AdtAckPendingTransfer => "A15",
                CodeEventTypeCode.AdtAckPendingDischarge => "A16",
                CodeEventTypeCode.AdtAckSwapPatients => "A17",
                CodeEventTypeCode.AdtAckMergePatientInformation => "A18",
                CodeEventTypeCode.QryAdrPatientQuery => "A19",
                CodeEventTypeCode.AdtAckBedStatusUpdate => "A20",
                CodeEventTypeCode.AdtAckPatientGoesOnALeaveOfAbsence => "A21",
                CodeEventTypeCode.AdtAckPatientReturnsFromALeaveOfAbsence => "A22",
                CodeEventTypeCode.AdtAckDeleteAPatientRecord => "A23",
                CodeEventTypeCode.AdtAckLinkPatientInformation => "A24",
                CodeEventTypeCode.AdtAckCancelPendingDischarge => "A25",
                CodeEventTypeCode.AdtAckCancelPendingTransfer => "A26",
                CodeEventTypeCode.AdtAckCancelPendingAdmit => "A27",
                CodeEventTypeCode.AdtAckAddPersonInformation => "A28",
                CodeEventTypeCode.AdtAckDeletePersonInformation => "A29",
                CodeEventTypeCode.AdtAckMergePersonInformation => "A30",
                CodeEventTypeCode.AdtAckUpdatePersonInformation => "A31",
                CodeEventTypeCode.AdtAckCancelPatientArrivingTracking => "A32",
                CodeEventTypeCode.AdtAckCancelPatientDepartingTracking => "A33",
                CodeEventTypeCode.AdtAckMergePatientInfoPatientId => "A34",
                CodeEventTypeCode.AdtAckMergePatientInfoAccountNumber => "A35",
                CodeEventTypeCode.AdtAckMergePatientInfoPatientIdAccountNumber => "A36",
                CodeEventTypeCode.AdtAckUnlinkPatientInformation => "A37",
                CodeEventTypeCode.AdtAckCancelPreAdmit => "A38",
                CodeEventTypeCode.AdtAckMergePersonPatientId => "A39",
                CodeEventTypeCode.AdtAckMergePatientPatientIdList => "A40",
                CodeEventTypeCode.AdtAckMergeAccountPatientAccountNumber => "A41",
                CodeEventTypeCode.AdtAckMergeVisitVisitNumber => "A42",
                CodeEventTypeCode.AdtAckMovePatientInfoPatientIdList => "A43",
                CodeEventTypeCode.AdtAckMoveAccountInfoPatientAccountNumber => "A44",
                CodeEventTypeCode.AdtAckMoveVisitInfoVisitNumber => "A45",
                CodeEventTypeCode.AdtAckChangePatientId => "A46",
                CodeEventTypeCode.AdtAckChangePatientIdList => "A47",
                CodeEventTypeCode.AdtAckChangeAlternatePatientId => "A48",
                CodeEventTypeCode.AdtAckChangePatientAccountNumber => "A49",
                CodeEventTypeCode.AdtAckChangeVisitNumber => "A50",
                CodeEventTypeCode.AdtAckChangeAlternateVisitId => "A51",
                CodeEventTypeCode.AdtAckCancelLeaveOfAbsenceForAPatient => "A52",
                CodeEventTypeCode.AdtAckCancelPatientReturnsFromLoa => "A53",
                CodeEventTypeCode.AdtAckChangeAttendingDoctor => "A54",
                CodeEventTypeCode.AdtAckCancelChangeAttendingDoctor => "A55",
                CodeEventTypeCode.AdtAckUpdateAllergyInfo => "A60",
                CodeEventTypeCode.AdtAckChangeConsultingDoctor => "A61",
                CodeEventTypeCode.AdtAckCancelChangeConsultingDoctor => "A62",
                CodeEventTypeCode.PmuAckAddPersonnelRecord => "B01",
                CodeEventTypeCode.PmuAckUpdatePersonnelRecord => "B02",
                CodeEventTypeCode.PmuAckDeletePersonnelReCord => "B03",
                CodeEventTypeCode.PmuAckActivePracticingPerson => "B04",
                CodeEventTypeCode.PmuAckDeactivatePracticingPerson => "B05",
                CodeEventTypeCode.PmuAckTerminatePracticingPerson => "B06",
                CodeEventTypeCode.PmuAckGrantCertificatePermission => "B07",
                CodeEventTypeCode.PmuAckRevokeCertificatePermission => "B08",
                CodeEventTypeCode.CrmRegisterPatientOnClinicalTrial => "C01",
                CodeEventTypeCode.CrmCancelPatientRegistrationOnClinicalTrial => "C02",
                CodeEventTypeCode.CrmUpdateRegistrationInformation => "C03",
                CodeEventTypeCode.CrmPatientOffClinicalTrial => "C04",
                CodeEventTypeCode.CrmPatientEntersPhaseOfClinicalTrial => "C05",
                CodeEventTypeCode.CrmCancelPatientEnteringPhase => "C06",
                CodeEventTypeCode.CrmUpdatePhaseInfo => "C07",
                CodeEventTypeCode.CrmPatientHasGoneOffPhaseOfClinicalTrial => "C08",
                CodeEventTypeCode.CsuAutomatedTimeIntervalsForReporting => "C09",
                CodeEventTypeCode.CsuPatientCompletesClinicalTrial => "C10",
                CodeEventTypeCode.CsuPatientCompletesPhaseOfClinicalTrial => "C11",
                CodeEventTypeCode.CsuUpdatePatientOrderResultInfo => "C12",
                CodeEventTypeCode.CancelQuery => "CNQ",
                CodeEventTypeCode.SubmitHealthcareServicesInvoice => "E01",
                CodeEventTypeCode.CancelHealthcareServicesInvoice => "E02",
                CodeEventTypeCode.HealthcareServicesInvoiceStatus => "E03",
                CodeEventTypeCode.ReassessHealthcareServicesInvoiceRequest => "E04",
                CodeEventTypeCode.EditAdjudicationResults => "E10",
                CodeEventTypeCode.RequestAdditionalInformation => "E12",
                CodeEventTypeCode.AdditionalInformationResponse => "E13",
                CodeEventTypeCode.PaymentRemittanceAdvice => "E15",
                CodeEventTypeCode.SubmitAuthorizationRequest => "E20",
                CodeEventTypeCode.CancelAuthorizationRequest => "E21",
                CodeEventTypeCode.AuthorizationRequestStatus => "E22",
                CodeEventTypeCode.AuthorizationResponse => "E24",
                CodeEventTypeCode.SubmitHealthDocumentRelatedToAuthorizationRequest => "E30",
                CodeEventTypeCode.CancelHealthDocumentRelatedToAuthorizationRequest => "E31",
                CodeEventTypeCode.RqiRpiRequestForInsuranceInformation => "I01",
                CodeEventTypeCode.RqiRplRequestReceiptOfPatientSelectionDisplayList => "I02",
                CodeEventTypeCode.RqiRprRequestReceiptOfPatientSelectionList => "I03",
                CodeEventTypeCode.RqdRpiRequestForPatientDemographicData => "I04",
                CodeEventTypeCode.RqcRciRequestForPatientClinicalInformation => "I05",
                CodeEventTypeCode.RqcRclRequestReceiptOfClinicalDataListing => "I06",
                CodeEventTypeCode.PinAckUnsolicitedInsuranceInformation => "I07",
                CodeEventTypeCode.RqaRpaRequestForTreatmentAuthorizationInformation => "I08",
                CodeEventTypeCode.RqaRpaRequestForModificationToAuthorization => "I09",
                CodeEventTypeCode.RqaRpaRequestForResubmissionOfAuthorization => "I10",
                CodeEventTypeCode.RqaRpaRequestForCancellationOfAuthorization => "I11",
                CodeEventTypeCode.RefRriPatientReferral => "I12",
                CodeEventTypeCode.RefRriModifyPatientReferral => "I13",
                CodeEventTypeCode.RefRriCancelPatientReferral => "I14",
                CodeEventTypeCode.RefRriRequestPatientReferralStatus => "I15",
                CodeEventTypeCode.CollaborativeCareReferral => "I16",
                CodeEventTypeCode.ModifyCollaborativeCareReferral => "I17",
                CodeEventTypeCode.CancelCollaborativeCareReferral => "I18",
                CodeEventTypeCode.CollaborativeCareQuery => "I19",
                CodeEventTypeCode.AsynchronousCollaborativeCareUpdate => "I20",
                CodeEventTypeCode.CollaborativeCareMessage => "I21",
                CodeEventTypeCode.CollaborativeCareFetch => "I22",
                CodeEventTypeCode.QcnAckCancelQueryAcknowledgeMessage => "J01",
                CodeEventTypeCode.QsxAckCancelSubscriptionAcknowledgeMessage => "J02",
                CodeEventTypeCode.RspSegmentPatternResponseInResponseToQbpQ11 => "K11",
                CodeEventTypeCode.RtbTabularResponseInResponseToQbpQ13 => "K13",
                CodeEventTypeCode.RdyDisplayResponseInResponseToQbpQ15 => "K15",
                CodeEventTypeCode.RspGetPersonDemographicsResponse => "K21",
                CodeEventTypeCode.RspFindCandidatesResponse => "K22",
                CodeEventTypeCode.RspGetCorrespondingIdentifiersResponse => "K23",
                CodeEventTypeCode.RspAllocateIdentifiersResponse => "K24",
                CodeEventTypeCode.RspPersonnelInformationBySegmentResponse => "K25",
                CodeEventTypeCode.RspDispenseHistoryResponse => "K31",
                CodeEventTypeCode.FindCandidatesIncludingVisitInformationResponse => "K32",
                CodeEventTypeCode.MfnMfkMasterFileNotOtherwiseSpecified => "M01",
                CodeEventTypeCode.MfnMfkMasterFileStaffPractitioner => "M02",
                CodeEventTypeCode.MfnMfkMasterFileTestObservation => "M03",
                CodeEventTypeCode.MfnMfkMasterFilesChargeDescription => "M04",
                CodeEventTypeCode.MfnMfkPatientLocationMasterFile => "M05",
                CodeEventTypeCode.MfnMfkClinicalStudyWithPhasesAndSchedulesMasterFile => "M06",
                CodeEventTypeCode.MfnMfkClinicalStudyWithoutPhasesButWithSchedulesMasterFile => "M07",
                CodeEventTypeCode.MfnMfkTestObservationNumericMasterFile => "M08",
                CodeEventTypeCode.MfnMfkTestObservationCategoricalMasterFile => "M09",
                CodeEventTypeCode.MfnMfkTestObservationBatteriesMasterFile => "M10",
                CodeEventTypeCode.MfnMfkTestCalculatedObservationsMasterFile => "M11",
                CodeEventTypeCode.MfnMfkMasterFileNotificationMessage => "M12",
                CodeEventTypeCode.MfnMfkMasterFileNotificationGeneral => "M13",
                CodeEventTypeCode.MfnMfkMasterFileNotificationSiteDefined => "M14",
                CodeEventTypeCode.MfnMfkInventoryItemMasterFileNotification => "M15",
                CodeEventTypeCode.MfnMfkMasterFileNotificationInventoryItemEnhanced => "M16",
                CodeEventTypeCode.DrgMasterFileMessage => "M17",
                CodeEventTypeCode.NmqNmrApplicationManagementQueryMessage => "N01",
                CodeEventTypeCode.NmdAckApplicationManagementDataMessageUnsolicited => "N02",
                CodeEventTypeCode.OrmOrderMessage => "O01",
                CodeEventTypeCode.OrrOrderResponse => "O02",
                CodeEventTypeCode.OmdDietOrder => "O03",
                CodeEventTypeCode.OrdDietOrderAcknowledgment => "O04",
                CodeEventTypeCode.OmsStockRequisitionOrder => "O05",
                CodeEventTypeCode.OrsStockRequisitionAcknowledgment => "O06",
                CodeEventTypeCode.OmnNonStockRequisitionOrder => "O07",
                CodeEventTypeCode.OrnNonStockRequisitionAcknowledgment => "O08",
                CodeEventTypeCode.OmpPharmacyTreatmentOrder => "O09",
                CodeEventTypeCode.OrpPharmacyTreatmentOrderAcknowledgment => "O10",
                CodeEventTypeCode.RdePharmacyTreatmentEncodedOrder => "O11",
                CodeEventTypeCode.RrePharmacyTreatmentEncodedOrderAcknowledgment => "O12",
                CodeEventTypeCode.RdsPharmacyTreatmentDispense => "O13",
                CodeEventTypeCode.RrdPharmacyTreatmentDispenseAcknowledgment => "O14",
                CodeEventTypeCode.RgvPharmacyTreatmentGive => "O15",
                CodeEventTypeCode.RrgPharmacyTreatmentGiveAcknowledgment => "O16",
                CodeEventTypeCode.RasPharmacyTreatmentAdministration => "O17",
                CodeEventTypeCode.RraPharmacyTreatmentAdministrationAcknowledgment => "O18",
                CodeEventTypeCode.OmgGeneralClinicalOrder => "O19",
                CodeEventTypeCode.OrgOrlGeneralClinicalOrderResponse => "O20",
                CodeEventTypeCode.OmlLaboratoryOrder => "O21",
                CodeEventTypeCode.OrlGeneralLaboratoryOrderResponseMessageToAnyOml => "O22",
                CodeEventTypeCode.OmiImagingOrder => "O23",
                CodeEventTypeCode.OriImagingOrderResponseMessageToAnyOmi => "O24",
                CodeEventTypeCode.RdePharmacyTreatmentRefillAuthorizationRequest => "O25",
                CodeEventTypeCode.RrePharmacyTreatmentRefillAuthorizationAcknowledgement => "O26",
                CodeEventTypeCode.OmbBloodProductOrder => "O27",
                CodeEventTypeCode.OrbBloodProductOrderAcknowledgment => "O28",
                CodeEventTypeCode.BpsBloodProductDispenseStatus => "O29",
                CodeEventTypeCode.BrpBloodProductDispenseStatusAcknowledgment => "O30",
                CodeEventTypeCode.BtsBloodProductTransfusionDisposition => "O31",
                CodeEventTypeCode.BrtBloodProductTransfusionDispositionAcknowledgment => "O32",
                CodeEventTypeCode.OmlLabOrderForMultipleOrdersRelatedToASingleSpecimen => "O33",
                CodeEventTypeCode.OrlLabOrderResponseToMultipleOrderRelatedToSingleSpecimenOml => "O34",
                CodeEventTypeCode.OmlLabOrderForMultipleOrdersRelatedToSingleSpecimen => "O35",
                CodeEventTypeCode.OrlLabOrderResponseToSingleSpecimenOml => "O36",
                CodeEventTypeCode.OplPopulationLocationBasedLabOrder => "O37",
                CodeEventTypeCode.OprPopulationLocationBasedLabOrderAcknowledgment => "O38",
                CodeEventTypeCode.SpecimenShipmentCentricLabOrder => "O39",
                CodeEventTypeCode.SpecimenShipmentCentricLabOrderAcknowledgment => "O40",
                CodeEventTypeCode.BarAckAddPatientAccounts => "P01",
                CodeEventTypeCode.BarAckPurgePatientAccounts => "P02",
                CodeEventTypeCode.DftAckPostDetailFinancialTransaction => "P03",
                CodeEventTypeCode.QryDspGenerateBillAndARStatements => "P04",
                CodeEventTypeCode.BarAckUpdateAccount => "P05",
                CodeEventTypeCode.BarAckEndAccount => "P06",
                CodeEventTypeCode.PexUnsolicitedInitialExperienceReport => "P07",
                CodeEventTypeCode.PexUnsolicitedUpdateExperienceReport => "P08",
                CodeEventTypeCode.SurSummaryExperienceReport => "P09",
                CodeEventTypeCode.BarAckTransmitAmbulatoryPaymentClassificationApc => "P10",
                CodeEventTypeCode.DftAckPostDetailFinancialTransactionsNew => "P11",
                CodeEventTypeCode.BarAckUpdateDiagnosisProcedure => "P12",
                CodeEventTypeCode.PprPcProblemAdd => "PC1",
                CodeEventTypeCode.PprPcProblemUpdate => "PC2",
                CodeEventTypeCode.PprPcProblemDelete => "PC3",
                CodeEventTypeCode.QryPcProblemQuery => "PC4",
                CodeEventTypeCode.PrrPcProblemResponse => "PC5",
                CodeEventTypeCode.PglPcGoalAdd => "PC6",
                CodeEventTypeCode.PglPcGoalUpdate => "PC7",
                CodeEventTypeCode.PglPcGoalDelete => "PC8",
                CodeEventTypeCode.QryPcGoalQuery => "PC9",
                CodeEventTypeCode.PpvPcGoalResponse => "PCA",
                CodeEventTypeCode.PppPcPathwayProblemOrientedAdd => "PCB",
                CodeEventTypeCode.PppPcPathwayProblemOrientedUpdate => "PCC",
                CodeEventTypeCode.PppPcPathwayProblemOrientedDelete => "PCD",
                CodeEventTypeCode.QryPcPathwayProblemOrientedQuery => "PCE",
                CodeEventTypeCode.PtrPcPathwayProblemOrientedQueryResponse => "PCF",
                CodeEventTypeCode.PpgPcPathwayGoalOrientedAdd => "PCG",
                CodeEventTypeCode.PpgPcPathwayGoalOrientedUpdate => "PCH",
                CodeEventTypeCode.PpgPcPathwayGoalOrientedDelete => "PCJ",
                CodeEventTypeCode.QryPcPathwayGoalOrientedQuery => "PCK",
                CodeEventTypeCode.PptPcPathwayGoalOrientedQueryResponse => "PCL",
                CodeEventTypeCode.QryDsrQuerySentForImmediateResponse => "Q01",
                CodeEventTypeCode.QryQckQuerySentForDeferredResponse => "Q02",
                CodeEventTypeCode.DsrAckDeferredResponseToAQuery => "Q03",
                CodeEventTypeCode.UdmAckUnsolicitedDisplayUpdateMessage => "Q05",
                CodeEventTypeCode.OsqOsrQueryForOrderStatus => "Q06",
                CodeEventTypeCode.QbpQueryByParameterRequestingRspSegmentPatternResponse => "Q11",
                CodeEventTypeCode.QbpQueryByParameterRequestingRtbTabularResponse => "Q13",
                CodeEventTypeCode.QbpQueryByParameterRequestingRdyDisplayResponse => "Q15",
                CodeEventTypeCode.QsbCreateSubscription => "Q16",
                CodeEventTypeCode.QvrQueryForPreviousEvents => "Q17",
                CodeEventTypeCode.QbpGetPersonDemographics => "Q21",
                CodeEventTypeCode.QbpFindCandidates => "Q22",
                CodeEventTypeCode.QbpGetCorrespondingIdentifiers => "Q23",
                CodeEventTypeCode.QbpAllocateIdentifiers => "Q24",
                CodeEventTypeCode.QbpPersonnelInformationBySegmentQuery => "Q25",
                CodeEventTypeCode.RorPharmacyTreatmentOrderResponse => "Q26",
                CodeEventTypeCode.RarPharmacyTreatmentAdministrationInformation => "Q27",
                CodeEventTypeCode.RdrPharmacyTreatmentDispenseInformation => "Q28",
                CodeEventTypeCode.RerPharmacyTreatmentEncodedOrderInformation => "Q29",
                CodeEventTypeCode.RgrPharmacyTreatmentDoseInformation => "Q30",
                CodeEventTypeCode.QbpQueryDispenseHistory => "Q31",
                CodeEventTypeCode.FindCandidatesIncludingVisitInformation => "Q32",
                CodeEventTypeCode.OruAckUnsolicitedTransmissionOfObservation => "R01",
                CodeEventTypeCode.QryQueryForResultsOfObservation => "R02",
                CodeEventTypeCode.OrfResponseToQueryTransmissionOfRequestedObservation => "R04",
                CodeEventTypeCode.OulUnsolicitedLaboratoryObservation => "R21",
                CodeEventTypeCode.OulUnsolicitedSpecimenOrientedObservation => "R22",
                CodeEventTypeCode.OulUnsolicitedSpecimenContainerOrientedObservation => "R23",
                CodeEventTypeCode.OulUnsolicitedOrderOrientedObservation => "R24",
                CodeEventTypeCode.OpuUnsolicitedPopulationLocationBasedLabObservation => "R25",
                CodeEventTypeCode.OsmUnsolicitedSpecimenShipmentManifest => "R26",
                CodeEventTypeCode.OruUnsolicitedPointOfCareObservationWithoutExistingOrder => "R30",
                CodeEventTypeCode.OruUnsolicitedNewPointOfCareObservationSearchForOrder => "R31",
                CodeEventTypeCode.OruUnsolicitedPreOrderedPointOfCareObservation => "R32",
                CodeEventTypeCode.OraObservationReportAcknowledgement => "R33",
                CodeEventTypeCode.RorPharmacyPrescriptionOrderQueryResponse => "ROR",
                CodeEventTypeCode.SrmSrrRequestNewAppointmentBooking => "S01",
                CodeEventTypeCode.SrmSrrRequestAppointmentRescheduling => "S02",
                CodeEventTypeCode.SrmSrrRequestAppointmentModification => "S03",
                CodeEventTypeCode.SrmSrrRequestAppointmentCancellation => "S04",
                CodeEventTypeCode.SrmSrrRequestAppointmentDiscontinuation => "S05",
                CodeEventTypeCode.SrmSrrRequestAppointmentDeletion => "S06",
                CodeEventTypeCode.SrmSrrRequestAdditionOfServiceOnAppointment => "S07",
                CodeEventTypeCode.SrmSrrRequestModificationOfServiceOnAppointment => "S08",
                CodeEventTypeCode.SrmSrrRequestCancellationOfServiceOnAppointment => "S09",
                CodeEventTypeCode.SrmSrrRequestDiscontinuationOfServiceOnAppointment => "S10",
                CodeEventTypeCode.SrmSrrRequestDeletionOfServiceOnAppointment => "S11",
                CodeEventTypeCode.SiuAckNotifyNewAppointmentBooking => "S12",
                CodeEventTypeCode.SiuAckNotifyAppointmentRescheduling => "S13",
                CodeEventTypeCode.SiuAckNotifyAppointmentModification => "S14",
                CodeEventTypeCode.SiuAckNotifyAppointmentCancellation => "S15",
                CodeEventTypeCode.SiuAckNotificationOfAppointmentDiscontinuation => "S16",
                CodeEventTypeCode.SiuAckNotifyAppointmentDeletion => "S17",
                CodeEventTypeCode.SiuAckNotifyAdditionOfServiceOnAppointment => "S18",
                CodeEventTypeCode.SiuAckNotifyModificationOfServiceOnAppointment => "S19",
                CodeEventTypeCode.SiuAckNotifyCancellationOfServiceOnAppointment => "S20",
                CodeEventTypeCode.SiuAckNotifyDiscontinuationOfServiceOnAppointment => "S21",
                CodeEventTypeCode.SiuAckNotifyDeletionOfServiceResourceOnAppointment => "S22",
                CodeEventTypeCode.SiuAckNotifyBlockedScheduleTimeSlots => "S23",
                CodeEventTypeCode.SiuAckNotifyOpenedUnblockedScheduleTimeSlots => "S24",
                CodeEventTypeCode.SqmSqrScheduleQueryMessageAndResponse => "S25",
                CodeEventTypeCode.SiuAckNotifyPatientDidNotShowUpForAppointment => "S26",
                CodeEventTypeCode.SiuAckBroadcastScheduledAppointments => "S27",
                CodeEventTypeCode.SlrSlsRequestNewSterilizationLot => "S28",
                CodeEventTypeCode.SlrSlsRequestSterilizationLotDeletion => "S29",
                CodeEventTypeCode.StiStsRequestItem => "S30",
                CodeEventTypeCode.SdrSdsRequestAntiMicrobialDeviceData => "S31",
                CodeEventTypeCode.SmdSmsRequestAntiMicrobialDeviceCycleData => "S32",
                CodeEventTypeCode.StcAckNotifySterilizationConfiguration => "S33",
                CodeEventTypeCode.SlnAckNotifySterilizationLot => "S34",
                CodeEventTypeCode.SlnAckNotifySterilizationLotDeletion => "S35",
                CodeEventTypeCode.SdnAckNotifyAntiMicrobialDeviceData => "S36",
                CodeEventTypeCode.ScnAckNotifyAntiMicrobialDeviceCycleData => "S37",
                CodeEventTypeCode.MdmAckOriginalDocument => "T01",
                CodeEventTypeCode.MdmAckOriginalDocumentNotifyAndContent => "T02",
                CodeEventTypeCode.MdmAckDocumentStatusChange => "T03",
                CodeEventTypeCode.MdmAckDocumentStatusChangeNotifyAndContent => "T04",
                CodeEventTypeCode.MdmAckDocumentAddendum => "T05",
                CodeEventTypeCode.MdmAckDocumentAddendumNotifyAndContent => "T06",
                CodeEventTypeCode.MdmAckDocumentEdit => "T07",
                CodeEventTypeCode.MdmAckDocumentEditNotifyAndContent => "T08",
                CodeEventTypeCode.MdmAckDocumentReplacement => "T09",
                CodeEventTypeCode.MdmAckDocumentReplacementNotifyAndContent => "T10",
                CodeEventTypeCode.MdmAckDocumentCancel => "T11",
                CodeEventTypeCode.QryDocDocumentQuery => "T12",
                CodeEventTypeCode.EsuAckAutomatedEquipmentStatusUpdate => "U01",
                CodeEventTypeCode.EsrAckAutomatedEquipmentStatusRequest => "U02",
                CodeEventTypeCode.SsuAckSpecimenStatusUpdate => "U03",
                CodeEventTypeCode.SsrAckSpecimenStatusRequest => "U04",
                CodeEventTypeCode.InuAckAutomatedEquipmentInventoryUpdate => "U05",
                CodeEventTypeCode.InrAckAutomatedEquipmentInventoryRequest => "U06",
                CodeEventTypeCode.EacAckAutomatedEquipmentCommand => "U07",
                CodeEventTypeCode.EarAckAutomatedEquipmentResponse => "U08",
                CodeEventTypeCode.EanAckAutomatedEquipment => "U09",
                CodeEventTypeCode.TcuAckAutomatedEquipmentTestCodeSettingsUpdate => "U10",
                CodeEventTypeCode.TcrAckAutomatedEquipmentTestCodeSettingsRequest => "U11",
                CodeEventTypeCode.LsuAckAutomatedEquipmentLogServiceUpdate => "U12",
                CodeEventTypeCode.LsrAckAutomatedEquipmentLogServiceRequest => "U13",
                CodeEventTypeCode.VxqQueryForVaccinationRecord => "V01",
                CodeEventTypeCode.VxxResponseToVaccinationQueryMultiplePidMatches => "V02",
                CodeEventTypeCode.VxrVaccinationRecordResponse => "V03",
                CodeEventTypeCode.VxuUnsolicitedVaccinationRecordUpdate => "V04",
                CodeEventTypeCode.MfqMfrMasterFilesQuery => "Varies",
                CodeEventTypeCode.OruWaveformResultUnsolicitedTransmission => "W01",
                CodeEventTypeCode.QrfWaveformResultResponseToQuery => "W02",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventTypeCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeExpandedYesNoIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeExpandedYesNoIndicator input)
        {
            return input switch
            {
                CodeExpandedYesNoIndicator.AskedButUnknown => "ASKU",
                CodeExpandedYesNoIndicator.No => "N",
                CodeExpandedYesNoIndicator.NotApplicable => "NA",
                CodeExpandedYesNoIndicator.NotAsked => "NASK",
                CodeExpandedYesNoIndicator.TemporarilyUnavailable => "NAV",
                CodeExpandedYesNoIndicator.NoInformation => "NI",
                CodeExpandedYesNoIndicator.NotPresent => "NP",
                CodeExpandedYesNoIndicator.Unknown => "UNK",
                CodeExpandedYesNoIndicator.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeExpandedYesNoIndicator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeExtendedPriorityCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeExtendedPriorityCodes input)
        {
            return input switch
            {
                CodeExtendedPriorityCodes.Asap => "A",
                CodeExtendedPriorityCodes.Callback => "C",
                CodeExtendedPriorityCodes.Preop => "P",
                CodeExtendedPriorityCodes.AsNeeded => "PRN",
                CodeExtendedPriorityCodes.Routine => "R",
                CodeExtendedPriorityCodes.Stat => "S",
                CodeExtendedPriorityCodes.TimingCritical => "T",
                CodeExtendedPriorityCodes.TimingCriticalWithinIntegerDays => "TDinteger",
                CodeExtendedPriorityCodes.TimingCriticalWithinIntegerHours => "THinteger",
                CodeExtendedPriorityCodes.TimingCriticalWithinIntegerMonths => "TLinteger",
                CodeExtendedPriorityCodes.TimingCriticalWithinIntegerMinutes => "TMinteger",
                CodeExtendedPriorityCodes.TimingCriticalWithinIntegerSeconds => "TSinteger",
                CodeExtendedPriorityCodes.TimingCriticalWithinIntegerWeeks => "TWinteger",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeExtendedPriorityCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeFacilityType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeFacilityType input)
        {
            return input switch
            {
                CodeFacilityType.AgentForForeignManufacturer => "A",
                CodeFacilityType.Distributor => "D",
                CodeFacilityType.Manufacturer => "M",
                CodeFacilityType.User => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeFacilityType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeFileLevelEventCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeFileLevelEventCode input)
        {
            return input switch
            {
                CodeFileLevelEventCode.ReplaceCurrentVersionOfMasterFile => "REP",
                CodeFileLevelEventCode.ChangeFileRecordsAsDefined => "UPD",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeFileLevelEventCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeFillerStatusCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeFillerStatusCodes input)
        {
            return input switch
            {
                CodeFillerStatusCodes.Blocked => "Blocked",
                CodeFillerStatusCodes.Booked => "Booked",
                CodeFillerStatusCodes.Cancelled => "Cancelled",
                CodeFillerStatusCodes.Complete => "Complete",
                CodeFillerStatusCodes.Deleted => "Deleted",
                CodeFillerStatusCodes.Discontinued => "Discontinued",
                CodeFillerStatusCodes.Noshow => "Noshow",
                CodeFillerStatusCodes.Overbook => "Overbook",
                CodeFillerStatusCodes.Pending => "Pending",
                CodeFillerStatusCodes.Started => "Started",
                CodeFillerStatusCodes.Waitlist => "Waitlist",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeFillerStatusCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeFormularyStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeFormularyStatus input)
        {
            return input switch
            {
                CodeFormularyStatus.PharmaceuticalSubstanceIsInFormularyButGuidelinesApply => "G",
                CodeFormularyStatus.PharmaceuticalSubstanceIsNotInFormulary => "N",
                CodeFormularyStatus.PharmaceuticalSubstanceIsInFormularyButRestrictionsApply => "R",
                CodeFormularyStatus.PharmaceuticalSubstanceIsInFormulary => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeFormularyStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeGestationCategoryCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeGestationCategoryCode input)
        {
            return input switch
            {
                CodeGestationCategoryCode.PrematurePreTerm => "1",
                CodeGestationCategoryCode.FullTerm => "2",
                CodeGestationCategoryCode.OverduePostTerm => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeGestationCategoryCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeGovernmentReimbursementProgram enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeGovernmentReimbursementProgram input)
        {
            return input switch
            {
                CodeGovernmentReimbursementProgram.MediCal => "C",
                CodeGovernmentReimbursementProgram.Medicare => "MM",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeGovernmentReimbursementProgram input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeGrouperStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeGrouperStatus input)
        {
            return input switch
            {
                CodeGrouperStatus.NormalGrouping => "0",
                CodeGrouperStatus.InvalidOrMissingPrimaryDiagnosis => "1",
                CodeGrouperStatus.DiagnosisIsNotAllowedToBePrimary => "2",
                CodeGrouperStatus.DataDoesNotFulfillDrgCriteria => "3",
                CodeGrouperStatus.InvalidAgeAdmissionDateDateOfBirthOrDischargeDate => "4",
                CodeGrouperStatus.InvalidGender => "5",
                CodeGrouperStatus.InvalidDischargeStatus => "6",
                CodeGrouperStatus.InvalidWeightAdAdmission => "7",
                CodeGrouperStatus.InvalidLengthOfStay => "8",
                CodeGrouperStatus.InvalidFieldSameDay => "9",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeGrouperStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeHospitalService enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeHospitalService input)
        {
            return input switch
            {
                CodeHospitalService.CardiacService => "CAR",
                CodeHospitalService.MedicalService => "MED",
                CodeHospitalService.PulmonaryService => "PUL",
                CodeHospitalService.SurgicalService => "SUR",
                CodeHospitalService.UrologyService => "URO",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeHospitalService input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeIdentifierType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeIdentifierType input)
        {
            return input switch
            {
                CodeIdentifierType.AccessionId => "ACSN",
                CodeIdentifierType.AmericanExpress => "AM",
                CodeIdentifierType.AmericanMedicalAssociationNumber => "AMA",
                CodeIdentifierType.AccountNumber => "AN",
                CodeIdentifierType.AccountNumberCreditor => "ANC",
                CodeIdentifierType.AccountNumberDebitor => "AND",
                CodeIdentifierType.AnonymousIdentifier => "ANON",
                CodeIdentifierType.TemporaryAccountNumber => "ANT",
                CodeIdentifierType.AdvancedPracticeRegisteredNurseNumber => "APRN",
                CodeIdentifierType.AncestorSpecimenId => "ASID",
                CodeIdentifierType.BankAccountNumber => "BA",
                CodeIdentifierType.BankCardNumber => "BC",
                CodeIdentifierType.BirthCertificate => "BCT",
                CodeIdentifierType.BirthRegistryNumber => "BR",
                CodeIdentifierType.BreedRegistryNumber => "BRN",
                CodeIdentifierType.PrimaryPhysicianOfficeNumber => "BSNR",
                CodeIdentifierType.CostCenterNumber => "CC",
                CodeIdentifierType.ChangeOfNameDocument => "CONM",
                CodeIdentifierType.CountyNumber => "CY",
                CodeIdentifierType.CitizenshipCard => "CZ",
                CodeIdentifierType.DentistLicenseNumber => "DDS",
                CodeIdentifierType.DrugEnforceAdminRegistrationNumber => "DEA",
                CodeIdentifierType.DrugFurnishingOrPrescriptiveAuthorityNumber => "DFN",
                CodeIdentifierType.DinersClubCard => "DI",
                CodeIdentifierType.DriversLicenseNumber => "DL",
                CodeIdentifierType.DoctorNumber => "DN",
                CodeIdentifierType.OsteopathicLicenseNumber => "DO",
                CodeIdentifierType.DiplomaticPassport => "DP",
                CodeIdentifierType.PodiatristLicenseNumber => "DPM",
                CodeIdentifierType.DonorRegistrationNumber => "DR",
                CodeIdentifierType.DiscoverCard => "DS",
                CodeIdentifierType.EmployeeNumber => "EI",
                CodeIdentifierType.EmployerNumber => "EN",
                CodeIdentifierType.StaffEnterpriseNumber => "ESN",
                CodeIdentifierType.FacilityId => "FI",
                CodeIdentifierType.GuarantorInternalIdentifier => "GI",
                CodeIdentifierType.GeneralLedgerNumber => "GL",
                CodeIdentifierType.GuarantorExternalIdentifier => "GN",
                CodeIdentifierType.HealthCardNumber => "HC",
                CodeIdentifierType.IndigenousAboriginal => "IND",
                CodeIdentifierType.JurisdictionalHealthNumberCanada => "JHN",
                CodeIdentifierType.LaboratoryAccessionId => "LACSN",
                CodeIdentifierType.LifelongPhysicianNumber => "LANR",
                CodeIdentifierType.LaborAndIndustriesNumber => "LI",
                CodeIdentifierType.LicenseNumber => "LN",
                CodeIdentifierType.LocalRegistryId => "LR",
                CodeIdentifierType.PatientMedicaidNumber => "MA",
                CodeIdentifierType.MemberNumber => "MB",
                CodeIdentifierType.PatientsMedicareNumber => "MC",
                CodeIdentifierType.PractitionerMedicaidNumber => "MCD",
                CodeIdentifierType.MicrochipNumber => "MCN",
                CodeIdentifierType.PractitionerMedicareNumber => "MCR",
                CodeIdentifierType.MarriageCertificate => "MCT",
                CodeIdentifierType.MedicalLicenseNumber => "MD",
                CodeIdentifierType.MilitaryIdNumber => "MI",
                CodeIdentifierType.MedicalRecordNumber => "MR",
                CodeIdentifierType.TemporaryMedicalRecordNumber => "MRT",
                CodeIdentifierType.Mastercard => "MS",
                CodeIdentifierType.SecondaryPhysicianOfficeNumber => "NBSNR",
                CodeIdentifierType.NaturalizationCertificate => "NCT",
                CodeIdentifierType.NationalEmployerId => "NE",
                CodeIdentifierType.NationalHealthPlanId => "NH",
                CodeIdentifierType.NationalUniqueIndividualId => "NI",
                CodeIdentifierType.NationalInsuranceOrganizationId => "NII",
                CodeIdentifierType.NationalInsurancePayorId => "NIIP",
                CodeIdentifierType.NationalPersonIdentifier => "NNxxx",
                CodeIdentifierType.NursePractitionerNumber => "NP",
                CodeIdentifierType.NationalProviderIdentifier => "NPI",
                CodeIdentifierType.OptometristLicenseNumber => "OD",
                CodeIdentifierType.PhysicianAssistantNumber => "PA",
                CodeIdentifierType.ParoleCard => "PC",
                CodeIdentifierType.PenitentiaryCorrectionalInstitutionNumber => "PCN",
                CodeIdentifierType.LivingSubjectEnterpriseNumber => "PE",
                CodeIdentifierType.PensionNumber => "PEN",
                CodeIdentifierType.PatientInternalIdentifier => "PI",
                CodeIdentifierType.PersonNumber => "PN",
                CodeIdentifierType.TemporaryLivingSubjectNumber => "PNT",
                CodeIdentifierType.MedicareCmsPerformingProviderIdNumber => "PPIN",
                CodeIdentifierType.PassportNumber => "PPN",
                CodeIdentifierType.PermanentResidentCardNumber => "PRC",
                CodeIdentifierType.ProviderNumber => "PRN",
                CodeIdentifierType.PatientExternalIdentifier => "PT",
                CodeIdentifierType.QaNumber => "QA",
                CodeIdentifierType.ResourceIdentifier => "RI",
                CodeIdentifierType.RegisteredNurseNumber => "RN",
                CodeIdentifierType.PharmacistLicenseNumber => "RPH",
                CodeIdentifierType.RailroadRetirementNumber => "RR",
                CodeIdentifierType.RegionalRegistryId => "RRI",
                CodeIdentifierType.RailroadRetirementProvider => "RRP",
                CodeIdentifierType.SpecimenId => "SID",
                CodeIdentifierType.StateLicense => "SL",
                CodeIdentifierType.SubscriberNumber => "SN",
                CodeIdentifierType.StudyPermit => "SP",
                CodeIdentifierType.StateRegistryId => "SR",
                CodeIdentifierType.SocialSecurityNumber => "SS",
                CodeIdentifierType.TaxIdNumber => "TAX",
                CodeIdentifierType.TreatyNumberCanada => "TN",
                CodeIdentifierType.TemporaryPermanentResidentCanada => "TPR",
                CodeIdentifierType.UnspecifiedIdentifier => "U",
                CodeIdentifierType.MedicareCmsUniversalPhysicianId => "UPIN",
                CodeIdentifierType.UniqueSpecimenId => "USID",
                CodeIdentifierType.VisitNumber => "VN",
                CodeIdentifierType.VisitorPermit => "VP",
                CodeIdentifierType.Visa => "VS",
                CodeIdentifierType.WicIdentifier => "WC",
                CodeIdentifierType.WorkersCompNumber => "WCN",
                CodeIdentifierType.WorkPermit => "WP",
                CodeIdentifierType.OrganizationIdentifier => "XX",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeIdentifierType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeIdentityMayBeDivulged enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeIdentityMayBeDivulged input)
        {
            return input switch
            {
                CodeIdentityMayBeDivulged.No => "N",
                CodeIdentityMayBeDivulged.NotApplicable => "NA",
                CodeIdentityMayBeDivulged.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeIdentityMayBeDivulged input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeIdentityReliabilityCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeIdentityReliabilityCode input)
        {
            return input switch
            {
                CodeIdentityReliabilityCode.PatientPersonNameIsAnAlias => "AL",
                CodeIdentityReliabilityCode.UnknownDefaultAddress => "UA",
                CodeIdentityReliabilityCode.UnknownDefaultDateOfBirth => "UD",
                CodeIdentityReliabilityCode.UnknownDefaultSocialSecurityNumber => "US",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeIdentityReliabilityCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeImmunizationRegistryStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeImmunizationRegistryStatus input)
        {
            return input switch
            {
                CodeImmunizationRegistryStatus.Active => "A",
                CodeImmunizationRegistryStatus.Inactive => "I",
                CodeImmunizationRegistryStatus.InactiveLostToFollowUp => "L",
                CodeImmunizationRegistryStatus.InactiveMovedOrGoneElsewhere => "M",
                CodeImmunizationRegistryStatus.Other => "O",
                CodeImmunizationRegistryStatus.InactivePermanently => "P",
                CodeImmunizationRegistryStatus.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeImmunizationRegistryStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInactiveReasonCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInactiveReasonCode input)
        {
            return input switch
            {
                CodeInactiveReasonCode.LeaveOfAbsence => "L",
                CodeInactiveReasonCode.Retired => "R",
                CodeInactiveReasonCode.Termination => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInactiveReasonCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeIncidentTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeIncidentTypeCode input)
        {
            return input switch
            {
                CodeIncidentTypeCode.Other => "O",
                CodeIncidentTypeCode.Preventable => "P",
                CodeIncidentTypeCode.UserError => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeIncidentTypeCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeIndirectExposureMechanism enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeIndirectExposureMechanism input)
        {
            return input switch
            {
                CodeIndirectExposureMechanism.BreastMilk => "B",
                CodeIndirectExposureMechanism.Father => "F",
                CodeIndirectExposureMechanism.Other => "O",
                CodeIndirectExposureMechanism.Transplacental => "P",
                CodeIndirectExposureMechanism.BloodProduct => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeIndirectExposureMechanism input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInformPersonCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInformPersonCode input)
        {
            return input switch
            {
                CodeInformPersonCode.InformHelpDesk => "HD",
                CodeInformPersonCode.DoNotInformPatient => "NPAT",
                CodeInformPersonCode.InformPatient => "PAT",
                CodeInformPersonCode.InformUser => "USR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInformPersonCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInstitutionRelationshipType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInstitutionRelationshipType input)
        {
            return input switch
            {
                CodeInstitutionRelationshipType.Contractor => "CON",
                CodeInstitutionRelationshipType.Consultant => "CST",
                CodeInstitutionRelationshipType.Employee => "EMP",
                CodeInstitutionRelationshipType.Volunteer => "VOL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInstitutionRelationshipType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInsuranceCompanyContactReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInsuranceCompanyContactReason input)
        {
            return input switch
            {
                CodeInsuranceCompanyContactReason.MedicareClaimStatus => "01",
                CodeInsuranceCompanyContactReason.MedicaidClaimStatus => "02",
                CodeInsuranceCompanyContactReason.NameAddressChange => "03",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInsuranceCompanyContactReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInterpretationCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInterpretationCodes input)
        {
            return input switch
            {
                CodeInterpretationCodes.OffScaleLow => "",
                CodeInterpretationCodes.OffScaleHigh => "",
                CodeInterpretationCodes.Abnormal => "A",
                CodeInterpretationCodes.CriticallyAbnormal => "AA",
                CodeInterpretationCodes.AntiComplementarySubstancesPresent => "AC",
                CodeInterpretationCodes.Better => "B",
                CodeInterpretationCodes.SignificantChangeDown => "D",
                CodeInterpretationCodes.Detected => "DET",
                CodeInterpretationCodes.High => "H",
                CodeInterpretationCodes.CriticallyHigh => "HH",
                CodeInterpretationCodes.Intermediate => "I",
                CodeInterpretationCodes.Indeterminate => "IND",
                CodeInterpretationCodes.Low => "L",
                CodeInterpretationCodes.CriticallyLow => "LL",
                CodeInterpretationCodes.ModeratelySusceptible => "MS",
                CodeInterpretationCodes.Normal => "N",
                CodeInterpretationCodes.NotDetected => "ND",
                CodeInterpretationCodes.Negative => "NEG",
                CodeInterpretationCodes.NonReactive => "NR",
                CodeInterpretationCodes.NoRangeDefinedOrNormalRangesDontApply => "null",
                CodeInterpretationCodes.Positive => "POS",
                CodeInterpretationCodes.QualityControlFailure => "QCF",
                CodeInterpretationCodes.Resistant => "R",
                CodeInterpretationCodes.Reactive => "RR",
                CodeInterpretationCodes.Susceptible => "S",
                CodeInterpretationCodes.CytotoxicSubstancePresent => "TOX",
                CodeInterpretationCodes.SignificantChangeUp => "U",
                CodeInterpretationCodes.VerySusceptible => "VS",
                CodeInterpretationCodes.Worse => "W",
                CodeInterpretationCodes.WeaklyReactive => "WR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInterpretationCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInvocationEvent enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInvocationEvent input)
        {
            return input switch
            {
                CodeInvocationEvent.OnDischarge => "D",
                CodeInvocationEvent.OnReceiptOfOrder => "O",
                CodeInvocationEvent.AtTimeServiceIsCompleted => "R",
                CodeInvocationEvent.AtTimeServiceIsStarted => "S",
                CodeInvocationEvent.AtDesignatedDateTime => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInvocationEvent input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInvoiceControlCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInvoiceControlCode input)
        {
            return input switch
            {
                CodeInvoiceControlCode.AuthorizationRequestForAdmission => "AA",
                CodeInvoiceControlCode.CombinedAuthorizationAndAdjudicationRequest => "AI",
                CodeInvoiceControlCode.CancelAuthorizationRequest => "CA",
                CodeInvoiceControlCode.CancelInvoiceProductServiceGroup => "CG",
                CodeInvoiceControlCode.CancelInvoiceProductServiceLineItem => "CL",
                CodeInvoiceControlCode.CancelInvoice => "CN",
                CodeInvoiceControlCode.CopyOfInvoice => "CP",
                CodeInvoiceControlCode.CoverageRegisterQuery => "CQ",
                CodeInvoiceControlCode.AuthorizationRequestForInpatientStayExtension => "EA",
                CodeInvoiceControlCode.OriginalAuthorization => "OA",
                CodeInvoiceControlCode.OriginalInvoice => "OR",
                CodeInvoiceControlCode.PreAuthorization => "PA",
                CodeInvoiceControlCode.PreDeterminationInvoice => "PD",
                CodeInvoiceControlCode.ReAssessment => "RA",
                CodeInvoiceControlCode.ReferralPreAuthorization => "RC",
                CodeInvoiceControlCode.ReferralAuthorization => "RU",
                CodeInvoiceControlCode.SpecialAuthorization => "SA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInvoiceControlCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInvoiceProcessingResultsStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInvoiceProcessingResultsStatus input)
        {
            return input switch
            {
                CodeInvoiceProcessingResultsStatus.Acknowledge => "ACK",
                CodeInvoiceProcessingResultsStatus.AdjudicatedWithAdjustments => "ADJ",
                CodeInvoiceProcessingResultsStatus.AdjudicatedAsSubmitted => "ADJSUB",
                CodeInvoiceProcessingResultsStatus.AdjudicatedToZero => "ADJZER",
                CodeInvoiceProcessingResultsStatus.Paid => "PAID",
                CodeInvoiceProcessingResultsStatus.Pending => "PEND",
                CodeInvoiceProcessingResultsStatus.PreDetermination => "PRED",
                CodeInvoiceProcessingResultsStatus.Reject => "REJECT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInvoiceProcessingResultsStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInvoiceReasonCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInvoiceReasonCodes input)
        {
            return input switch
            {
                CodeInvoiceReasonCodes.LateInvoice => "LATE",
                CodeInvoiceReasonCodes.NormalSubmission => "NORM",
                CodeInvoiceReasonCodes.SubscriberCoverageProblem => "SUB",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInvoiceReasonCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInvoiceType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInvoiceType input)
        {
            return input switch
            {
                CodeInvoiceType.Block => "BK",
                CodeInvoiceType.Final => "FN",
                CodeInvoiceType.FeeForService => "FS",
                CodeInvoiceType.Group => "GP",
                CodeInvoiceType.InformationOnly => "IN",
                CodeInvoiceType.NonPatient => "NP",
                CodeInvoiceType.Partial => "PA",
                CodeInvoiceType.Salary => "SL",
                CodeInvoiceType.BySession => "SS",
                CodeInvoiceType.Supplemental => "SU",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInvoiceType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeItemImportanceCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeItemImportanceCodes input)
        {
            return input switch
            {
                CodeItemImportanceCodes.Critical => "CRT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeItemImportanceCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeItemStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeItemStatus input)
        {
            return input switch
            {
                CodeItemStatus.Active => "A",
                CodeItemStatus.Inactive => "I",
                CodeItemStatus.PendingInactive => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeItemStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeItemStatusCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeItemStatusCodes input)
        {
            return input switch
            {
                CodeItemStatusCodes.Active => "1",
                CodeItemStatusCodes.PendingInactive => "2",
                CodeItemStatusCodes.Inactive => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeItemStatusCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeItemType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeItemType input)
        {
            return input switch
            {
                CodeItemType.Equipment => "EQP",
                CodeItemType.Implant => "IMP",
                CodeItemType.Medication => "MED",
                CodeItemType.Supply => "SUP",
                CodeItemType.TubesDrainsAndCatheters => "TDC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeItemType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeJobStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeJobStatus input)
        {
            return input switch
            {
                CodeJobStatus.Other => "O",
                CodeJobStatus.Permanent => "P",
                CodeJobStatus.Temporary => "T",
                CodeJobStatus.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeJobStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeJurisdictionalBreadth enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeJurisdictionalBreadth input)
        {
            return input switch
            {
                CodeJurisdictionalBreadth.CountyParish => "C",
                CodeJurisdictionalBreadth.Country => "N",
                CodeJurisdictionalBreadth.StateProvince => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeJurisdictionalBreadth input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeKindOfQuantity enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeKindOfQuantity input)
        {
            return input switch
            {
                CodeKindOfQuantity.Absorbance => "ABS",
                CodeKindOfQuantity.ConcentrationArbitrarySubstance => "ACNC",
                CodeKindOfQuantity.Activity => "ACT",
                CodeKindOfQuantity.Appearance => "APER",
                CodeKindOfQuantity.Arbitrary => "ARB",
                CodeKindOfQuantity.Area => "AREA",
                CodeKindOfQuantity.Aspect => "ASPECT",
                CodeKindOfQuantity.CatalyticActivity => "CACT",
                CodeKindOfQuantity.CatalyticContent => "CCNT",
                CodeKindOfQuantity.CatalyticConcentrationRatio => "CCRTO",
                CodeKindOfQuantity.CatalyticFraction => "CFR",
                CodeKindOfQuantity.Class => "CLAS",
                CodeKindOfQuantity.CatalyticConcentration => "CNC",
                CodeKindOfQuantity.Constant => "CNST",
                CodeKindOfQuantity.Coefficient => "COEF",
                CodeKindOfQuantity.Color => "COLOR",
                CodeKindOfQuantity.Consistency => "CONS",
                CodeKindOfQuantity.CatalyticRate => "CRAT",
                CodeKindOfQuantity.CatalyticRatio => "CRTO",
                CodeKindOfQuantity.Density => "DEN",
                CodeKindOfQuantity.Device => "DEV",
                CodeKindOfQuantity.Difference => "DIFF",
                CodeKindOfQuantity.Elasticity => "ELAS",
                CodeKindOfQuantity.ElectricalPotential => "ELPOT",
                CodeKindOfQuantity.ElectricalCurrent => "ELRAT",
                CodeKindOfQuantity.ElectricalResistance => "ELRES",
                CodeKindOfQuantity.Energy => "ENGR",
                CodeKindOfQuantity.Entitic => "ENT",
                CodeKindOfQuantity.EntiticCatalyticActivity => "ENTCAT",
                CodeKindOfQuantity.EntiticNumber => "ENTNUM",
                CodeKindOfQuantity.EntiticSubstanceOfAmount => "ENTSUB",
                CodeKindOfQuantity.EntiticVolume => "ENTVOL",
                CodeKindOfQuantity.Equilibrium => "EQL",
                CodeKindOfQuantity.MechanicalForce => "FORCE",
                CodeKindOfQuantity.Frequency => "FREQ",
                CodeKindOfQuantity.ImpressionInterpretationOfStudy => "IMP",
                CodeKindOfQuantity.KinematicViscosity => "KINV",
                CodeKindOfQuantity.Length => "LEN",
                CodeKindOfQuantity.LengthIncrement => "LINC",
                CodeKindOfQuantity.Liquefaction => "LIQ",
                CodeKindOfQuantity.Mass => "MASS",
                CodeKindOfQuantity.MassConcentration => "MCNC",
                CodeKindOfQuantity.MassContent => "MCNT",
                CodeKindOfQuantity.MassConcentrationRatio => "MCRTO",
                CodeKindOfQuantity.MassFraction => "MFR",
                CodeKindOfQuantity.MagneticFlux => "MGFLUX",
                CodeKindOfQuantity.MassIncrement => "MINC",
                CodeKindOfQuantity.Morphology => "MORPH",
                CodeKindOfQuantity.Motility => "MOTIL",
                CodeKindOfQuantity.MassRate => "MRAT",
                CodeKindOfQuantity.MassRatio => "MRTO",
                CodeKindOfQuantity.NumberConcentration => "NCNC",
                CodeKindOfQuantity.NumberContent => "NCNT",
                CodeKindOfQuantity.NumberFraction => "NFR",
                CodeKindOfQuantity.NumberRatio => "NRTO",
                CodeKindOfQuantity.Number => "NUM",
                CodeKindOfQuantity.OpticalDensity => "OD",
                CodeKindOfQuantity.Osmolality => "OSMOL",
                CodeKindOfQuantity.Pressure => "PRES",
                CodeKindOfQuantity.PresenceIdentityExistence => "PRID",
                CodeKindOfQuantity.PowerWattage => "PWR",
                CodeKindOfQuantity.Ranges => "RANGE",
                CodeKindOfQuantity.Ratios => "RATIO",
                CodeKindOfQuantity.ReciprocalRelativeTime => "RCRLTM",
                CodeKindOfQuantity.RelativeDensity => "RDEN",
                CodeKindOfQuantity.Relative => "REL",
                CodeKindOfQuantity.RelativeMassConcentration => "RLMCNC",
                CodeKindOfQuantity.RelativeSubstanceConcentration => "RLSCNC",
                CodeKindOfQuantity.RelativeTime => "RLTM",
                CodeKindOfQuantity.SaturationFraction => "SATFR",
                CodeKindOfQuantity.SubstanceConcentration => "SCNC",
                CodeKindOfQuantity.SubstanceConcentrationIncrement => "SCNCIN",
                CodeKindOfQuantity.SubstanceContent => "SCNT",
                CodeKindOfQuantity.SubstanceContentRate => "SCNTR",
                CodeKindOfQuantity.SubstanceConcentrationRatio => "SCRTO",
                CodeKindOfQuantity.SubstanceFraction => "SFR",
                CodeKindOfQuantity.Shape => "SHAPE",
                CodeKindOfQuantity.Smell => "SMELL",
                CodeKindOfQuantity.SubstanceRate => "SRAT",
                CodeKindOfQuantity.SubstanceRatio => "SRTO",
                CodeKindOfQuantity.SubstanceAmount => "SUB",
                CodeKindOfQuantity.Susceptibility => "SUSC",
                CodeKindOfQuantity.Taste => "TASTE",
                CodeKindOfQuantity.Temperature => "TEMP",
                CodeKindOfQuantity.TemperatureDifference => "TEMPDF",
                CodeKindOfQuantity.TemperatureIncrement => "TEMPIN",
                CodeKindOfQuantity.ThresholdMassConcentration => "THRMCNC",
                CodeKindOfQuantity.ThresholdSubstanceConcentration => "THRSCNC",
                CodeKindOfQuantity.Time => "TIME",
                CodeKindOfQuantity.DilutionFactor => "TITR",
                CodeKindOfQuantity.TimeDifference => "TMDF",
                CodeKindOfQuantity.TimeStampDateAndTime => "TMSTP",
                CodeKindOfQuantity.TimeRatio => "TRTO",
                CodeKindOfQuantity.Type => "TYPE",
                CodeKindOfQuantity.VolumeContent => "VCNT",
                CodeKindOfQuantity.Velocity => "VEL",
                CodeKindOfQuantity.VelocityRatio => "VELRT",
                CodeKindOfQuantity.VolumeFraction => "VFR",
                CodeKindOfQuantity.Viscosity => "VISC",
                CodeKindOfQuantity.Volume => "VOL",
                CodeKindOfQuantity.VolumeRate => "VRAT",
                CodeKindOfQuantity.VolumeRatio => "VRTO",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeKindOfQuantity input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLaborCalculationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLaborCalculationType input)
        {
            return input switch
            {
                CodeLaborCalculationType.Cost => "CST",
                CodeLaborCalculationType.Time => "TME",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLaborCalculationType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLanguageAbility enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLanguageAbility input)
        {
            return input switch
            {
                CodeLanguageAbility.Read => "1",
                CodeLanguageAbility.Write => "2",
                CodeLanguageAbility.Speak => "3",
                CodeLanguageAbility.Understand => "4",
                CodeLanguageAbility.Sign => "5",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLanguageAbility input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLanguageProficiency enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLanguageProficiency input)
        {
            return input switch
            {
                CodeLanguageProficiency.Excellent => "1",
                CodeLanguageProficiency.Good => "2",
                CodeLanguageProficiency.Fair => "3",
                CodeLanguageProficiency.Poor => "4",
                CodeLanguageProficiency.SomeLevelUnknown => "5",
                CodeLanguageProficiency.None => "6",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLanguageProficiency input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLevelOfCare enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLevelOfCare input)
        {
            return input switch
            {
                CodeLevelOfCare.Ambulatory => "A",
                CodeLevelOfCare.CriticalCare => "C",
                CodeLevelOfCare.Emergency => "E",
                CodeLevelOfCare.Isolation => "F",
                CodeLevelOfCare.IntensiveCare => "N",
                CodeLevelOfCare.Routine => "R",
                CodeLevelOfCare.Surgery => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLevelOfCare input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLivingArrangement enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLivingArrangement input)
        {
            return input switch
            {
                CodeLivingArrangement.Alone => "A",
                CodeLivingArrangement.Family => "F",
                CodeLivingArrangement.Institution => "I",
                CodeLivingArrangement.Relative => "R",
                CodeLivingArrangement.SpouseOnly => "S",
                CodeLivingArrangement.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLivingArrangement input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLivingDependency enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLivingDependency input)
        {
            return input switch
            {
                CodeLivingDependency.SmallChildrenDependent => "C",
                CodeLivingDependency.MedicalSupervisionRequired => "M",
                CodeLivingDependency.Other => "O",
                CodeLivingDependency.SpouseDependent => "S",
                CodeLivingDependency.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLivingDependency input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLivingWillCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLivingWillCode input)
        {
            return input switch
            {
                CodeLivingWillCode.YesPatientHasLivingWillButNotOnFile => "F",
                CodeLivingWillCode.NoPatientDoesNotHaveLivingWillButInfoWasProvided => "I",
                CodeLivingWillCode.NoPatientDoesNotHaveLivingWillAndNoInfoWasProvided => "N",
                CodeLivingWillCode.Unknown => "U",
                CodeLivingWillCode.YesPatientHasLivingWill => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLivingWillCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLoadStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLoadStatus input)
        {
            return input switch
            {
                CodeLoadStatus.LoadIsComplete => "LCC",
                CodeLoadStatus.LoadCanceled => "LCN",
                CodeLoadStatus.LoadInProcess => "LCP",
                CodeLoadStatus.BuildingALoad => "LLD",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLoadStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLocalRemoteControlState enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLocalRemoteControlState input)
        {
            return input switch
            {
                CodeLocalRemoteControlState.NullNoStateChangeADeprecated => "...",
                CodeLocalRemoteControlState.Local => "L",
                CodeLocalRemoteControlState.Remote => "R",
                CodeLocalRemoteControlState.NullNoStateChangeBDeprecated => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLocalRemoteControlState input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLocationCharacteristicId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLocationCharacteristicId input)
        {
            return input switch
            {
                CodeLocationCharacteristicId.GenderOfPatientS => "GEN",
                CodeLocationCharacteristicId.Implant => "IMP",
                CodeLocationCharacteristicId.InfectiousDisease => "INF",
                CodeLocationCharacteristicId.LevelOfCare => "LCR",
                CodeLocationCharacteristicId.Licensed => "LIC",
                CodeLocationCharacteristicId.Overflow => "OVR",
                CodeLocationCharacteristicId.PrivacyLevel => "PRL",
                CodeLocationCharacteristicId.BedIsSetUp => "SET",
                CodeLocationCharacteristicId.Shadow => "SHA",
                CodeLocationCharacteristicId.Smoking => "SMK",
                CodeLocationCharacteristicId.BedIsStaffed => "STF",
                CodeLocationCharacteristicId.TeachingLocation => "TEA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLocationCharacteristicId input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLocationEquipment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLocationEquipment input)
        {
            return input switch
            {
                CodeLocationEquipment.ElectroEncephalogram => "EEG",
                CodeLocationEquipment.ElectroCardiogram => "EKG",
                CodeLocationEquipment.InfusionPump => "INF",
                CodeLocationEquipment.IvPump => "IVP",
                CodeLocationEquipment.Oxygen => "OXY",
                CodeLocationEquipment.Suction => "SUC",
                CodeLocationEquipment.Ventilator => "VEN",
                CodeLocationEquipment.VitalSignsMonitor => "VIT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLocationEquipment input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLocationRelationshipId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLocationRelationshipId input)
        {
            return input switch
            {
                CodeLocationRelationshipId.LocationAliasEs => "ALI",
                CodeLocationRelationshipId.NearestDietaryLocation => "DTY",
                CodeLocationRelationshipId.NearestLab => "LAB",
                CodeLocationRelationshipId.SecondNearestLab => "LB2",
                CodeLocationRelationshipId.ParentLocation => "PAR",
                CodeLocationRelationshipId.NearestPharmacy => "RX",
                CodeLocationRelationshipId.SecondNearestPharmacy => "RX2",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLocationRelationshipId input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLocationServiceCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLocationServiceCode input)
        {
            return input switch
            {
                CodeLocationServiceCode.Diagnostic => "D",
                CodeLocationServiceCode.EmergencyRoomCasualty => "E",
                CodeLocationServiceCode.PrimaryCare => "P",
                CodeLocationServiceCode.Therapeutic => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLocationServiceCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLotControl enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLotControl input)
        {
            return input switch
            {
                CodeLotControl.OrModeWithoutOperator => "1",
                CodeLotControl.OrModeWithOperator => "2",
                CodeLotControl.CpdModeWithoutOperator => "3",
                CodeLotControl.CpdModeWithOperator => "4",
                CodeLotControl.OfflineMode => "5",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLotControl input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMailClaimParty enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMailClaimParty input)
        {
            return input switch
            {
                CodeMailClaimParty.Employer => "E",
                CodeMailClaimParty.Guarantor => "G",
                CodeMailClaimParty.InsuranceCompany => "I",
                CodeMailClaimParty.Other => "O",
                CodeMailClaimParty.Patient => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMailClaimParty input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeManufacturersOfVaccines enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeManufacturersOfVaccines input)
        {
            return input switch
            {
                CodeManufacturersOfVaccines.AbbottLaboratories => "AB",
                CodeManufacturersOfVaccines.AdamsLaboratoriesInc => "AD",
                CodeManufacturersOfVaccines.AlphaTherapeuticCorporation => "ALP",
                CodeManufacturersOfVaccines.Armour => "AR",
                CodeManufacturersOfVaccines.AventisBehringLLC => "AVB",
                CodeManufacturersOfVaccines.Aviron => "AVI",
                CodeManufacturersOfVaccines.BaxterHealthcareCorporationDeprecated => "BA",
                CodeManufacturersOfVaccines.BaxterHealthcareCorporation => "BAH",
                CodeManufacturersOfVaccines.BayerCorporation => "BAY",
                CodeManufacturersOfVaccines.BernaProducts => "BP",
                CodeManufacturersOfVaccines.BernaProductsCorporation => "BPC",
                CodeManufacturersOfVaccines.CenteonLLC => "CEN",
                CodeManufacturersOfVaccines.ChironCorporation => "CHI",
                CodeManufacturersOfVaccines.CelltechMedevaPharmaceuticals => "CMP",
                CodeManufacturersOfVaccines.CangeneCorporation => "CNJ",
                CodeManufacturersOfVaccines.Connaught => "CON",
                CodeManufacturersOfVaccines.DynportVaccineCompanyLlc => "DVC",
                CodeManufacturersOfVaccines.EvansMedicalLimited => "EVN",
                CodeManufacturersOfVaccines.GeovaxLabsInc => "GEO",
                CodeManufacturersOfVaccines.GreerLaboratoriesInc => "GRE",
                CodeManufacturersOfVaccines.ImmunoInternationalAg => "IAG",
                CodeManufacturersOfVaccines.Merieux => "IM",
                CodeManufacturersOfVaccines.ImmunoUSInc => "IUS",
                CodeManufacturersOfVaccines.ResearchFoundationForMicrobialDiseasesOfOsaka => "JPN",
                CodeManufacturersOfVaccines.KoreaGreenCrossCorporation => "KGC",
                CodeManufacturersOfVaccines.Lederle => "LED",
                CodeManufacturersOfVaccines.MassachusettsPublicHealthBiologicLabs => "MA",
                CodeManufacturersOfVaccines.MassachusettsBiologicLabs => "MBL",
                CodeManufacturersOfVaccines.MedimmuneInc => "MED",
                CodeManufacturersOfVaccines.Miles => "MIL",
                CodeManufacturersOfVaccines.BioportCorporation => "MIP",
                CodeManufacturersOfVaccines.MerckCoInc => "MSD",
                CodeManufacturersOfVaccines.Nabi => "NAB",
                CodeManufacturersOfVaccines.NorthAmericanVaccineInc => "NAV",
                CodeManufacturersOfVaccines.NovartisPharmaceuticalCorporation => "NOV",
                CodeManufacturersOfVaccines.NovavaxInc => "NVX",
                CodeManufacturersOfVaccines.NewYorkBloodCenter => "NYB",
                CodeManufacturersOfVaccines.OrthoClinicalDiagnostics => "ORT",
                CodeManufacturersOfVaccines.OrganonTeknikaCorporation => "OTC",
                CodeManufacturersOfVaccines.OtherManufacturer => "OTH",
                CodeManufacturersOfVaccines.ParkedalePharmaceuticals => "PD",
                CodeManufacturersOfVaccines.SanofiPasteur => "PMC",
                CodeManufacturersOfVaccines.PraxisBiologics => "PRX",
                CodeManufacturersOfVaccines.PowderjectPharmaceuticals => "PWJ",
                CodeManufacturersOfVaccines.SclavoInc => "SCL",
                CodeManufacturersOfVaccines.SwissSerumAndVaccineInst => "SI",
                CodeManufacturersOfVaccines.Glaxosmithkline => "SKB",
                CodeManufacturersOfVaccines.SolvayPharmaceuticals => "SOL",
                CodeManufacturersOfVaccines.TalecrisBiotherapeutics => "TAL",
                CodeManufacturersOfVaccines.UnknownManufacturer => "UNK",
                CodeManufacturersOfVaccines.UsArmyMedicalResearchAndMaterialCommand => "USA",
                CodeManufacturersOfVaccines.Vaxgen => "VXG",
                CodeManufacturersOfVaccines.WyethAyerstDeprecated => "WA",
                CodeManufacturersOfVaccines.WyethAyerst => "WAL",
                CodeManufacturersOfVaccines.ZlbBehring => "ZLB",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeManufacturersOfVaccines input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMaritalStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMaritalStatus input)
        {
            return input switch
            {
                CodeMaritalStatus.Separated => "A",
                CodeMaritalStatus.Unmarried => "B",
                CodeMaritalStatus.CommonLaw => "C",
                CodeMaritalStatus.Divorced => "D",
                CodeMaritalStatus.LegallySeparated => "E",
                CodeMaritalStatus.LivingTogether => "G",
                CodeMaritalStatus.Interlocutory => "I",
                CodeMaritalStatus.Married => "M",
                CodeMaritalStatus.Annulled => "N",
                CodeMaritalStatus.Other => "O",
                CodeMaritalStatus.DomesticPartner => "P",
                CodeMaritalStatus.RegisteredDomesticPartner => "R",
                CodeMaritalStatus.Single => "S",
                CodeMaritalStatus.Unreported => "T",
                CodeMaritalStatus.Unknown => "U",
                CodeMaritalStatus.Widowed => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMaritalStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMarketingBasis enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMarketingBasis input)
        {
            return input switch
            {
                CodeMarketingBasis.Basis510KExempt => "510E",
                CodeMarketingBasis.Basis510K => "510K",
                CodeMarketingBasis.PostMarketingStudy522 => "522S",
                CodeMarketingBasis.PremarketingAuthorization => "PMA",
                CodeMarketingBasis.Preamendment => "PRE",
                CodeMarketingBasis.Transitional => "TXN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMarketingBasis input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMasterfileActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMasterfileActionCode input)
        {
            return input switch
            {
                CodeMasterfileActionCode.ReactivateDeactivatedRecord => "MAC",
                CodeMasterfileActionCode.AddRecordToMasterFile => "MAD",
                CodeMasterfileActionCode.Deactivate => "MDC",
                CodeMasterfileActionCode.DeleteRecordFromMasterFile => "MDL",
                CodeMasterfileActionCode.UpdateRecordForMasterFile => "MUP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMasterfileActionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMasterFileIdentifierCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMasterFileIdentifierCode input)
        {
            return input switch
            {
                CodeMasterFileIdentifierCode.ChargeDescriptionMasterFile => "CDM",
                CodeMasterFileIdentifierCode.ClinicMasterFile => "CLN",
                CodeMasterFileIdentifierCode.ClinicalStudyWithPhasesAndScheduledMasterFile => "CMA",
                CodeMasterFileIdentifierCode.ClinicalStudyWithoutPhasesButWithScheduledMasterFile => "CMB",
                CodeMasterFileIdentifierCode.InventoryMasterFile => "INV",
                CodeMasterFileIdentifierCode.LocationMasterFile => "LOC",
                CodeMasterFileIdentifierCode.NumericalObservationMasterFile => "OMA",
                CodeMasterFileIdentifierCode.CategoricalObservationMasterFile => "OMB",
                CodeMasterFileIdentifierCode.ObservationBatteriesMasterFile => "OMC",
                CodeMasterFileIdentifierCode.CalculatedObservationsMasterFile => "OMD",
                CodeMasterFileIdentifierCode.OtherObservationServiceItemMasterFile => "OME",
                CodeMasterFileIdentifierCode.PractitionerMasterFile => "PRA",
                CodeMasterFileIdentifierCode.StaffMasterFile => "STF",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMasterFileIdentifierCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMatchAlgorithms enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMatchAlgorithms input)
        {
            return input switch
            {
                CodeMatchAlgorithms.ProprietaryAlgorithmForLinksoftV201 => "LINKSOFT_2.01",
                CodeMatchAlgorithms.ProprietaryAlgorithmForMatchwareV12 => "MATCHWARE_1.2",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMatchAlgorithms input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMatchReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMatchReason input)
        {
            return input switch
            {
                CodeMatchReason.MatchOnDateOfBirth => "DB",
                CodeMatchReason.MatchOnNameAlphaMatch => "NA",
                CodeMatchReason.MatchOnNamePhoneticMatch => "NP",
                CodeMatchReason.MatchOnSocialSecurityNumber => "SS",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMatchReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMedicalRoleExecutingPhysician enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMedicalRoleExecutingPhysician input)
        {
            return input switch
            {
                CodeMedicalRoleExecutingPhysician.Employed => "E",
                CodeMedicalRoleExecutingPhysician.SelfEmployed => "SE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMedicalRoleExecutingPhysician input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMessageErrorConditionCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMessageErrorConditionCodes input)
        {
            return input switch
            {
                CodeMessageErrorConditionCodes.MessageAccepted => "0",
                CodeMessageErrorConditionCodes.SegmentSequenceError => "100",
                CodeMessageErrorConditionCodes.RequiredFieldMissing => "101",
                CodeMessageErrorConditionCodes.DataTypeError => "102",
                CodeMessageErrorConditionCodes.TableValueNotFound => "103",
                CodeMessageErrorConditionCodes.ValueTooLong => "104",
                CodeMessageErrorConditionCodes.UnsupportedMessageType => "200",
                CodeMessageErrorConditionCodes.UnsupportedEventCode => "201",
                CodeMessageErrorConditionCodes.UnsupportedProcessingId => "202",
                CodeMessageErrorConditionCodes.UnsupportedVersionId => "203",
                CodeMessageErrorConditionCodes.UnknownKeyIdentifier => "204",
                CodeMessageErrorConditionCodes.DuplicateKeyIdentifier => "205",
                CodeMessageErrorConditionCodes.ApplicationRecordLocked => "206",
                CodeMessageErrorConditionCodes.ApplicationError => "207",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMessageErrorConditionCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMessageStructure enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMessageStructure input)
        {
            return input switch
            {
                CodeMessageStructure.Varies => "ACK",
                CodeMessageStructure.AdrA19Deprecated => "ADR_A19",
                CodeMessageStructure.A01A04A08A13 => "ADT_A01",
                CodeMessageStructure.A02 => "ADT_A02",
                CodeMessageStructure.A03 => "ADT_A03",
                CodeMessageStructure.A05A14A28A31 => "ADT_A05",
                CodeMessageStructure.A06A07 => "ADT_A06",
                CodeMessageStructure.A09A10A11 => "ADT_A09",
                CodeMessageStructure.A12 => "ADT_A12",
                CodeMessageStructure.A15 => "ADT_A15",
                CodeMessageStructure.A16 => "ADT_A16",
                CodeMessageStructure.A17 => "ADT_A17",
                CodeMessageStructure.AdtA18Deprecated => "ADT_A18",
                CodeMessageStructure.A20 => "ADT_A20",
                CodeMessageStructure.A21A22A23A25A26A27A29A32A33 => "ADT_A21",
                CodeMessageStructure.A24 => "ADT_A24",
                CodeMessageStructure.AdtA30Deprecated => "ADT_A30",
                CodeMessageStructure.A37 => "ADT_A37",
                CodeMessageStructure.A38 => "ADT_A38",
                CodeMessageStructure.A39A40A41A42 => "ADT_A39",
                CodeMessageStructure.A43 => "ADT_A43",
                CodeMessageStructure.A44 => "ADT_A44",
                CodeMessageStructure.A45 => "ADT_A45",
                CodeMessageStructure.A50A51 => "ADT_A50",
                CodeMessageStructure.A52A53 => "ADT_A52",
                CodeMessageStructure.A54A55 => "ADT_A54",
                CodeMessageStructure.A60 => "ADT_A60",
                CodeMessageStructure.A61A62 => "ADT_A61",
                CodeMessageStructure.P01 => "BAR_P01",
                CodeMessageStructure.P02 => "BAR_P02",
                CodeMessageStructure.P05 => "BAR_P05",
                CodeMessageStructure.P06 => "BAR_P06",
                CodeMessageStructure.P10 => "BAR_P10",
                CodeMessageStructure.P12 => "BAR_P12",
                CodeMessageStructure.O29 => "BPS_O29",
                CodeMessageStructure.O30 => "BRP_O30",
                CodeMessageStructure.O32 => "BRT_O32",
                CodeMessageStructure.O31 => "BTS_O31",
                CodeMessageStructure.I22CCF => "CCF_I22",
                CodeMessageStructure.I22CCI => "CCI_I22",
                CodeMessageStructure.I21 => "CCM_I21",
                CodeMessageStructure.I19CCQ => "CCQ_I19",
                CodeMessageStructure.I161718 => "CCR_I16",
                CodeMessageStructure.I20 => "CCU_I20",
                CodeMessageStructure.I19CQU => "CQU_I19",
                CodeMessageStructure.C01C02C03C04C05C06C07C08 => "CRM_C01",
                CodeMessageStructure.C09C10C11C12 => "CSU_C09",
                CodeMessageStructure.P03 => "DFT_P03",
                CodeMessageStructure.P11 => "DFT_P11",
                CodeMessageStructure.DocT12Deprecated => "DOC_T12",
                CodeMessageStructure.U07 => "EAC_U07",
                CodeMessageStructure.U09 => "EAN_U09",
                CodeMessageStructure.U08 => "EAR_U08",
                CodeMessageStructure.E01 => "EHC_E01",
                CodeMessageStructure.E02 => "EHC_E02",
                CodeMessageStructure.E04 => "EHC_E04",
                CodeMessageStructure.E10 => "EHC_E10",
                CodeMessageStructure.E12 => "EHC_E12",
                CodeMessageStructure.E13 => "EHC_E13",
                CodeMessageStructure.E15 => "EHC_E15",
                CodeMessageStructure.E20 => "EHC_E20",
                CodeMessageStructure.E21 => "EHC_E21",
                CodeMessageStructure.E24 => "EHC_E24",
                CodeMessageStructure.U02 => "ESR_U02",
                CodeMessageStructure.U01 => "ESU_U01",
                CodeMessageStructure.U06 => "INR_U06",
                CodeMessageStructure.U05 => "INU_U05",
                CodeMessageStructure.U12U13 => "LSU_U12",
                CodeMessageStructure.T01T03T05T07T09T11 => "MDM_T01",
                CodeMessageStructure.T02T04T06T08T10 => "MDM_T02",
                CodeMessageStructure.M01M02M03M04M05M06M07M08M09M10M11 => "MFK_M01",
                CodeMessageStructure.MfnM01Deprecated => "MFN_M01",
                CodeMessageStructure.M02 => "MFN_M02",
                CodeMessageStructure.M03Deprecated => "MFN_M03",
                CodeMessageStructure.M04 => "MFN_M04",
                CodeMessageStructure.M05 => "MFN_M05",
                CodeMessageStructure.M06 => "MFN_M06",
                CodeMessageStructure.M07 => "MFN_M07",
                CodeMessageStructure.M08 => "MFN_M08",
                CodeMessageStructure.M09 => "MFN_M09",
                CodeMessageStructure.M10 => "MFN_M10",
                CodeMessageStructure.M11 => "MFN_M11",
                CodeMessageStructure.M12 => "MFN_M12",
                CodeMessageStructure.M13 => "MFN_M13",
                CodeMessageStructure.M15 => "MFN_M15",
                CodeMessageStructure.M16 => "MFN_M16",
                CodeMessageStructure.M17 => "MFN_M17",
                CodeMessageStructure.M01M02M03M04M05M06Deprecated => "MFQ_M01",
                CodeMessageStructure.M01M02M03Deprecated => "MFR_M01",
                CodeMessageStructure.M04Deprecated => "MFR_M04",
                CodeMessageStructure.M05Deprecated => "MFR_M05",
                CodeMessageStructure.M06Deprecated => "MFR_M06",
                CodeMessageStructure.M07Deprecated => "MFR_M07",
                CodeMessageStructure.N02 => "NMD_N02",
                CodeMessageStructure.N01NMQDeprecated => "NMQ_N01",
                CodeMessageStructure.N01NMRDeprecated => "NMR_N01",
                CodeMessageStructure.O27 => "OMB_O27",
                CodeMessageStructure.O03 => "OMD_O03",
                CodeMessageStructure.O19 => "OMG_O19",
                CodeMessageStructure.O23 => "OMI_O23",
                CodeMessageStructure.O21 => "OML_O21",
                CodeMessageStructure.O33OML => "OML_O33",
                CodeMessageStructure.O35 => "OML_O35",
                CodeMessageStructure.O39 => "OML_O39",
                CodeMessageStructure.O07 => "OMN_O07",
                CodeMessageStructure.O09 => "OMP_O09",
                CodeMessageStructure.O05 => "OMS_O05",
                CodeMessageStructure.O37 => "OPL_O37",
                CodeMessageStructure.O38 => "OPR_O38",
                CodeMessageStructure.R25 => "OPU_R25",
                CodeMessageStructure.R33 => "ORA_R33",
                CodeMessageStructure.O28 => "ORB_O28",
                CodeMessageStructure.O04 => "ORD_O04",
                CodeMessageStructure.R04Deprecated => "ORF_R04",
                CodeMessageStructure.O20 => "ORG_O20",
                CodeMessageStructure.O24 => "ORI_O24",
                CodeMessageStructure.O22 => "ORL_O22",
                CodeMessageStructure.O34ORL => "ORL_O34",
                CodeMessageStructure.O36 => "ORL_O36",
                CodeMessageStructure.O40 => "ORL_O40",
                CodeMessageStructure.O01ORMDeprecated => "ORM_O01",
                CodeMessageStructure.O08 => "ORN_O08",
                CodeMessageStructure.O10 => "ORP_O10",
                CodeMessageStructure.O02ORRDeprecated => "ORR_O02",
                CodeMessageStructure.O06 => "ORS_O06",
                CodeMessageStructure.R01 => "ORU_R01",
                CodeMessageStructure.R30 => "ORU_R30",
                CodeMessageStructure.W01Deprecated => "ORU_W01",
                CodeMessageStructure.R26 => "OSM_R26",
                CodeMessageStructure.Q06OSQDeprecated => "OSQ_Q06",
                CodeMessageStructure.Q06OSRDeprecated => "OSR_Q06",
                CodeMessageStructure.R21Deprecated => "OUL_R21",
                CodeMessageStructure.R22 => "OUL_R22",
                CodeMessageStructure.R23 => "OUL_R23",
                CodeMessageStructure.R24 => "OUL_R24",
                CodeMessageStructure.P07P08 => "PEX_P07",
                CodeMessageStructure.Pc6Pc7Pc8 => "PGL_PC6",
                CodeMessageStructure.B01B02 => "PMU_B01",
                CodeMessageStructure.B03 => "PMU_B03",
                CodeMessageStructure.B04B05B06 => "PMU_B04",
                CodeMessageStructure.B07 => "PMU_B07",
                CodeMessageStructure.B08 => "PMU_B08",
                CodeMessageStructure.PccPcgPchPcj => "PPG_PCG",
                CodeMessageStructure.PcbPcd => "PPP_PCB",
                CodeMessageStructure.Pc1Pc2Pc3 => "PPR_PC1",
                CodeMessageStructure.PclDeprecated => "PPT_PCL",
                CodeMessageStructure.PcaDeprecated => "PPV_PCA",
                CodeMessageStructure.Pc5Deprecated => "PRR_PC5",
                CodeMessageStructure.PcfDeprecated => "PTR_PCF",
                CodeMessageStructure.E03QBP => "QBP_E03",
                CodeMessageStructure.E22QBP => "QBP_E22",
                CodeMessageStructure.Q11 => "QBP_Q11",
                CodeMessageStructure.Q13 => "QBP_Q13",
                CodeMessageStructure.Q15 => "QBP_Q15",
                CodeMessageStructure.Q21Q22Q23Q24Q25 => "QBP_Q21",
                CodeMessageStructure.Q02QCKDeprecated => "QCK_Q02",
                CodeMessageStructure.J01J02 => "QCN_J01",
                CodeMessageStructure.W02Deprecated => "QRF_W02",
                CodeMessageStructure.A19QRYDeprecated => "QRY_A19",
                CodeMessageStructure.Pc4Pc9PcePckDeprecated => "QRY_PC4",
                CodeMessageStructure.Q01Q26Q27Q28Q29Q30Deprecated => "QRY_Q01",
                CodeMessageStructure.Q02QRYDeprecated => "QRY_Q02",
                CodeMessageStructure.R02Deprecated => "QRY_R02",
                CodeMessageStructure.T12Deprecated => "QRY_T12",
                CodeMessageStructure.Q16 => "QSB_Q16",
                CodeMessageStructure.Q17 => "QVR_Q17",
                CodeMessageStructure.RarDeprecated => "RAR_RAR",
                CodeMessageStructure.O17 => "RAS_O17",
                CodeMessageStructure.I05Deprecated => "RCI_I05",
                CodeMessageStructure.I06RCLDeprecated => "RCL_I06",
                CodeMessageStructure.O11O25 => "RDE_O11",
                CodeMessageStructure.Rdr => "RDR_RDR",
                CodeMessageStructure.O13 => "RDS_O13",
                CodeMessageStructure.K15 => "RDY_K15",
                CodeMessageStructure.I12I13I14I15REF => "REF_I12",
                CodeMessageStructure.RerDeprecated => "RER_RER",
                CodeMessageStructure.RgrDeprecated => "RGR_RGR",
                CodeMessageStructure.O15 => "RGV_O15",
                CodeMessageStructure.RorDeprecated => "ROR_ROR",
                CodeMessageStructure.I08I09I10I11RPA => "RPA_I08",
                CodeMessageStructure.I01I04 => "RPI_I01",
                CodeMessageStructure.I04RPI => "RPI_I04",
                CodeMessageStructure.I02 => "RPL_I02",
                CodeMessageStructure.I03 => "RPR_I03",
                CodeMessageStructure.I08I09I10I11RQA => "RQA_I08",
                CodeMessageStructure.I05I06Deprecated => "RQC_I05",
                CodeMessageStructure.I01I02I03I07 => "RQI_I01",
                CodeMessageStructure.I04RQP => "RQP_I04",
                CodeMessageStructure.O18 => "RRA_O18",
                CodeMessageStructure.O14 => "RRD_O14",
                CodeMessageStructure.O12O26 => "RRE_O12",
                CodeMessageStructure.O16 => "RRG_O16",
                CodeMessageStructure.I12I13I14I15RRI => "RRI_I12",
                CodeMessageStructure.E03RSP => "RSP_E03",
                CodeMessageStructure.E22RSP => "RSP_E22",
                CodeMessageStructure.K11 => "RSP_K11",
                CodeMessageStructure.K21 => "RSP_K21",
                CodeMessageStructure.K22 => "RSP_K22",
                CodeMessageStructure.K23K24 => "RSP_K23",
                CodeMessageStructure.K25 => "RSP_K25",
                CodeMessageStructure.K31 => "RSP_K31",
                CodeMessageStructure.K32 => "RSP_K32",
                CodeMessageStructure.Q11Deprecated => "RSP_Q11",
                CodeMessageStructure.K13 => "RTB_K13",
                CodeMessageStructure.S31S36 => "SDR_S31",
                CodeMessageStructure.S32S37 => "SDR_S32",
                CodeMessageStructure.S12S13S14S15S16S17S18S19S20S21S22S23S24S26 => "SIU_S12",
                CodeMessageStructure.S28S29S30S34S35 => "SLR_S28",
                CodeMessageStructure.S25SQMDeprecated => "SQM_S25",
                CodeMessageStructure.S25SQRDeprecated => "SQR_S25",
                CodeMessageStructure.S01S02S03S04S05S06S07S08S09S10S11SRM => "SRM_S01",
                CodeMessageStructure.S01S02S03S04S05S06S07S08S09S10S11SRR => "SRR_S01",
                CodeMessageStructure.U04 => "SSR_U04",
                CodeMessageStructure.U03 => "SSU_U03",
                CodeMessageStructure.S33 => "STC_S33",
                CodeMessageStructure.P09SURDeprecated => "SUR_P09",
                CodeMessageStructure.U10U11 => "TCU_U10",
                CodeMessageStructure.Q05 => "UDM_Q05",
                CodeMessageStructure.V01Deprecated => "VXQ_V01",
                CodeMessageStructure.V03Deprecated => "VXR_V03",
                CodeMessageStructure.V04 => "VXU_V04",
                CodeMessageStructure.V02Deprecated => "VXX_V02",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMessageStructure input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMessageType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMessageType input)
        {
            return input switch
            {
                CodeMessageType.GeneralAcknowledgment => "ACK",
                CodeMessageType.AdtResponseDeprecated => "ADR",
                CodeMessageType.AdtMessage => "ADT",
                CodeMessageType.AddChangeBillingAccount => "BAR",
                CodeMessageType.BloodProductDispenseStatus => "BPS",
                CodeMessageType.BloodProductDispenseStatusAcknowledgement => "BRP",
                CodeMessageType.BloodProductTransfusionDispositionAcknowledgement => "BRT",
                CodeMessageType.BloodProductTransfusionDisposition => "BTS",
                CodeMessageType.CollaborativeCareFetch => "CCF",
                CodeMessageType.CollaborativeCareInformation => "CCI",
                CodeMessageType.CollaborativeCare => "CCM",
                CodeMessageType.CollaborativeCareReferralCcq => "CCQ",
                CodeMessageType.CollaborativeCareReferralCcu => "CCU",
                CodeMessageType.CollaborativeCareReferralCqu => "CQU",
                CodeMessageType.ClinicalStudyRegistration => "CRM",
                CodeMessageType.UnsolicitedStudyData => "CSU",
                CodeMessageType.DetailFinancialTransactions => "DFT",
                CodeMessageType.DocumentResponseDeprecated => "DOC",
                CodeMessageType.DisplayResponseDeprecated => "DSR",
                CodeMessageType.AutomatedEquipmentCommand => "EAC",
                CodeMessageType.AutomatedEquipmentNotification => "EAN",
                CodeMessageType.AutomatedEquipmentResponse => "EAR",
                CodeMessageType.HealthCareInvoice => "EHC",
                CodeMessageType.AutomatedEquipmentStatusUpdateAcknowledgment => "ESR",
                CodeMessageType.AutomatedEquipmentStatusUpdate => "ESU",
                CodeMessageType.AutomatedEquipmentInventoryRequest => "INR",
                CodeMessageType.AutomatedEquipmentInventoryUpdate => "INU",
                CodeMessageType.AutomatedEquipmentLogServiceRequest => "LSR",
                CodeMessageType.AutomatedEquipmentLogServiceUpdate => "LSU",
                CodeMessageType.MedicalDocumentManagement => "MDM",
                CodeMessageType.MasterFilesDelayedApplicationAcknowledgmentDeprecated => "MFD",
                CodeMessageType.MasterFilesApplicationAcknowledgment => "MFK",
                CodeMessageType.MasterFilesNotification => "MFN",
                CodeMessageType.MasterFilesQueryDeprecated => "MFQ",
                CodeMessageType.MasterFilesResponseDeprecated => "MFR",
                CodeMessageType.ApplicationManagementData => "NMD",
                CodeMessageType.ApplicationManagementQueryDeprecated => "NMQ",
                CodeMessageType.ApplicationManagementResponseDeprecated => "NMR",
                CodeMessageType.BloodProductOrder => "OMB",
                CodeMessageType.DietaryOrder => "OMD",
                CodeMessageType.GeneralClinicalOrder => "OMG",
                CodeMessageType.ImagingOrder => "OMI",
                CodeMessageType.LaboratoryOrder => "OML",
                CodeMessageType.NonStockRequisitionOrder => "OMN",
                CodeMessageType.PharmacyTreatmentOrder => "OMP",
                CodeMessageType.StockRequisitionOrder => "OMS",
                CodeMessageType.PopulationLocationBasedLaboratoryOrder => "OPL",
                CodeMessageType.PopulationLocationBasedLaboratoryOrderAcknowledgment => "OPR",
                CodeMessageType.UnsolicitedPopulationLocationBasedLaboratoryObservation => "OPU",
                CodeMessageType.ObservationReportAcknowledgment => "ORA",
                CodeMessageType.BloodProductOrderAcknowledgement => "ORB",
                CodeMessageType.DietaryOrderAcknowledgment => "ORD",
                CodeMessageType.QueryForResultsOfObservationDeprecated => "ORF",
                CodeMessageType.GeneralClinicalOrderAcknowledgment => "ORG",
                CodeMessageType.ImagingOrderAcknowledgement => "ORI",
                CodeMessageType.LaboratoryAcknowledgmentUnsolicited => "ORL",
                CodeMessageType.PharmacyTreatmentOrderDeprecated => "ORM",
                CodeMessageType.NonStockRequisitionGeneralOrderAcknowledgment => "ORN",
                CodeMessageType.PharmacyTreatmentOrderAcknowledgment => "ORP",
                CodeMessageType.GeneralOrderResponseToAnyOrmDeprecated => "ORR",
                CodeMessageType.StockRequisitionOrderAcknowledgment => "ORS",
                CodeMessageType.UnsolicitedTransmissionOfObservation => "ORU",
                CodeMessageType.SpecimenShipment => "OSM",
                CodeMessageType.QueryResponseForOrderStatusOsqDeprecated => "OSQ",
                CodeMessageType.QueryResponseForOrderStatusOsrDeprecated => "OSR",
                CodeMessageType.UnsolicitedLaboratoryObservation => "OUL",
                CodeMessageType.ProductExperience => "PEX",
                CodeMessageType.PatientGoalMessage => "PGL",
                CodeMessageType.PatientInsuranceInformation => "PIN",
                CodeMessageType.AddPersonnelRecord => "PMU",
                CodeMessageType.PatientPathwayGoalOriented => "PPG",
                CodeMessageType.PatientPathwayProblemOriented => "PPP",
                CodeMessageType.PatientProblem => "PPR",
                CodeMessageType.PatientPathwayGoalOrientedResponseDeprecated => "PPT",
                CodeMessageType.PatientGoalResponseDeprecated => "PPV",
                CodeMessageType.PatientProblemResponseDeprecated => "PRR",
                CodeMessageType.PatientPathwayProblemOrientedResponseDeprecated => "PTR",
                CodeMessageType.QueryByParameter => "QBP",
                CodeMessageType.QueryGeneralAcknowledgmentDeprecated => "QCK",
                CodeMessageType.CancelQuery => "QCN",
                CodeMessageType.QueryOriginalMode => "QRY",
                CodeMessageType.CreateSubscription => "QSB",
                CodeMessageType.CancelSubscriptionAcknowledge => "QSX",
                CodeMessageType.QueryForPreviousEvents => "QVR",
                CodeMessageType.PharmacyTreatmentAdministrationInfoDeprecated => "RAR",
                CodeMessageType.PharmacyTreatmentAdministration => "RAS",
                CodeMessageType.ReturnClinicalInformation => "RCI",
                CodeMessageType.ReturnClinicalList => "RCL",
                CodeMessageType.PharmacyTreatmentEncodedOrder => "RDE",
                CodeMessageType.PharmacyTreatmentDispenseInfo => "RDR",
                CodeMessageType.PharmacyTreatmentDispense => "RDS",
                CodeMessageType.DisplayBasedResponse => "RDY",
                CodeMessageType.PatientReferral => "REF",
                CodeMessageType.PharmacyTreatmentEncodedOrderInformationDeprecated => "RER",
                CodeMessageType.PharmacyTreatmentDoseInformationDeprecated => "RGR",
                CodeMessageType.PharmacyTreatmentGive => "RGV",
                CodeMessageType.PharmacyTreatmentOrderResponseDeprecated => "ROR",
                CodeMessageType.ReturnPatientAuthorization => "RPA",
                CodeMessageType.ReturnPatientInfo => "RPI",
                CodeMessageType.ReturnPatientDisplayList => "RPL",
                CodeMessageType.ReturnPatientList => "RPR",
                CodeMessageType.RequestPatientAuthorization => "RQA",
                CodeMessageType.RequestClinicalInformation => "RQC",
                CodeMessageType.RequestPatientInformation => "RQI",
                CodeMessageType.RequestPatientDemographics => "RQP",
                CodeMessageType.PharmacyTreatmentAdministrationAcknowledgment => "RRA",
                CodeMessageType.PharmacyTreatmentDispenseAcknowledgment => "RRD",
                CodeMessageType.PharmacyTreatmentEncodedOrderAcknowledgment => "RRE",
                CodeMessageType.PharmacyTreatmentGiveAcknowledgment => "RRG",
                CodeMessageType.ReturnReferralInfo => "RRI",
                CodeMessageType.SegmentPatternResponse => "RSP",
                CodeMessageType.TabularResponse => "RTB",
                CodeMessageType.NotificationOfAntiMicrobialDeviceCycleData => "SCN",
                CodeMessageType.NotificationOfAntiMicrobialDeviceData => "SDN",
                CodeMessageType.SterilizationAntiMicrobialDeviceDataRequest => "SDR",
                CodeMessageType.ScheduleInfoUnsolicited => "SIU",
                CodeMessageType.NotificationOfNewSterilizationLot => "SLN",
                CodeMessageType.SterilizationLotRequest => "SLR",
                CodeMessageType.SterilizationAntiMicrobialDeviceCycleDataRequest => "SMD",
                CodeMessageType.ScheduleQueryMessageDeprecated => "SQM",
                CodeMessageType.ScheduleQueryResponseDeprecated => "SQR",
                CodeMessageType.ScheduleRequestMessage => "SRM",
                CodeMessageType.ScheduledRequestResponse => "SRR",
                CodeMessageType.SpecimenStatusRequestMessage => "SSR",
                CodeMessageType.SpecimenStatusUpdateMessage => "SSU",
                CodeMessageType.NotificationOfSterilizationConfiguration => "STC",
                CodeMessageType.SterilizationItemRequest => "STI",
                CodeMessageType.SummaryProductExperienceReportDeprecated => "SUR",
                CodeMessageType.TabularDataResponseDeprecated => "TBR",
                CodeMessageType.AutomatedEquipmentTestCodeSettingsRequest => "TCR",
                CodeMessageType.AutomatedEquipmentTestCodeSettingsUpdate => "TCU",
                CodeMessageType.UnsolicitedDisplayUpdateMessage => "UDM",
                CodeMessageType.QueryForVaccinationRecordDeprecated => "VXQ",
                CodeMessageType.VaccinationRecordResponseDeprecated => "VXR",
                CodeMessageType.UnsolicitedVaccinationRecordUpdate => "VXU",
                CodeMessageType.ResponseForVaccinationQueryWithMultiplePidMatchesDeprecated => "VXX",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMessageType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMessageWaitingPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMessageWaitingPriority input)
        {
            return input switch
            {
                CodeMessageWaitingPriority.High => "H",
                CodeMessageWaitingPriority.Low => "L",
                CodeMessageWaitingPriority.Medium => "M",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMessageWaitingPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMfnRecordLevelErrorReturn enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMfnRecordLevelErrorReturn input)
        {
            return input switch
            {
                CodeMfnRecordLevelErrorReturn.SuccessfulPostingOfTheRecord => "S",
                CodeMfnRecordLevelErrorReturn.UnsuccessfulPostingOfTheRecord => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMfnRecordLevelErrorReturn input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMilitaryRankGrade enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMilitaryRankGrade input)
        {
            return input switch
            {
                CodeMilitaryRankGrade.Enlisted1 => "E1",
                CodeMilitaryRankGrade.Enlisted1To9 => "E1... E9",
                CodeMilitaryRankGrade.Enlisted2 => "E2",
                CodeMilitaryRankGrade.Enlisted3 => "E3",
                CodeMilitaryRankGrade.Enlisted4 => "E4",
                CodeMilitaryRankGrade.Enlisted5 => "E5",
                CodeMilitaryRankGrade.Enlisted6 => "E6",
                CodeMilitaryRankGrade.Enlisted7 => "E7",
                CodeMilitaryRankGrade.Enlisted8 => "E8",
                CodeMilitaryRankGrade.Enlisted9 => "E9",
                CodeMilitaryRankGrade.Officers1 => "O1",
                CodeMilitaryRankGrade.Officers => "O1 ... O9",
                CodeMilitaryRankGrade.Officers2 => "O2",
                CodeMilitaryRankGrade.Officers3 => "O3",
                CodeMilitaryRankGrade.Officers4 => "O4",
                CodeMilitaryRankGrade.Officers5 => "O5",
                CodeMilitaryRankGrade.Officers6 => "O6",
                CodeMilitaryRankGrade.Officers7 => "O7",
                CodeMilitaryRankGrade.Officers8 => "O8",
                CodeMilitaryRankGrade.Officers9 => "O9",
                CodeMilitaryRankGrade.WarrantOfficers1 => "W1",
                CodeMilitaryRankGrade.WarrantOfficers => "W1 ... W4",
                CodeMilitaryRankGrade.WarrantOfficers2 => "W2",
                CodeMilitaryRankGrade.WarrantOfficers3 => "W3",
                CodeMilitaryRankGrade.WarrantOfficers4 => "W4",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMilitaryRankGrade input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMilitaryService enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMilitaryService input)
        {
            return input switch
            {
                CodeMilitaryService.AustralianArmy => "AUSA",
                CodeMilitaryService.AustralianAirForce => "AUSAF",
                CodeMilitaryService.AustralianNavy => "AUSN",
                CodeMilitaryService.Nato => "NATO",
                CodeMilitaryService.Noaa => "NOAA",
                CodeMilitaryService.UsArmy => "USA",
                CodeMilitaryService.UsAirForce => "USAF",
                CodeMilitaryService.UsCoastGuard => "USCG",
                CodeMilitaryService.UsMarineCorps => "USMC",
                CodeMilitaryService.UsNavy => "USN",
                CodeMilitaryService.UsPublicHealthService => "USPHS",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMilitaryService input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMilitaryStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMilitaryStatus input)
        {
            return input switch
            {
                CodeMilitaryStatus.ActiveDuty => "ACT",
                CodeMilitaryStatus.Deceased => "DEC",
                CodeMilitaryStatus.Retired => "RET",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMilitaryStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMimeTypes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMimeTypes input)
        {
            return input switch
            {
                CodeMimeTypes.ApplicationData => "application",
                CodeMimeTypes.AudioData => "audio",
                CodeMimeTypes.ImageData => "image",
                CodeMimeTypes.ModelData => "model",
                CodeMimeTypes.MimeMultipartPackage => "multipart",
                CodeMimeTypes.TextData => "text",
                CodeMimeTypes.VideoData => "video",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMimeTypes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeModality enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeModality input)
        {
            return input switch
            {
                CodeModality.Angioscopy => "AS",
                CodeModality.BiomagneticImaging => "BS",
                CodeModality.ColorFlowDoppler => "CD",
                CodeModality.Colposcopy => "CP",
                CodeModality.ComputedRadiography => "CR",
                CodeModality.Cystoscopy => "CS",
                CodeModality.ComputedTomography => "CT",
                CodeModality.DuplexDoppler => "DD",
                CodeModality.Diapanography => "DG",
                CodeModality.DigitalMicroscopy => "DM",
                CodeModality.Echocardiography => "EC",
                CodeModality.Endoscopy => "ES",
                CodeModality.FluoresceinAngiography => "FA",
                CodeModality.Fundoscopy => "FS",
                CodeModality.Laparoscopy => "LP",
                CodeModality.LaserSurfaceScan => "LS",
                CodeModality.MagneticResonanceAngiography => "MA",
                CodeModality.MagneticResonanceSpectroscopy => "MS",
                CodeModality.NuclearMedicine => "NM",
                CodeModality.Other => "OT",
                CodeModality.PositronEmissionTomography => "PT",
                CodeModality.RadioFluoroscopy => "RF",
                CodeModality.SinglePhotonEmissionComputedTomography => "ST",
                CodeModality.Thermography => "TG",
                CodeModality.Ultrasound => "US",
                CodeModality.XRayAngiography => "XA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeModality input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeModeOfArrivalCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeModeOfArrivalCode input)
        {
            return input switch
            {
                CodeModeOfArrivalCode.Ambulance => "A",
                CodeModeOfArrivalCode.Car => "C",
                CodeModeOfArrivalCode.OnFoot => "F",
                CodeModeOfArrivalCode.Helicopter => "H",
                CodeModeOfArrivalCode.Other => "O",
                CodeModeOfArrivalCode.PublicTransport => "P",
                CodeModeOfArrivalCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeModeOfArrivalCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeModifyIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeModifyIndicator input)
        {
            return input switch
            {
                CodeModifyIndicator.ModifiedSubscription => "M",
                CodeModifyIndicator.NewSubscription => "N",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeModifyIndicator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMoneyOrPercentageIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMoneyOrPercentageIndicator input)
        {
            return input switch
            {
                CodeMoneyOrPercentageIndicator.CurrencyAmount => "AT",
                CodeMoneyOrPercentageIndicator.Percentage => "PC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMoneyOrPercentageIndicator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMoodCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMoodCodes input)
        {
            return input switch
            {
                CodeMoodCodes.Appointment => "APT",
                CodeMoodCodes.AppointmentRequest => "ARQ",
                CodeMoodCodes.Event => "EVN",
                CodeMoodCodes.EventCriterion => "EVN.CRT",
                CodeMoodCodes.Expectation => "EXP",
                CodeMoodCodes.Intent => "INT",
                CodeMoodCodes.Promise => "PRMS",
                CodeMoodCodes.Proposal => "PRP",
                CodeMoodCodes.RequestOrder => "RQO",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMoodCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNameAddressRepresentation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNameAddressRepresentation input)
        {
            return input switch
            {
                CodeNameAddressRepresentation.Alphabetic => "A",
                CodeNameAddressRepresentation.Ideographic => "I",
                CodeNameAddressRepresentation.Phonetic => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNameAddressRepresentation input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNameAssemblyOrder enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNameAssemblyOrder input)
        {
            return input switch
            {
                CodeNameAssemblyOrder.PrefixFamilyMiddleGivenSuffix => "F",
                CodeNameAssemblyOrder.PrefixGivenMiddleFamilySuffix => "G",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNameAssemblyOrder input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNameType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNameType input)
        {
            return input switch
            {
                CodeNameType.Assigned => "A",
                CodeNameType.BirthName => "B",
                CodeNameType.BadName => "BAD",
                CodeNameType.AdoptedName => "C",
                CodeNameType.CustomaryName => "D",
                CodeNameType.LicensingName => "I",
                CodeNameType.BusinessName => "K",
                CodeNameType.OfficialRegistryName => "L",
                CodeNameType.MaidenName => "M",
                CodeNameType.Masked => "MSK",
                CodeNameType.Nickname => "N",
                CodeNameType.TemporarilyUnavailable => "NAV",
                CodeNameType.NewbornName => "NB",
                CodeNameType.NoLongerToBeUsed => "NOUSE",
                CodeNameType.NameOfPartnerSpouse => "P",
                CodeNameType.RegisteredName => "R",
                CodeNameType.Religious => "REL",
                CodeNameType.Pseudonym => "S",
                CodeNameType.IndigenousTribal => "T",
                CodeNameType.TemporaryName => "TEMP",
                CodeNameType.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNameType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNatureOfAbnormalTesting enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNatureOfAbnormalTesting input)
        {
            return input switch
            {
                CodeNatureOfAbnormalTesting.AgeBasedPopulation => "A",
                CodeNatureOfAbnormalTesting.Breed => "B",
                CodeNatureOfAbnormalTesting.None => "N",
                CodeNatureOfAbnormalTesting.RaceBasedPopulation => "R",
                CodeNatureOfAbnormalTesting.SexBasedPopulation => "S",
                CodeNatureOfAbnormalTesting.Species => "SP",
                CodeNatureOfAbnormalTesting.Strain => "ST",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNatureOfAbnormalTesting input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNatureOfChallenge enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNatureOfChallenge input)
        {
            return input switch
            {
                CodeNatureOfChallenge.FastingForPeriodSpecified => "CFST",
                CodeNatureOfChallenge.ExerciseCanBeQuantified => "EXCZ",
                CodeNatureOfChallenge.NoFluidIntakeForPeriodSpecified => "FFST",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNatureOfChallenge input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNatureOfServiceTestObservation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNatureOfServiceTestObservation input)
        {
            return input switch
            {
                CodeNatureOfServiceTestObservation.AtomicServiceTestObservation => "A",
                CodeNatureOfServiceTestObservation.SingleObservation => "C",
                CodeNatureOfServiceTestObservation.FunctionalProcedure => "F",
                CodeNatureOfServiceTestObservation.ProfileFromAtomicObservation => "P",
                CodeNatureOfServiceTestObservation.Superset => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNatureOfServiceTestObservation input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNewbornCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNewbornCode input)
        {
            return input switch
            {
                CodeNewbornCode.BornInFacility => "1",
                CodeNewbornCode.TransferIn => "2",
                CodeNewbornCode.BornEnRoute => "3",
                CodeNewbornCode.Other => "4",
                CodeNewbornCode.BornAtHome => "5",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNewbornCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNonSubjectConsenterReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNonSubjectConsenterReason input)
        {
            return input switch
            {
                CodeNonSubjectConsenterReason.LegallyMandated => "LM",
                CodeNonSubjectConsenterReason.SubjectIsAMinor => "MIN",
                CodeNonSubjectConsenterReason.SubjectIsNotCompetentToConsent => "NC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNonSubjectConsenterReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNotifyClergyCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNotifyClergyCode input)
        {
            return input switch
            {
                CodeNotifyClergyCode.LastRitesOnly => "L",
                CodeNotifyClergyCode.No => "N",
                CodeNotifyClergyCode.Other => "O",
                CodeNotifyClergyCode.Unknown => "U",
                CodeNotifyClergyCode.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNotifyClergyCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeObservationResultHandling enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeObservationResultHandling input)
        {
            return input switch
            {
                CodeObservationResultHandling.AlertProviderWhenAbnormal => "A",
                CodeObservationResultHandling.BlindCopy => "BCC",
                CodeObservationResultHandling.CopiesRequested => "CC",
                CodeObservationResultHandling.FilmWithPatient => "F",
                CodeObservationResultHandling.NotifyProviderWhenReady => "N",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeObservationResultHandling input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeObservationResultStatusCodesInterpretation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeObservationResultStatusCodesInterpretation input)
        {
            return input switch
            {
                CodeObservationResultStatusCodesInterpretation.RecordIsCorrection => "C",
                CodeObservationResultStatusCodesInterpretation.DeletesTheObxRecord => "D",
                CodeObservationResultStatusCodesInterpretation.FinalResults => "F",
                CodeObservationResultStatusCodesInterpretation.SpecimenInLabResultsPending => "I",
                CodeObservationResultStatusCodesInterpretation.NotAsked => "N",
                CodeObservationResultStatusCodesInterpretation.OrderDetailDescription => "O",
                CodeObservationResultStatusCodesInterpretation.PreliminaryResults => "P",
                CodeObservationResultStatusCodesInterpretation.ResultsEnteredNotVerified => "R",
                CodeObservationResultStatusCodesInterpretation.PartialResults => "S",
                CodeObservationResultStatusCodesInterpretation.ResultsChangeToFinalWithoutRetransmit => "U",
                CodeObservationResultStatusCodesInterpretation.PostOriginalAsWrongEGTransmittedForWrongPatient => "W",
                CodeObservationResultStatusCodesInterpretation.ResultsCannotBeObtainedForThisObservation => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeObservationResultStatusCodesInterpretation input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOccurrenceCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOccurrenceCode input)
        {
            return input switch
            {
                CodeOccurrenceCode.UseNubcCodes => "...",
                CodeOccurrenceCode.UseNubcCodesDeprecated => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOccurrenceCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOccurrenceSpan enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOccurrenceSpan input)
        {
            return input switch
            {
                CodeOccurrenceSpan.UseNubcCodes => "...",
                CodeOccurrenceSpan.UseNubcCodesDeprecated => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOccurrenceSpan input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOrderControlCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOrderControlCodes input)
        {
            return input switch
            {
                CodeOrderControlCodes.OrderServiceRefillRequestApproval => "AF",
                CodeOrderControlCodes.CancelOrderServiceRequest => "CA",
                CodeOrderControlCodes.ChildOrderService => "CH",
                CodeOrderControlCodes.CombinedResult => "CN",
                CodeOrderControlCodes.CanceledAsRequested => "CR",
                CodeOrderControlCodes.DiscontinueOrderServiceRequest => "DC",
                CodeOrderControlCodes.DataErrors => "DE",
                CodeOrderControlCodes.OrderServiceRefillRequestDenied => "DF",
                CodeOrderControlCodes.DiscontinuedAsRequested => "DR",
                CodeOrderControlCodes.OrderServiceRefilledUnsolicited => "FU",
                CodeOrderControlCodes.HoldOrderRequest => "HD",
                CodeOrderControlCodes.OnHoldAsRequested => "HR",
                CodeOrderControlCodes.LinkOrderToPatientCareProblemOrGoal => "LI",
                CodeOrderControlCodes.MiscellaneousChargeNotAssociatedWithOrder => "MC",
                CodeOrderControlCodes.NumberAssigned => "NA",
                CodeOrderControlCodes.NewOrderService => "NW",
                CodeOrderControlCodes.OrderServiceCanceled => "OC",
                CodeOrderControlCodes.OrderServiceDiscontinued => "OD",
                CodeOrderControlCodes.OrderServiceReleased => "OE",
                CodeOrderControlCodes.OrderServiceRefilledAsRequested => "OF",
                CodeOrderControlCodes.OrderServiceHeld => "OH",
                CodeOrderControlCodes.OrderServiceAcceptedOk => "OK",
                CodeOrderControlCodes.NotificationOfOrderForOutsideDispense => "OP",
                CodeOrderControlCodes.ReleasedAsRequested => "OR",
                CodeOrderControlCodes.ParentOrderService => "PA",
                CodeOrderControlCodes.PreviousResultsWithNewOrderService => "PR",
                CodeOrderControlCodes.NotificationOfReplacementOrderForOutsideDispense => "PY",
                CodeOrderControlCodes.ObservationsPerformedServiceToFollow => "RE",
                CodeOrderControlCodes.RefillOrderServiceRequest => "RF",
                CodeOrderControlCodes.ReleasePreviousHold => "RL",
                CodeOrderControlCodes.ReplacementOrder => "RO",
                CodeOrderControlCodes.OrderServiceReplaceRequest => "RP",
                CodeOrderControlCodes.ReplacedAsRequested => "RQ",
                CodeOrderControlCodes.RequestReceived => "RR",
                CodeOrderControlCodes.ReplacedUnsolicited => "RU",
                CodeOrderControlCodes.StatusChanged => "SC",
                CodeOrderControlCodes.SendOrderServiceNumber => "SN",
                CodeOrderControlCodes.ResponseToSendOrderServiceStatusRequest => "SR",
                CodeOrderControlCodes.SendOrderServiceStatusRequest => "SS",
                CodeOrderControlCodes.UnableToAcceptOrderService => "UA",
                CodeOrderControlCodes.UnableToCancel => "UC",
                CodeOrderControlCodes.UnableToDiscontinue => "UD",
                CodeOrderControlCodes.UnableToRefill => "UF",
                CodeOrderControlCodes.UnableToPutOnHold => "UH",
                CodeOrderControlCodes.UnableToReplace => "UM",
                CodeOrderControlCodes.UnlinkOrderServiceFromPatientCareProblemOrGoal => "UN",
                CodeOrderControlCodes.UnableToRelease => "UR",
                CodeOrderControlCodes.UnableToChange => "UX",
                CodeOrderControlCodes.ChangeOrderServiceRequest => "XO",
                CodeOrderControlCodes.ChangedAsRequested => "XR",
                CodeOrderControlCodes.OrderServiceChangedUnsol => "XX",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOrderControlCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOrderStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOrderStatus input)
        {
            return input switch
            {
                CodeOrderStatus.SomeButNotAllResultsAvailable => "A",
                CodeOrderStatus.OrderWasCanceled => "CA",
                CodeOrderStatus.OrderIsCompleted => "CM",
                CodeOrderStatus.OrderWasDiscontinued => "DC",
                CodeOrderStatus.ErrorOrderNotFound => "ER",
                CodeOrderStatus.OrderIsOnHold => "HD",
                CodeOrderStatus.InProcessUnspecified => "IP",
                CodeOrderStatus.OrderHasBeenReplaced => "RP",
                CodeOrderStatus.InProcessScheduled => "SC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOrderStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOrderType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOrderType input)
        {
            return input switch
            {
                CodeOrderType.InpatientOrder => "I",
                CodeOrderType.OutpatientOrder => "O",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOrderType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOrganDonorCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOrganDonorCode input)
        {
            return input switch
            {
                CodeOrganDonorCode.YesPatientIsDonorButDocumentationNotOnFile => "F",
                CodeOrganDonorCode.NoPatientIsNotDonorButInfoWasProvided => "I",
                CodeOrganDonorCode.NoPatientHasNotAgreedToBeDonor => "N",
                CodeOrganDonorCode.PatientLeavesOrganDonationDecisionToSpecificPerson => "P",
                CodeOrganDonorCode.PatientLeavesOrganDonationDecisionToRelatives => "R",
                CodeOrganDonorCode.Unknown => "U",
                CodeOrganDonorCode.YesPatientIsDocumentedDonorAndDocumentationIsOnFile => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOrganDonorCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOrganizationAgencyDepartment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOrganizationAgencyDepartment input)
        {
            return input switch
            {
                CodeOrganizationAgencyDepartment.AmericanExpress => "AE",
                CodeOrganizationAgencyDepartment.DrugEnforcementAgency => "DEA",
                CodeOrganizationAgencyDepartment.DepartmentOfDefense => "DOD",
                CodeOrganizationAgencyDepartment.MasterCard => "MC",
                CodeOrganizationAgencyDepartment.VeteransAffairs => "VA",
                CodeOrganizationAgencyDepartment.Visa => "VI",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOrganizationAgencyDepartment input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOrganizationalNameType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOrganizationalNameType input)
        {
            return input switch
            {
                CodeOrganizationalNameType.AliasName => "A",
                CodeOrganizationalNameType.DisplayName => "D",
                CodeOrganizationalNameType.LegalName => "L",
                CodeOrganizationalNameType.StockExchangeListingName => "SL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOrganizationalNameType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOtherEnvironmentalFactors enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOtherEnvironmentalFactors input)
        {
            return input switch
            {
                CodeOtherEnvironmentalFactors.OpenedContainerIndoorAtmosphere60MinutesDuration => "A60",
                CodeOtherEnvironmentalFactors.OpenedContainerAtmosphereAndDurationUnspecified => "ATM",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOtherEnvironmentalFactors input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOutlierType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOutlierType input)
        {
            return input switch
            {
                CodeOutlierType.OutlierCost => "C",
                CodeOutlierType.OutlierDays => "D",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOutlierType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOverallClaimDispositionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOverallClaimDispositionCode input)
        {
            return input switch
            {
                CodeOverallClaimDispositionCode.NoEditsPresentOnClaim => "0",
                CodeOverallClaimDispositionCode.EditsPresentAreForLineItemDenialOrRejection => "1",
                CodeOverallClaimDispositionCode.MultipleDayClaimWithDaysDeniedOrRejected => "2",
                CodeOverallClaimDispositionCode.ClaimDeniedWithOnlyPostPaymentEdits => "3",
                CodeOverallClaimDispositionCode.ClaimDeniedWithOnlyPrePaymentEdits => "4",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOverallClaimDispositionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOverride enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOverride input)
        {
            return input switch
            {
                CodeOverride.OverrideAllowed => "A",
                CodeOverride.OverrideRequired => "R",
                CodeOverride.OverrideNotAllowed => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOverride input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOverrideType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOverrideType input)
        {
            return input switch
            {
                CodeOverrideType.EquivalenceOverride => "EQV",
                CodeOverrideType.ExtensionOverride => "EXTN",
                CodeOverrideType.IntervalOverride => "INLV",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOverrideType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePackage enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePackage input)
        {
            return input switch
            {
                CodePackage.Box => "BX",
                CodePackage.Case => "CS",
                CodePackage.Each => "EA",
                CodePackage.Set => "SET",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePackage input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePackagingStatusCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePackagingStatusCode input)
        {
            return input switch
            {
                CodePackagingStatusCode.NotPackaged => "0",
                CodePackagingStatusCode.PackagedService => "1",
                CodePackagingStatusCode.PackagedAsPartOfPerDiem => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePackagingStatusCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeParticipantOrganizationUnitType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeParticipantOrganizationUnitType input)
        {
            return input switch
            {
                CodeParticipantOrganizationUnitType.Hospital => "1",
                CodeParticipantOrganizationUnitType.PhysicianClinic => "2",
                CodeParticipantOrganizationUnitType.LongTermCare => "3",
                CodeParticipantOrganizationUnitType.AcuteCare => "4",
                CodeParticipantOrganizationUnitType.Other => "5",
                CodeParticipantOrganizationUnitType.Home => "H",
                CodeParticipantOrganizationUnitType.Office => "O",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeParticipantOrganizationUnitType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeParticipation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeParticipation input)
        {
            return input switch
            {
                CodeParticipation.AdmittingProvider => "AD",
                CodeParticipation.AssistantAlternateInterpreter => "AI",
                CodeParticipation.AdministeringProvider => "AP",
                CodeParticipation.AssistantResultInterpreter => "ARI",
                CodeParticipation.AttendingProvider => "AT",
                CodeParticipation.AuthorEventInitiator => "AUT",
                CodeParticipation.ConsultingProvider => "CP",
                CodeParticipation.DispensingProvider => "DP",
                CodeParticipation.EnteringPerson => "EP",
                CodeParticipation.Equipment => "EQUIP",
                CodeParticipation.FamilyHealthCareProfessional => "FHCP",
                CodeParticipation.MedicalDirector => "MDIR",
                CodeParticipation.OrderingProvider => "OP",
                CodeParticipation.PackedBy => "PB",
                CodeParticipation.Pharmacist => "PH",
                CodeParticipation.PrimaryInterpreter => "PI",
                CodeParticipation.PerformingOrganization => "PO",
                CodeParticipation.PerformingOrganizationMedicalDirector => "POMD",
                CodeParticipation.PrimaryCareProvider => "PP",
                CodeParticipation.PrincipalResultInterpreter => "PRI",
                CodeParticipation.ResultsCopiesTo => "RCT",
                CodeParticipation.ResponsibleObserver => "RO",
                CodeParticipation.ReferringProvider => "RP",
                CodeParticipation.ReferredToProvider => "RT",
                CodeParticipation.SendBy => "SB",
                CodeParticipation.SpecimenCollector => "SC",
                CodeParticipation.Technician => "TN",
                CodeParticipation.Transcriptionist => "TR",
                CodeParticipation.VerifierVerifyingPerson => "VP",
                CodeParticipation.VerifyingPharmaceuticalSupplier => "VPS",
                CodeParticipation.VerifyingTreatmentSupplier => "VTS",
                CodeParticipation.Waypoint => "WAY",
                CodeParticipation.WaypointRecipient => "WAYR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeParticipation input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePatientClass enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePatientClass input)
        {
            return input switch
            {
                CodePatientClass.Obstetrics => "B",
                CodePatientClass.CommercialAccount => "C",
                CodePatientClass.Emergency => "E",
                CodePatientClass.Inpatient => "I",
                CodePatientClass.NotApplicable => "N",
                CodePatientClass.Outpatient => "O",
                CodePatientClass.Preadmit => "P",
                CodePatientClass.RecurringPatient => "R",
                CodePatientClass.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePatientClass input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePatientConditionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePatientConditionCode input)
        {
            return input switch
            {
                CodePatientConditionCode.Satisfactory => "A",
                CodePatientConditionCode.Critical => "C",
                CodePatientConditionCode.Other => "O",
                CodePatientConditionCode.Poor => "P",
                CodePatientConditionCode.Stable => "S",
                CodePatientConditionCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePatientConditionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePatientLocationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePatientLocationType input)
        {
            return input switch
            {
                CodePatientLocationType.Bed => "B",
                CodePatientLocationType.Clinic => "C",
                CodePatientLocationType.Department => "D",
                CodePatientLocationType.ExamRoom => "E",
                CodePatientLocationType.OtherLocation => "L",
                CodePatientLocationType.NursingUnit => "N",
                CodePatientLocationType.OperatingRoom => "O",
                CodePatientLocationType.Room => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePatientLocationType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePatientOutcome enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePatientOutcome input)
        {
            return input switch
            {
                CodePatientOutcome.Died => "D",
                CodePatientOutcome.FullyRecovered => "F",
                CodePatientOutcome.NotRecoveringUnchanged => "N",
                CodePatientOutcome.Recovering => "R",
                CodePatientOutcome.Sequelae => "S",
                CodePatientOutcome.Unknown => "U",
                CodePatientOutcome.Worsening => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePatientOutcome input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePatientResultsReleaseCategorizationScheme enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePatientResultsReleaseCategorizationScheme input)
        {
            return input switch
            {
                CodePatientResultsReleaseCategorizationScheme.ShareIn1Day => "SID",
                CodePatientResultsReleaseCategorizationScheme.ShareIn1DayConditionally => "SIDC",
                CodePatientResultsReleaseCategorizationScheme.ShareImmediately => "SIMM",
                CodePatientResultsReleaseCategorizationScheme.ShareToBeDetermined => "STBD",
                CodePatientResultsReleaseCategorizationScheme.ShareWithinNormalLimits => "SWNL",
                CodePatientResultsReleaseCategorizationScheme.ShareWithhold => "SWTH",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePatientResultsReleaseCategorizationScheme input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePatientsRelationshiptoInsured enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePatientsRelationshiptoInsured input)
        {
            return input switch
            {
                CodePatientsRelationshiptoInsured.PatientIsInsured => "01",
                CodePatientsRelationshiptoInsured.Spouse => "02",
                CodePatientsRelationshiptoInsured.NaturalChildInsuredFinancialResponsibility => "03",
                CodePatientsRelationshiptoInsured.NaturalChildInsuredDoesNotHaveFinancialResponsibility => "04",
                CodePatientsRelationshiptoInsured.StepChild => "05",
                CodePatientsRelationshiptoInsured.FosterChild => "06",
                CodePatientsRelationshiptoInsured.WardOfTheCourt => "07",
                CodePatientsRelationshiptoInsured.Employee => "08",
                CodePatientsRelationshiptoInsured.Unknown => "09",
                CodePatientsRelationshiptoInsured.HandicappedDependent => "10",
                CodePatientsRelationshiptoInsured.OrganDonor => "11",
                CodePatientsRelationshiptoInsured.CadaverDonor => "12",
                CodePatientsRelationshiptoInsured.Grandchild => "13",
                CodePatientsRelationshiptoInsured.NieceNephew => "14",
                CodePatientsRelationshiptoInsured.InjuredPlaintiff => "15",
                CodePatientsRelationshiptoInsured.SponsoredDependent => "16",
                CodePatientsRelationshiptoInsured.MinorDependentOfAMinorDependent => "17",
                CodePatientsRelationshiptoInsured.Parent => "18",
                CodePatientsRelationshiptoInsured.Grandparent => "19",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePatientsRelationshiptoInsured input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePatientStatusCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePatientStatusCode input)
        {
            return input switch
            {
                CodePatientStatusCode.ActiveInpatient => "AI",
                CodePatientStatusCode.DischargedInpatient => "DI",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePatientStatusCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePayeeRelationshipToInvoice enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePayeeRelationshipToInvoice input)
        {
            return input switch
            {
                CodePayeeRelationshipToInvoice.FamilyMember => "FM",
                CodePayeeRelationshipToInvoice.Guarantor => "GT",
                CodePayeeRelationshipToInvoice.Patient => "PT",
                CodePayeeRelationshipToInvoice.Subscriber => "SB",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePayeeRelationshipToInvoice input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePayeeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePayeeType input)
        {
            return input switch
            {
                CodePayeeType.Employer => "EMPL",
                CodePayeeType.PayeeOrganization => "ORG",
                CodePayeeType.Person => "PERS",
                CodePayeeType.PayPerson => "PPER",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePayeeType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePaymentAdjustmentCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePaymentAdjustmentCode input)
        {
            return input switch
            {
                CodePaymentAdjustmentCode.NoPaymentAdjustment => "1",
                CodePaymentAdjustmentCode.DesignatedDrugOrBiologicalPaymentAdjustmentAppliesToApc => "2",
                CodePaymentAdjustmentCode.DesignatedNewDevicePaymentAdjustmentAppliesToApc => "3",
                CodePaymentAdjustmentCode.DesignatedNewDrugOrNewBiologicalPaymentAdjustmentAppliesToApc => "4",
                CodePaymentAdjustmentCode.DeductibleNotApplicable => "5",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePaymentAdjustmentCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePaymentMethodCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePaymentMethodCode input)
        {
            return input switch
            {
                CodePaymentMethodCode.Cash => "CASH",
                CodePaymentMethodCode.CreditCard => "CCCA",
                CodePaymentMethodCode.CashiersCheck => "CCHK",
                CodePaymentMethodCode.CreditDebitAccount => "CDAC",
                CodePaymentMethodCode.Check => "CHCK",
                CodePaymentMethodCode.DirectDeposit => "DDPO",
                CodePaymentMethodCode.DebitCard => "DEBC",
                CodePaymentMethodCode.SocietyForWorldwideInterbankFinancialTelecom => "SWFT",
                CodePaymentMethodCode.TravelersCheck => "TRAC",
                CodePaymentMethodCode.VisaSpecialElectronicFundsTransferNetwork => "VISN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePaymentMethodCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePersonLocationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePersonLocationType input)
        {
            return input switch
            {
                CodePersonLocationType.Clinic => "C",
                CodePersonLocationType.Department => "D",
                CodePersonLocationType.Home => "H",
                CodePersonLocationType.NursingUnit => "N",
                CodePersonLocationType.ProvidersOffice => "O",
                CodePersonLocationType.Phone => "P",
                CodePersonLocationType.Snf => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePersonLocationType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePharmacyOrderTypes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePharmacyOrderTypes input)
        {
            return input switch
            {
                CodePharmacyOrderTypes.Medication => "M",
                CodePharmacyOrderTypes.OtherSolutionAsMedicationOrders => "O",
                CodePharmacyOrderTypes.IvLargeVolumeSolutions => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePharmacyOrderTypes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePolicyType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePolicyType input)
        {
            return input switch
            {
                CodePolicyType.SecondAncillary => "2ANC",
                CodePolicyType.SecondMajorMedical => "2MMD",
                CodePolicyType.ThirdMajorMedical => "3MMD",
                CodePolicyType.Ancillary => "ANC",
                CodePolicyType.MajorMedical => "MMD",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePolicyType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePractitionerIdNumberType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePractitionerIdNumberType input)
        {
            return input switch
            {
                CodePractitionerIdNumberType.CountyNumber => "CY",
                CodePractitionerIdNumberType.DrugEnforcementAgencyNo => "DEA",
                CodePractitionerIdNumberType.GeneralLedgerNumber => "GL",
                CodePractitionerIdNumberType.LaborAndIndustriesNumberDeprecated => "L&I",
                CodePractitionerIdNumberType.LaborAndIndustriesNumber => "LI",
                CodePractitionerIdNumberType.MedicaidNumber => "MCD",
                CodePractitionerIdNumberType.MedicareNumber => "MCR",
                CodePractitionerIdNumberType.QaNumber => "QA",
                CodePractitionerIdNumberType.StateLicenseNumber => "SL",
                CodePractitionerIdNumberType.TaxIdNumber => "TAX",
                CodePractitionerIdNumberType.TrainingLicenseNumber => "TRL",
                CodePractitionerIdNumberType.UniquePhysicianIdNo => "UPIN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePractitionerIdNumberType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePractitionerOrganizationUnitType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePractitionerOrganizationUnitType input)
        {
            return input switch
            {
                CodePractitionerOrganizationUnitType.Department => "D",
                CodePractitionerOrganizationUnitType.Facility => "F",
                CodePractitionerOrganizationUnitType.Subdivision => "S",
                CodePractitionerOrganizationUnitType.Subdepartment => "U",
                CodePractitionerOrganizationUnitType.Division => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePractitionerOrganizationUnitType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePrecautionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePrecautionCode input)
        {
            return input switch
            {
                CodePrecautionCode.Aggressive => "A",
                CodePrecautionCode.Blind => "B",
                CodePrecautionCode.Confused => "C",
                CodePrecautionCode.Deaf => "D",
                CodePrecautionCode.OnIv => "I",
                CodePrecautionCode.DoNotResuscitate => "N",
                CodePrecautionCode.Other => "O",
                CodePrecautionCode.Paraplegic => "P",
                CodePrecautionCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePrecautionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePreferredMethodOfContact enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePreferredMethodOfContact input)
        {
            return input switch
            {
                CodePreferredMethodOfContact.BeeperNumber => "B",
                CodePreferredMethodOfContact.CellularPhoneNumber => "C",
                CodePreferredMethodOfContact.EmailAddress => "E",
                CodePreferredMethodOfContact.FaxNumber => "F",
                CodePreferredMethodOfContact.HomePhoneNumber => "H",
                CodePreferredMethodOfContact.OfficePhoneNumber => "O",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePreferredMethodOfContact input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePresentOnAdmissionIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePresentOnAdmissionIndicator input)
        {
            return input switch
            {
                CodePresentOnAdmissionIndicator.Exempt => "E",
                CodePresentOnAdmissionIndicator.No => "N",
                CodePresentOnAdmissionIndicator.Unknown => "U",
                CodePresentOnAdmissionIndicator.NotApplicable => "W",
                CodePresentOnAdmissionIndicator.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePresentOnAdmissionIndicator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePriceType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePriceType input)
        {
            return input switch
            {
                CodePriceType.AdministrativePriceOrHandlingFee => "AP",
                CodePriceType.DirectUnitCost => "DC",
                CodePriceType.IndirectUnitCost => "IC",
                CodePriceType.ProfessionalFeeForPerformingProvider => "PF",
                CodePriceType.TechnologyFeeForUseOfEquipment => "TF",
                CodePriceType.TotalPrice => "TP",
                CodePriceType.UnitPrice => "UP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePriceType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePrimaryKeyValueType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePrimaryKeyValueType input)
        {
            return input switch
            {
                CodePrimaryKeyValueType.CodedElement => "CE",
                CodePrimaryKeyValueType.CodedWithExceptions => "CWE",
                CodePrimaryKeyValueType.PersonLocation => "PL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePrimaryKeyValueType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePrimaryObserversQualification enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePrimaryObserversQualification input)
        {
            return input switch
            {
                CodePrimaryObserversQualification.HealthCareConsumerPatient => "C",
                CodePrimaryObserversQualification.OtherHealthProfessional => "H",
                CodePrimaryObserversQualification.LawyerAttorney => "L",
                CodePrimaryObserversQualification.MidLevelProfessional => "M",
                CodePrimaryObserversQualification.OtherNonHealthProfessional => "O",
                CodePrimaryObserversQualification.PhysicianOsteopathHomeopath => "P",
                CodePrimaryObserversQualification.Pharmacist => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePrimaryObserversQualification input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePriority input)
        {
            return input switch
            {
                CodePriority.AsSoonAsPossible => "A",
                CodePriority.Preoperative => "P",
                CodePriority.Routine => "R",
                CodePriority.Stat => "S",
                CodePriority.TimingCritical => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePrivacyLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePrivacyLevel input)
        {
            return input switch
            {
                CodePrivacyLevel.Isolation => "F",
                CodePrivacyLevel.PrivateRoomMedicallyJustified => "J",
                CodePrivacyLevel.PrivateRoom => "P",
                CodePrivacyLevel.PrivateRoomDueToOverflow => "Q",
                CodePrivacyLevel.SemiPrivateRoom => "S",
                CodePrivacyLevel.Ward => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePrivacyLevel input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProblemGoalActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProblemGoalActionCode input)
        {
            return input switch
            {
                CodeProblemGoalActionCode.Add => "AD",
                CodeProblemGoalActionCode.Correct => "CO",
                CodeProblemGoalActionCode.Delete => "DE",
                CodeProblemGoalActionCode.Link => "LI",
                CodeProblemGoalActionCode.Unchanged => "UC",
                CodeProblemGoalActionCode.Unlink => "UN",
                CodeProblemGoalActionCode.Update => "UP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProblemGoalActionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcedureDrgType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcedureDrgType input)
        {
            return input switch
            {
                CodeProcedureDrgType.FirstNonOperative => "1",
                CodeProcedureDrgType.SecondNonOperative => "2",
                CodeProcedureDrgType.MajorOperative => "3",
                CodeProcedureDrgType.SecondOperative => "4",
                CodeProcedureDrgType.ThirdOperative => "5",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcedureDrgType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcedureFunctionalType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcedureFunctionalType input)
        {
            return input switch
            {
                CodeProcedureFunctionalType.Anesthesia => "A",
                CodeProcedureFunctionalType.DiagnosticProcedure => "D",
                CodeProcedureFunctionalType.InvasiveProcedureNotClassified => "I",
                CodeProcedureFunctionalType.ProcedureForTreatment => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcedureFunctionalType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcedurePriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcedurePriority input)
        {
            return input switch
            {
                CodeProcedurePriority.NoSuggestedValuesDefined => "...",
                CodeProcedurePriority.TheAdmittingProcedure => "0",
                CodeProcedurePriority.ThePrimaryProcedure => "1",
                CodeProcedurePriority.ForRankedSecondaryProcedures => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcedurePriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcessingConsiderationCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcessingConsiderationCodes input)
        {
            return input switch
            {
                CodeProcessingConsiderationCodes.DeferredAdjudicationProcessing => "DFADJ",
                CodeProcessingConsiderationCodes.ElectronicFormToFollow => "EFORM",
                CodeProcessingConsiderationCodes.FaxToFollow => "FAX",
                CodeProcessingConsiderationCodes.PaperDocumentationToFollow => "PAPER",
                CodeProcessingConsiderationCodes.DelayedByAPreviousPayer => "PYRDELAY",
                CodeProcessingConsiderationCodes.RealTimeAdjudicationProcessing => "RTADJ",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcessingConsiderationCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcessingId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcessingId input)
        {
            return input switch
            {
                CodeProcessingId.Debugging => "D",
                CodeProcessingId.Production => "P",
                CodeProcessingId.Training => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcessingId input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcessingMode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcessingMode input)
        {
            return input switch
            {
                CodeProcessingMode.Archive => "A",
                CodeProcessingMode.InitialLoad => "I",
                CodeProcessingMode.NotPresent => "Not present",
                CodeProcessingMode.RestoreFromArchive => "R",
                CodeProcessingMode.CurrentProcessing => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcessingMode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcessingPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcessingPriority input)
        {
            return input switch
            {
                CodeProcessingPriority.AsSoonAsPossible => "A",
                CodeProcessingPriority.DoAtBedsideOrPortable => "B",
                CodeProcessingPriority.MeasureContinuously => "C",
                CodeProcessingPriority.Preoperative => "P",
                CodeProcessingPriority.Routine => "R",
                CodeProcessingPriority.Stat => "S",
                CodeProcessingPriority.TimingCritical => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcessingPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcessingType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcessingType input)
        {
            return input switch
            {
                CodeProcessingType.Evaluation => "E",
                CodeProcessingType.RegularProduction => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcessingType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProductionClassCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProductionClassCode input)
        {
            return input switch
            {
                CodeProductionClassCode.BreedingGeneticStock => "BR",
                CodeProductionClassCode.Dairy => "DA",
                CodeProductionClassCode.Draft => "DR",
                CodeProductionClassCode.DualPurpose => "DU",
                CodeProductionClassCode.LayerIncludesMultiplierFlocks => "LY",
                CodeProductionClassCode.Meat => "MT",
                CodeProductionClassCode.NotApplicable => "NA",
                CodeProductionClassCode.Other => "OT",
                CodeProductionClassCode.Pleasure => "PL",
                CodeProductionClassCode.Racing => "RA",
                CodeProductionClassCode.Show => "SH",
                CodeProductionClassCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProductionClassCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProductServicesClarificationCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProductServicesClarificationCodes input)
        {
            return input switch
            {
                CodeProductServicesClarificationCodes.ClaimCenter => "CLCTR",
                CodeProductServicesClarificationCodes.DiagnosticApprovalNumber => "DGAPP",
                CodeProductServicesClarificationCodes.DataCenterNumber => "DTCTR",
                CodeProductServicesClarificationCodes.EncounterNumber => "ENC",
                CodeProductServicesClarificationCodes.GoodFaithIndicator => "GFTH",
                CodeProductServicesClarificationCodes.OutOfProvinceIndicator => "OOP",
                CodeProductServicesClarificationCodes.SequenceNumber => "SEQ",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProductServicesClarificationCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProductServiceStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProductServiceStatus input)
        {
            return input switch
            {
                CodeProductServiceStatus.Denied => "D",
                CodeProductServiceStatus.Processed => "P",
                CodeProductServiceStatus.Rejected => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProductServiceStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProductSource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProductSource input)
        {
            return input switch
            {
                CodeProductSource.ActualProductWasEvaluated => "A",
                CodeProductSource.ProductFromSameLotWasEvaluated => "L",
                CodeProductSource.ProductFromNonRelatedInventoryWasEvaluated => "N",
                CodeProductSource.ProductFromReserveWasEvaluated => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProductSource input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProtectionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProtectionCode input)
        {
            return input switch
            {
                CodeProtectionCode.Listed => "LI",
                CodeProtectionCode.UnlistedShouldNotAppearInDirectories => "UL",
                CodeProtectionCode.Unpublished => "UP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProtectionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProviderAdjustmentReasonCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProviderAdjustmentReasonCode input)
        {
            return input switch
            {
                CodeProviderAdjustmentReasonCode.DispensingFee => "DISP",
                CodeProviderAdjustmentReasonCode.GoodsAndServicesTax => "GST",
                CodeProviderAdjustmentReasonCode.HarmonizedSalesTax => "HST",
                CodeProviderAdjustmentReasonCode.MarkUpFee => "MKUP",
                CodeProviderAdjustmentReasonCode.ProvincialSalesTax => "PST",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProviderAdjustmentReasonCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProviderBilling enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProviderBilling input)
        {
            return input switch
            {
                CodeProviderBilling.InstitutionBillsForProvider => "I",
                CodeProviderBilling.ProviderDoesOwnBilling => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProviderBilling input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProviderRole enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProviderRole input)
        {
            return input switch
            {
                CodeProviderRole.Admitting => "AD",
                CodeProviderRole.AssistantAlternateInterpreter => "AI",
                CodeProviderRole.AdministeringProvider => "AP",
                CodeProviderRole.Attending => "AT",
                CodeProviderRole.CollectingProvider => "CLP",
                CodeProviderRole.ConsultingProvider => "CP",
                CodeProviderRole.DispensingProvider => "DP",
                CodeProviderRole.EnteringProvider => "EP",
                CodeProviderRole.FamilyHealthCareProfessional => "FHCP",
                CodeProviderRole.InitiatingProviderAsInActionBy => "IP",
                CodeProviderRole.MedicalDirector => "MDIR",
                CodeProviderRole.OrderingProvider => "OP",
                CodeProviderRole.Pharmacist => "PH",
                CodeProviderRole.PrimaryInterpreter => "PI",
                CodeProviderRole.PrimaryCareProvider => "PP",
                CodeProviderRole.ResponsibleObserver => "RO",
                CodeProviderRole.ReferringProvider => "RP",
                CodeProviderRole.ReferredToProvider => "RT",
                CodeProviderRole.Technician => "TN",
                CodeProviderRole.Transcriptionist => "TR",
                CodeProviderRole.VerifyingProvider => "VP",
                CodeProviderRole.VerifyingPharmaceuticalSupplier => "VPS",
                CodeProviderRole.VerifyingTreatmentSupplier => "VTS",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProviderRole input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePublicityCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePublicityCode input)
        {
            return input switch
            {
                CodePublicityCode.FamilyOnly => "F",
                CodePublicityCode.NoPublicity => "N",
                CodePublicityCode.Other => "O",
                CodePublicityCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePublicityCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePurgeStatusCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePurgeStatusCode input)
        {
            return input switch
            {
                CodePurgeStatusCode.VisitMarkedForDeletion => "D",
                CodePurgeStatusCode.VisitMarkedInactive => "I",
                CodePurgeStatusCode.MarkedForPurge => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePurgeStatusCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeQuantityLimitedRequest enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeQuantityLimitedRequest input)
        {
            return input switch
            {
                CodeQuantityLimitedRequest.Characters => "CH",
                CodeQuantityLimitedRequest.Lines => "LI",
                CodeQuantityLimitedRequest.Pages => "PG",
                CodeQuantityLimitedRequest.Records => "RD",
                CodeQuantityLimitedRequest.LocallyDefined => "ZO",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeQuantityLimitedRequest input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeQuantityMethod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeQuantityMethod input)
        {
            return input switch
            {
                CodeQuantityMethod.ActualCount => "A",
                CodeQuantityMethod.EstimatedSeeComment => "E",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeQuantityMethod input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeQueryPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeQueryPriority input)
        {
            return input switch
            {
                CodeQueryPriority.Deferred => "D",
                CodeQueryPriority.Immediate => "I",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeQueryPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeQueryResponseStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeQueryResponseStatus input)
        {
            return input switch
            {
                CodeQueryResponseStatus.ApplicationError => "AE",
                CodeQueryResponseStatus.ApplicationReject => "AR",
                CodeQueryResponseStatus.NoDataFoundNoErrors => "NF",
                CodeQueryResponseStatus.DataFoundNoErrors => "OK",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeQueryResponseStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRace enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRace input)
        {
            return input switch
            {
                CodeRace.AmericanIndianOrAlaskaNative => "1002-5",
                CodeRace.Asian => "2028-9",
                CodeRace.BlackOrAfricanAmerican => "2054-5",
                CodeRace.NativeHawaiianOrOtherPacificIslander => "2076-8",
                CodeRace.White => "2106-3",
                CodeRace.OtherRace => "2131-1",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRace input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReadmissionIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReadmissionIndicator input)
        {
            return input switch
            {
                CodeReadmissionIndicator.ReAdmission => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReadmissionIndicator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRecreationalDrugUseCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRecreationalDrugUseCode input)
        {
            return input switch
            {
                CodeRecreationalDrugUseCode.Alcohol => "A",
                CodeRecreationalDrugUseCode.TobaccoChewed => "C",
                CodeRecreationalDrugUseCode.Kava => "K",
                CodeRecreationalDrugUseCode.Marijuana => "M",
                CodeRecreationalDrugUseCode.Other => "O",
                CodeRecreationalDrugUseCode.TobaccoSmoked => "T",
                CodeRecreationalDrugUseCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRecreationalDrugUseCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReferralCategory enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReferralCategory input)
        {
            return input switch
            {
                CodeReferralCategory.Ambulatory => "A",
                CodeReferralCategory.Emergency => "E",
                CodeReferralCategory.Inpatient => "I",
                CodeReferralCategory.Outpatient => "O",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReferralCategory input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReferralDisposition enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReferralDisposition input)
        {
            return input switch
            {
                CodeReferralDisposition.AssumeManagement => "AM",
                CodeReferralDisposition.ReturnPatientAfterEvaluation => "RP",
                CodeReferralDisposition.SecondOpinion => "SO",
                CodeReferralDisposition.SendWrittenReport => "WR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReferralDisposition input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReferralPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReferralPriority input)
        {
            return input switch
            {
                CodeReferralPriority.Asap => "A",
                CodeReferralPriority.Routine => "R",
                CodeReferralPriority.Stat => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReferralPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReferralReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReferralReason input)
        {
            return input switch
            {
                CodeReferralReason.ProviderOrdered => "O",
                CodeReferralReason.PatientPreference => "P",
                CodeReferralReason.SecondOpinion => "S",
                CodeReferralReason.WorkLoad => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReferralReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReferralStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReferralStatus input)
        {
            return input switch
            {
                CodeReferralStatus.Accepted => "A",
                CodeReferralStatus.Expired => "E",
                CodeReferralStatus.Pending => "P",
                CodeReferralStatus.Rejected => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReferralStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReferralType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReferralType input)
        {
            return input switch
            {
                CodeReferralType.HomeCare => "Hom",
                CodeReferralType.Laboratory => "Lab",
                CodeReferralType.Medical => "Med",
                CodeReferralType.Psychiatric => "Psy",
                CodeReferralType.Radiology => "Rad",
                CodeReferralType.SkilledNursing => "Skn",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReferralType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReimbursementActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReimbursementActionCode input)
        {
            return input switch
            {
                CodeReimbursementActionCode.OceLineItemDenialOrRejectionIsNotIgnored => "0",
                CodeReimbursementActionCode.OceLineItemDenialOrRejectionIsIgnored => "1",
                CodeReimbursementActionCode.ExternalLineItemDenial => "2",
                CodeReimbursementActionCode.ExternalLineItemRejection => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReimbursementActionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReimbursementTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReimbursementTypeCode input)
        {
            return input switch
            {
                CodeReimbursementTypeCode.CornealTissueApc => "Crnl",
                CodeReimbursementTypeCode.DurableMedicalEquipment => "DME",
                CodeReimbursementTypeCode.Epotein => "EPO",
                CodeReimbursementTypeCode.ClinicalLaboratoryApc => "Lab",
                CodeReimbursementTypeCode.ScreeningMammographyApc => "Mamm",
                CodeReimbursementTypeCode.ThisApcIsNotPaid => "NoPay",
                CodeReimbursementTypeCode.OutpatientProspectivePaymentSystem => "OPPS",
                CodeReimbursementTypeCode.PartialHospitalizationApc => "PartH",
                CodeReimbursementTypeCode.PackagedApc => "Pckg",
                CodeReimbursementTypeCode.TherapyApc => "Thrpy",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReimbursementTypeCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRelatednessAssessment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRelatednessAssessment input)
        {
            return input switch
            {
                CodeRelatednessAssessment.HighlyProbable => "H",
                CodeRelatednessAssessment.Improbable => "I",
                CodeRelatednessAssessment.ModeratelyProbable => "M",
                CodeRelatednessAssessment.NotRelated => "N",
                CodeRelatednessAssessment.SomewhatProbable => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRelatednessAssessment input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRelationalConjunction enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRelationalConjunction input)
        {
            return input switch
            {
                CodeRelationalConjunction.Default => "AND",
                CodeRelationalConjunction.Or => "OR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRelationalConjunction input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRelationalOperator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRelationalOperator input)
        {
            return input switch
            {
                CodeRelationalOperator.Contains => "CT",
                CodeRelationalOperator.Equal => "EQ",
                CodeRelationalOperator.GreaterThanOrEqual => "GE",
                CodeRelationalOperator.Generic => "GN",
                CodeRelationalOperator.GreaterThan => "GT",
                CodeRelationalOperator.LessThanOrEqual => "LE",
                CodeRelationalOperator.LessThan => "LT",
                CodeRelationalOperator.NotEqual => "NE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRelationalOperator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRelationship enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRelationship input)
        {
            return input switch
            {
                CodeRelationship.Associate => "ASC",
                CodeRelationship.Brother => "BRO",
                CodeRelationship.CareGiver => "CGV",
                CodeRelationship.Child => "CHD",
                CodeRelationship.HandicappedDependent => "DEP",
                CodeRelationship.LifePartner => "DOM",
                CodeRelationship.EmergencyContact => "EMC",
                CodeRelationship.Employee => "EME",
                CodeRelationship.Employer => "EMR",
                CodeRelationship.ExtendedFamily => "EXF",
                CodeRelationship.FosterChild => "FCH",
                CodeRelationship.Friend => "FND",
                CodeRelationship.Father => "FTH",
                CodeRelationship.Grandchild => "GCH",
                CodeRelationship.Guardian => "GRD",
                CodeRelationship.Grandparent => "GRP",
                CodeRelationship.Manager => "MGR",
                CodeRelationship.Mother => "MTH",
                CodeRelationship.NaturalChild => "NCH",
                CodeRelationship.None => "NON",
                CodeRelationship.OtherAdult => "OAD",
                CodeRelationship.Other => "OTH",
                CodeRelationship.Owner => "OWN",
                CodeRelationship.Parent => "PAR",
                CodeRelationship.Stepchild => "SCH",
                CodeRelationship.Self => "SEL",
                CodeRelationship.Sibling => "SIB",
                CodeRelationship.Sister => "SIS",
                CodeRelationship.Spouse => "SPO",
                CodeRelationship.Trainer => "TRA",
                CodeRelationship.Unknown => "UNK",
                CodeRelationship.WardOfCourt => "WRD",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRelationship input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRelationshipModifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRelationshipModifier input)
        {
            return input switch
            {
                CodeRelationshipModifier.BloodProductUnit => "BPU",
                CodeRelationshipModifier.Control => "CONTROL",
                CodeRelationshipModifier.Donor => "DONOR",
                CodeRelationshipModifier.Patient => "PATIENT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRelationshipModifier input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRelevantClinicialInformation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRelevantClinicialInformation input)
        {
            return input switch
            {
                CodeRelevantClinicialInformation.PatientWasFastingPrior => "F",
                CodeRelevantClinicialInformation.FastingNotAskedOfThePatient => "FNA",
                CodeRelevantClinicialInformation.PatientIndicatedTheyDidNotFastPrior => "NF",
                CodeRelevantClinicialInformation.PatientWasNotAsked => "NG",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRelevantClinicialInformation input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReligion enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReligion input)
        {
            return input switch
            {
                CodeReligion.ChristianAmericanBaptistChurch => "ABC",
                CodeReligion.Agnostic => "AGN",
                CodeReligion.ChristianAfricanMethodistEpiscopalZion => "AME",
                CodeReligion.ChristianAfricanMethodistEpiscopal => "AMT",
                CodeReligion.ChristianAnglican => "ANG",
                CodeReligion.ChristianAssemblyOfGod => "AOG",
                CodeReligion.Atheist => "ATH",
                CodeReligion.Bahai => "BAH",
                CodeReligion.ChristianBaptist => "BAP",
                CodeReligion.BuddhistMahayana => "BMA",
                CodeReligion.BuddhistOther => "BOT",
                CodeReligion.Brethren => "BRE",
                CodeReligion.BuddhistTantrayana => "BTA",
                CodeReligion.BuddhistTheravada => "BTH",
                CodeReligion.Buddhist => "BUD",
                CodeReligion.ChristianRomanCatholic => "CAT",
                CodeReligion.ChineseFolkReligionist => "CFR",
                CodeReligion.Christian => "CHR",
                CodeReligion.ChristianChristianScience => "CHS",
                CodeReligion.ChristianChristianMissionaryAlliance => "CMA",
                CodeReligion.Confucian => "CNF",
                CodeReligion.ChristianChurchOfChrist => "COC",
                CodeReligion.ChristianChurchOfGod => "COG",
                CodeReligion.ChristianChurchOfGodInChrist => "COI",
                CodeReligion.ChristianCongregational => "COL",
                CodeReligion.ChristianCommunity => "COM",
                CodeReligion.ChristianOtherPentecostal => "COP",
                CodeReligion.ChristianOther => "COT",
                CodeReligion.ChristianChristianReformed => "CRR",
                CodeReligion.DisciplesOfChrist => "DOC",
                CodeReligion.ChristianEasternOrthodox => "EOT",
                CodeReligion.ChristianEpiscopalian => "EPI",
                CodeReligion.EthnicReligionist => "ERL",
                CodeReligion.ChristianEvangelicalChurch => "EVC",
                CodeReligion.ChristianFriends => "FRQ",
                CodeReligion.ChristianFullGospel => "FUL",
                CodeReligion.ChristianFreeWillBaptist => "FWB",
                CodeReligion.ChristianGreekOrthodox => "GRE",
                CodeReligion.Hindu => "HIN",
                CodeReligion.HinduOther => "HOT",
                CodeReligion.HinduShaivites => "HSH",
                CodeReligion.HinduVaishnavites => "HVA",
                CodeReligion.Jain => "JAI",
                CodeReligion.JewishConservative => "JCO",
                CodeReligion.Jewish => "JEW",
                CodeReligion.JewishOrthodox => "JOR",
                CodeReligion.JewishOther => "JOT",
                CodeReligion.JewishReconstructionist => "JRC",
                CodeReligion.JewishReform => "JRF",
                CodeReligion.JewishRenewal => "JRN",
                CodeReligion.ChristianJehovahsWitness => "JWN",
                CodeReligion.ChristianLutheranMissouriSynod => "LMS",
                CodeReligion.ChristianLutheran => "LUT",
                CodeReligion.ChristianMennonite => "MEN",
                CodeReligion.ChristianMethodist => "MET",
                CodeReligion.ChristianLatterDaySaints => "MOM",
                CodeReligion.Muslim => "MOS",
                CodeReligion.MuslimOther => "MOT",
                CodeReligion.MuslimShiite => "MSH",
                CodeReligion.MuslimSunni => "MSU",
                CodeReligion.NativeAmerican => "NAM",
                CodeReligion.ChristianChurchOfTheNazarene => "NAZ",
                CodeReligion.Nonreligious => "NOE",
                CodeReligion.NewReligionist => "NRL",
                CodeReligion.ChristianOrthodox => "ORT",
                CodeReligion.Other => "OTH",
                CodeReligion.ChristianPentecostal => "PEN",
                CodeReligion.ChristianOtherProtestant => "PRC",
                CodeReligion.ChristianPresbyterian => "PRE",
                CodeReligion.ChristianProtestant => "PRO",
                CodeReligion.ChristianReformedChurch => "REC",
                CodeReligion.ChristianReorganizedChurchOfJesusChristLds => "REO",
                CodeReligion.ChristianSalvationArmy => "SAA",
                CodeReligion.ChristianSeventhDayAdventist => "SEV",
                CodeReligion.Shintoist => "SHN",
                CodeReligion.Sikh => "SIK",
                CodeReligion.ChristianSouthernBaptist => "SOU",
                CodeReligion.Spiritist => "SPI",
                CodeReligion.ChristianUnitedChurchOfChrist => "UCC",
                CodeReligion.ChristianUnitedMethodist => "UMD",
                CodeReligion.ChristianUnitarian => "UNI",
                CodeReligion.ChristianUnitarianUniversalist => "UNU",
                CodeReligion.Unknown => "VAR",
                CodeReligion.ChristianWesleyan => "WES",
                CodeReligion.ChristianWesleyanMethodist => "WMC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReligion input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRemoteControlCommand enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRemoteControlCommand input)
        {
            return input switch
            {
                CodeRemoteControlCommand.Abort => "AB",
                CodeRemoteControlCommand.Clear => "CL",
                CodeRemoteControlCommand.ClearNotification => "CN",
                CodeRemoteControlCommand.DisableSendingEvents => "DI",
                CodeRemoteControlCommand.EnableSendingEvents => "EN",
                CodeRemoteControlCommand.EmergencyStop => "ES",
                CodeRemoteControlCommand.Execute => "EX",
                CodeRemoteControlCommand.Initialize => "IN",
                CodeRemoteControlCommand.LocalControlRequest => "LC",
                CodeRemoteControlCommand.Lock => "LK",
                CodeRemoteControlCommand.Load => "LO",
                CodeRemoteControlCommand.Pause => "PA",
                CodeRemoteControlCommand.RemoteControlRequest => "RC",
                CodeRemoteControlCommand.Resume => "RE",
                CodeRemoteControlCommand.Sampling => "SA",
                CodeRemoteControlCommand.Setup => "SU",
                CodeRemoteControlCommand.TransportTo => "TT",
                CodeRemoteControlCommand.Unlock => "UC",
                CodeRemoteControlCommand.Unload => "UN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRemoteControlCommand input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReorderTheoryCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReorderTheoryCodes input)
        {
            return input switch
            {
                CodeReorderTheoryCodes.DopDoq => "D",
                CodeReorderTheoryCodes.MinMax => "M",
                CodeReorderTheoryCodes.Override => "O",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReorderTheoryCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRepeatPattern enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRepeatPattern input)
        {
            return input switch
            {
                CodeRepeatPattern.AnteBefore => "A",
                CodeRepeatPattern.TwiceADay => "BID",
                CodeRepeatPattern.ServiceProvidedContinuouslyBetweenStartAndStopTime => "C",
                CodeRepeatPattern.CibusDiurnusLunch => "D",
                CodeRepeatPattern.Inter => "I",
                CodeRepeatPattern.CibusMatutinusBreakfast => "M",
                CodeRepeatPattern.TimingcCumMeal => "Meal Related Timings",
                CodeRepeatPattern.OneTimeOnly => "Once",
                CodeRepeatPattern.PostAfter => "P",
                CodeRepeatPattern.GivenAsNeeded => "PRN",
                CodeRepeatPattern.WhereXxxIsSomeFrequencyCode => "PRNxxx",
                CodeRepeatPattern.EveryIntegerDays => "QintegerD",
                CodeRepeatPattern.EveryIntegerHours => "QintegerH",
                CodeRepeatPattern.RepeatsOnParticularDayOfTheWeek => "QintegerJday#",
                CodeRepeatPattern.EveryIntegerMonthsLunarCycle => "QintegerL",
                CodeRepeatPattern.EveryIntegerMinutes => "QintegerM",
                CodeRepeatPattern.EveryIntegerSeconds => "QintegerS",
                CodeRepeatPattern.EveryIntegerWeeks => "QintegerW",
                CodeRepeatPattern.InTheMorning => "QAM",
                CodeRepeatPattern.EveryDayBeforeTheHourOfSleep => "QHS",
                CodeRepeatPattern.FourTimesDay => "QID",
                CodeRepeatPattern.EveryOtherDay => "QOD",
                CodeRepeatPattern.InTheEvening => "QPM",
                CodeRepeatPattern.DuringEachOfThreeEightHourShifts => "QSHIFT",
                CodeRepeatPattern.ThreeTimesADay => "TID",
                CodeRepeatPattern.UnixCron => "U spec",
                CodeRepeatPattern.CibusVespertinusDinner => "V",
                CodeRepeatPattern.XTimesPerDay => "xID",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRepeatPattern input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReportingPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReportingPriority input)
        {
            return input switch
            {
                CodeReportingPriority.CallBackResults => "C",
                CodeReportingPriority.RushReporting => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReportingPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReportSource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReportSource input)
        {
            return input switch
            {
                CodeReportSource.ClinicalTrial => "C",
                CodeReportSource.DatabaseRegistryPoisonControlCenter => "D",
                CodeReportSource.Distributor => "E",
                CodeReportSource.HealthProfessional => "H",
                CodeReportSource.Literature => "L",
                CodeReportSource.ManufacturerMarketingAuthorityHolder => "M",
                CodeReportSource.NonHealthcareProfessional => "N",
                CodeReportSource.Other => "O",
                CodeReportSource.Patient => "P",
                CodeReportSource.RegulatoryAgency => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReportSource input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReportTiming enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReportTiming input)
        {
            return input switch
            {
                CodeReportTiming.TenDayReport => "10D",
                CodeReportTiming.FifteenDayReport => "15D",
                CodeReportTiming.ThirtyDayReport => "30D",
                CodeReportTiming.ThreeDayReport => "3D",
                CodeReportTiming.SevenDayReport => "7D",
                CodeReportTiming.AdditionalInformation => "AD",
                CodeReportTiming.Correction => "CO",
                CodeReportTiming.DeviceEvaluation => "DE",
                CodeReportTiming.Periodic => "PD",
                CodeReportTiming.RequestedInformation => "RQ",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReportTiming input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeResponseFlag enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeResponseFlag input)
        {
            return input switch
            {
                CodeResponseFlag.AlsoOtherAssociatedSegments => "D",
                CodeResponseFlag.ReportExceptionsOnly => "E",
                CodeResponseFlag.PlusConfirmationsExplicitly => "F",
                CodeResponseFlag.OnlyMsaSegmentIsReturned => "N",
                CodeResponseFlag.ReplacementAndParentChild => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeResponseFlag input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeResponseLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeResponseLevel input)
        {
            return input switch
            {
                CodeResponseLevel.Always => "AL",
                CodeResponseLevel.ErrorReject => "ER",
                CodeResponseLevel.Never => "NE",
                CodeResponseLevel.Success => "SU",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeResponseLevel input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeResponseModality enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeResponseModality input)
        {
            return input switch
            {
                CodeResponseModality.Batch => "B",
                CodeResponseModality.RealTime => "R",
                CodeResponseModality.Bolus => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeResponseModality input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeResultStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeResultStatus input)
        {
            return input switch
            {
                CodeResultStatus.SomeResultsAvailable => "A",
                CodeResultStatus.CorrectedFinal => "C",
                CodeResultStatus.FinalResults => "F",
                CodeResultStatus.NoResultsAvailableSpecimenReceivedProcedureIncomplete => "I",
                CodeResultStatus.OrderReceivedSpecimenNotYetReceived => "O",
                CodeResultStatus.Preliminary => "P",
                CodeResultStatus.ResultsStoredNotYetVerified => "R",
                CodeResultStatus.NoResultsAvailableProcedureScheduledButNotDone => "S",
                CodeResultStatus.NoResultsAvailableOrderCanceled => "X",
                CodeResultStatus.NoOrderOnRecordForThisTest => "Y",
                CodeResultStatus.NoRecordOfThisPatient => "Z",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeResultStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRevenueCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRevenueCode input)
        {
            return input switch
            {
                CodeRevenueCode.NoSuggestedValuesDefined => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRevenueCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRiskCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRiskCodes input)
        {
            return input switch
            {
                CodeRiskCodes.Aggressive => "AGG",
                CodeRiskCodes.Biohazard => "BHZ",
                CodeRiskCodes.Biological => "BIO",
                CodeRiskCodes.Corrosive => "COR",
                CodeRiskCodes.EscapeRisk => "ESC",
                CodeRiskCodes.Explosive => "EXP",
                CodeRiskCodes.Materialdangerinflammable => "IFL",
                CodeRiskCodes.Materialdangerinfectious => "INF",
                CodeRiskCodes.InjuryHazard => "INJ",
                CodeRiskCodes.Poison => "POI",
                CodeRiskCodes.Radioactive => "RAD",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRiskCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRiskManagementIncidentCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRiskManagementIncidentCode input)
        {
            return input switch
            {
                CodeRiskManagementIncidentCode.BodyFluidExposure => "B",
                CodeRiskManagementIncidentCode.ContaminatedSubstance => "C",
                CodeRiskManagementIncidentCode.DietErrors => "D",
                CodeRiskManagementIncidentCode.EquipmentProblem => "E",
                CodeRiskManagementIncidentCode.PatientFellNotFromBed => "F",
                CodeRiskManagementIncidentCode.PatientFellFromBed => "H",
                CodeRiskManagementIncidentCode.InfusionError => "I",
                CodeRiskManagementIncidentCode.ForeignObjectLeftDuringSurgery => "J",
                CodeRiskManagementIncidentCode.SterilePrecautionViolated => "K",
                CodeRiskManagementIncidentCode.Other => "O",
                CodeRiskManagementIncidentCode.ProcedureError => "P",
                CodeRiskManagementIncidentCode.PharmaceuticalError => "R",
                CodeRiskManagementIncidentCode.SuicideAttempt => "S",
                CodeRiskManagementIncidentCode.TransfusionError => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRiskManagementIncidentCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRoleExecutingPhysician enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRoleExecutingPhysician input)
        {
            return input switch
            {
                CodeRoleExecutingPhysician.Both => "B",
                CodeRoleExecutingPhysician.ProfessionalPart => "P",
                CodeRoleExecutingPhysician.TechnicalPart => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRoleExecutingPhysician input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRoomType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRoomType input)
        {
            return input switch
            {
                CodeRoomType.SecondIntensiveCareUnit => "2ICU",
                CodeRoomType.SecondPrivateRoom => "2PRI",
                CodeRoomType.SecondSemiPrivateRoom => "2SPR",
                CodeRoomType.IntensiveCareUnit => "ICU",
                CodeRoomType.PrivateRoom => "PRI",
                CodeRoomType.SemiPrivateRoom => "SPR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRoomType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRouteOfAdministration enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRouteOfAdministration input)
        {
            return input switch
            {
                CodeRouteOfAdministration.ApplyExternally => "AP",
                CodeRouteOfAdministration.Buccal => "B",
                CodeRouteOfAdministration.Dental => "DT",
                CodeRouteOfAdministration.Epidural => "EP",
                CodeRouteOfAdministration.EndotrachialTube => "ET",
                CodeRouteOfAdministration.GastrostomyTube => "GTT",
                CodeRouteOfAdministration.GuIrrigant => "GU",
                CodeRouteOfAdministration.IntraArterial => "IA",
                CodeRouteOfAdministration.Intrabursal => "IB",
                CodeRouteOfAdministration.Intracardiac => "IC",
                CodeRouteOfAdministration.Intracervical => "ICV",
                CodeRouteOfAdministration.Intradermal => "ID",
                CodeRouteOfAdministration.Inhalation => "IH",
                CodeRouteOfAdministration.IntrahepaticArtery => "IHA",
                CodeRouteOfAdministration.Intramuscular => "IM",
                CodeRouteOfAdministration.ImmerseBodyPart => "IMR",
                CodeRouteOfAdministration.Intranasal => "IN",
                CodeRouteOfAdministration.Intraocular => "IO",
                CodeRouteOfAdministration.Intraperitoneal => "IP",
                CodeRouteOfAdministration.Intrasynovial => "IS",
                CodeRouteOfAdministration.Intrathecal => "IT",
                CodeRouteOfAdministration.Intrauterine => "IU",
                CodeRouteOfAdministration.Intravenous => "IV",
                CodeRouteOfAdministration.MucousMembrane => "MM",
                CodeRouteOfAdministration.MouthThroat => "MTH",
                CodeRouteOfAdministration.Nasogastric => "NG",
                CodeRouteOfAdministration.NasalProngs => "NP",
                CodeRouteOfAdministration.Nasal => "NS",
                CodeRouteOfAdministration.NasotrachialTube => "NT",
                CodeRouteOfAdministration.Ophthalmic => "OP",
                CodeRouteOfAdministration.Otic => "OT",
                CodeRouteOfAdministration.OtherMiscellaneous => "OTH",
                CodeRouteOfAdministration.Perfusion => "PF",
                CodeRouteOfAdministration.Oral => "PO",
                CodeRouteOfAdministration.Rectal => "PR",
                CodeRouteOfAdministration.RebreatherMask => "RM",
                CodeRouteOfAdministration.Subcutaneous => "SC",
                CodeRouteOfAdministration.SoakedDressing => "SD",
                CodeRouteOfAdministration.Sublingual => "SL",
                CodeRouteOfAdministration.Transdermal => "TD",
                CodeRouteOfAdministration.Translingual => "TL",
                CodeRouteOfAdministration.Topical => "TP",
                CodeRouteOfAdministration.Tracheostomy => "TRA",
                CodeRouteOfAdministration.Urethral => "UR",
                CodeRouteOfAdministration.Vaginal => "VG",
                CodeRouteOfAdministration.Ventimask => "VM",
                CodeRouteOfAdministration.Wound => "WND",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRouteOfAdministration input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRulingAct enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRulingAct input)
        {
            return input switch
            {
                CodeRulingAct.SafeMedicalDevicesAct => "SMDA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRulingAct input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRXComponentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRXComponentType input)
        {
            return input switch
            {
                CodeRXComponentType.Additive => "A",
                CodeRXComponentType.Base => "B",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRXComponentType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSchoolType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSchoolType input)
        {
            return input switch
            {
                CodeSchoolType.Dental => "D",
                CodeSchoolType.Graduate => "G",
                CodeSchoolType.Medical => "M",
                CodeSchoolType.Undergraduate => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSchoolType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSecurityCheckScheme enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSecurityCheckScheme input)
        {
            return input switch
            {
                CodeSecurityCheckScheme.BankCardValidationNumber => "BCV",
                CodeSecurityCheckScheme.CreditCardSecurityCode => "CCS",
                CodeSecurityCheckScheme.VersionId => "VID",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSecurityCheckScheme input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSegmentActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSegmentActionCode input)
        {
            return input switch
            {
                CodeSegmentActionCode.AddInsert => "A",
                CodeSegmentActionCode.Delete => "D",
                CodeSegmentActionCode.Update => "U",
                CodeSegmentActionCode.NoChange => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSegmentActionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSegmentGroup enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSegmentGroup input)
        {
            return input switch
            {
                CodeSegmentGroup.Administration => "ADMINISTRATION",
                CodeSegmentGroup.Allergy => "ALLERGY",
                CodeSegmentGroup.AppStats => "APP_STATS",
                CodeSegmentGroup.AppStatus => "APP_STATUS",
                CodeSegmentGroup.AssociatedPerson => "ASSOCIATED_PERSON",
                CodeSegmentGroup.AssociatedRxAdmin => "ASSOCIATED_RX_ADMIN",
                CodeSegmentGroup.AssociatedRxOrder => "ASSOCIATED_RX_ORDER",
                CodeSegmentGroup.Authorization => "AUTHORIZATION",
                CodeSegmentGroup.AuthorizationContact => "AUTHORIZATION_CONTACT",
                CodeSegmentGroup.Certificate => "CERTIFICATE",
                CodeSegmentGroup.Clock => "CLOCK",
                CodeSegmentGroup.ClockAndStatistics => "CLOCK_AND_STATISTICS",
                CodeSegmentGroup.ClockAndStatsWithNote => "CLOCK_AND_STATS_WITH_NOTE",
                CodeSegmentGroup.ClockAndStatsWithNotes => "CLOCK_AND_STATS_WITH_NOTES",
                CodeSegmentGroup.ClockAndStatsWithNotesAlt => "CLOCK_AND_STATS_WITH_NOTES_ALT",
                CodeSegmentGroup.Command => "COMMAND",
                CodeSegmentGroup.CommandResponse => "COMMAND_RESPONSE",
                CodeSegmentGroup.CommonOrder => "COMMON_ORDER",
                CodeSegmentGroup.Component => "COMPONENT",
                CodeSegmentGroup.Components => "COMPONENTS",
                CodeSegmentGroup.Container => "CONTAINER",
                CodeSegmentGroup.Definition => "DEFINITION",
                CodeSegmentGroup.Diet => "DIET",
                CodeSegmentGroup.Dispense => "DISPENSE",
                CodeSegmentGroup.EncodedOrder => "ENCODED_ORDER",
                CodeSegmentGroup.Encoding => "ENCODING",
                CodeSegmentGroup.Experience => "EXPERIENCE",
                CodeSegmentGroup.Financial => "FINANCIAL",
                CodeSegmentGroup.FinancialCommonOrder => "FINANCIAL_COMMON_ORDER",
                CodeSegmentGroup.FinancialInsurance => "FINANCIAL_INSURANCE",
                CodeSegmentGroup.FinancialObservation => "FINANCIAL_OBSERVATION",
                CodeSegmentGroup.FinancialOrder => "FINANCIAL_ORDER",
                CodeSegmentGroup.FinancialProcedure => "FINANCIAL_PROCEDURE",
                CodeSegmentGroup.FinancialTimingQuantity => "FINANCIAL_TIMING_QUANTITY",
                CodeSegmentGroup.GeneralResource => "GENERAL_RESOURCE",
                CodeSegmentGroup.Give => "GIVE",
                CodeSegmentGroup.Goal => "GOAL",
                CodeSegmentGroup.GoalObservation => "GOAL_OBSERVATION",
                CodeSegmentGroup.GoalPathway => "GOAL_PATHWAY",
                CodeSegmentGroup.GoalRole => "GOAL_ROLE",
                CodeSegmentGroup.GuarantorInsurance => "GUARANTOR_INSURANCE",
                CodeSegmentGroup.Insurance => "INSURANCE",
                CodeSegmentGroup.LocationResource => "LOCATION_RESOURCE",
                CodeSegmentGroup.MergeInfo => "MERGE_INFO",
                CodeSegmentGroup.Mf => "MF",
                CodeSegmentGroup.MfCdm => "MF_CDM",
                CodeSegmentGroup.MfClinStudy => "MF_CLIN_STUDY",
                CodeSegmentGroup.MfClinStudySched => "MF_CLIN_STUDY_SCHED",
                CodeSegmentGroup.MfInvItem => "MF_INV_ITEM",
                CodeSegmentGroup.MfLocation => "MF_LOCATION",
                CodeSegmentGroup.MfLocDept => "MF_LOC_DEPT",
                CodeSegmentGroup.MfObsAttributes => "MF_OBS_ATTRIBUTES",
                CodeSegmentGroup.MfPhaseSchedDetail => "MF_PHASE_SCHED_DETAIL",
                CodeSegmentGroup.MfQuery => "MF_QUERY",
                CodeSegmentGroup.MfSiteDefined => "MF_SITE_DEFINED",
                CodeSegmentGroup.MfStaff => "MF_STAFF",
                CodeSegmentGroup.MfTest => "MF_TEST",
                CodeSegmentGroup.MfTestBatteries => "MF_TEST_BATTERIES",
                CodeSegmentGroup.MfTestBattDetail => "MF_TEST_BATT_DETAIL",
                CodeSegmentGroup.MfTestCalculated => "MF_TEST_CALCULATED",
                CodeSegmentGroup.MfTestCalcDetail => "MF_TEST_CALC_DETAIL",
                CodeSegmentGroup.MfTestCategorical => "MF_TEST_CATEGORICAL",
                CodeSegmentGroup.MfTestCatDetail => "MF_TEST_CAT_DETAIL",
                CodeSegmentGroup.MfTestNumeric => "MF_TEST_NUMERIC",
                CodeSegmentGroup.Nk1TimingQty => "NK1_TIMING_QTY",
                CodeSegmentGroup.Notification => "NOTIFICATION",
                CodeSegmentGroup.Observation => "OBSERVATION",
                CodeSegmentGroup.ObservationPrior => "OBSERVATION_PRIOR",
                CodeSegmentGroup.ObservationRequest => "OBSERVATION_REQUEST",
                CodeSegmentGroup.Omservation => "OMSERVATION",
                CodeSegmentGroup.Order => "ORDER",
                CodeSegmentGroup.OrderChoice => "ORDER_CHOICE",
                CodeSegmentGroup.OrderDetail => "ORDER_DETAIL",
                CodeSegmentGroup.OrderDetailSupplement => "ORDER_DETAIL_SUPPLEMENT",
                CodeSegmentGroup.OrderDiet => "ORDER_DIET",
                CodeSegmentGroup.OrderEncoded => "ORDER_ENCODED",
                CodeSegmentGroup.OrderObservation => "ORDER_OBSERVATION",
                CodeSegmentGroup.OrderPrior => "ORDER_PRIOR",
                CodeSegmentGroup.OrderTray => "ORDER_TRAY",
                CodeSegmentGroup.Pathway => "PATHWAY",
                CodeSegmentGroup.PathwayRole => "PATHWAY_ROLE",
                CodeSegmentGroup.Patient => "PATIENT",
                CodeSegmentGroup.PatientPrior => "PATIENT_PRIOR",
                CodeSegmentGroup.PatientResult => "PATIENT_RESULT",
                CodeSegmentGroup.PatientVisit => "PATIENT_VISIT",
                CodeSegmentGroup.PatientVisitPrior => "PATIENT_VISIT_PRIOR",
                CodeSegmentGroup.PersonnelResource => "PERSONNEL_RESOURCE",
                CodeSegmentGroup.PexCause => "PEX_CAUSE",
                CodeSegmentGroup.PexObservation => "PEX_OBSERVATION",
                CodeSegmentGroup.PriorResult => "PRIOR_RESULT",
                CodeSegmentGroup.Problem => "PROBLEM",
                CodeSegmentGroup.ProblemObservation => "PROBLEM_OBSERVATION",
                CodeSegmentGroup.ProblemPathway => "PROBLEM_PATHWAY",
                CodeSegmentGroup.ProblemRole => "PROBLEM_ROLE",
                CodeSegmentGroup.Procedure => "PROCEDURE",
                CodeSegmentGroup.Product => "PRODUCT",
                CodeSegmentGroup.ProductStatus => "PRODUCT_STATUS",
                CodeSegmentGroup.Provider => "PROVIDER",
                CodeSegmentGroup.ProviderContact => "PROVIDER_CONTACT",
                CodeSegmentGroup.Qbp => "QBP",
                CodeSegmentGroup.QryWithDetail => "QRY_WITH_DETAIL",
                CodeSegmentGroup.QueryResponse => "QUERY_RESPONSE",
                CodeSegmentGroup.QueryResultCluster => "QUERY_RESULT_CLUSTER",
                CodeSegmentGroup.Request => "REQUEST",
                CodeSegmentGroup.Resource => "RESOURCE",
                CodeSegmentGroup.Resources => "RESOURCES",
                CodeSegmentGroup.Response => "RESPONSE",
                CodeSegmentGroup.Result => "RESULT",
                CodeSegmentGroup.Results => "RESULTS",
                CodeSegmentGroup.ResultsNotes => "RESULTS_NOTES",
                CodeSegmentGroup.RowDefinition => "ROW_DEFINITION",
                CodeSegmentGroup.RxAdministration => "RX_ADMINISTRATION",
                CodeSegmentGroup.RxOrder => "RX_ORDER",
                CodeSegmentGroup.Schedule => "SCHEDULE",
                CodeSegmentGroup.Service => "SERVICE",
                CodeSegmentGroup.Specimen => "SPECIMEN",
                CodeSegmentGroup.SpecimenContainer => "SPECIMEN_CONTAINER",
                CodeSegmentGroup.Staff => "STAFF",
                CodeSegmentGroup.Study => "STUDY",
                CodeSegmentGroup.StudyObservation => "STUDY_OBSERVATION",
                CodeSegmentGroup.StudyPhase => "STUDY_PHASE",
                CodeSegmentGroup.StudySchedule => "STUDY_SCHEDULE",
                CodeSegmentGroup.TestConfiguration => "TEST_CONFIGURATION",
                CodeSegmentGroup.Timing => "TIMING",
                CodeSegmentGroup.TimingDiet => "TIMING_DIET",
                CodeSegmentGroup.TimingEncoded => "TIMING_ENCODED",
                CodeSegmentGroup.TimingGive => "TIMING_GIVE",
                CodeSegmentGroup.TimingPrior => "TIMING_PRIOR",
                CodeSegmentGroup.TimingQty => "TIMING_QTY",
                CodeSegmentGroup.TimingQuantity => "TIMING_QUANTITY",
                CodeSegmentGroup.TimingTray => "TIMING_TRAY",
                CodeSegmentGroup.Treatment => "TREATMENT",
                CodeSegmentGroup.Visit => "VISIT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSegmentGroup input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSensitivityToCausativeAgentCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSensitivityToCausativeAgentCode input)
        {
            return input switch
            {
                CodeSensitivityToCausativeAgentCode.AdverseReaction => "AD",
                CodeSensitivityToCausativeAgentCode.Allergy => "AL",
                CodeSensitivityToCausativeAgentCode.Contraindication => "CT",
                CodeSensitivityToCausativeAgentCode.Intolerance => "IN",
                CodeSensitivityToCausativeAgentCode.SideEffect => "SE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSensitivityToCausativeAgentCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSequenceConditionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSequenceConditionCode input)
        {
            return input switch
            {
                CodeSequenceConditionCode.EndRelatedEndCurrent => "EE",
                CodeSequenceConditionCode.EndRelatedStartCurrent => "ES",
                CodeSequenceConditionCode.StartRelatedEndCurrent => "SE",
                CodeSequenceConditionCode.StartRelatedStartCurrent => "SS",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSequenceConditionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSequenceResultsFlag enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSequenceResultsFlag input)
        {
            return input switch
            {
                CodeSequenceResultsFlag.Cyclical => "C",
                CodeSequenceResultsFlag.ReservedForFutureUse => "R",
                CodeSequenceResultsFlag.Sequential => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSequenceResultsFlag input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSequencing enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSequencing input)
        {
            return input switch
            {
                CodeSequencing.Ascending => "A",
                CodeSequencing.AscendingCaseInsensitive => "AN",
                CodeSequencing.Descending => "D",
                CodeSequencing.DescendingCaseInsensitive => "DN",
                CodeSequencing.None => "N",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSequencing input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeServiceRequestRelationship enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeServiceRequestRelationship input)
        {
            return input switch
            {
                CodeServiceRequestRelationship.Compound => "C",
                CodeServiceRequestRelationship.Exclusive => "E",
                CodeServiceRequestRelationship.NursePrerogative => "N",
                CodeServiceRequestRelationship.Simultaneous => "S",
                CodeServiceRequestRelationship.Tapering => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeServiceRequestRelationship input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSeverityOfIllnessCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSeverityOfIllnessCode input)
        {
            return input switch
            {
                CodeSeverityOfIllnessCode.Mild => "MI",
                CodeSeverityOfIllnessCode.Moderate => "MO",
                CodeSeverityOfIllnessCode.Severe => "SE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSeverityOfIllnessCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeShipmentStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeShipmentStatus input)
        {
            return input switch
            {
                CodeShipmentStatus.Inventoried => "INV",
                CodeShipmentStatus.OnHold => "ONH",
                CodeShipmentStatus.Processing => "PRC",
                CodeShipmentStatus.Rejected => "REJ",
                CodeShipmentStatus.InTransit => "TRN",
                CodeShipmentStatus.TriagedToLab => "TTL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeShipmentStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSideOfBody enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSideOfBody input)
        {
            return input switch
            {
                CodeSideOfBody.Left => "L",
                CodeSideOfBody.Right => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSideOfBody input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSignatorysRelationshipToSubject enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSignatorysRelationshipToSubject input)
        {
            return input switch
            {
                CodeSignatorysRelationshipToSubject.Self => "1",
                CodeSignatorysRelationshipToSubject.Parent => "2",
                CodeSignatorysRelationshipToSubject.NextOfKin => "3",
                CodeSignatorysRelationshipToSubject.DurablePowerOfAttorneyInHealthcareAffairs => "4",
                CodeSignatorysRelationshipToSubject.Conservator => "5",
                CodeSignatorysRelationshipToSubject.EmergentPractitioner => "6",
                CodeSignatorysRelationshipToSubject.NonEmergentPractitioner => "7",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSignatorysRelationshipToSubject input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSignatureCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSignatureCode input)
        {
            return input switch
            {
                CodeSignatureCode.SignedCms1500ClaimFormOnFile => "C",
                CodeSignatureCode.SignedAuthorizationForAssignmentOfBenefitsOnFile => "M",
                CodeSignatureCode.SignatureGeneratedByProvider => "P",
                CodeSignatureCode.SignedAuthorizationForReleaseOfAnyMedicalOrOtherInfoOnFile => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSignatureCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSourceOfComment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSourceOfComment input)
        {
            return input switch
            {
                CodeSourceOfComment.AncillaryDepartmentIsSourceOfComment => "L",
                CodeSourceOfComment.OtherSystemIsSourceOfComment => "O",
                CodeSourceOfComment.OrdererIsSourceOfComment => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSourceOfComment input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSourceType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSourceType input)
        {
            return input switch
            {
                CodeSourceType.Accept => "A",
                CodeSourceType.Initiate => "I",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSourceType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecialHandlingCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecialHandlingCode input)
        {
            return input switch
            {
                CodeSpecialHandlingCode.AmbientTemperature => "AMB",
                CodeSpecialHandlingCode.BodyTemperature => "C37",
                CodeSpecialHandlingCode.CriticalAmbientTemperature => "CAMB",
                CodeSpecialHandlingCode.ProtectFromAir => "CATM",
                CodeSpecialHandlingCode.CriticalFrozenTemperature => "CFRZ",
                CodeSpecialHandlingCode.CriticalRefrigeratedTemperature => "CREF",
                CodeSpecialHandlingCode.DeepFrozen => "DFRZ",
                CodeSpecialHandlingCode.Dry => "DRY",
                CodeSpecialHandlingCode.FrozenTemperature => "FRZ",
                CodeSpecialHandlingCode.MetalFree => "MTLF",
                CodeSpecialHandlingCode.LiquidNitrogen => "NTR",
                CodeSpecialHandlingCode.ProtectFromLight => "PRTL",
                CodeSpecialHandlingCode.DoNotShake => "PSA",
                CodeSpecialHandlingCode.NoShock => "PSO",
                CodeSpecialHandlingCode.RefrigeratedTemperature => "REF",
                CodeSpecialHandlingCode.UltraFrozen => "UFRZ",
                CodeSpecialHandlingCode.Upright => "UPR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecialHandlingCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecialProgramCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecialProgramCode input)
        {
            return input switch
            {
                CodeSpecialProgramCode.ChildHealthAssistance => "CH",
                CodeSpecialProgramCode.ElectiveSurgeryProgram => "ES",
                CodeSpecialProgramCode.FamilyPlanning => "FP",
                CodeSpecialProgramCode.Other => "O",
                CodeSpecialProgramCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecialProgramCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecialtyType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecialtyType input)
        {
            return input switch
            {
                CodeSpecialtyType.Allergy => "ALC",
                CodeSpecialtyType.Ambulatory => "AMB",
                CodeSpecialtyType.Cancer => "CAN",
                CodeSpecialtyType.CoronaryCardiacCare => "CAR",
                CodeSpecialtyType.CriticalCare => "CCR",
                CodeSpecialtyType.Chiropractic => "CHI",
                CodeSpecialtyType.Education => "EDI",
                CodeSpecialtyType.Emergency => "EMR",
                CodeSpecialtyType.FamilyPlanning => "FPC",
                CodeSpecialtyType.IntensiveCare => "INT",
                CodeSpecialtyType.Isolation => "ISO",
                CodeSpecialtyType.Naturopathic => "NAT",
                CodeSpecialtyType.NewbornNurseryInfants => "NBI",
                CodeSpecialtyType.ObstetricsGynecology => "OBG",
                CodeSpecialtyType.Observation => "OBS",
                CodeSpecialtyType.OtherSpecialty => "OTH",
                CodeSpecialtyType.Pediatrics => "PED",
                CodeSpecialtyType.GeneralFamilyPractice => "PHY",
                CodeSpecialtyType.PediatricNeonatalIntensiveCare => "PIN",
                CodeSpecialtyType.PediatricPsychiatric => "PPS",
                CodeSpecialtyType.PediatricRehabilitation => "PRE",
                CodeSpecialtyType.PsychiatricIntensiveCare => "PSI",
                CodeSpecialtyType.Psychiatric => "PSY",
                CodeSpecialtyType.Rehabilitation => "REH",
                CodeSpecialtyType.Surgery => "SUR",
                CodeSpecialtyType.WalkInClinic => "WIC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecialtyType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecimenActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecimenActionCode input)
        {
            return input switch
            {
                CodeSpecimenActionCode.AddOrderedTestsToExistingSpecimen => "A",
                CodeSpecimenActionCode.GeneratedOrderReflexOrder => "G",
                CodeSpecimenActionCode.LabToObtainSpecimenFromPatient => "L",
                CodeSpecimenActionCode.SpecimenObtainedByServiceOtherThanLab => "O",
                CodeSpecimenActionCode.PendingSpecimenOrderSentPriorToDelivery => "P",
                CodeSpecimenActionCode.RevisedOrder => "R",
                CodeSpecimenActionCode.ScheduleTheTestsSpecifiedBelow => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecimenActionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecimenAppropriateness enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecimenAppropriateness input)
        {
            return input switch
            {
                CodeSpecimenAppropriateness.InappropriateDueTo => "??",
                CodeSpecimenAppropriateness.Appropriate => "A",
                CodeSpecimenAppropriateness.Inappropriate => "I",
                CodeSpecimenAppropriateness.Preferred => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecimenAppropriateness input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecimenChildRole enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecimenChildRole input)
        {
            return input switch
            {
                CodeSpecimenChildRole.Aliquot => "A",
                CodeSpecimenChildRole.Component => "C",
                CodeSpecimenChildRole.ModifiedFromOriginalSpecimen => "M",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecimenChildRole input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecimenCollectionMethod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecimenCollectionMethod input)
        {
            return input switch
            {
                CodeSpecimenCollectionMethod.PlatesAnaerobic => "ANP",
                CodeSpecimenCollectionMethod.PlatesBloodAgar => "BAP",
                CodeSpecimenCollectionMethod.BloodCultureAerobicBottle => "BCAE",
                CodeSpecimenCollectionMethod.BloodCultureAnaerobicBottle => "BCAN",
                CodeSpecimenCollectionMethod.BloodCulturePediatricBottle => "BCPD",
                CodeSpecimenCollectionMethod.Biopsy => "BIO",
                CodeSpecimenCollectionMethod.CapillarySpecimen => "CAP",
                CodeSpecimenCollectionMethod.Catheterized => "CATH",
                CodeSpecimenCollectionMethod.LineCvp => "CVP",
                CodeSpecimenCollectionMethod.EnvironmentalPlate => "EPLA",
                CodeSpecimenCollectionMethod.EnvironmentalSwab => "ESWA",
                CodeSpecimenCollectionMethod.AspirationFineNeedle => "FNA",
                CodeSpecimenCollectionMethod.PlateCough => "KOFFP",
                CodeSpecimenCollectionMethod.LineArterial => "LNA",
                CodeSpecimenCollectionMethod.LineVenous => "LNV",
                CodeSpecimenCollectionMethod.MartinLewisAgar => "MARTL",
                CodeSpecimenCollectionMethod.ModMartinLewisAgar => "ML11",
                CodeSpecimenCollectionMethod.PlateMartinLewis => "MLP",
                CodeSpecimenCollectionMethod.PlateNewYorkCity => "NYP",
                CodeSpecimenCollectionMethod.PaceGenProbe => "PACE",
                CodeSpecimenCollectionMethod.PinwormPrep => "PIN",
                CodeSpecimenCollectionMethod.ArterialPuncture => "PNA",
                CodeSpecimenCollectionMethod.PumpPrime => "PRIME",
                CodeSpecimenCollectionMethod.PumpSpecimen => "PUMP",
                CodeSpecimenCollectionMethod.QualityControlForMicro => "QC5",
                CodeSpecimenCollectionMethod.ScalpFetalVein => "SCLP",
                CodeSpecimenCollectionMethod.Scrapings => "SCRAPS",
                CodeSpecimenCollectionMethod.Shaving => "SHA",
                CodeSpecimenCollectionMethod.Swab => "SWA",
                CodeSpecimenCollectionMethod.SwabDacronTipped => "SWD",
                CodeSpecimenCollectionMethod.TransportMediaAnaerobic => "TMAN",
                CodeSpecimenCollectionMethod.TransportMediaChalamydia => "TMCH",
                CodeSpecimenCollectionMethod.TransportMediaM4 => "TMM4",
                CodeSpecimenCollectionMethod.TransportMediaMycoplasma => "TMMY",
                CodeSpecimenCollectionMethod.TransportMedia => "TMOT",
                CodeSpecimenCollectionMethod.PlateThayerMartin => "TMP",
                CodeSpecimenCollectionMethod.TransportMediaPva => "TMPV",
                CodeSpecimenCollectionMethod.TransportMediaStoolCulture => "TMSC",
                CodeSpecimenCollectionMethod.TransportMediaUreaplasma => "TMUP",
                CodeSpecimenCollectionMethod.TransportMediaViral => "TMVI",
                CodeSpecimenCollectionMethod.Venipuncture => "VENIP",
                CodeSpecimenCollectionMethod.SwabWoodenShaft => "WOOD",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecimenCollectionMethod input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecimenComponent enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecimenComponent input)
        {
            return input switch
            {
                CodeSpecimenComponent.WholeBloodHomogeneous => "BLD",
                CodeSpecimenComponent.WholeBloodSeparated => "BSEP",
                CodeSpecimenComponent.Plasma => "PLAS",
                CodeSpecimenComponent.PlateletPoorPlasma => "PPP",
                CodeSpecimenComponent.PlateletRichPlasma => "PRP",
                CodeSpecimenComponent.Sediment => "SED",
                CodeSpecimenComponent.SerumNosNotOtherwiseSpecified => "SER",
                CodeSpecimenComponent.Supernatant => "SUP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecimenComponent input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecimenCondition enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecimenCondition input)
        {
            return input switch
            {
                CodeSpecimenCondition.Autolyzed => "AUT",
                CodeSpecimenCondition.Clotted => "CLOT",
                CodeSpecimenCondition.Contaminated => "CON",
                CodeSpecimenCondition.Cool => "COOL",
                CodeSpecimenCondition.Frozen => "FROZ",
                CodeSpecimenCondition.Hemolyzed => "HEM",
                CodeSpecimenCondition.Live => "LIVE",
                CodeSpecimenCondition.RoomTemperature => "ROOM",
                CodeSpecimenCondition.SampleNotReceived => "SNR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecimenCondition input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecimenQuality enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecimenQuality input)
        {
            return input switch
            {
                CodeSpecimenQuality.Excellent => "E",
                CodeSpecimenQuality.Fair => "F",
                CodeSpecimenQuality.Good => "G",
                CodeSpecimenQuality.Poor => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecimenQuality input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecimenRejectReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecimenRejectReason input)
        {
            return input switch
            {
                CodeSpecimenRejectReason.Expired => "EX",
                CodeSpecimenRejectReason.QuantityNotSufficient => "QS",
                CodeSpecimenRejectReason.MissingPatientIdNumber => "RA",
                CodeSpecimenRejectReason.BrokenContainer => "RB",
                CodeSpecimenRejectReason.Clotting => "RC",
                CodeSpecimenRejectReason.MissingCollectionDate => "RD",
                CodeSpecimenRejectReason.MissingPatientName => "RE",
                CodeSpecimenRejectReason.Hemolysis => "RH",
                CodeSpecimenRejectReason.IdentificationProblem => "RI",
                CodeSpecimenRejectReason.Labeling => "RM",
                CodeSpecimenRejectReason.Contamination => "RN",
                CodeSpecimenRejectReason.MissingPhlebotomistId => "RP",
                CodeSpecimenRejectReason.ImproperStorage => "RR",
                CodeSpecimenRejectReason.NameMisspelling => "RS",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecimenRejectReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecimenRole enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecimenRole input)
        {
            return input switch
            {
                CodeSpecimenRole.BlindSample => "B",
                CodeSpecimenRole.Calibrator => "C",
                CodeSpecimenRole.ElectronicQc => "E",
                CodeSpecimenRole.SpecimenUsedForTestingProficiency => "F",
                CodeSpecimenRole.Group => "G",
                CodeSpecimenRole.Pool => "L",
                CodeSpecimenRole.SpecimenUsedForTestingOperatorProficiency => "O",
                CodeSpecimenRole.Patient => "P",
                CodeSpecimenRole.ControlSpecimen => "Q",
                CodeSpecimenRole.Replicate => "R",
                CodeSpecimenRole.VerifyingCalibrator => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecimenRole input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecimenType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecimenType input)
        {
            return input switch
            {
                CodeSpecimenType.Abscess => "ABS",
                CodeSpecimenType.TissueAcne => "ACNE",
                CodeSpecimenType.FluidAcne => "ACNFLD",
                CodeSpecimenType.AirSample => "AIRS",
                CodeSpecimenType.Allograft => "ALL",
                CodeSpecimenType.Amputation => "AMP",
                CodeSpecimenType.CatheterTipAngio => "ANGI",
                CodeSpecimenType.CatheterTipArterial => "ARTC",
                CodeSpecimenType.SerumAcute => "ASERU",
                CodeSpecimenType.Aspirate => "ASP",
                CodeSpecimenType.EnvironmentAttest => "ATTE",
                CodeSpecimenType.EnvironmentalAutoclaveAmpule => "AUTOA",
                CodeSpecimenType.EnvironmentalAutoclaveCapsule => "AUTOC",
                CodeSpecimenType.Autopsy => "AUTP",
                CodeSpecimenType.BloodBag => "BBL",
                CodeSpecimenType.CystBakers => "BCYST",
                CodeSpecimenType.Bite => "BITE",
                CodeSpecimenType.Bleb => "BLEB",
                CodeSpecimenType.Blister => "BLIST",
                CodeSpecimenType.Boil => "BOIL",
                CodeSpecimenType.Bone => "BON",
                CodeSpecimenType.BowelContents => "BOWL",
                CodeSpecimenType.BloodProductUnit => "BPU",
                CodeSpecimenType.Burn => "BRN",
                CodeSpecimenType.Brush => "BRSH",
                CodeSpecimenType.BreathUseExhld => "BRTH",
                CodeSpecimenType.Brushing => "BRUS",
                CodeSpecimenType.Bubo => "BUB",
                CodeSpecimenType.BullaBullae => "BULLA",
                CodeSpecimenType.Biopsy => "BX",
                CodeSpecimenType.CalculusStone => "CALC",
                CodeSpecimenType.Carbuncle => "CARBU",
                CodeSpecimenType.Catheter => "CAT",
                CodeSpecimenType.BiteCat => "CBITE",
                CodeSpecimenType.Clippings => "CLIPP",
                CodeSpecimenType.Conjunctiva => "CNJT",
                CodeSpecimenType.Colostrum => "COL",
                CodeSpecimenType.BiospyCone => "CONE",
                CodeSpecimenType.ScratchCat => "CSCR",
                CodeSpecimenType.SerumConvalescent => "CSERU",
                CodeSpecimenType.CatheterInsertionSite => "CSITE",
                CodeSpecimenType.FluidCystostomyTube => "CSMY",
                CodeSpecimenType.FluidCyst => "CST",
                CodeSpecimenType.BloodCellSaver => "CSVR",
                CodeSpecimenType.CatheterTip => "CTP",
                CodeSpecimenType.SiteCvp => "CVPS",
                CodeSpecimenType.CatheterTipCvp => "CVPT",
                CodeSpecimenType.NoduleCystic => "CYN",
                CodeSpecimenType.Cyst => "CYST",
                CodeSpecimenType.BiteDog => "DBITE",
                CodeSpecimenType.SputumDeepCough => "DCS",
                CodeSpecimenType.UlcerDecubitus => "DEC",
                CodeSpecimenType.EnvironmentalWaterDeionized => "DEION",
                CodeSpecimenType.Dialysate => "DIA",
                CodeSpecimenType.Discharge => "DISCHG",
                CodeSpecimenType.Diverticulum => "DIV",
                CodeSpecimenType.Drain => "DRN",
                CodeSpecimenType.DrainageTube => "DRNG",
                CodeSpecimenType.DrainagePenrose => "DRNGP",
                CodeSpecimenType.EarWaxCerumen => "EARW",
                CodeSpecimenType.BrushEsophageal => "EBRUSH",
                CodeSpecimenType.EnvironmentalEyeWash => "EEYE",
                CodeSpecimenType.EnvironmentalEffluent => "EFF",
                CodeSpecimenType.Effusion => "EFFUS",
                CodeSpecimenType.EnvironmentalFood => "EFOD",
                CodeSpecimenType.EnvironmentalIsolette => "EISO",
                CodeSpecimenType.Electrode => "ELT",
                CodeSpecimenType.EnvironmentalUnidentifiedSubstance => "ENVIR",
                CodeSpecimenType.EnvironmentalOtherSubstance => "EOTH",
                CodeSpecimenType.EnvironmentalSoil => "ESOI",
                CodeSpecimenType.EnvironmentalSolutionSterile => "ESOS",
                CodeSpecimenType.AspirateEndotrach => "ETA",
                CodeSpecimenType.CatheterTipEndotracheal => "ETTP",
                CodeSpecimenType.TubeEndotracheal => "ETTUB",
                CodeSpecimenType.EnvironmentalWhirlpool => "EWHI",
                CodeSpecimenType.GasExhaledBreath => "EXG",
                CodeSpecimenType.ShuntExternal => "EXS",
                CodeSpecimenType.Exudate => "EXUDTE",
                CodeSpecimenType.EnvironmentalWaterWell => "FAW",
                CodeSpecimenType.BloodFetal => "FBLOOD",
                CodeSpecimenType.FluidAbdomen => "FGA",
                CodeSpecimenType.Fistula => "FIST",
                CodeSpecimenType.FluidOther => "FLD",
                CodeSpecimenType.Filter => "FLT",
                CodeSpecimenType.FluidBodyUnsp => "FLU",
                CodeSpecimenType.Fluid => "FLUID",
                CodeSpecimenType.CatheterTipFoley => "FOLEY",
                CodeSpecimenType.FluidRespiratory => "FRS",
                CodeSpecimenType.ScalpFetal => "FSCLP",
                CodeSpecimenType.Furuncle => "FUR",
                CodeSpecimenType.Gas => "GAS",
                CodeSpecimenType.AspirateGastric => "GASA",
                CodeSpecimenType.AntrumGastric => "GASAN",
                CodeSpecimenType.BrushingGastric => "GASBR",
                CodeSpecimenType.DrainageGastric => "GASD",
                CodeSpecimenType.FluidContentsGastric => "GAST",
                CodeSpecimenType.GenitalVaginal => "GENV",
                CodeSpecimenType.Graft => "GRAFT",
                CodeSpecimenType.GraftSite => "GRAFTS",
                CodeSpecimenType.Granuloma => "GRANU",
                CodeSpecimenType.CatheterGroshong => "GROSH",
                CodeSpecimenType.SolutionGastrostomy => "GSOL",
                CodeSpecimenType.BiopsyGastric => "GSPEC",
                CodeSpecimenType.TubeGastric => "GT",
                CodeSpecimenType.DrainageTubeDrainageGastrostomy => "GTUBE",
                CodeSpecimenType.BiteHuman => "HBITE",
                CodeSpecimenType.BloodAutopsy => "HBLUD",
                CodeSpecimenType.CatheterTipHemaquit => "HEMAQ",
                CodeSpecimenType.CatheterTipHemovac => "HEMO",
                CodeSpecimenType.TissueHerniated => "HERNI",
                CodeSpecimenType.DrainHemovac => "HEV",
                CodeSpecimenType.CatheterHickman => "HIC",
                CodeSpecimenType.FluidHydrocele => "HYDC",
                CodeSpecimenType.BiteInsect => "IBITE",
                CodeSpecimenType.CystInclusion => "ICYST",
                CodeSpecimenType.CatheterTipIndwelling => "IDC",
                CodeSpecimenType.GasInhaled => "IHG",
                CodeSpecimenType.DrainageIleostomy => "ILEO",
                CodeSpecimenType.SourceOfSpecimenIsIllegible => "ILLEG",
                CodeSpecimenType.Implant => "IMP",
                CodeSpecimenType.SiteIncisionSurgical => "INCI",
                CodeSpecimenType.Infiltrate => "INFIL",
                CodeSpecimenType.Insect => "INS",
                CodeSpecimenType.CatheterTipIntroducer => "INTRD",
                CodeSpecimenType.IntubationTube => "IT",
                CodeSpecimenType.IntrauterineDevice => "IUD",
                CodeSpecimenType.CatheterTipIv => "IVCAT",
                CodeSpecimenType.FluidIv => "IVFLD",
                CodeSpecimenType.TubingTipIv => "IVTIP",
                CodeSpecimenType.DrainageJejunal => "JEJU",
                CodeSpecimenType.FluidJoint => "JNTFLD",
                CodeSpecimenType.DrainageJacksonPratt => "JP",
                CodeSpecimenType.Lavage => "KELOI",
                CodeSpecimenType.FluidKidney => "KIDFLD",
                CodeSpecimenType.LavageBronhial => "LAVG",
                CodeSpecimenType.LavageGastric => "LAVGG",
                CodeSpecimenType.LavagePeritoneal => "LAVGP",
                CodeSpecimenType.LavagePreBronch => "LAVPG",
                CodeSpecimenType.ContactLens => "LENS1",
                CodeSpecimenType.ContactLensCase => "LENS2",
                CodeSpecimenType.Lesion => "LESN",
                CodeSpecimenType.LiquidUnspecified => "LIQ",
                CodeSpecimenType.LiquidOther => "LIQO",
                CodeSpecimenType.FluidLumbarSac => "LSAC",
                CodeSpecimenType.CatheterTipMakurkour => "MAHUR",
                CodeSpecimenType.Mass => "MASS",
                CodeSpecimenType.BloodMenstrual => "MBLD",
                CodeSpecimenType.Mucosa => "MUCOS",
                CodeSpecimenType.Mucus => "MUCUS",
                CodeSpecimenType.DrainageNasal => "NASDR",
                CodeSpecimenType.Needle => "NEDL",
                CodeSpecimenType.SiteNephrostomy => "NEPH",
                CodeSpecimenType.AspirateNasogastric => "NGASP",
                CodeSpecimenType.DrainageNasogastric => "NGAST",
                CodeSpecimenType.SiteNasoGastric => "NGS",
                CodeSpecimenType.NoduleS => "NODUL",
                CodeSpecimenType.SecretionNasal => "NSECR",
                CodeSpecimenType.Other => "ORH",
                CodeSpecimenType.LesionOral => "ORL",
                CodeSpecimenType.SourceOther => "OTH",
                CodeSpecimenType.Pacemaker => "PACEM",
                CodeSpecimenType.FluidPericardial => "PCFL",
                CodeSpecimenType.SitePeritonealDialysis => "PDSIT",
                CodeSpecimenType.SitePeritonealDialysisTunnel => "PDTS",
                CodeSpecimenType.AbscessPelvic => "PELVA",
                CodeSpecimenType.LesionPenile => "PENIL",
                CodeSpecimenType.AbscessPerianal => "PERIA",
                CodeSpecimenType.CystPilonidal => "PILOC",
                CodeSpecimenType.SitePin => "PINS",
                CodeSpecimenType.SitePacemakerInsetion => "PIS",
                CodeSpecimenType.PlantMaterial => "PLAN",
                CodeSpecimenType.Plasma => "PLAS",
                CodeSpecimenType.PlasmaBag => "PLB",
                CodeSpecimenType.SerumPeakLevel => "PLEVS",
                CodeSpecimenType.DrainagePenile => "PND",
                CodeSpecimenType.Polyps => "POL",
                CodeSpecimenType.GraftSitePopliteal => "POPGS",
                CodeSpecimenType.GraftPopliteal => "POPLG",
                CodeSpecimenType.SitePoplitealVein => "POPLV",
                CodeSpecimenType.CatheterPorta => "PORTA",
                CodeSpecimenType.PlasmaPlateletPoor => "PPP",
                CodeSpecimenType.ProstheticDevice => "PROST",
                CodeSpecimenType.PlasmaPlateletRich => "PRP",
                CodeSpecimenType.Pseudocyst => "PSC",
                CodeSpecimenType.WoundPuncture => "PUNCT",
                CodeSpecimenType.Pus => "PUS",
                CodeSpecimenType.Pustule => "PUSFR",
                CodeSpecimenType.PusCondition => "PUST",
                CodeSpecimenType.QualityControl => "QC3",
                CodeSpecimenType.UrineRandom => "RANDU",
                CodeSpecimenType.BiteReptile => "RBITE",
                CodeSpecimenType.DrainageRectal => "RECT",
                CodeSpecimenType.AbscessRectal => "RECTA",
                CodeSpecimenType.CystRenal => "RENALC",
                CodeSpecimenType.FluidRenalCyst => "RENC",
                CodeSpecimenType.Respiratory => "RES",
                CodeSpecimenType.Saliva => "SAL",
                CodeSpecimenType.TissueKeloidScar => "SCAR",
                CodeSpecimenType.CatheterTipSubclavian => "SCLV",
                CodeSpecimenType.AbscessScrotal => "SCROA",
                CodeSpecimenType.SecretionS => "SECRE",
                CodeSpecimenType.Serum => "SER",
                CodeSpecimenType.SiteShunt => "SHU",
                CodeSpecimenType.FluidShunt => "SHUNF",
                CodeSpecimenType.Shunt => "SHUNT",
                CodeSpecimenType.Site => "SITE",
                CodeSpecimenType.BiopsySkin => "SKBP",
                CodeSpecimenType.Skin => "SKN",
                CodeSpecimenType.MassSubMandibular => "SMM",
                CodeSpecimenType.FluidSynovialJointFluid => "SNV",
                CodeSpecimenType.Spermatozoa => "SPRM",
                CodeSpecimenType.CatheterTipSuprapubic => "SPRP",
                CodeSpecimenType.CathetherTipSuprapubic => "SPRPB",
                CodeSpecimenType.EnvironmentalSporeStrip => "SPS",
                CodeSpecimenType.Sputum => "SPT",
                CodeSpecimenType.SputumCoughed => "SPTC",
                CodeSpecimenType.SputumTrachealAspirate => "SPTT",
                CodeSpecimenType.SputumSimulated => "SPUT1",
                CodeSpecimenType.SputumInducted => "SPUTIN",
                CodeSpecimenType.SputumSpontaneous => "SPUTSP",
                CodeSpecimenType.EnvironmentalSterrad => "STER",
                CodeSpecimenType.StoolFecal => "STL",
                CodeSpecimenType.StoneKidney => "STONE",
                CodeSpecimenType.AbscessSubmandibular => "SUBMA",
                CodeSpecimenType.AbscessSubmaxillary => "SUBMX",
                CodeSpecimenType.DrainageSump => "SUMP",
                CodeSpecimenType.SuprapubicTap => "SUP",
                CodeSpecimenType.Suture => "SUTUR",
                CodeSpecimenType.CatheterTipSwanGantz => "SWGZ",
                CodeSpecimenType.AspirateTracheal => "TASP",
                CodeSpecimenType.Tissue => "TISS",
                CodeSpecimenType.TissueUlcer => "TISU",
                CodeSpecimenType.CathetherTipTripleLumen => "TLC",
                CodeSpecimenType.SiteTracheostomy => "TRAC",
                CodeSpecimenType.Transudate => "TRANS",
                CodeSpecimenType.SerumTrough => "TSERU",
                CodeSpecimenType.AbscessTesticular => "TSTES",
                CodeSpecimenType.AspirateTranstracheal => "TTRA",
                CodeSpecimenType.Tubes => "TUBES",
                CodeSpecimenType.Tumor => "TUMOR",
                CodeSpecimenType.SmearTzanck => "TZANC",
                CodeSpecimenType.SourceUnidentified => "UDENT",
                CodeSpecimenType.Urine => "UR",
                CodeSpecimenType.UrineCleanCatch => "URC",
                CodeSpecimenType.UrineBladderWashings => "URINB",
                CodeSpecimenType.UrineCatheterized => "URINC",
                CodeSpecimenType.UrineMidstream => "URINM",
                CodeSpecimenType.UrineNephrostomy => "URINN",
                CodeSpecimenType.UrinePedibag => "URINP",
                CodeSpecimenType.UrineCatheter => "URT",
                CodeSpecimenType.UrineCystoscopy => "USCOP",
                CodeSpecimenType.SourceUnspecified => "USPEC",
                CodeSpecimenType.CatheterTipVas => "VASTIP",
                CodeSpecimenType.CatheterTipVentricular => "VENT",
                CodeSpecimenType.VitreousFluid => "VITF",
                CodeSpecimenType.Vomitus => "VOM",
                CodeSpecimenType.Wash => "WASH",
                CodeSpecimenType.WashingEGBronchialWashing => "WASI",
                CodeSpecimenType.Water => "WAT",
                CodeSpecimenType.BloodWhole => "WB",
                CodeSpecimenType.Wen => "WEN",
                CodeSpecimenType.Wick => "WICK",
                CodeSpecimenType.Wound => "WND",
                CodeSpecimenType.WoundAbscess => "WNDA",
                CodeSpecimenType.WoundDrainage => "WNDD",
                CodeSpecimenType.WoundExudate => "WNDE",
                CodeSpecimenType.Worm => "WORM",
                CodeSpecimenType.Wart => "WRT",
                CodeSpecimenType.EnvironmentalWater => "WWA",
                CodeSpecimenType.EnvironmentalWaterOcean => "WWO",
                CodeSpecimenType.EnvironmentalWaterTap => "WWT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecimenType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeStatusAdmission enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeStatusAdmission input)
        {
            return input switch
            {
                CodeStatusAdmission.AdmissionStatusIsValidUsedForGrouping => "0",
                CodeStatusAdmission.AdmissionStatusIsValidNotUsedForGrouping => "1",
                CodeStatusAdmission.AdmissionStatusIsInvalidNotUsedForGrouping => "2",
                CodeStatusAdmission.AdmissionStatusIsInvalidDefaultValueUsedForGrouping => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeStatusAdmission input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeStatusOfEvaluation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeStatusOfEvaluation input)
        {
            return input switch
            {
                CodeStatusOfEvaluation.EvaluationAnticipatedNotYetBegun => "A",
                CodeStatusOfEvaluation.ProductReceivedInConditionWhichMadeAnalysisImpossible => "C",
                CodeStatusOfEvaluation.ProductDiscardedNoFollowUp => "D",
                CodeStatusOfEvaluation.ProductRemainsImplantedNoFollowUp => "I",
                CodeStatusOfEvaluation.ProblemAlreadyKnownNoEvaluation => "K",
                CodeStatusOfEvaluation.Other => "O",
                CodeStatusOfEvaluation.EvaluationInProgress => "P",
                CodeStatusOfEvaluation.ProductUnderQuarantineNoFollowUp => "Q",
                CodeStatusOfEvaluation.ProductUnderRecall => "R",
                CodeStatusOfEvaluation.ProductUnavailableForFollowUp => "U",
                CodeStatusOfEvaluation.ProductNotMadeByCompany => "X",
                CodeStatusOfEvaluation.EvaluationCompleted => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeStatusOfEvaluation input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeStatusWeightAtBirth enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeStatusWeightAtBirth input)
        {
            return input switch
            {
                CodeStatusWeightAtBirth.NoWeightReportedAtAdmissionUsedForGrouping => "0",
                CodeStatusWeightAtBirth.WeightReportedAtAdmissionUsedForGrouping => "1",
                CodeStatusWeightAtBirth.DefaultWeight2499GUsedForGrouping => "2",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeStatusWeightAtBirth input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSterilizationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSterilizationType input)
        {
            return input switch
            {
                CodeSterilizationType.EthyleneOxideGas => "EOG",
                CodeSterilizationType.PeraceticAcid => "PCA",
                CodeSterilizationType.Steam => "STM",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSterilizationType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeStudentStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeStudentStatus input)
        {
            return input switch
            {
                CodeStudentStatus.FullTimeStudent => "F",
                CodeStudentStatus.NotAStudent => "N",
                CodeStudentStatus.PartTimeStudent => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeStudentStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSubstanceStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSubstanceStatus input)
        {
            return input switch
            {
                CodeSubstanceStatus.CalibrationError => "CE",
                CodeSubstanceStatus.CalibrationWarning => "CW",
                CodeSubstanceStatus.ExpiredError => "EE",
                CodeSubstanceStatus.ExpiredWarning => "EW",
                CodeSubstanceStatus.NotAvailableError => "NE",
                CodeSubstanceStatus.NotAvailableWarning => "NW",
                CodeSubstanceStatus.OtherError => "OE",
                CodeSubstanceStatus.OkStatus => "OK",
                CodeSubstanceStatus.OtherWarning => "OW",
                CodeSubstanceStatus.QcError => "QE",
                CodeSubstanceStatus.QcWarning => "QW",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSubstanceStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSubstanceType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSubstanceType input)
        {
            return input switch
            {
                CodeSubstanceType.ControlReagent => "CO",
                CodeSubstanceType.Diluent => "DI",
                CodeSubstanceType.MeasurableLiquidItem => "LI",
                CodeSubstanceType.LiquidWaste => "LW",
                CodeSubstanceType.MultipleTestReagent => "MR",
                CodeSubstanceType.Other => "OT",
                CodeSubstanceType.Pretreatment => "PT",
                CodeSubstanceType.PurifiedWater => "PW",
                CodeSubstanceType.ReagentCalibrator => "RC",
                CodeSubstanceType.CountableSolidItem => "SC",
                CodeSubstanceType.SingleTestReagent => "SR",
                CodeSubstanceType.SolidWaste => "SW",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSubstanceType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSubstitutionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSubstitutionStatus input)
        {
            return input switch
            {
                CodeSubstitutionStatus.NoProductSelectionIndicated => "0",
                CodeSubstitutionStatus.SubstitutionNotAllowedByPrescriber => "1",
                CodeSubstitutionStatus.SubstitutionAllowedPatientRequested => "2",
                CodeSubstitutionStatus.SubstitutionAllowedPharmacistSelected => "3",
                CodeSubstitutionStatus.SubstitutionAllowedGenericDrugNotInStock => "4",
                CodeSubstitutionStatus.SubstitutionAllowedDispensedAsGeneric => "5",
                CodeSubstitutionStatus.SubstitutionNotAllowedBrandMandatedByLaw => "7",
                CodeSubstitutionStatus.SubstitutionAllowedGenericNotAvailable => "8",
                CodeSubstitutionStatus.AGenericSubstitutionWasDispensed => "G",
                CodeSubstitutionStatus.NoSubstituteWasDispensed => "N",
                CodeSubstitutionStatus.TherapeuticSubstitutionWasDispensed => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSubstitutionStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSubtypeOfReferencedData enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSubtypeOfReferencedData input)
        {
            return input switch
            {
                CodeSubtypeOfReferencedData.SourceRfc2046ADeprecated => "...",
                CodeSubtypeOfReferencedData.IsdnPcmAudioData => "BASIC",
                CodeSubtypeOfReferencedData.DigitalImagingAndCommunicationsInMedicine => "DICOM",
                CodeSubtypeOfReferencedData.FacsimileData => "FAX",
                CodeSubtypeOfReferencedData.GraphicsInterchangeFormat => "GIF",
                CodeSubtypeOfReferencedData.HypertextMarkupLanguage => "HTML",
                CodeSubtypeOfReferencedData.ElectronicInkDataJot10Standard => "JOT",
                CodeSubtypeOfReferencedData.JointPhotographicExpertsGroup => "JPEG",
                CodeSubtypeOfReferencedData.UninterpretedBinaryData => "Octet-stream",
                CodeSubtypeOfReferencedData.PictFormatImageData => "PICT",
                CodeSubtypeOfReferencedData.PostscriptProgram => "PostScript",
                CodeSubtypeOfReferencedData.RichTextFormat => "RTF",
                CodeSubtypeOfReferencedData.SgmlStandardGeneralizedMarkupLanguage => "SGML",
                CodeSubtypeOfReferencedData.TiffImageData => "TIFF",
                CodeSubtypeOfReferencedData.Hl7ClinicalDocumentArchitectureLevelOne => "x-hl7-cda-level-one",
                CodeSubtypeOfReferencedData.XmlExtensibleMarkupLanguage => "XML",
                CodeSubtypeOfReferencedData.SourceRfc2046BDeprecated => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSubtypeOfReferencedData input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSupplementalServiceInformationValues enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSupplementalServiceInformationValues input)
        {
            return input switch
            {
                CodeSupplementalServiceInformationValues.NoSuggestedValuesDefined => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSupplementalServiceInformationValues input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSupplyRiskCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSupplyRiskCodes input)
        {
            return input switch
            {
                CodeSupplyRiskCodes.Corrosive => "COR",
                CodeSupplyRiskCodes.Explosive => "EXP",
                CodeSupplyRiskCodes.Flammable => "FLA",
                CodeSupplyRiskCodes.InjuryHazard => "INJ",
                CodeSupplyRiskCodes.Radioactive => "RAD",
                CodeSupplyRiskCodes.Toxic => "TOX",
                CodeSupplyRiskCodes.Unknown => "UNK",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSupplyRiskCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSystemInducedContaminants enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSystemInducedContaminants input)
        {
            return input switch
            {
                CodeSystemInducedContaminants.PresentTypeOfContaminationUnspecified => "CNTM",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSystemInducedContaminants input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTaxStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTaxStatus input)
        {
            return input switch
            {
                CodeTaxStatus.RegisteredInVatRegister => "RVAT",
                CodeTaxStatus.UnregisteredInVatRegister => "UVAT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTaxStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTelecommunicationEquipmentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTelecommunicationEquipmentType input)
        {
            return input switch
            {
                CodeTelecommunicationEquipmentType.Beeper => "BP",
                CodeTelecommunicationEquipmentType.CellularOrMobilePhone => "CP",
                CodeTelecommunicationEquipmentType.Fax => "FX",
                CodeTelecommunicationEquipmentType.InternetAddress => "Internet",
                CodeTelecommunicationEquipmentType.Modem => "MD",
                CodeTelecommunicationEquipmentType.Telephone => "PH",
                CodeTelecommunicationEquipmentType.SatellitePhone => "SAT",
                CodeTelecommunicationEquipmentType.TelecommunicationsDeviceForTheDeaf => "TDD",
                CodeTelecommunicationEquipmentType.Teletypewriter => "TTY",
                CodeTelecommunicationEquipmentType.X400EmailAddress => "X.400",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTelecommunicationEquipmentType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTelecommunicationExpirationReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTelecommunicationExpirationReason input)
        {
            return input switch
            {
                CodeTelecommunicationExpirationReason.Corrected => "C",
                CodeTelecommunicationExpirationReason.AddedInError => "E",
                CodeTelecommunicationExpirationReason.Moved => "M",
                CodeTelecommunicationExpirationReason.NoLongerInService => "N",
                CodeTelecommunicationExpirationReason.OnRequest => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTelecommunicationExpirationReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTelecommunicationUseCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTelecommunicationUseCode input)
        {
            return input switch
            {
                CodeTelecommunicationUseCode.AnsweringServiceNumber => "ASN",
                CodeTelecommunicationUseCode.BeeperNumber => "BPN",
                CodeTelecommunicationUseCode.EmergencyNumber => "EMR",
                CodeTelecommunicationUseCode.NetworkEmailAddress => "NET",
                CodeTelecommunicationUseCode.OtherResidenceNumber => "ORN",
                CodeTelecommunicationUseCode.PrimaryResidenceNumber => "PRN",
                CodeTelecommunicationUseCode.Personal => "PRS",
                CodeTelecommunicationUseCode.VacationHomeNumber => "VHN",
                CodeTelecommunicationUseCode.WorkNumber => "WPN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTelecommunicationUseCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTimeDelayPostChallenge enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTimeDelayPostChallenge input)
        {
            return input switch
            {
                CodeTimeDelayPostChallenge.TenDays => "10D",
                CodeTimeDelayPostChallenge.TenMinutesPostChallenge => "10M",
                CodeTimeDelayPostChallenge.TwelveHoursPostChallenge => "12H",
                CodeTimeDelayPostChallenge.FifteenMinutesPostChallenge => "15M",
                CodeTimeDelayPostChallenge.OneHourPostChallenge => "1H",
                CodeTimeDelayPostChallenge.OneMonthPostChallenge => "1L",
                CodeTimeDelayPostChallenge.OneMinutePostChallenge => "1M",
                CodeTimeDelayPostChallenge.OneWeek => "1W",
                CodeTimeDelayPostChallenge.TwoAndAHalfHoursPostChallenge => "2.5H",
                CodeTimeDelayPostChallenge.TwentyMinutesPostChallenge => "20M",
                CodeTimeDelayPostChallenge.TwentyFourHoursPostChallenge => "24H",
                CodeTimeDelayPostChallenge.TwentyFiveMinutesPostChallenge => "25M",
                CodeTimeDelayPostChallenge.TwoDays => "2D",
                CodeTimeDelayPostChallenge.TwoHoursPostChallenge => "2H",
                CodeTimeDelayPostChallenge.TwoMonthsPostChallenge => "2L",
                CodeTimeDelayPostChallenge.TwoMinutesPostChallenge => "2M",
                CodeTimeDelayPostChallenge.TwoWeeks => "2W",
                CodeTimeDelayPostChallenge.ThirtyMinutesPostChallenge => "30M",
                CodeTimeDelayPostChallenge.ThreeDays => "3D",
                CodeTimeDelayPostChallenge.ThreeHoursPostChallenge => "3H",
                CodeTimeDelayPostChallenge.ThreeMonthsPostChallenge => "3L",
                CodeTimeDelayPostChallenge.ThreeMinutesPostChallenge => "3M",
                CodeTimeDelayPostChallenge.ThreeWeeks => "3W",
                CodeTimeDelayPostChallenge.FourDays => "4D",
                CodeTimeDelayPostChallenge.FourHoursPostChallenge => "4H",
                CodeTimeDelayPostChallenge.FourMinutesPostChallenge => "4M",
                CodeTimeDelayPostChallenge.FourWeeks => "4W",
                CodeTimeDelayPostChallenge.FiveDays => "5D",
                CodeTimeDelayPostChallenge.FiveHoursPostChallenge => "5H",
                CodeTimeDelayPostChallenge.FiveMinutesPostChallenge => "5M",
                CodeTimeDelayPostChallenge.SixDays => "6D",
                CodeTimeDelayPostChallenge.SixHoursPostChallenge => "6H",
                CodeTimeDelayPostChallenge.SixMinutesPostChallenge => "6M",
                CodeTimeDelayPostChallenge.SevenDays => "7D",
                CodeTimeDelayPostChallenge.SevenHoursPostChallenge => "7H",
                CodeTimeDelayPostChallenge.SevenMinutesPostChallenge => "7M",
                CodeTimeDelayPostChallenge.EightHoursPostChallenge => "8H",
                CodeTimeDelayPostChallenge.EightHoursAlignedOnNursingShifts => "8H SHIFT",
                CodeTimeDelayPostChallenge.EightMinutesPostChallenge => "8M",
                CodeTimeDelayPostChallenge.NineMinutesPostChallenge => "9M",
                CodeTimeDelayPostChallenge.Baseline => "BS",
                CodeTimeDelayPostChallenge.TimePostDrugDoseHighestDrugLevelReached => "PEAK",
                CodeTimeDelayPostChallenge.TimeFromChallengeOrDoseNotSpecified => "RANDOM",
                CodeTimeDelayPostChallenge.TimePostDrugDoseLowestDrugLevelReached => "TROUGH",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTimeDelayPostChallenge input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTimeSelectionCriteriaParameterClassCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTimeSelectionCriteriaParameterClassCodes input)
        {
            return input switch
            {
                CodeTimeSelectionCriteriaParameterClassCodes.Friday => "Fri",
                CodeTimeSelectionCriteriaParameterClassCodes.Monday => "Mon",
                CodeTimeSelectionCriteriaParameterClassCodes.IsPreferredEndTime => "Prefend",
                CodeTimeSelectionCriteriaParameterClassCodes.IsPreferredStartTime => "Prefstart",
                CodeTimeSelectionCriteriaParameterClassCodes.Saturday => "Sat",
                CodeTimeSelectionCriteriaParameterClassCodes.Sunday => "Sun",
                CodeTimeSelectionCriteriaParameterClassCodes.Thursday => "Thu",
                CodeTimeSelectionCriteriaParameterClassCodes.Tuesday => "Tue",
                CodeTimeSelectionCriteriaParameterClassCodes.Wednesday => "Wed",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTimeSelectionCriteriaParameterClassCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTissueTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTissueTypeCode input)
        {
            return input switch
            {
                CodeTissueTypeCode.NoTissueExpected => "0",
                CodeTissueTypeCode.InsufficientTissue => "1",
                CodeTissueTypeCode.NotAbnormal => "2",
                CodeTissueTypeCode.AbnormalNotCategorized => "3",
                CodeTissueTypeCode.MechanicalAbnormal => "4",
                CodeTissueTypeCode.GrowthAlteration => "5",
                CodeTissueTypeCode.DegenerationNecrosis => "6",
                CodeTissueTypeCode.NonAcuteInflammation => "7",
                CodeTissueTypeCode.NonMalignantNeoplasm => "8",
                CodeTissueTypeCode.MalignantNeoplasm => "9",
                CodeTissueTypeCode.BasalCellCarcinoma => "B",
                CodeTissueTypeCode.CarcinomaUnspecifiedType => "C",
                CodeTissueTypeCode.AdditionalTissueRequired => "G",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTissueTypeCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTqConjunctionId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTqConjunctionId input)
        {
            return input switch
            {
                CodeTqConjunctionId.Asynchronous => "A",
                CodeTqConjunctionId.ActuationTime => "C",
                CodeTqConjunctionId.Synchronous => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTqConjunctionId input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTransactionType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTransactionType input)
        {
            return input switch
            {
                CodeTransactionType.Adjustment => "AJ",
                CodeTransactionType.Credit => "CD",
                CodeTransactionType.Charge => "CG",
                CodeTransactionType.CoPayment => "CO",
                CodeTransactionType.Payment => "PY",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTransactionType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTransferType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTransferType input)
        {
            return input switch
            {
                CodeTransferType.DrgExempt => "E",
                CodeTransferType.DrgNonExempt => "N",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTransferType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTransfusionAdverseReaction enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTransfusionAdverseReaction input)
        {
            return input switch
            {
                CodeTransfusionAdverseReaction.AboIncompatibleTransfusionReaction => "ABOINC",
                CodeTransfusionAdverseReaction.AcuteHemolyticTransfusionReaction => "ACUTHEHTR",
                CodeTransfusionAdverseReaction.AllergicReactionFirst => "ALLERGIC1",
                CodeTransfusionAdverseReaction.AllergicReactionRecurrent => "ALLERGIC2",
                CodeTransfusionAdverseReaction.AllergicReactionRepeating => "ALLERGICR",
                CodeTransfusionAdverseReaction.AnaphylacticReaction => "ANAPHYLAC",
                CodeTransfusionAdverseReaction.ReactionToBacterialContamination => "BACTCONTAM",
                CodeTransfusionAdverseReaction.DelayedHemolyticTransfusionReaction => "DELAYEDHTR",
                CodeTransfusionAdverseReaction.DelayedSerologicalTransfusionReaction => "DELAYEDSTR",
                CodeTransfusionAdverseReaction.GraftVsHostDiseaseTransfusionAssociated => "GVHD",
                CodeTransfusionAdverseReaction.NonHemolyticHypotensiveReaction => "HYPOTENS",
                CodeTransfusionAdverseReaction.NonHemolyticFeverChillTransfusionReactionFirst => "NONHTR1",
                CodeTransfusionAdverseReaction.NonHemolyticFeverChillTransfusionReactionRecurrent => "NONHTR2",
                CodeTransfusionAdverseReaction.NonHemolyticFeverChillTransfusionReactionRepeating => "NONHTRREC",
                CodeTransfusionAdverseReaction.NonImmuneHemolysis => "NONIMMUNE",
                CodeTransfusionAdverseReaction.NonSpecificNonHemolyticTransfusionReaction => "NONSPEC",
                CodeTransfusionAdverseReaction.NoEvidenceOfTransfusionReaction => "NORXN",
                CodeTransfusionAdverseReaction.PosttransfusionPurpura => "PTP",
                CodeTransfusionAdverseReaction.SymptomsMostLikelyDueToVolumeOverload => "VOLOVER",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTransfusionAdverseReaction input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTransportArranged enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTransportArranged input)
        {
            return input switch
            {
                CodeTransportArranged.Arranged => "A",
                CodeTransportArranged.NotArranged => "N",
                CodeTransportArranged.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTransportArranged input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTransportationMode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTransportationMode input)
        {
            return input switch
            {
                CodeTransportationMode.CartPatientTravelsOnCartOrGurney => "CART",
                CodeTransportationMode.TheExaminingDeviceGoesToPatientsLocation => "PORT",
                CodeTransportationMode.PatientWalksToDiagnosticService => "WALK",
                CodeTransportationMode.Wheelchair => "WHLC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTransportationMode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTrayType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTrayType input)
        {
            return input switch
            {
                CodeTrayType.EarlyTray => "EARLY",
                CodeTrayType.GuestTray => "GUEST",
                CodeTrayType.LateTray => "LATE",
                CodeTrayType.TrayMessageOnly => "MSG",
                CodeTrayType.NoTray => "NO",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTrayType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTreatment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTreatment input)
        {
            return input switch
            {
                CodeTreatment.Acidification => "ACID",
                CodeTreatment.Alkalization => "ALK",
                CodeTreatment.Defibrination => "DEFB",
                CodeTreatment.Filtration => "FILT",
                CodeTreatment.LdlPrecipitation => "LDLP",
                CodeTreatment.Neutralization => "NEUT",
                CodeTreatment.Recalification => "RECA",
                CodeTreatment.Ultrafiltration => "UFIL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTreatment input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTriageCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTriageCode input)
        {
            return input switch
            {
                CodeTriageCode.NonAcute => "1",
                CodeTriageCode.Acute => "2",
                CodeTriageCode.Urgent => "3",
                CodeTriageCode.Severe => "4",
                CodeTriageCode.DeadOnArrivalDoa => "5",
                CodeTriageCode.Other => "99",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTriageCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTypeOfAgreement enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTypeOfAgreement input)
        {
            return input switch
            {
                CodeTypeOfAgreement.Maternity => "M",
                CodeTypeOfAgreement.Standard => "S",
                CodeTypeOfAgreement.Unified => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTypeOfAgreement input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTypeOfBillCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTypeOfBillCode input)
        {
            return input switch
            {
                CodeTypeOfBillCode.NoSuggestedValuesDefined => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTypeOfBillCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTypeOfReferencedData enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTypeOfReferencedData input)
        {
            return input switch
            {
                CodeTypeOfReferencedData.OtherApplicationData => "AP",
                CodeTypeOfReferencedData.AudioData => "AU",
                CodeTypeOfReferencedData.FormattedText => "FT",
                CodeTypeOfReferencedData.ImageData => "IM",
                CodeTypeOfReferencedData.MimeMultipartPackage => "multipart",
                CodeTypeOfReferencedData.NonScannedImage => "NS",
                CodeTypeOfReferencedData.ScannedDocument => "SD",
                CodeTypeOfReferencedData.ScannedImage => "SI",
                CodeTypeOfReferencedData.MachineReadableTextDocument => "TEXT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTypeOfReferencedData input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeUniversalIdType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeUniversalIdType input)
        {
            return input switch
            {
                CodeUniversalIdType.ClinicalLaboratoryImprovementAmendments => "CLIA",
                CodeUniversalIdType.ClinicalLaboratoryImprovementProgram => "CLIP",
                CodeUniversalIdType.DomainNameSystem => "DNS",
                CodeUniversalIdType.Ieee64BitExtendedUniqueIdentifier => "EUI64",
                CodeUniversalIdType.GloballyUniqueIdentifier => "GUID",
                CodeUniversalIdType.CenHealthcareCodingIdentifier => "HCD",
                CodeUniversalIdType.Hl7RegistrationSchemes => "HL7",
                CodeUniversalIdType.IsoObjectIdentifier => "ISO",
                CodeUniversalIdType.LocalL => "L",
                CodeUniversalIdType.LocalLMN => "L,M,N",
                CodeUniversalIdType.LocalM => "M",
                CodeUniversalIdType.LocalN => "N",
                CodeUniversalIdType.Random => "Random",
                CodeUniversalIdType.UniformResourceIdentifier => "URI",
                CodeUniversalIdType.UniversalUniqueIdentifier => "UUID",
                CodeUniversalIdType.X400MhsIdentifier => "x400",
                CodeUniversalIdType.X500DirectoryName => "x500",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeUniversalIdType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeUserAuthenticationCredentialTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeUserAuthenticationCredentialTypeCode input)
        {
            return input switch
            {
                CodeUserAuthenticationCredentialTypeCode.KerberosServiceTicket => "KERB",
                CodeUserAuthenticationCredentialTypeCode.AuthenticatedUserIdentityAssertion => "SAML",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeUserAuthenticationCredentialTypeCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeVaccinesAdministered enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeVaccinesAdministered input)
        {
            return input switch
            {
                CodeVaccinesAdministered.Dtp => "01",
                CodeVaccinesAdministered.Opv => "02",
                CodeVaccinesAdministered.Mmr => "03",
                CodeVaccinesAdministered.MR => "04",
                CodeVaccinesAdministered.Measles => "05",
                CodeVaccinesAdministered.Rubella => "06",
                CodeVaccinesAdministered.Mumps => "07",
                CodeVaccinesAdministered.HepBAdolescentOrPediatric => "08",
                CodeVaccinesAdministered.TdAdult09 => "09",
                CodeVaccinesAdministered.Ipv => "10",
                CodeVaccinesAdministered.PneumococcalConjugate => "100",
                CodeVaccinesAdministered.TyphoidVicps => "101",
                CodeVaccinesAdministered.DtpHibHepB => "102",
                CodeVaccinesAdministered.MeningococcalCConjugate => "103",
                CodeVaccinesAdministered.HepAHepB => "104",
                CodeVaccinesAdministered.VacciniaSmallpoxDiluted => "105",
                CodeVaccinesAdministered.Dtap5PertussisAntigens6 => "106",
                CodeVaccinesAdministered.DtapNos => "107",
                CodeVaccinesAdministered.MeningococcalNos => "108",
                CodeVaccinesAdministered.PneumococcalNos => "109",
                CodeVaccinesAdministered.Pertussis => "11",
                CodeVaccinesAdministered.DtapHepBIpv => "110",
                CodeVaccinesAdministered.InfluenzaLiveIntranasal => "111",
                CodeVaccinesAdministered.TetanusToxoidNos => "112",
                CodeVaccinesAdministered.TdAdult113 => "113",
                CodeVaccinesAdministered.MeningococcalACYW135DiphtheriaConjugate => "114",
                CodeVaccinesAdministered.Tdap => "115",
                CodeVaccinesAdministered.RotavirusPentavalent => "116",
                CodeVaccinesAdministered.VzigInd => "117",
                CodeVaccinesAdministered.HpvBivalent => "118",
                CodeVaccinesAdministered.RotavirusMonovalent => "119",
                CodeVaccinesAdministered.DiphtheriaAntitoxin => "12",
                CodeVaccinesAdministered.DtapHibIpv => "120",
                CodeVaccinesAdministered.Zoster => "121",
                CodeVaccinesAdministered.RotavirusNos1 => "122",
                CodeVaccinesAdministered.Tig => "13",
                CodeVaccinesAdministered.IgNos => "14",
                CodeVaccinesAdministered.InfluenzaSplitInclPurifiedSurfaceAntigen => "15",
                CodeVaccinesAdministered.InfluenzaWhole => "16",
                CodeVaccinesAdministered.HibNos => "17",
                CodeVaccinesAdministered.RabiesIntramuscularInjection => "18",
                CodeVaccinesAdministered.Bcg => "19",
                CodeVaccinesAdministered.Dtap => "20",
                CodeVaccinesAdministered.Varicella => "21",
                CodeVaccinesAdministered.DtpHib => "22",
                CodeVaccinesAdministered.Plague => "23",
                CodeVaccinesAdministered.Anthrax => "24",
                CodeVaccinesAdministered.TyphoidOral => "25",
                CodeVaccinesAdministered.Cholera => "26",
                CodeVaccinesAdministered.BotulinumAntitoxin => "27",
                CodeVaccinesAdministered.DtPediatric => "28",
                CodeVaccinesAdministered.Cmvig => "29",
                CodeVaccinesAdministered.Hbig => "30",
                CodeVaccinesAdministered.HepAPediatricNos => "31",
                CodeVaccinesAdministered.Meningococcal => "32",
                CodeVaccinesAdministered.Pneumococcal => "33",
                CodeVaccinesAdministered.Rig => "34",
                CodeVaccinesAdministered.TetanusToxoid => "35",
                CodeVaccinesAdministered.Vzig => "36",
                CodeVaccinesAdministered.YellowFever => "37",
                CodeVaccinesAdministered.RubellaMumps => "38",
                CodeVaccinesAdministered.JapaneseEncephalitis => "39",
                CodeVaccinesAdministered.RabiesIntradermalInjection => "40",
                CodeVaccinesAdministered.TyphoidParenteral => "41",
                CodeVaccinesAdministered.HepBAdolescentHighRiskInfant2 => "42",
                CodeVaccinesAdministered.HepBAdult4 => "43",
                CodeVaccinesAdministered.HepBDialysis => "44",
                CodeVaccinesAdministered.HepBNos => "45",
                CodeVaccinesAdministered.HibPrpD => "46",
                CodeVaccinesAdministered.HibHboc => "47",
                CodeVaccinesAdministered.HibPrpT => "48",
                CodeVaccinesAdministered.HibPrpOmp => "49",
                CodeVaccinesAdministered.DtapHib => "50",
                CodeVaccinesAdministered.HibHepB => "51",
                CodeVaccinesAdministered.HepAAdult => "52",
                CodeVaccinesAdministered.TyphoidParenteralAkdUSMilitary => "53",
                CodeVaccinesAdministered.AdenovirusType4 => "54",
                CodeVaccinesAdministered.AdenovirusType7 => "55",
                CodeVaccinesAdministered.DengueFever => "56",
                CodeVaccinesAdministered.Hantavirus => "57",
                CodeVaccinesAdministered.HepC => "58",
                CodeVaccinesAdministered.HepE => "59",
                CodeVaccinesAdministered.HerpesSimplex2 => "60",
                CodeVaccinesAdministered.Hiv => "61",
                CodeVaccinesAdministered.HpvQuadrivalent => "62",
                CodeVaccinesAdministered.JuninVirus => "63",
                CodeVaccinesAdministered.Leishmaniasis => "64",
                CodeVaccinesAdministered.Leprosy => "65",
                CodeVaccinesAdministered.LymeDisease => "66",
                CodeVaccinesAdministered.Malaria => "67",
                CodeVaccinesAdministered.Melanoma => "68",
                CodeVaccinesAdministered.Parainfluenza3 => "69",
                CodeVaccinesAdministered.QFever => "70",
                CodeVaccinesAdministered.RsvIgiv => "71",
                CodeVaccinesAdministered.RheumaticFever => "72",
                CodeVaccinesAdministered.RiftValleyFever => "73",
                CodeVaccinesAdministered.RotavirusTetravalent => "74",
                CodeVaccinesAdministered.VacciniaSmallpox => "75",
                CodeVaccinesAdministered.StaphylococcusBacterioLysate => "76",
                CodeVaccinesAdministered.TickBorneEncephalitis => "77",
                CodeVaccinesAdministered.TularemiaVaccine => "78",
                CodeVaccinesAdministered.VacciniaImmuneGlobulin => "79",
                CodeVaccinesAdministered.VeeLive => "80",
                CodeVaccinesAdministered.VeeInactivated => "81",
                CodeVaccinesAdministered.AdenovirusNos1 => "82",
                CodeVaccinesAdministered.HepAPedAdol2Dose => "83",
                CodeVaccinesAdministered.HepAPedAdol3Dose => "84",
                CodeVaccinesAdministered.HepANos => "85",
                CodeVaccinesAdministered.Ig => "86",
                CodeVaccinesAdministered.Igiv => "87",
                CodeVaccinesAdministered.InfluenzaNos => "88",
                CodeVaccinesAdministered.PolioNos => "89",
                CodeVaccinesAdministered.RabiesNos => "90",
                CodeVaccinesAdministered.TyphoidNos => "91",
                CodeVaccinesAdministered.VeeNos => "92",
                CodeVaccinesAdministered.RsvMab => "93",
                CodeVaccinesAdministered.Mmrv => "94",
                CodeVaccinesAdministered.TstOtTineTest => "95",
                CodeVaccinesAdministered.TstPpdIntradermal => "96",
                CodeVaccinesAdministered.TstPpdTineTest => "97",
                CodeVaccinesAdministered.TstNos => "98",
                CodeVaccinesAdministered.ReservedDoNotUse3 => "99",
                CodeVaccinesAdministered.NoVaccineAdministered5 => "998",
                CodeVaccinesAdministered.Unknown => "999",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeVaccinesAdministered input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeValueCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeValueCode input)
        {
            return input switch
            {
                CodeValueCode.SeeNubcCodesADeprecated => "...",
                CodeValueCode.SeeNubcCodesBDeprecated => "...",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeValueCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeValueType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeValueType input)
        {
            return input switch
            {
                CodeValueType.Address => "AD",
                CodeValueType.CodedElementWithFormattedValues => "CF",
                CodeValueType.CompositeIdWithCheckDigit => "CK",
                CodeValueType.CompositeIdAndName => "CN",
                CodeValueType.CodedWithNoExceptions => "CNE",
                CodeValueType.CompositePrice => "CP",
                CodeValueType.CodedWithExceptions => "CWE",
                CodeValueType.ExtendedCompositeIdWithCheckDigit => "CX",
                CodeValueType.DateTimeRange => "DR",
                CodeValueType.Date => "DT",
                CodeValueType.DateTime => "DTM",
                CodeValueType.EncapsulatedData => "ED",
                CodeValueType.FormattedText => "FT",
                CodeValueType.CodedValueForHl7DefinedTables => "ID",
                CodeValueType.CodedValueForUserDefinedTables => "IS",
                CodeValueType.MultiplexedArray => "MA",
                CodeValueType.Money => "MO",
                CodeValueType.NumericArray => "NA",
                CodeValueType.NameWithDateAndLocation => "NDL",
                CodeValueType.Numeric => "NM",
                CodeValueType.PersonName => "PN",
                CodeValueType.ReferencePointer => "RP",
                CodeValueType.StructuredNumeric => "SN",
                CodeValueType.StringData => "ST",
                CodeValueType.Time => "TM",
                CodeValueType.TelephoneNumber => "TN",
                CodeValueType.TextData => "TX",
                CodeValueType.ExtendedAddress => "XAD",
                CodeValueType.ExtendedCompositeIdNumberAndNameForPersons => "XCN",
                CodeValueType.ExtendedCompositeNameAndIdNumberForOrganizations => "OXN",
                CodeValueType.ExtendedPersonName => "XPN",
                CodeValueType.ExtendedTelecommunicationsNumber => "XTN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeValueType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeVersionId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeVersionId input)
        {
            return input switch
            {
                CodeVersionId.Release20 => "2.0",
                CodeVersionId.Demo20 => "2.0D",
                CodeVersionId.Release21 => "2.1",
                CodeVersionId.Release22 => "2.2",
                CodeVersionId.Release23 => "2.3",
                CodeVersionId.Release231 => "2.3.1",
                CodeVersionId.Release24 => "2.4",
                CodeVersionId.Release25 => "2.5",
                CodeVersionId.Release251 => "2.5.1",
                CodeVersionId.Release26 => "2.6",
                CodeVersionId.Release27 => "2.7",
                CodeVersionId.Release271 => "2.7.1",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeVersionId input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeVisitIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeVisitIndicator input)
        {
            return input switch
            {
                CodeVisitIndicator.AccountLevel => "A",
                CodeVisitIndicator.VisitLevel => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeVisitIndicator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeVisitPriorityCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeVisitPriorityCode input)
        {
            return input switch
            {
                CodeVisitPriorityCode.Emergency => "1",
                CodeVisitPriorityCode.Urgent => "2",
                CodeVisitPriorityCode.Elective => "3",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeVisitPriorityCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeVisitUserCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeVisitUserCode input)
        {
            return input switch
            {
                CodeVisitUserCode.Home => "HO",
                CodeVisitUserCode.MobileUnit => "MO",
                CodeVisitUserCode.Phone => "PH",
                CodeVisitUserCode.Teaching => "TE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeVisitUserCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeYesNoIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeYesNoIndicator input)
        {
            return input switch
            {
                CodeYesNoIndicator.No => "N",
                CodeYesNoIndicator.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeYesNoIndicator input) => EnumToCode(input);
    }
}
