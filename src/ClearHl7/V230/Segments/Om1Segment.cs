using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM1 - General Segment.
    /// </summary>
    public class Om1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OM1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OM1.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OM1.2 - Producer's Service/Test/Observation ID.
        /// </summary>
        public CodedElement ProducersServiceTestObservationId { get; set; }

        /// <summary>
        /// OM1.3 - Permitted Data Types.
        /// <para>Suggested: 0125 Value Type -&gt; ClearHl7.Codes.V230.CodeValueType</para>
        /// </summary>
        public IEnumerable<string> PermittedDataTypes { get; set; }

        /// <summary>
        /// OM1.4 - Specimen Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V230.CodeYesNoIndicator</para>
        /// </summary>
        public string SpecimenRequired { get; set; }

        /// <summary>
        /// OM1.5 - Producer ID.
        /// </summary>
        public CodedElement ProducerId { get; set; }

        /// <summary>
        /// OM1.6 - Observation Description.
        /// </summary>
        public CodedElement ObservationDescription { get; set; }

        /// <summary>
        /// OM1.7 - Other Service/Test/Observation IDs for the Observation.
        /// </summary>
        public CodedElement OtherServiceTestObservationIdsForTheObservation { get; set; }

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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V230.CodeYesNoIndicator</para>
        /// </summary>
        public string Orderability { get; set; }

        /// <summary>
        /// OM1.13 - Identity of Instrument Used to Perform this Study.
        /// </summary>
        public IEnumerable<CodedElement> IdentityOfInstrumentUsedToPerformThisStudy { get; set; }

        /// <summary>
        /// OM1.14 - Coded Representation of Method.
        /// </summary>
        public CodedElement CodedRepresentationOfMethod { get; set; }

        /// <summary>
        /// OM1.15 - Portable Device Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V230.CodeYesNoIndicator</para>
        /// </summary>
        public string PortableDeviceIndicator { get; set; }

        /// <summary>
        /// OM1.16 - Observation Producing Department/Section.
        /// </summary>
        public IEnumerable<CodedElement> ObservationProducingDepartmentSection { get; set; }

        /// <summary>
        /// OM1.17 - Telephone Number of Section.
        /// </summary>
        public ExtendedTelecommunicationNumber TelephoneNumberOfSection { get; set; }

        /// <summary>
        /// OM1.18 - Nature of Service/Test/Observation.
        /// <para>Suggested: 0174 Nature Of Service/Test/Observation -&gt; ClearHl7.Codes.V230.CodeNatureOfServiceTestObservation</para>
        /// </summary>
        public string NatureOfServiceTestObservation { get; set; }

        /// <summary>
        /// OM1.19 - Report Subheader.
        /// </summary>
        public CodedElement ReportSubheader { get; set; }

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
        /// <para>Suggested: 0168 Processing Priority -&gt; ClearHl7.Codes.V230.CodeProcessingPriority</para>
        /// </summary>
        public IEnumerable<string> ProcessingPriority { get; set; }

        /// <summary>
        /// OM1.26 - Reporting Priority.
        /// <para>Suggested: 0169 Reporting Priority -&gt; ClearHl7.Codes.V230.CodeReportingPriority</para>
        /// </summary>
        public string ReportingPriority { get; set; }

        /// <summary>
        /// OM1.27 - Outside Site(s) Where Observation May Be Performed.
        /// </summary>
        public IEnumerable<CodedElement> OutsideSitesWhereObservationMayBePerformed { get; set; }

        /// <summary>
        /// OM1.28 - Address of Outside Site(s).
        /// </summary>
        public ExtendedAddress AddressOfOutsideSites { get; set; }

        /// <summary>
        /// OM1.29 - Phone Number of Outside Site.
        /// </summary>
        public ExtendedTelecommunicationNumber PhoneNumberOfOutsideSite { get; set; }

        /// <summary>
        /// OM1.30 - Confidentiality Code.
        /// <para>Suggested: 0177 Confidentiality Code -&gt; ClearHl7.Codes.V230.CodeConfidentialityCode</para>
        /// </summary>
        public string ConfidentialityCode { get; set; }

        /// <summary>
        /// OM1.31 - Observations Required to Interpret this Observation.
        /// </summary>
        public CodedElement ObservationsRequiredToInterpretThisObservation { get; set; }

        /// <summary>
        /// OM1.32 - Interpretation of Observations.
        /// </summary>
        public Text InterpretationOfObservations { get; set; }

        /// <summary>
        /// OM1.33 - Contraindications to Observations.
        /// </summary>
        public CodedElement ContraindicationsToObservations { get; set; }

        /// <summary>
        /// OM1.34 - Reflex Tests/Observations.
        /// </summary>
        public IEnumerable<CodedElement> ReflexTestsObservations { get; set; }

        /// <summary>
        /// OM1.35 - Rules that Trigger Reflex Testing.
        /// </summary>
        public string RulesThatTriggerReflexTesting { get; set; }

        /// <summary>
        /// OM1.36 - Fixed Canned Message.
        /// </summary>
        public CodedElement FixedCannedMessage { get; set; }

        /// <summary>
        /// OM1.37 - Patient Preparation.
        /// </summary>
        public Text PatientPreparation { get; set; }

        /// <summary>
        /// OM1.38 - Procedure Medication.
        /// </summary>
        public CodedElement ProcedureMedication { get; set; }

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
        /// <para>Suggested: 0254 Kind Of Quantity -&gt; ClearHl7.Codes.V230.CodeKindOfQuantity</para>
        /// </summary>
        public CodedElement KindOfQuantityObserved { get; set; }

        /// <summary>
        /// OM1.43 - Point Versus Interval.
        /// <para>Suggested: 0255 Duration Categories -&gt; ClearHl7.Codes.V230.CodeDurationCategories</para>
        /// </summary>
        public CodedElement PointVersusInterval { get; set; }

        /// <summary>
        /// OM1.44 - Challenge Information.
        /// </summary>
        public Text ChallengeInformation { get; set; }

        /// <summary>
        /// OM1.45 - Relationship Modifier.
        /// <para>Suggested: 0258 Relationship Modifier -&gt; ClearHl7.Codes.V230.CodeRelationshipModifier</para>
        /// </summary>
        public CodedElement RelationshipModifier { get; set; }

        /// <summary>
        /// OM1.46 - Target Anatomic Site Of Test.
        /// </summary>
        public CodedElement TargetAnatomicSiteOfTest { get; set; }

        /// <summary>
        /// OM1.47 - Modality of Imaging Measurement.
        /// <para>Suggested: 0259 Modality -&gt; ClearHl7.Codes.V230.CodeModality</para>
        /// </summary>
        public CodedElement ModalityOfImagingMeasurement { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SequenceNumberTestObservationMasterFile = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            ProducersServiceTestObservationId = segments.Length > 2 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(2), false) : null;
            PermittedDataTypes = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator) : null;
            SpecimenRequired = segments.ElementAtOrDefault(4);
            ProducerId = segments.Length > 5 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(5), false) : null;
            ObservationDescription = segments.Length > 6 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(6), false) : null;
            OtherServiceTestObservationIdsForTheObservation = segments.Length > 7 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(7), false) : null;
            OtherNames = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator) : null;
            PreferredReportNameForTheObservation = segments.ElementAtOrDefault(9);
            PreferredShortNameOrMnemonicForTheObservation = segments.ElementAtOrDefault(10);
            PreferredLongNameForTheObservation = segments.ElementAtOrDefault(11);
            Orderability = segments.ElementAtOrDefault(12);
            IdentityOfInstrumentUsedToPerformThisStudy = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            CodedRepresentationOfMethod = segments.Length > 14 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(14), false) : null;
            PortableDeviceIndicator = segments.ElementAtOrDefault(15);
            ObservationProducingDepartmentSection = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            TelephoneNumberOfSection = segments.Length > 17 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments.ElementAtOrDefault(17), false) : null;
            NatureOfServiceTestObservation = segments.ElementAtOrDefault(18);
            ReportSubheader = segments.Length > 19 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(19), false) : null;
            ReportDisplayOrder = segments.ElementAtOrDefault(20);
            DateTimeStampForAnyChangeInDefinitionForTheObservation = segments.ElementAtOrDefault(21)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            EffectiveDateTimeOfChange = segments.ElementAtOrDefault(22)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            TypicalTurnAroundTime = segments.ElementAtOrDefault(23)?.ToNullableDecimal();
            ProcessingTime = segments.ElementAtOrDefault(24)?.ToNullableDecimal();
            ProcessingPriority = segments.Length > 25 ? segments.ElementAtOrDefault(25).Split(separator) : null;
            ReportingPriority = segments.ElementAtOrDefault(26);
            OutsideSitesWhereObservationMayBePerformed = segments.Length > 27 ? segments.ElementAtOrDefault(27).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            AddressOfOutsideSites = segments.Length > 28 ? TypeHelper.Deserialize<ExtendedAddress>(segments.ElementAtOrDefault(28), false) : null;
            PhoneNumberOfOutsideSite = segments.Length > 29 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments.ElementAtOrDefault(29), false) : null;
            ConfidentialityCode = segments.ElementAtOrDefault(30);
            ObservationsRequiredToInterpretThisObservation = segments.Length > 31 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(31), false) : null;
            InterpretationOfObservations = segments.Length > 32 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(32), false) : null;
            ContraindicationsToObservations = segments.Length > 33 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(33), false) : null;
            ReflexTestsObservations = segments.Length > 34 ? segments.ElementAtOrDefault(34).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            RulesThatTriggerReflexTesting = segments.ElementAtOrDefault(35);
            FixedCannedMessage = segments.Length > 36 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(36), false) : null;
            PatientPreparation = segments.Length > 37 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(37), false) : null;
            ProcedureMedication = segments.Length > 38 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(38), false) : null;
            FactorsThatMayAffectTheObservation = segments.Length > 39 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(39), false) : null;
            ServiceTestObservationPerformanceSchedule = segments.Length > 40 ? segments.ElementAtOrDefault(40).Split(separator) : null;
            DescriptionOfTestMethods = segments.Length > 41 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(41), false) : null;
            KindOfQuantityObserved = segments.Length > 42 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(42), false) : null;
            PointVersusInterval = segments.Length > 43 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(43), false) : null;
            ChallengeInformation = segments.Length > 44 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(44), false) : null;
            RelationshipModifier = segments.Length > 45 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(45), false) : null;
            TargetAnatomicSiteOfTest = segments.Length > 46 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(46), false) : null;
            ModalityOfImagingMeasurement = segments.Length > 47 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(47), false) : null;
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
                                StringHelper.StringFormatSequence(0, 48, Configuration.FieldSeparator),
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                ProducersServiceTestObservationId?.ToDelimitedString(),
                                PermittedDataTypes != null ? string.Join(Configuration.FieldRepeatSeparator, PermittedDataTypes) : null,
                                SpecimenRequired,
                                ProducerId?.ToDelimitedString(),
                                ObservationDescription?.ToDelimitedString(),
                                OtherServiceTestObservationIdsForTheObservation?.ToDelimitedString(),
                                OtherNames != null ? string.Join(Configuration.FieldRepeatSeparator, OtherNames) : null,
                                PreferredReportNameForTheObservation,
                                PreferredShortNameOrMnemonicForTheObservation,
                                PreferredLongNameForTheObservation,
                                Orderability,
                                IdentityOfInstrumentUsedToPerformThisStudy != null ? string.Join(Configuration.FieldRepeatSeparator, IdentityOfInstrumentUsedToPerformThisStudy.Select(x => x.ToDelimitedString())) : null,
                                CodedRepresentationOfMethod?.ToDelimitedString(),
                                PortableDeviceIndicator,
                                ObservationProducingDepartmentSection != null ? string.Join(Configuration.FieldRepeatSeparator, ObservationProducingDepartmentSection.Select(x => x.ToDelimitedString())) : null,
                                TelephoneNumberOfSection?.ToDelimitedString(),
                                NatureOfServiceTestObservation,
                                ReportSubheader?.ToDelimitedString(),
                                ReportDisplayOrder,
                                DateTimeStampForAnyChangeInDefinitionForTheObservation.HasValue ? DateTimeStampForAnyChangeInDefinitionForTheObservation.Value.ToString(Consts.DateTimeFormatPrecisionSecond) : null,
                                EffectiveDateTimeOfChange.HasValue ? EffectiveDateTimeOfChange.Value.ToString(Consts.DateTimeFormatPrecisionSecond) : null,
                                TypicalTurnAroundTime.HasValue ? TypicalTurnAroundTime.Value.ToString(Consts.NumericFormat) : null,
                                ProcessingTime.HasValue ? ProcessingTime.Value.ToString(Consts.NumericFormat) : null,
                                ProcessingPriority != null ? string.Join(Configuration.FieldRepeatSeparator, ProcessingPriority) : null,
                                ReportingPriority,
                                OutsideSitesWhereObservationMayBePerformed != null ? string.Join(Configuration.FieldRepeatSeparator, OutsideSitesWhereObservationMayBePerformed.Select(x => x.ToDelimitedString())) : null,
                                AddressOfOutsideSites?.ToDelimitedString(),
                                PhoneNumberOfOutsideSite?.ToDelimitedString(),
                                ConfidentialityCode,
                                ObservationsRequiredToInterpretThisObservation?.ToDelimitedString(),
                                InterpretationOfObservations?.ToDelimitedString(),
                                ContraindicationsToObservations?.ToDelimitedString(),
                                ReflexTestsObservations != null ? string.Join(Configuration.FieldRepeatSeparator, ReflexTestsObservations.Select(x => x.ToDelimitedString())) : null,
                                RulesThatTriggerReflexTesting,
                                FixedCannedMessage?.ToDelimitedString(),
                                PatientPreparation?.ToDelimitedString(),
                                ProcedureMedication?.ToDelimitedString(),
                                FactorsThatMayAffectTheObservation?.ToDelimitedString(),
                                ServiceTestObservationPerformanceSchedule != null ? string.Join(Configuration.FieldRepeatSeparator, ServiceTestObservationPerformanceSchedule) : null,
                                DescriptionOfTestMethods?.ToDelimitedString(),
                                KindOfQuantityObserved?.ToDelimitedString(),
                                PointVersusInterval?.ToDelimitedString(),
                                ChallengeInformation?.ToDelimitedString(),
                                RelationshipModifier?.ToDelimitedString(),
                                TargetAnatomicSiteOfTest?.ToDelimitedString(),
                                ModalityOfImagingMeasurement?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}