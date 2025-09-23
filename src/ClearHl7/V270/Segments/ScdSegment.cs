using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SCD - Anti-Microbial Cycle Data.
    /// </summary>
    public class ScdSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScdSegment"/> class.
        /// </summary>
        public ScdSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScdSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public ScdSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "SCD";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0682 Device Status -&gt; ClearHl7.Codes.V270.CodeDeviceStatus</para>
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
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions AbortCycle { get; set; }

        /// <summary>
        /// SCD.20 - Alarm.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions Alarm { get; set; }

        /// <summary>
        /// SCD.21 - Long in Charge Phase.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions LongInChargePhase { get; set; }

        /// <summary>
        /// SCD.22 - Long in Exhaust Phase.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions LongInExhaustPhase { get; set; }

        /// <summary>
        /// SCD.23 - Long in Fast Exhaust Phase.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions LongInFastExhaustPhase { get; set; }

        /// <summary>
        /// SCD.24 - Reset.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions Reset { get; set; }

        /// <summary>
        /// SCD.25 - Operator - Unload.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons OperatorUnload { get; set; }

        /// <summary>
        /// SCD.26 - Door Open.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions DoorOpen { get; set; }

        /// <summary>
        /// SCD.27 - Reading Failure.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions ReadingFailure { get; set; }

        /// <summary>
        /// SCD.28 - Cycle Type.
        /// <para>Suggested: 0702 Cycle Type -&gt; ClearHl7.Codes.V270.CodeCycleType</para>
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

            CycleStartTime = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
            CycleCount = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            TempMax = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[3], false, seps) : null;
            TempMin = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[4], false, seps) : null;
            LoadNumber = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            ConditionTime = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[6], false, seps) : null;
            SterilizeTime = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[7], false, seps) : null;
            ExhaustTime = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[8], false, seps) : null;
            TotalCycleTime = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[9], false, seps) : null;
            DeviceStatus = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[10], false, seps) : null;
            CycleStartDateTime = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDateTime() : null;
            DryTime = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[12], false, seps) : null;
            LeakRate = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[13], false, seps) : null;
            ControlTemperature = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[14], false, seps) : null;
            SterilizerTemperature = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[15], false, seps) : null;
            CycleCompleteTime = segments.Length > 16 && segments[16].Length > 0 ? segments[16].ToNullableDateTime() : null;
            UnderTemperature = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[17], false, seps) : null;
            OverTemperature = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[18], false, seps) : null;
            AbortCycle = segments.Length > 19 && segments[19].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[19], false, seps) : null;
            Alarm = segments.Length > 20 && segments[20].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[20], false, seps) : null;
            LongInChargePhase = segments.Length > 21 && segments[21].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[21], false, seps) : null;
            LongInExhaustPhase = segments.Length > 22 && segments[22].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[22], false, seps) : null;
            LongInFastExhaustPhase = segments.Length > 23 && segments[23].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[23], false, seps) : null;
            Reset = segments.Length > 24 && segments[24].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[24], false, seps) : null;
            OperatorUnload = segments.Length > 25 && segments[25].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[25], false, seps) : null;
            DoorOpen = segments.Length > 26 && segments[26].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[26], false, seps) : null;
            ReadingFailure = segments.Length > 27 && segments[27].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[27], false, seps) : null;
            CycleType = segments.Length > 28 && segments[28].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[28], false, seps) : null;
            ThermalRinseTime = segments.Length > 29 && segments[29].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[29], false, seps) : null;
            WashTime = segments.Length > 30 && segments[30].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[30], false, seps) : null;
            InjectionRate = segments.Length > 31 && segments[31].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[31], false, seps) : null;
            ProcedureCode = segments.Length > 32 && segments[32].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[32], false, seps) : null;
            PatientIdentifierList = segments.Length > 33 && segments[33].Length > 0 ? segments[33].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            AttendingDoctor = segments.Length > 34 && segments[34].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[34], false, seps) : null;
            DilutionFactor = segments.Length > 35 && segments[35].Length > 0 ? TypeSerializer.Deserialize<StructuredNumeric>(segments[35], false, seps) : null;
            FillTime = segments.Length > 36 && segments[36].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[36], false, seps) : null;
            InletTemperature = segments.Length > 37 && segments[37].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[37], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 38, Configuration.FieldSeparator),
                                Id,
                                CycleStartTime.ToHl7DateTimeString(typeof(ScdSegment), nameof(CycleStartTime), Consts.TimeFormatPrecisionSecond, culture),
                                CycleCount.HasValue ? CycleCount.Value.ToString(Consts.NumericFormat, culture) : null,
                                TempMax?.ToDelimitedString(),
                                TempMin?.ToDelimitedString(),
                                LoadNumber.HasValue ? LoadNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                ConditionTime?.ToDelimitedString(),
                                SterilizeTime?.ToDelimitedString(),
                                ExhaustTime?.ToDelimitedString(),
                                TotalCycleTime?.ToDelimitedString(),
                                DeviceStatus?.ToDelimitedString(),
                                CycleStartDateTime.ToHl7DateTimeString(typeof(ScdSegment), nameof(CycleStartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                DryTime?.ToDelimitedString(),
                                LeakRate?.ToDelimitedString(),
                                ControlTemperature?.ToDelimitedString(),
                                SterilizerTemperature?.ToDelimitedString(),
                                CycleCompleteTime.ToHl7DateTimeString(typeof(ScdSegment), nameof(CycleCompleteTime), Consts.TimeFormatPrecisionSecond, culture),
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
