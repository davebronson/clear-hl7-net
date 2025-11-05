using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PSL - Product Service Line Item.
    /// </summary>
    public class PslSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PslSegment"/> class.
        /// </summary>
        public PslSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PslSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PslSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PSL";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PSL.1 - Provider Product/Service Line Item Number.
        /// </summary>
        public EntityIdentifier ProviderProductServiceLineItemNumber { get; set; }

        /// <summary>
        /// PSL.2 - Payer Product/Service Line Item Number.
        /// </summary>
        public EntityIdentifier PayerProductServiceLineItemNumber { get; set; }

        /// <summary>
        /// PSL.3 - Product/Service Line Item Sequence Number.
        /// </summary>
        public uint? ProductServiceLineItemSequenceNumber { get; set; }

        /// <summary>
        /// PSL.4 - Provider Tracking ID.
        /// </summary>
        public EntityIdentifier ProviderTrackingId { get; set; }

        /// <summary>
        /// PSL.5 - Payer Tracking ID.
        /// </summary>
        public EntityIdentifier PayerTrackingId { get; set; }

        /// <summary>
        /// PSL.6 - Product/Service Line Item Status.
        /// <para>Suggested: 0559 Product/Service Status -&gt; ClearHl7.Codes.V270.CodeProductServiceStatus</para>
        /// </summary>
        public CodedWithExceptions ProductServiceLineItemStatus { get; set; }

        /// <summary>
        /// PSL.7 - Product/Service Code.
        /// <para>Suggested: 0879 Product/Service Code</para>
        /// </summary>
        public CodedWithExceptions ProductServiceCode { get; set; }

        /// <summary>
        /// PSL.8 - Product/Service Code Modifier.
        /// <para>Suggested: 0880 Product/Service Code Modifier</para>
        /// </summary>
        public CodedWithExceptions ProductServiceCodeModifier { get; set; }

        /// <summary>
        /// PSL.9 - Product/Service Code Description.
        /// </summary>
        public string ProductServiceCodeDescription { get; set; }

        /// <summary>
        /// PSL.10 - Product/Service Effective Date.
        /// </summary>
        public DateTime? ProductServiceEffectiveDate { get; set; }

        /// <summary>
        /// PSL.11 - Product/Service Expiration Date.
        /// </summary>
        public DateTime? ProductServiceExpirationDate { get; set; }

        /// <summary>
        /// PSL.12 - Product/Service Quantity.
        /// <para>Suggested: 0560 Quantity Units</para>
        /// </summary>
        public CompositeQuantityWithUnits ProductServiceQuantity { get; set; }

        /// <summary>
        /// PSL.13 - Product/Service Unit Cost.
        /// </summary>
        public CompositePrice ProductServiceUnitCost { get; set; }

        /// <summary>
        /// PSL.14 - Number of Items per Unit.
        /// </summary>
        public decimal? NumberOfItemsPerUnit { get; set; }

        /// <summary>
        /// PSL.15 - Product/Service Gross Amount.
        /// </summary>
        public CompositePrice ProductServiceGrossAmount { get; set; }

        /// <summary>
        /// PSL.16 - Product/Service Billed Amount.
        /// </summary>
        public CompositePrice ProductServiceBilledAmount { get; set; }

        /// <summary>
        /// PSL.17 - Product/Service Clarification Code Type.
        /// <para>Suggested: 0561 Product/Services Clarification Codes -&gt; ClearHl7.Codes.V270.CodeProductServicesClarificationCodes</para>
        /// </summary>
        public CodedWithExceptions ProductServiceClarificationCodeType { get; set; }

        /// <summary>
        /// PSL.18 - Product/Service Clarification Code Value.
        /// </summary>
        public string ProductServiceClarificationCodeValue { get; set; }

        /// <summary>
        /// PSL.19 - Health Document Reference Identifier.
        /// </summary>
        public EntityIdentifier HealthDocumentReferenceIdentifier { get; set; }

        /// <summary>
        /// PSL.20 - Processing Consideration Code.
        /// <para>Suggested: 0562 Processing Consideration Codes -&gt; ClearHl7.Codes.V270.CodeProcessingConsiderationCodes</para>
        /// </summary>
        public CodedWithExceptions ProcessingConsiderationCode { get; set; }

        /// <summary>
        /// PSL.21 - Restricted Disclosure Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public string RestrictedDisclosureIndicator { get; set; }

        /// <summary>
        /// PSL.22 - Related Product/Service Code Indicator.
        /// <para>Suggested: 0879 Product/Service Code</para>
        /// </summary>
        public CodedWithExceptions RelatedProductServiceCodeIndicator { get; set; }

        /// <summary>
        /// PSL.23 - Product/Service Amount for Physician.
        /// </summary>
        public CompositePrice ProductServiceAmountForPhysician { get; set; }

        /// <summary>
        /// PSL.24 - Product/Service Cost Factor.
        /// </summary>
        public decimal? ProductServiceCostFactor { get; set; }

        /// <summary>
        /// PSL.25 - Cost Center.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit CostCenter { get; set; }

        /// <summary>
        /// PSL.26 - Billing Period.
        /// </summary>
        public DateTimeRange BillingPeriod { get; set; }

        /// <summary>
        /// PSL.27 - Days without Billing.
        /// </summary>
        public decimal? DaysWithoutBilling { get; set; }

        /// <summary>
        /// PSL.28 - Session-No.
        /// </summary>
        public decimal? SessionNo { get; set; }

        /// <summary>
        /// PSL.29 - Executing Physician ID.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons ExecutingPhysicianId { get; set; }

        /// <summary>
        /// PSL.30 - Responsible Physician ID.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons ResponsiblePhysicianId { get; set; }

        /// <summary>
        /// PSL.31 - Role Executing Physician.
        /// <para>Suggested: 0881 Role Executing Physician -&gt; ClearHl7.Codes.V270.CodeRoleExecutingPhysician</para>
        /// </summary>
        public CodedWithExceptions RoleExecutingPhysician { get; set; }

        /// <summary>
        /// PSL.32 - Medical Role Executing Physician.
        /// <para>Suggested: 0882 Medical Role Executing Physician -&gt; ClearHl7.Codes.V270.CodeMedicalRoleExecutingPhysician</para>
        /// </summary>
        public CodedWithExceptions MedicalRoleExecutingPhysician { get; set; }

        /// <summary>
        /// PSL.33 - Side of body.
        /// <para>Suggested: 0894 Side Of Body -&gt; ClearHl7.Codes.V270.CodeSideOfBody</para>
        /// </summary>
        public CodedWithExceptions SideOfBody { get; set; }

        /// <summary>
        /// PSL.34 - Number of TP's PP.
        /// </summary>
        public decimal? NumberOfTpsPp { get; set; }

        /// <summary>
        /// PSL.35 - TP-Value PP.
        /// </summary>
        public CompositePrice TpValuePp { get; set; }

        /// <summary>
        /// PSL.36 - Internal Scaling Factor PP.
        /// </summary>
        public decimal? InternalScalingFactorPp { get; set; }

        /// <summary>
        /// PSL.37 - External Scaling Factor PP.
        /// </summary>
        public decimal? ExternalScalingFactorPp { get; set; }

        /// <summary>
        /// PSL.38 - Amount PP.
        /// </summary>
        public CompositePrice AmountPp { get; set; }

        /// <summary>
        /// PSL.39 - Number of TP's Technical Part.
        /// </summary>
        public decimal? NumberOfTpsTechnicalPart { get; set; }

        /// <summary>
        /// PSL.40 - TP-Value Technical Part.
        /// </summary>
        public CompositePrice TpValueTechnicalPart { get; set; }

        /// <summary>
        /// PSL.41 - Internal Scaling Factor Technical Part.
        /// </summary>
        public decimal? InternalScalingFactorTechnicalPart { get; set; }

        /// <summary>
        /// PSL.42 - External Scaling Factor Technical Part.
        /// </summary>
        public decimal? ExternalScalingFactorTechnicalPart { get; set; }

        /// <summary>
        /// PSL.43 - Amount Technical Part.
        /// </summary>
        public CompositePrice AmountTechnicalPart { get; set; }

        /// <summary>
        /// PSL.44 - Total Amount Professional Part + Technical Part.
        /// </summary>
        public CompositePrice TotalAmountProfessionalPartTechnicalPart { get; set; }

        /// <summary>
        /// PSL.45 - VAT-Rate.
        /// </summary>
        public decimal? VatRate { get; set; }

        /// <summary>
        /// PSL.46 - Main-Service.
        /// </summary>
        public string MainService { get; set; }

        /// <summary>
        /// PSL.47 - Validation.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string Validation { get; set; }

        /// <summary>
        /// PSL.48 - Comment.
        /// </summary>
        public string Comment { get; set; }

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
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ProviderProductServiceLineItemNumber = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            PayerProductServiceLineItemNumber = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            ProductServiceLineItemSequenceNumber = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableUInt() : null;
            ProviderTrackingId = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[4], false, seps) : null;
            PayerTrackingId = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[5], false, seps) : null;
            ProductServiceLineItemStatus = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            ProductServiceCode = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[7], false, seps) : null;
            ProductServiceCodeModifier = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[8], false, seps) : null;
            ProductServiceCodeDescription = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            ProductServiceEffectiveDate = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDateTime() : null;
            ProductServiceExpirationDate = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDateTime() : null;
            ProductServiceQuantity = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[12], false, seps) : null;
            ProductServiceUnitCost = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[13], false, seps) : null;
            NumberOfItemsPerUnit = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDecimal() : null;
            ProductServiceGrossAmount = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[15], false, seps) : null;
            ProductServiceBilledAmount = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[16], false, seps) : null;
            ProductServiceClarificationCodeType = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[17], false, seps) : null;
            ProductServiceClarificationCodeValue = segments.Length > 18 && segments[18].Length > 0 ? segments[18] : null;
            HealthDocumentReferenceIdentifier = segments.Length > 19 && segments[19].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[19], false, seps) : null;
            ProcessingConsiderationCode = segments.Length > 20 && segments[20].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[20], false, seps) : null;
            RestrictedDisclosureIndicator = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            RelatedProductServiceCodeIndicator = segments.Length > 22 && segments[22].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[22], false, seps) : null;
            ProductServiceAmountForPhysician = segments.Length > 23 && segments[23].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[23], false, seps) : null;
            ProductServiceCostFactor = segments.Length > 24 && segments[24].Length > 0 ? segments[24].ToNullableDecimal() : null;
            CostCenter = segments.Length > 25 && segments[25].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[25], false, seps) : null;
            BillingPeriod = segments.Length > 26 && segments[26].Length > 0 ? TypeSerializer.Deserialize<DateTimeRange>(segments[26], false, seps) : null;
            DaysWithoutBilling = segments.Length > 27 && segments[27].Length > 0 ? segments[27].ToNullableDecimal() : null;
            SessionNo = segments.Length > 28 && segments[28].Length > 0 ? segments[28].ToNullableDecimal() : null;
            ExecutingPhysicianId = segments.Length > 29 && segments[29].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[29], false, seps) : null;
            ResponsiblePhysicianId = segments.Length > 30 && segments[30].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[30], false, seps) : null;
            RoleExecutingPhysician = segments.Length > 31 && segments[31].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[31], false, seps) : null;
            MedicalRoleExecutingPhysician = segments.Length > 32 && segments[32].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[32], false, seps) : null;
            SideOfBody = segments.Length > 33 && segments[33].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[33], false, seps) : null;
            NumberOfTpsPp = segments.Length > 34 && segments[34].Length > 0 ? segments[34].ToNullableDecimal() : null;
            TpValuePp = segments.Length > 35 && segments[35].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[35], false, seps) : null;
            InternalScalingFactorPp = segments.Length > 36 && segments[36].Length > 0 ? segments[36].ToNullableDecimal() : null;
            ExternalScalingFactorPp = segments.Length > 37 && segments[37].Length > 0 ? segments[37].ToNullableDecimal() : null;
            AmountPp = segments.Length > 38 && segments[38].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[38], false, seps) : null;
            NumberOfTpsTechnicalPart = segments.Length > 39 && segments[39].Length > 0 ? segments[39].ToNullableDecimal() : null;
            TpValueTechnicalPart = segments.Length > 40 && segments[40].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[40], false, seps) : null;
            InternalScalingFactorTechnicalPart = segments.Length > 41 && segments[41].Length > 0 ? segments[41].ToNullableDecimal() : null;
            ExternalScalingFactorTechnicalPart = segments.Length > 42 && segments[42].Length > 0 ? segments[42].ToNullableDecimal() : null;
            AmountTechnicalPart = segments.Length > 43 && segments[43].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[43], false, seps) : null;
            TotalAmountProfessionalPartTechnicalPart = segments.Length > 44 && segments[44].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[44], false, seps) : null;
            VatRate = segments.Length > 45 && segments[45].Length > 0 ? segments[45].ToNullableDecimal() : null;
            MainService = segments.Length > 46 && segments[46].Length > 0 ? segments[46] : null;
            Validation = segments.Length > 47 && segments[47].Length > 0 ? segments[47] : null;
            Comment = segments.Length > 48 && segments[48].Length > 0 ? segments[48] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 49, Configuration.FieldSeparator),
                                Id,
                                ProviderProductServiceLineItemNumber?.ToDelimitedString(),
                                PayerProductServiceLineItemNumber?.ToDelimitedString(),
                                ProductServiceLineItemSequenceNumber.HasValue ? ProductServiceLineItemSequenceNumber.Value.ToString(culture) : null,
                                ProviderTrackingId?.ToDelimitedString(),
                                PayerTrackingId?.ToDelimitedString(),
                                ProductServiceLineItemStatus?.ToDelimitedString(),
                                ProductServiceCode?.ToDelimitedString(),
                                ProductServiceCodeModifier?.ToDelimitedString(),
                                ProductServiceCodeDescription,
                                ProductServiceEffectiveDate?.ToHl7DateTimeString(typeof(PslSegment), nameof(ProductServiceEffectiveDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ProductServiceExpirationDate?.ToHl7DateTimeString(typeof(PslSegment), nameof(ProductServiceExpirationDate), Consts.DateTimeFormatPrecisionSecond, culture),
                                ProductServiceQuantity?.ToDelimitedString(),
                                ProductServiceUnitCost?.ToDelimitedString(),
                                NumberOfItemsPerUnit.HasValue ? NumberOfItemsPerUnit.Value.ToString(Consts.NumericFormat, culture) : null,
                                ProductServiceGrossAmount?.ToDelimitedString(),
                                ProductServiceBilledAmount?.ToDelimitedString(),
                                ProductServiceClarificationCodeType?.ToDelimitedString(),
                                ProductServiceClarificationCodeValue,
                                HealthDocumentReferenceIdentifier?.ToDelimitedString(),
                                ProcessingConsiderationCode?.ToDelimitedString(),
                                RestrictedDisclosureIndicator,
                                RelatedProductServiceCodeIndicator?.ToDelimitedString(),
                                ProductServiceAmountForPhysician?.ToDelimitedString(),
                                ProductServiceCostFactor.HasValue ? ProductServiceCostFactor.Value.ToString(Consts.NumericFormat, culture) : null,
                                CostCenter?.ToDelimitedString(),
                                BillingPeriod?.ToDelimitedString(),
                                DaysWithoutBilling.HasValue ? DaysWithoutBilling.Value.ToString(Consts.NumericFormat, culture) : null,
                                SessionNo.HasValue ? SessionNo.Value.ToString(Consts.NumericFormat, culture) : null,
                                ExecutingPhysicianId?.ToDelimitedString(),
                                ResponsiblePhysicianId?.ToDelimitedString(),
                                RoleExecutingPhysician?.ToDelimitedString(),
                                MedicalRoleExecutingPhysician?.ToDelimitedString(),
                                SideOfBody?.ToDelimitedString(),
                                NumberOfTpsPp.HasValue ? NumberOfTpsPp.Value.ToString(Consts.NumericFormat, culture) : null,
                                TpValuePp?.ToDelimitedString(),
                                InternalScalingFactorPp.HasValue ? InternalScalingFactorPp.Value.ToString(Consts.NumericFormat, culture) : null,
                                ExternalScalingFactorPp.HasValue ? ExternalScalingFactorPp.Value.ToString(Consts.NumericFormat, culture) : null,
                                AmountPp?.ToDelimitedString(),
                                NumberOfTpsTechnicalPart.HasValue ? NumberOfTpsTechnicalPart.Value.ToString(Consts.NumericFormat, culture) : null,
                                TpValueTechnicalPart?.ToDelimitedString(),
                                InternalScalingFactorTechnicalPart.HasValue ? InternalScalingFactorTechnicalPart.Value.ToString(Consts.NumericFormat, culture) : null,
                                ExternalScalingFactorTechnicalPart.HasValue ? ExternalScalingFactorTechnicalPart.Value.ToString(Consts.NumericFormat, culture) : null,
                                AmountTechnicalPart?.ToDelimitedString(),
                                TotalAmountProfessionalPartTechnicalPart?.ToDelimitedString(),
                                VatRate.HasValue ? VatRate.Value.ToString(Consts.NumericFormat, culture) : null,
                                MainService,
                                Validation,
                                Comment
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
