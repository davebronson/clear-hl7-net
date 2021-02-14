using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment INV - Inventory Detail.
    /// </summary>
    public class InvSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "INV";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// INV.1 - Substance Identifier.
        /// <para>Suggested: 0451 Substance Identifier</para>
        /// </summary>
        public CodedWithExceptions SubstanceIdentifier { get; set; }

        /// <summary>
        /// INV.2 - Substance Status.
        /// <para>Suggested: 0383 Substance Status -&gt; ClearHl7.Codes.V281.CodeSubstanceStatus</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SubstanceStatus { get; set; }

        /// <summary>
        /// INV.3 - Substance Type.
        /// <para>Suggested: 0384 Substance Type -&gt; ClearHl7.Codes.V281.CodeSubstanceType</para>
        /// </summary>
        public CodedWithExceptions SubstanceType { get; set; }

        /// <summary>
        /// INV.4 - Inventory Container Identifier.
        /// </summary>
        public CodedWithExceptions InventoryContainerIdentifier { get; set; }

        /// <summary>
        /// INV.5 - Container Carrier Identifier.
        /// </summary>
        public CodedWithExceptions ContainerCarrierIdentifier { get; set; }

        /// <summary>
        /// INV.6 - Position on Carrier.
        /// </summary>
        public CodedWithExceptions PositionOnCarrier { get; set; }

        /// <summary>
        /// INV.7 - Initial Quantity.
        /// </summary>
        public decimal? InitialQuantity { get; set; }

        /// <summary>
        /// INV.8 - Current Quantity.
        /// </summary>
        public decimal? CurrentQuantity { get; set; }

        /// <summary>
        /// INV.9 - Available Quantity.
        /// </summary>
        public decimal? AvailableQuantity { get; set; }

        /// <summary>
        /// INV.10 - Consumption Quantity.
        /// </summary>
        public decimal? ConsumptionQuantity { get; set; }

        /// <summary>
        /// INV.11 - Quantity Units.
        /// </summary>
        public CodedWithExceptions QuantityUnits { get; set; }

        /// <summary>
        /// INV.12 - Expiration Date/Time.
        /// </summary>
        public DateTime? ExpirationDateTime { get; set; }

        /// <summary>
        /// INV.13 - First Used Date/Time.
        /// </summary>
        public DateTime? FirstUsedDateTime { get; set; }

        /// <summary>
        /// INV.14 - On Board Stability Duration.
        /// </summary>
        public string OnBoardStabilityDuration { get; set; }

        /// <summary>
        /// INV.15 - Test/Fluid Identifier(s).
        /// </summary>
        public IEnumerable<CodedWithExceptions> TestFluidIdentifiers { get; set; }

        /// <summary>
        /// INV.16 - Manufacturer Lot Number.
        /// </summary>
        public string ManufacturerLotNumber { get; set; }

        /// <summary>
        /// INV.17 - Manufacturer Identifier.
        /// <para>Suggested: 0385 Manufacturer Identifier</para>
        /// </summary>
        public CodedWithExceptions ManufacturerIdentifier { get; set; }

        /// <summary>
        /// INV.18 - Supplier Identifier.
        /// <para>Suggested: 0386 Supplier Identifier</para>
        /// </summary>
        public CodedWithExceptions SupplierIdentifier { get; set; }

        /// <summary>
        /// INV.19 - On Board Stability Time.
        /// </summary>
        public CompositeQuantityWithUnits OnBoardStabilityTime { get; set; }

        /// <summary>
        /// INV.20 - Target Value.
        /// </summary>
        public CompositeQuantityWithUnits TargetValue { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 21, Configuration.FieldSeparator),
                                Id,
                                SubstanceIdentifier?.ToDelimitedString(),
                                SubstanceStatus != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceStatus.Select(x => x.ToDelimitedString())) : null,
                                SubstanceType?.ToDelimitedString(),
                                InventoryContainerIdentifier?.ToDelimitedString(),
                                ContainerCarrierIdentifier?.ToDelimitedString(),
                                PositionOnCarrier?.ToDelimitedString(),
                                InitialQuantity.HasValue ? InitialQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                CurrentQuantity.HasValue ? CurrentQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                AvailableQuantity.HasValue ? AvailableQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                ConsumptionQuantity.HasValue ? ConsumptionQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                QuantityUnits?.ToDelimitedString(),
                                ExpirationDateTime.HasValue ? ExpirationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                FirstUsedDateTime.HasValue ? FirstUsedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                OnBoardStabilityDuration,
                                TestFluidIdentifiers != null ? string.Join(Configuration.FieldRepeatSeparator, TestFluidIdentifiers.Select(x => x.ToDelimitedString())) : null,
                                ManufacturerLotNumber,
                                ManufacturerIdentifier?.ToDelimitedString(),
                                SupplierIdentifier?.ToDelimitedString(),
                                OnBoardStabilityTime?.ToDelimitedString(),
                                TargetValue?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}