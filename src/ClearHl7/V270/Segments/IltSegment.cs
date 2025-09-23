using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ILT - Material Lot.
    /// </summary>
    public class IltSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IltSegment"/> class.
        /// </summary>
        public IltSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IltSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public IltSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "ILT";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// ILT.1 - Set Id - ILT.
        /// </summary>
        public uint? SetIdIlt { get; set; }

        /// <summary>
        /// ILT.2 - Inventory Lot Number.
        /// </summary>
        public string InventoryLotNumber { get; set; }

        /// <summary>
        /// ILT.3 - Inventory Expiration Date.
        /// </summary>
        public DateTime? InventoryExpirationDate { get; set; }

        /// <summary>
        /// ILT.4 - Inventory Received Date.
        /// </summary>
        public DateTime? InventoryReceivedDate { get; set; }

        /// <summary>
        /// ILT.5 - Inventory Received Quantity.
        /// </summary>
        public decimal? InventoryReceivedQuantity { get; set; }

        /// <summary>
        /// ILT.6 - Inventory Received Quantity Unit.
        /// <para>Suggested: 0818 Package -&gt; ClearHl7.Codes.V270.CodePackage</para>
        /// </summary>
        public CodedWithExceptions InventoryReceivedQuantityUnit { get; set; }

        /// <summary>
        /// ILT.7 - Inventory Received Item Cost.
        /// </summary>
        public Money InventoryReceivedItemCost { get; set; }

        /// <summary>
        /// ILT.8 - Inventory On Hand Date.
        /// </summary>
        public DateTime? InventoryOnHandDate { get; set; }

        /// <summary>
        /// ILT.9 - Inventory On Hand Quantity.
        /// </summary>
        public decimal? InventoryOnHandQuantity { get; set; }

        /// <summary>
        /// ILT.10 - Inventory On Hand Quantity Unit.
        /// <para>Suggested: 0818 Package -&gt; ClearHl7.Codes.V270.CodePackage</para>
        /// </summary>
        public CodedWithExceptions InventoryOnHandQuantityUnit { get; set; }

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

            SetIdIlt = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            InventoryLotNumber = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            InventoryExpirationDate = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            InventoryReceivedDate = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            InventoryReceivedQuantity = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            InventoryReceivedQuantityUnit = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            InventoryReceivedItemCost = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[7], false, seps) : null;
            InventoryOnHandDate = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            InventoryOnHandQuantity = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDecimal() : null;
            InventoryOnHandQuantityUnit = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[10], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 11, Configuration.FieldSeparator),
                                Id,
                                SetIdIlt.HasValue ? SetIdIlt.Value.ToString(culture) : null,
                                InventoryLotNumber,
                                InventoryExpirationDate.ToHl7DateTimeString(typeof(IltSegment), nameof(InventoryExpirationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                InventoryReceivedDate.ToHl7DateTimeString(typeof(IltSegment), nameof(InventoryReceivedDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                InventoryReceivedQuantity.HasValue ? InventoryReceivedQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                InventoryReceivedQuantityUnit?.ToDelimitedString(),
                                InventoryReceivedItemCost?.ToDelimitedString(),
                                InventoryOnHandDate.ToHl7DateTimeString(typeof(IltSegment), nameof(InventoryOnHandDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                InventoryOnHandQuantity.HasValue ? InventoryOnHandQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                InventoryOnHandQuantityUnit?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
