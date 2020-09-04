using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PV1 - Patient Visit.
    /// </summary>
    public class Pv1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PV1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// PV1.1 - Set ID - PV1.
        ///// </summary>
        //public SetIdPv1 { get; set; }

        ///// <summary>
        ///// PV1.2 - Patient Class.
        ///// </summary>
        //public PatientClass { get; set; }

        ///// <summary>
        ///// PV1.3 - Assigned Patient Location.
        ///// </summary>
        //public AssignedPatientLocation { get; set; }

        ///// <summary>
        ///// PV1.4 - Admission Type.
        ///// </summary>
        //public AdmissionType { get; set; }

        ///// <summary>
        ///// PV1.5 - Preadmit Number.
        ///// </summary>
        //public PreadmitNumber { get; set; }

        ///// <summary>
        ///// PV1.6 - Prior Patient Location.
        ///// </summary>
        //public PriorPatientLocation { get; set; }

        ///// <summary>
        ///// PV1.7 - Attending Doctor.
        ///// </summary>
        //public AttendingDoctor { get; set; }

        ///// <summary>
        ///// PV1.8 - Referring Doctor.
        ///// </summary>
        //public ReferringDoctor { get; set; }

        ///// <summary>
        ///// PV1.9 - Consulting Doctor.
        ///// </summary>
        //public ConsultingDoctor { get; set; }

        ///// <summary>
        ///// PV1.10 - Hospital Service.
        ///// </summary>
        //public HospitalService { get; set; }

        ///// <summary>
        ///// PV1.11 - Temporary Location.
        ///// </summary>
        //public TemporaryLocation { get; set; }

        ///// <summary>
        ///// PV1.12 - Preadmit Test Indicator.
        ///// </summary>
        //public PreadmitTestIndicator { get; set; }

        ///// <summary>
        ///// PV1.13 - Re-admission Indicator.
        ///// </summary>
        //public ReAdmissionIndicator { get; set; }

        ///// <summary>
        ///// PV1.14 - Admit Source.
        ///// </summary>
        //public AdmitSource { get; set; }

        ///// <summary>
        ///// PV1.15 - Ambulatory Status.
        ///// </summary>
        //public AmbulatoryStatus { get; set; }

        ///// <summary>
        ///// PV1.16 - VIP Indicator.
        ///// </summary>
        //public VipIndicator { get; set; }

        ///// <summary>
        ///// PV1.17 - Admitting Doctor.
        ///// </summary>
        //public AdmittingDoctor { get; set; }

        ///// <summary>
        ///// PV1.18 - Patient Type.
        ///// </summary>
        //public PatientType { get; set; }

        ///// <summary>
        ///// PV1.19 - Visit Number.
        ///// </summary>
        //public VisitNumber { get; set; }

        ///// <summary>
        ///// PV1.20 - Financial Class.
        ///// </summary>
        //public FinancialClass { get; set; }

        ///// <summary>
        ///// PV1.21 - Charge Price Indicator.
        ///// </summary>
        //public ChargePriceIndicator { get; set; }

        ///// <summary>
        ///// PV1.22 - Courtesy Code.
        ///// </summary>
        //public CourtesyCode { get; set; }

        ///// <summary>
        ///// PV1.23 - Credit Rating.
        ///// </summary>
        //public CreditRating { get; set; }

        ///// <summary>
        ///// PV1.24 - Contract Code.
        ///// </summary>
        //public ContractCode { get; set; }

        ///// <summary>
        ///// PV1.25 - Contract Effective Date.
        ///// </summary>
        //public ContractEffectiveDate { get; set; }

        ///// <summary>
        ///// PV1.26 - Contract Amount.
        ///// </summary>
        //public ContractAmount { get; set; }

        ///// <summary>
        ///// PV1.27 - Contract Period.
        ///// </summary>
        //public ContractPeriod { get; set; }

        ///// <summary>
        ///// PV1.28 - Interest Code.
        ///// </summary>
        //public InterestCode { get; set; }

        ///// <summary>
        ///// PV1.29 - Transfer to Bad Debt Code.
        ///// </summary>
        //public TransferToBadDebtCode { get; set; }

        ///// <summary>
        ///// PV1.30 - Transfer to Bad Debt Date.
        ///// </summary>
        //public TransferToBadDebtDate { get; set; }

        ///// <summary>
        ///// PV1.31 - Bad Debt Agency Code.
        ///// </summary>
        //public BadDebtAgencyCode { get; set; }

        ///// <summary>
        ///// PV1.32 - Bad Debt Transfer Amount.
        ///// </summary>
        //public BadDebtTransferAmount { get; set; }

        ///// <summary>
        ///// PV1.33 - Bad Debt Recovery Amount.
        ///// </summary>
        //public BadDebtRecoveryAmount { get; set; }

        ///// <summary>
        ///// PV1.34 - Delete Account Indicator.
        ///// </summary>
        //public DeleteAccountIndicator { get; set; }

        ///// <summary>
        ///// PV1.35 - Delete Account Date.
        ///// </summary>
        //public DeleteAccountDate { get; set; }

        ///// <summary>
        ///// PV1.36 - Discharge Disposition.
        ///// </summary>
        //public DischargeDisposition { get; set; }

        ///// <summary>
        ///// PV1.37 - Discharged to Location.
        ///// </summary>
        //public DischargedToLocation { get; set; }

        ///// <summary>
        ///// PV1.38 - Diet Type.
        ///// </summary>
        //public DietType { get; set; }

        ///// <summary>
        ///// PV1.39 - Servicing Facility.
        ///// </summary>
        //public ServicingFacility { get; set; }

        ///// <summary>
        ///// PV1.40 - Bed Status.
        ///// </summary>
        //public BedStatus { get; set; }

        ///// <summary>
        ///// PV1.41 - Account Status.
        ///// </summary>
        //public AccountStatus { get; set; }

        ///// <summary>
        ///// PV1.42 - Pending Location.
        ///// </summary>
        //public PendingLocation { get; set; }

        ///// <summary>
        ///// PV1.43 - Prior Temporary Location.
        ///// </summary>
        //public PriorTemporaryLocation { get; set; }

        ///// <summary>
        ///// PV1.44 - Admit Date/Time.
        ///// </summary>
        //public AdmitDateTime { get; set; }

        ///// <summary>
        ///// PV1.45 - Discharge Date/Time.
        ///// </summary>
        //public DischargeDateTime { get; set; }

        ///// <summary>
        ///// PV1.46 - Current Patient Balance.
        ///// </summary>
        //public CurrentPatientBalance { get; set; }

        ///// <summary>
        ///// PV1.47 - Total Charges.
        ///// </summary>
        //public TotalCharges { get; set; }

        ///// <summary>
        ///// PV1.48 - Total Adjustments.
        ///// </summary>
        //public TotalAdjustments { get; set; }

        ///// <summary>
        ///// PV1.49 - Total Payments.
        ///// </summary>
        //public TotalPayments { get; set; }

        ///// <summary>
        ///// PV1.50 - Alternate Visit ID.
        ///// </summary>
        //public AlternateVisitId { get; set; }

        ///// <summary>
        ///// PV1.51 - Visit Indicator.
        ///// </summary>
        //public VisitIndicator { get; set; }

        ///// <summary>
        ///// PV1.52 - Other Healthcare Provider.
        ///// </summary>
        //public OtherHealthcareProvider { get; set; }

        ///// <summary>
        ///// PV1.53 - Service Episode Description.
        ///// </summary>
        //public ServiceEpisodeDescription { get; set; }

        ///// <summary>
        ///// PV1.54 - Service Episode Identifier.
        ///// </summary>
        //public ServiceEpisodeIdentifier { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|{37}|{38}|{39}|{40}|{41}|{42}|{43}|{44}|{45}|{46}|{47}|{48}|{49}|{50}|{51}|{52}|{53}|{54}"
                                ).TrimEnd('|');
        }
    }
}