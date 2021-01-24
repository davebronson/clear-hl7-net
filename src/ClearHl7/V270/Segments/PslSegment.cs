using System;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0559</remarks>
        public CodedWithExceptions ProductServiceLineItemStatus { get; set; }

        /// <summary>
        /// PSL.7 - Product/Service Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0879</remarks>
        public CodedWithExceptions ProductServiceCode { get; set; }

        /// <summary>
        /// PSL.8 - Product/Service Code Modifier.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0880</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0560</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0561</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0562</remarks>
        public CodedWithExceptions ProcessingConsiderationCode { get; set; }

        /// <summary>
        /// PSL.21 - Restricted Disclosure Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0532</remarks>
        public string RestrictedDisclosureIndicator { get; set; }

        /// <summary>
        /// PSL.22 - Related Product/Service Code Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0879</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0881</remarks>
        public CodedWithExceptions RoleExecutingPhysician { get; set; }

        /// <summary>
        /// PSL.32 - Medical Role Executing Physician.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0882</remarks>
        public CodedWithExceptions MedicalRoleExecutingPhysician { get; set; }

        /// <summary>
        /// PSL.33 - Side of body.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0894</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
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