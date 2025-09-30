using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IIM - Inventory Item Master.
    /// </summary>
    public class IimSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IimSegment"/> class.
        /// </summary>
        public IimSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IimSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public IimSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "IIM";

        /// <inheritdoc/>
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

            PrimaryKeyValueIim = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            ServiceItemCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            InventoryLotNumber = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            InventoryExpirationDate = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            InventoryManufacturerName = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            InventoryLocation = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            InventoryReceivedDate = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            InventoryReceivedQuantity = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            InventoryReceivedQuantityUnit = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[9], false, seps) : null;
            InventoryReceivedItemCost = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<Money>(segments[10], false, seps) : null;
            InventoryOnHandDate = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDateTime() : null;
            InventoryOnHandQuantity = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDecimal() : null;
            InventoryOnHandQuantityUnit = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[13], false, seps) : null;
            ProcedureCode = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[14], false, seps) : null;
            ProcedureCodeModifier = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithNoExceptions>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
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
                                InventoryExpirationDate?.ToHl7DateTimeString(typeof(IimSegment), nameof(InventoryExpirationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                InventoryManufacturerName?.ToDelimitedString(),
                                InventoryLocation?.ToDelimitedString(),
                                InventoryReceivedDate?.ToHl7DateTimeString(typeof(IimSegment), nameof(InventoryReceivedDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                InventoryReceivedQuantity.HasValue ? InventoryReceivedQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                InventoryReceivedQuantityUnit?.ToDelimitedString(),
                                InventoryReceivedItemCost?.ToDelimitedString(),
                                InventoryOnHandDate?.ToHl7DateTimeString(typeof(IimSegment), nameof(InventoryOnHandDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                InventoryOnHandQuantity.HasValue ? InventoryOnHandQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                InventoryOnHandQuantityUnit?.ToDelimitedString(),
                                ProcedureCode?.ToDelimitedString(),
                                ProcedureCodeModifier != null ? string.Join(Configuration.FieldRepeatSeparator, ProcedureCodeModifier.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
