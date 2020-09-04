using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SLT - Sterilization Lot.
    /// </summary>
    public class SltSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SLT";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// SLT.1 - Device Number.
        ///// </summary>
        //public DeviceNumber { get; set; }

        ///// <summary>
        ///// SLT.2 - Device Name.
        ///// </summary>
        //public DeviceName { get; set; }

        ///// <summary>
        ///// SLT.3 - Lot Number.
        ///// </summary>
        //public LotNumber { get; set; }

        ///// <summary>
        ///// SLT.4 - Item Identifier.
        ///// </summary>
        //public ItemIdentifier { get; set; }

        ///// <summary>
        ///// SLT.5 - Bar Code.
        ///// </summary>
        //public BarCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}"
                                ).TrimEnd('|');
        }
    }
}