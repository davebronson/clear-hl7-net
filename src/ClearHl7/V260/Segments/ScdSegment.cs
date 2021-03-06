using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
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
        /// <para>Suggested: 0682 Device Status -&gt; ClearHl7.Codes.V260.CodeDeviceStatus</para>
        /// </summary>
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
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions AbortCycle { get; set; }

        /// <summary>
        /// SCD.20 - Alarm.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions Alarm { get; set; }

        /// <summary>
        /// SCD.21 - Long in Charge Phase.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions LongInChargePhase { get; set; }

        /// <summary>
        /// SCD.22 - Long in Exhaust Phase.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions LongInExhaustPhase { get; set; }

        /// <summary>
        /// SCD.23 - Long in Fast Exhaust Phase.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions LongInFastExhaustPhase { get; set; }

        /// <summary>
        /// SCD.24 - Reset.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions Reset { get; set; }

        /// <summary>
        /// SCD.25 - Operator - Unload.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons OperatorUnload { get; set; }

        /// <summary>
        /// SCD.26 - Door Open.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions DoorOpen { get; set; }

        /// <summary>
        /// SCD.27 - Reading Failure.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions ReadingFailure { get; set; }

        /// <summary>
        /// SCD.28 - Cycle Type.
        /// <para>Suggested: 0702 Cycle Type -&gt; ClearHl7.Codes.V260.CodeCycleType</para>
        /// </summary>
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
        /// <para>Suggested: 0088 Procedure Code</para>
        /// </summary>
        public CodedWithNoExceptions ProcedureCode { get; set; }

        /// <summary>
        /// SCD.33 - Patient Identifier List.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> PatientIdentifierList { get; set; }

        /// <summary>
        /// SCD.34 - Attending Doctor.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
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
                                StringHelper.StringFormatSequence(0, 38, Configuration.FieldSeparator),
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
                                PatientIdentifierList != null ? string.Join(Configuration.FieldRepeatSeparator, PatientIdentifierList.Select(x => x.ToDelimitedString())) : null,
                                AttendingDoctor?.ToDelimitedString(),
                                DilutionFactor?.ToDelimitedString(),
                                FillTime?.ToDelimitedString(),
                                InletTemperature?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}