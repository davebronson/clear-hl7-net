using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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

        /// <summary>
        /// PDC.1 - Manufacturer/Distributor.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> ManufacturerDistributor { get; set; }

        /// <summary>
        /// PDC.2 - Country.
        /// </summary>
        public CodedWithExceptions Country { get; set; }

        /// <summary>
        /// PDC.3 - Brand Name.
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// PDC.4 - Device Family Name.
        /// </summary>
        public string DeviceFamilyName { get; set; }

        /// <summary>
        /// PDC.5 - Generic Name.
        /// </summary>
        public CodedWithExceptions GenericName { get; set; }

        /// <summary>
        /// PDC.6 - Model Identifier.
        /// </summary>
        public IEnumerable<string> ModelIdentifier { get; set; }

        /// <summary>
        /// PDC.7 - Catalogue Identifier.
        /// </summary>
        public string CatalogueIdentifier { get; set; }

        /// <summary>
        /// PDC.8 - Other Identifier.
        /// </summary>
        public IEnumerable<string> OtherIdentifier { get; set; }

        /// <summary>
        /// PDC.9 - Product Code.
        /// </summary>
        public CodedWithExceptions ProductCode { get; set; }

        /// <summary>
        /// PDC.10 - Marketing Basis.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0330</remarks>
        public string MarketingBasis { get; set; }

        /// <summary>
        /// PDC.11 - Marketing Approval ID.
        /// </summary>
        public string MarketingApprovalId { get; set; }

        /// <summary>
        /// PDC.12 - Labeled Shelf Life.
        /// </summary>
        public CompositeQuantityWithUnits LabeledShelfLife { get; set; }

        /// <summary>
        /// PDC.13 - Expected Shelf Life.
        /// </summary>
        public CompositeQuantityWithUnits ExpectedShelfLife { get; set; }

        /// <summary>
        /// PDC.14 - Date First Marketed.
        /// </summary>
        public DateTime? DateFirstMarketed { get; set; }

        /// <summary>
        /// PDC.15 - Date Last Marketed.
        /// </summary>
        public DateTime? DateLastMarketed { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 16, Configuration.FieldSeparator),
                                Id,
                                ManufacturerDistributor != null ? string.Join(Configuration.FieldRepeatSeparator, ManufacturerDistributor.Select(x => x.ToDelimitedString())) : null,
                                Country?.ToDelimitedString(),
                                BrandName,
                                DeviceFamilyName,
                                GenericName?.ToDelimitedString(),
                                ModelIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, ModelIdentifier) : null,
                                CatalogueIdentifier,
                                OtherIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, OtherIdentifier) : null,
                                ProductCode?.ToDelimitedString(),
                                MarketingBasis,
                                MarketingApprovalId,
                                LabeledShelfLife?.ToDelimitedString(),
                                ExpectedShelfLife?.ToDelimitedString(),
                                DateFirstMarketed.HasValue ? DateFirstMarketed.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DateLastMarketed.HasValue ? DateLastMarketed.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}