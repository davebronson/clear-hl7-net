using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RQ1 - Requisition Detail-1.
    /// </summary>
    public class Rq1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RQ1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// RQ1.1 - Anticipated Price.
        ///// </summary>
        //public AnticipatedPrice { get; set; }

        ///// <summary>
        ///// RQ1.2 - Manufacturer Identifier.
        ///// </summary>
        //public ManufacturerIdentifier { get; set; }

        ///// <summary>
        ///// RQ1.3 - Manufacturer's Catalog.
        ///// </summary>
        //public ManufacturersCatalog { get; set; }

        ///// <summary>
        ///// RQ1.4 - Vendor ID.
        ///// </summary>
        //public VendorId { get; set; }

        ///// <summary>
        ///// RQ1.5 - Vendor Catalog.
        ///// </summary>
        //public VendorCatalog { get; set; }

        ///// <summary>
        ///// RQ1.6 - Taxable.
        ///// </summary>
        //public Taxable { get; set; }

        ///// <summary>
        ///// RQ1.7 - Substitute Allowed.
        ///// </summary>
        //public SubstituteAllowed { get; set; }
        
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