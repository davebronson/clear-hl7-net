using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V281.Types;

namespace ClearHl7.Fhir.V281.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0818</remarks>
        public CodedWithExceptions PackagingUnits { get; set; }

        /// <summary>
        /// PKG.3 - Default Order Unit Of Measure Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0532</remarks>
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}",
                                Id,
                                SetIdPkg.HasValue ? SetIdPkg.Value.ToString(culture) : null,
                                PackagingUnits?.ToDelimitedString(),
                                DefaultOrderUnitOfMeasureIndicator?.ToDelimitedString(),
                                PackageQuantity.HasValue ? PackageQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                Price?.ToDelimitedString(),
                                FutureItemPrice?.ToDelimitedString(),
                                FutureItemPriceEffectiveDate.HasValue ? FutureItemPriceEffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                GlobalTradeItemNumber?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}