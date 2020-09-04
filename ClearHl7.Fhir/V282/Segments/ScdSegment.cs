using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// SCD.1 - Cycle Start Time.
        ///// </summary>
        //public CycleStartTime { get; set; }

        ///// <summary>
        ///// SCD.2 - Cycle Count.
        ///// </summary>
        //public CycleCount { get; set; }

        ///// <summary>
        ///// SCD.3 - Temp Max.
        ///// </summary>
        //public TempMax { get; set; }

        ///// <summary>
        ///// SCD.4 - Temp Min.
        ///// </summary>
        //public TempMin { get; set; }

        ///// <summary>
        ///// SCD.5 - Load Number.
        ///// </summary>
        //public LoadNumber { get; set; }

        ///// <summary>
        ///// SCD.6 - Condition Time.
        ///// </summary>
        //public ConditionTime { get; set; }

        ///// <summary>
        ///// SCD.7 - Sterilize Time.
        ///// </summary>
        //public SterilizeTime { get; set; }

        ///// <summary>
        ///// SCD.8 - Exhaust Time.
        ///// </summary>
        //public ExhaustTime { get; set; }

        ///// <summary>
        ///// SCD.9 - Total Cycle Time.
        ///// </summary>
        //public TotalCycleTime { get; set; }

        ///// <summary>
        ///// SCD.10 - Device Status.
        ///// </summary>
        //public DeviceStatus { get; set; }

        ///// <summary>
        ///// SCD.11 - Cycle Start Date/Time.
        ///// </summary>
        //public CycleStartDateTime { get; set; }

        ///// <summary>
        ///// SCD.12 - Dry Time.
        ///// </summary>
        //public DryTime { get; set; }

        ///// <summary>
        ///// SCD.13 - Leak Rate.
        ///// </summary>
        //public LeakRate { get; set; }

        ///// <summary>
        ///// SCD.14 - Control Temperature.
        ///// </summary>
        //public ControlTemperature { get; set; }

        ///// <summary>
        ///// SCD.15 - Sterilizer Temperature.
        ///// </summary>
        //public SterilizerTemperature { get; set; }

        ///// <summary>
        ///// SCD.16 - Cycle Complete Time.
        ///// </summary>
        //public CycleCompleteTime { get; set; }

        ///// <summary>
        ///// SCD.17 - Under Temperature.
        ///// </summary>
        //public UnderTemperature { get; set; }

        ///// <summary>
        ///// SCD.18 - Over Temperature.
        ///// </summary>
        //public OverTemperature { get; set; }

        ///// <summary>
        ///// SCD.19 - Abort Cycle.
        ///// </summary>
        //public AbortCycle { get; set; }

        ///// <summary>
        ///// SCD.20 - Alarm.
        ///// </summary>
        //public Alarm { get; set; }

        ///// <summary>
        ///// SCD.21 - Long in Charge Phase.
        ///// </summary>
        //public LongInChargePhase { get; set; }

        ///// <summary>
        ///// SCD.22 - Long in Exhaust Phase.
        ///// </summary>
        //public LongInExhaustPhase { get; set; }

        ///// <summary>
        ///// SCD.23 - Long in Fast Exhaust Phase.
        ///// </summary>
        //public LongInFastExhaustPhase { get; set; }

        ///// <summary>
        ///// SCD.24 - Reset.
        ///// </summary>
        //public Reset { get; set; }

        ///// <summary>
        ///// SCD.25 - Operator - Unload.
        ///// </summary>
        //public OperatorUnload { get; set; }

        ///// <summary>
        ///// SCD.26 - Door Open.
        ///// </summary>
        //public DoorOpen { get; set; }

        ///// <summary>
        ///// SCD.27 - Reading Failure.
        ///// </summary>
        //public ReadingFailure { get; set; }

        ///// <summary>
        ///// SCD.28 - Cycle Type.
        ///// </summary>
        //public CycleType { get; set; }

        ///// <summary>
        ///// SCD.29 - Thermal Rinse Time.
        ///// </summary>
        //public ThermalRinseTime { get; set; }

        ///// <summary>
        ///// SCD.30 - Wash Time.
        ///// </summary>
        //public WashTime { get; set; }

        ///// <summary>
        ///// SCD.31 - Injection Rate.
        ///// </summary>
        //public InjectionRate { get; set; }

        ///// <summary>
        ///// SCD.32 - Procedure Code.
        ///// </summary>
        //public ProcedureCode { get; set; }

        ///// <summary>
        ///// SCD.33 - Patient Identifier List.
        ///// </summary>
        //public PatientIdentifierList { get; set; }

        ///// <summary>
        ///// SCD.34 - Attending Doctor.
        ///// </summary>
        //public AttendingDoctor { get; set; }

        ///// <summary>
        ///// SCD.35 - Dilution Factor.
        ///// </summary>
        //public DilutionFactor { get; set; }

        ///// <summary>
        ///// SCD.36 - Fill Time.
        ///// </summary>
        //public FillTime { get; set; }

        ///// <summary>
        ///// SCD.37 - Inlet Temperature.
        ///// </summary>
        //public InletTemperature { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}"
                                ).TrimEnd('|');
        }
    }
}