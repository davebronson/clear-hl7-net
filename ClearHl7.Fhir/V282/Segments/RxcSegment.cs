using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// RXC.1 - RX Component Type.
        ///// </summary>
        //public RxComponentType { get; set; }

        ///// <summary>
        ///// RXC.2 - Component Code.
        ///// </summary>
        //public ComponentCode { get; set; }

        ///// <summary>
        ///// RXC.3 - Component Amount.
        ///// </summary>
        //public ComponentAmount { get; set; }

        ///// <summary>
        ///// RXC.4 - Component Units.
        ///// </summary>
        //public ComponentUnits { get; set; }

        ///// <summary>
        ///// RXC.5 - Component Strength.
        ///// </summary>
        //public ComponentStrength { get; set; }

        ///// <summary>
        ///// RXC.6 - Component Strength Units.
        ///// </summary>
        //public ComponentStrengthUnits { get; set; }

        ///// <summary>
        ///// RXC.7 - Supplementary Code.
        ///// </summary>
        //public SupplementaryCode { get; set; }

        ///// <summary>
        ///// RXC.8 - Component Drug Strength Volume.
        ///// </summary>
        //public ComponentDrugStrengthVolume { get; set; }

        ///// <summary>
        ///// RXC.9 - Component Drug Strength Volume Units.
        ///// </summary>
        //public ComponentDrugStrengthVolumeUnits { get; set; }

        ///// <summary>
        ///// RXC.10 - Dispense Amount.
        ///// </summary>
        //public DispenseAmount { get; set; }

        ///// <summary>
        ///// RXC.11 - Dispense Units.
        ///// </summary>
        //public DispenseUnits { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}"
                                ).TrimEnd('|');
        }
    }
}