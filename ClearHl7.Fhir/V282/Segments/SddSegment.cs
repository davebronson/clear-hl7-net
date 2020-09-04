using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SDD - Sterilization Device Data.
    /// </summary>
    public class SddSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SDD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// SDD.1 - Lot Number.
        ///// </summary>
        //public LotNumber { get; set; }

        ///// <summary>
        ///// SDD.2 - Device Number.
        ///// </summary>
        //public DeviceNumber { get; set; }

        ///// <summary>
        ///// SDD.3 - Device Name.
        ///// </summary>
        //public DeviceName { get; set; }

        ///// <summary>
        ///// SDD.4 - Device Data State.
        ///// </summary>
        //public DeviceDataState { get; set; }

        ///// <summary>
        ///// SDD.5 - Load Status.
        ///// </summary>
        //public LoadStatus { get; set; }

        ///// <summary>
        ///// SDD.6 - Control Code.
        ///// </summary>
        //public ControlCode { get; set; }

        ///// <summary>
        ///// SDD.7 - Operator Name.
        ///// </summary>
        //public OperatorName { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}"
                                ).TrimEnd('|');
        }
    }
}