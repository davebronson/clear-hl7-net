using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V281.Types;

namespace ClearHl7.Fhir.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OBR - Observation Request.
    /// </summary>
    public class ObrSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OBR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OBR.1 - Set ID - OBR.
        /// </summary>
        public uint? SetIdObr { get; set; }

        /// <summary>
        /// OBR.2 - Placer Order Number.
        /// </summary>
        public EntityIdentifier PlacerOrderNumber { get; set; }

        /// <summary>
        /// OBR.3 - Filler Order Number.
        /// </summary>
        public EntityIdentifier FillerOrderNumber { get; set; }

        /// <summary>
        /// OBR.4 - Universal Service Identifier.
        /// </summary>
        public CodedWithExceptions UniversalServiceIdentifier { get; set; }

        /// <summary>
        /// OBR.5 - Priority.
        /// </summary>
        public string Priority { get; set; }

        /// <summary>
        /// OBR.6 - Requested Date/Time.
        /// </summary>
        public DateTime? RequestedDateTime { get; set; }

        /// <summary>
        /// OBR.7 - Observation Date/Time.
        /// </summary>
        public DateTime? ObservationDateTime { get; set; }

        /// <summary>
        /// OBR.8 - Observation End Date/Time.
        /// </summary>
        public DateTime? ObservationEndDateTime { get; set; }

        /// <summary>
        /// OBR.9 - Collection Volume.
        /// </summary>
        public CompositeQuantityWithUnits CollectionVolume { get; set; }

        /// <summary>
        /// OBR.10 - Collector Identifier.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> CollectorIdentifier { get; set; }

        /// <summary>
        /// OBR.11 - Specimen Action Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0065</remarks>
        public string SpecimenActionCode { get; set; }

        /// <summary>
        /// OBR.12 - Danger Code.
        /// </summary>
        public CodedWithExceptions DangerCode { get; set; }

        /// <summary>
        /// OBR.13 - Relevant Clinical Information.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0916</remarks>
        public IEnumerable<CodedWithExceptions> RelevantClinicalInformation { get; set; }

        /// <summary>
        /// OBR.14 - Specimen Received Date/Time.
        /// </summary>
        public DateTime? SpecimenReceivedDateTime { get; set; }

        /// <summary>
        /// OBR.15 - Specimen Source.
        /// </summary>
        public string SpecimenSource { get; set; }

        /// <summary>
        /// OBR.16 - Ordering Provider.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> OrderingProvider { get; set; }

        /// <summary>
        /// OBR.17 - Order Callback Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> OrderCallbackPhoneNumber { get; set; }

        /// <summary>
        /// OBR.18 - Placer Field 1.
        /// </summary>
        public string PlacerField1 { get; set; }

        /// <summary>
        /// OBR.19 - Placer Field 2.
        /// </summary>
        public string PlacerField2 { get; set; }

        /// <summary>
        /// OBR.20 - Filler Field 1.
        /// </summary>
        public string FillerField1 { get; set; }

        /// <summary>
        /// OBR.21 - Filler Field 2.
        /// </summary>
        public string FillerField2 { get; set; }

        /// <summary>
        /// OBR.22 - Results Rpt/Status Chng - Date/Time.
        /// </summary>
        public DateTime? ResultsRptStatusChngDateTime { get; set; }

        /// <summary>
        /// OBR.23 - Charge to Practice.
        /// </summary>
        public MoneyAndChargeCode ChargeToPractice { get; set; }

        /// <summary>
        /// OBR.24 - Diagnostic Serv Sect ID.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0074</remarks>
        public string DiagnosticServSectId { get; set; }

        /// <summary>
        /// OBR.25 - Result Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0123</remarks>
        public string ResultStatus { get; set; }

        /// <summary>
        /// OBR.26 - Parent Result.
        /// </summary>
        public ParentResultLink ParentResult { get; set; }

        /// <summary>
        /// OBR.27 - Quantity/Timing.
        /// </summary>
        public IEnumerable<string> QuantityTiming { get; set; }

        /// <summary>
        /// OBR.28 - Result Copies To.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ResultCopiesTo { get; set; }

        /// <summary>
        /// OBR.29 - Parent Results Observation Identifier.
        /// </summary>
        public EntityIdentifierPair ParentResultsObservationIdentifier { get; set; }

        /// <summary>
        /// OBR.30 - Transportation Mode.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0124</remarks>
        public string TransportationMode { get; set; }

        /// <summary>
        /// OBR.31 - Reason for Study.
        /// </summary>
        public IEnumerable<CodedWithExceptions> ReasonForStudy { get; set; }

        /// <summary>
        /// OBR.32 - Principal Result Interpreter.
        /// </summary>
        public NameWithDateAndLocation PrincipalResultInterpreter { get; set; }

        /// <summary>
        /// OBR.33 - Assistant Result Interpreter.
        /// </summary>
        public IEnumerable<NameWithDateAndLocation> AssistantResultInterpreter { get; set; }

        /// <summary>
        /// OBR.34 - Technician.
        /// </summary>
        public IEnumerable<NameWithDateAndLocation> Technician { get; set; }

        /// <summary>
        /// OBR.35 - Transcriptionist.
        /// </summary>
        public IEnumerable<NameWithDateAndLocation> Transcriptionist { get; set; }

        /// <summary>
        /// OBR.36 - Scheduled Date/Time.
        /// </summary>
        public DateTime? ScheduledDateTime { get; set; }

        /// <summary>
        /// OBR.37 - Number of Sample Containers.
        /// </summary>
        public decimal? NumberOfSampleContainers { get; set; }

        /// <summary>
        /// OBR.38 - Transport Logistics of Collected Sample.
        /// </summary>
        public IEnumerable<CodedWithExceptions> TransportLogisticsOfCollectedSample { get; set; }

        /// <summary>
        /// OBR.39 - Collector's Comment.
        /// </summary>
        public IEnumerable<CodedWithExceptions> CollectorsComment { get; set; }

        /// <summary>
        /// OBR.40 - Transport Arrangement Responsibility.
        /// </summary>
        public CodedWithExceptions TransportArrangementResponsibility { get; set; }

        /// <summary>
        /// OBR.41 - Transport Arranged.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0224</remarks>
        public string TransportArranged { get; set; }

        /// <summary>
        /// OBR.42 - Escort Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0225</remarks>
        public string EscortRequired { get; set; }

        /// <summary>
        /// OBR.43 - Planned Patient Transport Comment.
        /// </summary>
        public IEnumerable<CodedWithExceptions> PlannedPatientTransportComment { get; set; }

        /// <summary>
        /// OBR.44 - Procedure Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0088</remarks>
        public CodedWithNoExceptions ProcedureCode { get; set; }

        /// <summary>
        /// OBR.45 - Procedure Code Modifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0340</remarks>
        public IEnumerable<CodedWithNoExceptions> ProcedureCodeModifier { get; set; }

        /// <summary>
        /// OBR.46 - Placer Supplemental Service Information.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0411</remarks>
        public IEnumerable<CodedWithExceptions> PlacerSupplementalServiceInformation { get; set; }

        /// <summary>
        /// OBR.47 - Filler Supplemental Service Information.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0411</remarks>
        public IEnumerable<CodedWithExceptions> FillerSupplementalServiceInformation { get; set; }

        /// <summary>
        /// OBR.48 - Medically Necessary Duplicate Procedure Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0476</remarks>
        public CodedWithExceptions MedicallyNecessaryDuplicateProcedureReason { get; set; }

        /// <summary>
        /// OBR.49 - Result Handling.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0507</remarks>
        public CodedWithExceptions ResultHandling { get; set; }

        /// <summary>
        /// OBR.50 - Parent Universal Service Identifier.
        /// </summary>
        public CodedWithExceptions ParentUniversalServiceIdentifier { get; set; }

        /// <summary>
        /// OBR.51 - Observation Group ID.
        /// </summary>
        public EntityIdentifier ObservationGroupId { get; set; }

        /// <summary>
        /// OBR.52 - Parent Observation Group ID.
        /// </summary>
        public EntityIdentifier ParentObservationGroupId { get; set; }

        /// <summary>
        /// OBR.53 - Alternate Placer Order Number.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> AlternatePlacerOrderNumber { get; set; }

        /// <summary>
        /// OBR.54 - Parent Order.
        /// </summary>
        public EntityIdentifierPair ParentOrder { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 55, Configuration.FieldSeparator),
                                Id,
                                SetIdObr.HasValue ? SetIdObr.Value.ToString(culture) : null,
                                PlacerOrderNumber?.ToDelimitedString(),
                                FillerOrderNumber?.ToDelimitedString(),
                                UniversalServiceIdentifier?.ToDelimitedString(),
                                Priority,
                                RequestedDateTime.HasValue ? RequestedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ObservationDateTime.HasValue ? ObservationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ObservationEndDateTime.HasValue ? ObservationEndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                CollectionVolume?.ToDelimitedString(),
                                CollectorIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, CollectorIdentifier.Select(x => x.ToDelimitedString())) : null,
                                SpecimenActionCode,
                                DangerCode?.ToDelimitedString(),
                                RelevantClinicalInformation != null ? string.Join(Configuration.FieldRepeatSeparator, RelevantClinicalInformation.Select(x => x.ToDelimitedString())) : null,
                                SpecimenReceivedDateTime.HasValue ? SpecimenReceivedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                SpecimenSource,
                                OrderingProvider != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingProvider.Select(x => x.ToDelimitedString())) : null,
                                OrderCallbackPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, OrderCallbackPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                PlacerField1,
                                PlacerField2,
                                FillerField1,
                                FillerField2,
                                ResultsRptStatusChngDateTime.HasValue ? ResultsRptStatusChngDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ChargeToPractice?.ToDelimitedString(),
                                DiagnosticServSectId,
                                ResultStatus,
                                ParentResult?.ToDelimitedString(),
                                QuantityTiming != null ? string.Join(Configuration.FieldRepeatSeparator, QuantityTiming) : null,
                                ResultCopiesTo != null ? string.Join(Configuration.FieldRepeatSeparator, ResultCopiesTo.Select(x => x.ToDelimitedString())) : null,
                                ParentResultsObservationIdentifier?.ToDelimitedString(),
                                TransportationMode,
                                ReasonForStudy != null ? string.Join(Configuration.FieldRepeatSeparator, ReasonForStudy.Select(x => x.ToDelimitedString())) : null,
                                PrincipalResultInterpreter?.ToDelimitedString(),
                                AssistantResultInterpreter != null ? string.Join(Configuration.FieldRepeatSeparator, AssistantResultInterpreter.Select(x => x.ToDelimitedString())) : null,
                                Technician != null ? string.Join(Configuration.FieldRepeatSeparator, Technician.Select(x => x.ToDelimitedString())) : null,
                                Transcriptionist != null ? string.Join(Configuration.FieldRepeatSeparator, Transcriptionist.Select(x => x.ToDelimitedString())) : null,
                                ScheduledDateTime.HasValue ? ScheduledDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                NumberOfSampleContainers.HasValue ? NumberOfSampleContainers.Value.ToString(Consts.NumericFormat, culture) : null,
                                TransportLogisticsOfCollectedSample != null ? string.Join(Configuration.FieldRepeatSeparator, TransportLogisticsOfCollectedSample.Select(x => x.ToDelimitedString())) : null,
                                CollectorsComment != null ? string.Join(Configuration.FieldRepeatSeparator, CollectorsComment.Select(x => x.ToDelimitedString())) : null,
                                TransportArrangementResponsibility,
                                TransportArranged,
                                EscortRequired,
                                PlannedPatientTransportComment != null ? string.Join(Configuration.FieldRepeatSeparator, PlannedPatientTransportComment.Select(x => x.ToDelimitedString())) : null,
                                ProcedureCode?.ToDelimitedString(),
                                ProcedureCodeModifier != null ? string.Join(Configuration.FieldRepeatSeparator, ProcedureCodeModifier.Select(x => x.ToDelimitedString())) : null,
                                PlacerSupplementalServiceInformation != null ? string.Join(Configuration.FieldRepeatSeparator, PlacerSupplementalServiceInformation.Select(x => x.ToDelimitedString())) : null,
                                FillerSupplementalServiceInformation != null ? string.Join(Configuration.FieldRepeatSeparator, FillerSupplementalServiceInformation.Select(x => x.ToDelimitedString())) : null,
                                MedicallyNecessaryDuplicateProcedureReason?.ToDelimitedString(),
                                ResultHandling?.ToDelimitedString(),
                                ParentUniversalServiceIdentifier?.ToDelimitedString(),
                                ObservationGroupId?.ToDelimitedString(),
                                ParentObservationGroupId?.ToDelimitedString(),
                                AlternatePlacerOrderNumber != null ? string.Join(Configuration.FieldRepeatSeparator, AlternatePlacerOrderNumber.Select(x => x.ToDelimitedString())) : null,
                                ParentOrder?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}