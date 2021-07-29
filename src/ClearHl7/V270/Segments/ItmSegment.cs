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
    /// HL7 Version 2 Segment ITM - Material Item.
    /// </summary>
    public class ItmSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ITM";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ITM.1 - Item Identifier.
        /// </summary>
        public EntityIdentifier ItemIdentifier { get; set; }

        /// <summary>
        /// ITM.2 - Item Description.
        /// </summary>
        public string ItemDescription { get; set; }

        /// <summary>
        /// ITM.3 - Item Status.
        /// <para>Suggested: 0776 Item Status -&gt; ClearHl7.Codes.V270.CodeItemStatus</para>
        /// </summary>
        public CodedWithExceptions ItemStatus { get; set; }

        /// <summary>
        /// ITM.4 - Item Type.
        /// <para>Suggested: 0778 Item Type -&gt; ClearHl7.Codes.V270.CodeItemType</para>
        /// </summary>
        public CodedWithExceptions ItemType { get; set; }

        /// <summary>
        /// ITM.5 - Item Category.
        /// </summary>
        public CodedWithExceptions ItemCategory { get; set; }

        /// <summary>
        /// ITM.6 - Subject to Expiration Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions SubjectToExpirationIndicator { get; set; }

        /// <summary>
        /// ITM.7 - Manufacturer Identifier.
        /// </summary>
        public EntityIdentifier ManufacturerIdentifier { get; set; }

        /// <summary>
        /// ITM.8 - Manufacturer Name.
        /// </summary>
        public string ManufacturerName { get; set; }

        /// <summary>
        /// ITM.9 - Manufacturer Catalog Number.
        /// </summary>
        public string ManufacturerCatalogNumber { get; set; }

        /// <summary>
        /// ITM.10 - Manufacturer Labeler Identification Code.
        /// </summary>
        public CodedWithExceptions ManufacturerLabelerIdentificationCode { get; set; }

        /// <summary>
        /// ITM.11 - Patient Chargeable Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions PatientChargeableIndicator { get; set; }

        /// <summary>
        /// ITM.12 - Transaction Code.
        /// <para>Suggested: 0132 Transaction Code</para>
        /// </summary>
        public CodedWithExceptions TransactionCode { get; set; }

        /// <summary>
        /// ITM.13 - Transaction amount - unit.
        /// </summary>
        public CompositePrice TransactionAmountUnit { get; set; }

        /// <summary>
        /// ITM.14 - Stocked Item Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions StockedItemIndicator { get; set; }

        /// <summary>
        /// ITM.15 - Supply Risk Codes.
        /// <para>Suggested: 0871 Supply Risk Codes -&gt; ClearHl7.Codes.V270.CodeSupplyRiskCodes</para>
        /// </summary>
        public CodedWithExceptions SupplyRiskCodes { get; set; }

        /// <summary>
        /// ITM.16 - Approving Regulatory Agency.
        /// <para>Suggested: 0790 Approving Regulatory Agency -&gt; ClearHl7.Codes.V270.CodeApprovingRegulatoryAgency</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> ApprovingRegulatoryAgency { get; set; }

        /// <summary>
        /// ITM.17 - Latex Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions LatexIndicator { get; set; }

        /// <summary>
        /// ITM.18 - Ruling Act.
        /// <para>Suggested: 0793 Ruling Act -&gt; ClearHl7.Codes.V270.CodeRulingAct</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> RulingAct { get; set; }

        /// <summary>
        /// ITM.19 - Item Natural Account Code.
        /// <para>Suggested: 0320 Item Natural Account Code</para>
        /// </summary>
        public CodedWithExceptions ItemNaturalAccountCode { get; set; }

        /// <summary>
        /// ITM.20 - Approved To Buy Quantity.
        /// </summary>
        public decimal? ApprovedToBuyQuantity { get; set; }

        /// <summary>
        /// ITM.21 - Approved To Buy Price.
        /// </summary>
        public Money ApprovedToBuyPrice { get; set; }

        /// <summary>
        /// ITM.22 - Taxable Item Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions TaxableItemIndicator { get; set; }

        /// <summary>
        /// ITM.23 - Freight Charge Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions FreightChargeIndicator { get; set; }

        /// <summary>
        /// ITM.24 - Item Set Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions ItemSetIndicator { get; set; }

        /// <summary>
        /// ITM.25 - Item Set Identifier.
        /// </summary>
        public EntityIdentifier ItemSetIdentifier { get; set; }

        /// <summary>
        /// ITM.26 - Track Department Usage Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions TrackDepartmentUsageIndicator { get; set; }

        /// <summary>
        /// ITM.27 - Procedure Code.
        /// <para>Suggested: 0088 Procedure Code</para>
        /// </summary>
        public CodedWithNoExceptions ProcedureCode { get; set; }

        /// <summary>
        /// ITM.28 - Procedure Code Modifier.
        /// <para>Suggested: 0340 Procedure Code Modifier</para>
        /// </summary>
        public IEnumerable<CodedWithNoExceptions> ProcedureCodeModifier { get; set; }

        /// <summary>
        /// ITM.29 - Special Handling Code.
        /// <para>Suggested: 0376 Special Handling Code -&gt; ClearHl7.Codes.V270.CodeSpecialHandlingCode</para>
        /// </summary>
        public CodedWithExceptions SpecialHandlingCode { get; set; }

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

            ItemIdentifier = segments.Length > 1 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(1), false) : null;
            ItemDescription = segments.ElementAtOrDefault(2);
            ItemStatus = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            ItemType = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
            ItemCategory = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(5), false) : null;
            SubjectToExpirationIndicator = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(6), false) : null;
            ManufacturerIdentifier = segments.Length > 7 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(7), false) : null;
            ManufacturerName = segments.ElementAtOrDefault(8);
            ManufacturerCatalogNumber = segments.ElementAtOrDefault(9);
            ManufacturerLabelerIdentificationCode = segments.Length > 10 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(10), false) : null;
            PatientChargeableIndicator = segments.Length > 11 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(11), false) : null;
            TransactionCode = segments.Length > 12 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(12), false) : null;
            TransactionAmountUnit = segments.Length > 13 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(13), false) : null;
            StockedItemIndicator = segments.Length > 14 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(14), false) : null;
            SupplyRiskCodes = segments.Length > 15 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(15), false) : null;
            ApprovingRegulatoryAgency = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            LatexIndicator = segments.Length > 17 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(17), false) : null;
            RulingAct = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ItemNaturalAccountCode = segments.Length > 19 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(19), false) : null;
            ApprovedToBuyQuantity = segments.ElementAtOrDefault(20)?.ToNullableDecimal();
            ApprovedToBuyPrice = segments.Length > 21 ? TypeHelper.Deserialize<Money>(segments.ElementAtOrDefault(21), false) : null;
            TaxableItemIndicator = segments.Length > 22 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(22), false) : null;
            FreightChargeIndicator = segments.Length > 23 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(23), false) : null;
            ItemSetIndicator = segments.Length > 24 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(24), false) : null;
            ItemSetIdentifier = segments.Length > 25 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(25), false) : null;
            TrackDepartmentUsageIndicator = segments.Length > 26 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(26), false) : null;
            ProcedureCode = segments.Length > 27 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(27), false) : null;
            ProcedureCodeModifier = segments.Length > 28 ? segments.ElementAtOrDefault(28).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            SpecialHandlingCode = segments.Length > 29 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(29), false) : null;
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
                                StringHelper.StringFormatSequence(0, 30, Configuration.FieldSeparator),
                                Id,
                                ItemIdentifier?.ToDelimitedString(),
                                ItemDescription,
                                ItemStatus?.ToDelimitedString(),
                                ItemType?.ToDelimitedString(),
                                ItemCategory?.ToDelimitedString(),
                                SubjectToExpirationIndicator?.ToDelimitedString(),
                                ManufacturerIdentifier?.ToDelimitedString(),
                                ManufacturerName,
                                ManufacturerCatalogNumber,
                                ManufacturerLabelerIdentificationCode?.ToDelimitedString(),
                                PatientChargeableIndicator?.ToDelimitedString(),
                                TransactionCode?.ToDelimitedString(),
                                TransactionAmountUnit?.ToDelimitedString(),
                                StockedItemIndicator?.ToDelimitedString(),
                                SupplyRiskCodes?.ToDelimitedString(),
                                ApprovingRegulatoryAgency != null ? string.Join(Configuration.FieldRepeatSeparator, ApprovingRegulatoryAgency.Select(x => x.ToDelimitedString())) : null,
                                LatexIndicator?.ToDelimitedString(),
                                RulingAct != null ? string.Join(Configuration.FieldRepeatSeparator, RulingAct.Select(x => x.ToDelimitedString())) : null,
                                ItemNaturalAccountCode?.ToDelimitedString(),
                                ApprovedToBuyQuantity.HasValue ? ApprovedToBuyQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                ApprovedToBuyPrice?.ToDelimitedString(),
                                TaxableItemIndicator?.ToDelimitedString(),
                                FreightChargeIndicator?.ToDelimitedString(),
                                ItemSetIndicator?.ToDelimitedString(),
                                ItemSetIdentifier?.ToDelimitedString(),
                                TrackDepartmentUsageIndicator?.ToDelimitedString(),
                                ProcedureCode?.ToDelimitedString(),
                                ProcedureCodeModifier != null ? string.Join(Configuration.FieldRepeatSeparator, ProcedureCodeModifier.Select(x => x.ToDelimitedString())) : null,
                                SpecialHandlingCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}