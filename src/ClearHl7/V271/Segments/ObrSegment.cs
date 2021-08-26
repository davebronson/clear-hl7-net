﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
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
        /// <para>Suggested: 0065 Specimen Action Code -&gt; ClearHl7.Codes.V271.CodeSpecimenActionCode</para>
        /// </summary>
        public string SpecimenActionCode { get; set; }

        /// <summary>
        /// OBR.12 - Danger Code.
        /// </summary>
        public CodedWithExceptions DangerCode { get; set; }

        /// <summary>
        /// OBR.13 - Relevant Clinical Information.
        /// </summary>
        public string RelevantClinicalInformation { get; set; }

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
        /// <para>Suggested: 0074 Diagnostic Service Section ID -&gt; ClearHl7.Codes.V271.CodeDiagnosticServiceSectionId</para>
        /// </summary>
        public string DiagnosticServSectId { get; set; }

        /// <summary>
        /// OBR.25 - Result Status.
        /// <para>Suggested: 0123 Result Status -&gt; ClearHl7.Codes.V271.CodeResultStatus</para>
        /// </summary>
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
        /// <para>Suggested: 0124 Transportation Mode -&gt; ClearHl7.Codes.V271.CodeTransportationMode</para>
        /// </summary>
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
        /// <para>Suggested: 0224 Transport Arranged -&gt; ClearHl7.Codes.V271.CodeTransportArranged</para>
        /// </summary>
        public string TransportArranged { get; set; }

        /// <summary>
        /// OBR.42 - Escort Required.
        /// <para>Suggested: 0225 Escort Required -&gt; ClearHl7.Codes.V271.CodeEscortRequired</para>
        /// </summary>
        public string EscortRequired { get; set; }

        /// <summary>
        /// OBR.43 - Planned Patient Transport Comment.
        /// </summary>
        public IEnumerable<CodedWithExceptions> PlannedPatientTransportComment { get; set; }

        /// <summary>
        /// OBR.44 - Procedure Code.
        /// <para>Suggested: 0088 Procedure Code</para>
        /// </summary>
        public CodedWithNoExceptions ProcedureCode { get; set; }

        /// <summary>
        /// OBR.45 - Procedure Code Modifier.
        /// <para>Suggested: 0340 Procedure Code Modifier</para>
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> ProcedureCodeModifier { get; set; }

        /// <summary>
        /// OBR.46 - Placer Supplemental Service Information.
        /// <para>Suggested: 0411 Supplemental Service Information Values -&gt; ClearHl7.Codes.V271.CodeSupplementalServiceInformationValues</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> PlacerSupplementalServiceInformation { get; set; }

        /// <summary>
        /// OBR.47 - Filler Supplemental Service Information.
        /// <para>Suggested: 0411 Supplemental Service Information Values -&gt; ClearHl7.Codes.V271.CodeSupplementalServiceInformationValues</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> FillerSupplementalServiceInformation { get; set; }

        /// <summary>
        /// OBR.48 - Medically Necessary Duplicate Procedure Reason.
        /// <para>Suggested: 0476 Medically Necessary Duplicate Procedure Reason</para>
        /// </summary>
        public CodedWithExceptions MedicallyNecessaryDuplicateProcedureReason { get; set; }

        /// <summary>
        /// OBR.49 - Result Handling.
        /// <para>Suggested: 0507 Observation Result Handling -&gt; ClearHl7.Codes.V271.CodeObservationResultHandling</para>
        /// </summary>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdObr = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            PlacerOrderNumber = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[2], false) : null;
            FillerOrderNumber = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[3], false) : null;
            UniversalServiceIdentifier = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[4], false) : null;
            Priority = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            RequestedDateTime = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            ObservationDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            ObservationEndDateTime = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            CollectionVolume = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments[9], false) : null;
            CollectorIdentifier = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            SpecimenActionCode = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            DangerCode = segments.Length > 12 && segments[12].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[12], false) : null;
            RelevantClinicalInformation = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            SpecimenReceivedDateTime = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            SpecimenSource = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            OrderingProvider = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            OrderCallbackPhoneNumber = segments.Length > 17 && segments[17].Length > 0 ? segments[17].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            PlacerField1 = segments.Length > 18 && segments[18].Length > 0 ? segments[18] : null;
            PlacerField2 = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            FillerField1 = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            FillerField2 = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            ResultsRptStatusChngDateTime = segments.Length > 22 && segments[22].Length > 0 ? segments[22].ToNullableDateTime() : null;
            ChargeToPractice = segments.Length > 23 && segments[23].Length > 0 ? TypeHelper.Deserialize<MoneyAndChargeCode>(segments[23], false) : null;
            DiagnosticServSectId = segments.Length > 24 && segments[24].Length > 0 ? segments[24] : null;
            ResultStatus = segments.Length > 25 && segments[25].Length > 0 ? segments[25] : null;
            ParentResult = segments.Length > 26 && segments[26].Length > 0 ? TypeHelper.Deserialize<ParentResultLink>(segments[26], false) : null;
            QuantityTiming = segments.Length > 27 && segments[27].Length > 0 ? segments[27].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            ResultCopiesTo = segments.Length > 28 && segments[28].Length > 0 ? segments[28].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            ParentResultsObservationIdentifier = segments.Length > 29 && segments[29].Length > 0 ? TypeHelper.Deserialize<EntityIdentifierPair>(segments[29], false) : null;
            TransportationMode = segments.Length > 30 && segments[30].Length > 0 ? segments[30] : null;
            ReasonForStudy = segments.Length > 31 && segments[31].Length > 0 ? segments[31].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PrincipalResultInterpreter = segments.Length > 32 && segments[32].Length > 0 ? TypeHelper.Deserialize<NameWithDateAndLocation>(segments[32], false) : null;
            AssistantResultInterpreter = segments.Length > 33 && segments[33].Length > 0 ? segments[33].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<NameWithDateAndLocation>(x, false)) : null;
            Technician = segments.Length > 34 && segments[34].Length > 0 ? segments[34].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<NameWithDateAndLocation>(x, false)) : null;
            Transcriptionist = segments.Length > 35 && segments[35].Length > 0 ? segments[35].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<NameWithDateAndLocation>(x, false)) : null;
            ScheduledDateTime = segments.Length > 36 && segments[36].Length > 0 ? segments[36].ToNullableDateTime() : null;
            NumberOfSampleContainers = segments.Length > 37 && segments[37].Length > 0 ? segments[37].ToNullableDecimal() : null;
            TransportLogisticsOfCollectedSample = segments.Length > 38 && segments[38].Length > 0 ? segments[38].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            CollectorsComment = segments.Length > 39 && segments[39].Length > 0 ? segments[39].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            TransportArrangementResponsibility = segments.Length > 40 && segments[40].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[40], false) : null;
            TransportArranged = segments.Length > 41 && segments[41].Length > 0 ? segments[41] : null;
            EscortRequired = segments.Length > 42 && segments[42].Length > 0 ? segments[42] : null;
            PlannedPatientTransportComment = segments.Length > 43 && segments[43].Length > 0 ? segments[43].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ProcedureCode = segments.Length > 44 && segments[44].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[44], false) : null;
            ProcedureCodeModifier = segments.Length > 45 && segments[45].Length > 0 ? segments[45].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            PlacerSupplementalServiceInformation = segments.Length > 46 && segments[46].Length > 0 ? segments[46].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            FillerSupplementalServiceInformation = segments.Length > 47 && segments[47].Length > 0 ? segments[47].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            MedicallyNecessaryDuplicateProcedureReason = segments.Length > 48 && segments[48].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[48], false) : null;
            ResultHandling = segments.Length > 49 && segments[49].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[49], false) : null;
            ParentUniversalServiceIdentifier = segments.Length > 50 && segments[50].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[50], false) : null;
            ObservationGroupId = segments.Length > 51 && segments[51].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[51], false) : null;
            ParentObservationGroupId = segments.Length > 52 && segments[52].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[52], false) : null;
            AlternatePlacerOrderNumber = segments.Length > 53 && segments[53].Length > 0 ? segments[53].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 54, Configuration.FieldSeparator),
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
                                RelevantClinicalInformation,
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
                                TransportArrangementResponsibility?.ToDelimitedString(),
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
                                AlternatePlacerOrderNumber != null ? string.Join(Configuration.FieldRepeatSeparator, AlternatePlacerOrderNumber.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
