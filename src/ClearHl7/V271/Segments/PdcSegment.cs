using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
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
        /// <para>Suggested: 0330 Marketing Basis -&gt; ClearHl7.Codes.V271.CodeMarketingBasis</para>
        /// </summary>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ManufacturerDistributor = segments.Length > 1 ? segments.ElementAtOrDefault(1).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            Country = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            BrandName = segments.ElementAtOrDefault(3);
            DeviceFamilyName = segments.ElementAtOrDefault(4);
            GenericName = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(5), false) : null;
            ModelIdentifier = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator) : null;
            CatalogueIdentifier = segments.ElementAtOrDefault(7);
            OtherIdentifier = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator) : null;
            ProductCode = segments.Length > 9 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(9), false) : null;
            MarketingBasis = segments.ElementAtOrDefault(10);
            MarketingApprovalId = segments.ElementAtOrDefault(11);
            LabeledShelfLife = segments.Length > 12 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(12), false) : null;
            ExpectedShelfLife = segments.Length > 13 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(13), false) : null;
            DateFirstMarketed = segments.ElementAtOrDefault(14)?.ToNullableDateTime();
            DateLastMarketed = segments.ElementAtOrDefault(15)?.ToNullableDateTime();
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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