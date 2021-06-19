using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0625 Item Status Codes -&gt; ClearHl7.Codes.V290.CodeItemStatusCodes</para>
        /// </summary>
        public CodedWithExceptions ItemStatus { get; set; }

        /// <summary>
        /// IVT.7 - Bin Location Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> BinLocationIdentifier { get; set; }

        /// <summary>
        /// IVT.8 - Order Packaging.
        /// <para>Suggested: 0818 Order Packaging</para>
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
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
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
        /// <para>Suggested: 0634 Item Importance Codes -&gt; ClearHl7.Codes.V290.CodeItemImportanceCodes</para>
        /// </summary>
        public CodedWithExceptions ItemImportanceCode { get; set; }

        /// <summary>
        /// IVT.15 - Stocked Item Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions StockedItemIndicator { get; set; }

        /// <summary>
        /// IVT.16 - Consignment Item Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions ConsignmentItemIndicator { get; set; }

        /// <summary>
        /// IVT.17 - Reusable Item Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
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
        /// <para>Suggested: 0642 Reorder Theory Codes -&gt; ClearHl7.Codes.V290.CodeReorderTheoryCodes</para>
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
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions OperatingRoomParLevelIndicator { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public IvtSegment FromDelimitedString(string delimitedString)
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

            SetIdIvt = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            InventoryLocationIdentifier = segments.Length > 2 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            InventoryLocationName = segments.ElementAtOrDefault(3);
            SourceLocationIdentifier = segments.Length > 4 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            SourceLocationName = segments.ElementAtOrDefault(5);
            ItemStatus = segments.Length > 6 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            BinLocationIdentifier = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => new EntityIdentifier().FromDelimitedString(x)) : null;
            OrderPackaging = segments.Length > 8 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            IssuePackaging = segments.Length > 9 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(9)) : null;
            DefaultInventoryAssetAccount = segments.Length > 10 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(10)) : null;
            PatientChargeableIndicator = segments.Length > 11 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            TransactionCode = segments.Length > 12 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(12)) : null;
            TransactionAmountUnit = segments.Length > 13 ? new CompositePrice().FromDelimitedString(segments.ElementAtOrDefault(13)) : null;
            ItemImportanceCode = segments.Length > 14 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(14)) : null;
            StockedItemIndicator = segments.Length > 15 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(15)) : null;
            ConsignmentItemIndicator = segments.Length > 16 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(16)) : null;
            ReusableItemIndicator = segments.Length > 17 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(17)) : null;
            ReusableCost = segments.Length > 18 ? new CompositePrice().FromDelimitedString(segments.ElementAtOrDefault(18)) : null;
            SubstituteItemIdentifier = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator).Select(x => new EntityIdentifier().FromDelimitedString(x)) : null;
            LatexFreeSubstituteItemIdentifier = segments.Length > 20 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(20)) : null;
            RecommendedReorderTheory = segments.Length > 21 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(21)) : null;
            RecommendedSafetyStockDays = segments.ElementAtOrDefault(22)?.ToNullableDecimal();
            RecommendedMaximumDaysInventory = segments.ElementAtOrDefault(23)?.ToNullableDecimal();
            RecommendedOrderPoint = segments.ElementAtOrDefault(24)?.ToNullableDecimal();
            RecommendedOrderAmount = segments.ElementAtOrDefault(25)?.ToNullableDecimal();
            OperatingRoomParLevelIndicator = segments.Length > 26 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(26)) : null;
            
            return this;
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