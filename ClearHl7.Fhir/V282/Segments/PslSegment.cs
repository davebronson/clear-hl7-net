using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// PSL.1 - Provider Product/Service Line Item Number.
        ///// </summary>
        //public ProviderProductServiceLineItemNumber { get; set; }

        ///// <summary>
        ///// PSL.2 - Payer Product/Service Line Item Number.
        ///// </summary>
        //public PayerProductServiceLineItemNumber { get; set; }

        ///// <summary>
        ///// PSL.3 - Product/Service Line Item Sequence Number.
        ///// </summary>
        //public ProductServiceLineItemSequenceNumber { get; set; }

        ///// <summary>
        ///// PSL.4 - Provider Tracking ID.
        ///// </summary>
        //public ProviderTrackingId { get; set; }

        ///// <summary>
        ///// PSL.5 - Payer Tracking ID.
        ///// </summary>
        //public PayerTrackingId { get; set; }

        ///// <summary>
        ///// PSL.6 - Product/Service Line Item Status.
        ///// </summary>
        //public ProductServiceLineItemStatus { get; set; }

        ///// <summary>
        ///// PSL.7 - Product/Service Code.
        ///// </summary>
        //public ProductServiceCode { get; set; }

        ///// <summary>
        ///// PSL.8 - Product/Service Code Modifier.
        ///// </summary>
        //public ProductServiceCodeModifier { get; set; }

        ///// <summary>
        ///// PSL.9 - Product/Service Code Description.
        ///// </summary>
        //public ProductServiceCodeDescription { get; set; }

        ///// <summary>
        ///// PSL.10 - Product/Service Effective Date.
        ///// </summary>
        //public ProductServiceEffectiveDate { get; set; }

        ///// <summary>
        ///// PSL.11 - Product/Service Expiration Date.
        ///// </summary>
        //public ProductServiceExpirationDate { get; set; }

        ///// <summary>
        ///// PSL.12 - Product/Service Quantity.
        ///// </summary>
        //public ProductServiceQuantity { get; set; }

        ///// <summary>
        ///// PSL.13 - Product/Service Unit Cost.
        ///// </summary>
        //public ProductServiceUnitCost { get; set; }

        ///// <summary>
        ///// PSL.14 - Number of Items per Unit.
        ///// </summary>
        //public NumberOfItemsPerUnit { get; set; }

        ///// <summary>
        ///// PSL.15 - Product/Service Gross Amount.
        ///// </summary>
        //public ProductServiceGrossAmount { get; set; }

        ///// <summary>
        ///// PSL.16 - Product/Service Billed Amount.
        ///// </summary>
        //public ProductServiceBilledAmount { get; set; }

        ///// <summary>
        ///// PSL.17 - Product/Service Clarification Code Type.
        ///// </summary>
        //public ProductServiceClarificationCodeType { get; set; }

        ///// <summary>
        ///// PSL.18 - Product/Service Clarification Code Value.
        ///// </summary>
        //public ProductServiceClarificationCodeValue { get; set; }

        ///// <summary>
        ///// PSL.19 - Health Document Reference Identifier.
        ///// </summary>
        //public HealthDocumentReferenceIdentifier { get; set; }

        ///// <summary>
        ///// PSL.20 - Processing Consideration Code.
        ///// </summary>
        //public ProcessingConsiderationCode { get; set; }

        ///// <summary>
        ///// PSL.21 - Restricted Disclosure Indicator.
        ///// </summary>
        //public RestrictedDisclosureIndicator { get; set; }

        ///// <summary>
        ///// PSL.22 - Related Product/Service Code Indicator.
        ///// </summary>
        //public RelatedProductServiceCodeIndicator { get; set; }

        ///// <summary>
        ///// PSL.23 - Product/Service Amount for Physician.
        ///// </summary>
        //public ProductServiceAmountForPhysician { get; set; }

        ///// <summary>
        ///// PSL.24 - Product/Service Cost Factor.
        ///// </summary>
        //public ProductServiceCostFactor { get; set; }

        ///// <summary>
        ///// PSL.25 - Cost Center.
        ///// </summary>
        //public CostCenter { get; set; }

        ///// <summary>
        ///// PSL.26 - Billing Period.
        ///// </summary>
        //public BillingPeriod { get; set; }

        ///// <summary>
        ///// PSL.27 - Days without Billing.
        ///// </summary>
        //public DaysWithoutBilling { get; set; }

        ///// <summary>
        ///// PSL.28 - Session-No.
        ///// </summary>
        //public SessionNo { get; set; }

        ///// <summary>
        ///// PSL.29 - Executing Physician ID.
        ///// </summary>
        //public ExecutingPhysicianId { get; set; }

        ///// <summary>
        ///// PSL.30 - Responsible Physician ID.
        ///// </summary>
        //public ResponsiblePhysicianId { get; set; }

        ///// <summary>
        ///// PSL.31 - Role Executing Physician.
        ///// </summary>
        //public RoleExecutingPhysician { get; set; }

        ///// <summary>
        ///// PSL.32 - Medical Role Executing Physician.
        ///// </summary>
        //public MedicalRoleExecutingPhysician { get; set; }

        ///// <summary>
        ///// PSL.33 - Side of body.
        ///// </summary>
        //public SideOfBody { get; set; }

        ///// <summary>
        ///// PSL.34 - Number of TP's PP.
        ///// </summary>
        //public NumberOfTpsPp { get; set; }

        ///// <summary>
        ///// PSL.35 - TP-Value PP.
        ///// </summary>
        //public TpValuePp { get; set; }

        ///// <summary>
        ///// PSL.36 - Internal Scaling Factor PP.
        ///// </summary>
        //public InternalScalingFactorPp { get; set; }

        ///// <summary>
        ///// PSL.37 - External Scaling Factor PP.
        ///// </summary>
        //public ExternalScalingFactorPp { get; set; }

        ///// <summary>
        ///// PSL.38 - Amount PP.
        ///// </summary>
        //public AmountPp { get; set; }

        ///// <summary>
        ///// PSL.39 - Number of TP's Technical Part.
        ///// </summary>
        //public NumberOfTpsTechnicalPart { get; set; }

        ///// <summary>
        ///// PSL.40 - TP-Value Technical Part.
        ///// </summary>
        //public TpValueTechnicalPart { get; set; }

        ///// <summary>
        ///// PSL.41 - Internal Scaling Factor Technical Part.
        ///// </summary>
        //public InternalScalingFactorTechnicalPart { get; set; }

        ///// <summary>
        ///// PSL.42 - External Scaling Factor Technical Part.
        ///// </summary>
        //public ExternalScalingFactorTechnicalPart { get; set; }

        ///// <summary>
        ///// PSL.43 - Amount Technical Part.
        ///// </summary>
        //public AmountTechnicalPart { get; set; }

        ///// <summary>
        ///// PSL.44 - Total Amount Professional Part + Technical Part.
        ///// </summary>
        //public TotalAmountProfessionalPartTechnicalPart { get; set; }

        ///// <summary>
        ///// PSL.45 - VAT-Rate.
        ///// </summary>
        //public VatRate { get; set; }

        ///// <summary>
        ///// PSL.46 - Main-Service.
        ///// </summary>
        //public MainService { get; set; }

        ///// <summary>
        ///// PSL.47 - Validation.
        ///// </summary>
        //public Validation { get; set; }

        ///// <summary>
        ///// PSL.48 - Comment.
        ///// </summary>
        //public Comment { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}|{38}|{39}|{40}|{41}|{42}|{43}|{44}|{45}|{46}|{47}|{48}"
                                ).TrimEnd('|');
        }
    }
}