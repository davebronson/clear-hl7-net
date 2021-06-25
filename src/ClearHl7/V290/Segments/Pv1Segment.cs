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
        /// <para>Suggested: 0004 Patient Class -&gt; ClearHl7.Codes.V290.CodePatientClass</para>
        /// </summary>
        public CodedWithExceptions PatientClass { get; set; }

        /// <summary>
        /// PV1.3 - Assigned Patient Location.
        /// </summary>
        public PersonLocation AssignedPatientLocation { get; set; }

        /// <summary>
        /// PV1.4 - Admission Type.
        /// <para>Suggested: 0007 Admission Type -&gt; ClearHl7.Codes.V290.CodeAdmissionType</para>
        /// </summary>
        public CodedWithExceptions AdmissionType { get; set; }

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
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ConsultingDoctor { get; set; }

        /// <summary>
        /// PV1.10 - Hospital Service.
        /// <para>Suggested: 0069 Hospital Service -&gt; ClearHl7.Codes.V290.CodeHospitalService</para>
        /// </summary>
        public CodedWithExceptions HospitalService { get; set; }

        /// <summary>
        /// PV1.11 - Temporary Location.
        /// </summary>
        public PersonLocation TemporaryLocation { get; set; }

        /// <summary>
        /// PV1.12 - Preadmit Test Indicator.
        /// <para>Suggested: 0087 Pre-Admit Test Indicator</para>
        /// </summary>
        public CodedWithExceptions PreadmitTestIndicator { get; set; }

        /// <summary>
        /// PV1.13 - Re-admission Indicator.
        /// <para>Suggested: 0092 Re-Admission Indicator -&gt; ClearHl7.Codes.V290.CodeReadmissionIndicator</para>
        /// </summary>
        public CodedWithExceptions ReadmissionIndicator { get; set; }

        /// <summary>
        /// PV1.14 - Admit Source.
        /// <para>Suggested: 0023 Admit Source -&gt; ClearHl7.Codes.V290.CodeAdmitSource</para>
        /// </summary>
        public CodedWithExceptions AdmitSource { get; set; }

        /// <summary>
        /// PV1.15 - Ambulatory Status.
        /// <para>Suggested: 0009 Ambulatory Status -&gt; ClearHl7.Codes.V290.CodeAmbulatoryStatus</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> AmbulatoryStatus { get; set; }

        /// <summary>
        /// PV1.16 - VIP Indicator.
        /// <para>Suggested: 0099 VIP Indicator</para>
        /// </summary>
        public CodedWithExceptions VipIndicator { get; set; }

        /// <summary>
        /// PV1.17 - Admitting Doctor.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> AdmittingDoctor { get; set; }

        /// <summary>
        /// PV1.18 - Patient Type.
        /// <para>Suggested: 0018 Patient Type</para>
        /// </summary>
        public CodedWithExceptions PatientType { get; set; }

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
        public CodedWithExceptions ChargePriceIndicator { get; set; }

        /// <summary>
        /// PV1.22 - Courtesy Code.
        /// <para>Suggested: 0045 Courtesy Code</para>
        /// </summary>
        public CodedWithExceptions CourtesyCode { get; set; }

        /// <summary>
        /// PV1.23 - Credit Rating.
        /// <para>Suggested: 0046 Credit Rating</para>
        /// </summary>
        public CodedWithExceptions CreditRating { get; set; }

        /// <summary>
        /// PV1.24 - Contract Code.
        /// <para>Suggested: 0044 Contract Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ContractCode { get; set; }

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
        public CodedWithExceptions InterestCode { get; set; }

        /// <summary>
        /// PV1.29 - Transfer to Bad Debt Code.
        /// <para>Suggested: 0110 Transfer To Bad Debt Code</para>
        /// </summary>
        public CodedWithExceptions TransferToBadDebtCode { get; set; }

        /// <summary>
        /// PV1.30 - Transfer to Bad Debt Date.
        /// </summary>
        public DateTime? TransferToBadDebtDate { get; set; }

        /// <summary>
        /// PV1.31 - Bad Debt Agency Code.
        /// <para>Suggested: 0021 Bad Debt Agency Code</para>
        /// </summary>
        public CodedWithExceptions BadDebtAgencyCode { get; set; }

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
        public CodedWithExceptions DeleteAccountIndicator { get; set; }

        /// <summary>
        /// PV1.35 - Delete Account Date.
        /// </summary>
        public DateTime? DeleteAccountDate { get; set; }

        /// <summary>
        /// PV1.36 - Discharge Disposition.
        /// <para>Suggested: 0112 Discharge Disposition</para>
        /// </summary>
        public CodedWithExceptions DischargeDisposition { get; set; }

        /// <summary>
        /// PV1.37 - Discharged to Location.
        /// <para>Suggested: 0113 Discharged to Location</para>
        /// </summary>
        public DischargeToLocationAndDate DischargedToLocation { get; set; }

        /// <summary>
        /// PV1.38 - Diet Type.
        /// <para>Suggested: 0114 Diet Type</para>
        /// </summary>
        public CodedWithExceptions DietType { get; set; }

        /// <summary>
        /// PV1.39 - Servicing Facility.
        /// <para>Suggested: 0115 Servicing Facility</para>
        /// </summary>
        public CodedWithExceptions ServicingFacility { get; set; }

        /// <summary>
        /// PV1.40 - Bed Status.
        /// <para>Suggested: 0116 Bed Status -&gt; ClearHl7.Codes.V290.CodeBedStatus</para>
        /// </summary>
        public CodedWithExceptions BedStatus { get; set; }

        /// <summary>
        /// PV1.41 - Account Status.
        /// <para>Suggested: 0117 Account Status</para>
        /// </summary>
        public CodedWithExceptions AccountStatus { get; set; }

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
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V290.CodeIdentifierType</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> AlternateVisitId { get; set; }

        /// <summary>
        /// PV1.51 - Visit Indicator.
        /// <para>Suggested: 0326 Visit Indicator -&gt; ClearHl7.Codes.V290.CodeVisitIndicator</para>
        /// </summary>
        public CodedWithExceptions VisitIndicator { get; set; }

        /// <summary>
        /// PV1.52 - Other Healthcare Provider.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons OtherHealthcareProvider { get; set; }

        /// <summary>
        /// PV1.53 - Service Episode Description.
        /// </summary>
        public string ServiceEpisodeDescription { get; set; }

        /// <summary>
        /// PV1.54 - Service Episode Identifier.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit ServiceEpisodeIdentifier { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public Pv1Segment FromDelimitedString(string delimitedString)
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

            SetIdPv1 = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            PatientClass = segments.Length > 2 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            AssignedPatientLocation = segments.Length > 3 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            AdmissionType = segments.Length > 4 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            PreadmitNumber = segments.Length > 5 ? new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            PriorPatientLocation = segments.Length > 6 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            AttendingDoctor = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            ReferringDoctor = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            ConsultingDoctor = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            HospitalService = segments.Length > 10 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(10)) : null;
            TemporaryLocation = segments.Length > 11 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            PreadmitTestIndicator = segments.Length > 12 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(12)) : null;
            ReadmissionIndicator = segments.Length > 13 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(13)) : null;
            AdmitSource = segments.Length > 14 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(14)) : null;
            AmbulatoryStatus = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            VipIndicator = segments.Length > 16 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(16)) : null;
            AdmittingDoctor = segments.Length > 17 ? segments.ElementAtOrDefault(17).Split(separator).Select(x => new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(x)) : null;
            PatientType = segments.Length > 18 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(18)) : null;
            VisitNumber = segments.Length > 19 ? new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(segments.ElementAtOrDefault(19)) : null;
            FinancialClass = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => new FinancialClass().FromDelimitedString(x)) : null;
            ChargePriceIndicator = segments.Length > 21 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(21)) : null;
            CourtesyCode = segments.Length > 22 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(22)) : null;
            CreditRating = segments.Length > 23 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(23)) : null;
            ContractCode = segments.Length > 24 ? segments.ElementAtOrDefault(24).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            ContractEffectiveDate = segments.Length > 25 ? segments.ElementAtOrDefault(25).Split(separator).Select(x => x.ToDateTime(Consts.DateFormatPrecisionDay)) : null;
            ContractAmount = segments.Length > 26 ? segments.ElementAtOrDefault(26).Split(separator).Select(x => x.ToDecimal()) : null;
            ContractPeriod = segments.Length > 27 ? segments.ElementAtOrDefault(27).Split(separator).Select(x => x.ToDecimal()) : null;
            InterestCode = segments.Length > 28 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(28)) : null;
            TransferToBadDebtCode = segments.Length > 29 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(29)) : null;
            TransferToBadDebtDate = segments.ElementAtOrDefault(30)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            BadDebtAgencyCode = segments.Length > 31 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(31)) : null;
            BadDebtTransferAmount = segments.Length > 32 ? segments.ElementAtOrDefault(32)?.ToNullableDecimal() : null;
            BadDebtRecoveryAmount = segments.Length > 33 ? segments.ElementAtOrDefault(33)?.ToNullableDecimal() : null;
            DeleteAccountIndicator = segments.Length > 34 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(34)) : null;
            DeleteAccountDate = segments.ElementAtOrDefault(35)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            DischargeDisposition = segments.Length > 36 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(36)) : null;
            DischargedToLocation = segments.Length > 37 ? new DischargeToLocationAndDate().FromDelimitedString(segments.ElementAtOrDefault(37)) : null;
            DietType = segments.Length > 38 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(38)) : null;
            ServicingFacility = segments.Length > 39 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(39)) : null;
            BedStatus = segments.Length > 40 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(40)) : null;
            AccountStatus = segments.Length > 41 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(41)) : null;
            PendingLocation = segments.Length > 42 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(42)) : null;
            PriorTemporaryLocation = segments.Length > 43 ? new PersonLocation().FromDelimitedString(segments.ElementAtOrDefault(43)) : null;
            AdmitDateTime = segments.ElementAtOrDefault(44)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            DischargeDateTime = segments.ElementAtOrDefault(45)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            CurrentPatientBalance = segments.ElementAtOrDefault(46)?.ToNullableDecimal();
            TotalCharges = segments.ElementAtOrDefault(47)?.ToNullableDecimal();
            TotalAdjustments = segments.ElementAtOrDefault(48)?.ToNullableDecimal();
            TotalPayments = segments.ElementAtOrDefault(49)?.ToNullableDecimal();
            AlternateVisitId = segments.Length > 50 ? segments.ElementAtOrDefault(50).Split(separator).Select(x => new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(x)) : null;
            VisitIndicator = segments.Length > 51 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(51)) : null;
            OtherHealthcareProvider = segments.Length > 52 ? new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(segments.ElementAtOrDefault(52)) : null;
            ServiceEpisodeDescription = segments.ElementAtOrDefault(53);
            ServiceEpisodeIdentifier = segments.Length > 54 ? new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(segments.ElementAtOrDefault(54)) : null;

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
                                StringHelper.StringFormatSequence(0, 55, Configuration.FieldSeparator),
                                Id,
                                SetIdPv1.HasValue ? SetIdPv1.Value.ToString(culture) : null,
                                PatientClass?.ToDelimitedString(),
                                AssignedPatientLocation?.ToDelimitedString(),
                                AdmissionType?.ToDelimitedString(),
                                PreadmitNumber?.ToDelimitedString(),
                                PriorPatientLocation?.ToDelimitedString(),
                                AttendingDoctor != null ? string.Join(Configuration.FieldRepeatSeparator, AttendingDoctor.Select(x => x.ToDelimitedString())) : null,
                                ReferringDoctor != null ? string.Join(Configuration.FieldRepeatSeparator, ReferringDoctor.Select(x => x.ToDelimitedString())) : null,
                                ConsultingDoctor != null ? string.Join(Configuration.FieldRepeatSeparator, ConsultingDoctor.Select(x => x.ToDelimitedString())) : null,
                                HospitalService?.ToDelimitedString(),
                                TemporaryLocation?.ToDelimitedString(),
                                PreadmitTestIndicator?.ToDelimitedString(),
                                ReadmissionIndicator?.ToDelimitedString(),
                                AdmitSource?.ToDelimitedString(),
                                AmbulatoryStatus != null ? string.Join(Configuration.FieldRepeatSeparator, AmbulatoryStatus.Select(x => x.ToDelimitedString())) : null,
                                VipIndicator?.ToDelimitedString(),
                                AdmittingDoctor != null ? string.Join(Configuration.FieldRepeatSeparator, AdmittingDoctor.Select(x => x.ToDelimitedString())) : null,
                                PatientType?.ToDelimitedString(),
                                VisitNumber?.ToDelimitedString(),
                                FinancialClass != null ? string.Join(Configuration.FieldRepeatSeparator, FinancialClass.Select(x => x.ToDelimitedString())) : null,
                                ChargePriceIndicator?.ToDelimitedString(),
                                CourtesyCode?.ToDelimitedString(),
                                CreditRating?.ToDelimitedString(),
                                ContractCode != null ? string.Join(Configuration.FieldRepeatSeparator, ContractCode.Select(x => x.ToDelimitedString())) : null,
                                ContractEffectiveDate != null ? string.Join(Configuration.FieldRepeatSeparator, ContractEffectiveDate.Select(x => x.ToString(Consts.DateFormatPrecisionDay, culture))) : null,
                                ContractAmount != null ? string.Join(Configuration.FieldRepeatSeparator, ContractAmount.Select(x => x.ToString(Consts.NumericFormat, culture))) : null,
                                ContractPeriod != null ? string.Join(Configuration.FieldRepeatSeparator, ContractPeriod.Select(x => x.ToString(Consts.NumericFormat, culture))) : null,
                                InterestCode?.ToDelimitedString(),
                                TransferToBadDebtCode?.ToDelimitedString(),
                                TransferToBadDebtDate.HasValue ? TransferToBadDebtDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                BadDebtAgencyCode?.ToDelimitedString(),
                                BadDebtTransferAmount.HasValue ? BadDebtTransferAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                BadDebtRecoveryAmount.HasValue ? BadDebtRecoveryAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                DeleteAccountIndicator?.ToDelimitedString(),
                                DeleteAccountDate.HasValue ? DeleteAccountDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                DischargeDisposition?.ToDelimitedString(),
                                DischargedToLocation?.ToDelimitedString(),
                                DietType?.ToDelimitedString(),
                                ServicingFacility?.ToDelimitedString(),
                                BedStatus?.ToDelimitedString(),
                                AccountStatus?.ToDelimitedString(),
                                PendingLocation?.ToDelimitedString(),
                                PriorTemporaryLocation?.ToDelimitedString(),
                                AdmitDateTime.HasValue ? AdmitDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DischargeDateTime.HasValue ? DischargeDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                CurrentPatientBalance.HasValue ? CurrentPatientBalance.Value.ToString(Consts.NumericFormat, culture) : null,
                                TotalCharges.HasValue ? TotalCharges.Value.ToString(Consts.NumericFormat, culture) : null,
                                TotalAdjustments.HasValue ? TotalAdjustments.Value.ToString(Consts.NumericFormat, culture) : null,
                                TotalPayments.HasValue ? TotalPayments.Value.ToString(Consts.NumericFormat, culture) : null,
                                AlternateVisitId != null ? string.Join(Configuration.FieldRepeatSeparator, AlternateVisitId.Select(x => x.ToDelimitedString())) : null,
                                VisitIndicator?.ToDelimitedString(),
                                OtherHealthcareProvider?.ToDelimitedString(),
                                ServiceEpisodeDescription,
                                ServiceEpisodeIdentifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}