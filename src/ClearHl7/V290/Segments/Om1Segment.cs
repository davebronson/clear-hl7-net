using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V290.Types;

namespace ClearHl7.Fhir.V290.Segments
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
        public CodedWithExceptions ProducersServiceTestObservationId { get; set; }

        /// <summary>
        /// OM1.3 - Permitted Data Types.
        /// <para>Suggested: 0125 Value Type -&gt; ClearHl7.Fhir.Codes.V290.CodeValueType</para>
        /// </summary>
        public IEnumerable<string> PermittedDataTypes { get; set; }

        /// <summary>
        /// OM1.4 - Specimen Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Fhir.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string SpecimenRequired { get; set; }

        /// <summary>
        /// OM1.5 - Producer ID.
        /// <para>Suggested: 0631 Producer ID</para>
        /// </summary>
        public CodedWithExceptions ProducerId { get; set; }

        /// <summary>
        /// OM1.6 - Observation Description.
        /// </summary>
        public Text ObservationDescription { get; set; }

        /// <summary>
        /// OM1.7 - Other Service/Test/Observation IDs for the Observation.
        /// <para>Suggested: 0632 Other Service/Test/Observation IDs</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Fhir.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string Orderability { get; set; }

        /// <summary>
        /// OM1.13 - Identity of Instrument Used to Perform this Study.
        /// <para>Suggested: 0633 Identity Of Instrument Used To Perform This Study</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> IdentityOfInstrumentUsedToPerformThisStudy { get; set; }

        /// <summary>
        /// OM1.14 - Coded Representation of Method.
        /// <para>Suggested: 0635 Coded Representation of Method</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> CodedRepresentationOfMethod { get; set; }

        /// <summary>
        /// OM1.15 - Portable Device Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Fhir.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string PortableDeviceIndicator { get; set; }

        /// <summary>
        /// OM1.16 - Observation Producing Department/Section.
        /// <para>Suggested: 0636 Observation Producing Department/Section</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ObservationProducingDepartmentSection { get; set; }

        /// <summary>
        /// OM1.17 - Telephone Number of Section.
        /// </summary>
        public ExtendedTelecommunicationNumber TelephoneNumberOfSection { get; set; }

        /// <summary>
        /// OM1.18 - Nature of Service/Test/Observation.
        /// <para>Suggested: 0174 Nature Of Service/Test/Observation -&gt; ClearHl7.Fhir.Codes.V290.CodeNatureOfServiceTestObservation</para>
        /// </summary>
        public CodedWithExceptions NatureOfServiceTestObservation { get; set; }

        /// <summary>
        /// OM1.19 - Report Subheader.
        /// <para>Suggested: 0637 Report Subheader</para>
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
        /// <para>Suggested: 0168 Processing Priority -&gt; ClearHl7.Fhir.Codes.V290.CodeProcessingPriority</para>
        /// </summary>
        public IEnumerable<string> ProcessingPriority { get; set; }

        /// <summary>
        /// OM1.26 - Reporting Priority.
        /// <para>Suggested: 0169 Reporting Priority -&gt; ClearHl7.Fhir.Codes.V290.CodeReportingPriority</para>
        /// </summary>
        public string ReportingPriority { get; set; }

        /// <summary>
        /// OM1.27 - Outside Site(s) Where Observation May Be Performed.
        /// <para>Suggested: 0638 Outside Site(s) Where Observation May Be Performed</para>
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
        /// <para>Suggested: 0177 Confidentiality Code -&gt; ClearHl7.Fhir.Codes.V290.CodeConfidentialityCode</para>
        /// </summary>
        public CodedWithExceptions ConfidentialityCode { get; set; }

        /// <summary>
        /// OM1.31 - Observations Required to Interpret this Observation.
        /// <para>Suggested: 0639 Observations Required to Interpret this</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ObservationsRequiredToInterpretThisObservation { get; set; }

        /// <summary>
        /// OM1.32 - Interpretation of Observations.
        /// </summary>
        public Text InterpretationOfObservations { get; set; }

        /// <summary>
        /// OM1.33 - Contraindications to Observations.
        /// <para>Suggested: 0640 Contraindications to Observations</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ContraindicationsToObservations { get; set; }

        /// <summary>
        /// OM1.34 - Reflex Tests/Observations.
        /// <para>Suggested: 0641 Reflex Tests/Observations</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ReflexTestsObservations { get; set; }

        /// <summary>
        /// OM1.35 - Rules that Trigger Reflex Testing.
        /// </summary>
        public IEnumerable<Text> RulesThatTriggerReflexTesting { get; set; }

        /// <summary>
        /// OM1.36 - Fixed Canned Message.
        /// <para>Suggested: 0643 Fixed Canned Message</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> FixedCannedMessage { get; set; }

        /// <summary>
        /// OM1.37 - Patient Preparation.
        /// </summary>
        public IEnumerable<Text> PatientPreparation { get; set; }

        /// <summary>
        /// OM1.38 - Procedure Medication.
        /// <para>Suggested: 0644 Procedure Medication</para>
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
        /// <para>Suggested: 0254 Kind of Quantity -&gt; ClearHl7.Fhir.Codes.V290.CodeKindOfQuantity</para>
        /// </summary>
        public CodedWithExceptions KindOfQuantityObserved { get; set; }

        /// <summary>
        /// OM1.43 - Point Versus Interval.
        /// <para>Suggested: 0255 Duration Categories -&gt; ClearHl7.Fhir.Codes.V290.CodeDurationCategories</para>
        /// </summary>
        public CodedWithExceptions PointVersusInterval { get; set; }

        /// <summary>
        /// OM1.44 - Challenge Information.
        /// <para>Suggested: 0256 Time Delay Post Challenge -&gt; ClearHl7.Fhir.Codes.V290.CodeTimeDelayPostChallenge</para>
        /// </summary>
        public Text ChallengeInformation { get; set; }

        /// <summary>
        /// OM1.45 - Relationship Modifier.
        /// <para>Suggested: 0258 Relationship Modifier -&gt; ClearHl7.Fhir.Codes.V290.CodeRelationshipModifier</para>
        /// </summary>
        public CodedWithExceptions RelationshipModifier { get; set; }

        /// <summary>
        /// OM1.46 - Target Anatomic Site Of Test.
        /// <para>Suggested: 0645 Target Anatomic Site Of Test</para>
        /// </summary>
        public CodedWithExceptions TargetAnatomicSiteOfTest { get; set; }

        /// <summary>
        /// OM1.47 - Modality of Imaging Measurement.
        /// <para>Suggested: 0910 Modality Of Imaging Measurement</para>
        /// </summary>
        public CodedWithExceptions ModalityOfImagingMeasurement { get; set; }

        /// <summary>
        /// OM1.48 - Exclusive Test.
        /// <para>Suggested: 0919 Exclusive Test -&gt; ClearHl7.Fhir.Codes.V290.CodeExclusiveTest</para>
        /// </summary>
        public string ExclusiveTest { get; set; }

        /// <summary>
        /// OM1.49 - Diagnostic Serv Sect ID.
        /// <para>Suggested: 0074 Diagnostic Service Section ID -&gt; ClearHl7.Fhir.Codes.V290.CodeDiagnosticServiceSectionId</para>
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

        /// <summary>
        /// OM1.52 - Replacement Producer's Service/Test/Observation ID.
        /// <para>Suggested: 0646 Replacement Producer's Service/Test/Observation ID</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ReplacementProducersServiceTestObservationId { get; set; }

        /// <summary>
        /// OM1.53 - Prior Results Instructions.
        /// </summary>
        public IEnumerable<Text> PriorResultsInstructions { get; set; }

        /// <summary>
        /// OM1.54 - Special Instructions.
        /// </summary>
        public Text SpecialInstructions { get; set; }

        /// <summary>
        /// OM1.55 - Test Category.
        /// </summary>
        public IEnumerable<CodedWithExceptions> TestCategory { get; set; }

        /// <summary>
        /// OM1.56 - Observation/Identifier associated with Producer's Service/Test/Observation ID.
        /// <para>Suggested: 0647 Observation/Identifier associated with Producer’s Service/Test/Observation ID</para>
        /// </summary>
        public CodedWithExceptions ObservationIdAssociatedWithProducersServiceTestObservationId { get; set; }

        /// <summary>
        /// OM1.57 - Typical Turn-Around Time.
        /// </summary>
        public CompositeQuantityWithUnits TypicalTurnAroundTimeWithUnits { get; set; }

        /// <summary>
        /// OM1.58 - Gender Restriction.
        /// <para>Suggested: 0001 Administrative Sex -&gt; ClearHl7.Fhir.Codes.V290.CodeAdministrativeSex</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> GenderRestriction { get; set; }

        /// <summary>
        /// OM1.59 - Age Restriction.
        /// </summary>
        public IEnumerable<NumericRange> AgeRestriction { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 60, Configuration.FieldSeparator),
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
                                DateTimeStampForAnyChangeInDefinitionForTheObservation.HasValue ? DateTimeStampForAnyChangeInDefinitionForTheObservation.Value.ToString(Consts.DateTimeFormatPrecisionSecond) : null,
                                EffectiveDateTimeOfChange.HasValue ? EffectiveDateTimeOfChange.Value.ToString(Consts.DateTimeFormatPrecisionSecond) : null,
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
                                OtherNamesB != null ? string.Join(Configuration.FieldRepeatSeparator, OtherNamesB) : null,
                                ReplacementProducersServiceTestObservationId != null ? string.Join(Configuration.FieldRepeatSeparator, ReplacementProducersServiceTestObservationId.Select(x => x.ToDelimitedString())) : null,
                                PriorResultsInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, PriorResultsInstructions.Select(x => x.ToDelimitedString())) : null,
                                SpecialInstructions?.ToDelimitedString(),
                                TestCategory != null ? string.Join(Configuration.FieldRepeatSeparator, TestCategory.Select(x => x.ToDelimitedString())) : null,
                                ObservationIdAssociatedWithProducersServiceTestObservationId?.ToDelimitedString(),
                                TypicalTurnAroundTimeWithUnits?.ToDelimitedString(),
                                GenderRestriction != null ? string.Join(Configuration.FieldRepeatSeparator, GenderRestriction.Select(x => x.ToDelimitedString())) : null,
                                AgeRestriction != null ? string.Join(Configuration.FieldRepeatSeparator, AgeRestriction.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}