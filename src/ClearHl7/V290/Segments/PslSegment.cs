using System;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PSL - Product Service Line Item.
    /// </summary>
    public class PslSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PSL";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        /// <para>Suggested: 0559 Product/Service Status -&gt; ClearHl7.Codes.V290.CodeProductServiceStatus</para>
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
        /// <para>Suggested: 0561 Product/Services Clarification Codes -&gt; ClearHl7.Codes.V290.CodeProductServicesClarificationCodes</para>
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
        /// <para>Suggested: 0562 Processing Consideration Codes -&gt; ClearHl7.Codes.V290.CodeProcessingConsiderationCodes</para>
        /// </summary>
        public CodedWithExceptions ProcessingConsiderationCode { get; set; }

        /// <summary>
        /// PSL.21 - Restricted Disclosure Indicator.
        /// <para>Suggested: 0532 Expanded Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeExpandedYesNoIndicator</para>
        /// </summary>
        public string RestrictedDisclosureIndicator { get; set; }

        /// <summary>
        /// PSL.22 - Related Product/Service Code Indicator.
        /// <para>Suggested: 0879 Related Product/Service Code Indicator</para>
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
        /// <para>Suggested: 0881 Role Executing Physician -&gt; ClearHl7.Codes.V290.CodeRoleExecutingPhysician</para>
        /// </summary>
        public CodedWithExceptions RoleExecutingPhysician { get; set; }

        /// <summary>
        /// PSL.32 - Medical Role Executing Physician.
        /// <para>Suggested: 0882 Medical Role Executing Physician -&gt; ClearHl7.Codes.V290.CodeMedicalRoleExecutingPhysician</para>
        /// </summary>
        public CodedWithExceptions MedicalRoleExecutingPhysician { get; set; }

        /// <summary>
        /// PSL.33 - Side of body.
        /// <para>Suggested: 0894 Side Of Body -&gt; ClearHl7.Codes.V290.CodeSideOfBody</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string Validation { get; set; }

        /// <summary>
        /// PSL.48 - Comment.
        /// </summary>
        public string Comment { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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
                                ProductServiceEffectiveDate.HasValue ? ProductServiceEffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProductServiceExpirationDate.HasValue ? ProductServiceExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
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