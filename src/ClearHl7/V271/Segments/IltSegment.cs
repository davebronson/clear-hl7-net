using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ILT - Material Lot.
    /// </summary>
    public class IltSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ILT";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        /// <para>Suggested: 0818 Package -&gt; ClearHl7.Codes.V271.CodePackage</para>
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
        /// <para>Suggested: 0818 Package -&gt; ClearHl7.Codes.V271.CodePackage</para>
        /// </summary>
        public CodedWithExceptions InventoryOnHandQuantityUnit { get; set; }

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

            SetIdIlt = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            InventoryLotNumber = segments.ElementAtOrDefault(2);
            InventoryExpirationDate = segments.ElementAtOrDefault(3)?.ToNullableDateTime();
            InventoryReceivedDate = segments.ElementAtOrDefault(4)?.ToNullableDateTime();
            InventoryReceivedQuantity = segments.ElementAtOrDefault(5)?.ToNullableDecimal();
            InventoryReceivedQuantityUnit = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(6), false) : null;
            InventoryReceivedItemCost = segments.Length > 7 ? TypeHelper.Deserialize<Money>(segments.ElementAtOrDefault(7), false) : null;
            InventoryOnHandDate = segments.ElementAtOrDefault(8)?.ToNullableDateTime();
            InventoryOnHandQuantity = segments.ElementAtOrDefault(9)?.ToNullableDecimal();
            InventoryOnHandQuantityUnit = segments.Length > 10 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(10), false) : null;
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
                                StringHelper.StringFormatSequence(0, 11, Configuration.FieldSeparator),
                                Id,
                                SetIdIlt.HasValue ? SetIdIlt.Value.ToString(culture) : null,
                                InventoryLotNumber,
                                InventoryExpirationDate.HasValue ? InventoryExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InventoryReceivedDate.HasValue ? InventoryReceivedDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InventoryReceivedQuantity.HasValue ? InventoryReceivedQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                InventoryReceivedQuantityUnit?.ToDelimitedString(),
                                InventoryReceivedItemCost?.ToDelimitedString(),
                                InventoryOnHandDate.HasValue ? InventoryOnHandDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InventoryOnHandQuantity.HasValue ? InventoryOnHandQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                InventoryOnHandQuantityUnit?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}