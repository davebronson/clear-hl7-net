using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IVT - Material Location.
    /// </summary>
    public class IvtSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "IVT";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// IVT.1 - Set Id - IVT.
        /// </summary>
        public uint? SetIdIvt { get; set; }

        /// <summary>
        /// IVT.2 - Inventory Location Identifier.
        /// </summary>
        public EntityIdentifier InventoryLocationIdentifier { get; set; }

        /// <summary>
        /// IVT.3 - Inventory Location Name.
        /// </summary>
        public string InventoryLocationName { get; set; }

        /// <summary>
        /// IVT.4 - Source Location Identifier.
        /// </summary>
        public EntityIdentifier SourceLocationIdentifier { get; set; }

        /// <summary>
        /// IVT.5 - Source Location Name.
        /// </summary>
        public string SourceLocationName { get; set; }

        /// <summary>
        /// IVT.6 - Item Status.
        /// <para>Suggested: 0625 Item Status Codes -&gt; ClearHl7.Codes.V281.CodeItemStatusCodes</para>
        /// </summary>
        public CodedWithExceptions ItemStatus { get; set; }

        /// <summary>
        /// IVT.7 - Bin Location Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> BinLocationIdentifier { get; set; }

        /// <summary>
        /// IVT.8 - Order Packaging.
        /// <para>Suggested: 0818 Package -&gt; ClearHl7.Codes.V281.CodePackage</para>
        /// </summary>
        public CodedWithExceptions OrderPackaging { get; set; }

        /// <summary>
        /// IVT.9 - Issue Packaging.
        /// </summary>
        public CodedWithExceptions IssuePackaging { get; set; }

        /// <summary>
        /// IVT.10 - Default Inventory Asset Account.
        /// </summary>
        public EntityIdentifier DefaultInventoryAssetAccount { get; set; }

        /// <summary>
        /// IVT.11 - Patient Chargeable Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions PatientChargeableIndicator { get; set; }

        /// <summary>
        /// IVT.12 - Transaction Code.
        /// <para>Suggested: 0132 Transaction Code</para>
        /// </summary>
        public CodedWithExceptions TransactionCode { get; set; }

        /// <summary>
        /// IVT.13 - Transaction amount - unit.
        /// </summary>
        public CompositePrice TransactionAmountUnit { get; set; }

        /// <summary>
        /// IVT.14 - Item Importance Code.
        /// <para>Suggested: 0634 Item Importance Codes -&gt; ClearHl7.Codes.V281.CodeItemImportanceCodes</para>
        /// </summary>
        public CodedWithExceptions ItemImportanceCode { get; set; }

        /// <summary>
        /// IVT.15 - Stocked Item Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions StockedItemIndicator { get; set; }

        /// <summary>
        /// IVT.16 - Consignment Item Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions ConsignmentItemIndicator { get; set; }

        /// <summary>
        /// IVT.17 - Reusable Item Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions ReusableItemIndicator { get; set; }

        /// <summary>
        /// IVT.18 - Reusable Cost.
        /// </summary>
        public CompositePrice ReusableCost { get; set; }

        /// <summary>
        /// IVT.19 - Substitute Item Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> SubstituteItemIdentifier { get; set; }

        /// <summary>
        /// IVT.20 - Latex-Free Substitute Item Identifier.
        /// </summary>
        public EntityIdentifier LatexFreeSubstituteItemIdentifier { get; set; }

        /// <summary>
        /// IVT.21 - Recommended Reorder Theory.
        /// <para>Suggested: 0642 Reorder Theory Codes -&gt; ClearHl7.Codes.V281.CodeReorderTheoryCodes</para>
        /// </summary>
        public CodedWithExceptions RecommendedReorderTheory { get; set; }

        /// <summary>
        /// IVT.22 - Recommended Safety Stock Days.
        /// </summary>
        public decimal? RecommendedSafetyStockDays { get; set; }

        /// <summary>
        /// IVT.23 - Recommended Maximum Days Inventory.
        /// </summary>
        public decimal? RecommendedMaximumDaysInventory { get; set; }

        /// <summary>
        /// IVT.24 - Recommended Order Point.
        /// </summary>
        public decimal? RecommendedOrderPoint { get; set; }

        /// <summary>
        /// IVT.25 - Recommended Order Amount.
        /// </summary>
        public decimal? RecommendedOrderAmount { get; set; }

        /// <summary>
        /// IVT.26 - Operating Room Par Level Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions OperatingRoomParLevelIndicator { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 27, Configuration.FieldSeparator),
                                Id,
                                SetIdIvt.HasValue ? SetIdIvt.Value.ToString(culture) : null,
                                InventoryLocationIdentifier?.ToDelimitedString(),
                                InventoryLocationName,
                                SourceLocationIdentifier?.ToDelimitedString(),
                                SourceLocationName,
                                ItemStatus?.ToDelimitedString(),
                                BinLocationIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, BinLocationIdentifier.Select(x => x.ToDelimitedString())) : null,
                                OrderPackaging?.ToDelimitedString(),
                                IssuePackaging?.ToDelimitedString(),
                                DefaultInventoryAssetAccount?.ToDelimitedString(),
                                PatientChargeableIndicator?.ToDelimitedString(),
                                TransactionCode?.ToDelimitedString(),
                                TransactionAmountUnit?.ToDelimitedString(),
                                ItemImportanceCode?.ToDelimitedString(),
                                StockedItemIndicator?.ToDelimitedString(),
                                ConsignmentItemIndicator?.ToDelimitedString(),
                                ReusableItemIndicator?.ToDelimitedString(),
                                ReusableCost?.ToDelimitedString(),
                                SubstituteItemIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, SubstituteItemIdentifier.Select(x => x.ToDelimitedString())) : null,
                                LatexFreeSubstituteItemIdentifier?.ToDelimitedString(),
                                RecommendedReorderTheory?.ToDelimitedString(),
                                RecommendedSafetyStockDays.HasValue ? RecommendedSafetyStockDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                RecommendedMaximumDaysInventory.HasValue ? RecommendedMaximumDaysInventory.Value.ToString(Consts.NumericFormat, culture) : null,
                                RecommendedOrderPoint.HasValue ? RecommendedOrderPoint.Value.ToString(Consts.NumericFormat, culture) : null,
                                RecommendedOrderAmount.HasValue ? RecommendedOrderAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                OperatingRoomParLevelIndicator?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}