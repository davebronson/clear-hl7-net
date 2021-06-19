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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public ItmSegment FromDelimitedString(string delimitedString)
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

            ItemIdentifier = segments.Length > 1 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(1)) : null;
            ItemDescription = segments.ElementAtOrDefault(2);
            ItemStatus = segments.Length > 3 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            ItemType = segments.Length > 4 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            ItemCategory = segments.Length > 5 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            SubjectToExpirationIndicator = segments.Length > 6 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            ManufacturerIdentifier = segments.Length > 7 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(7)) : null;
            ManufacturerName = segments.ElementAtOrDefault(8);
            ManufacturerCatalogNumber = segments.ElementAtOrDefault(9);
            ManufacturerLabelerIdentificationCode = segments.Length > 10 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(10)) : null;
            PatientChargeableIndicator = segments.Length > 11 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            TransactionCode = segments.Length > 12 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(12)) : null;
            TransactionAmountUnit = segments.Length > 13 ? new CompositePrice().FromDelimitedString(segments.ElementAtOrDefault(13)) : null;
            StockedItemIndicator = segments.Length > 14 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(14)) : null;
            SupplyRiskCodes = segments.Length > 15 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(15)) : null;
            ApprovingRegulatoryAgency = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator).Select(x => new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(x)) : null;
            LatexIndicator = segments.Length > 17 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(17)) : null;
            RulingAct = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            ItemNaturalAccountCode = segments.Length > 19 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(19)) : null;
            ApprovedToBuyQuantity = segments.ElementAtOrDefault(20)?.ToNullableDecimal();
            ApprovedToBuyPrice = segments.Length > 21 ? new Money().FromDelimitedString(segments.ElementAtOrDefault(21)) : null;
            TaxableItemIndicator = segments.Length > 22 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(22)) : null;
            FreightChargeIndicator = segments.Length > 23 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(23)) : null;
            ItemSetIndicator = segments.Length > 24 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(24)) : null;
            ItemSetIdentifier = segments.Length > 25 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(25)) : null;
            TrackDepartmentUsageIndicator = segments.Length > 26 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(26)) : null;
            ProcedureCode = segments.Length > 27 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(27)) : null;
            ProcedureCodeModifier = segments.Length > 28 ? segments.ElementAtOrDefault(28).Split(separator).Select(x => new CodedWithNoExceptions().FromDelimitedString(x)) : null;
            SpecialHandlingCode = segments.Length > 29 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(29)) : null;
            HazardousIndicator = segments.Length > 30 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(30)) : null;
            SterileIndicator = segments.Length > 31 ? new CodedWithNoExceptions().FromDelimitedString(segments.ElementAtOrDefault(31)) : null;
            MaterialDataSafetySheetNumber = segments.Length > 32 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(32)) : null;
            UnitedNationsStandardProductsAndServicesCode = segments.Length > 33 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(33)) : null;
            ContractDate = segments.Length > 34 ? new DateTimeRange().FromDelimitedString(segments.ElementAtOrDefault(34)) : null;
            ManufacturerContactName = segments.Length > 35 ? new ExtendedPersonName().FromDelimitedString(segments.ElementAtOrDefault(35)) : null;
            ManufacturerContactInformation = segments.Length > 36 ? new ExtendedTelecommunicationNumber().FromDelimitedString(segments.ElementAtOrDefault(36)) : null;
            ClassOfTrade = segments.ElementAtOrDefault(37);
            FieldLevelEventCode = segments.ElementAtOrDefault(38);
            
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