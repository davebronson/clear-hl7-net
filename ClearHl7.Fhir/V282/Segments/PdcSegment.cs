using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PDC - Product Detail Country.
    /// </summary>
    public class PdcSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PDC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// PDC.1 - Manufacturer/Distributor.
        ///// </summary>
        //public ManufacturerDistributor { get; set; }

        ///// <summary>
        ///// PDC.2 - Country.
        ///// </summary>
        //public Country { get; set; }

        ///// <summary>
        ///// PDC.3 - Brand Name.
        ///// </summary>
        //public BrandName { get; set; }

        ///// <summary>
        ///// PDC.4 - Device Family Name.
        ///// </summary>
        //public DeviceFamilyName { get; set; }

        ///// <summary>
        ///// PDC.5 - Generic Name.
        ///// </summary>
        //public GenericName { get; set; }

        ///// <summary>
        ///// PDC.6 - Model Identifier.
        ///// </summary>
        //public ModelIdentifier { get; set; }

        ///// <summary>
        ///// PDC.7 - Catalogue Identifier.
        ///// </summary>
        //public CatalogueIdentifier { get; set; }

        ///// <summary>
        ///// PDC.8 - Other Identifier.
        ///// </summary>
        //public OtherIdentifier { get; set; }

        ///// <summary>
        ///// PDC.9 - Product Code.
        ///// </summary>
        //public ProductCode { get; set; }

        ///// <summary>
        ///// PDC.10 - Marketing Basis.
        ///// </summary>
        //public MarketingBasis { get; set; }

        ///// <summary>
        ///// PDC.11 - Marketing Approval ID.
        ///// </summary>
        //public MarketingApprovalId { get; set; }

        ///// <summary>
        ///// PDC.12 - Labeled Shelf Life.
        ///// </summary>
        //public LabeledShelfLife { get; set; }

        ///// <summary>
        ///// PDC.13 - Expected Shelf Life.
        ///// </summary>
        //public ExpectedShelfLife { get; set; }

        ///// <summary>
        ///// PDC.14 - Date First Marketed.
        ///// </summary>
        //public DateFirstMarketed { get; set; }

        ///// <summary>
        ///// PDC.15 - Date Last Marketed.
        ///// </summary>
        //public DateLastMarketed { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}"
                                ).TrimEnd('|');
        }
    }
}