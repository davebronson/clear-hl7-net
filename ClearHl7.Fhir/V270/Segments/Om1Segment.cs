using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V270.Types;

namespace ClearHl7.Fhir.V270.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0125</remarks>
        public IEnumerable<string> PermittedDataTypes { get; set; }

        /// <summary>
        /// OM1.4 - Specimen Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
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
        public CodedWithExceptions OtherServiceTestObservationIdsForTheObservation { get; set; }

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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0174</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0168</remarks>
        public IEnumerable<string> ProcessingPriority { get; set; }

        /// <summary>
        /// OM1.26 - Reporting Priority.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0169</remarks>
        public string ReportingPriority { get; set; }

        /// <summary>
        /// OM1.27 - Outside Site(s) Where Observation May Be Performed.
        /// </summary>
        public IEnumerable<CodedWithExceptions> OutsideSiteSWhereObservationMayBePerformed { get; set; }

        /// <summary>
        /// OM1.28 - Address of Outside Site(s).
        /// </summary>
        public IEnumerable<ExtendedAddress> AddressOfOutsideSiteS { get; set; }

        /// <summary>
        /// OM1.29 - Phone Number of Outside Site.
        /// </summary>
        public ExtendedTelecommunicationNumber PhoneNumberOfOutsideSite { get; set; }

        /// <summary>
        /// OM1.30 - Confidentiality Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0177</remarks>
        public CodedWithExceptions ConfidentialityCode { get; set; }

        /// <summary>
        /// OM1.31 - Observations Required to Interpret this Observation.
        /// </summary>
        public CodedWithExceptions ObservationsRequiredToInterpretThisObservation { get; set; }

        /// <summary>
        /// OM1.32 - Interpretation of Observations.
        /// </summary>
        public Text InterpretationOfObservations { get; set; }

        /// <summary>
        /// OM1.33 - Contraindications to Observations.
        /// </summary>
        public CodedWithExceptions ContraindicationsToObservations { get; set; }

        /// <summary>
        /// OM1.34 - Reflex Tests/Observations.
        /// </summary>
        public IEnumerable<CodedWithExceptions> ReflexTestsObservations { get; set; }

        /// <summary>
        /// OM1.35 - Rules that Trigger Reflex Testing.
        /// </summary>
        public Text RulesThatTriggerReflexTesting { get; set; }

        /// <summary>
        /// OM1.36 - Fixed Canned Message.
        /// </summary>
        public CodedWithExceptions FixedCannedMessage { get; set; }

        /// <summary>
        /// OM1.37 - Patient Preparation.
        /// </summary>
        public Text PatientPreparation { get; set; }

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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0254</remarks>
        public CodedWithExceptions KindOfQuantityObserved { get; set; }

        /// <summary>
        /// OM1.43 - Point Versus Interval.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0255</remarks>
        public CodedWithExceptions PointVersusInterval { get; set; }

        /// <summary>
        /// OM1.44 - Challenge Information.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0256</remarks>
        public Text ChallengeInformation { get; set; }

        /// <summary>
        /// OM1.45 - Relationship Modifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0258</remarks>
        public CodedWithExceptions RelationshipModifier { get; set; }

        /// <summary>
        /// OM1.46 - Target Anatomic Site Of Test.
        /// </summary>
        public CodedWithExceptions TargetAnatomicSiteOfTest { get; set; }

        /// <summary>
        /// OM1.47 - Modality of Imaging Measurement.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0910</remarks>
        public CodedWithExceptions ModalityOfImagingMeasurement { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}|{38}|{39}|{40}|{41}|{42}|{43}|{44}|{45}|{46}|{47}",
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                ProducersServiceTestObservationId?.ToDelimitedString(),
                                PermittedDataTypes != null ? string.Join("~", PermittedDataTypes) : null,
                                SpecimenRequired,
                                ProducerId?.ToDelimitedString(),
                                ObservationDescription?.ToDelimitedString(),
                                OtherServiceTestObservationIdsForTheObservation?.ToDelimitedString(),
                                OtherNames != null ? string.Join("~", OtherNames) : null,
                                PreferredReportNameForTheObservation,
                                PreferredShortNameOrMnemonicForTheObservation,
                                PreferredLongNameForTheObservation,
                                Orderability,
                                IdentityOfInstrumentUsedToPerformThisStudy != null ? string.Join("~", IdentityOfInstrumentUsedToPerformThisStudy.Select(x => x.ToDelimitedString())) : null,
                                CodedRepresentationOfMethod != null ? string.Join("~", CodedRepresentationOfMethod.Select(x => x.ToDelimitedString())) : null,
                                PortableDeviceIndicator,
                                ObservationProducingDepartmentSection != null ? string.Join("~", ObservationProducingDepartmentSection.Select(x => x.ToDelimitedString())) : null,
                                TelephoneNumberOfSection?.ToDelimitedString(),
                                NatureOfServiceTestObservation?.ToDelimitedString(),
                                ReportSubheader?.ToDelimitedString(),
                                ReportDisplayOrder,
                                DateTimeStampForAnyChangeInDefinitionForTheObservation.HasValue ? DateTimeStampForAnyChangeInDefinitionForTheObservation.Value.ToString(Consts.DateTimeFormatPrecisionSecond) : null,
                                EffectiveDateTimeOfChange.HasValue ? EffectiveDateTimeOfChange.Value.ToString(Consts.DateTimeFormatPrecisionSecond) : null,
                                TypicalTurnAroundTime.HasValue ? TypicalTurnAroundTime.Value.ToString(Consts.NumericFormat) : null,
                                ProcessingTime.HasValue ? ProcessingTime.Value.ToString(Consts.NumericFormat) : null,
                                ProcessingPriority != null ? string.Join("~", ProcessingPriority) : null,
                                ReportingPriority,
                                OutsideSiteSWhereObservationMayBePerformed != null ? string.Join("~", OutsideSiteSWhereObservationMayBePerformed.Select(x => x.ToDelimitedString())) : null,
                                AddressOfOutsideSiteS != null ? string.Join("~", AddressOfOutsideSiteS.Select(x => x.ToDelimitedString())) : null,
                                PhoneNumberOfOutsideSite?.ToDelimitedString(),
                                ConfidentialityCode?.ToDelimitedString(),
                                ObservationsRequiredToInterpretThisObservation?.ToDelimitedString(),
                                InterpretationOfObservations?.ToDelimitedString(),
                                ContraindicationsToObservations?.ToDelimitedString(),
                                ReflexTestsObservations != null ? string.Join("~", ReflexTestsObservations.Select(x => x.ToDelimitedString())) : null,
                                RulesThatTriggerReflexTesting?.ToDelimitedString(),
                                FixedCannedMessage?.ToDelimitedString(),
                                PatientPreparation?.ToDelimitedString(),
                                ProcedureMedication?.ToDelimitedString(),
                                FactorsThatMayAffectTheObservation?.ToDelimitedString(),
                                ServiceTestObservationPerformanceSchedule != null ? string.Join("~", ServiceTestObservationPerformanceSchedule) : null,
                                DescriptionOfTestMethods?.ToDelimitedString(),
                                KindOfQuantityObserved?.ToDelimitedString(),
                                PointVersusInterval?.ToDelimitedString(),
                                ChallengeInformation?.ToDelimitedString(),
                                RelationshipModifier?.ToDelimitedString(),
                                TargetAnatomicSiteOfTest?.ToDelimitedString(),
                                ModalityOfImagingMeasurement?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}