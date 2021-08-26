using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
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
        /// <para>Suggested: 0818 Package -&gt; ClearHl7.Codes.V281.CodePackage</para>
        /// </summary>
        public CodedWithExceptions PackagingUnits { get; set; }

        /// <summary>
        /// PKG.3 - Default Order Unit Of Measure Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
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
        internal void FromDelimitedString(string delimitedString, Separators separators)
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

            SetIdPkg = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            PackagingUnits = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[2], false) : null;
            DefaultOrderUnitOfMeasureIndicator = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[3], false) : null;
            PackageQuantity = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            Price = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[5], false) : null;
            FutureItemPrice = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[6], false) : null;
            FutureItemPriceEffectiveDate = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            GlobalTradeItemNumber = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[8], false) : null;
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
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                SetIdPkg.HasValue ? SetIdPkg.Value.ToString(culture) : null,
                                PackagingUnits?.ToDelimitedString(),
                                DefaultOrderUnitOfMeasureIndicator?.ToDelimitedString(),
                                PackageQuantity.HasValue ? PackageQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                Price?.ToDelimitedString(),
                                FutureItemPrice?.ToDelimitedString(),
                                FutureItemPriceEffectiveDate.HasValue ? FutureItemPriceEffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                GlobalTradeItemNumber?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}