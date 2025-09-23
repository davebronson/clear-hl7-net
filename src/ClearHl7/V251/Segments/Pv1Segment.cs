using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PV1 - Patient Visit.
    /// </summary>
    public class Pv1Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pv1Segment"/> class.
        /// </summary>
        public Pv1Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pv1Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Pv1Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PV1";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PV1.1 - Set ID - PV1.
        /// </summary>
        public uint? SetIdPv1 { get; set; }

        /// <summary>
        /// PV1.2 - Patient Class.
        /// <para>Suggested: 0004 Patient Class -&gt; ClearHl7.Codes.V251.CodePatientClass</para>
        /// </summary>
        public string PatientClass { get; set; }

        /// <summary>
        /// PV1.3 - Assigned Patient Location.
        /// </summary>
        public PersonLocation AssignedPatientLocation { get; set; }

        /// <summary>
        /// PV1.4 - Admission Type.
        /// <para>Suggested: 0007 Admission Type -&gt; ClearHl7.Codes.V251.CodeAdmissionType</para>
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
        /// <para>Suggested: 0069 Hospital Service -&gt; ClearHl7.Codes.V251.CodeHospitalService</para>
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
        /// <para>Suggested: 0092 Re-Admission Indicator -&gt; ClearHl7.Codes.V251.CodeReadmissionIndicator</para>
        /// </summary>
        public string ReadmissionIndicator { get; set; }

        /// <summary>
        /// PV1.14 - Admit Source.
        /// <para>Suggested: 0023 Admit Source -&gt; ClearHl7.Codes.V251.CodeAdmitSource</para>
        /// </summary>
        public string AdmitSource { get; set; }

        /// <summary>
        /// PV1.15 - Ambulatory Status.
        /// <para>Suggested: 0009 Ambulatory Status -&gt; ClearHl7.Codes.V251.CodeAmbulatoryStatus</para>
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
        /// <para>Suggested: 0116 Bed Status -&gt; ClearHl7.Codes.V251.CodeBedStatus</para>
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
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V251.CodeIdentifierType</para>
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit AlternateVisitId { get; set; }

        /// <summary>
        /// PV1.51 - Visit Indicator.
        /// <para>Suggested: 0326 Visit Indicator -&gt; ClearHl7.Codes.V251.CodeVisitIndicator</para>
        /// </summary>
        public string VisitIndicator { get; set; }

        /// <summary>
        /// PV1.52 - Other Healthcare Provider.
        /// <para>Suggested: 0010 Physician ID</para>
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons OtherHealthcareProvider { get; set; }

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

            SetIdPv1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            PatientClass = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            AssignedPatientLocation = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[3], false, seps) : null;
            AdmissionType = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            PreadmitNumber = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[5], false, seps) : null;
            PriorPatientLocation = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[6], false, seps) : null;
            AttendingDoctor = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            ReferringDoctor = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            ConsultingDoctor = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            HospitalService = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            TemporaryLocation = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[11], false, seps) : null;
            PreadmitTestIndicator = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            ReadmissionIndicator = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            AdmitSource = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            AmbulatoryStatus = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            VipIndicator = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            AdmittingDoctor = segments.Length > 17 && segments[17].Length > 0 ? segments[17].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            PatientType = segments.Length > 18 && segments[18].Length > 0 ? segments[18] : null;
            VisitNumber = segments.Length > 19 && segments[19].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[19], false, seps) : null;
            FinancialClass = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<FinancialClass>(x, false, seps)) : null;
            ChargePriceIndicator = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            CourtesyCode = segments.Length > 22 && segments[22].Length > 0 ? segments[22] : null;
            CreditRating = segments.Length > 23 && segments[23].Length > 0 ? segments[23] : null;
            ContractCode = segments.Length > 24 && segments[24].Length > 0 ? segments[24].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            ContractEffectiveDate = segments.Length > 25 && segments[25].Length > 0 ? segments[25].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDateTime()) : null;
            ContractAmount = segments.Length > 26 && segments[26].Length > 0 ? segments[26].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDecimal()) : null;
            ContractPeriod = segments.Length > 27 && segments[27].Length > 0 ? segments[27].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDecimal()) : null;
            InterestCode = segments.Length > 28 && segments[28].Length > 0 ? segments[28] : null;
            TransferToBadDebtCode = segments.Length > 29 && segments[29].Length > 0 ? segments[29] : null;
            TransferToBadDebtDate = segments.Length > 30 && segments[30].Length > 0 ? segments[30].ToNullableDateTime() : null;
            BadDebtAgencyCode = segments.Length > 31 && segments[31].Length > 0 ? segments[31] : null;
            BadDebtTransferAmount = segments.Length > 32 && segments[32].Length > 0 ? segments[32].ToNullableDecimal() : null;
            BadDebtRecoveryAmount = segments.Length > 33 && segments[33].Length > 0 ? segments[33].ToNullableDecimal() : null;
            DeleteAccountIndicator = segments.Length > 34 && segments[34].Length > 0 ? segments[34] : null;
            DeleteAccountDate = segments.Length > 35 && segments[35].Length > 0 ? segments[35].ToNullableDateTime() : null;
            DischargeDisposition = segments.Length > 36 && segments[36].Length > 0 ? segments[36] : null;
            DischargedToLocation = segments.Length > 37 && segments[37].Length > 0 ? TypeSerializer.Deserialize<DischargeToLocationAndDate>(segments[37], false, seps) : null;
            DietType = segments.Length > 38 && segments[38].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[38], false, seps) : null;
            ServicingFacility = segments.Length > 39 && segments[39].Length > 0 ? segments[39] : null;
            BedStatus = segments.Length > 40 && segments[40].Length > 0 ? segments[40] : null;
            AccountStatus = segments.Length > 41 && segments[41].Length > 0 ? segments[41] : null;
            PendingLocation = segments.Length > 42 && segments[42].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[42], false, seps) : null;
            PriorTemporaryLocation = segments.Length > 43 && segments[43].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[43], false, seps) : null;
            AdmitDateTime = segments.Length > 44 && segments[44].Length > 0 ? segments[44].ToNullableDateTime() : null;
            DischargeDateTime = segments.Length > 45 && segments[45].Length > 0 ? segments[45].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDateTime()) : null;
            CurrentPatientBalance = segments.Length > 46 && segments[46].Length > 0 ? segments[46].ToNullableDecimal() : null;
            TotalCharges = segments.Length > 47 && segments[47].Length > 0 ? segments[47].ToNullableDecimal() : null;
            TotalAdjustments = segments.Length > 48 && segments[48].Length > 0 ? segments[48].ToNullableDecimal() : null;
            TotalPayments = segments.Length > 49 && segments[49].Length > 0 ? segments[49].ToNullableDecimal() : null;
            AlternateVisitId = segments.Length > 50 && segments[50].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[50], false, seps) : null;
            VisitIndicator = segments.Length > 51 && segments[51].Length > 0 ? segments[51] : null;
            OtherHealthcareProvider = segments.Length > 52 && segments[52].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[52], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
                                TransferToBadDebtDate.ToHl7DateTimeString(typeof(Pv1Segment), nameof(TransferToBadDebtDate), Consts.DateFormatPrecisionDay, culture),
                                BadDebtAgencyCode,
                                BadDebtTransferAmount.HasValue ? BadDebtTransferAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                BadDebtRecoveryAmount.HasValue ? BadDebtRecoveryAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                DeleteAccountIndicator,
                                DeleteAccountDate.ToHl7DateTimeString(typeof(Pv1Segment), nameof(DeleteAccountDate), Consts.DateFormatPrecisionDay, culture),
                                DischargeDisposition,
                                DischargedToLocation?.ToDelimitedString(),
                                DietType?.ToDelimitedString(),
                                ServicingFacility,
                                BedStatus,
                                AccountStatus,
                                PendingLocation?.ToDelimitedString(),
                                PriorTemporaryLocation?.ToDelimitedString(),
                                AdmitDateTime.ToHl7DateTimeString(typeof(Pv1Segment), nameof(AdmitDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                DischargeDateTime != null ? string.Join(Configuration.FieldRepeatSeparator, DischargeDateTime.Select(x => x.ToString(Consts.DateTimeFormatPrecisionSecond, culture))) : null,
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
