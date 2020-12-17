using System;

namespace ClearHl7.Fhir.Codes.V240.Helpers
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
        /// Converts the given ActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ActionCode input)
        {
            return input switch
            {
                ActionCode.AddInsert => "A",
                ActionCode.Delete => "D",
                ActionCode.Update => "U",
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
        /// Converts the given AdditivePreservative enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdditivePreservative input)
        {
            return input switch
            {
                AdditivePreservative.BorateBoricAcid => "BOR",
                AdditivePreservative.ThreePointTwoPercentCitrate => "C32",
                AdditivePreservative.ThreePointEightPercentCitrate => "C38",
                AdditivePreservative.PotassiumKEdta => "EDTK",
                AdditivePreservative.SodiumNaEdta => "EDTN",
                AdditivePreservative.SixNHcl => "HCL6",
                AdditivePreservative.LithiumLiHeparin => "HEPL",
                AdditivePreservative.SodiumNaHeparin => "HEPN",
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
        /// Converts the given AdministrativeSexCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdministrativeSexCode input)
        {
            return input switch
            {
                AdministrativeSexCode.Ambiguous => "A",
                AdministrativeSexCode.Female => "F",
                AdministrativeSexCode.Male => "M",
                AdministrativeSexCode.NotApplicable => "N",
                AdministrativeSexCode.Other => "O",
                AdministrativeSexCode.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdmissionLevelOfCareValueCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AdmissionLevelOfCareValueCode input)
        {
            return input switch
            {
                AdmissionLevelOfCareValueCode.Acute => "AC",
                AdmissionLevelOfCareValueCode.Chronic => "CH",
                AdmissionLevelOfCareValueCode.Comatose => "CO",
                AdmissionLevelOfCareValueCode.Critical => "CR",
                AdmissionLevelOfCareValueCode.Improved => "IM",
                AdmissionLevelOfCareValueCode.Moribund => "MO",
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
                AdmitSource.PhysicianReferral => "1",
                AdmitSource.ClinicReferral => "2",
                AdmitSource.HmoReferral => "3",
                AdmitSource.TransferFromHospital => "4",
                AdmitSource.TransferFromSkilledNursingFacility => "5",
                AdmitSource.TransferFromAnotherHealthCareFacility => "6",
                AdmitSource.EmergencyRoom => "7",
                AdmitSource.CourtLawEnforcement => "8",
                AdmitSource.InformationNotAvailable => "9",
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
                AlternateCharacterSets.Iso88592CharacterSet => "8859/2",
                AlternateCharacterSets.Iso88593CharacterSet => "8859/3",
                AlternateCharacterSets.Iso88594CharacterSet => "8859/4",
                AlternateCharacterSets.Iso88595CharacterSet => "8859/5",
                AlternateCharacterSets.Iso88596CharacterSet => "8859/6",
                AlternateCharacterSets.Iso88597CharacterSet => "8859/7",
                AlternateCharacterSets.Iso88598CharacterSet => "8859/8",
                AlternateCharacterSets.Iso88599CharacterSet => "8859/9",
                AlternateCharacterSets.Seven7BitAsciiCharacterSet => "ASCII",
                AlternateCharacterSets.InfoExchangeOneByteJisX02011976 => "ISO IR14",
                AlternateCharacterSets.JapaneseGraphicJisX02121990 => "ISO IR159",
                AlternateCharacterSets.JapaneseGraphicJisX02081990 => "ISO IR87",
                AlternateCharacterSets.IsoIec1064611993 => "UNICODE",
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
                AssigningAuthority.AustraliaDeptOfVeteransAffairs => "AUSDVA",
                AssigningAuthority.AustraliaHealthInsuranceCommission => "AUSHIC",
                AssigningAuthority.CanadaAlberta => "CANAB",
                AssigningAuthority.CanadaBritishColumbia => "CANBC",
                AssigningAuthority.CanadaManitoba => "CANMB",
                AssigningAuthority.CanadaNewBrunswick => "CANNB",
                AssigningAuthority.CanadaNewfoundland => "CANNF",
                AssigningAuthority.CanadaNovaScotia => "CANNS",
                AssigningAuthority.CanadaNorthwestTerritories => "CANNT",
                AssigningAuthority.CanadaNanavut => "CANNU",
                AssigningAuthority.CanadaOntario => "CANON",
                AssigningAuthority.CanadaPrinceEdwardIsland => "CANPE",
                AssigningAuthority.CanadaQuebec => "CANQC",
                AssigningAuthority.CanadaSaskatchewan => "CANSK",
                AssigningAuthority.CanadaYukonTerritories => "CANYT",
                AssigningAuthority.NlMinisterieVanVolksgezondheidWelzijnEnSport => "NLVWS",
                AssigningAuthority.UsCenterForDiseaseControl => "USCDC",
                AssigningAuthority.UsHealthcareFinanceAuthority => "USHCFA",
                AssigningAuthority.UsSocialSecurityAdministration => "USSSA",
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
        /// Converts the given CheckDigitScheme enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(CheckDigitScheme input)
        {
            return input switch
            {
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
                CodingSystem.LocalGeneralCode99ZzzOrL => "99zzz or L",
                CodingSystem.AmericanCollegeOfRadiologyFindingCodes => "ACR",
                CodingSystem.WhoAdverseReactionTerms => "ART",
                CodingSystem.AstmE1238E1467Universal => "AS4",
                CodingSystem.As4NeurophysiologyCodes => "AS4E",
                CodingSystem.AmericanTypeCultureCollection => "ATC",
                CodingSystem.Cpt4 => "C4",
                CodingSystem.Cpt5 => "C5",
                CodingSystem.ChemicalAbstractCodes => "CAS",
                CodingSystem.Cdt2Codes => "CD2",
                CodingSystem.CdcAnalyteCodes => "CDCA",
                CodingSystem.CdcMethodsInstrumentsCodes => "CDCM",
                CodingSystem.CdcSurveillance => "CDS",
                CodingSystem.CenEcgDiagnosticCodes => "CE",
                CodingSystem.Clip => "CLP",
                CodingSystem.CptModifierCode => "CPTM",
                CodingSystem.Costart => "CST",
                CodingSystem.CdcVaccineCodes => "CVX",
                CodingSystem.DicomClassLabel => "DCL",
                CodingSystem.DicomControlledTerminology => "DCM",
                CodingSystem.DicomQueryLabel => "DQL",
                CodingSystem.Euclides => "E",
                CodingSystem.EuclidesQuantityCodes => "E5",
                CodingSystem.EuclidesLabMethodCodes => "E6",
                CodingSystem.EuclidesLabEquipmentCodes => "E7",
                CodingSystem.EnzymeCodes => "ENZC",
                CodingSystem.FirstDatabankDrugCodes => "FDDC",
                CodingSystem.FirstDatabankDiagnosticCodes => "FDDX",
                CodingSystem.FdaK10 => "FDK",
                CodingSystem.Hibcc => "HB",
                CodingSystem.CmsFormerlyHcfaCommonProcedureCodingSystem => "HCPCS",
                CodingSystem.HomeHealthCare => "HHC",
                CodingSystem.HealthOutcomes => "HI",
                CodingSystem.Hl7DefinedCodesWhereNnnnIsTheHl7TableNumber => "HL7nnnn",
                CodingSystem.CmsFormerlyHcfaProcedureCodesHcpcs => "HPC",
                CodingSystem.Icd10 => "I10",
                CodingSystem.Icd10ProcedureCodes => "I10P",
                CodingSystem.Icd9 => "I9",
                CodingSystem.Icd9Cm => "I9C",
                CodingSystem.Isbt => "IBT",
                CodingSystem.Ichppc2 => "IC2",
                CodingSystem.IcdForOncology => "ICDO",
                CodingSystem.Iccs => "ICS",
                CodingSystem.Icsd => "ICSD",
                CodingSystem.IsoDefinedCodes => "ISOnnnn",
                CodingSystem.IupacIfccComponentCodes => "IUPC",
                CodingSystem.IupacIfccPropertyCodes => "IUPP",
                CodingSystem.JapaneseChemistry => "JC8",
                CodingSystem.LocalBillingCode => "LB",
                CodingSystem.LogicalObservationIdentifierNamesAndCodesLoinc => "LN",
                CodingSystem.Medicaid => "MCD",
                CodingSystem.Medicare => "MCR",
                CodingSystem.MedispanDiagnosticCodes => "MDDX",
                CodingSystem.MedicalEconomicsDrugCodes => "MEDC",
                CodingSystem.MedicalDictionaryForDrugRegulatoryAffairs => "MEDR",
                CodingSystem.MedicalEconomicsDiagnosticCodes => "MEDX",
                CodingSystem.MedispanGpi => "MGPI",
                CodingSystem.CdcVaccineManufacturerCodes => "MVX",
                CodingSystem.Nanda => "NDA",
                CodingSystem.NationalDrugCodes => "NDC",
                CodingSystem.NursingInterventionsClassification => "NIC",
                CodingSystem.NationalProviderIdentifier => "NPI",
                CodingSystem.OmahaSystem => "OHA",
                CodingSystem.PosCodes => "POS",
                CodingSystem.ReadClassification => "RC",
                CodingSystem.SnomedDicomMicroglossary => "SDM",
                CodingSystem.SystemizedNomenclatureOfMedicineSnomed => "SNM",
                CodingSystem.SnomedInternational => "SNM3",
                CodingSystem.SnomedTopologyCodesAnatomicSites => "SNT",
                CodingSystem.Ucds => "UC",
                CodingSystem.Mdns => "UMD",
                CodingSystem.UnifiedMedicalLanguage => "UML",
                CodingSystem.UniversalProductCode => "UPC",
                CodingSystem.Upin => "UPIN",
                CodingSystem.WhoRecordDrugCodes6Digit => "W1",
                CodingSystem.WhoRecordDrugCodes8Digit => "W2",
                CodingSystem.WhoRecordCodeWithAstmExtension => "W4",
                CodingSystem.WhoAtc => "WC",
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
        /// Converts the given ConditionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ConditionCode input)
        {
            return input switch
            {
                ConditionCode.MilitaryServiceRelated => "01",
                ConditionCode.ConditionIsEmploymentRelated => "02",
                ConditionCode.PatientCoveredByInsuranceNotReflectedHere => "03",
                ConditionCode.HmoEnrollee => "04",
                ConditionCode.LienHasBeenFiled => "05",
                ConditionCode.EsrdPatient18MonthsCoveredByEmployerInsurance => "06",
                ConditionCode.TreatmentOfNonTerminalConditionHospicePatient => "07",
                ConditionCode.BeneficiaryWouldNotProvideInfoConcerningOtherInsurance => "08",
                ConditionCode.NeitherPatientNorSpouseIsEmployed => "09",
                ConditionCode.PatientAndOrSpouseIsEmployedButNoEghpExists => "10",
                ConditionCode.DisabledBeneficiaryButNoLghp => "11",
                ConditionCode.PayerCodes12 => "12",
                ConditionCode.PayerCodes12To16 => "12 ... 16",
                ConditionCode.PayerCodes13 => "13",
                ConditionCode.PayerCodes14 => "14",
                ConditionCode.PayerCodes15 => "15",
                ConditionCode.PayerCodes16 => "16",
                ConditionCode.MaidenNameRetained => "18",
                ConditionCode.ChildRetainsMothersName => "19",
                ConditionCode.BeneficiaryRequestedBilling => "20",
                ConditionCode.BillingForDenialNotice => "21",
                ConditionCode.VaPatientChoosesMedicareCertifiedFacility => "26",
                ConditionCode.PatientReferredToHospitalForDiagnosticLabTest => "27",
                ConditionCode.PatientAndOrSpousesEghpIsSecondaryToMedicare => "28",
                ConditionCode.DisabledBeneficiaryAndOrFamilyMembersLghpIsSecondaryToMedicare => "29",
                ConditionCode.PatientIsStudentFullTimeDay => "31",
                ConditionCode.PatientIsStudentWorkStudyProgram => "32",
                ConditionCode.PatientIsStudentFullTimeNight => "33",
                ConditionCode.PatientIsStudentPartTime => "34",
                ConditionCode.GeneralCarePatientInSpecialUnit => "36",
                ConditionCode.WardAccommodationAsPatientRequest => "37",
                ConditionCode.SemiPrivateRoomNotAvailable => "38",
                ConditionCode.PrivateRoomMedicallyNecessary => "39",
                ConditionCode.SameDayTransfer => "40",
                ConditionCode.PartialHospitalization => "41",
                ConditionCode.NonAvailabilityStatementOnFile => "46",
                ConditionCode.PsycTreatmentCentersForChildrenAndAdolescents => "48",
                ConditionCode.SnfBedNotAvailable => "55",
                ConditionCode.MedicalAppropriateness => "56",
                ConditionCode.SnfReadmission => "57",
                ConditionCode.DayOutlier => "60",
                ConditionCode.CostOutlier => "61",
                ConditionCode.PayerCode => "62",
                ConditionCode.ProviderDoesNotWishCostOutlierPayment => "66",
                ConditionCode.BeneficiaryElectsNotToUseLifeTimeReserveLtrDays => "67",
                ConditionCode.BeneficiaryElectsToUseLifeTimeReserveLtrDays => "68",
                ConditionCode.SelfAdministeredEpo => "70",
                ConditionCode.FullCareInUnit => "71",
                ConditionCode.SelfCareInUnit => "72",
                ConditionCode.SelfCareTraining => "73",
                ConditionCode.Home => "74",
                ConditionCode.Home100Reimbursement => "75",
                ConditionCode.BackUpInFacilityDialysis => "76",
                ConditionCode.ProviderAcceptsPayerPaymentInFull => "77",
                ConditionCode.NewCoverageNotImplementedByHmo => "78",
                ConditionCode.CorfServicesProvidedOffSite => "79",
                ConditionCode.Pregnant => "80",
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
        /// Converts the given DataTypes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DataTypes input)
        {
            return input switch
            {
                DataTypes.Address => "AD",
                DataTypes.ChannelDefinition => "CD",
                DataTypes.CodedElement => "CE",
                DataTypes.CodedElementWithFormattedValues => "CF",
                DataTypes.CompositeIdWithCheckDigit => "CK",
                DataTypes.Composite => "CM",
                DataTypes.CompositeIdNumberAndName => "CN",
                DataTypes.CodedWithNoExceptions => "CNE",
                DataTypes.CompositePrice => "CP",
                DataTypes.CompositeQuantityWithUnits => "CQ",
                DataTypes.CodedWithExceptions => "CWE",
                DataTypes.ExtendedCompositeIdWithCheckDigit => "CX",
                DataTypes.DriversLicenseNumber => "DLN",
                DataTypes.DateTimeRange => "DR",
                DataTypes.Date => "DT",
                DataTypes.EncapsulatedData => "ED",
                DataTypes.EntityIdentifier => "EI",
                DataTypes.FinancialClass => "FC",
                DataTypes.FamilyName => "FN",
                DataTypes.FormattedText => "FT",
                DataTypes.HierarchicDesignator => "HD",
                DataTypes.CodedValuesForHl7Tables => "ID",
                DataTypes.CodedValueForUserDefinedTables => "IS",
                DataTypes.JobCodeClass => "JCC",
                DataTypes.MultiplexedArray => "MA",
                DataTypes.Money => "MO",
                DataTypes.NumericArray => "NA",
                DataTypes.Numeric => "NM",
                DataTypes.PersonLocation => "PL",
                DataTypes.PersonName => "PN",
                DataTypes.PerformingPersonTimeStamp => "PPN",
                DataTypes.ProcessingType => "PT",
                DataTypes.QueryInputParameterList => "QIP",
                DataTypes.QuerySelectionCriteria => "QSC",
                DataTypes.RowColumnDefinition => "RCD",
                DataTypes.RepeatInterval => "RI",
                DataTypes.ReferencePointer => "RP",
                DataTypes.StreetAddress => "SAD",
                DataTypes.SchedulingClassValuePair => "SCV",
                DataTypes.SequenceId => "SI",
                DataTypes.StructuredNumeric => "SN",
                DataTypes.SortOrder => "SRT",
                DataTypes.StringData => "ST",
                DataTypes.Time => "TM",
                DataTypes.TelephoneNumber => "TN",
                DataTypes.TimingQuantity => "TQ",
                DataTypes.TimeStamp => "TS",
                DataTypes.TextData => "TX",
                DataTypes.VisitingHours => "VH",
                DataTypes.VersionIdentifier => "VID",
                DataTypes.ExtendedAddress => "XAD",
                DataTypes.ExtendedCompositeIdNumberAndNameForPersons => "XCN",
                DataTypes.ExtendedCompositeNameAndIdNumberForOrganizations => "XON",
                DataTypes.ExtendedPersonName => "XPN",
                DataTypes.ExtendedTelecommunicationsNumber => "XTN",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DateTimeSelectionQualifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DateTimeSelectionQualifier input)
        {
            return input switch
            {
                DateTimeSelectionQualifier.FirstValueWithinRange => "1ST",
                DateTimeSelectionQualifier.AllValuesWithinTheRange => "ALL",
                DateTimeSelectionQualifier.LastValueWithinTheRange => "LST",
                DateTimeSelectionQualifier.ValuesWithinRangeInReverseOrder => "REV",
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
        /// Converts the given DeferredResponseType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DeferredResponseType input)
        {
            return input switch
            {
                DeferredResponseType.BeforeTheDateTimeSpecified => "B",
                DeferredResponseType.LaterThanTheDateTimeSpecified => "L",
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
                DegreeLicenseCertificate.BachelorOfTheology => "BT",
                DegreeLicenseCertificate.Certificate => "CER",
                DegreeLicenseCertificate.DoctorOfBusinessAdministration => "DBA",
                DegreeLicenseCertificate.DoctorOfEducation => "DED",
                DegreeLicenseCertificate.Diploma => "DIP",
                DegreeLicenseCertificate.DoctorOfOsteopathy => "DO",
                DegreeLicenseCertificate.HighSchoolGraduate => "HS",
                DegreeLicenseCertificate.JurisDoctor => "JD",
                DegreeLicenseCertificate.MasterOfArts => "MA",
                DegreeLicenseCertificate.MasterOfBusinessAdministration => "MBA",
                DegreeLicenseCertificate.MasterOfCivilEngineering => "MCE",
                DegreeLicenseCertificate.DoctorOfMedicine => "MD",
                DegreeLicenseCertificate.MasterOfDivinity => "MDI",
                DegreeLicenseCertificate.MasterOfEngineering => "ME",
                DegreeLicenseCertificate.MasterOfEducation => "MED",
                DegreeLicenseCertificate.MasterOfElectricalEngineering => "MEE",
                DegreeLicenseCertificate.MasterOfFineArts => "MFA",
                DegreeLicenseCertificate.MasterOfMechanicalEngineering => "MME",
                DegreeLicenseCertificate.MasterOfScience => "MS",
                DegreeLicenseCertificate.MasterOfScienceLaw => "MSL",
                DegreeLicenseCertificate.MasterOfTheology => "MT",
                DegreeLicenseCertificate.NonGraduate => "NG",
                DegreeLicenseCertificate.DoctorOfPhilosophy => "PHD",
                DegreeLicenseCertificate.DoctorOfEngineering => "PHE",
                DegreeLicenseCertificate.DoctorOfScience => "PHS",
                DegreeLicenseCertificate.DoctorOfPharmacy => "PharmD",
                DegreeLicenseCertificate.SecretarialCertificate => "SEC",
                DegreeLicenseCertificate.TradeSchoolGraduate => "TS",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DelayedAcknowledgmentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DelayedAcknowledgmentType input)
        {
            return input switch
            {
                DelayedAcknowledgmentType.MessageReceived => "D",
                DelayedAcknowledgmentType.AcknowledgmentAfterProcessing => "F",
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
                DiagnosisPriority.NotIncludedInDiagnosisRanking => "0",
                DiagnosisPriority.ThePrimaryDiagnosis => "1",
                DiagnosisPriority.ForRankedSecondaryDiagnoses => "2 ...",
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
                DiagnosticServiceSectionId.DiagnosticImaging => "IMG",
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
                DiagnosticServiceSectionId.Parasitology => "PAR",
                DiagnosticServiceSectionId.Pathology => "PAT",
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
                DiagnosticServiceSectionId.Urinalysis => "URN",
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
                EmploymentStatus.PerDiem => "D",
                EmploymentStatus.FullTime => "F",
                EmploymentStatus.LeaveOfAbsence => "L",
                EmploymentStatus.Other => "O",
                EmploymentStatus.PartTime => "P",
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
                EventTypeCode.QcnAckCancelQueryAcknowledgeMessage => "J01",
                EventTypeCode.QsxAckCancelSubscriptionAcknowledgeMessage => "J02",
                EventTypeCode.RspGetPersonDemographicsResponse => "K21",
                EventTypeCode.RspFindCandidatesResponse => "K22",
                EventTypeCode.RspGetCorrespondingIdentifiersResponse => "K23",
                EventTypeCode.RspAllocateIdentifiersResponse => "K24",
                EventTypeCode.RspPersonnelInformationBySegmentResponse => "K25",
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
                EventTypeCode.EqqEmbeddedQueryLanguageQuery => "Q04",
                EventTypeCode.UdmAckUnsolicitedDisplayUpdateMessage => "Q05",
                EventTypeCode.OsqOsrQueryForOrderStatus => "Q06",
                EventTypeCode.VqqVirtualTableQuery => "Q07",
                EventTypeCode.SpqStoredProcedureRequest => "Q08",
                EventTypeCode.RqqEventReplayQuery => "Q09",
                EventTypeCode.QsbCreateSubscription => "Q16",
                EventTypeCode.QvrQueryForPreviousEvents => "Q17",
                EventTypeCode.QbpGetPersonDemographics => "Q21",
                EventTypeCode.QbpFindCandidates => "Q22",
                EventTypeCode.QbpGetCorrespondingIdentifiers => "Q23",
                EventTypeCode.QbpAllocateIdentifiers => "Q24",
                EventTypeCode.QbpPersonnelInformationBySegmentQuery => "Q25",
                EventTypeCode.OruAckUnsolicitedTransmissionOfObservation => "R01",
                EventTypeCode.QryQueryForResultsOfObservation => "R02",
                EventTypeCode.QryDsrDisplayOrientedResultsQueryUnsolUpdate => "R03",
                EventTypeCode.OrfResponseToQueryTransmissionOfRequestedObservation => "R04",
                EventTypeCode.QryDsrQueryForDisplayResults => "R05",
                EventTypeCode.UdmUnsolicitedUpdateDisplayResults => "R06",
                EventTypeCode.EdrEnhancedDisplayResponse => "R07",
                EventTypeCode.TbrTabularDataResponse => "R08",
                EventTypeCode.ErpEventReplayResponse => "R09",
                EventTypeCode.OulUnsolicitedLaboratoryObservation => "R21",
                EventTypeCode.RarPharmacyAdministrationInfoQueryResponse => "RAR",
                EventTypeCode.RdrPharmacyDispenseInfoQueryResponse => "RDR",
                EventTypeCode.RerPharmacyEncodedOrderInfoQueryResponse => "RER",
                EventTypeCode.RgrPharmacyDoseInfoQueryResponse => "RGR",
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
                FormularyStatus.ThisObservationServiceIsOnFormularyAndHasGuidelines => "G",
                FormularyStatus.ThisObservationServiceIsNotOnFormulary => "N",
                FormularyStatus.ThisObservationServiceIsOnFormularyButIsRestricted => "R",
                FormularyStatus.ThisObservationServiceIsOnFormulary => "Y",
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
                IdentifierType.AmericanExpress => "AM",
                IdentifierType.AccountNumber => "AN",
                IdentifierType.BankAccountNumber => "BA",
                IdentifierType.BirthRegistryNumber => "BR",
                IdentifierType.BreedRegistryNumber => "BRN",
                IdentifierType.DinersClubCard => "DI",
                IdentifierType.DriversLicenseNumber => "DL",
                IdentifierType.DoctorNumber => "DN",
                IdentifierType.DonorRegistrationNumber => "DR",
                IdentifierType.DiscoverCard => "DS",
                IdentifierType.EmployeeNumber => "EI",
                IdentifierType.EmployerNumber => "EN",
                IdentifierType.FacilityId => "FI",
                IdentifierType.GuarantorInternalIdentifier => "GI",
                IdentifierType.GuarantorExternalIdentifier => "GN",
                IdentifierType.HealthCardNumber => "HC",
                IdentifierType.JurisdictionalHealthNumberCanada => "JHN",
                IdentifierType.LicenseNumber => "LN",
                IdentifierType.LocalRegistryId => "LR",
                IdentifierType.PatientMedicaidNumber => "MA",
                IdentifierType.PatientsMedicareNumber => "MC",
                IdentifierType.MicrochipNumber => "MCN",
                IdentifierType.MedicalRecordNumber => "MR",
                IdentifierType.Mastercard => "MS",
                IdentifierType.NationalEmployerId => "NE",
                IdentifierType.NationalHealthPlanId => "NH",
                IdentifierType.NationalUniqueIndividualId => "NI",
                IdentifierType.NationalPersonIdentifier => "NNxxx",
                IdentifierType.NationalProviderIdentifier => "NPI",
                IdentifierType.PensionNumber => "PEN",
                IdentifierType.PatientInternalIdentifier => "PI",
                IdentifierType.PersonNumber => "PN",
                IdentifierType.ProviderNumber => "PRN",
                IdentifierType.PatientExternalIdentifier => "PT",
                IdentifierType.RailroadRetirementNumber => "RR",
                IdentifierType.RegionalRegistryId => "RRI",
                IdentifierType.StateLicense => "SL",
                IdentifierType.StateRegistryId => "SR",
                IdentifierType.SocialSecurityNumber => "SS",
                IdentifierType.UnspecifiedIdentifier => "U",
                IdentifierType.MedicareCmsUniversalPhysicianId => "UPIN",
                IdentifierType.VisitNumber => "VN",
                IdentifierType.Visa => "VS",
                IdentifierType.WicIdentifier => "WC",
                IdentifierType.WorkersCompNumber => "WCN",
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
                InterpretationCodes.Better => "B",
                InterpretationCodes.SignificantChangeDown => "D",
                InterpretationCodes.High => "H",
                InterpretationCodes.CriticallyHigh => "HH",
                InterpretationCodes.Intermediate => "I",
                InterpretationCodes.Low => "L",
                InterpretationCodes.CriticallyLow => "LL",
                InterpretationCodes.ModeratelySusceptible => "MS",
                InterpretationCodes.Normal => "N",
                InterpretationCodes.NoRangeDefinedOrNormalRangesDontApply => "null",
                InterpretationCodes.Resistant => "R",
                InterpretationCodes.Susceptible => "S",
                InterpretationCodes.SignificantChangeUp => "U",
                InterpretationCodes.VerySusceptible => "VS",
                InterpretationCodes.Worse => "W",
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
                LivingDependency.CommonBathDeprecated => "CB",
                LivingDependency.SpouseDependentDeprecated => "D",
                LivingDependency.MedicalSupervisionRequired => "M",
                LivingDependency.Other => "O",
                LivingDependency.SpouseDependent => "S",
                LivingDependency.Unknown => "U",
                LivingDependency.WalkUpDeprecated => "WU",
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
        /// Converts the given LocalRemoteControlState enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(LocalRemoteControlState input)
        {
            return input switch
            {
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
                ManufacturersOfVaccines.Aviron => "AVI",
                ManufacturersOfVaccines.BaxterHealthcareCorporationDeprecated => "BA",
                ManufacturersOfVaccines.BayerCorporation => "BAY",
                ManufacturersOfVaccines.BernaProducts => "BP",
                ManufacturersOfVaccines.BernaProductsCorporation => "BPC",
                ManufacturersOfVaccines.CenteonLLC => "CEN",
                ManufacturersOfVaccines.ChironCorporation => "CHI",
                ManufacturersOfVaccines.Connaught => "CON",
                ManufacturersOfVaccines.EvansMedicalLimited => "EVN",
                ManufacturersOfVaccines.GreerLaboratoriesInc => "GRE",
                ManufacturersOfVaccines.ImmunoInternationalAg => "IAG",
                ManufacturersOfVaccines.Merieux => "IM",
                ManufacturersOfVaccines.ImmunoUSInc => "IUS",
                ManufacturersOfVaccines.ResearchFoundationForMicrobialDiseasesOfOsaka => "JPN",
                ManufacturersOfVaccines.KoreaGreenCrossCorporation => "KGC",
                ManufacturersOfVaccines.Lederle => "LED",
                ManufacturersOfVaccines.MassachusettsPublicHealthBiologicLabs => "MA",
                ManufacturersOfVaccines.MedimmuneInc => "MED",
                ManufacturersOfVaccines.Miles => "MIL",
                ManufacturersOfVaccines.BioportCorporation => "MIP",
                ManufacturersOfVaccines.MerckCoInc => "MSD",
                ManufacturersOfVaccines.Nabi => "NAB",
                ManufacturersOfVaccines.NorthAmericanVaccineInc => "NAV",
                ManufacturersOfVaccines.NovartisPharmaceuticalCorporation => "NOV",
                ManufacturersOfVaccines.NewYorkBloodCenter => "NYB",
                ManufacturersOfVaccines.OrthoClinicalDiagnostics => "ORT",
                ManufacturersOfVaccines.OrganonTeknikaCorporation => "OTC",
                ManufacturersOfVaccines.OtherManufacturer => "OTH",
                ManufacturersOfVaccines.ParkedalePharmaceuticals => "PD",
                ManufacturersOfVaccines.SanofiPasteur => "PMC",
                ManufacturersOfVaccines.PraxisBiologics => "PRX",
                ManufacturersOfVaccines.SclavoInc => "SCL",
                ManufacturersOfVaccines.SwissSerumAndVaccineInst => "SI",
                ManufacturersOfVaccines.Glaxosmithkline => "SKB",
                ManufacturersOfVaccines.UnknownManufacturer => "UNK",
                ManufacturersOfVaccines.UsArmyMedicalResearchAndMaterialCommand => "USA",
                ManufacturersOfVaccines.WyethAyerstDeprecated => "WA",
                ManufacturersOfVaccines.WyethAyerst => "WAL",
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
                MessageStructure.C01C02C03C04C05C06C07C08 => "CRM_C01",
                MessageStructure.C09C10C11C12 => "CSU_C09",
                MessageStructure.P03 => "DFT_P03",
                MessageStructure.DocT12Deprecated => "DOC_T12",
                MessageStructure.P04DSRDeprecated => "DSR_P04",
                MessageStructure.Q01Deprecated => "DSR_Q01",
                MessageStructure.Q03Deprecated => "DSR_Q03",
                MessageStructure.U07 => "EAC_U07",
                MessageStructure.U09 => "EAN_U09",
                MessageStructure.U08 => "EAR_U08",
                MessageStructure.R07Deprecated => "EDR_R07",
                MessageStructure.Q04Deprecated => "EQQ_Q04",
                MessageStructure.R09ERPDeprecated => "ERP_R09",
                MessageStructure.U02 => "ESR_U02",
                MessageStructure.U01 => "ESU_U01",
                MessageStructure.U06 => "INR_U06",
                MessageStructure.U05 => "INU_U05",
                MessageStructure.U12U13 => "LSU_U12",
                MessageStructure.T01T03T05T07T09T11 => "MDM_T01",
                MessageStructure.T02T04T06T08T10 => "MDM_T02",
                MessageStructure.MfaDeprecated => "MFD_MFA",
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
                MessageStructure.M01M02M03M04M05M06Deprecated => "MFQ_M01",
                MessageStructure.M01M02M03Deprecated => "MFR_M01",
                MessageStructure.N02 => "NMD_N02",
                MessageStructure.N01NMQDeprecated => "NMQ_N01",
                MessageStructure.N01NMRDeprecated => "NMR_N01",
                MessageStructure.O03 => "OMD_O03",
                MessageStructure.O19 => "OMG_O19",
                MessageStructure.O21 => "OML_O21",
                MessageStructure.O07 => "OMN_O07",
                MessageStructure.O09 => "OMP_O09",
                MessageStructure.O05 => "OMS_O05",
                MessageStructure.O04 => "ORD_O04",
                MessageStructure.R04Deprecated => "ORF_R04",
                MessageStructure.O20 => "ORG_O20",
                MessageStructure.O22 => "ORL_O22",
                MessageStructure.O01ORMDeprecated => "ORM_O01",
                MessageStructure.O08 => "ORN_O08",
                MessageStructure.O10 => "ORP_O10",
                MessageStructure.O02ORRDeprecated => "ORR_O02",
                MessageStructure.O06 => "ORS_O06",
                MessageStructure.R01 => "ORU_R01",
                MessageStructure.W01Deprecated => "ORU_W01",
                MessageStructure.Q06OSQDeprecated => "OSQ_Q06",
                MessageStructure.Q06OSRDeprecated => "OSR_Q06",
                MessageStructure.R21Deprecated => "OUL_R21",
                MessageStructure.P07P08 => "PEX_P07",
                MessageStructure.Pc6Pc7Pc8 => "PGL_PC6",
                MessageStructure.B01B02 => "PMU_B01",
                MessageStructure.B03 => "PMU_B03",
                MessageStructure.B04B05B06 => "PMU_B04",
                MessageStructure.PccPcgPchPcj => "PPG_PCG",
                MessageStructure.PcbPcd => "PPP_PCB",
                MessageStructure.Pc1Pc2Pc3 => "PPR_PC1",
                MessageStructure.PclDeprecated => "PPT_PCL",
                MessageStructure.PcaDeprecated => "PPV_PCA",
                MessageStructure.Pc5Deprecated => "PRR_PC5",
                MessageStructure.PcfDeprecated => "PTR_PCF",
                MessageStructure.Q11 => "QBP_Q11",
                MessageStructure.Q13 => "QBP_Q13",
                MessageStructure.Q15 => "QBP_Q15",
                MessageStructure.Q21Q22Q23Q24Q25 => "QBP_Q21",
                MessageStructure.Q02QCKDeprecated => "QCK_Q02",
                MessageStructure.J01J02 => "QCN_J01",
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
                MessageStructure.O01RDEDeprecated => "RDE_O01",
                MessageStructure.O11O25 => "RDE_O11",
                MessageStructure.Rdr => "RDR_RDR",
                MessageStructure.O13 => "RDS_O13",
                MessageStructure.K11Deprecated => "RDY_K11",
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
                MessageStructure.Q09Deprecated => "RQQ_Q09",
                MessageStructure.O02RRADeprecated => "RRA_O02",
                MessageStructure.O18 => "RRA_O18",
                MessageStructure.O14 => "RRD_O14",
                MessageStructure.O12O26 => "RRE_O12",
                MessageStructure.O16 => "RRG_O16",
                MessageStructure.I12I13I14I15RRI => "RRI_I12",
                MessageStructure.K21 => "RSP_K21",
                MessageStructure.K22 => "RSP_K22",
                MessageStructure.K23K24 => "RSP_K23",
                MessageStructure.K24Deprecated => "RSP_K24",
                MessageStructure.K25 => "RSP_K25",
                MessageStructure.K13 => "RTB_K13",
                MessageStructure.S12S13S14S15S16S17S18S19S20S21S22S23S24S26 => "SIU_S12",
                MessageStructure.Q08Deprecated => "SPQ_Q08",
                MessageStructure.S25SQMDeprecated => "SQM_S25",
                MessageStructure.S25SQRDeprecated => "SQR_S25",
                MessageStructure.S01S02S03S04S05S06S07S08S09S10S11SRM => "SRM_S01",
                MessageStructure.S01S02S03S04S05S06S07S08S09S10S11SRR => "SRR_S01",
                MessageStructure.U04 => "SSR_U04",
                MessageStructure.U03 => "SSU_U03",
                MessageStructure.P09SURDeprecated => "SUR_P09",
                MessageStructure.R08Deprecated => "TBR_R08",
                MessageStructure.R09TBRDeprecated => "TBR_R09",
                MessageStructure.U10U11 => "TCU_U10",
                MessageStructure.Q05 => "UDM_Q05",
                MessageStructure.Q07Deprecated => "VQQ_Q07",
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
                MessageType.ClinicalStudyRegistration => "CRM",
                MessageType.UnsolicitedStudyData => "CSU",
                MessageType.DetailFinancialTransactions => "DFT",
                MessageType.DocumentResponseDeprecated => "DOC",
                MessageType.DisplayResponseDeprecated => "DSR",
                MessageType.AutomatedEquipmentCommand => "EAC",
                MessageType.AutomatedEquipmentNotification => "EAN",
                MessageType.AutomatedEquipmentResponse => "EAR",
                MessageType.EnhancedDisplayResponseDeprecated => "EDR",
                MessageType.EmbeddedQueryLanguageQueryDeprecated => "EQQ",
                MessageType.EventReplayResponseDeprecated => "ERP",
                MessageType.AutomatedEquipmentStatusUpdateAcknowledgment => "ESR",
                MessageType.AutomatedEquipmentStatusUpdate => "ESU",
                MessageType.AutomatedEquipmentInventoryRequest => "INR",
                MessageType.AutomatedEquipmentInventoryUpdate => "INU",
                MessageType.AutomatedEquipmentLogServiceRequest => "LSR",
                MessageType.AutomatedEquipmentLogServiceUpdate => "LSU",
                MessageType.DelayedAcknowledgmentDeprecated => "MCF",
                MessageType.MedicalDocumentManagement => "MDM",
                MessageType.MasterFilesDelayedApplicationAcknowledgmentDeprecated => "MFD",
                MessageType.MasterFilesApplicationAcknowledgment => "MFK",
                MessageType.MasterFilesNotification => "MFN",
                MessageType.MasterFilesQueryDeprecated => "MFQ",
                MessageType.MasterFilesResponseDeprecated => "MFR",
                MessageType.ApplicationManagementData => "NMD",
                MessageType.ApplicationManagementQueryDeprecated => "NMQ",
                MessageType.ApplicationManagementResponseDeprecated => "NMR",
                MessageType.DietaryOrder => "OMD",
                MessageType.GeneralClinicalOrder => "OMG",
                MessageType.LaboratoryOrder => "OML",
                MessageType.NonStockRequisitionOrder => "OMN",
                MessageType.PharmacyTreatmentOrder => "OMP",
                MessageType.StockRequisitionOrder => "OMS",
                MessageType.DietaryOrderAcknowledgment => "ORD",
                MessageType.QueryForResultsOfObservationDeprecated => "ORF",
                MessageType.GeneralClinicalOrderAcknowledgment => "ORG",
                MessageType.LaboratoryAcknowledgmentUnsolicited => "ORL",
                MessageType.PharmacyTreatmentOrderDeprecated => "ORM",
                MessageType.NonStockRequisitionGeneralOrderAcknowledgment => "ORN",
                MessageType.PharmacyTreatmentOrderAcknowledgment => "ORP",
                MessageType.GeneralOrderResponseToAnyOrmDeprecated => "ORR",
                MessageType.StockRequisitionOrderAcknowledgment => "ORS",
                MessageType.UnsolicitedTransmissionOfObservation => "ORU",
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
                MessageType.EventReplayQueryDeprecated => "RQQ",
                MessageType.PharmacyTreatmentAdministrationAcknowledgment => "RRA",
                MessageType.PharmacyTreatmentDispenseAcknowledgment => "RRD",
                MessageType.PharmacyTreatmentEncodedOrderAcknowledgment => "RRE",
                MessageType.PharmacyTreatmentGiveAcknowledgment => "RRG",
                MessageType.ReturnReferralInfo => "RRI",
                MessageType.SegmentPatternResponse => "RSP",
                MessageType.TabularResponse => "RTB",
                MessageType.ScheduleInfoUnsolicited => "SIU",
                MessageType.StoredProcedureRequestDeprecated => "SPQ",
                MessageType.ScheduleQueryMessageDeprecated => "SQM",
                MessageType.ScheduleQueryResponseDeprecated => "SQR",
                MessageType.ScheduleRequestMessage => "SRM",
                MessageType.ScheduledRequestResponse => "SRR",
                MessageType.SpecimenStatusRequestMessage => "SSR",
                MessageType.SpecimenStatusUpdateMessage => "SSU",
                MessageType.SummaryProductExperienceReportDeprecated => "SUR",
                MessageType.TabularDataResponseDeprecated => "TBR",
                MessageType.AutomatedEquipmentTestCodeSettingsRequest => "TCR",
                MessageType.AutomatedEquipmentTestCodeSettingsUpdate => "TCU",
                MessageType.UnsolicitedDisplayUpdateMessage => "UDM",
                MessageType.VirtualTableQueryDeprecated => "VQQ",
                MessageType.QueryForVaccinationRecordDeprecated => "VXQ",
                MessageType.VaccinationRecordResponseDeprecated => "VXR",
                MessageType.UnsolicitedVaccinationRecordUpdate => "VXU",
                MessageType.ResponseForVaccinationQueryWithMultiplePidMatchesDeprecated => "VXX",
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
                MilitaryRankGrade.Enlisted1To9 => "E1 ... E9",
                MilitaryRankGrade.Enlisted2 => "E2",
                MilitaryRankGrade.Enlisted3 => "E3",
                MilitaryRankGrade.Enlisted4 => "E4",
                MilitaryRankGrade.Enlisted5 => "E5",
                MilitaryRankGrade.Enlisted6 => "E6",
                MilitaryRankGrade.Enlisted7 => "E7",
                MilitaryRankGrade.Enlisted8 => "E8",
                MilitaryRankGrade.Enlisted9 => "E9",
                MilitaryRankGrade.Officers1 => "O1",
                MilitaryRankGrade.Officers => "O1 ... O10",
                MilitaryRankGrade.Officers10 => "O10",
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
        /// Converts the given MimeBase64EncodingCharacters enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(MimeBase64EncodingCharacters input)
        {
            return input switch
            {
                MimeBase64EncodingCharacters.EqualsSign => "(pad)",
                MimeBase64EncodingCharacters.A => "0",
                MimeBase64EncodingCharacters.B => "1",
                MimeBase64EncodingCharacters.K => "10",
                MimeBase64EncodingCharacters.L => "11",
                MimeBase64EncodingCharacters.M => "12",
                MimeBase64EncodingCharacters.N => "13",
                MimeBase64EncodingCharacters.O => "14",
                MimeBase64EncodingCharacters.P => "15",
                MimeBase64EncodingCharacters.Q => "16",
                MimeBase64EncodingCharacters.R => "17",
                MimeBase64EncodingCharacters.S => "18",
                MimeBase64EncodingCharacters.T => "19",
                MimeBase64EncodingCharacters.C => "2",
                MimeBase64EncodingCharacters.U => "20",
                MimeBase64EncodingCharacters.V => "21",
                MimeBase64EncodingCharacters.W => "22",
                MimeBase64EncodingCharacters.X => "23",
                MimeBase64EncodingCharacters.Y => "24",
                MimeBase64EncodingCharacters.Z => "25",
                MimeBase64EncodingCharacters.a => "26",
                MimeBase64EncodingCharacters.b => "27",
                MimeBase64EncodingCharacters.c => "28",
                MimeBase64EncodingCharacters.d => "29",
                MimeBase64EncodingCharacters.D => "3",
                MimeBase64EncodingCharacters.e => "30",
                MimeBase64EncodingCharacters.f => "31",
                MimeBase64EncodingCharacters.g => "32",
                MimeBase64EncodingCharacters.h => "33",
                MimeBase64EncodingCharacters.i => "34",
                MimeBase64EncodingCharacters.j => "35",
                MimeBase64EncodingCharacters.k => "36",
                MimeBase64EncodingCharacters.l => "37",
                MimeBase64EncodingCharacters.m => "38",
                MimeBase64EncodingCharacters.n => "39",
                MimeBase64EncodingCharacters.E => "4",
                MimeBase64EncodingCharacters.o => "40",
                MimeBase64EncodingCharacters.p => "41",
                MimeBase64EncodingCharacters.q => "42",
                MimeBase64EncodingCharacters.r => "43",
                MimeBase64EncodingCharacters.s => "44",
                MimeBase64EncodingCharacters.t => "45",
                MimeBase64EncodingCharacters.u => "46",
                MimeBase64EncodingCharacters.v => "47",
                MimeBase64EncodingCharacters.w => "48",
                MimeBase64EncodingCharacters.x => "49",
                MimeBase64EncodingCharacters.F => "5",
                MimeBase64EncodingCharacters.y => "50",
                MimeBase64EncodingCharacters.z => "51",
                MimeBase64EncodingCharacters.Number0 => "52",
                MimeBase64EncodingCharacters.Number1 => "53",
                MimeBase64EncodingCharacters.Number2 => "54",
                MimeBase64EncodingCharacters.Number3 => "55",
                MimeBase64EncodingCharacters.Number4 => "56",
                MimeBase64EncodingCharacters.Number5 => "57",
                MimeBase64EncodingCharacters.Number6 => "58",
                MimeBase64EncodingCharacters.Number7 => "59",
                MimeBase64EncodingCharacters.G => "6",
                MimeBase64EncodingCharacters.Number8 => "60",
                MimeBase64EncodingCharacters.Number9 => "61",
                MimeBase64EncodingCharacters.PlusSign => "62",
                MimeBase64EncodingCharacters.ForwardSlash => "63",
                MimeBase64EncodingCharacters.H => "7",
                MimeBase64EncodingCharacters.I => "8",
                MimeBase64EncodingCharacters.J => "9",
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
                NameType.AdoptedName => "C",
                NameType.CustomaryName => "D",
                NameType.LicensingName => "I",
                NameType.OfficialRegistryName => "L",
                NameType.MaidenName => "M",
                NameType.Nickname => "N",
                NameType.NameOfPartnerSpouse => "P",
                NameType.RegisteredName => "R",
                NameType.Pseudonym => "S",
                NameType.IndigenousTribal => "T",
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
                NatureOfAbnormalTesting.None => "N",
                NatureOfAbnormalTesting.RaceBasedPopulation => "R",
                NatureOfAbnormalTesting.SexBasedPopulation => "S",
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
                OccurrenceCode.AutoAccident => "01",
                OccurrenceCode.NoFaultInsuranceInvolved => "02",
                OccurrenceCode.AccidentTortLiability => "03",
                OccurrenceCode.AccidentEmploymentRelated => "04",
                OccurrenceCode.OtherAccident => "05",
                OccurrenceCode.CrimeVictim => "06",
                OccurrenceCode.StartOfInfertilityTreatment => "09",
                OccurrenceCode.LastMenstrualPeriod => "10",
                OccurrenceCode.OnsetOfSymptomsIllness => "11",
                OccurrenceCode.DateOfOnsetForChronicallyDependent => "12",
                OccurrenceCode.DateOutpatientOccupationalTherapyPlanEstablishedOrReviewed => "17",
                OccurrenceCode.DateOfRetirementPatientBeneficiary => "18",
                OccurrenceCode.DateOfRetirementSpouse => "19",
                OccurrenceCode.GuaranteeOfPaymentBegan => "20",
                OccurrenceCode.UrNoticeReceived => "21",
                OccurrenceCode.DateActiveCareEnded => "22",
                OccurrenceCode.DateInsuranceDenied => "24",
                OccurrenceCode.DateBenefitsTerminatedByPrimaryPayor => "25",
                OccurrenceCode.DateSnfBedAvailable => "26",
                OccurrenceCode.DateHomeHealthPlanEstablished => "27",
                OccurrenceCode.SpousesDateOfBirth => "28",
                OccurrenceCode.DateOutpatientPhysicalTherapyPlanEstablishedOrReviewed => "29",
                OccurrenceCode.DateOutpatientSpeechPathologyPlanEstablishedOrReviewed => "30",
                OccurrenceCode.DateBeneficiaryNotifiedOfIntentToBillAccommodations => "31",
                OccurrenceCode.DateBeneficiaryNotifiedOfIntentToBillTreatments => "32",
                OccurrenceCode.FirstDayOfMedicareCoordinationPeriodForEsrdBeneficiariesCoveredByEghp => "33",
                OccurrenceCode.DateOfElectionOfExtendedCareFacilities => "34",
                OccurrenceCode.DateTreatmentStartedForPT => "35",
                OccurrenceCode.DateOfInpatientDischargeForCoveredTransplantPatients => "36",
                OccurrenceCode.DateOfInpatientDischargeForNonCoveredTransplantPatient => "37",
                OccurrenceCode.ScheduledDateOfAdmission => "40",
                OccurrenceCode.DateOfFirstTestForPreAdmissionTesting => "41",
                OccurrenceCode.DateOfDischarge => "42",
                OccurrenceCode.ScheduledDateOfCanceledSurgery => "43",
                OccurrenceCode.DateTreatmentStartedForOT => "44",
                OccurrenceCode.DateTreatmentStartedForST => "45",
                OccurrenceCode.DateTreatmentStartedForCardiacRehab => "46",
                OccurrenceCode.PayerCodes47 => "47",
                OccurrenceCode.PayerCodes47To49 => "47 ... 49",
                OccurrenceCode.PayerCodes48 => "48",
                OccurrenceCode.PayerCodes49 => "49",
                OccurrenceCode.DateLienReleased => "50",
                OccurrenceCode.DateTreatmentStartedForPsychiatricCare => "51",
                OccurrenceCode.OccurrenceSpanCodesAndDates => "70",
                OccurrenceCode.OccurrenceSpanCodesAndDates70To99 => "70 ... 99",
                OccurrenceCode.OccurrenceSpanCodesAndDates71 => "71",
                OccurrenceCode.OccurrenceSpanCodesAndDates72 => "72",
                OccurrenceCode.OccurrenceSpanCodesAndDates73 => "73",
                OccurrenceCode.OccurrenceSpanCodesAndDates74 => "74",
                OccurrenceCode.OccurrenceSpanCodesAndDates75 => "75",
                OccurrenceCode.OccurrenceSpanCodesAndDates76 => "76",
                OccurrenceCode.OccurrenceSpanCodesAndDates77 => "77",
                OccurrenceCode.OccurrenceSpanCodesAndDates78 => "78",
                OccurrenceCode.OccurrenceSpanCodesAndDates79 => "79",
                OccurrenceCode.OccurrenceSpanCodesAndDates80 => "80",
                OccurrenceCode.OccurrenceSpanCodesAndDates81 => "81",
                OccurrenceCode.OccurrenceSpanCodesAndDates82 => "82",
                OccurrenceCode.OccurrenceSpanCodesAndDates83 => "83",
                OccurrenceCode.OccurrenceSpanCodesAndDates84 => "84",
                OccurrenceCode.OccurrenceSpanCodesAndDates85 => "85",
                OccurrenceCode.OccurrenceSpanCodesAndDates86 => "86",
                OccurrenceCode.OccurrenceSpanCodesAndDates87 => "87",
                OccurrenceCode.OccurrenceSpanCodesAndDates88 => "88",
                OccurrenceCode.OccurrenceSpanCodesAndDates89 => "89",
                OccurrenceCode.OccurrenceSpanCodesAndDates90 => "90",
                OccurrenceCode.OccurrenceSpanCodesAndDates91 => "91",
                OccurrenceCode.OccurrenceSpanCodesAndDates92 => "92",
                OccurrenceCode.OccurrenceSpanCodesAndDates93 => "93",
                OccurrenceCode.OccurrenceSpanCodesAndDates94 => "94",
                OccurrenceCode.OccurrenceSpanCodesAndDates95 => "95",
                OccurrenceCode.OccurrenceSpanCodesAndDates96 => "96",
                OccurrenceCode.OccurrenceSpanCodesAndDates97 => "97",
                OccurrenceCode.OccurrenceSpanCodesAndDates98 => "98",
                OccurrenceCode.OccurrenceSpanCodesAndDates99 => "99",
                OccurrenceCode.BirthdateInsuredA => "A1",
                OccurrenceCode.EffectiveDateInsuredAPolicy => "A2",
                OccurrenceCode.BenefitsExhaustedPayerA => "A3",
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
                OccurrenceSpan.QualifyingStayDatesForSnf => "70",
                OccurrenceSpan.PriorStayDates => "71",
                OccurrenceSpan.FirstLastVisit => "72",
                OccurrenceSpan.BenefitEligibilityPeriod => "73",
                OccurrenceSpan.NonCoveredLevelOfCare => "74",
                OccurrenceSpan.SnfLevelOfCare => "75",
                OccurrenceSpan.PatientLiability => "76",
                OccurrenceSpan.ProviderLiabilityPeriod => "77",
                OccurrenceSpan.SnfPriorStayDates => "78",
                OccurrenceSpan.PayerCode => "79",
                OccurrenceSpan.PsroUrApprovedStayDates => "M0",
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
                OrderControlCodes.NumberAssigned => "NA",
                OrderControlCodes.NewOrderService => "NW",
                OrderControlCodes.OrderServiceCanceled => "OC",
                OrderControlCodes.OrderServiceDiscontinued => "OD",
                OrderControlCodes.OrderServiceReleased => "OE",
                OrderControlCodes.OrderServiceRefilledAsRequested => "OF",
                OrderControlCodes.OrderServiceHeld => "OH",
                OrderControlCodes.OrderServiceAcceptedOk => "OK",
                OrderControlCodes.ReleasedAsRequested => "OR",
                OrderControlCodes.ParentOrderService => "PA",
                OrderControlCodes.PreviousResultsWithNewOrderService => "PR",
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
                PractitionerOrganizationUnitType.LocalMarketArea => "L",
                PractitionerOrganizationUnitType.MedicalCenterArea => "M",
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
        /// Converts the given ProcedurePractitionerIdentifierCodeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ProcedurePractitionerIdentifierCodeType input)
        {
            return input switch
            {
                ProcedurePractitionerIdentifierCodeType.AnesthesiologistAnesthetist => "AN",
                ProcedurePractitionerIdentifierCodeType.AssistantSurgeon => "AS",
                ProcedurePractitionerIdentifierCodeType.CertifiedNurseMidwife => "CM",
                ProcedurePractitionerIdentifierCodeType.NursePractitioner => "NP",
                ProcedurePractitionerIdentifierCodeType.ProcedureMdSurgeon => "PR",
                ProcedurePractitionerIdentifierCodeType.PrimarySurgeon => "PS",
                ProcedurePractitionerIdentifierCodeType.Radiologist => "RD",
                ProcedurePractitionerIdentifierCodeType.Resident => "RS",
                ProcedurePractitionerIdentifierCodeType.ScrubNurse => "SN",
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
                ProcedurePriority.TheAdmittingProcedure => "0",
                ProcedurePriority.ThePrimaryProcedure => "1",
                ProcedurePriority.ForRankedSecondaryProcedures => "2",
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
                ProviderRole.Attending => "AT",
                ProviderRole.ConsultingProvider => "CP",
                ProviderRole.FamilyHealthCareProfessional => "FHCP",
                ProviderRole.PrimaryCareProvider => "PP",
                ProviderRole.ReferringProvider => "RP",
                ProviderRole.ReferredToProvider => "RT",
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
        /// Converts the given QueryResponseFormatCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(QueryResponseFormatCode input)
        {
            return input switch
            {
                QueryResponseFormatCode.ResponseIsInDisplayFormat => "D",
                QueryResponseFormatCode.ResponseIsInRecordOrientedFormat => "R",
                QueryResponseFormatCode.ResponseIsInTabularFormat => "T",
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
        /// Converts the given QueryResultsLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(QueryResultsLevel input)
        {
            return input switch
            {
                QueryResultsLevel.OrderPlusOrderStatus => "O",
                QueryResultsLevel.ResultsWithoutBulkText => "R",
                QueryResultsLevel.StatusOnly => "S",
                QueryResultsLevel.FullResults => "T",
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
                Religion.ChristianEasternOrthodox => "EOT",
                Religion.ChristianEpiscopalian => "EPI",
                Religion.EthnicReligionist => "ERL",
                Religion.ChristianEvangelicalChurch => "EVC",
                Religion.ChristianFriends => "FRQ",
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
                Religion.ChristianFriendsDeprecated => "QUA",
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
        /// Converts the given ReportPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ReportPriority input)
        {
            return input switch
            {
                ReportPriority.Routine => "R",
                ReportPriority.Stat => "S",
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
                RevenueCode.IvTherapy => "260",
                RevenueCode.Oncology => "280",
                RevenueCode.LabChemistry => "301",
                RevenueCode.CafeteriaGuestTray => "991",
                RevenueCode.TelephoneTelegraph => "993",
                RevenueCode.TvRadio => "994",
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
                SegmentGroup.ObrGroup => "OBRG",
                SegmentGroup.OrcGroup => "ORCG",
                SegmentGroup.PidGroup => "PIDG",
                SegmentGroup.RxaGroup => "RXAG",
                SegmentGroup.RxdGroup => "RXDG",
                SegmentGroup.RxeGroup => "RXEG",
                SegmentGroup.RxoGroup => "RXOG",
                SegmentGroup.Etc => "etc",
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
                SpecialHandlingCode.BodyTemperature => "C37",
                SpecialHandlingCode.CriticalAmbientTemperature => "CAMB",
                SpecialHandlingCode.ProtectFromAir => "CATM",
                SpecialHandlingCode.CriticalFrozenTemperature => "CFRZ",
                SpecialHandlingCode.CriticalRefrigeratedTemperature => "CREF",
                SpecialHandlingCode.ProtectFromLight => "PRTL",
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
                SpecimenRole.Patient => "P",
                SpecimenRole.ControlSpecimen => "Q",
                SpecimenRole.Replicate => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SpecimenSourceCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SpecimenSourceCodes input)
        {
            return input switch
            {
                SpecimenSourceCodes.Abscess => "ABS",
                SpecimenSourceCodes.AmnioticFluid => "AMN",
                SpecimenSourceCodes.Aspirate => "ASP",
                SpecimenSourceCodes.BloodBag => "BBL",
                SpecimenSourceCodes.WholeBody => "BDY",
                SpecimenSourceCodes.BileFluid => "BIFL",
                SpecimenSourceCodes.WholeBlood => "BLD",
                SpecimenSourceCodes.BloodArterial => "BLDA",
                SpecimenSourceCodes.BloodCapillary => "BLDC",
                SpecimenSourceCodes.CordBlood => "BLDCO",
                SpecimenSourceCodes.BloodVenous => "BLDV",
                SpecimenSourceCodes.Bone => "BON",
                SpecimenSourceCodes.Basophils => "BPH",
                SpecimenSourceCodes.BloodProductUnit => "BPU",
                SpecimenSourceCodes.Burn => "BRN",
                SpecimenSourceCodes.Bronchial => "BRO",
                SpecimenSourceCodes.Breath => "BRTH",
                SpecimenSourceCodes.Calculus => "CALC",
                SpecimenSourceCodes.CordBloodCbld => "CBLD",
                SpecimenSourceCodes.CardiacMuscle => "CDM",
                SpecimenSourceCodes.Conjunctiva => "CNJT",
                SpecimenSourceCodes.Cannula => "CNL",
                SpecimenSourceCodes.Colostrum => "COL",
                SpecimenSourceCodes.CerebralSpinalFluid => "CSF",
                SpecimenSourceCodes.CatheterTip => "CTP",
                SpecimenSourceCodes.Curettage => "CUR",
                SpecimenSourceCodes.CervicalMucus => "CVM",
                SpecimenSourceCodes.Cervix => "CVX",
                SpecimenSourceCodes.Cyst => "CYST",
                SpecimenSourceCodes.DialysisFluid => "DIAF",
                SpecimenSourceCodes.DoseMedOrSubstance => "DOSE",
                SpecimenSourceCodes.Drain => "DRN",
                SpecimenSourceCodes.DuodenalFluid => "DUFL",
                SpecimenSourceCodes.Ear => "EAR",
                SpecimenSourceCodes.EarWax => "EARW",
                SpecimenSourceCodes.Electrode => "ELT",
                SpecimenSourceCodes.Endocardium => "ENDC",
                SpecimenSourceCodes.Endometrium => "ENDM",
                SpecimenSourceCodes.Eosinophils => "EOS",
                SpecimenSourceCodes.ExhaledGas => "EXG",
                SpecimenSourceCodes.ExhaledGasExhld => "EXHLD",
                SpecimenSourceCodes.Eye => "EYE",
                SpecimenSourceCodes.Fibroblasts => "FIB",
                SpecimenSourceCodes.Fistula => "FIST",
                SpecimenSourceCodes.Filter => "FLT",
                SpecimenSourceCodes.BodyFluidUnsp => "FLU",
                SpecimenSourceCodes.Gas => "GAS",
                SpecimenSourceCodes.GastricFluidContents => "GAST",
                SpecimenSourceCodes.Genital => "GEN",
                SpecimenSourceCodes.GenitalCervix => "GENC",
                SpecimenSourceCodes.GenitalLochia => "GENL",
                SpecimenSourceCodes.GenitalVaginal => "GENV",
                SpecimenSourceCodes.Hair => "HAR",
                SpecimenSourceCodes.InhaledGas => "IHG",
                SpecimenSourceCodes.Isolate => "ISLT",
                SpecimenSourceCodes.IntubationTube => "IT",
                SpecimenSourceCodes.Lamella => "LAM",
                SpecimenSourceCodes.LiquidNos => "LIQ",
                SpecimenSourceCodes.Line => "LN",
                SpecimenSourceCodes.LineArterial => "LNA",
                SpecimenSourceCodes.LineVenous => "LNV",
                SpecimenSourceCodes.Lymphocytes => "LYM",
                SpecimenSourceCodes.Macrophages => "MAC",
                SpecimenSourceCodes.Marrow => "MAR",
                SpecimenSourceCodes.MenstrualBlood => "MBLD",
                SpecimenSourceCodes.Meconium => "MEC",
                SpecimenSourceCodes.BreastMilk => "MILK",
                SpecimenSourceCodes.Milk => "MLK",
                SpecimenSourceCodes.Nail => "NAIL",
                SpecimenSourceCodes.Nose => "NOS",
                SpecimenSourceCodes.Other => "ORH",
                SpecimenSourceCodes.PancreaticFluid => "PAFL",
                SpecimenSourceCodes.Patient => "PAT",
                SpecimenSourceCodes.Plasma => "PLAS",
                SpecimenSourceCodes.PlasmaBag => "PLB",
                SpecimenSourceCodes.Placenta => "PLC",
                SpecimenSourceCodes.PleuralFluid => "PLR",
                SpecimenSourceCodes.PolymorphonuclearNeutrophils => "PMN",
                SpecimenSourceCodes.PlateletPoorPlasma => "PPP",
                SpecimenSourceCodes.PlateletRichPlasma => "PRP",
                SpecimenSourceCodes.PeritonealFluidAscites => "PRT",
                SpecimenSourceCodes.Pus => "PUS",
                SpecimenSourceCodes.Erythrocytes => "RBC",
                SpecimenSourceCodes.RouteOfMedicine => "RT",
                SpecimenSourceCodes.Saliva => "SAL",
                SpecimenSourceCodes.SeminalFluidSem => "SEM",
                SpecimenSourceCodes.Serum => "SER",
                SpecimenSourceCodes.SkeletalMuscle => "SKM",
                SpecimenSourceCodes.Skin => "SKN",
                SpecimenSourceCodes.SeminalFluid => "SMN",
                SpecimenSourceCodes.SynovialFluid => "SNV",
                SpecimenSourceCodes.Spermatozoa => "SPRM",
                SpecimenSourceCodes.Sputum => "SPT",
                SpecimenSourceCodes.SputumCoughed => "SPTC",
                SpecimenSourceCodes.SputumTrachealAspirate => "SPTT",
                SpecimenSourceCodes.StoolFecal => "STL",
                SpecimenSourceCodes.Stone => "STON",
                SpecimenSourceCodes.Sweat => "SWT",
                SpecimenSourceCodes.Tears => "TEAR",
                SpecimenSourceCodes.Thrombocyte => "THRB",
                SpecimenSourceCodes.Throat => "THRT",
                SpecimenSourceCodes.TissueGallBladder => "TISG",
                SpecimenSourceCodes.TissuePlacenta => "TISPL",
                SpecimenSourceCodes.Tissue => "TISS",
                SpecimenSourceCodes.TissueUlcer => "TISU",
                SpecimenSourceCodes.TissueLargeIntestine => "TLGI",
                SpecimenSourceCodes.TissueLung => "TLNG",
                SpecimenSourceCodes.TissueSmallIntestine => "TSMI",
                SpecimenSourceCodes.TubeNos => "TUB",
                SpecimenSourceCodes.Ulcer => "ULC",
                SpecimenSourceCodes.UmbilicalBlood => "UMB",
                SpecimenSourceCodes.UnknownMedicine => "UMED",
                SpecimenSourceCodes.Urine => "UR",
                SpecimenSourceCodes.UrineCleanCatch => "URC",
                SpecimenSourceCodes.UrineSediment => "URNS",
                SpecimenSourceCodes.UrineCatheter => "URT",
                SpecimenSourceCodes.Urethra => "URTH",
                SpecimenSourceCodes.UnknownSubstance => "USUB",
                SpecimenSourceCodes.VitreousFluid => "VITF",
                SpecimenSourceCodes.Vomitus => "VOM",
                SpecimenSourceCodes.Water => "WAT",
                SpecimenSourceCodes.Leukocytes => "WBC",
                SpecimenSourceCodes.Wick => "WICK",
                SpecimenSourceCodes.Wound => "WND",
                SpecimenSourceCodes.WoundAbscess => "WNDA",
                SpecimenSourceCodes.WoundDrainage => "WNDD",
                SpecimenSourceCodes.WoundExudate => "WNDE",
                SpecimenSourceCodes.ToBeSpecifiedInAnotherPartOfMessage => "XXX",
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
                SupplementalServiceInformationValues.First => "1ST",
                SupplementalServiceInformationValues.Second => "2ND",
                SupplementalServiceInformationValues.Third => "3RD",
                SupplementalServiceInformationValues.Fourth => "4TH",
                SupplementalServiceInformationValues.Fifth => "5TH",
                SupplementalServiceInformationValues.AnteriorPosterior => "A/P",
                SupplementalServiceInformationValues.Anterior => "ANT",
                SupplementalServiceInformationValues.Bilateral => "BLT",
                SupplementalServiceInformationValues.Decubitus => "DEC",
                SupplementalServiceInformationValues.Distal => "DST",
                SupplementalServiceInformationValues.Lateral => "LAT",
                SupplementalServiceInformationValues.Left => "LFT",
                SupplementalServiceInformationValues.LeftLowerQuadrant => "LLQ",
                SupplementalServiceInformationValues.Lower => "LOW",
                SupplementalServiceInformationValues.LeftUpperQuadrant => "LUQ",
                SupplementalServiceInformationValues.Medial => "MED",
                SupplementalServiceInformationValues.OperatingRoom => "OR",
                SupplementalServiceInformationValues.Pediatric => "PED",
                SupplementalServiceInformationValues.Posterior => "POS",
                SupplementalServiceInformationValues.Portable => "PRT",
                SupplementalServiceInformationValues.Proximal => "PRX",
                SupplementalServiceInformationValues.Recumbent => "REC",
                SupplementalServiceInformationValues.Right => "RGH",
                SupplementalServiceInformationValues.RightLowerQuadrant => "RLQ",
                SupplementalServiceInformationValues.RightUpperQuadrant => "RUQ",
                SupplementalServiceInformationValues.Upper => "UPP",
                SupplementalServiceInformationValues.Upright => "UPR",
                SupplementalServiceInformationValues.WithContrast => "WCT",
                SupplementalServiceInformationValues.WithoutContrast => "WOC",
                SupplementalServiceInformationValues.WithSedation => "WSD",
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
                TelecommunicationEquipmentType.X400EmailAddress => "X.400",
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
                TypeOfBillCode.HospitalOutpatientAdmitThruDischargeClaim => "131",
                TypeOfBillCode.HospitalOtherAdmitThruDischargeClaim => "141",
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
                UniversalIdType.DomainNameSystem => "DNS",
                UniversalIdType.GloballyUniqueIdentifier => "GUID",
                UniversalIdType.CenHealthcareCodingIdentifier => "HCD",
                UniversalIdType.Hl7RegistrationSchemes => "HL7",
                UniversalIdType.IsoObjectIdentifier => "ISO",
                UniversalIdType.LocalL => "L",
                UniversalIdType.LocalLMN => "L,M,N",
                UniversalIdType.LocalM => "M",
                UniversalIdType.LocalN => "N",
                UniversalIdType.Random => "Random",
                UniversalIdType.UniversalUniqueIdentifier => "UUID",
                UniversalIdType.X400MhsIdentifier => "x400",
                UniversalIdType.X500DirectoryName => "x500",
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
                VaccinesAdministered.Pertussis => "11",
                VaccinesAdministered.DiphtheriaAntitoxin => "12",
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
                ValueCode.MostCommonSemiPrivateRate => "01",
                ValueCode.HospitalHasNoSemiPrivateRooms => "02",
                ValueCode.InpatientChargesCombinedBilled => "04",
                ValueCode.ProfessionalComponentIncludedInChargesAndBilledCarrier => "05",
                ValueCode.MedicareBloodDeductible => "06",
                ValueCode.MedicareLifeTimeReserveAmountInFirstYear => "08",
                ValueCode.MedicareCoInsuranceAmountInFirstYear => "09",
                ValueCode.LifetimeReserveAmountInSecondYear => "10",
                ValueCode.CoInsuranceAmountInSecondYear => "11",
                ValueCode.WorkingAgedBeneficiarySpouseWithEmployerGroupPlan => "12",
                ValueCode.EsrdBeneficiaryInMedicareCoordPeriodWithEmployerGroupPlan => "13",
                ValueCode.NoFault => "14",
                ValueCode.WorkersCompensation => "15",
                ValueCode.PhsOrOtherFederalAgency => "16",
                ValueCode.PayerCode => "17",
                ValueCode.Catastrophic => "21",
                ValueCode.Surplus => "22",
                ValueCode.RecurringMonthlyIncode => "23",
                ValueCode.MedicaidRateCode => "24",
                ValueCode.PreAdmissionTesting => "30",
                ValueCode.PatientLiabilityAmount => "31",
                ValueCode.PintsOfBloodFurnished => "37",
                ValueCode.BloodDeductiblePints => "38",
                ValueCode.PintsOfBloodReplaced => "39",
                ValueCode.NewCoverageNotImplementedByHmo => "40",
                ValueCode.BlackLung => "41",
                ValueCode.Va => "42",
                ValueCode.DisabledBeneficiaryUnderAge64WithLghp => "43",
                ValueCode.AmountFromPayerLessThanChargesButHigherThanPayment => "44",
                ValueCode.AccidentHour => "45",
                ValueCode.NumberOfGraceDays => "46",
                ValueCode.AnyLiabilityInsurance => "47",
                ValueCode.HemoglobinReading => "48",
                ValueCode.HematocritReading => "49",
                ValueCode.PhysicalTherapyVisits => "50",
                ValueCode.OccupationalTherapyVisits => "51",
                ValueCode.SpeechTherapyVisits => "52",
                ValueCode.CardiacRehabVisits => "53",
                ValueCode.SkilledNurseHomeVisitHours => "56",
                ValueCode.HomeHealthAideHomeVisitHours => "57",
                ValueCode.ArterialBloodGas => "58",
                ValueCode.OxygenSaturation => "59",
                ValueCode.HhaBranchMsa => "60",
                ValueCode.PeritonealDialysis => "67",
                ValueCode.EpoDrug => "68",
                ValueCode.PayerCodes70 => "70",
                ValueCode.PayerCodes70To72 => "70 ... 72",
                ValueCode.PayerCodes71 => "71",
                ValueCode.PayerCodes72 => "72",
                ValueCode.PayerCodes75 => "75",
                ValueCode.PayerCodes75To79 => "75 ... 79",
                ValueCode.PayerCodes76 => "76",
                ValueCode.PayerCodes77 => "77",
                ValueCode.PayerCodes78 => "78",
                ValueCode.PayerCodes79 => "79",
                ValueCode.PsychiatricVisits => "80",
                ValueCode.VisitsSubjectToCoPayment => "81",
                ValueCode.DeductiblePayerA => "A1",
                ValueCode.CoinsurancePayerA => "A2",
                ValueCode.EstimatedResponsibilityPayerA => "A3",
                ValueCode.ServiceExcludedOnPrimaryPolicy => "X0",
                ValueCode.SupplementalCoverage => "X4",
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
        /// Converts the given WhatSubjectFilter enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(WhatSubjectFilter input)
        {
            return input switch
            {
                WhatSubjectFilter.AdviceDiagnosis => "ADV",
                WhatSubjectFilter.NursingUnitLookupExcludingEmptyBeds => "ANU",
                WhatSubjectFilter.AccountNumberQuery => "APA",
                WhatSubjectFilter.MedicalRecordNumberQuery => "APM",
                WhatSubjectFilter.PatientNameLookup => "APN",
                WhatSubjectFilter.PhysicianLookup => "APP",
                WhatSubjectFilter.NursingUnitLookupIncludingEmptyBeds => "ARN",
                WhatSubjectFilter.Cancel => "CAN",
                WhatSubjectFilter.Demographics => "DEM",
                WhatSubjectFilter.Financial => "FIN",
                WhatSubjectFilter.GenerateNewIdentifier => "GID",
                WhatSubjectFilter.Goals => "GOL",
                WhatSubjectFilter.MostRecentInpatient => "MRI",
                WhatSubjectFilter.MostRecentOutpatient => "MRO",
                WhatSubjectFilter.NetworkClock => "NCK",
                WhatSubjectFilter.NetworkStatusChange => "NSC",
                WhatSubjectFilter.NetworkStatistic => "NST",
                WhatSubjectFilter.Order => "ORD",
                WhatSubjectFilter.Other => "OTH",
                WhatSubjectFilter.Problems => "PRB",
                WhatSubjectFilter.Procedure => "PRO",
                WhatSubjectFilter.PharmacyAdministrationInfo => "RAR",
                WhatSubjectFilter.PharmacyDispenseInfo => "RDR",
                WhatSubjectFilter.PharmacyEncodedOrderInfo => "RER",
                WhatSubjectFilter.Result => "RES",
                WhatSubjectFilter.PharmacyGiveInfo => "RGR",
                WhatSubjectFilter.PharmacyPrescriptionInfo => "ROR",
                WhatSubjectFilter.AllScheduleRelatedInfo => "SAL",
                WhatSubjectFilter.BookedSlotsOnIdentifiedSchedule => "SBK",
                WhatSubjectFilter.BlockedSlotsOnIdentifiedSchedule => "SBL",
                WhatSubjectFilter.FirstOpenSlotOnIdentifiedSchedule => "SOF",
                WhatSubjectFilter.OpenSlotsOnIdentifiedSchedule => "SOP",
                WhatSubjectFilter.TimeSlotsAvailableForSingleAppointment => "SSA",
                WhatSubjectFilter.TimeSlotsAvailableForRecurringAppointment => "SSR",
                WhatSubjectFilter.Status => "STA",
                WhatSubjectFilter.VaccineInformation => "VXI",
                WhatSubjectFilter.GetCrossReferencedIds => "XID",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given WhichDateTimeQualifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(WhichDateTimeQualifier input)
        {
            return input switch
            {
                WhichDateTimeQualifier.AnyDateTimeWithinRange => "ANY",
                WhichDateTimeQualifier.CollectionDateTime => "COL",
                WhichDateTimeQualifier.OrderDateTime => "ORD",
                WhichDateTimeQualifier.SpecimenReceiptDateTime => "RCT",
                WhichDateTimeQualifier.ReportDateTime => "REP",
                WhichDateTimeQualifier.ScheduleDateTime => "SCHED",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given WhichDateTimeStatusQualifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(WhichDateTimeStatusQualifier input)
        {
            return input switch
            {
                WhichDateTimeStatusQualifier.AnyStatus => "ANY",
                WhichDateTimeStatusQualifier.CurrentFinalValueWhetherFinalOrCorrected => "CFN",
                WhichDateTimeStatusQualifier.CorrectedOnly => "COR",
                WhichDateTimeStatusQualifier.FinalOnly => "FIN",
                WhichDateTimeStatusQualifier.Preliminary => "PRE",
                WhichDateTimeStatusQualifier.ReportCompletionDateTime => "REP",
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