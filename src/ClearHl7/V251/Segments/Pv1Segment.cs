using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0004</remarks>
        public string PatientClass { get; set; }

        /// <summary>
        /// PV1.3 - Assigned Patient Location.
        /// </summary>
        public PersonLocation AssignedPatientLocation { get; set; }

        /// <summary>
        /// PV1.4 - Admission Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0007</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0010</remarks>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> AttendingDoctor { get; set; }

        /// <summary>
        /// PV1.8 - Referring Doctor.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0010</remarks>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ReferringDoctor { get; set; }

        /// <summary>
        /// PV1.9 - Consulting Doctor.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0010</remarks>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ConsultingDoctor { get; set; }

        /// <summary>
        /// PV1.10 - Hospital Service.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0069</remarks>
        public string HospitalService { get; set; }

        /// <summary>
        /// PV1.11 - Temporary Location.
        /// </summary>
        public PersonLocation TemporaryLocation { get; set; }

        /// <summary>
        /// PV1.12 - Preadmit Test Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0087</remarks>
        public string PreadmitTestIndicator { get; set; }

        /// <summary>
        /// PV1.13 - Re-admission Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0092</remarks>
        public string ReadmissionIndicator { get; set; }

        /// <summary>
        /// PV1.14 - Admit Source.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0023</remarks>
        public string AdmitSource { get; set; }

        /// <summary>
        /// PV1.15 - Ambulatory Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0009</remarks>
        public IEnumerable<string> AmbulatoryStatus { get; set; }

        /// <summary>
        /// PV1.16 - VIP Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0099</remarks>
        public string VipIndicator { get; set; }

        /// <summary>
        /// PV1.17 - Admitting Doctor.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0010</remarks>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> AdmittingDoctor { get; set; }

        /// <summary>
        /// PV1.18 - Patient Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0018</remarks>
        public string PatientType { get; set; }

        /// <summary>
        /// PV1.19 - Visit Number.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit VisitNumber { get; set; }

        /// <summary>
        /// PV1.20 - Financial Class.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0064</remarks>
        public IEnumerable<FinancialClass> FinancialClass { get; set; }

        /// <summary>
        /// PV1.21 - Charge Price Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0032</remarks>
        public string ChargePriceIndicator { get; set; }

        /// <summary>
        /// PV1.22 - Courtesy Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0045</remarks>
        public string CourtesyCode { get; set; }

        /// <summary>
        /// PV1.23 - Credit Rating.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0046</remarks>
        public string CreditRating { get; set; }

        /// <summary>
        /// PV1.24 - Contract Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0044</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0073</remarks>
        public string InterestCode { get; set; }

        /// <summary>
        /// PV1.29 - Transfer to Bad Debt Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0110</remarks>
        public string TransferToBadDebtCode { get; set; }

        /// <summary>
        /// PV1.30 - Transfer to Bad Debt Date.
        /// </summary>
        public DateTime? TransferToBadDebtDate { get; set; }

        /// <summary>
        /// PV1.31 - Bad Debt Agency Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0021</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0111</remarks>
        public string DeleteAccountIndicator { get; set; }

        /// <summary>
        /// PV1.35 - Delete Account Date.
        /// </summary>
        public DateTime? DeleteAccountDate { get; set; }

        /// <summary>
        /// PV1.36 - Discharge Disposition.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0112</remarks>
        public string DischargeDisposition { get; set; }

        /// <summary>
        /// PV1.37 - Discharged to Location.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0113</remarks>
        public DischargeToLocationAndDate DischargedToLocation { get; set; }

        /// <summary>
        /// PV1.38 - Diet Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0114</remarks>
        public CodedElement DietType { get; set; }

        /// <summary>
        /// PV1.39 - Servicing Facility.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0115</remarks>
        public string ServicingFacility { get; set; }

        /// <summary>
        /// PV1.40 - Bed Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0116</remarks>
        public string BedStatus { get; set; }

        /// <summary>
        /// PV1.41 - Account Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0117</remarks>
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
        public DateTime? DischargeDateTime { get; set; }

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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0203</remarks>
        public ExtendedCompositeIdWithCheckDigit AlternateVisitId { get; set; }

        /// <summary>
        /// PV1.51 - Visit Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0326</remarks>
        public string VisitIndicator { get; set; }

        /// <summary>
        /// PV1.52 - Other Healthcare Provider.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons OtherHealthcareProvider { get; set; }

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
                                DischargeDateTime.HasValue ? DischargeDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                CurrentPatientBalance.HasValue ? CurrentPatientBalance.Value.ToString(Consts.NumericFormat, culture) : null,
                                TotalCharges.HasValue ? TotalCharges.Value.ToString(Consts.NumericFormat, culture) : null,
                                TotalAdjustments.HasValue ? TotalAdjustments.Value.ToString(Consts.NumericFormat, culture) : null,
                                TotalPayments.HasValue ? TotalPayments.Value.ToString(Consts.NumericFormat, culture) : null,
                                AlternateVisitId?.ToDelimitedString(),
                                VisitIndicator,
                                OtherHealthcareProvider?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}