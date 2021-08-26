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
        /// <para>Suggested: 0776 Item Status -&gt; ClearHl7.Codes.V290.CodeItemStatus</para>
        /// </summary>
        public CodedWithExceptions ItemStatus { get; set; }

        /// <summary>
        /// ITM.4 - Item Type.
        /// <para>Suggested: 0778 Item Type -&gt; ClearHl7.Codes.V290.CodeItemType</para>
        /// </summary>
        public CodedWithExceptions ItemType { get; set; }

        /// <summary>
        /// ITM.5 - Item Category.
        /// </summary>
        public CodedWithExceptions ItemCategory { get; set; }

        /// <summary>
        /// ITM.6 - Subject to Expiration Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
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
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
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
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions StockedItemIndicator { get; set; }

        /// <summary>
        /// ITM.15 - Supply Risk Codes.
        /// <para>Suggested: 0871 Supply Risk Codes -&gt; ClearHl7.Codes.V290.CodeSupplyRiskCodes</para>
        /// </summary>
        public CodedWithExceptions SupplyRiskCodes { get; set; }

        /// <summary>
        /// ITM.16 - Approving Regulatory Agency.
        /// <para>Suggested: 0790 Approving Regulatory Agency -&gt; ClearHl7.Codes.V290.CodeApprovingRegulatoryAgency</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> ApprovingRegulatoryAgency { get; set; }

        /// <summary>
        /// ITM.17 - Latex Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions LatexIndicator { get; set; }

        /// <summary>
        /// ITM.18 - Ruling Act.
        /// <para>Suggested: 0793 Ruling Act -&gt; ClearHl7.Codes.V290.CodeRulingAct</para>
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
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions TaxableItemIndicator { get; set; }

        /// <summary>
        /// ITM.23 - Freight Charge Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions FreightChargeIndicator { get; set; }

        /// <summary>
        /// ITM.24 - Item Set Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions ItemSetIndicator { get; set; }

        /// <summary>
        /// ITM.25 - Item Set Identifier.
        /// </summary>
        public EntityIdentifier ItemSetIdentifier { get; set; }

        /// <summary>
        /// ITM.26 - Track Department Usage Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
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
        /// <para>Suggested: 0376 Special Handling Code -&gt; ClearHl7.Codes.V290.CodeSpecialHandlingCode</para>
        /// </summary>
        public CodedWithExceptions SpecialHandlingCode { get; set; }

        /// <summary>
        /// ITM.30 - Hazardous Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions HazardousIndicator { get; set; }

        /// <summary>
        /// ITM.31 - Sterile Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public CodedWithNoExceptions SterileIndicator { get; set; }

        /// <summary>
        /// ITM.32 - Material Data Safety Sheet Number.
        /// </summary>
        public EntityIdentifier MaterialDataSafetySheetNumber { get; set; }

        /// <summary>
        /// ITM.33 - United Nations Standard Products and Services Code (UNSPSC).
        /// <para>Suggested: 0396 Coding System</para>
        /// </summary>
        public CodedWithExceptions UnitedNationsStandardProductsAndServicesCode { get; set; }

        /// <summary>
        /// ITM.34 - Contract Date.
        /// </summary>
        public DateTimeRange ContractDate { get; set; }

        /// <summary>
        /// ITM.35 - Manufacturer Contact Name.
        /// </summary>
        public ExtendedPersonName ManufacturerContactName { get; set; }

        /// <summary>
        /// ITM.36 - Manufacturer Contact Information.
        /// </summary>
        public ExtendedTelecommunicationNumber ManufacturerContactInformation { get; set; }

        /// <summary>
        /// ITM.37 - Class of Trade.
        /// </summary>
        public string ClassOfTrade { get; set; }

        /// <summary>
        /// ITM.38 - Field Level Event Code.
        /// <para>Suggested: 0180 Masterfile Action Code -&gt; ClearHl7.Codes.V290.CodeMasterfileActionCode</para>
        /// </summary>
        public string FieldLevelEventCode { get; set; }

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

            ItemIdentifier = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[1], false) : null;
            ItemDescription = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            ItemStatus = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[3], false) : null;
            ItemType = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[4], false) : null;
            ItemCategory = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[5], false) : null;
            SubjectToExpirationIndicator = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[6], false) : null;
            ManufacturerIdentifier = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[7], false) : null;
            ManufacturerName = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            ManufacturerCatalogNumber = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            ManufacturerLabelerIdentificationCode = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[10], false) : null;
            PatientChargeableIndicator = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[11], false) : null;
            TransactionCode = segments.Length > 12 && segments[12].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[12], false) : null;
            TransactionAmountUnit = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[13], false) : null;
            StockedItemIndicator = segments.Length > 14 && segments[14].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[14], false) : null;
            SupplyRiskCodes = segments.Length > 15 && segments[15].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[15], false) : null;
            ApprovingRegulatoryAgency = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            LatexIndicator = segments.Length > 17 && segments[17].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[17], false) : null;
            RulingAct = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ItemNaturalAccountCode = segments.Length > 19 && segments[19].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[19], false) : null;
            ApprovedToBuyQuantity = segments.Length > 20 && segments[20].Length > 0 ? segments[20].ToNullableDecimal() : null;
            ApprovedToBuyPrice = segments.Length > 21 && segments[21].Length > 0 ? TypeHelper.Deserialize<Money>(segments[21], false) : null;
            TaxableItemIndicator = segments.Length > 22 && segments[22].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[22], false) : null;
            FreightChargeIndicator = segments.Length > 23 && segments[23].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[23], false) : null;
            ItemSetIndicator = segments.Length > 24 && segments[24].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[24], false) : null;
            ItemSetIdentifier = segments.Length > 25 && segments[25].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[25], false) : null;
            TrackDepartmentUsageIndicator = segments.Length > 26 && segments[26].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[26], false) : null;
            ProcedureCode = segments.Length > 27 && segments[27].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[27], false) : null;
            ProcedureCodeModifier = segments.Length > 28 && segments[28].Length > 0 ? segments[28].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithNoExceptions>(x, false)) : null;
            SpecialHandlingCode = segments.Length > 29 && segments[29].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[29], false) : null;
            HazardousIndicator = segments.Length > 30 && segments[30].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[30], false) : null;
            SterileIndicator = segments.Length > 31 && segments[31].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[31], false) : null;
            MaterialDataSafetySheetNumber = segments.Length > 32 && segments[32].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[32], false) : null;
            UnitedNationsStandardProductsAndServicesCode = segments.Length > 33 && segments[33].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[33], false) : null;
            ContractDate = segments.Length > 34 && segments[34].Length > 0 ? TypeHelper.Deserialize<DateTimeRange>(segments[34], false) : null;
            ManufacturerContactName = segments.Length > 35 && segments[35].Length > 0 ? TypeHelper.Deserialize<ExtendedPersonName>(segments[35], false) : null;
            ManufacturerContactInformation = segments.Length > 36 && segments[36].Length > 0 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments[36], false) : null;
            ClassOfTrade = segments.Length > 37 && segments[37].Length > 0 ? segments[37] : null;
            FieldLevelEventCode = segments.Length > 38 && segments[38].Length > 0 ? segments[38] : null;
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
                                StringHelper.StringFormatSequence(0, 39, Configuration.FieldSeparator),
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
                                SpecialHandlingCode?.ToDelimitedString(),
                                HazardousIndicator?.ToDelimitedString(),
                                SterileIndicator?.ToDelimitedString(),
                                MaterialDataSafetySheetNumber?.ToDelimitedString(),
                                UnitedNationsStandardProductsAndServicesCode?.ToDelimitedString(),
                                ContractDate?.ToDelimitedString(),
                                ManufacturerContactName?.ToDelimitedString(),
                                ManufacturerContactInformation?.ToDelimitedString(),
                                ClassOfTrade,
                                FieldLevelEventCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}