﻿using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
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

        /// <summary>
        /// RXV.1 - Set ID - RXV.
        /// </summary>
        public uint? SetIdRxv { get; set; }

        /// <summary>
        /// RXV.2 - Bolus Type.
        /// <para>Suggested: 0917 Bolus Type -&gt; ClearHl7.Codes.V280.CodeBolusType</para>
        /// </summary>
        public string BolusType { get; set; }

        /// <summary>
        /// RXV.3 - Bolus Dose Amount.
        /// </summary>
        public decimal? BolusDoseAmount { get; set; }

        /// <summary>
        /// RXV.4 - Bolus Dose Amount Units.
        /// </summary>
        public CodedWithExceptions BolusDoseAmountUnits { get; set; }

        /// <summary>
        /// RXV.5 - Bolus Dose Volume.
        /// </summary>
        public decimal? BolusDoseVolume { get; set; }

        /// <summary>
        /// RXV.6 - Bolus Dose Volume Units.
        /// </summary>
        public CodedWithExceptions BolusDoseVolumeUnits { get; set; }

        /// <summary>
        /// RXV.7 - PCA Type.
        /// <para>Suggested: 0918 PCA Type -&gt; ClearHl7.Codes.V280.CodePcaType</para>
        /// </summary>
        public string PcaType { get; set; }

        /// <summary>
        /// RXV.8 - PCA Dose Amount.
        /// </summary>
        public decimal? PcaDoseAmount { get; set; }

        /// <summary>
        /// RXV.9 - PCA Dose Amount Units.
        /// </summary>
        public CodedWithExceptions PcaDoseAmountUnits { get; set; }

        /// <summary>
        /// RXV.10 - PCA Dose Amount Volume.
        /// </summary>
        public decimal? PcaDoseAmountVolume { get; set; }

        /// <summary>
        /// RXV.11 - PCA Dose Amount Volume Units.
        /// </summary>
        public CodedWithExceptions PcaDoseAmountVolumeUnits { get; set; }

        /// <summary>
        /// RXV.12 - Max Dose Amount.
        /// </summary>
        public decimal? MaxDoseAmount { get; set; }

        /// <summary>
        /// RXV.13 - Max Dose Amount Units.
        /// </summary>
        public CodedWithExceptions MaxDoseAmountUnits { get; set; }

        /// <summary>
        /// RXV.14 - Max Dose Amount Volume.
        /// </summary>
        public decimal? MaxDoseAmountVolume { get; set; }

        /// <summary>
        /// RXV.15 - Max Dose Amount Volume Units.
        /// </summary>
        public CodedWithExceptions MaxDoseAmountVolumeUnits { get; set; }

        /// <summary>
        /// RXV.16 - Max Dose per Time.
        /// </summary>
        public CompositeQuantityWithUnits MaxDosePerTime { get; set; }

        /// <summary>
        /// RXV.17 - Lockout Interval.
        /// </summary>
        public CompositeQuantityWithUnits LockoutInterval { get; set; }

        /// <summary>
        /// RXV.18 - Syringe Manufacturer.
        /// </summary>
        public CodedWithExceptions SyringeManufacturer { get; set; }

        /// <summary>
        /// RXV.19 - Syringe Model Number.
        /// </summary>
        public CodedWithExceptions SyringeModelNumber { get; set; }

        /// <summary>
        /// RXV.20 - Syringe Size.
        /// </summary>
        public decimal? SyringeSize { get; set; }

        /// <summary>
        /// RXV.21 - Syringe Size Units.
        /// </summary>
        public CodedWithExceptions SyringeSizeUnits { get; set; }

        /// <summary>
        /// RXV.22 - Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V280.CodeSegmentActionCode</para>
        /// </summary>
        public string ActionCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 23, Configuration.FieldSeparator),
                                Id,
                                SetIdRxv.HasValue ? SetIdRxv.Value.ToString(culture) : null,
                                BolusType,
                                BolusDoseAmount.HasValue ? BolusDoseAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                BolusDoseAmountUnits?.ToDelimitedString(),
                                BolusDoseVolume.HasValue ? BolusDoseVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                BolusDoseVolumeUnits?.ToDelimitedString(),
                                PcaType,
                                PcaDoseAmount.HasValue ? PcaDoseAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                PcaDoseAmountUnits?.ToDelimitedString(),
                                PcaDoseAmountVolume.HasValue ? PcaDoseAmountVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                PcaDoseAmountVolumeUnits?.ToDelimitedString(),
                                MaxDoseAmount.HasValue ? MaxDoseAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                MaxDoseAmountUnits?.ToDelimitedString(),
                                MaxDoseAmountVolume.HasValue ? MaxDoseAmountVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                MaxDoseAmountVolumeUnits?.ToDelimitedString(),
                                MaxDosePerTime?.ToDelimitedString(),
                                LockoutInterval?.ToDelimitedString(),
                                SyringeManufacturer?.ToDelimitedString(),
                                SyringeModelNumber?.ToDelimitedString(),
                                SyringeSize.HasValue ? SyringeSize.Value.ToString(Consts.NumericFormat, culture) : null,
                                SyringeSizeUnits?.ToDelimitedString(),
                                ActionCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}