using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IVT - Material Location.
    /// </summary>
    public class IvtSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IvtSegment"/> class.
        /// </summary>
        public IvtSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IvtSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public IvtSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id { get; } = "IVT";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0625 Item Status Codes -&gt; ClearHl7.Codes.V280.CodeItemStatusCodes</para>
        /// </summary>
        public CodedWithExceptions ItemStatus { get; set; }

        /// <summary>
        /// IVT.7 - Bin Location Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> BinLocationIdentifier { get; set; }

        /// <summary>
        /// IVT.8 - Order Packaging.
        /// <para>Suggested: 0818 Package -&gt; ClearHl7.Codes.V280.CodePackage</para>
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
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeExpandedYesNoIndicator</para>
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
        /// <para>Suggested: 0634 Item Importance Codes -&gt; ClearHl7.Codes.V280.CodeItemImportanceCodes</para>
        /// </summary>
        public CodedWithExceptions ItemImportanceCode { get; set; }

        /// <summary>
        /// IVT.15 - Stocked Item Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions StockedItemIndicator { get; set; }

        /// <summary>
        /// IVT.16 - Consignment Item Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions ConsignmentItemIndicator { get; set; }

        /// <summary>
        /// IVT.17 - Reusable Item Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeExpandedYesNoIndicator</para>
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
        /// <para>Suggested: 0642 Reorder Theory Codes -&gt; ClearHl7.Codes.V280.CodeReorderTheoryCodes</para>
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
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions OperatingRoomParLevelIndicator { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdIvt = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            InventoryLocationIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            InventoryLocationName = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            SourceLocationIdentifier = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[4], false, seps) : null;
            SourceLocationName = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            ItemStatus = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            BinLocationIdentifier = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            OrderPackaging = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[8], false, seps) : null;
            IssuePackaging = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[9], false, seps) : null;
            DefaultInventoryAssetAccount = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[10], false, seps) : null;
            PatientChargeableIndicator = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[11], false, seps) : null;
            TransactionCode = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[12], false, seps) : null;
            TransactionAmountUnit = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[13], false, seps) : null;
            ItemImportanceCode = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[14], false, seps) : null;
            StockedItemIndicator = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[15], false, seps) : null;
            ConsignmentItemIndicator = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[16], false, seps) : null;
            ReusableItemIndicator = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[17], false, seps) : null;
            ReusableCost = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[18], false, seps) : null;
            SubstituteItemIdentifier = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<EntityIdentifier>(x, false, seps)) : null;
            LatexFreeSubstituteItemIdentifier = segments.Length > 20 && segments[20].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[20], false, seps) : null;
            RecommendedReorderTheory = segments.Length > 21 && segments[21].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[21], false, seps) : null;
            RecommendedSafetyStockDays = segments.Length > 22 && segments[22].Length > 0 ? segments[22].ToNullableDecimal() : null;
            RecommendedMaximumDaysInventory = segments.Length > 23 && segments[23].Length > 0 ? segments[23].ToNullableDecimal() : null;
            RecommendedOrderPoint = segments.Length > 24 && segments[24].Length > 0 ? segments[24].ToNullableDecimal() : null;
            RecommendedOrderAmount = segments.Length > 25 && segments[25].Length > 0 ? segments[25].ToNullableDecimal() : null;
            OperatingRoomParLevelIndicator = segments.Length > 26 && segments[26].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[26], false, seps) : null;
        }

        /// <inheritdoc/>
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
