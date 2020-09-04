using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment VND - Purchasing Vendor.
    /// </summary>
    public class VndSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "VND";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// VND.1 - Set Id - VND.
        ///// </summary>
        //public SetIdVnd { get; set; }

        ///// <summary>
        ///// VND.2 - Vendor Identifier.
        ///// </summary>
        //public VendorIdentifier { get; set; }

        ///// <summary>
        ///// VND.3 - Vendor Name.
        ///// </summary>
        //public VendorName { get; set; }

        ///// <summary>
        ///// VND.4 - Vendor Catalog Number.
        ///// </summary>
        //public VendorCatalogNumber { get; set; }

        ///// <summary>
        ///// VND.5 - Primary Vendor Indicator.
        ///// </summary>
        //public PrimaryVendorIndicator { get; set; }
        
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