using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PDC - Product Detail Country.
    /// </summary>
    public class PdcSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdcSegment"/> class.
        /// </summary>
        public PdcSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdcSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PdcSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PDC";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0330 Marketing Basis -&gt; ClearHl7.Codes.V282.CodeMarketingBasis</para>
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

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ManufacturerDistributor = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            Country = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            BrandName = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            DeviceFamilyName = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            GenericName = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            ModelIdentifier = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            CatalogueIdentifier = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            OtherIdentifier = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            ProductCode = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[9], false, seps) : null;
            MarketingBasis = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            MarketingApprovalId = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            LabeledShelfLife = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[12], false, seps) : null;
            ExpectedShelfLife = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[13], false, seps) : null;
            DateFirstMarketed = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            DateLastMarketed = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
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
                                DateFirstMarketed?.ToHl7DateTimeString(typeof(PdcSegment), nameof(DateFirstMarketed), Consts.DateTimeFormatPrecisionSecond, culture),
                                DateLastMarketed?.ToHl7DateTimeString(typeof(PdcSegment), nameof(DateLastMarketed), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
