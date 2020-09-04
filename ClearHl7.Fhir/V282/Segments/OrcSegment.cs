using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ORC - Common Order.
    /// </summary>
    public class OrcSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ORC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// ORC.1 - Order Control.
        ///// </summary>
        //public OrderControl { get; set; }

        ///// <summary>
        ///// ORC.2 - Placer Order Number.
        ///// </summary>
        //public PlacerOrderNumber { get; set; }

        ///// <summary>
        ///// ORC.3 - Filler Order Number.
        ///// </summary>
        //public FillerOrderNumber { get; set; }

        ///// <summary>
        ///// ORC.4 - Placer Group Number.
        ///// </summary>
        //public PlacerGroupNumber { get; set; }

        ///// <summary>
        ///// ORC.5 - Order Status.
        ///// </summary>
        //public OrderStatus { get; set; }

        ///// <summary>
        ///// ORC.6 - Response Flag.
        ///// </summary>
        //public ResponseFlag { get; set; }

        ///// <summary>
        ///// ORC.7 - Quantity/Timing.
        ///// </summary>
        //public QuantityTiming { get; set; }

        ///// <summary>
        ///// ORC.8 - Parent Order.
        ///// </summary>
        //public ParentOrder { get; set; }

        ///// <summary>
        ///// ORC.9 - Date/Time of Transaction.
        ///// </summary>
        //public DateTimeOfTransaction { get; set; }

        ///// <summary>
        ///// ORC.10 - Entered By.
        ///// </summary>
        //public EnteredBy { get; set; }

        ///// <summary>
        ///// ORC.11 - Verified By.
        ///// </summary>
        //public VerifiedBy { get; set; }

        ///// <summary>
        ///// ORC.12 - Ordering Provider.
        ///// </summary>
        //public OrderingProvider { get; set; }

        ///// <summary>
        ///// ORC.13 - Enterer's Location.
        ///// </summary>
        //public EnterersLocation { get; set; }

        ///// <summary>
        ///// ORC.14 - Call Back Phone Number.
        ///// </summary>
        //public CallBackPhoneNumber { get; set; }

        ///// <summary>
        ///// ORC.15 - Order Effective Date/Time.
        ///// </summary>
        //public OrderEffectiveDateTime { get; set; }

        ///// <summary>
        ///// ORC.16 - Order Control Code Reason.
        ///// </summary>
        //public OrderControlCodeReason { get; set; }

        ///// <summary>
        ///// ORC.17 - Entering Organization.
        ///// </summary>
        //public EnteringOrganization { get; set; }

        ///// <summary>
        ///// ORC.18 - Entering Device.
        ///// </summary>
        //public EnteringDevice { get; set; }

        ///// <summary>
        ///// ORC.19 - Action By.
        ///// </summary>
        //public ActionBy { get; set; }

        ///// <summary>
        ///// ORC.20 - Advanced Beneficiary Notice Code.
        ///// </summary>
        //public AdvancedBeneficiaryNoticeCode { get; set; }

        ///// <summary>
        ///// ORC.21 - Ordering Facility Name.
        ///// </summary>
        //public OrderingFacilityName { get; set; }

        ///// <summary>
        ///// ORC.22 - Ordering Facility Address.
        ///// </summary>
        //public OrderingFacilityAddress { get; set; }

        ///// <summary>
        ///// ORC.23 - Ordering Facility Phone Number.
        ///// </summary>
        //public OrderingFacilityPhoneNumber { get; set; }

        ///// <summary>
        ///// ORC.24 - Ordering Provider Address.
        ///// </summary>
        //public OrderingProviderAddress { get; set; }

        ///// <summary>
        ///// ORC.25 - Order Status Modifier.
        ///// </summary>
        //public OrderStatusModifier { get; set; }

        ///// <summary>
        ///// ORC.26 - Advanced Beneficiary Notice Override Reason.
        ///// </summary>
        //public AdvancedBeneficiaryNoticeOverrideReason { get; set; }

        ///// <summary>
        ///// ORC.27 - Filler's Expected Availability Date/Time.
        ///// </summary>
        //public FillersExpectedAvailabilityDateTime { get; set; }

        ///// <summary>
        ///// ORC.28 - Confidentiality Code.
        ///// </summary>
        //public ConfidentialityCode { get; set; }

        ///// <summary>
        ///// ORC.29 - Order Type.
        ///// </summary>
        //public OrderType { get; set; }

        ///// <summary>
        ///// ORC.30 - Enterer Authorization Mode.
        ///// </summary>
        //public EntererAuthorizationMode { get; set; }

        ///// <summary>
        ///// ORC.31 - Parent Universal Service Identifier.
        ///// </summary>
        //public ParentUniversalServiceIdentifier { get; set; }

        ///// <summary>
        ///// ORC.32 - Advanced Beneficiary Notice Date.
        ///// </summary>
        //public AdvancedBeneficiaryNoticeDate { get; set; }

        ///// <summary>
        ///// ORC.33 - Alternate Placer Order Number.
        ///// </summary>
        //public AlternatePlacerOrderNumber { get; set; }

        ///// <summary>
        ///// ORC.34 - Order Workflow Profile.
        ///// </summary>
        //public OrderWorkflowProfile { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}"
                                ).TrimEnd('|');
        }
    }
}