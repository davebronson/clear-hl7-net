﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
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
        /// <para>Suggested: 0818 Package -&gt; ClearHl7.Codes.V271.CodePackage</para>
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
        /// <para>Suggested: 0818 Package -&gt; ClearHl7.Codes.V271.CodePackage</para>
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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