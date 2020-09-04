using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// RF1.1 - Referral Status.
        ///// </summary>
        //public ReferralStatus { get; set; }

        ///// <summary>
        ///// RF1.2 - Referral Priority.
        ///// </summary>
        //public ReferralPriority { get; set; }

        ///// <summary>
        ///// RF1.3 - Referral Type.
        ///// </summary>
        //public ReferralType { get; set; }

        ///// <summary>
        ///// RF1.4 - Referral Disposition.
        ///// </summary>
        //public ReferralDisposition { get; set; }

        ///// <summary>
        ///// RF1.5 - Referral Category.
        ///// </summary>
        //public ReferralCategory { get; set; }

        ///// <summary>
        ///// RF1.6 - Originating Referral Identifier.
        ///// </summary>
        //public OriginatingReferralIdentifier { get; set; }

        ///// <summary>
        ///// RF1.7 - Effective Date.
        ///// </summary>
        //public EffectiveDate { get; set; }

        ///// <summary>
        ///// RF1.8 - Expiration Date.
        ///// </summary>
        //public ExpirationDate { get; set; }

        ///// <summary>
        ///// RF1.9 - Process Date.
        ///// </summary>
        //public ProcessDate { get; set; }

        ///// <summary>
        ///// RF1.10 - Referral Reason.
        ///// </summary>
        //public ReferralReason { get; set; }

        ///// <summary>
        ///// RF1.11 - External Referral Identifier.
        ///// </summary>
        //public ExternalReferralIdentifier { get; set; }

        ///// <summary>
        ///// RF1.12 - Referral Documentation Completion Status.
        ///// </summary>
        //public ReferralDocumentationCompletionStatus { get; set; }

        ///// <summary>
        ///// RF1.13 - Planned Treatment Stop Date.
        ///// </summary>
        //public PlannedTreatmentStopDate { get; set; }

        ///// <summary>
        ///// RF1.14 - Referral Reason Text.
        ///// </summary>
        //public ReferralReasonText { get; set; }

        ///// <summary>
        ///// RF1.15 - Number of Authorized Treatments/Units.
        ///// </summary>
        //public NumberOfAuthorizedTreatmentsUnits { get; set; }

        ///// <summary>
        ///// RF1.16 - Number of Used Treatments/Units.
        ///// </summary>
        //public NumberOfUsedTreatmentsUnits { get; set; }

        ///// <summary>
        ///// RF1.17 - Number of Schedule Treatments/Units.
        ///// </summary>
        //public NumberOfScheduleTreatmentsUnits { get; set; }

        ///// <summary>
        ///// RF1.18 - Remaining Benefit Amount.
        ///// </summary>
        //public RemainingBenefitAmount { get; set; }

        ///// <summary>
        ///// RF1.19 - Authorized Provider.
        ///// </summary>
        //public AuthorizedProvider { get; set; }

        ///// <summary>
        ///// RF1.20 - Authorized Health Professional.
        ///// </summary>
        //public AuthorizedHealthProfessional { get; set; }

        ///// <summary>
        ///// RF1.21 - Source Text.
        ///// </summary>
        //public SourceText { get; set; }

        ///// <summary>
        ///// RF1.22 - Source Date.
        ///// </summary>
        //public SourceDate { get; set; }

        ///// <summary>
        ///// RF1.23 - Source Phone.
        ///// </summary>
        //public SourcePhone { get; set; }

        ///// <summary>
        ///// RF1.24 - Comment.
        ///// </summary>
        //public Comment { get; set; }

        ///// <summary>
        ///// RF1.25 - Action Code.
        ///// </summary>
        //public ActionCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}"
                                ).TrimEnd('|');
        }
    }
}