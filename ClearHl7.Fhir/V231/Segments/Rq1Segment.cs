using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V231.Types;

namespace ClearHl7.Fhir.V231.Segments
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

        /// <summary>
        /// RQ1.1 - Anticipated Price.
        /// </summary>
        public string AnticipatedPrice { get; set; }

        /// <summary>
        /// RQ1.2 - Manufacturer Identifier.
        /// </summary>
        public CodedElement ManufacturerIdentifier { get; set; }

        /// <summary>
        /// RQ1.3 - Manufacturer's Catalog.
        /// </summary>
        public string ManufacturersCatalog { get; set; }

        /// <summary>
        /// RQ1.4 - Vendor ID.
        /// </summary>
        public CodedElement VendorId { get; set; }

        /// <summary>
        /// RQ1.5 - Vendor Catalog.
        /// </summary>
        public string VendorCatalog { get; set; }

        /// <summary>
        /// RQ1.6 - Taxable.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string Taxable { get; set; }

        /// <summary>
        /// RQ1.7 - Substitute Allowed.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string SubstituteAllowed { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                AnticipatedPrice,
                                ManufacturerIdentifier?.ToDelimitedString(),
                                ManufacturersCatalog,
                                VendorId?.ToDelimitedString(),
                                VendorCatalog,
                                Taxable,
                                SubstituteAllowed
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}