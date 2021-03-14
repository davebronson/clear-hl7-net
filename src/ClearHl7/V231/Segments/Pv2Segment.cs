using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
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

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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
                                ExpectedAdmitDateTime.HasValue ? ExpectedAdmitDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpectedDischargeDateTime.HasValue ? ExpectedDischargeDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EstimatedLengthOfInpatientStay.HasValue ? EstimatedLengthOfInpatientStay.Value.ToString(Consts.NumericFormat, culture) : null,
                                ActualLengthOfInpatientStay.HasValue ? ActualLengthOfInpatientStay.Value.ToString(Consts.NumericFormat, culture) : null,
                                VisitDescription,
                                ReferralSourceCode != null ? string.Join(Configuration.FieldRepeatSeparator, ReferralSourceCode.Select(x => x.ToDelimitedString())) : null,
                                PreviousServiceDate.HasValue ? PreviousServiceDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                EmploymentIllnessRelatedIndicator,
                                PurgeStatusCode,
                                PurgeStatusDate.HasValue ? PurgeStatusDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                SpecialProgramCode,
                                RetentionIndicator,
                                ExpectedNumberOfInsurancePlans.HasValue ? ExpectedNumberOfInsurancePlans.Value.ToString(Consts.NumericFormat, culture) : null,
                                VisitPublicityCode,
                                VisitProtectionIndicator,
                                ClinicOrganizationName != null ? string.Join(Configuration.FieldRepeatSeparator, ClinicOrganizationName.Select(x => x.ToDelimitedString())) : null,
                                PatientStatusCode,
                                VisitPriorityCode,
                                PreviousTreatmentDate.HasValue ? PreviousTreatmentDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                ExpectedDischargeDisposition,
                                SignatureOnFileDate.HasValue ? SignatureOnFileDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                FirstSimilarIllnessDate.HasValue ? FirstSimilarIllnessDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                PatientChargeAdjustmentCode?.ToDelimitedString(),
                                RecurringServiceCode,
                                BillingMediaCode,
                                ExpectedSurgeryDateAndTime.HasValue ? ExpectedSurgeryDateAndTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                MilitaryPartnershipCode,
                                MilitaryNonAvailabilityCode,
                                NewbornBabyIndicator,
                                BabyDetainedIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}