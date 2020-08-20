using System;

namespace ClearHl7.Fhir.Codes.V210.Helpers
{
    /// <summary>
    /// Provides helper methods for interacting with enumerations.
    /// </summary>
    public class EnumHelper : IEnumHelper
    {
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
                BedStatus.Occupied => "O",
                BedStatus.Unoccupied => "U",
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
                CheckDigitScheme.Mod11Algorithm => "M11",
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
                DiagnosticServiceSectionId.BloodGases => "BG",
                DiagnosticServiceSectionId.Chemistry => "CH",
                DiagnosticServiceSectionId.Cytopathology => "CP",
                DiagnosticServiceSectionId.CatScan => "CT",
                DiagnosticServiceSectionId.CardiacUltrasound => "CUS",
                DiagnosticServiceSectionId.Electrocardiac => "EC",
                DiagnosticServiceSectionId.Hematology => "HM",
                DiagnosticServiceSectionId.Immunology => "IMM",
                DiagnosticServiceSectionId.Microbiology => "MB",
                DiagnosticServiceSectionId.Mycobacteriology => "MCB",
                DiagnosticServiceSectionId.Mycology => "MYC",
                DiagnosticServiceSectionId.NuclearMagneticResonance => "NMR",
                DiagnosticServiceSectionId.NuclearMedicineScan => "NMS",
                DiagnosticServiceSectionId.NursingServiceMeasures => "NRS",
                DiagnosticServiceSectionId.OccupationalTherapy => "OT",
                DiagnosticServiceSectionId.Other => "OTH",
                DiagnosticServiceSectionId.ObUltrasound => "OUS",
                DiagnosticServiceSectionId.Pharmacy => "PHR",
                DiagnosticServiceSectionId.PhysicalTherapy => "PT",
                DiagnosticServiceSectionId.RespiratoryCareTherapy => "RC",
                DiagnosticServiceSectionId.RadiationTherapy => "RT",
                DiagnosticServiceSectionId.RadiologyUltrasound => "RUS",
                DiagnosticServiceSectionId.SurgicalPathology => "SP",
                DiagnosticServiceSectionId.Serology => "SR",
                DiagnosticServiceSectionId.Toxicology => "TX",
                DiagnosticServiceSectionId.VascularUltrasound => "VUS",
                DiagnosticServiceSectionId.Cineradiograph => "XRC",
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
                EventTypeCode.OrmOrderMessage => "O01",
                EventTypeCode.OrrOrderResponse => "O02",
                EventTypeCode.BarAckAddPatientAccounts => "P01",
                EventTypeCode.BarAckPurgePatientAccounts => "P02",
                EventTypeCode.DftAckPostDetailFinancialTransaction => "P03",
                EventTypeCode.QryDspGenerateBillAndARStatements => "P04",
                EventTypeCode.QryDsrQuerySentForImmediateResponse => "Q01",
                EventTypeCode.QryQckQuerySentForDeferredResponse => "Q02",
                EventTypeCode.OruAckUnsolicitedTransmissionOfObservation => "R01",
                EventTypeCode.QryDsrDisplayOrientedResultsQueryUnsolUpdate => "R03",
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
                InterpretationCodes.Abnormal => "A",
                InterpretationCodes.CriticallyAbnormal => "AA",
                InterpretationCodes.SignificantChangeDown => "D",
                InterpretationCodes.High => "H",
                InterpretationCodes.CriticallyHigh => "HH",
                InterpretationCodes.Intermediate => "I",
                InterpretationCodes.CriticallyLow => "LL",
                InterpretationCodes.ModeratelySusceptible => "MS",
                InterpretationCodes.NoRangeDefinedOrNormalRangesDontApply => "null",
                InterpretationCodes.Resistant => "R",
                InterpretationCodes.Susceptible => "S",
                InterpretationCodes.SignificantChangeUp => "U",
                InterpretationCodes.VerySusceptible => "VS",
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
        /// Converts the given MessageType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(MessageType input)
        {
            return input switch
            {
                MessageType.GeneralAcknowledgment => "ACK",
                MessageType.AncillaryRptDeprecated => "ARD",
                MessageType.AddChangeBillingAccount => "BAR",
                MessageType.DisplayResponseDeprecated => "DSR",
                MessageType.DelayedAcknowledgmentDeprecated => "MCF",
                MessageType.QueryForResultsOfObservationDeprecated => "ORF",
                MessageType.PharmacyTreatmentOrderDeprecated => "ORM",
                MessageType.GeneralOrderResponseToAnyOrmDeprecated => "ORR",
                MessageType.UnsolicitedTransmissionOfObservation => "ORU",
                MessageType.QueryResponseForOrderStatusOsqDeprecated => "OSQ",
                MessageType.UnsolicitedDisplayUpdateMessage => "UDM",
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
        /// Converts the given ObservationResultStatusCodesInterpretation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(ObservationResultStatusCodesInterpretation input)
        {
            return input switch
            {
                ObservationResultStatusCodesInterpretation.DeletesTheObxRecord => "D",
                ObservationResultStatusCodesInterpretation.FinalResults => "F",
                ObservationResultStatusCodesInterpretation.SpecimenInLabResultsPending => "I",
                ObservationResultStatusCodesInterpretation.ResultsEnteredNotVerified => "R",
                ObservationResultStatusCodesInterpretation.PartialResults => "S",
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
                OrderControlCodes.DiscontinueOrderServiceRequest => "DC",
                OrderControlCodes.DataErrors => "DE",
                OrderControlCodes.DiscontinuedAsRequested => "DR",
                OrderControlCodes.HoldOrderRequest => "HD",
                OrderControlCodes.OnHoldAsRequested => "HR",
                OrderControlCodes.NumberAssigned => "NA",
                OrderControlCodes.NewOrderService => "NW",
                OrderControlCodes.OrderServiceDiscontinued => "OD",
                OrderControlCodes.OrderServiceAcceptedOk => "OK",
                OrderControlCodes.ReleasedAsRequested => "OR",
                OrderControlCodes.ParentOrderService => "PA",
                OrderControlCodes.ObservationsPerformedServiceToFollow => "RE",
                OrderControlCodes.ReplacementOrder => "RO",
                OrderControlCodes.OrderServiceReplaceRequest => "RP",
                OrderControlCodes.RequestReceived => "RR",
                OrderControlCodes.ReplacedUnsolicited => "RU",
                OrderControlCodes.SendOrderServiceNumber => "SN",
                OrderControlCodes.SendOrderServiceStatusRequest => "SS",
                OrderControlCodes.UnableToDiscontinue => "UD",
                OrderControlCodes.UnableToPutOnHold => "UH",
                OrderControlCodes.UnableToRelease => "UR",
                OrderControlCodes.UnableToChange => "UX",
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
                PatientClass.Emergency => "E",
                PatientClass.Inpatient => "I",
                PatientClass.Outpatient => "O",
                PatientClass.Preadmit => "P",
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
                Priority.Stat => "S",
                Priority.TimingCritical => "T",
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
                ResultStatus.Preliminary => "P",
                ResultStatus.ResultsStoredNotYetVerified => "R",
                ResultStatus.NoResultsAvailableProcedureScheduledButNotDone => "S",
                ResultStatus.NoOrderOnRecordForThisTest => "Y",
                ResultStatus.NoRecordOfThisPatient => "Z",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given Route enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(Route input)
        {
            return input switch
            {
                Route.ApplyExternally => "AP",
                Route.Chew => "CH",
                Route.Dust => "DU",
                Route.Ear => "EA",
                Route.Eye => "EY",
                Route.IntroArterial => "IA",
                Route.IntraDermal => "ID",
                Route.Infiltrate => "IF",
                Route.Inhalation => "IH",
                Route.IntraMuscular => "IM",
                Route.IntraNasal => "IN",
                Route.Irrigate => "IR",
                Route.Inserted => "IS",
                Route.Intrathecal => "IT",
                Route.Intravenous => "IV",
                Route.Nebulized => "NB",
                Route.Nathogasic => "NG",
                Route.PeriAnally => "PA",
                Route.Paint => "PT",
                Route.IvPush => "PU",
                Route.Rectally => "RC",
                Route.Shampoo => "SH",
                Route.Sublingual => "SL",
                Route.Soak => "SO",
                Route.IvSoluset => "SS",
                Route.Topically => "TP",
                Route.Wash => "WA",
                Route.Wipe => "WI",
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Converts the given SiteAdministered enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public string ValueToCode(SiteAdministered input)
        {
            return input switch
            {
                SiteAdministered.Buttock => "B",
                SiteAdministered.LeftArm => "L",
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
                SpecimenActionCode.CancelOrderForBatteryOrTests => "C",
                SpecimenActionCode.GeneratedOrderReflexOrder => "G",
                SpecimenActionCode.LabToObtainSpecimenFromPatient => "L",
                SpecimenActionCode.SpecimenObtainedByServiceOtherThanLab => "O",
                SpecimenActionCode.PendingSpecimenOrderSentPriorToDelivery => "P",
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
                SpecimenSourceCodes.WholeBlood => "BLD",
                SpecimenSourceCodes.Bone => "BON",
                SpecimenSourceCodes.Burn => "BRN",
                SpecimenSourceCodes.Conjunctiva => "CNJT",
                SpecimenSourceCodes.CerebralSpinalFluid => "CSF",
                SpecimenSourceCodes.Cervix => "CVX",
                SpecimenSourceCodes.Ear => "EAR",
                SpecimenSourceCodes.Fibroblasts => "FIB",
                SpecimenSourceCodes.Hair => "HAR",
                SpecimenSourceCodes.AmnioticFluid => "MN",
                SpecimenSourceCodes.Nose => "NOS",
                SpecimenSourceCodes.Other => "OTH",
                SpecimenSourceCodes.Plasma => "PLAS",
                SpecimenSourceCodes.PeritonealFluidAscites => "PRT",
                SpecimenSourceCodes.Erythrocytes => "RBC",
                SpecimenSourceCodes.Saliva => "SAL",
                SpecimenSourceCodes.SeminalFluidSem => "SEM",
                SpecimenSourceCodes.Serum => "SER",
                SpecimenSourceCodes.Skin => "SKN",
                SpecimenSourceCodes.SynovialFluid => "SNV",
                SpecimenSourceCodes.StoolFecal => "STL",
                SpecimenSourceCodes.Sweat => "SWT",
                SpecimenSourceCodes.Throat => "THRT",
                SpecimenSourceCodes.Tissue => "TIS",
                SpecimenSourceCodes.UmbilicalBlood => "UMB",
                SpecimenSourceCodes.Urine => "UR",
                SpecimenSourceCodes.Urethra => "URTH",
                SpecimenSourceCodes.Leukocytes => "WBC",
                SpecimenSourceCodes.Wound => "WND",
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
                WhatSubjectFilter.PatientNameLookup => "APN",
                WhatSubjectFilter.Cancel => "CAN",
                WhatSubjectFilter.Demographics => "DEM",
                WhatSubjectFilter.MostRecentInpatient => "MRI",
                WhatSubjectFilter.MostRecentOutpatient => "MRO",
                WhatSubjectFilter.Other => "OTH",
                WhatSubjectFilter.Procedure => "PRO",
                WhatSubjectFilter.Result => "RES",
                WhatSubjectFilter.Status => "STA",
                _ => throw new NotImplementedException()
            };
        }
    }
}