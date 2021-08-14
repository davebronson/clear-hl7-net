using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PKG - Item Packaging.
    /// </summary>
    public class PkgSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PKG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PKG.1 - Set Id - PKG.
        /// </summary>
        public uint? SetIdPkg { get; set; }

        /// <summary>
        /// PKG.2 - Packaging Units.
        /// <para>Suggested: 0818 Package -&gt; ClearHl7.Codes.V290.CodePackage</para>
        /// </summary>
        public CodedWithExceptions PackagingUnits { get; set; }

        /// <summary>
        /// PKG.3 - Default Order Unit Of Measure Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions DefaultOrderUnitOfMeasureIndicator { get; set; }

        /// <summary>
        /// PKG.4 - Package Quantity.
        /// </summary>
        public decimal? PackageQuantity { get; set; }

        /// <summary>
        /// PKG.5 - Price.
        /// </summary>
        public CompositePrice Price { get; set; }

        /// <summary>
        /// PKG.6 - Future Item Price.
        /// </summary>
        public CompositePrice FutureItemPrice { get; set; }

        /// <summary>
        /// PKG.7 - Future Item Price Effective Date.
        /// </summary>
        public DateTime? FutureItemPriceEffectiveDate { get; set; }

        /// <summary>
        /// PKG.8 - Global Trade Item Number.
        /// </summary>
        public CodedWithExceptions GlobalTradeItemNumber { get; set; }

        /// <summary>
        /// PKG.9 - Contract Price.
        /// </summary>
        public Money ContractPrice { get; set; }

        /// <summary>
        /// PKG.10 - Quantity Of Each
        /// </summary>
        public decimal? QuantityOfEach { get; set; }

        /// <summary>
        /// PKG.11 - Vendor Catalog Number.
        /// </summary>
        public EntityIdentifier VendorCatalogNumber { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdPkg = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            PackagingUnits = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            DefaultOrderUnitOfMeasureIndicator = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(3), false) : null;
            PackageQuantity = segments.ElementAtOrDefault(4)?.ToNullableDecimal();
            Price = segments.Length > 5 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(5), false) : null;
            FutureItemPrice = segments.Length > 6 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(6), false) : null;
            FutureItemPriceEffectiveDate = segments.ElementAtOrDefault(7)?.ToNullableDateTime();
            GlobalTradeItemNumber = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(8), false) : null;
            ContractPrice = segments.Length > 9 ? TypeHelper.Deserialize<Money>(segments.ElementAtOrDefault(9), false) : null;
            QuantityOfEach = segments.ElementAtOrDefault(10)?.ToNullableDecimal();
            VendorCatalogNumber = segments.Length > 11 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(11), false) : null;
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
                                StringHelper.StringFormatSequence(0, 12, Configuration.FieldSeparator),
                                Id,
                                SetIdPkg.HasValue ? SetIdPkg.Value.ToString(culture) : null,
                                PackagingUnits?.ToDelimitedString(),
                                DefaultOrderUnitOfMeasureIndicator?.ToDelimitedString(),
                                PackageQuantity.HasValue ? PackageQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                Price?.ToDelimitedString(),
                                FutureItemPrice?.ToDelimitedString(),
                                FutureItemPriceEffectiveDate.HasValue ? FutureItemPriceEffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                GlobalTradeItemNumber?.ToDelimitedString(),
                                ContractPrice?.ToDelimitedString(),
                                QuantityOfEach.HasValue ? QuantityOfEach.Value.ToString(Consts.NumericFormat, culture) : null,
                                VendorCatalogNumber?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}