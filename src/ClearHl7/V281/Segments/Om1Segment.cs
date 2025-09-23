using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM1 - General Segment.
    /// </summary>
    public class Om1Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Om1Segment"/> class.
        /// </summary>
        public Om1Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Om1Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Om1Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "OM1";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// OM1.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OM1.2 - Producer's Service/Test/Observation ID.
        /// </summary>
        public CodedWithExceptions ProducersServiceTestObservationId { get; set; }

        /// <summary>
        /// OM1.3 - Permitted Data Types.
        /// <para>Suggested: 0125 Value Type -&gt; ClearHl7.Codes.V281.CodeValueType</para>
        /// </summary>
        public IEnumerable<string> PermittedDataTypes { get; set; }

        /// <summary>
        /// OM1.4 - Specimen Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string SpecimenRequired { get; set; }

        /// <summary>
        /// OM1.5 - Producer ID.
        /// </summary>
        public CodedWithExceptions ProducerId { get; set; }

        /// <summary>
        /// OM1.6 - Observation Description.
        /// </summary>
        public Text ObservationDescription { get; set; }

        /// <summary>
        /// OM1.7 - Other Service/Test/Observation IDs for the Observation.
        /// </summary>
        public IEnumerable<CodedWithExceptions> OtherServiceTestObservationIdsForTheObservation { get; set; }

        /// <summary>
        /// OM1.8 - Other Names.
        /// </summary>
        public IEnumerable<string> OtherNames { get; set; }

        /// <summary>
        /// OM1.9 - Preferred Report Name for the Observation.
        /// </summary>
        public string PreferredReportNameForTheObservation { get; set; }

        /// <summary>
        /// OM1.10 - Preferred Short Name or Mnemonic for the Observation.
        /// </summary>
        public string PreferredShortNameOrMnemonicForTheObservation { get; set; }

        /// <summary>
        /// OM1.11 - Preferred Long Name for the Observation.
        /// </summary>
        public string PreferredLongNameForTheObservation { get; set; }

        /// <summary>
        /// OM1.12 - Orderability.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string Orderability { get; set; }

        /// <summary>
        /// OM1.13 - Identity of Instrument Used to Perform this Study.
        /// </summary>
        public IEnumerable<CodedWithExceptions> IdentityOfInstrumentUsedToPerformThisStudy { get; set; }

        /// <summary>
        /// OM1.14 - Coded Representation of Method.
        /// </summary>
        public IEnumerable<CodedWithExceptions> CodedRepresentationOfMethod { get; set; }

        /// <summary>
        /// OM1.15 - Portable Device Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string PortableDeviceIndicator { get; set; }

        /// <summary>
        /// OM1.16 - Observation Producing Department/Section.
        /// </summary>
        public IEnumerable<CodedWithExceptions> ObservationProducingDepartmentSection { get; set; }

        /// <summary>
        /// OM1.17 - Telephone Number of Section.
        /// </summary>
        public ExtendedTelecommunicationNumber TelephoneNumberOfSection { get; set; }

        /// <summary>
        /// OM1.18 - Nature of Service/Test/Observation.
        /// <para>Suggested: 0174 Nature Of Service/Test/Observation -&gt; ClearHl7.Codes.V281.CodeNatureOfServiceTestObservation</para>
        /// </summary>
        public CodedWithExceptions NatureOfServiceTestObservation { get; set; }

        /// <summary>
        /// OM1.19 - Report Subheader.
        /// </summary>
        public CodedWithExceptions ReportSubheader { get; set; }

        /// <summary>
        /// OM1.20 - Report Display Order.
        /// </summary>
        public string ReportDisplayOrder { get; set; }

        /// <summary>
        /// OM1.21 - Date/Time Stamp for Any Change in Definition for the Observation.
        /// </summary>
        public DateTime? DateTimeStampForAnyChangeInDefinitionForTheObservation { get; set; }

        /// <summary>
        /// OM1.22 - Effective Date/Time of Change.
        /// </summary>
        public DateTime? EffectiveDateTimeOfChange { get; set; }

        /// <summary>
        /// OM1.23 - Typical Turn-Around Time.
        /// </summary>
        public decimal? TypicalTurnAroundTime { get; set; }

        /// <summary>
        /// OM1.24 - Processing Time.
        /// </summary>
        public decimal? ProcessingTime { get; set; }

        /// <summary>
        /// OM1.25 - Processing Priority.
        /// <para>Suggested: 0168 Processing Priority -&gt; ClearHl7.Codes.V281.CodeProcessingPriority</para>
        /// </summary>
        public IEnumerable<string> ProcessingPriority { get; set; }

        /// <summary>
        /// OM1.26 - Reporting Priority.
        /// <para>Suggested: 0169 Reporting Priority -&gt; ClearHl7.Codes.V281.CodeReportingPriority</para>
        /// </summary>
        public string ReportingPriority { get; set; }

        /// <summary>
        /// OM1.27 - Outside Site(s) Where Observation May Be Performed.
        /// </summary>
        public IEnumerable<CodedWithExceptions> OutsideSitesWhereObservationMayBePerformed { get; set; }

        /// <summary>
        /// OM1.28 - Address of Outside Site(s).
        /// </summary>
        public IEnumerable<ExtendedAddress> AddressOfOutsideSites { get; set; }

        /// <summary>
        /// OM1.29 - Phone Number of Outside Site.
        /// </summary>
        public ExtendedTelecommunicationNumber PhoneNumberOfOutsideSite { get; set; }

        /// <summary>
        /// OM1.30 - Confidentiality Code.
        /// <para>Suggested: 0177 Confidentiality Code -&gt; ClearHl7.Codes.V281.CodeConfidentialityCode</para>
        /// </summary>
        public CodedWithExceptions ConfidentialityCode { get; set; }

        /// <summary>
        /// OM1.31 - Observations Required to Interpret this Observation.
        /// </summary>
        public IEnumerable<CodedWithExceptions> ObservationsRequiredToInterpretThisObservation { get; set; }

        /// <summary>
        /// OM1.32 - Interpretation of Observations.
        /// </summary>
        public Text InterpretationOfObservations { get; set; }

        /// <summary>
        /// OM1.33 - Contraindications to Observations.
        /// </summary>
        public IEnumerable<CodedWithExceptions> ContraindicationsToObservations { get; set; }

        /// <summary>
        /// OM1.34 - Reflex Tests/Observations.
        /// </summary>
        public IEnumerable<CodedWithExceptions> ReflexTestsObservations { get; set; }

        /// <summary>
        /// OM1.35 - Rules that Trigger Reflex Testing.
        /// </summary>
        public IEnumerable<Text> RulesThatTriggerReflexTesting { get; set; }

        /// <summary>
        /// OM1.36 - Fixed Canned Message.
        /// </summary>
        public IEnumerable<CodedWithExceptions> FixedCannedMessage { get; set; }

        /// <summary>
        /// OM1.37 - Patient Preparation.
        /// </summary>
        public IEnumerable<Text> PatientPreparation { get; set; }

        /// <summary>
        /// OM1.38 - Procedure Medication.
        /// </summary>
        public CodedWithExceptions ProcedureMedication { get; set; }

        /// <summary>
        /// OM1.39 - Factors that may Affect the Observation.
        /// </summary>
        public Text FactorsThatMayAffectTheObservation { get; set; }

        /// <summary>
        /// OM1.40 - Service/Test/Observation Performance Schedule.
        /// </summary>
        public IEnumerable<string> ServiceTestObservationPerformanceSchedule { get; set; }

        /// <summary>
        /// OM1.41 - Description of Test Methods.
        /// </summary>
        public Text DescriptionOfTestMethods { get; set; }

        /// <summary>
        /// OM1.42 - Kind of Quantity Observed.
        /// <para>Suggested: 0254 Kind Of Quantity -&gt; ClearHl7.Codes.V281.CodeKindOfQuantity</para>
        /// </summary>
        public CodedWithExceptions KindOfQuantityObserved { get; set; }

        /// <summary>
        /// OM1.43 - Point Versus Interval.
        /// <para>Suggested: 0255 Duration Categories -&gt; ClearHl7.Codes.V281.CodeDurationCategories</para>
        /// </summary>
        public CodedWithExceptions PointVersusInterval { get; set; }

        /// <summary>
        /// OM1.44 - Challenge Information.
        /// <para>Suggested: 0256 Time Delay Post Challenge -&gt; ClearHl7.Codes.V281.CodeTimeDelayPostChallenge</para>
        /// </summary>
        public Text ChallengeInformation { get; set; }

        /// <summary>
        /// OM1.45 - Relationship Modifier.
        /// <para>Suggested: 0258 Relationship Modifier -&gt; ClearHl7.Codes.V281.CodeRelationshipModifier</para>
        /// </summary>
        public CodedWithExceptions RelationshipModifier { get; set; }

        /// <summary>
        /// OM1.46 - Target Anatomic Site Of Test.
        /// </summary>
        public CodedWithExceptions TargetAnatomicSiteOfTest { get; set; }

        /// <summary>
        /// OM1.47 - Modality of Imaging Measurement.
        /// <para>Suggested: 0910 Modality Of Imaging Measurement</para>
        /// </summary>
        public CodedWithExceptions ModalityOfImagingMeasurement { get; set; }

        /// <summary>
        /// OM1.48 - Exclusive Test.
        /// <para>Suggested: 0919 Exclusive Test -&gt; ClearHl7.Codes.V281.CodeExclusiveTest</para>
        /// </summary>
        public string ExclusiveTest { get; set; }

        /// <summary>
        /// OM1.49 - Diagnostic Serv Sect ID.
        /// <para>Suggested: 0074 Diagnostic Service Section ID -&gt; ClearHl7.Codes.V281.CodeDiagnosticServiceSectionId</para>
        /// </summary>
        public string DiagnosticServSectId { get; set; }

        /// <summary>
        /// OM1.50 - Taxonomic Classification Code.
        /// </summary>
        public CodedWithExceptions TaxonomicClassificationCode { get; set; }

        /// <summary>
        /// OM1.51 - Other Names.
        /// </summary>
        public IEnumerable<string> OtherNamesB { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SequenceNumberTestObservationMasterFile = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            ProducersServiceTestObservationId = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            PermittedDataTypes = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SpecimenRequired = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            ProducerId = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            ObservationDescription = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[6], false, seps) : null;
            OtherServiceTestObservationIdsForTheObservation = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            OtherNames = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            PreferredReportNameForTheObservation = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            PreferredShortNameOrMnemonicForTheObservation = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            PreferredLongNameForTheObservation = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            Orderability = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            IdentityOfInstrumentUsedToPerformThisStudy = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            CodedRepresentationOfMethod = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            PortableDeviceIndicator = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            ObservationProducingDepartmentSection = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            TelephoneNumberOfSection = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(segments[17], false, seps) : null;
            NatureOfServiceTestObservation = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[18], false, seps) : null;
            ReportSubheader = segments.Length > 19 && segments[19].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[19], false, seps) : null;
            ReportDisplayOrder = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            DateTimeStampForAnyChangeInDefinitionForTheObservation = segments.Length > 21 && segments[21].Length > 0 ? segments[21].ToNullableDateTime() : null;
            EffectiveDateTimeOfChange = segments.Length > 22 && segments[22].Length > 0 ? segments[22].ToNullableDateTime() : null;
            TypicalTurnAroundTime = segments.Length > 23 && segments[23].Length > 0 ? segments[23].ToNullableDecimal() : null;
            ProcessingTime = segments.Length > 24 && segments[24].Length > 0 ? segments[24].ToNullableDecimal() : null;
            ProcessingPriority = segments.Length > 25 && segments[25].Length > 0 ? segments[25].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            ReportingPriority = segments.Length > 26 && segments[26].Length > 0 ? segments[26] : null;
            OutsideSitesWhereObservationMayBePerformed = segments.Length > 27 && segments[27].Length > 0 ? segments[27].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            AddressOfOutsideSites = segments.Length > 28 && segments[28].Length > 0 ? segments[28].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            PhoneNumberOfOutsideSite = segments.Length > 29 && segments[29].Length > 0 ? TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(segments[29], false, seps) : null;
            ConfidentialityCode = segments.Length > 30 && segments[30].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[30], false, seps) : null;
            ObservationsRequiredToInterpretThisObservation = segments.Length > 31 && segments[31].Length > 0 ? segments[31].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            InterpretationOfObservations = segments.Length > 32 && segments[32].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[32], false, seps) : null;
            ContraindicationsToObservations = segments.Length > 33 && segments[33].Length > 0 ? segments[33].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ReflexTestsObservations = segments.Length > 34 && segments[34].Length > 0 ? segments[34].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            RulesThatTriggerReflexTesting = segments.Length > 35 && segments[35].Length > 0 ? segments[35].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<Text>(x, false, seps)) : null;
            FixedCannedMessage = segments.Length > 36 && segments[36].Length > 0 ? segments[36].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            PatientPreparation = segments.Length > 37 && segments[37].Length > 0 ? segments[37].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<Text>(x, false, seps)) : null;
            ProcedureMedication = segments.Length > 38 && segments[38].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[38], false, seps) : null;
            FactorsThatMayAffectTheObservation = segments.Length > 39 && segments[39].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[39], false, seps) : null;
            ServiceTestObservationPerformanceSchedule = segments.Length > 40 && segments[40].Length > 0 ? segments[40].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            DescriptionOfTestMethods = segments.Length > 41 && segments[41].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[41], false, seps) : null;
            KindOfQuantityObserved = segments.Length > 42 && segments[42].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[42], false, seps) : null;
            PointVersusInterval = segments.Length > 43 && segments[43].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[43], false, seps) : null;
            ChallengeInformation = segments.Length > 44 && segments[44].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[44], false, seps) : null;
            RelationshipModifier = segments.Length > 45 && segments[45].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[45], false, seps) : null;
            TargetAnatomicSiteOfTest = segments.Length > 46 && segments[46].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[46], false, seps) : null;
            ModalityOfImagingMeasurement = segments.Length > 47 && segments[47].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[47], false, seps) : null;
            ExclusiveTest = segments.Length > 48 && segments[48].Length > 0 ? segments[48] : null;
            DiagnosticServSectId = segments.Length > 49 && segments[49].Length > 0 ? segments[49] : null;
            TaxonomicClassificationCode = segments.Length > 50 && segments[50].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[50], false, seps) : null;
            OtherNamesB = segments.Length > 51 && segments[51].Length > 0 ? segments[51].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 52, Configuration.FieldSeparator),
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                ProducersServiceTestObservationId?.ToDelimitedString(),
                                PermittedDataTypes != null ? string.Join(Configuration.FieldRepeatSeparator, PermittedDataTypes) : null,
                                SpecimenRequired,
                                ProducerId?.ToDelimitedString(),
                                ObservationDescription?.ToDelimitedString(),
                                OtherServiceTestObservationIdsForTheObservation != null ? string.Join(Configuration.FieldRepeatSeparator, OtherServiceTestObservationIdsForTheObservation.Select(x => x.ToDelimitedString())) : null,
                                OtherNames != null ? string.Join(Configuration.FieldRepeatSeparator, OtherNames) : null,
                                PreferredReportNameForTheObservation,
                                PreferredShortNameOrMnemonicForTheObservation,
                                PreferredLongNameForTheObservation,
                                Orderability,
                                IdentityOfInstrumentUsedToPerformThisStudy != null ? string.Join(Configuration.FieldRepeatSeparator, IdentityOfInstrumentUsedToPerformThisStudy.Select(x => x.ToDelimitedString())) : null,
                                CodedRepresentationOfMethod != null ? string.Join(Configuration.FieldRepeatSeparator, CodedRepresentationOfMethod.Select(x => x.ToDelimitedString())) : null,
                                PortableDeviceIndicator,
                                ObservationProducingDepartmentSection != null ? string.Join(Configuration.FieldRepeatSeparator, ObservationProducingDepartmentSection.Select(x => x.ToDelimitedString())) : null,
                                TelephoneNumberOfSection?.ToDelimitedString(),
                                NatureOfServiceTestObservation?.ToDelimitedString(),
                                ReportSubheader?.ToDelimitedString(),
                                ReportDisplayOrder,
                                DateTimeStampForAnyChangeInDefinitionForTheObservation.ToHl7DateTimeString(typeof(Om1Segment), nameof(DateTimeStampForAnyChangeInDefinitionForTheObservation), Consts.DateTimeFormatPrecisionSecond, CultureInfo.CurrentCulture),
                                EffectiveDateTimeOfChange.ToHl7DateTimeString(typeof(Om1Segment), nameof(EffectiveDateTimeOfChange), Consts.DateTimeFormatPrecisionSecond, CultureInfo.CurrentCulture),
                                TypicalTurnAroundTime.HasValue ? TypicalTurnAroundTime.Value.ToString(Consts.NumericFormat) : null,
                                ProcessingTime.HasValue ? ProcessingTime.Value.ToString(Consts.NumericFormat) : null,
                                ProcessingPriority != null ? string.Join(Configuration.FieldRepeatSeparator, ProcessingPriority) : null,
                                ReportingPriority,
                                OutsideSitesWhereObservationMayBePerformed != null ? string.Join(Configuration.FieldRepeatSeparator, OutsideSitesWhereObservationMayBePerformed.Select(x => x.ToDelimitedString())) : null,
                                AddressOfOutsideSites != null ? string.Join(Configuration.FieldRepeatSeparator, AddressOfOutsideSites.Select(x => x.ToDelimitedString())) : null,
                                PhoneNumberOfOutsideSite?.ToDelimitedString(),
                                ConfidentialityCode?.ToDelimitedString(),
                                ObservationsRequiredToInterpretThisObservation != null ? string.Join(Configuration.FieldRepeatSeparator, ObservationsRequiredToInterpretThisObservation.Select(x => x.ToDelimitedString())) : null,
                                InterpretationOfObservations?.ToDelimitedString(),
                                ContraindicationsToObservations != null ? string.Join(Configuration.FieldRepeatSeparator, ContraindicationsToObservations.Select(x => x.ToDelimitedString())) : null,
                                ReflexTestsObservations != null ? string.Join(Configuration.FieldRepeatSeparator, ReflexTestsObservations.Select(x => x.ToDelimitedString())) : null,
                                RulesThatTriggerReflexTesting != null ? string.Join(Configuration.FieldRepeatSeparator, RulesThatTriggerReflexTesting.Select(x => x.ToDelimitedString())) : null,
                                FixedCannedMessage != null ? string.Join(Configuration.FieldRepeatSeparator, FixedCannedMessage.Select(x => x.ToDelimitedString())) : null,
                                PatientPreparation != null ? string.Join(Configuration.FieldRepeatSeparator, PatientPreparation.Select(x => x.ToDelimitedString())) : null,
                                ProcedureMedication?.ToDelimitedString(),
                                FactorsThatMayAffectTheObservation?.ToDelimitedString(),
                                ServiceTestObservationPerformanceSchedule != null ? string.Join(Configuration.FieldRepeatSeparator, ServiceTestObservationPerformanceSchedule) : null,
                                DescriptionOfTestMethods?.ToDelimitedString(),
                                KindOfQuantityObserved?.ToDelimitedString(),
                                PointVersusInterval?.ToDelimitedString(),
                                ChallengeInformation?.ToDelimitedString(),
                                RelationshipModifier?.ToDelimitedString(),
                                TargetAnatomicSiteOfTest?.ToDelimitedString(),
                                ModalityOfImagingMeasurement?.ToDelimitedString(),
                                ExclusiveTest,
                                DiagnosticServSectId,
                                TaxonomicClassificationCode?.ToDelimitedString(),
                                OtherNamesB != null ? string.Join(Configuration.FieldRepeatSeparator, OtherNamesB) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
