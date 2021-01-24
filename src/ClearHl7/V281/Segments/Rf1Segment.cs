using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RF1 - Referral Information.
    /// </summary>
    public class Rf1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RF1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RF1.1 - Referral Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0283</remarks>
        public CodedWithExceptions ReferralStatus { get; set; }

        /// <summary>
        /// RF1.2 - Referral Priority.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0280</remarks>
        public CodedWithExceptions ReferralPriority { get; set; }

        /// <summary>
        /// RF1.3 - Referral Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0281</remarks>
        public CodedWithExceptions ReferralType { get; set; }

        /// <summary>
        /// RF1.4 - Referral Disposition.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0282</remarks>
        public IEnumerable<CodedWithExceptions> ReferralDisposition { get; set; }

        /// <summary>
        /// RF1.5 - Referral Category.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0284</remarks>
        public CodedWithExceptions ReferralCategory { get; set; }

        /// <summary>
        /// RF1.6 - Originating Referral Identifier.
        /// </summary>
        public EntityIdentifier OriginatingReferralIdentifier { get; set; }

        /// <summary>
        /// RF1.7 - Effective Date.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// RF1.8 - Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// RF1.9 - Process Date.
        /// </summary>
        public DateTime? ProcessDate { get; set; }

        /// <summary>
        /// RF1.10 - Referral Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0336</remarks>
        public IEnumerable<CodedWithExceptions> ReferralReason { get; set; }

        /// <summary>
        /// RF1.11 - External Referral Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> ExternalReferralIdentifier { get; set; }

        /// <summary>
        /// RF1.12 - Referral Documentation Completion Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0865</remarks>
        public CodedWithExceptions ReferralDocumentationCompletionStatus { get; set; }

        /// <summary>
        /// RF1.13 - Planned Treatment Stop Date.
        /// </summary>
        public DateTime? PlannedTreatmentStopDate { get; set; }

        /// <summary>
        /// RF1.14 - Referral Reason Text.
        /// </summary>
        public string ReferralReasonText { get; set; }

        /// <summary>
        /// RF1.15 - Number of Authorized Treatments/Units.
        /// </summary>
        public CompositeQuantityWithUnits NumberOfAuthorizedTreatmentsUnits { get; set; }

        /// <summary>
        /// RF1.16 - Number of Used Treatments/Units.
        /// </summary>
        public CompositeQuantityWithUnits NumberOfUsedTreatmentsUnits { get; set; }

        /// <summary>
        /// RF1.17 - Number of Schedule Treatments/Units.
        /// </summary>
        public CompositeQuantityWithUnits NumberOfScheduleTreatmentsUnits { get; set; }

        /// <summary>
        /// RF1.18 - Remaining Benefit Amount.
        /// </summary>
        public Money RemainingBenefitAmount { get; set; }

        /// <summary>
        /// RF1.19 - Authorized Provider.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations AuthorizedProvider { get; set; }

        /// <summary>
        /// RF1.20 - Authorized Health Professional.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons AuthorizedHealthProfessional { get; set; }

        /// <summary>
        /// RF1.21 - Source Text.
        /// </summary>
        public string SourceText { get; set; }

        /// <summary>
        /// RF1.22 - Source Date.
        /// </summary>
        public DateTime? SourceDate { get; set; }

        /// <summary>
        /// RF1.23 - Source Phone.
        /// </summary>
        public ExtendedTelecommunicationNumber SourcePhone { get; set; }

        /// <summary>
        /// RF1.24 - Comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// RF1.25 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 26, Configuration.FieldSeparator),
                                Id,
                                ReferralStatus?.ToDelimitedString(),
                                ReferralPriority?.ToDelimitedString(),
                                ReferralType?.ToDelimitedString(),
                                ReferralDisposition != null ? string.Join(Configuration.FieldRepeatSeparator, ReferralDisposition.Select(x => x.ToDelimitedString())) : null,
                                ReferralCategory?.ToDelimitedString(),
                                OriginatingReferralIdentifier?.ToDelimitedString(),
                                EffectiveDate.HasValue ? EffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpirationDate.HasValue ? ExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProcessDate.HasValue ? ProcessDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReferralReason != null ? string.Join(Configuration.FieldRepeatSeparator, ReferralReason.Select(x => x.ToDelimitedString())) : null,
                                ExternalReferralIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, ExternalReferralIdentifier.Select(x => x.ToDelimitedString())) : null,
                                ReferralDocumentationCompletionStatus?.ToDelimitedString(),
                                PlannedTreatmentStopDate.HasValue ? PlannedTreatmentStopDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReferralReasonText,
                                NumberOfAuthorizedTreatmentsUnits?.ToDelimitedString(),
                                NumberOfUsedTreatmentsUnits?.ToDelimitedString(),
                                NumberOfScheduleTreatmentsUnits?.ToDelimitedString(),
                                RemainingBenefitAmount?.ToDelimitedString(),
                                AuthorizedProvider?.ToDelimitedString(),
                                AuthorizedHealthProfessional?.ToDelimitedString(),
                                SourceText,
                                SourceDate.HasValue ? SourceDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                SourcePhone?.ToDelimitedString(),
                                Comment,
                                ActionCode
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}