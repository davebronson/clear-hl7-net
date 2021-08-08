using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
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
        /// <para>Suggested: 0682 Device Status -&gt; ClearHl7.Codes.V281.CodeDeviceStatus</para>
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
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions AbortCycle { get; set; }

        /// <summary>
        /// SCD.20 - Alarm.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions Alarm { get; set; }

        /// <summary>
        /// SCD.21 - Long in Charge Phase.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions LongInChargePhase { get; set; }

        /// <summary>
        /// SCD.22 - Long in Exhaust Phase.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions LongInExhaustPhase { get; set; }

        /// <summary>
        /// SCD.23 - Long in Fast Exhaust Phase.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions LongInFastExhaustPhase { get; set; }

        /// <summary>
        /// SCD.24 - Reset.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions Reset { get; set; }

        /// <summary>
        /// SCD.25 - Operator - Unload.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons OperatorUnload { get; set; }

        /// <summary>
        /// SCD.26 - Door Open.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions DoorOpen { get; set; }

        /// <summary>
        /// SCD.27 - Reading Failure.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions ReadingFailure { get; set; }

        /// <summary>
        /// SCD.28 - Cycle Type.
        /// <para>Suggested: 0702 Cycle Type -&gt; ClearHl7.Codes.V281.CodeCycleType</para>
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

            CycleStartTime = segments.ElementAtOrDefault(1)?.ToNullableDateTime(Consts.TimeFormatPrecisionSecond);
            CycleCount = segments.ElementAtOrDefault(2)?.ToNullableDecimal();
            TempMax = segments.Length > 3 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(3), false) : null;
            TempMin = segments.Length > 4 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(4), false) : null;
            LoadNumber = segments.ElementAtOrDefault(5)?.ToNullableDecimal();
            ConditionTime = segments.Length > 6 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(6), false) : null;
            SterilizeTime = segments.Length > 7 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(7), false) : null;
            ExhaustTime = segments.Length > 8 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(8), false) : null;
            TotalCycleTime = segments.Length > 9 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(9), false) : null;
            DeviceStatus = segments.Length > 10 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(10), false) : null;
            CycleStartDateTime = segments.ElementAtOrDefault(11)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            DryTime = segments.Length > 12 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(12), false) : null;
            LeakRate = segments.Length > 13 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(13), false) : null;
            ControlTemperature = segments.Length > 14 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(14), false) : null;
            SterilizerTemperature = segments.Length > 15 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(15), false) : null;
            CycleCompleteTime = segments.ElementAtOrDefault(16)?.ToNullableDateTime(Consts.TimeFormatPrecisionSecond);
            UnderTemperature = segments.Length > 17 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(17), false) : null;
            OverTemperature = segments.Length > 18 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(18), false) : null;
            AbortCycle = segments.Length > 19 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(19), false) : null;
            Alarm = segments.Length > 20 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(20), false) : null;
            LongInChargePhase = segments.Length > 21 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(21), false) : null;
            LongInExhaustPhase = segments.Length > 22 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(22), false) : null;
            LongInFastExhaustPhase = segments.Length > 23 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(23), false) : null;
            Reset = segments.Length > 24 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(24), false) : null;
            OperatorUnload = segments.Length > 25 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(25), false) : null;
            DoorOpen = segments.Length > 26 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(26), false) : null;
            ReadingFailure = segments.Length > 27 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(27), false) : null;
            CycleType = segments.Length > 28 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(28), false) : null;
            ThermalRinseTime = segments.Length > 29 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(29), false) : null;
            WashTime = segments.Length > 30 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(30), false) : null;
            InjectionRate = segments.Length > 31 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(31), false) : null;
            ProcedureCode = segments.Length > 32 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(32), false) : null;
            PatientIdentifierList = segments.Length > 33 ? segments.ElementAtOrDefault(33).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            AttendingDoctor = segments.Length > 34 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(34), false) : null;
            DilutionFactor = segments.Length > 35 ? TypeHelper.Deserialize<StructuredNumeric>(segments.ElementAtOrDefault(35), false) : null;
            FillTime = segments.Length > 36 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(36), false) : null;
            InletTemperature = segments.Length > 37 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(37), false) : null;
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