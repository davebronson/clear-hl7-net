using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IIM - Inventory Item Master.
    /// </summary>
    public class IimSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "IIM";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// IIM.1 - Primary Key Value - IIM.
        /// </summary>
        public CodedWithExceptions PrimaryKeyValueIim { get; set; }

        /// <summary>
        /// IIM.2 - Service Item Code.
        /// </summary>
        public CodedWithExceptions ServiceItemCode { get; set; }

        /// <summary>
        /// IIM.3 - Inventory Lot Number.
        /// </summary>
        public string InventoryLotNumber { get; set; }

        /// <summary>
        /// IIM.4 - Inventory Expiration Date.
        /// </summary>
        public DateTime? InventoryExpirationDate { get; set; }

        /// <summary>
        /// IIM.5 - Inventory Manufacturer Name.
        /// </summary>
        public CodedWithExceptions InventoryManufacturerName { get; set; }

        /// <summary>
        /// IIM.6 - Inventory Location.
        /// </summary>
        public CodedWithExceptions InventoryLocation { get; set; }

        /// <summary>
        /// IIM.7 - Inventory Received Date.
        /// </summary>
        public DateTime? InventoryReceivedDate { get; set; }

        /// <summary>
        /// IIM.8 - Inventory Received Quantity.
        /// </summary>
        public decimal? InventoryReceivedQuantity { get; set; }

        /// <summary>
        /// IIM.9 - Inventory Received Quantity Unit.
        /// <para>Suggested: 0818 Package -&gt; ClearHl7.Codes.V270.CodePackage</para>
        /// </summary>
        public CodedWithExceptions InventoryReceivedQuantityUnit { get; set; }

        /// <summary>
        /// IIM.10 - Inventory Received Item Cost.
        /// </summary>
        public Money InventoryReceivedItemCost { get; set; }

        /// <summary>
        /// IIM.11 - Inventory On Hand Date.
        /// </summary>
        public DateTime? InventoryOnHandDate { get; set; }

        /// <summary>
        /// IIM.12 - Inventory On Hand Quantity.
        /// </summary>
        public decimal? InventoryOnHandQuantity { get; set; }

        /// <summary>
        /// IIM.13 - Inventory On Hand Quantity Unit.
        /// <para>Suggested: 0818 Package -&gt; ClearHl7.Codes.V270.CodePackage</para>
        /// </summary>
        public CodedWithExceptions InventoryOnHandQuantityUnit { get; set; }

        /// <summary>
        /// IIM.14 - Procedure Code.
        /// <para>Suggested: 0088 Procedure Code</para>
        /// </summary>
        public CodedWithNoExceptions ProcedureCode { get; set; }

        /// <summary>
        /// IIM.15 - Procedure Code Modifier.
        /// <para>Suggested: 0340 Procedure Code Modifier</para>
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> ProcedureCodeModifier { get; set; }

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

            PrimaryKeyValueIim = segments.Length > 1 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(1), false) : null;
            ServiceItemCode = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            InventoryLotNumber = segments.ElementAtOrDefault(3);
            InventoryExpirationDate = segments.ElementAtOrDefault(4)?.ToNullableDateTime();
            InventoryManufacturerName = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(5), false) : null;
            InventoryLocation = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(6), false) : null;
            InventoryReceivedDate = segments.ElementAtOrDefault(7)?.ToNullableDateTime();
            InventoryReceivedQuantity = segments.ElementAtOrDefault(8)?.ToNullableDecimal();
            InventoryReceivedQuantityUnit = segments.Length > 9 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(9), false) : null;
            InventoryReceivedItemCost = segments.Length > 10 ? TypeHelper.Deserialize<Money>(segments.ElementAtOrDefault(10), false) : null;
            InventoryOnHandDate = segments.ElementAtOrDefault(11)?.ToNullableDateTime();
            InventoryOnHandQuantity = segments.ElementAtOrDefault(12)?.ToNullableDecimal();
            InventoryOnHandQuantityUnit = segments.Length > 13 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(13), false) : null;
            ProcedureCode = segments.Length > 14 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(14), false) : null;
            ProcedureCodeModifier = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
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
                                PrimaryKeyValueIim?.ToDelimitedString(),
                                ServiceItemCode?.ToDelimitedString(),
                                InventoryLotNumber,
                                InventoryExpirationDate.HasValue ? InventoryExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InventoryManufacturerName?.ToDelimitedString(),
                                InventoryLocation?.ToDelimitedString(),
                                InventoryReceivedDate.HasValue ? InventoryReceivedDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InventoryReceivedQuantity.HasValue ? InventoryReceivedQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                InventoryReceivedQuantityUnit?.ToDelimitedString(),
                                InventoryReceivedItemCost?.ToDelimitedString(),
                                InventoryOnHandDate.HasValue ? InventoryOnHandDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InventoryOnHandQuantity.HasValue ? InventoryOnHandQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                InventoryOnHandQuantityUnit?.ToDelimitedString(),
                                ProcedureCode?.ToDelimitedString(),
                                ProcedureCodeModifier != null ? string.Join(Configuration.FieldRepeatSeparator, ProcedureCodeModifier.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}