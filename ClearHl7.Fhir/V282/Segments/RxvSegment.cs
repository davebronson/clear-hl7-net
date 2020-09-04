using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXV - Pharmacy Treatment Infusion.
    /// </summary>
    public class RxvSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXV";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// RXV.1 - Set ID - RXV.
        ///// </summary>
        //public SetIdRxv { get; set; }

        ///// <summary>
        ///// RXV.2 - Bolus Type.
        ///// </summary>
        //public BolusType { get; set; }

        ///// <summary>
        ///// RXV.3 - Bolus Dose Amount.
        ///// </summary>
        //public BolusDoseAmount { get; set; }

        ///// <summary>
        ///// RXV.4 - Bolus Dose Amount Units.
        ///// </summary>
        //public BolusDoseAmountUnits { get; set; }

        ///// <summary>
        ///// RXV.5 - Bolus Dose Volume.
        ///// </summary>
        //public BolusDoseVolume { get; set; }

        ///// <summary>
        ///// RXV.6 - Bolus Dose Volume Units.
        ///// </summary>
        //public BolusDoseVolumeUnits { get; set; }

        ///// <summary>
        ///// RXV.7 - PCA Type.
        ///// </summary>
        //public PcaType { get; set; }

        ///// <summary>
        ///// RXV.8 - PCA Dose Amount.
        ///// </summary>
        //public PcaDoseAmount { get; set; }

        ///// <summary>
        ///// RXV.9 - PCA Dose Amount Units.
        ///// </summary>
        //public PcaDoseAmountUnits { get; set; }

        ///// <summary>
        ///// RXV.10 - PCA Dose Amount Volume.
        ///// </summary>
        //public PcaDoseAmountVolume { get; set; }

        ///// <summary>
        ///// RXV.11 - PCA Dose Amount Volume Units.
        ///// </summary>
        //public PcaDoseAmountVolumeUnits { get; set; }

        ///// <summary>
        ///// RXV.12 - Max Dose Amount.
        ///// </summary>
        //public MaxDoseAmount { get; set; }

        ///// <summary>
        ///// RXV.13 - Max Dose Amount Units.
        ///// </summary>
        //public MaxDoseAmountUnits { get; set; }

        ///// <summary>
        ///// RXV.14 - Max Dose Amount Volume.
        ///// </summary>
        //public MaxDoseAmountVolume { get; set; }

        ///// <summary>
        ///// RXV.15 - Max Dose Amount Volume Units.
        ///// </summary>
        //public MaxDoseAmountVolumeUnits { get; set; }

        ///// <summary>
        ///// RXV.16 - Max Dose per Time.
        ///// </summary>
        //public MaxDosePerTime { get; set; }

        ///// <summary>
        ///// RXV.17 - Lockout Interval.
        ///// </summary>
        //public LockoutInterval { get; set; }

        ///// <summary>
        ///// RXV.18 - Syringe Manufacturer.
        ///// </summary>
        //public SyringeManufacturer { get; set; }

        ///// <summary>
        ///// RXV.19 - Syringe Model Number.
        ///// </summary>
        //public SyringeModelNumber { get; set; }

        ///// <summary>
        ///// RXV.20 - Syringe Size.
        ///// </summary>
        //public SyringeSize { get; set; }

        ///// <summary>
        ///// RXV.21 - Syringe Size Units.
        ///// </summary>
        //public SyringeSizeUnits { get; set; }

        ///// <summary>
        ///// RXV.22 - Action Code.
        ///// </summary>
        //public ActionCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}"
                                ).TrimEnd('|');
        }
    }
}