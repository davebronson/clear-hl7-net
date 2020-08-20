using System;

namespace ClearHl7.Fhir.Codes.V220.Helpers
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
        public string ValueToCode(AcceptApplicationAcknowledgmentConditions input)
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
        /// Converts the given AcknowledgmentCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(AcknowledgmentCode input)
        {
            return input switch
            {
                AcknowledgmentCode.OriginalModeAcceptEnhancedModeAcknowledgmentAccept => "AA",
                AcknowledgmentCode.OriginalModeErrorEnhancedModeAcknowledgmentError => "AE",
                AcknowledgmentCode.OriginalModeRejectEnhancedModeAcknowledgmentReject => "AR",
                AcknowledgmentCode.EnhancedModeAcceptAcknowledgmentCommitAccept => "CA",
                AcknowledgmentCode.EnhancedModeAcceptAcknowledgmentCommitError => "CE",
                AcknowledgmentCode.EnhancedModeAcceptAcknowledgmentCommitReject => "CR",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ActiveInactive enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(ActiveInactive input)
        {
            return input switch
            {
                ActiveInactive.ActiveStaff => "A",
                ActiveInactive.InactiveStaff => "I",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AddressType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(AddressType input)
        {
            return input switch
            {
                AddressType.FirmBusiness => "B",
                AddressType.CurrentOrTemporary => "C",
                AddressType.Home => "H",
                AddressType.Mailing => "M",
                AddressType.OfficeBusiness => "O",
                AddressType.Permanent => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdministrationDevice enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(AdministrationDevice input)
        {
            return input switch
            {
                AdministrationDevice.Applicator => "AP",
                AdministrationDevice.Buretrol => "BT",
                AdministrationDevice.HeparinLock => "HL",
                AdministrationDevice.Ippb => "IPPB",
                AdministrationDevice.IvPump => "IVP",
                AdministrationDevice.IvSoluset => "IVS",
                AdministrationDevice.MeteredInhaler => "MI",
                AdministrationDevice.Nebulizer => "NEB",
                AdministrationDevice.PcaPump => "PCA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdministrationMethod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(AdministrationMethod input)
        {
            return input switch
            {
                AdministrationMethod.Chew => "CH",
                AdministrationMethod.Dissolve => "DI",
                AdministrationMethod.Dust => "DU",
                AdministrationMethod.Infiltrate => "IF",
                AdministrationMethod.Irrigate => "IR",
                AdministrationMethod.Insert => "IS",
                AdministrationMethod.IvPush => "IVP",
                AdministrationMethod.IvPiggyback => "IVPB",
                AdministrationMethod.Nebulized => "NB",
                AdministrationMethod.Perfuse => "PF",
                AdministrationMethod.Paint => "PT",
                AdministrationMethod.Shampoo => "SH",
                AdministrationMethod.Soak => "SO",
                AdministrationMethod.Wash => "WA",
                AdministrationMethod.Wipe => "WI",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given AdministrativeSex enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(AdministrativeSex input)
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
        public string ValueToCode(AdmissionType input)
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
        public string ValueToCode(AllergenType input)
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
        public string ValueToCode(AllergySeverity input)
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
        public string ValueToCode(AllowSubstitution input)
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
        /// Converts the given AmbulatoryStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(AmbulatoryStatus input)
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
        public string ValueToCode(AmountClass input)
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
        public string ValueToCode(AmountType input)
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
        /// Converts the given AssignmentOfBenefits enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(AssignmentOfBenefits input)
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
        public string ValueToCode(BedStatus input)
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
        public string ValueToCode(BodySite input)
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
        /// Converts the given CertificationPatientType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(CertificationPatientType input)
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
        /// Converts the given ChargeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(ChargeType input)
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
        public string ValueToCode(CheckDigitScheme input)
        {
            return input switch
            {
                CheckDigitScheme.Mod10Algorithm => "M10",
                CheckDigitScheme.Mod11Algorithm => "M11",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ConfidentialityCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(ConfidentialityCode input)
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
        /// Converts the given CoordinationOfBenefits enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(CoordinationOfBenefits input)
        {
            return input switch
            {
                CoordinationOfBenefits.Coordination => "CO",
                CoordinationOfBenefits.Independent => "IN",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given DateTimeSelectionQualifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(DateTimeSelectionQualifier input)
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
        /// Converts the given DayType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(DayType input)
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
        public string ValueToCode(DeferredResponseType input)
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
        public string ValueToCode(DelayedAcknowledgmentType input)
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
        public string ValueToCode(DerivedSpecimen input)
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
        /// Converts the given DiagnosticServiceSectionId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(DiagnosticServiceSectionId input)
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
                DiagnosticServiceSectionId.Immunology => "IMM",
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
        public string ValueToCode(DietCodeSpecificationType input)
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
        /// Converts the given EligibilitySource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(EligibilitySource input)
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
        /// Converts the given EventReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(EventReason input)
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
        /// Converts the given EventTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(EventTypeCode input)
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
                EventTypeCode.MfnMfkMasterFileNotOtherwiseSpecified => "M01",
                EventTypeCode.MfnMfkMasterFileStaffPractitioner => "M02",
                EventTypeCode.MfnMfkMasterFileTestObservation => "M03",
                EventTypeCode.OrmOrderMessage => "O01",
                EventTypeCode.OrrOrderResponse => "O02",
                EventTypeCode.BarAckAddPatientAccounts => "P01",
                EventTypeCode.BarAckPurgePatientAccounts => "P02",
                EventTypeCode.DftAckPostDetailFinancialTransaction => "P03",
                EventTypeCode.QryDspGenerateBillAndARStatements => "P04",
                EventTypeCode.QryDsrQuerySentForImmediateResponse => "Q01",
                EventTypeCode.QryQckQuerySentForDeferredResponse => "Q02",
                EventTypeCode.DsrAckDeferredResponseToAQuery => "Q03",
                EventTypeCode.UdmAckUnsolicitedDisplayUpdateMessage => "Q05",
                EventTypeCode.OruAckUnsolicitedTransmissionOfObservation => "R01",
                EventTypeCode.QryQueryForResultsOfObservation => "R02",
                EventTypeCode.QryDsrDisplayOrientedResultsQueryUnsolUpdate => "R03",
                EventTypeCode.OrfResponseToQueryTransmissionOfRequestedObservation => "R04",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given FileLevelEventCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(FileLevelEventCode input)
        {
            return input switch
            {
                FileLevelEventCode.ReplaceCurrentVersionOfMasterFile => "REP",
                FileLevelEventCode.ChangeFileRecordsAsDefined => "UPD",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given InterpretationCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(InterpretationCodes input)
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
        public string ValueToCode(InvocationEvent input)
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
        /// Converts the given MailClaimParty enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(MailClaimParty input)
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
        /// Converts the given MaritalStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(MaritalStatus input)
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
        /// Converts the given MasterfileActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(MasterfileActionCode input)
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
        public string ValueToCode(MasterFileIdentifierCode input)
        {
            return input switch
            {
                MasterFileIdentifierCode.ChargeDescriptionMasterFile => "CDM",
                MasterFileIdentifierCode.OM1ObservationTextMasterFileSegments => "OM1",
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
        public string ValueToCode(MessageType input)
        {
            return input switch
            {
                MessageType.GeneralAcknowledgment => "ACK",
                MessageType.AdtResponseDeprecated => "ADR",
                MessageType.AdtMessage => "ADT",
                MessageType.AncillaryRptDeprecated => "ARD",
                MessageType.AddChangeBillingAccount => "BAR",
                MessageType.DetailFinancialTransactions => "DFT",
                MessageType.DisplayResponseDeprecated => "DSR",
                MessageType.DelayedAcknowledgmentDeprecated => "MCF",
                MessageType.MasterFilesDelayedApplicationAcknowledgmentDeprecated => "MFD",
                MessageType.MasterFilesApplicationAcknowledgment => "MFK",
                MessageType.MasterFilesNotification => "MFN",
                MessageType.MasterFilesResponseDeprecated => "MFR",
                MessageType.ApplicationManagementData => "NMD",
                MessageType.ApplicationManagementQueryDeprecated => "NMQ",
                MessageType.ApplicationManagementResponseDeprecated => "NMR",
                MessageType.QueryForResultsOfObservationDeprecated => "ORF",
                MessageType.PharmacyTreatmentOrderDeprecated => "ORM",
                MessageType.GeneralOrderResponseToAnyOrmDeprecated => "ORR",
                MessageType.UnsolicitedTransmissionOfObservation => "ORU",
                MessageType.QueryResponseForOrderStatusOsqDeprecated => "OSQ",
                MessageType.QueryOriginalMode => "QRY",
                MessageType.PharmacyTreatmentAdministrationInfoDeprecated => "RAR",
                MessageType.PharmacyTreatmentAdministration => "RAS",
                MessageType.PharmacyTreatmentEncodedOrder => "RDE",
                MessageType.PharmacyTreatmentDispenseInfo => "RDR",
                MessageType.PharmacyTreatmentDispense => "RDS",
                MessageType.PharmacyTreatmentEncodedOrderInformationDeprecated => "RER",
                MessageType.PharmacyTreatmentDoseInformationDeprecated => "RGR",
                MessageType.PharmacyTreatmentGive => "RGV",
                MessageType.PharmacyTreatmentOrderResponseDeprecated => "ROR",
                MessageType.PharmacyTreatmentAdministrationAcknowledgment => "RRA",
                MessageType.PharmacyTreatmentDispenseAcknowledgment => "RRD",
                MessageType.PharmacyTreatmentEncodedOrderAcknowledgment => "RRE",
                MessageType.PharmacyTreatmentGiveAcknowledgment => "RRG",
                MessageType.UnsolicitedDisplayUpdateMessage => "UDM",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MfnRecordLevelErrorReturn enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(MfnRecordLevelErrorReturn input)
        {
            return input switch
            {
                MfnRecordLevelErrorReturn.SuccessfulPostingOfTheRecord => "S",
                MfnRecordLevelErrorReturn.UnsuccessfulPostingOfTheRecord => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given MoneyOrPercentageIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(MoneyOrPercentageIndicator input)
        {
            return input switch
            {
                MoneyOrPercentageIndicator.CurrencyAmount => "AT",
                MoneyOrPercentageIndicator.Percentage => "PC",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given NatureOfAbnormalTesting enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(NatureOfAbnormalTesting input)
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
        /// Converts the given NatureOfServiceTestObservation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(NatureOfServiceTestObservation input)
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
        public string ValueToCode(ObservationResultStatusCodesInterpretation input)
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
        public string ValueToCode(OrderControlCodes input)
        {
            return input switch
            {
                OrderControlCodes.CancelOrderServiceRequest => "CA",
                OrderControlCodes.ChildOrderService => "CH",
                OrderControlCodes.CombinedResult => "CN",
                OrderControlCodes.CanceledAsRequested => "CR",
                OrderControlCodes.DiscontinueOrderServiceRequest => "DC",
                OrderControlCodes.DataErrors => "DE",
                OrderControlCodes.DiscontinuedAsRequested => "DR",
                OrderControlCodes.HoldOrderRequest => "HD",
                OrderControlCodes.OnHoldAsRequested => "HR",
                OrderControlCodes.NumberAssigned => "NA",
                OrderControlCodes.NewOrderService => "NW",
                OrderControlCodes.OrderServiceCanceled => "OC",
                OrderControlCodes.OrderServiceDiscontinued => "OD",
                OrderControlCodes.OrderServiceHeld => "OH",
                OrderControlCodes.OrderServiceAcceptedOk => "OK",
                OrderControlCodes.ReleasedAsRequested => "OR",
                OrderControlCodes.ParentOrderService => "PA",
                OrderControlCodes.ObservationsPerformedServiceToFollow => "RE",
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
                OrderControlCodes.UnableToCancel => "UC",
                OrderControlCodes.UnableToDiscontinue => "UD",
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
        public string ValueToCode(OrderStatus input)
        {
            return input switch
            {
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
        /// Converts the given PatientClass enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(PatientClass input)
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
        /// Converts the given PolicyType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(PolicyType input)
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
        /// Converts the given PreferredMethodOfContact enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(PreferredMethodOfContact input)
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
        /// Converts the given Priority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(Priority input)
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
        /// Converts the given ProcedurePractitionerIdentifierCodeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(ProcedurePractitionerIdentifierCodeType input)
        {
            return input switch
            {
                ProcedurePractitionerIdentifierCodeType.AnesthesiologistAnesthetist => "AN",
                ProcedurePractitionerIdentifierCodeType.CertifiedNurseMidwife => "CM",
                ProcedurePractitionerIdentifierCodeType.NursePractitioner => "NP",
                ProcedurePractitionerIdentifierCodeType.ProcedureMdSurgeon => "PR",
                ProcedurePractitionerIdentifierCodeType.Radiologist => "RD",
                ProcedurePractitionerIdentifierCodeType.Resident => "RS",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ProcessingId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(ProcessingId input)
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
        /// Converts the given ProcessingPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(ProcessingPriority input)
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
        /// Converts the given ProviderBilling enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(ProviderBilling input)
        {
            return input switch
            {
                ProviderBilling.InstitutionBillsForProvider => "I",
                ProviderBilling.ProviderDoesOwnBilling => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given QuantityLimitedRequest enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(QuantityLimitedRequest input)
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
        /// Converts the given QueryPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(QueryPriority input)
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
        public string ValueToCode(QueryResponseFormatCode input)
        {
            return input switch
            {
                QueryResponseFormatCode.ResponseIsInDisplayFormat => "D",
                QueryResponseFormatCode.ResponseIsInRecordOrientedFormat => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given QueryResultsLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(QueryResultsLevel input)
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
        public string ValueToCode(ReadmissionIndicator input)
        {
            return input switch
            {
                ReadmissionIndicator.ReAdmission => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Religion enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(Religion input)
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
        public string ValueToCode(ReportingPriority input)
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
        public string ValueToCode(ReportPriority input)
        {
            return input switch
            {
                ReportPriority.Routine => "R",
                ReportPriority.Stat => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given ResponseFlag enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(ResponseFlag input)
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
        public string ValueToCode(ResponseLevel input)
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
        public string ValueToCode(ResultStatus input)
        {
            return input switch
            {
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
        public string ValueToCode(RoomType input)
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
        public string ValueToCode(RouteOfAdministration input)
        {
            return input switch
            {
                RouteOfAdministration.ApplyExternally => "AP",
                RouteOfAdministration.Buccal => "B",
                RouteOfAdministration.Dental => "DT",
                RouteOfAdministration.GastrostomyTube => "GTT",
                RouteOfAdministration.GuIrrigant => "GU",
                RouteOfAdministration.IntraArterial => "IA",
                RouteOfAdministration.Intracardiac => "IC",
                RouteOfAdministration.Intradermal => "ID",
                RouteOfAdministration.Inhalation => "IH",
                RouteOfAdministration.Intramuscular => "IM",
                RouteOfAdministration.Intranasal => "IN",
                RouteOfAdministration.Intraocular => "IO",
                RouteOfAdministration.Intraperitoneal => "IP",
                RouteOfAdministration.Intrasynovial => "IS",
                RouteOfAdministration.Intrathecal => "IT",
                RouteOfAdministration.Intravenous => "IV",
                RouteOfAdministration.Nasogastric => "NG",
                RouteOfAdministration.Nasal => "NS",
                RouteOfAdministration.Ophthalmic => "OP",
                RouteOfAdministration.Otic => "OT",
                RouteOfAdministration.Oral => "PO",
                RouteOfAdministration.Rectal => "PR",
                RouteOfAdministration.Subcutaneous => "SC",
                RouteOfAdministration.Sublingual => "SL",
                RouteOfAdministration.Transdermal => "TD",
                RouteOfAdministration.Translingual => "TL",
                RouteOfAdministration.Topical => "TP",
                RouteOfAdministration.Urethral => "UR",
                RouteOfAdministration.Vaginal => "VG",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given RXComponentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(RXComponentType input)
        {
            return input switch
            {
                RXComponentType.Additive => "A",
                RXComponentType.Base => "B",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SourceOfComment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(SourceOfComment input)
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
        /// Converts the given SpecimenActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(SpecimenActionCode input)
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
        public string ValueToCode(SpecimenSourceCodes input)
        {
            return input switch
            {
                SpecimenSourceCodes.ArterialBlood => "ABLD",
                SpecimenSourceCodes.Abscess => "ABS",
                SpecimenSourceCodes.AmnioticFluid => "AMN",
                SpecimenSourceCodes.Aspirate => "ASP",
                SpecimenSourceCodes.BloodBag => "BBL",
                SpecimenSourceCodes.WholeBody => "BDY",
                SpecimenSourceCodes.WholeBlood => "BLD",
                SpecimenSourceCodes.Bone => "BON",
                SpecimenSourceCodes.Basophils => "BPH",
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
                SpecimenSourceCodes.Drain => "DRN",
                SpecimenSourceCodes.Ear => "EAR",
                SpecimenSourceCodes.Electrode => "ELT",
                SpecimenSourceCodes.Endocardium => "ENDC",
                SpecimenSourceCodes.Endometrium => "ENDM",
                SpecimenSourceCodes.Eosinophils => "EOS",
                SpecimenSourceCodes.Fibroblasts => "FIB",
                SpecimenSourceCodes.Fistula => "FIST",
                SpecimenSourceCodes.Filter => "FLT",
                SpecimenSourceCodes.BodyFluidUnsp => "FLU",
                SpecimenSourceCodes.GastricFluidContents => "GAST",
                SpecimenSourceCodes.Genital => "GEN",
                SpecimenSourceCodes.GenitalCervix => "GENC",
                SpecimenSourceCodes.GenitalLochia => "GENL",
                SpecimenSourceCodes.GenitalVaginal => "GENV",
                SpecimenSourceCodes.Hair => "HAR",
                SpecimenSourceCodes.IntubationTube => "IT",
                SpecimenSourceCodes.Lamella => "LAM",
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
                SpecimenSourceCodes.Peritoneum => "PER",
                SpecimenSourceCodes.Plasma => "PLAS",
                SpecimenSourceCodes.PlasmaBag => "PLB",
                SpecimenSourceCodes.Placenta => "PLC",
                SpecimenSourceCodes.PleuralFluid => "PLR",
                SpecimenSourceCodes.PolymorphonuclearNeutrophils => "PMN",
                SpecimenSourceCodes.PeritonealFluidAscites => "PRT",
                SpecimenSourceCodes.Pus => "PUS",
                SpecimenSourceCodes.Erythrocytes => "RBC",
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
                SpecimenSourceCodes.TissueBoneMarrow => "TISB",
                SpecimenSourceCodes.TissueCurettage => "TISC",
                SpecimenSourceCodes.TissueGallBladder => "TISG",
                SpecimenSourceCodes.TissueLung => "TISL",
                SpecimenSourceCodes.TissuePeritoneum => "TISP",
                SpecimenSourceCodes.TissuePlacenta => "TISPL",
                SpecimenSourceCodes.Tissue => "TISS",
                SpecimenSourceCodes.TissueUlcer => "TISU",
                SpecimenSourceCodes.Ulcer => "ULC",
                SpecimenSourceCodes.UmbilicalBlood => "UMB",
                SpecimenSourceCodes.Urine => "UR",
                SpecimenSourceCodes.UrineCleanCatch => "URC",
                SpecimenSourceCodes.UrineCatheter => "URT",
                SpecimenSourceCodes.Urethra => "URTH",
                SpecimenSourceCodes.Vomitus => "VOM",
                SpecimenSourceCodes.Leukocytes => "WBC",
                SpecimenSourceCodes.Wick => "WICK",
                SpecimenSourceCodes.Wound => "WND",
                SpecimenSourceCodes.WoundAbscess => "WNDA",
                SpecimenSourceCodes.WoundDrainage => "WNDD",
                SpecimenSourceCodes.WoundExudate => "WNDE",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given StockLocation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(StockLocation input)
        {
            return input switch
            {
                StockLocation.FilledFromAncillaryDepartmentStock => "AN",
                StockLocation.FilledFromFloorStock => "FL",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SubstitutionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(SubstitutionStatus input)
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
        /// Converts the given TransportationMode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(TransportationMode input)
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
        public string ValueToCode(TrayType input)
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
        /// Converts the given TypeOfReferencedData enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(TypeOfReferencedData input)
        {
            return input switch
            {
                TypeOfReferencedData.FormattedText => "FT",
                TypeOfReferencedData.NonScannedImage => "NS",
                TypeOfReferencedData.ScannedDocument => "SD",
                TypeOfReferencedData.ScannedImage => "SI",
                TypeOfReferencedData.MachineReadableTextDocument => "TX",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given VersionId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(VersionId input)
        {
            return input switch
            {
                VersionId.Release20 => "2.0",
                VersionId.Demo20 => "2.0D",
                VersionId.Release21 => "2.1",
                VersionId.Release22 => "2.2",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given WhatSubjectFilter enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(WhatSubjectFilter input)
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
                WhatSubjectFilter.MasterFileQuery => "MFQ",
                WhatSubjectFilter.MostRecentInpatient => "MRI",
                WhatSubjectFilter.MostRecentOutpatient => "MRO",
                WhatSubjectFilter.NetworkClock => "NCK",
                WhatSubjectFilter.NetworkStatusChange => "NSC",
                WhatSubjectFilter.NetworkStatistic => "NST",
                WhatSubjectFilter.Order => "ORD",
                WhatSubjectFilter.Other => "OTH",
                WhatSubjectFilter.Procedure => "PRO",
                WhatSubjectFilter.PharmacyAdministrationInfo => "RAR",
                WhatSubjectFilter.PharmacyDispenseInfo => "RDR",
                WhatSubjectFilter.PharmacyEncodedOrderInfo => "RER",
                WhatSubjectFilter.Result => "RES",
                WhatSubjectFilter.PharmacyGiveInfo => "RGR",
                WhatSubjectFilter.PharmacyPrescriptionInfo => "ROR",
                WhatSubjectFilter.Status => "STA",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given WhichDateTimeQualifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(WhichDateTimeQualifier input)
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
        public string ValueToCode(WhichDateTimeStatusQualifier input)
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
        public string ValueToCode(YesNoIndicator input)
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