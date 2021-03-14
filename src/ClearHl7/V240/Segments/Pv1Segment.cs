using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
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

        /// <summary>
        /// PV1.1 - Set ID - PV1.
        /// </summary>
        public uint? SetIdPv1 { get; set; }

        /// <summary>
        /// PV1.2 - Patient Class.
        /// <para>Suggested: 0004 Patient Class -&gt; ClearHl7.Codes.V240.CodePatientClass</para>
        /// </summary>
        public string PatientClass { get; set; }

        /// <summary>
        /// PV1.3 - Assigned Patient Location.
        /// </summary>
        public PersonLocation AssignedPatientLocation { get; set; }

        /// <summary>
        /// PV1.4 - Admission Type.
        /// <para>Suggested: 0007 Admission Type -&gt; ClearHl7.Codes.V240.CodeAdmissionType</para>
        /// </summary>
        public string AdmissionType { get; set; }

        /// <summary>
        /// PV1.5 - Preadmit Number.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PreadmitNumber { get; set; }

        /// <summary>
        /// PV1.6 - Prior Patient Location.
        /// </summary>
        public PersonLocation PriorPatientLocation { get; set; }

        /// <summary>
        /// PV1.7 - Attending Doctor.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> AttendingDoctor { get; set; }

        /// <summary>
        /// PV1.8 - Referring Doctor.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ReferringDoctor { get; set; }

        /// <summary>
        /// PV1.9 - Consulting Doctor.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ConsultingDoctor { get; set; }

        /// <summary>
        /// PV1.10 - Hospital Service.
        /// <para>Suggested: 0069 Hospital Service -&gt; ClearHl7.Codes.V240.CodeHospitalService</para>
        /// </summary>
        public string HospitalService { get; set; }

        /// <summary>
        /// PV1.11 - Temporary Location.
        /// </summary>
        public PersonLocation TemporaryLocation { get; set; }

        /// <summary>
        /// PV1.12 - Preadmit Test Indicator.
        /// <para>Suggested: 0087 Pre-Admit Test Indicator</para>
        /// </summary>
        public string PreadmitTestIndicator { get; set; }

        /// <summary>
        /// PV1.13 - Re-admission Indicator.
        /// <para>Suggested: 0092 Re-Admission Indicator -&gt; ClearHl7.Codes.V240.CodeReadmissionIndicator</para>
        /// </summary>
        public string ReadmissionIndicator { get; set; }

        /// <summary>
        /// PV1.14 - Admit Source.
        /// <para>Suggested: 0023 Admit Source -&gt; ClearHl7.Codes.V240.CodeAdmitSource</para>
        /// </summary>
        public string AdmitSource { get; set; }

        /// <summary>
        /// PV1.15 - Ambulatory Status.
        /// <para>Suggested: 0009 Ambulatory Status -&gt; ClearHl7.Codes.V240.CodeAmbulatoryStatus</para>
        /// </summary>
        public IEnumerable<string> AmbulatoryStatus { get; set; }

        /// <summary>
        /// PV1.16 - VIP Indicator.
        /// <para>Suggested: 0099 VIP Indicator</para>
        /// </summary>
        public string VipIndicator { get; set; }

        /// <summary>
        /// PV1.17 - Admitting Doctor.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> AdmittingDoctor { get; set; }

        /// <summary>
        /// PV1.18 - Patient Type.
        /// <para>Suggested: 0018 Patient Type</para>
        /// </summary>
        public string PatientType { get; set; }

        /// <summary>
        /// PV1.19 - Visit Number.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit VisitNumber { get; set; }

        /// <summary>
        /// PV1.20 - Financial Class.
        /// <para>Suggested: 0064 Financial Class</para>
        /// </summary>
        public IEnumerable<FinancialClass> FinancialClass { get; set; }

        /// <summary>
        /// PV1.21 - Charge Price Indicator.
        /// <para>Suggested: 0032 Charge/Price Indicator</para>
        /// </summary>
        public string ChargePriceIndicator { get; set; }

        /// <summary>
        /// PV1.22 - Courtesy Code.
        /// <para>Suggested: 0045 Courtesy Code</para>
        /// </summary>
        public string CourtesyCode { get; set; }

        /// <summary>
        /// PV1.23 - Credit Rating.
        /// <para>Suggested: 0046 Credit Rating</para>
        /// </summary>
        public string CreditRating { get; set; }

        /// <summary>
        /// PV1.24 - Contract Code.
        /// <para>Suggested: 0044 Contract Code</para>
        /// </summary>
        public IEnumerable<string> ContractCode { get; set; }

        /// <summary>
        /// PV1.25 - Contract Effective Date.
        /// </summary>
        public IEnumerable<DateTime> ContractEffectiveDate { get; set; }

        /// <summary>
        /// PV1.26 - Contract Amount.
        /// </summary>
        public IEnumerable<decimal> ContractAmount { get; set; }

        /// <summary>
        /// PV1.27 - Contract Period.
        /// </summary>
        public IEnumerable<decimal> ContractPeriod { get; set; }

        /// <summary>
        /// PV1.28 - Interest Code.
        /// <para>Suggested: 0073 Interest Rate Code</para>
        /// </summary>
        public string InterestCode { get; set; }

        /// <summary>
        /// PV1.29 - Transfer to Bad Debt Code.
        /// <para>Suggested: 0110 Transfer To Bad Debt Code</para>
        /// </summary>
        public string TransferToBadDebtCode { get; set; }

        /// <summary>
        /// PV1.30 - Transfer to Bad Debt Date.
        /// </summary>
        public DateTime? TransferToBadDebtDate { get; set; }

        /// <summary>
        /// PV1.31 - Bad Debt Agency Code.
        /// <para>Suggested: 0021 Bad Debt Agency Code</para>
        /// </summary>
        public string BadDebtAgencyCode { get; set; }

        /// <summary>
        /// PV1.32 - Bad Debt Transfer Amount.
        /// </summary>
        public decimal? BadDebtTransferAmount { get; set; }

        /// <summary>
        /// PV1.33 - Bad Debt Recovery Amount.
        /// </summary>
        public decimal? BadDebtRecoveryAmount { get; set; }

        /// <summary>
        /// PV1.34 - Delete Account Indicator.
        /// <para>Suggested: 0111 Delete Account Code</para>
        /// </summary>
        public string DeleteAccountIndicator { get; set; }

        /// <summary>
        /// PV1.35 - Delete Account Date.
        /// </summary>
        public DateTime? DeleteAccountDate { get; set; }

        /// <summary>
        /// PV1.36 - Discharge Disposition.
        /// <para>Suggested: 0112 Discharge Disposition</para>
        /// </summary>
        public string DischargeDisposition { get; set; }

        /// <summary>
        /// PV1.37 - Discharged to Location.
        /// <para>Suggested: 0113 Discharged to Location</para>
        /// </summary>
        public DischargeToLocationAndDate DischargedToLocation { get; set; }

        /// <summary>
        /// PV1.38 - Diet Type.
        /// <para>Suggested: 0114 Diet Type</para>
        /// </summary>
        public CodedElement DietType { get; set; }

        /// <summary>
        /// PV1.39 - Servicing Facility.
        /// <para>Suggested: 0115 Servicing Facility</para>
        /// </summary>
        public string ServicingFacility { get; set; }

        /// <summary>
        /// PV1.40 - Bed Status.
        /// <para>Suggested: 0116 Bed Status -&gt; ClearHl7.Codes.V240.CodeBedStatus</para>
        /// </summary>
        public string BedStatus { get; set; }

        /// <summary>
        /// PV1.41 - Account Status.
        /// <para>Suggested: 0117 Account Status</para>
        /// </summary>
        public string AccountStatus { get; set; }

        /// <summary>
        /// PV1.42 - Pending Location.
        /// </summary>
        public PersonLocation PendingLocation { get; set; }

        /// <summary>
        /// PV1.43 - Prior Temporary Location.
        /// </summary>
        public PersonLocation PriorTemporaryLocation { get; set; }

        /// <summary>
        /// PV1.44 - Admit Date/Time.
        /// </summary>
        public DateTime? AdmitDateTime { get; set; }

        /// <summary>
        /// PV1.45 - Discharge Date/Time.
        /// </summary>
        public IEnumerable<DateTime> DischargeDateTime { get; set; }

        /// <summary>
        /// PV1.46 - Current Patient Balance.
        /// </summary>
        public decimal? CurrentPatientBalance { get; set; }

        /// <summary>
        /// PV1.47 - Total Charges.
        /// </summary>
        public decimal? TotalCharges { get; set; }

        /// <summary>
        /// PV1.48 - Total Adjustments.
        /// </summary>
        public decimal? TotalAdjustments { get; set; }

        /// <summary>
        /// PV1.49 - Total Payments.
        /// </summary>
        public decimal? TotalPayments { get; set; }

        /// <summary>
        /// PV1.50 - Alternate Visit ID.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V240.CodeIdentifierType</para>
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit AlternateVisitId { get; set; }

        /// <summary>
        /// PV1.51 - Visit Indicator.
        /// <para>Suggested: 0326 Visit Indicator -&gt; ClearHl7.Codes.V240.CodeVisitIndicator</para>
        /// </summary>
        public string VisitIndicator { get; set; }

        /// <summary>
        /// PV1.52 - Other Healthcare Provider.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> OtherHealthcareProvider { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 53, Configuration.FieldSeparator),
                                Id,
                                SetIdPv1.HasValue ? SetIdPv1.Value.ToString(culture) : null,
                                PatientClass,
                                AssignedPatientLocation?.ToDelimitedString(),
                                AdmissionType,
                                PreadmitNumber?.ToDelimitedString(),
                                PriorPatientLocation?.ToDelimitedString(),
                                AttendingDoctor != null ? string.Join(Configuration.FieldRepeatSeparator, AttendingDoctor.Select(x => x.ToDelimitedString())) : null,
                                ReferringDoctor != null ? string.Join(Configuration.FieldRepeatSeparator, ReferringDoctor.Select(x => x.ToDelimitedString())) : null,
                                ConsultingDoctor != null ? string.Join(Configuration.FieldRepeatSeparator, ConsultingDoctor.Select(x => x.ToDelimitedString())) : null,
                                HospitalService,
                                TemporaryLocation?.ToDelimitedString(),
                                PreadmitTestIndicator,
                                ReadmissionIndicator,
                                AdmitSource,
                                AmbulatoryStatus != null ? string.Join(Configuration.FieldRepeatSeparator, AmbulatoryStatus) : null,
                                VipIndicator,
                                AdmittingDoctor != null ? string.Join(Configuration.FieldRepeatSeparator, AdmittingDoctor.Select(x => x.ToDelimitedString())) : null,
                                PatientType,
                                VisitNumber?.ToDelimitedString(),
                                FinancialClass != null ? string.Join(Configuration.FieldRepeatSeparator, FinancialClass.Select(x => x.ToDelimitedString())) : null,
                                ChargePriceIndicator,
                                CourtesyCode,
                                CreditRating,
                                ContractCode != null ? string.Join(Configuration.FieldRepeatSeparator, ContractCode) : null,
                                ContractEffectiveDate != null ? string.Join(Configuration.FieldRepeatSeparator, ContractEffectiveDate.Select(x => x.ToString(Consts.DateFormatPrecisionDay, culture))) : null,
                                ContractAmount != null ? string.Join(Configuration.FieldRepeatSeparator, ContractAmount.Select(x => x.ToString(Consts.NumericFormat, culture))) : null,
                                ContractPeriod != null ? string.Join(Configuration.FieldRepeatSeparator, ContractPeriod.Select(x => x.ToString(Consts.NumericFormat, culture))) : null,
                                InterestCode,
                                TransferToBadDebtCode,
                                TransferToBadDebtDate.HasValue ? TransferToBadDebtDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                BadDebtAgencyCode,
                                BadDebtTransferAmount.HasValue ? BadDebtTransferAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                BadDebtRecoveryAmount.HasValue ? BadDebtRecoveryAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                DeleteAccountIndicator,
                                DeleteAccountDate.HasValue ? DeleteAccountDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DischargeDisposition,
                                DischargedToLocation?.ToDelimitedString(),
                                DietType?.ToDelimitedString(),
                                ServicingFacility,
                                BedStatus,
                                AccountStatus,
                                PendingLocation?.ToDelimitedString(),
                                PriorTemporaryLocation?.ToDelimitedString(),
                                AdmitDateTime.HasValue ? AdmitDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DischargeDateTime != null ? string.Join(Configuration.FieldRepeatSeparator, DischargeDateTime.Select(x => x.ToString(Consts.DateTimeFormatPrecisionSecond, culture))) : null,
                                CurrentPatientBalance.HasValue ? CurrentPatientBalance.Value.ToString(Consts.NumericFormat, culture) : null,
                                TotalCharges.HasValue ? TotalCharges.Value.ToString(Consts.NumericFormat, culture) : null,
                                TotalAdjustments.HasValue ? TotalAdjustments.Value.ToString(Consts.NumericFormat, culture) : null,
                                TotalPayments.HasValue ? TotalPayments.Value.ToString(Consts.NumericFormat, culture) : null,
                                AlternateVisitId?.ToDelimitedString(),
                                VisitIndicator,
                                OtherHealthcareProvider != null ? string.Join(Configuration.FieldRepeatSeparator, OtherHealthcareProvider.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}