﻿using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V290.Types;

namespace ClearHl7.Fhir.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXC - Pharmacy Treatment Component Order.
    /// </summary>
    public class RxcSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RXC.1 - RX Component Type.
        /// <para>Suggested: 0166 RX Component Type -&gt; ClearHl7.Fhir.Codes.V290.CodeRXComponentType</para>
        /// </summary>
        public string RxComponentType { get; set; }

        /// <summary>
        /// RXC.2 - Component Code.
        /// <para>Suggested: 0697 Component Code</para>
        /// </summary>
        public CodedWithExceptions ComponentCode { get; set; }

        /// <summary>
        /// RXC.3 - Component Amount.
        /// </summary>
        public decimal? ComponentAmount { get; set; }

        /// <summary>
        /// RXC.4 - Component Units.
        /// <para>Suggested: 0698 Component Units</para>
        /// </summary>
        public CodedWithExceptions ComponentUnits { get; set; }

        /// <summary>
        /// RXC.5 - Component Strength.
        /// </summary>
        public decimal? ComponentStrength { get; set; }

        /// <summary>
        /// RXC.6 - Component Strength Units.
        /// <para>Suggested: 0699 Component Strength Units</para>
        /// </summary>
        public CodedWithExceptions ComponentStrengthUnits { get; set; }

        /// <summary>
        /// RXC.7 - Supplementary Code.
        /// <para>Suggested: 0700 Supplementary Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SupplementaryCode { get; set; }

        /// <summary>
        /// RXC.8 - Component Drug Strength Volume.
        /// </summary>
        public decimal? ComponentDrugStrengthVolume { get; set; }

        /// <summary>
        /// RXC.9 - Component Drug Strength Volume Units.
        /// <para>Suggested: 0701 Component Drug Strength Volume Units</para>
        /// </summary>
        public CodedWithExceptions ComponentDrugStrengthVolumeUnits { get; set; }

        /// <summary>
        /// RXC.10 - Dispense Amount.
        /// </summary>
        public decimal? DispenseAmount { get; set; }

        /// <summary>
        /// RXC.11 - Dispense Units.
        /// <para>Suggested: 0703 Dispense Units</para>
        /// </summary>
        public CodedWithExceptions DispenseUnits { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 12, Configuration.FieldSeparator),
                                Id,
                                RxComponentType,
                                ComponentCode?.ToDelimitedString(),
                                ComponentAmount.HasValue ? ComponentAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                ComponentUnits?.ToDelimitedString(),
                                ComponentStrength.HasValue ? ComponentStrength.Value.ToString(Consts.NumericFormat, culture) : null,
                                ComponentStrengthUnits?.ToDelimitedString(),
                                SupplementaryCode != null ? string.Join(Configuration.FieldRepeatSeparator, SupplementaryCode.Select(x => x.ToDelimitedString())) : null,
                                ComponentDrugStrengthVolume.HasValue ? ComponentDrugStrengthVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                ComponentDrugStrengthVolumeUnits?.ToDelimitedString(),
                                DispenseAmount.HasValue ? DispenseAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseUnits?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}