using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PV2 - Patient Visit - Additional Information.
    /// </summary>
    public class Pv2Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PV2";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// PV2.1 - Prior Pending Location.
        ///// </summary>
        //public PriorPendingLocation { get; set; }

        ///// <summary>
        ///// PV2.2 - Accommodation Code.
        ///// </summary>
        //public AccommodationCode { get; set; }

        ///// <summary>
        ///// PV2.3 - Admit Reason.
        ///// </summary>
        //public AdmitReason { get; set; }

        ///// <summary>
        ///// PV2.4 - Transfer Reason.
        ///// </summary>
        //public TransferReason { get; set; }

        ///// <summary>
        ///// PV2.5 - Patient Valuables.
        ///// </summary>
        //public PatientValuables { get; set; }

        ///// <summary>
        ///// PV2.6 - Patient Valuables Location.
        ///// </summary>
        //public PatientValuablesLocation { get; set; }

        ///// <summary>
        ///// PV2.7 - Visit User Code.
        ///// </summary>
        //public VisitUserCode { get; set; }

        ///// <summary>
        ///// PV2.8 - Expected Admit Date/Time.
        ///// </summary>
        //public ExpectedAdmitDateTime { get; set; }

        ///// <summary>
        ///// PV2.9 - Expected Discharge Date/Time.
        ///// </summary>
        //public ExpectedDischargeDateTime { get; set; }

        ///// <summary>
        ///// PV2.10 - Estimated Length of Inpatient Stay.
        ///// </summary>
        //public EstimatedLengthOfInpatientStay { get; set; }

        ///// <summary>
        ///// PV2.11 - Actual Length of Inpatient Stay.
        ///// </summary>
        //public ActualLengthOfInpatientStay { get; set; }

        ///// <summary>
        ///// PV2.12 - Visit Description.
        ///// </summary>
        //public VisitDescription { get; set; }

        ///// <summary>
        ///// PV2.13 - Referral Source Code.
        ///// </summary>
        //public ReferralSourceCode { get; set; }

        ///// <summary>
        ///// PV2.14 - Previous Service Date.
        ///// </summary>
        //public PreviousServiceDate { get; set; }

        ///// <summary>
        ///// PV2.15 - Employment Illness Related Indicator.
        ///// </summary>
        //public EmploymentIllnessRelatedIndicator { get; set; }

        ///// <summary>
        ///// PV2.16 - Purge Status Code.
        ///// </summary>
        //public PurgeStatusCode { get; set; }

        ///// <summary>
        ///// PV2.17 - Purge Status Date.
        ///// </summary>
        //public PurgeStatusDate { get; set; }

        ///// <summary>
        ///// PV2.18 - Special Program Code.
        ///// </summary>
        //public SpecialProgramCode { get; set; }

        ///// <summary>
        ///// PV2.19 - Retention Indicator.
        ///// </summary>
        //public RetentionIndicator { get; set; }

        ///// <summary>
        ///// PV2.20 - Expected Number of Insurance Plans.
        ///// </summary>
        //public ExpectedNumberOfInsurancePlans { get; set; }

        ///// <summary>
        ///// PV2.21 - Visit Publicity Code.
        ///// </summary>
        //public VisitPublicityCode { get; set; }

        ///// <summary>
        ///// PV2.22 - Visit Protection Indicator.
        ///// </summary>
        //public VisitProtectionIndicator { get; set; }

        ///// <summary>
        ///// PV2.23 - Clinic Organization Name.
        ///// </summary>
        //public ClinicOrganizationName { get; set; }

        ///// <summary>
        ///// PV2.24 - Patient Status Code.
        ///// </summary>
        //public PatientStatusCode { get; set; }

        ///// <summary>
        ///// PV2.25 - Visit Priority Code.
        ///// </summary>
        //public VisitPriorityCode { get; set; }

        ///// <summary>
        ///// PV2.26 - Previous Treatment Date.
        ///// </summary>
        //public PreviousTreatmentDate { get; set; }

        ///// <summary>
        ///// PV2.27 - Expected Discharge Disposition.
        ///// </summary>
        //public ExpectedDischargeDisposition { get; set; }

        ///// <summary>
        ///// PV2.28 - Signature on File Date.
        ///// </summary>
        //public SignatureOnFileDate { get; set; }

        ///// <summary>
        ///// PV2.29 - First Similar Illness Date.
        ///// </summary>
        //public FirstSimilarIllnessDate { get; set; }

        ///// <summary>
        ///// PV2.30 - Patient Charge Adjustment Code.
        ///// </summary>
        //public PatientChargeAdjustmentCode { get; set; }

        ///// <summary>
        ///// PV2.31 - Recurring Service Code.
        ///// </summary>
        //public RecurringServiceCode { get; set; }

        ///// <summary>
        ///// PV2.32 - Billing Media Code.
        ///// </summary>
        //public BillingMediaCode { get; set; }

        ///// <summary>
        ///// PV2.33 - Expected Surgery Date and Time.
        ///// </summary>
        //public ExpectedSurgeryDateAndTime { get; set; }

        ///// <summary>
        ///// PV2.34 - Military Partnership Code.
        ///// </summary>
        //public MilitaryPartnershipCode { get; set; }

        ///// <summary>
        ///// PV2.35 - Military Non-Availability Code.
        ///// </summary>
        //public MilitaryNonAvailabilityCode { get; set; }

        ///// <summary>
        ///// PV2.36 - Newborn Baby Indicator.
        ///// </summary>
        //public NewbornBabyIndicator { get; set; }

        ///// <summary>
        ///// PV2.37 - Baby Detained Indicator.
        ///// </summary>
        //public BabyDetainedIndicator { get; set; }

        ///// <summary>
        ///// PV2.38 - Mode of Arrival Code.
        ///// </summary>
        //public ModeOfArrivalCode { get; set; }

        ///// <summary>
        ///// PV2.39 - Recreational Drug Use Code.
        ///// </summary>
        //public RecreationalDrugUseCode { get; set; }

        ///// <summary>
        ///// PV2.40 - Admission Level of Care Code.
        ///// </summary>
        //public AdmissionLevelOfCareCode { get; set; }

        ///// <summary>
        ///// PV2.41 - Precaution Code.
        ///// </summary>
        //public PrecautionCode { get; set; }

        ///// <summary>
        ///// PV2.42 - Patient Condition Code.
        ///// </summary>
        //public PatientConditionCode { get; set; }

        ///// <summary>
        ///// PV2.43 - Living Will Code.
        ///// </summary>
        //public LivingWillCode { get; set; }

        ///// <summary>
        ///// PV2.44 - Organ Donor Code.
        ///// </summary>
        //public OrganDonorCode { get; set; }

        ///// <summary>
        ///// PV2.45 - Advance Directive Code.
        ///// </summary>
        //public AdvanceDirectiveCode { get; set; }

        ///// <summary>
        ///// PV2.46 - Patient Status Effective Date.
        ///// </summary>
        //public PatientStatusEffectiveDate { get; set; }

        ///// <summary>
        ///// PV2.47 - Expected LOA Return Date/Time.
        ///// </summary>
        //public ExpectedLoaReturnDateTime { get; set; }

        ///// <summary>
        ///// PV2.48 - Expected Pre-admission Testing Date/Time.
        ///// </summary>
        //public ExpectedPreAdmissionTestingDateTime { get; set; }

        ///// <summary>
        ///// PV2.49 - Notify Clergy Code.
        ///// </summary>
        //public NotifyClergyCode { get; set; }

        ///// <summary>
        ///// PV2.50 - Advance Directive Last Verified Date.
        ///// </summary>
        //public AdvanceDirectiveLastVerifiedDate { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}|{38}|{39}|{40}|{41}|{42}|{43}|{44}|{45}|{46}|{47}|{48}|{49}|{50}"
                                ).TrimEnd('|');
        }
    }
}