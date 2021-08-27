using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
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
        public CodedElement Country { get; set; }

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
        public CodedElement GenericName { get; set; }

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
        public CodedElement ProductCode { get; set; }

        /// <summary>
        /// PDC.10 - Marketing Basis.
        /// <para>Suggested: 0330 Marketing Basis -&gt; ClearHl7.Codes.V240.CodeMarketingBasis</para>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ManufacturerDistributor = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            Country = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[2], false) : null;
            BrandName = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            DeviceFamilyName = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            GenericName = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[5], false) : null;
            ModelIdentifier = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            CatalogueIdentifier = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            OtherIdentifier = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            ProductCode = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[9], false) : null;
            MarketingBasis = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            MarketingApprovalId = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            LabeledShelfLife = segments.Length > 12 && segments[12].Length > 0 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments[12], false) : null;
            ExpectedShelfLife = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments[13], false) : null;
            DateFirstMarketed = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            DateLastMarketed = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDateTime() : null;
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