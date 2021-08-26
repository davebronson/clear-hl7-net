﻿using System;
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

            SetIdIvt = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            InventoryLocationIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[2], false) : null;
            InventoryLocationName = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            SourceLocationIdentifier = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[4], false) : null;
            SourceLocationName = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            ItemStatus = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[6], false) : null;
            BinLocationIdentifier = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            OrderPackaging = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[8], false) : null;
            IssuePackaging = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[9], false) : null;
            DefaultInventoryAssetAccount = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[10], false) : null;
            PatientChargeableIndicator = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[11], false) : null;
            TransactionCode = segments.Length > 12 && segments[12].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[12], false) : null;
            TransactionAmountUnit = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[13], false) : null;
            ItemImportanceCode = segments.Length > 14 && segments[14].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[14], false) : null;
            StockedItemIndicator = segments.Length > 15 && segments[15].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[15], false) : null;
            ConsignmentItemIndicator = segments.Length > 16 && segments[16].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[16], false) : null;
            ReusableItemIndicator = segments.Length > 17 && segments[17].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[17], false) : null;
            ReusableCost = segments.Length > 18 && segments[18].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[18], false) : null;
            SubstituteItemIdentifier = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            LatexFreeSubstituteItemIdentifier = segments.Length > 20 && segments[20].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[20], false) : null;
            RecommendedReorderTheory = segments.Length > 21 && segments[21].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[21], false) : null;
            RecommendedSafetyStockDays = segments.Length > 22 && segments[22].Length > 0 ? segments[22].ToNullableDecimal() : null;
            RecommendedMaximumDaysInventory = segments.Length > 23 && segments[23].Length > 0 ? segments[23].ToNullableDecimal() : null;
            RecommendedOrderPoint = segments.Length > 24 && segments[24].Length > 0 ? segments[24].ToNullableDecimal() : null;
            RecommendedOrderAmount = segments.Length > 25 && segments[25].Length > 0 ? segments[25].ToNullableDecimal() : null;
            OperatingRoomParLevelIndicator = segments.Length > 26 && segments[26].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[26], false) : null;
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