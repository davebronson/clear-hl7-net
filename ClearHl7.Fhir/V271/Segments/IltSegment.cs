using System;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0818</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0818</remarks>
        public CodedWithExceptions InventoryOnHandQuantityUnit { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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