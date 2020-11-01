using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V270.Types;

namespace ClearHl7.Fhir.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SCD - Anti-Microbial Cycle Data.
    /// </summary>
    public class ScdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SCD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// SCD.1 - Cycle Start Time.
        /// </summary>
        public DateTime? CycleStartTime { get; set; }

        /// <summary>
        /// SCD.2 - Cycle Count.
        /// </summary>
        public decimal? CycleCount { get; set; }

        /// <summary>
        /// SCD.3 - Temp Max.
        /// </summary>
        public CompositeQuantityWithUnits TempMax { get; set; }

        /// <summary>
        /// SCD.4 - Temp Min.
        /// </summary>
        public CompositeQuantityWithUnits TempMin { get; set; }

        /// <summary>
        /// SCD.5 - Load Number.
        /// </summary>
        public decimal? LoadNumber { get; set; }

        /// <summary>
        /// SCD.6 - Condition Time.
        /// </summary>
        public CompositeQuantityWithUnits ConditionTime { get; set; }

        /// <summary>
        /// SCD.7 - Sterilize Time.
        /// </summary>
        public CompositeQuantityWithUnits SterilizeTime { get; set; }

        /// <summary>
        /// SCD.8 - Exhaust Time.
        /// </summary>
        public CompositeQuantityWithUnits ExhaustTime { get; set; }

        /// <summary>
        /// SCD.9 - Total Cycle Time.
        /// </summary>
        public CompositeQuantityWithUnits TotalCycleTime { get; set; }

        /// <summary>
        /// SCD.10 - Device Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0682</remarks>
        public CodedWithExceptions DeviceStatus { get; set; }

        /// <summary>
        /// SCD.11 - Cycle Start Date/Time.
        /// </summary>
        public DateTime? CycleStartDateTime { get; set; }

        /// <summary>
        /// SCD.12 - Dry Time.
        /// </summary>
        public CompositeQuantityWithUnits DryTime { get; set; }

        /// <summary>
        /// SCD.13 - Leak Rate.
        /// </summary>
        public CompositeQuantityWithUnits LeakRate { get; set; }

        /// <summary>
        /// SCD.14 - Control Temperature.
        /// </summary>
        public CompositeQuantityWithUnits ControlTemperature { get; set; }

        /// <summary>
        /// SCD.15 - Sterilizer Temperature.
        /// </summary>
        public CompositeQuantityWithUnits SterilizerTemperature { get; set; }

        /// <summary>
        /// SCD.16 - Cycle Complete Time.
        /// </summary>
        public DateTime? CycleCompleteTime { get; set; }

        /// <summary>
        /// SCD.17 - Under Temperature.
        /// </summary>
        public CompositeQuantityWithUnits UnderTemperature { get; set; }

        /// <summary>
        /// SCD.18 - Over Temperature.
        /// </summary>
        public CompositeQuantityWithUnits OverTemperature { get; set; }

        /// <summary>
        /// SCD.19 - Abort Cycle.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0532</remarks>
        public CodedWithNoExceptions AbortCycle { get; set; }

        /// <summary>
        /// SCD.20 - Alarm.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0532</remarks>
        public CodedWithNoExceptions Alarm { get; set; }

        /// <summary>
        /// SCD.21 - Long in Charge Phase.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0532</remarks>
        public CodedWithNoExceptions LongInChargePhase { get; set; }

        /// <summary>
        /// SCD.22 - Long in Exhaust Phase.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0532</remarks>
        public CodedWithNoExceptions LongInExhaustPhase { get; set; }

        /// <summary>
        /// SCD.23 - Long in Fast Exhaust Phase.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0532</remarks>
        public CodedWithNoExceptions LongInFastExhaustPhase { get; set; }

        /// <summary>
        /// SCD.24 - Reset.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0532</remarks>
        public CodedWithNoExceptions Reset { get; set; }

        /// <summary>
        /// SCD.25 - Operator - Unload.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons OperatorUnload { get; set; }

        /// <summary>
        /// SCD.26 - Door Open.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0532</remarks>
        public CodedWithNoExceptions DoorOpen { get; set; }

        /// <summary>
        /// SCD.27 - Reading Failure.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0532</remarks>
        public CodedWithNoExceptions ReadingFailure { get; set; }

        /// <summary>
        /// SCD.28 - Cycle Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0702</remarks>
        public CodedWithExceptions CycleType { get; set; }

        /// <summary>
        /// SCD.29 - Thermal Rinse Time.
        /// </summary>
        public CompositeQuantityWithUnits ThermalRinseTime { get; set; }

        /// <summary>
        /// SCD.30 - Wash Time.
        /// </summary>
        public CompositeQuantityWithUnits WashTime { get; set; }

        /// <summary>
        /// SCD.31 - Injection Rate.
        /// </summary>
        public CompositeQuantityWithUnits InjectionRate { get; set; }

        /// <summary>
        /// SCD.32 - Procedure Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0088</remarks>
        public CodedWithNoExceptions ProcedureCode { get; set; }

        /// <summary>
        /// SCD.33 - Patient Identifier List.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> PatientIdentifierList { get; set; }

        /// <summary>
        /// SCD.34 - Attending Doctor.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0010</remarks>
        public ExtendedCompositeIdNumberAndNameForPersons AttendingDoctor { get; set; }

        /// <summary>
        /// SCD.35 - Dilution Factor.
        /// </summary>
        public StructuredNumeric DilutionFactor { get; set; }

        /// <summary>
        /// SCD.36 - Fill Time.
        /// </summary>
        public CompositeQuantityWithUnits FillTime { get; set; }

        /// <summary>
        /// SCD.37 - Inlet Temperature.
        /// </summary>
        public CompositeQuantityWithUnits InletTemperature { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}",
                                Id,
                                CycleStartTime.HasValue ? CycleStartTime.Value.ToString(Consts.TimeFormatPrecisionSecond, culture) : null,
                                CycleCount.HasValue ? CycleCount.Value.ToString(Consts.NumericFormat, culture) : null,
                                TempMax?.ToDelimitedString(),
                                TempMin?.ToDelimitedString(),
                                LoadNumber.HasValue ? LoadNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                ConditionTime?.ToDelimitedString(),
                                SterilizeTime?.ToDelimitedString(),
                                ExhaustTime?.ToDelimitedString(),
                                TotalCycleTime?.ToDelimitedString(),
                                DeviceStatus?.ToDelimitedString(),
                                CycleStartDateTime.HasValue ? CycleStartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DryTime?.ToDelimitedString(),
                                LeakRate?.ToDelimitedString(),
                                ControlTemperature?.ToDelimitedString(),
                                SterilizerTemperature?.ToDelimitedString(),
                                CycleCompleteTime.HasValue ? CycleCompleteTime.Value.ToString(Consts.TimeFormatPrecisionSecond, culture) : null,
                                UnderTemperature?.ToDelimitedString(),
                                OverTemperature?.ToDelimitedString(),
                                AbortCycle?.ToDelimitedString(),
                                Alarm?.ToDelimitedString(),
                                LongInChargePhase?.ToDelimitedString(),
                                LongInExhaustPhase?.ToDelimitedString(),
                                LongInFastExhaustPhase?.ToDelimitedString(),
                                Reset?.ToDelimitedString(),
                                OperatorUnload?.ToDelimitedString(),
                                DoorOpen?.ToDelimitedString(),
                                ReadingFailure?.ToDelimitedString(),
                                CycleType?.ToDelimitedString(),
                                ThermalRinseTime?.ToDelimitedString(),
                                WashTime?.ToDelimitedString(),
                                InjectionRate?.ToDelimitedString(),
                                ProcedureCode?.ToDelimitedString(),
                                PatientIdentifierList != null ? string.Join("~", PatientIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                AttendingDoctor?.ToDelimitedString(),
                                DilutionFactor?.ToDelimitedString(),
                                FillTime?.ToDelimitedString(),
                                InletTemperature?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}