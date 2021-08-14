using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
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

        /// <summary>
        /// PV2.1 - Prior Pending Location.
        /// </summary>
        public PersonLocation PriorPendingLocation { get; set; }

        /// <summary>
        /// PV2.2 - Accommodation Code.
        /// <para>Suggested: 0129 Accomodation Code</para>
        /// </summary>
        public CodedWithExceptions AccommodationCode { get; set; }

        /// <summary>
        /// PV2.3 - Admit Reason.
        /// </summary>
        public CodedWithExceptions AdmitReason { get; set; }

        /// <summary>
        /// PV2.4 - Transfer Reason.
        /// </summary>
        public CodedWithExceptions TransferReason { get; set; }

        /// <summary>
        /// PV2.5 - Patient Valuables.
        /// </summary>
        public IEnumerable<string> PatientValuables { get; set; }

        /// <summary>
        /// PV2.6 - Patient Valuables Location.
        /// </summary>
        public string PatientValuablesLocation { get; set; }

        /// <summary>
        /// PV2.7 - Visit User Code.
        /// <para>Suggested: 0130 Visit User Code -&gt; ClearHl7.Codes.V281.CodeVisitUserCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> VisitUserCode { get; set; }

        /// <summary>
        /// PV2.8 - Expected Admit Date/Time.
        /// </summary>
        public DateTime? ExpectedAdmitDateTime { get; set; }

        /// <summary>
        /// PV2.9 - Expected Discharge Date/Time.
        /// </summary>
        public DateTime? ExpectedDischargeDateTime { get; set; }

        /// <summary>
        /// PV2.10 - Estimated Length of Inpatient Stay.
        /// </summary>
        public decimal? EstimatedLengthOfInpatientStay { get; set; }

        /// <summary>
        /// PV2.11 - Actual Length of Inpatient Stay.
        /// </summary>
        public decimal? ActualLengthOfInpatientStay { get; set; }

        /// <summary>
        /// PV2.12 - Visit Description.
        /// </summary>
        public string VisitDescription { get; set; }

        /// <summary>
        /// PV2.13 - Referral Source Code.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ReferralSourceCode { get; set; }

        /// <summary>
        /// PV2.14 - Previous Service Date.
        /// </summary>
        public DateTime? PreviousServiceDate { get; set; }

        /// <summary>
        /// PV2.15 - Employment Illness Related Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string EmploymentIllnessRelatedIndicator { get; set; }

        /// <summary>
        /// PV2.16 - Purge Status Code.
        /// <para>Suggested: 0213 Purge Status Code -&gt; ClearHl7.Codes.V281.CodePurgeStatusCode</para>
        /// </summary>
        public CodedWithExceptions PurgeStatusCode { get; set; }

        /// <summary>
        /// PV2.17 - Purge Status Date.
        /// </summary>
        public DateTime? PurgeStatusDate { get; set; }

        /// <summary>
        /// PV2.18 - Special Program Code.
        /// <para>Suggested: 0214 Special Program Code -&gt; ClearHl7.Codes.V281.CodeSpecialProgramCode</para>
        /// </summary>
        public CodedWithExceptions SpecialProgramCode { get; set; }

        /// <summary>
        /// PV2.19 - Retention Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string RetentionIndicator { get; set; }

        /// <summary>
        /// PV2.20 - Expected Number of Insurance Plans.
        /// </summary>
        public decimal? ExpectedNumberOfInsurancePlans { get; set; }

        /// <summary>
        /// PV2.21 - Visit Publicity Code.
        /// <para>Suggested: 0215 Publicity Code -&gt; ClearHl7.Codes.V281.CodePublicityCode</para>
        /// </summary>
        public CodedWithExceptions VisitPublicityCode { get; set; }

        /// <summary>
        /// PV2.22 - Visit Protection Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string VisitProtectionIndicator { get; set; }

        /// <summary>
        /// PV2.23 - Clinic Organization Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> ClinicOrganizationName { get; set; }

        /// <summary>
        /// PV2.24 - Patient Status Code.
        /// <para>Suggested: 0216 Patient Status Code -&gt; ClearHl7.Codes.V281.CodePatientStatusCode</para>
        /// </summary>
        public CodedWithExceptions PatientStatusCode { get; set; }

        /// <summary>
        /// PV2.25 - Visit Priority Code.
        /// <para>Suggested: 0217 Visit Priority Code -&gt; ClearHl7.Codes.V281.CodeVisitPriorityCode</para>
        /// </summary>
        public CodedWithExceptions VisitPriorityCode { get; set; }

        /// <summary>
        /// PV2.26 - Previous Treatment Date.
        /// </summary>
        public DateTime? PreviousTreatmentDate { get; set; }

        /// <summary>
        /// PV2.27 - Expected Discharge Disposition.
        /// <para>Suggested: 0112 Discharge Disposition</para>
        /// </summary>
        public CodedWithExceptions ExpectedDischargeDisposition { get; set; }

        /// <summary>
        /// PV2.28 - Signature on File Date.
        /// </summary>
        public DateTime? SignatureOnFileDate { get; set; }

        /// <summary>
        /// PV2.29 - First Similar Illness Date.
        /// </summary>
        public DateTime? FirstSimilarIllnessDate { get; set; }

        /// <summary>
        /// PV2.30 - Patient Charge Adjustment Code.
        /// <para>Suggested: 0218 Patient Charge Adjustment</para>
        /// </summary>
        public CodedWithExceptions PatientChargeAdjustmentCode { get; set; }

        /// <summary>
        /// PV2.31 - Recurring Service Code.
        /// <para>Suggested: 0219 Recurring Service Code</para>
        /// </summary>
        public CodedWithExceptions RecurringServiceCode { get; set; }

        /// <summary>
        /// PV2.32 - Billing Media Code.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string BillingMediaCode { get; set; }

        /// <summary>
        /// PV2.33 - Expected Surgery Date and Time.
        /// </summary>
        public DateTime? ExpectedSurgeryDateAndTime { get; set; }

        /// <summary>
        /// PV2.34 - Military Partnership Code.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string MilitaryPartnershipCode { get; set; }

        /// <summary>
        /// PV2.35 - Military Non-Availability Code.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string MilitaryNonAvailabilityCode { get; set; }

        /// <summary>
        /// PV2.36 - Newborn Baby Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string NewbornBabyIndicator { get; set; }

        /// <summary>
        /// PV2.37 - Baby Detained Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string BabyDetainedIndicator { get; set; }

        /// <summary>
        /// PV2.38 - Mode of Arrival Code.
        /// <para>Suggested: 0430 Mode Of Arrival Code -&gt; ClearHl7.Codes.V281.CodeModeOfArrivalCode</para>
        /// </summary>
        public CodedWithExceptions ModeOfArrivalCode { get; set; }

        /// <summary>
        /// PV2.39 - Recreational Drug Use Code.
        /// <para>Suggested: 0431 Recreational Drug Use Code -&gt; ClearHl7.Codes.V281.CodeRecreationalDrugUseCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> RecreationalDrugUseCode { get; set; }

        /// <summary>
        /// PV2.40 - Admission Level of Care Code.
        /// <para>Suggested: 0432 Admission Level Of Care Code -&gt; ClearHl7.Codes.V281.CodeAdmissionLevelOfCareCode</para>
        /// </summary>
        public CodedWithExceptions AdmissionLevelOfCareCode { get; set; }

        /// <summary>
        /// PV2.41 - Precaution Code.
        /// <para>Suggested: 0433 Precaution Code -&gt; ClearHl7.Codes.V281.CodePrecautionCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> PrecautionCode { get; set; }

        /// <summary>
        /// PV2.42 - Patient Condition Code.
        /// <para>Suggested: 0434 Patient Condition Code -&gt; ClearHl7.Codes.V281.CodePatientConditionCode</para>
        /// </summary>
        public CodedWithExceptions PatientConditionCode { get; set; }

        /// <summary>
        /// PV2.43 - Living Will Code.
        /// <para>Suggested: 0315 Living Will Code -&gt; ClearHl7.Codes.V281.CodeLivingWillCode</para>
        /// </summary>
        public CodedWithExceptions LivingWillCode { get; set; }

        /// <summary>
        /// PV2.44 - Organ Donor Code.
        /// <para>Suggested: 0316 Organ Donor Code -&gt; ClearHl7.Codes.V281.CodeOrganDonorCode</para>
        /// </summary>
        public CodedWithExceptions OrganDonorCode { get; set; }

        /// <summary>
        /// PV2.45 - Advance Directive Code.
        /// <para>Suggested: 0435 Advance Directive Code -&gt; ClearHl7.Codes.V281.CodeAdvanceDirectiveCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> AdvanceDirectiveCode { get; set; }

        /// <summary>
        /// PV2.46 - Patient Status Effective Date.
        /// </summary>
        public DateTime? PatientStatusEffectiveDate { get; set; }

        /// <summary>
        /// PV2.47 - Expected LOA Return Date/Time.
        /// </summary>
        public DateTime? ExpectedLoaReturnDateTime { get; set; }

        /// <summary>
        /// PV2.48 - Expected Pre-admission Testing Date/Time.
        /// </summary>
        public DateTime? ExpectedPreAdmissionTestingDateTime { get; set; }

        /// <summary>
        /// PV2.49 - Notify Clergy Code.
        /// <para>Suggested: 0534 Notify Clergy Code -&gt; ClearHl7.Codes.V281.CodeNotifyClergyCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> NotifyClergyCode { get; set; }

        /// <summary>
        /// PV2.50 - Advance Directive Last Verified Date.
        /// </summary>
        public DateTime? AdvanceDirectiveLastVerifiedDate { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
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

            PriorPendingLocation = segments.Length > 1 ? TypeHelper.Deserialize<PersonLocation>(segments.ElementAtOrDefault(1), false) : null;
            AccommodationCode = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            AdmitReason = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            TransferReason = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
            PatientValuables = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator) : null;
            PatientValuablesLocation = segments.ElementAtOrDefault(6);
            VisitUserCode = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ExpectedAdmitDateTime = segments.ElementAtOrDefault(8)?.ToNullableDateTime();
            ExpectedDischargeDateTime = segments.ElementAtOrDefault(9)?.ToNullableDateTime();
            EstimatedLengthOfInpatientStay = segments.ElementAtOrDefault(10)?.ToNullableDecimal();
            ActualLengthOfInpatientStay = segments.ElementAtOrDefault(11)?.ToNullableDecimal();
            VisitDescription = segments.ElementAtOrDefault(12);
            ReferralSourceCode = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            PreviousServiceDate = segments.ElementAtOrDefault(14)?.ToNullableDateTime();
            EmploymentIllnessRelatedIndicator = segments.ElementAtOrDefault(15);
            PurgeStatusCode = segments.Length > 16 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(16), false) : null;
            PurgeStatusDate = segments.ElementAtOrDefault(17)?.ToNullableDateTime();
            SpecialProgramCode = segments.Length > 18 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(18), false) : null;
            RetentionIndicator = segments.ElementAtOrDefault(19);
            ExpectedNumberOfInsurancePlans = segments.ElementAtOrDefault(20)?.ToNullableDecimal();
            VisitPublicityCode = segments.Length > 21 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(21), false) : null;
            VisitProtectionIndicator = segments.ElementAtOrDefault(22);
            ClinicOrganizationName = segments.Length > 23 ? segments.ElementAtOrDefault(23).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            PatientStatusCode = segments.Length > 24 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(24), false) : null;
            VisitPriorityCode = segments.Length > 25 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(25), false) : null;
            PreviousTreatmentDate = segments.ElementAtOrDefault(26)?.ToNullableDateTime();
            ExpectedDischargeDisposition = segments.Length > 27 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(27), false) : null;
            SignatureOnFileDate = segments.ElementAtOrDefault(28)?.ToNullableDateTime();
            FirstSimilarIllnessDate = segments.ElementAtOrDefault(29)?.ToNullableDateTime();
            PatientChargeAdjustmentCode = segments.Length > 30 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(30), false) : null;
            RecurringServiceCode = segments.Length > 31 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(31), false) : null;
            BillingMediaCode = segments.ElementAtOrDefault(32);
            ExpectedSurgeryDateAndTime = segments.ElementAtOrDefault(33)?.ToNullableDateTime();
            MilitaryPartnershipCode = segments.ElementAtOrDefault(34);
            MilitaryNonAvailabilityCode = segments.ElementAtOrDefault(35);
            NewbornBabyIndicator = segments.ElementAtOrDefault(36);
            BabyDetainedIndicator = segments.ElementAtOrDefault(37);
            ModeOfArrivalCode = segments.Length > 38 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(38), false) : null;
            RecreationalDrugUseCode = segments.Length > 39 ? segments.ElementAtOrDefault(39).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            AdmissionLevelOfCareCode = segments.Length > 40 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(40), false) : null;
            PrecautionCode = segments.Length > 41 ? segments.ElementAtOrDefault(41).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PatientConditionCode = segments.Length > 42 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(42), false) : null;
            LivingWillCode = segments.Length > 43 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(43), false) : null;
            OrganDonorCode = segments.Length > 44 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(44), false) : null;
            AdvanceDirectiveCode = segments.Length > 45 ? segments.ElementAtOrDefault(45).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PatientStatusEffectiveDate = segments.ElementAtOrDefault(46)?.ToNullableDateTime();
            ExpectedLoaReturnDateTime = segments.ElementAtOrDefault(47)?.ToNullableDateTime();
            ExpectedPreAdmissionTestingDateTime = segments.ElementAtOrDefault(48)?.ToNullableDateTime();
            NotifyClergyCode = segments.Length > 49 ? segments.ElementAtOrDefault(49).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            AdvanceDirectiveLastVerifiedDate = segments.ElementAtOrDefault(50)?.ToNullableDateTime();
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
                                StringHelper.StringFormatSequence(0, 51, Configuration.FieldSeparator),
                                Id,
                                PriorPendingLocation?.ToDelimitedString(),
                                AccommodationCode?.ToDelimitedString(),
                                AdmitReason?.ToDelimitedString(),
                                TransferReason?.ToDelimitedString(),
                                PatientValuables != null ? string.Join(Configuration.FieldRepeatSeparator, PatientValuables) : null,
                                PatientValuablesLocation,
                                VisitUserCode != null ? string.Join(Configuration.FieldRepeatSeparator, VisitUserCode.Select(x => x.ToDelimitedString())) : null,
                                ExpectedAdmitDateTime.HasValue ? ExpectedAdmitDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpectedDischargeDateTime.HasValue ? ExpectedDischargeDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EstimatedLengthOfInpatientStay.HasValue ? EstimatedLengthOfInpatientStay.Value.ToString(Consts.NumericFormat, culture) : null,
                                ActualLengthOfInpatientStay.HasValue ? ActualLengthOfInpatientStay.Value.ToString(Consts.NumericFormat, culture) : null,
                                VisitDescription,
                                ReferralSourceCode != null ? string.Join(Configuration.FieldRepeatSeparator, ReferralSourceCode.Select(x => x.ToDelimitedString())) : null,
                                PreviousServiceDate.HasValue ? PreviousServiceDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EmploymentIllnessRelatedIndicator,
                                PurgeStatusCode?.ToDelimitedString(),
                                PurgeStatusDate.HasValue ? PurgeStatusDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                SpecialProgramCode?.ToDelimitedString(),
                                RetentionIndicator,
                                ExpectedNumberOfInsurancePlans.HasValue ? ExpectedNumberOfInsurancePlans.Value.ToString(Consts.NumericFormat, culture) : null,
                                VisitPublicityCode?.ToDelimitedString(),
                                VisitProtectionIndicator,
                                ClinicOrganizationName != null ? string.Join(Configuration.FieldRepeatSeparator, ClinicOrganizationName.Select(x => x.ToDelimitedString())) : null,
                                PatientStatusCode?.ToDelimitedString(),
                                VisitPriorityCode?.ToDelimitedString(),
                                PreviousTreatmentDate.HasValue ? PreviousTreatmentDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                ExpectedDischargeDisposition?.ToDelimitedString(),
                                SignatureOnFileDate.HasValue ? SignatureOnFileDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                FirstSimilarIllnessDate.HasValue ? FirstSimilarIllnessDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                PatientChargeAdjustmentCode?.ToDelimitedString(),
                                RecurringServiceCode?.ToDelimitedString(),
                                BillingMediaCode,
                                ExpectedSurgeryDateAndTime.HasValue ? ExpectedSurgeryDateAndTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                MilitaryPartnershipCode,
                                MilitaryNonAvailabilityCode,
                                NewbornBabyIndicator,
                                BabyDetainedIndicator,
                                ModeOfArrivalCode?.ToDelimitedString(),
                                RecreationalDrugUseCode != null ? string.Join(Configuration.FieldRepeatSeparator, RecreationalDrugUseCode.Select(x => x.ToDelimitedString())) : null,
                                AdmissionLevelOfCareCode?.ToDelimitedString(),
                                PrecautionCode != null ? string.Join(Configuration.FieldRepeatSeparator, PrecautionCode.Select(x => x.ToDelimitedString())) : null,
                                PatientConditionCode?.ToDelimitedString(),
                                LivingWillCode?.ToDelimitedString(),
                                OrganDonorCode?.ToDelimitedString(),
                                AdvanceDirectiveCode != null ? string.Join(Configuration.FieldRepeatSeparator, AdvanceDirectiveCode.Select(x => x.ToDelimitedString())) : null,
                                PatientStatusEffectiveDate.HasValue ? PatientStatusEffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                ExpectedLoaReturnDateTime.HasValue ? ExpectedLoaReturnDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpectedPreAdmissionTestingDateTime.HasValue ? ExpectedPreAdmissionTestingDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                NotifyClergyCode != null ? string.Join(Configuration.FieldRepeatSeparator, NotifyClergyCode.Select(x => x.ToDelimitedString())) : null,
                                AdvanceDirectiveLastVerifiedDate.HasValue ? AdvanceDirectiveLastVerifiedDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}