﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0129</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0130</remarks>
        public IEnumerable<string> VisitUserCode { get; set; }

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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string EmploymentIllnessRelatedIndicator { get; set; }

        /// <summary>
        /// PV2.16 - Purge Status Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0213</remarks>
        public string PurgeStatusCode { get; set; }

        /// <summary>
        /// PV2.17 - Purge Status Date.
        /// </summary>
        public DateTime? PurgeStatusDate { get; set; }

        /// <summary>
        /// PV2.18 - Special Program Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0214</remarks>
        public string SpecialProgramCode { get; set; }

        /// <summary>
        /// PV2.19 - Retention Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string RetentionIndicator { get; set; }

        /// <summary>
        /// PV2.20 - Expected Number of Insurance Plans.
        /// </summary>
        public decimal? ExpectedNumberOfInsurancePlans { get; set; }

        /// <summary>
        /// PV2.21 - Visit Publicity Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0215</remarks>
        public string VisitPublicityCode { get; set; }

        /// <summary>
        /// PV2.22 - Visit Protection Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string VisitProtectionIndicator { get; set; }

        /// <summary>
        /// PV2.23 - Clinic Organization Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> ClinicOrganizationName { get; set; }

        /// <summary>
        /// PV2.24 - Patient Status Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0216</remarks>
        public string PatientStatusCode { get; set; }

        /// <summary>
        /// PV2.25 - Visit Priority Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0217</remarks>
        public string VisitPriorityCode { get; set; }

        /// <summary>
        /// PV2.26 - Previous Treatment Date.
        /// </summary>
        public DateTime? PreviousTreatmentDate { get; set; }

        /// <summary>
        /// PV2.27 - Expected Discharge Disposition.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0112</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0218</remarks>
        public CodedElement PatientChargeAdjustmentCode { get; set; }

        /// <summary>
        /// PV2.31 - Recurring Service Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0219</remarks>
        public string RecurringServiceCode { get; set; }

        /// <summary>
        /// PV2.32 - Billing Media Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string BillingMediaCode { get; set; }

        /// <summary>
        /// PV2.33 - Expected Surgery Date and Time.
        /// </summary>
        public DateTime? ExpectedSurgeryDateAndTime { get; set; }

        /// <summary>
        /// PV2.34 - Military Partnership Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string MilitaryPartnershipCode { get; set; }

        /// <summary>
        /// PV2.35 - Military Non-Availability Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string MilitaryNonAvailabilityCode { get; set; }

        /// <summary>
        /// PV2.36 - Newborn Baby Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string NewbornBabyIndicator { get; set; }

        /// <summary>
        /// PV2.37 - Baby Detained Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string BabyDetainedIndicator { get; set; }

        /// <summary>
        /// PV2.38 - Mode of Arrival Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0430</remarks>
        public CodedElement ModeOfArrivalCode { get; set; }

        /// <summary>
        /// PV2.39 - Recreational Drug Use Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0431</remarks>
        public IEnumerable<CodedElement> RecreationalDrugUseCode { get; set; }

        /// <summary>
        /// PV2.40 - Admission Level of Care Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0432</remarks>
        public CodedElement AdmissionLevelOfCareCode { get; set; }

        /// <summary>
        /// PV2.41 - Precaution Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0433</remarks>
        public IEnumerable<CodedElement> PrecautionCode { get; set; }

        /// <summary>
        /// PV2.42 - Patient Condition Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0434</remarks>
        public CodedElement PatientConditionCode { get; set; }

        /// <summary>
        /// PV2.43 - Living Will Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0315</remarks>
        public string LivingWillCode { get; set; }

        /// <summary>
        /// PV2.44 - Organ Donor Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0316</remarks>
        public string OrganDonorCode { get; set; }

        /// <summary>
        /// PV2.45 - Advance Directive Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0435</remarks>
        public IEnumerable<CodedElement> AdvanceDirectiveCode { get; set; }

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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0534</remarks>
        public IEnumerable<string> NotifyClergyCode { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 50, Configuration.FieldSeparator),
                                Id,
                                PriorPendingLocation?.ToDelimitedString(),
                                AccommodationCode?.ToDelimitedString(),
                                AdmitReason?.ToDelimitedString(),
                                TransferReason?.ToDelimitedString(),
                                PatientValuables != null ? string.Join(Configuration.FieldRepeatSeparator, PatientValuables) : null,
                                PatientValuablesLocation,
                                VisitUserCode != null ? string.Join(Configuration.FieldRepeatSeparator, VisitUserCode) : null,
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
                                BabyDetainedIndicator,
                                ModeOfArrivalCode?.ToDelimitedString(),
                                RecreationalDrugUseCode != null ? string.Join(Configuration.FieldRepeatSeparator, RecreationalDrugUseCode.Select(x => x.ToDelimitedString())) : null,
                                AdmissionLevelOfCareCode?.ToDelimitedString(),
                                PrecautionCode != null ? string.Join(Configuration.FieldRepeatSeparator, PrecautionCode.Select(x => x.ToDelimitedString())) : null,
                                PatientConditionCode?.ToDelimitedString(),
                                LivingWillCode,
                                OrganDonorCode,
                                AdvanceDirectiveCode != null ? string.Join(Configuration.FieldRepeatSeparator, AdvanceDirectiveCode.Select(x => x.ToDelimitedString())) : null,
                                PatientStatusEffectiveDate.HasValue ? PatientStatusEffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                ExpectedLoaReturnDateTime.HasValue ? ExpectedLoaReturnDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpectedPreAdmissionTestingDateTime.HasValue ? ExpectedPreAdmissionTestingDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                NotifyClergyCode != null ? string.Join(Configuration.FieldRepeatSeparator, NotifyClergyCode) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}