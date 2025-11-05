using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PV2 - Patient Visit - Additional Information.
    /// </summary>
    public class Pv2Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pv2Segment"/> class.
        /// </summary>
        public Pv2Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pv2Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Pv2Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PV2";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PV2.1 - Prior Pending Location.
        /// </summary>
        public PersonLocation PriorPendingLocation { get; set; }

        /// <summary>
        /// PV2.2 - Accommodation Code.
        /// <para>Suggested: 0129 Accomodation Code</para>
        /// </summary>
        public CodedElement AccommodationCode { get; set; }

        /// <summary>
        /// PV2.3 - Admit Reason.
        /// </summary>
        public CodedElement AdmitReason { get; set; }

        /// <summary>
        /// PV2.4 - Transfer Reason.
        /// </summary>
        public CodedElement TransferReason { get; set; }

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
        /// <para>Suggested: 0130 Visit User Code</para>
        /// </summary>
        public string VisitUserCode { get; set; }

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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string EmploymentIllnessRelatedIndicator { get; set; }

        /// <summary>
        /// PV2.16 - Purge Status Code.
        /// <para>Suggested: 0213 Purge Status Code -&gt; ClearHl7.Codes.V231.CodePurgeStatusCode</para>
        /// </summary>
        public string PurgeStatusCode { get; set; }

        /// <summary>
        /// PV2.17 - Purge Status Date.
        /// </summary>
        public DateTime? PurgeStatusDate { get; set; }

        /// <summary>
        /// PV2.18 - Special Program Code.
        /// <para>Suggested: 0214 Special Program Code</para>
        /// </summary>
        public string SpecialProgramCode { get; set; }

        /// <summary>
        /// PV2.19 - Retention Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string RetentionIndicator { get; set; }

        /// <summary>
        /// PV2.20 - Expected Number of Insurance Plans.
        /// </summary>
        public decimal? ExpectedNumberOfInsurancePlans { get; set; }

        /// <summary>
        /// PV2.21 - Visit Publicity Code.
        /// <para>Suggested: 0215 Publicity Code</para>
        /// </summary>
        public string VisitPublicityCode { get; set; }

        /// <summary>
        /// PV2.22 - Visit Protection Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string VisitProtectionIndicator { get; set; }

        /// <summary>
        /// PV2.23 - Clinic Organization Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> ClinicOrganizationName { get; set; }

        /// <summary>
        /// PV2.24 - Patient Status Code.
        /// <para>Suggested: 0216 Patient Status Code</para>
        /// </summary>
        public string PatientStatusCode { get; set; }

        /// <summary>
        /// PV2.25 - Visit Priority Code.
        /// <para>Suggested: 0217 Visit Priority Code</para>
        /// </summary>
        public string VisitPriorityCode { get; set; }

        /// <summary>
        /// PV2.26 - Previous Treatment Date.
        /// </summary>
        public DateTime? PreviousTreatmentDate { get; set; }

        /// <summary>
        /// PV2.27 - Expected Discharge Disposition.
        /// <para>Suggested: 0112 Discharge Disposition</para>
        /// </summary>
        public string ExpectedDischargeDisposition { get; set; }

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
        public CodedElement PatientChargeAdjustmentCode { get; set; }

        /// <summary>
        /// PV2.31 - Recurring Service Code.
        /// <para>Suggested: 0219 Recurring Service Code</para>
        /// </summary>
        public string RecurringServiceCode { get; set; }

        /// <summary>
        /// PV2.32 - Billing Media Code.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string BillingMediaCode { get; set; }

        /// <summary>
        /// PV2.33 - Expected Surgery Date and Time.
        /// </summary>
        public DateTime? ExpectedSurgeryDateAndTime { get; set; }

        /// <summary>
        /// PV2.34 - Military Partnership Code.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string MilitaryPartnershipCode { get; set; }

        /// <summary>
        /// PV2.35 - Military Non-Availability Code.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string MilitaryNonAvailabilityCode { get; set; }

        /// <summary>
        /// PV2.36 - Newborn Baby Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string NewbornBabyIndicator { get; set; }

        /// <summary>
        /// PV2.37 - Baby Detained Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string BabyDetainedIndicator { get; set; }

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

            PriorPendingLocation = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[1], false, seps) : null;
            AccommodationCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[2], false, seps) : null;
            AdmitReason = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], false, seps) : null;
            TransferReason = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[4], false, seps) : null;
            PatientValuables = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            PatientValuablesLocation = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            VisitUserCode = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            ExpectedAdmitDateTime = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            ExpectedDischargeDateTime = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDateTime() : null;
            EstimatedLengthOfInpatientStay = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
            ActualLengthOfInpatientStay = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDecimal() : null;
            VisitDescription = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            ReferralSourceCode = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            PreviousServiceDate = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            EmploymentIllnessRelatedIndicator = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            PurgeStatusCode = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            PurgeStatusDate = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDateTime() : null;
            SpecialProgramCode = segments.Length > 18 && segments[18].Length > 0 ? segments[18] : null;
            RetentionIndicator = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            ExpectedNumberOfInsurancePlans = segments.Length > 20 && segments[20].Length > 0 ? segments[20].ToNullableDecimal() : null;
            VisitPublicityCode = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            VisitProtectionIndicator = segments.Length > 22 && segments[22].Length > 0 ? segments[22] : null;
            ClinicOrganizationName = segments.Length > 23 && segments[23].Length > 0 ? segments[23].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            PatientStatusCode = segments.Length > 24 && segments[24].Length > 0 ? segments[24] : null;
            VisitPriorityCode = segments.Length > 25 && segments[25].Length > 0 ? segments[25] : null;
            PreviousTreatmentDate = segments.Length > 26 && segments[26].Length > 0 ? segments[26].ToNullableDateTime() : null;
            ExpectedDischargeDisposition = segments.Length > 27 && segments[27].Length > 0 ? segments[27] : null;
            SignatureOnFileDate = segments.Length > 28 && segments[28].Length > 0 ? segments[28].ToNullableDateTime() : null;
            FirstSimilarIllnessDate = segments.Length > 29 && segments[29].Length > 0 ? segments[29].ToNullableDateTime() : null;
            PatientChargeAdjustmentCode = segments.Length > 30 && segments[30].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[30], false, seps) : null;
            RecurringServiceCode = segments.Length > 31 && segments[31].Length > 0 ? segments[31] : null;
            BillingMediaCode = segments.Length > 32 && segments[32].Length > 0 ? segments[32] : null;
            ExpectedSurgeryDateAndTime = segments.Length > 33 && segments[33].Length > 0 ? segments[33].ToNullableDateTime() : null;
            MilitaryPartnershipCode = segments.Length > 34 && segments[34].Length > 0 ? segments[34] : null;
            MilitaryNonAvailabilityCode = segments.Length > 35 && segments[35].Length > 0 ? segments[35] : null;
            NewbornBabyIndicator = segments.Length > 36 && segments[36].Length > 0 ? segments[36] : null;
            BabyDetainedIndicator = segments.Length > 37 && segments[37].Length > 0 ? segments[37] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 38, Configuration.FieldSeparator),
                                Id,
                                PriorPendingLocation?.ToDelimitedString(),
                                AccommodationCode?.ToDelimitedString(),
                                AdmitReason?.ToDelimitedString(),
                                TransferReason?.ToDelimitedString(),
                                PatientValuables != null ? string.Join(Configuration.FieldRepeatSeparator, PatientValuables) : null,
                                PatientValuablesLocation,
                                VisitUserCode,
                                ExpectedAdmitDateTime?.ToHl7DateTimeString(typeof(Pv2Segment), nameof(ExpectedAdmitDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ExpectedDischargeDateTime?.ToHl7DateTimeString(typeof(Pv2Segment), nameof(ExpectedDischargeDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EstimatedLengthOfInpatientStay.HasValue ? EstimatedLengthOfInpatientStay.Value.ToString(Consts.NumericFormat, culture) : null,
                                ActualLengthOfInpatientStay.HasValue ? ActualLengthOfInpatientStay.Value.ToString(Consts.NumericFormat, culture) : null,
                                VisitDescription,
                                ReferralSourceCode != null ? string.Join(Configuration.FieldRepeatSeparator, ReferralSourceCode.Select(x => x.ToDelimitedString())) : null,
                                PreviousServiceDate?.ToHl7DateTimeString(typeof(Pv2Segment), nameof(PreviousServiceDate), Consts.DateFormatPrecisionDay, culture),
                                EmploymentIllnessRelatedIndicator,
                                PurgeStatusCode,
                                PurgeStatusDate?.ToHl7DateTimeString(typeof(Pv2Segment), nameof(PurgeStatusDate), Consts.DateFormatPrecisionDay, culture),
                                SpecialProgramCode,
                                RetentionIndicator,
                                ExpectedNumberOfInsurancePlans.HasValue ? ExpectedNumberOfInsurancePlans.Value.ToString(Consts.NumericFormat, culture) : null,
                                VisitPublicityCode,
                                VisitProtectionIndicator,
                                ClinicOrganizationName != null ? string.Join(Configuration.FieldRepeatSeparator, ClinicOrganizationName.Select(x => x.ToDelimitedString())) : null,
                                PatientStatusCode,
                                VisitPriorityCode,
                                PreviousTreatmentDate?.ToHl7DateTimeString(typeof(Pv2Segment), nameof(PreviousTreatmentDate), Consts.DateFormatPrecisionDay, culture),
                                ExpectedDischargeDisposition,
                                SignatureOnFileDate?.ToHl7DateTimeString(typeof(Pv2Segment), nameof(SignatureOnFileDate), Consts.DateFormatPrecisionDay, culture),
                                FirstSimilarIllnessDate?.ToHl7DateTimeString(typeof(Pv2Segment), nameof(FirstSimilarIllnessDate), Consts.DateFormatPrecisionDay, culture),
                                PatientChargeAdjustmentCode?.ToDelimitedString(),
                                RecurringServiceCode,
                                BillingMediaCode,
                                ExpectedSurgeryDateAndTime?.ToHl7DateTimeString(typeof(Pv2Segment), nameof(ExpectedSurgeryDateAndTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                MilitaryPartnershipCode,
                                MilitaryNonAvailabilityCode,
                                NewbornBabyIndicator,
                                BabyDetainedIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
