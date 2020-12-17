using System;

namespace ClearHl7.Fhir.Codes.V230.Helpers
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
        /// Converts the given AddressTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(AddressTypeCode input)
        {
            return input switch
            {
                AddressTypeCode.FirmBusiness => "B",
                AddressTypeCode.CurrentOrTemporary => "C",
                AddressTypeCode.CountryOfOrigin => "F",
                AddressTypeCode.Home => "H",
                AddressTypeCode.Mailing => "M",
                AddressTypeCode.OfficeBusiness => "O",
                AddressTypeCode.Permanent => "P",
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
                AdministrativeSex.Female => "F",
                AdministrativeSex.Male => "M",
                AdministrativeSex.Other => "O",
                AdministrativeSex.Unknown => "U",
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
                AdmissionType.Emergency => "E",
                AdmissionType.LaborAndDelivery => "L",
                AdmissionType.Routine => "R",
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
                AllergenType.DrugAllergy => "DA",
                AllergenType.FoodAllergy => "FA",
                AllergenType.MiscellaneousAllergy => "MA",
                AllergenType.MiscellaneousContraindication => "MC",
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
                AlternateCharacterSets.Iso2020Kanjii => "JAS2020",
                AlternateCharacterSets.Iso2022ForKanjii => "JIS X 0202",
                AlternateCharacterSets.IsoIec1064611993 => "UNICODE",
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
                BodySite.NebulizedDeprecated => "LNB",
                BodySite.LeftPosteriorChest => "LPC",
                BodySite.LeftSubclavian => "LSC",
                BodySite.LeftThigh => "LT",
                BodySite.LeftUpperArm => "LUA",
                BodySite.LeftUpperAbdQuadrant => "LUAQ",
                BodySite.LeftUpperForearm => "LUFA",
                BodySite.LeftVastusLateralisDeprecated => "LV",
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
                CheckDigitScheme.Mod10Algorithm => "M10",
                CheckDigitScheme.Mod11Algorithm => "M11",
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
        /// Converts the given ContactRole enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(ContactRole input)
        {
            return input switch
            {
                ContactRole.BillingContactPerson => "BP",
                ContactRole.ContactPerson => "CP",
                ContactRole.EmergencyContactPerson => "EP",
                ContactRole.PersonPreparingReferral => "PR",
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
        /// Converts the given DocumentAvailabilityStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(DocumentAvailabilityStatus input)
        {
            return input switch
            {
                DocumentAvailabilityStatus.AvailableForPatientCare => "AV",
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
                DocumentConfidentialityStatus.AstmLevel1 => "1",
                DocumentConfidentialityStatus.AstmLevel2 => "2",
                DocumentConfidentialityStatus.AstmLevel3 => "3",
                DocumentConfidentialityStatus.Restricted => "RE",
                DocumentConfidentialityStatus.UsualControl => "UC",
                DocumentConfidentialityStatus.VeryRestricted => "VR",
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
                EventTypeCode.OrmOrderMessage => "O01",
                EventTypeCode.OrrOrderResponse => "O02",
                EventTypeCode.BarAckAddPatientAccounts => "P01",
                EventTypeCode.BarAckPurgePatientAccounts => "P02",
                EventTypeCode.DftAckPostDetailFinancialTransaction => "P03",
                EventTypeCode.QryDspGenerateBillAndARStatements => "P04",
                EventTypeCode.BarAckUpdateAccount => "P05",
                EventTypeCode.BarAckEndAccount => "P06",
                EventTypeCode.PexUnsolicitedInitialExperienceReport => "P07",
                EventTypeCode.PexUnsolicitedUpdateExperienceReport => "P08",
                EventTypeCode.SurSummaryExperienceReport => "P09",
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
                EventTypeCode.OruAckUnsolicitedTransmissionOfObservation => "R01",
                EventTypeCode.QryQueryForResultsOfObservation => "R02",
                EventTypeCode.QryDsrDisplayOrientedResultsQueryUnsolUpdate => "R03",
                EventTypeCode.OrfResponseToQueryTransmissionOfRequestedObservation => "R04",
                EventTypeCode.QryDsrQueryForDisplayResults => "R05",
                EventTypeCode.UdmUnsolicitedUpdateDisplayResults => "R06",
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
                EventTypeCode.VxqQueryForVaccinationRecord => "V01",
                EventTypeCode.VxxResponseToVaccinationQueryMultiplePidMatches => "V02",
                EventTypeCode.VxrVaccinationRecordResponse => "V03",
                EventTypeCode.VxuUnsolicitedVaccinationRecordUpdate => "V04",
                EventTypeCode.MfqMfrMasterFilesQuery => "Varies",
                EventTypeCode.OruWaveformResultUnsolicitedTransmission => "W01",
                EventTypeCode.QrfWaveformResultResponseToQuery => "W02",
                EventTypeCode.PexProductExperience => "X01",
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
                IdentifierType.BirthRegistryNumber => "BR",
                IdentifierType.DinersClubCard => "DI",
                IdentifierType.DriversLicenseNumber => "DL",
                IdentifierType.DoctorNumber => "DN",
                IdentifierType.DiscoverCard => "DS",
                IdentifierType.EmployeeNumber => "EI",
                IdentifierType.EmployerNumber => "EN",
                IdentifierType.GuarantorInternalIdentifier => "GI",
                IdentifierType.GuarantorExternalIdentifier => "GN",
                IdentifierType.PatientMedicaidNumber => "MA",
                IdentifierType.PatientsMedicareNumber => "MC",
                IdentifierType.MedicalRecordNumber => "MR",
                IdentifierType.Mastercard => "MS",
                IdentifierType.PatientInternalIdentifier => "PI",
                IdentifierType.PatientExternalIdentifier => "PT",
                IdentifierType.RailroadRetirementNumber => "RR",
                IdentifierType.SocialSecurityNumber => "SS",
                IdentifierType.VisitNumber => "VN",
                IdentifierType.Visa => "VS",
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
                LivingDependency.CommonBathDeprecated => "CB",
                LivingDependency.SpouseDependentDeprecated => "D",
                LivingDependency.MedicalSupervisionRequired => "M",
                LivingDependency.SpouseDependent => "S",
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
                ManufacturersOfVaccines.BaxterHealthcareCorporationDeprecated => "BA",
                ManufacturersOfVaccines.BayerCorporation => "BAY",
                ManufacturersOfVaccines.BernaProducts => "BP",
                ManufacturersOfVaccines.Connaught => "CON",
                ManufacturersOfVaccines.EvansMedicalLimited => "EVN",
                ManufacturersOfVaccines.GreerLaboratoriesInc => "GRE",
                ManufacturersOfVaccines.Merieux => "IM",
                ManufacturersOfVaccines.ImmunoUSInc => "IUS",
                ManufacturersOfVaccines.ResearchFoundationForMicrobialDiseasesOfOsaka => "JPN",
                ManufacturersOfVaccines.KoreaGreenCrossCorporation => "KGC",
                ManufacturersOfVaccines.Lederle => "LED",
                ManufacturersOfVaccines.MassachusettsPublicHealthBiologicLabs => "MA",
                ManufacturersOfVaccines.Miles => "MIL",
                ManufacturersOfVaccines.BioportCorporation => "MIP",
                ManufacturersOfVaccines.MerckCoInc => "MSD",
                ManufacturersOfVaccines.Nabi => "NAB",
                ManufacturersOfVaccines.NewYorkBloodCenter => "NYB",
                ManufacturersOfVaccines.OrganonTeknikaCorporation => "OTC",
                ManufacturersOfVaccines.OtherManufacturer => "OTH",
                ManufacturersOfVaccines.ParkedalePharmaceuticals => "PD",
                ManufacturersOfVaccines.PraxisBiologics => "PRX",
                ManufacturersOfVaccines.SclavoInc => "SCL",
                ManufacturersOfVaccines.SwissSerumAndVaccineInst => "SI",
                ManufacturersOfVaccines.Glaxosmithkline => "SKB",
                ManufacturersOfVaccines.UnknownManufacturer => "UNK",
                ManufacturersOfVaccines.WyethAyerstDeprecated => "WA",
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
                MaritalStatus.Divorced => "D",
                MaritalStatus.Married => "M",
                MaritalStatus.Single => "S",
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
                MasterFileIdentifierCode.ClinicalStudyMaster => "CM0",
                MasterFileIdentifierCode.ClinicalStudyPhaseMaster => "CM1",
                MasterFileIdentifierCode.ClinicalStudyDataScheduleMaster => "CM2",
                MasterFileIdentifierCode.LocationMasterFile => "LOC",
                MasterFileIdentifierCode.OM1ObservationTextMasterFileSegments => "OM1",
                MasterFileIdentifierCode.OM1To6ObservationTextMasterFileSegments => "OM1-OM6",
                MasterFileIdentifierCode.OM2ObservationTextMasterFileSegments => "OM2",
                MasterFileIdentifierCode.OM3ObservationTextMasterFileSegments => "OM3",
                MasterFileIdentifierCode.OM4ObservationTextMasterFileSegments => "OM4",
                MasterFileIdentifierCode.OM5ObservationTextMasterFileSegments => "OM5",
                MasterFileIdentifierCode.OM6ObservationTextMasterFileSegments => "OM6",
                MasterFileIdentifierCode.PractitionerMasterFile => "PRA",
                MasterFileIdentifierCode.StaffMasterFile => "STF",
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
                MessageType.AncillaryRptDeprecated => "ARD",
                MessageType.AddChangeBillingAccount => "BAR",
                MessageType.CancelQueryDeprecated => "CNQ",
                MessageType.UnsolicitedStudyData => "CSU",
                MessageType.DetailFinancialTransactions => "DFT",
                MessageType.DocumentResponseDeprecated => "DOC",
                MessageType.DisplayResponseDeprecated => "DSR",
                MessageType.EnhancedDisplayResponseDeprecated => "EDR",
                MessageType.EmbeddedQueryLanguageQueryDeprecated => "EQQ",
                MessageType.EventReplayResponseDeprecated => "ERP",
                MessageType.EventReplayQueryDeprecated => "ERQ",
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
                MessageType.QueryForResultsOfObservationDeprecated => "ORF",
                MessageType.PharmacyTreatmentOrderDeprecated => "ORM",
                MessageType.GeneralOrderResponseToAnyOrmDeprecated => "ORR",
                MessageType.UnsolicitedTransmissionOfObservation => "ORU",
                MessageType.QueryResponseForOrderStatusOsqDeprecated => "OSQ",
                MessageType.QueryResponseForOrderStatusOsrDeprecated => "OSR",
                MessageType.ProductExperience => "PEX",
                MessageType.PatientGoalMessage => "PGL",
                MessageType.PatientInsuranceInformation => "PIN",
                MessageType.PatientPathwayGoalOriented => "PPG",
                MessageType.PatientProblem => "PPR",
                MessageType.PatientPathwayGoalOrientedResponseDeprecated => "PPT",
                MessageType.PatientGoalResponseDeprecated => "PPV",
                MessageType.PatientProblemResponseDeprecated => "PRR",
                MessageType.PatientPathwayProblemOrientedResponseDeprecated => "PTR",
                MessageType.QueryGeneralAcknowledgmentDeprecated => "QCK",
                MessageType.QueryOriginalMode => "QRY",
                MessageType.PharmacyTreatmentAdministrationInfoDeprecated => "RAR",
                MessageType.PharmacyTreatmentAdministration => "RAS",
                MessageType.ReturnClinicalInformation => "RCI",
                MessageType.ReturnClinicalList => "RCL",
                MessageType.PharmacyTreatmentEncodedOrder => "RDE",
                MessageType.PharmacyTreatmentDispenseInfo => "RDR",
                MessageType.PharmacyTreatmentDispense => "RDS",
                MessageType.PatientReferral => "REF",
                MessageType.PharmacyTreatmentEncodedOrderInformationDeprecated => "RER",
                MessageType.PharmacyTreatmentDoseInformationDeprecated => "RGR",
                MessageType.PharmacyTreatmentGive => "RGV",
                MessageType.RequestClinicalInfoDeprecated => "ROC",
                MessageType.RequestPatientDemographicsDeprecated => "ROD",
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
                MessageType.ScheduleInfoUnsolicited => "SIU",
                MessageType.StoredProcedureRequestDeprecated => "SPQ",
                MessageType.ScheduleQueryMessageDeprecated => "SQM",
                MessageType.ScheduleQueryResponseDeprecated => "SQR",
                MessageType.ScheduleRequestMessage => "SRM",
                MessageType.ScheduledRequestResponse => "SRR",
                MessageType.TabularDataResponseDeprecated => "TBR",
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
        /// Converts the given NameType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(NameType input)
        {
            return input switch
            {
                NameType.Assigned => "A",
                NameType.AdoptedName => "C",
                NameType.CustomaryName => "D",
                NameType.OfficialRegistryName => "L",
                NameType.MaidenName => "M",
                NameType.Other => "O",
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
                ObservationResultStatusCodesInterpretation.PreliminaryResults => "P",
                ObservationResultStatusCodesInterpretation.ResultsEnteredNotVerified => "R",
                ObservationResultStatusCodesInterpretation.PartialResults => "S",
                ObservationResultStatusCodesInterpretation.ResultsChangeToFinalWithoutRetransmit => "U",
                ObservationResultStatusCodesInterpretation.ResultsCannotBeObtainedForThisObservation => "X",
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
                OrganDonorCode.NoPatientHasNotAgreedToBeDonor => "N",
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
        /// Converts the given PatientClass enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(PatientClass input)
        {
            return input switch
            {
                PatientClass.Obstetrics => "B",
                PatientClass.Emergency => "E",
                PatientClass.Inpatient => "I",
                PatientClass.Outpatient => "O",
                PatientClass.Preadmit => "P",
                PatientClass.RecurringPatient => "R",
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
                ProviderRole.ConsultingProvider => "CP",
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
                Religion.Atheist => "A",
                Religion.Baptist => "B",
                Religion.Catholic => "C",
                Religion.Episcopalian => "E",
                Religion.Judaism => "J",
                Religion.Lutheran => "L",
                Religion.ChurchOfLatterDaySaintsMormon => "M",
                Religion.Hindu => "N",
                Religion.Protestant => "P",
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
                RouteOfAdministration.Intramuscular => "IM",
                RouteOfAdministration.ImmerseBodyPart => "IMR",
                RouteOfAdministration.Intranasal => "IN",
                RouteOfAdministration.Intraocular => "IO",
                RouteOfAdministration.Intraperitoneal => "IP",
                RouteOfAdministration.Intrasynovial => "IS",
                RouteOfAdministration.Intrathecal => "IT",
                RouteOfAdministration.Intravenous => "IV",
                RouteOfAdministration.MucousMembrane => "MM",
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
        /// Converts the given SubstitutionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string EnumToCode(SubstitutionStatus input)
        {
            return input switch
            {
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
                SubtypeOfReferencedData.TiffImageData => "TIFF",
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
                TransactionType.Payment => "PY",
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
                TypeOfReferencedData.NonScannedImage => "NS",
                TypeOfReferencedData.ScannedDocument => "SD",
                TypeOfReferencedData.ScannedImage => "SI",
                TypeOfReferencedData.MachineReadableTextDocument => "TX",
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
                WhatSubjectFilter.Status => "STA",
                WhatSubjectFilter.VaccineInformation => "VXI",
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
                WhichDateTimeQualifier.CancellationDateTime => "CAN",
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