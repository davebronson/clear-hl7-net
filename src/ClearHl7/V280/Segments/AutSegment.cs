using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment AUT - Authorization Information.
    /// </summary>
    public class AutSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "AUT";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// AUT.1 - Authorizing Payor, Plan ID.
        /// <para>Suggested: 0072 Insurance Plan ID</para>
        /// </summary>
        public CodedWithExceptions AuthorizingPayorPlanId { get; set; }

        /// <summary>
        /// AUT.2 - Authorizing Payor, Company ID.
        /// <para>Suggested: 0285 Insurance Company ID Codes</para>
        /// </summary>
        public CodedWithExceptions AuthorizingPayorCompanyId { get; set; }

        /// <summary>
        /// AUT.3 - Authorizing Payor, Company Name.
        /// </summary>
        public string AuthorizingPayorCompanyName { get; set; }

        /// <summary>
        /// AUT.4 - Authorization Effective Date.
        /// </summary>
        public DateTime? AuthorizationEffectiveDate { get; set; }

        /// <summary>
        /// AUT.5 - Authorization Expiration Date.
        /// </summary>
        public DateTime? AuthorizationExpirationDate { get; set; }

        /// <summary>
        /// AUT.6 - Authorization Identifier.
        /// </summary>
        public EntityIdentifier AuthorizationIdentifier { get; set; }

        /// <summary>
        /// AUT.7 - Reimbursement Limit.
        /// </summary>
        public CompositePrice ReimbursementLimit { get; set; }

        /// <summary>
        /// AUT.8 - Requested Number of Treatments.
        /// </summary>
        public CompositeQuantityWithUnits RequestedNumberOfTreatments { get; set; }

        /// <summary>
        /// AUT.9 - Authorized Number of Treatments.
        /// </summary>
        public CompositeQuantityWithUnits AuthorizedNumberOfTreatments { get; set; }

        /// <summary>
        /// AUT.10 - Process Date.
        /// </summary>
        public DateTime? ProcessDate { get; set; }

        /// <summary>
        /// AUT.11 - Requested Discipline(s).
        /// </summary>
        public IEnumerable<CodedWithExceptions> RequestedDisciplines { get; set; }

        /// <summary>
        /// AUT.12 - Authorized Discipline(s).
        /// </summary>
        public IEnumerable<CodedWithExceptions> AuthorizedDisciplines { get; set; }

        /// <summary>
        /// AUT.13 - Authorization Referral Type.
        /// </summary>
        public CodedWithExceptions AuthorizationReferralType { get; set; }

        /// <summary>
        /// AUT.14 - Approval Status.
        /// </summary>
        public CodedWithExceptions ApprovalStatus { get; set; }

        /// <summary>
        /// AUT.15 - Planned Treatment Stop Date.
        /// </summary>
        public DateTime? PlannedTreatmentStopDate { get; set; }

        /// <summary>
        /// AUT.16 - Clinical Service.
        /// </summary>
        public CodedWithExceptions ClinicalService { get; set; }

        /// <summary>
        /// AUT.17 - Reason Text.
        /// </summary>
        public string ReasonText { get; set; }

        /// <summary>
        /// AUT.18 - Number of Authorized Treatments/Units.
        /// </summary>
        public CompositeQuantityWithUnits NumberOfAuthorizedTreatmentsUnits { get; set; }

        /// <summary>
        /// AUT.19 - Number of Used Treatments/Units.
        /// </summary>
        public CompositeQuantityWithUnits NumberOfUsedTreatmentsUnits { get; set; }

        /// <summary>
        /// AUT.20 - Number of Schedule Treatments/Units.
        /// </summary>
        public CompositeQuantityWithUnits NumberOfScheduleTreatmentsUnits { get; set; }

        /// <summary>
        /// AUT.21 - Encounter Type.
        /// </summary>
        public CodedWithExceptions EncounterType { get; set; }

        /// <summary>
        /// AUT.22 - Remaining Benefit Amount.
        /// </summary>
        public Money RemainingBenefitAmount { get; set; }

        /// <summary>
        /// AUT.23 - Authorized Provider.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations AuthorizedProvider { get; set; }

        /// <summary>
        /// AUT.24 - Authorized Health Professional.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons AuthorizedHealthProfessional { get; set; }

        /// <summary>
        /// AUT.25 - Source Text.
        /// </summary>
        public string SourceText { get; set; }

        /// <summary>
        /// AUT.26 - Source Date.
        /// </summary>
        public DateTime? SourceDate { get; set; }

        /// <summary>
        /// AUT.27 - Source Phone.
        /// </summary>
        public ExtendedTelecommunicationNumber SourcePhone { get; set; }

        /// <summary>
        /// AUT.28 - Comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// AUT.29 - Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V280.CodeSegmentActionCode</para>
        /// </summary>
        public string ActionCode { get; set; }

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

            AuthorizingPayorPlanId = segments.Length > 1 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(1), false) : null;
            AuthorizingPayorCompanyId = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            AuthorizingPayorCompanyName = segments.ElementAtOrDefault(3);
            AuthorizationEffectiveDate = segments.ElementAtOrDefault(4)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            AuthorizationExpirationDate = segments.ElementAtOrDefault(5)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            AuthorizationIdentifier = segments.Length > 6 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(6), false) : null;
            ReimbursementLimit = segments.Length > 7 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(7), false) : null;
            RequestedNumberOfTreatments = segments.Length > 8 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(8), false) : null;
            AuthorizedNumberOfTreatments = segments.Length > 9 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(9), false) : null;
            ProcessDate = segments.ElementAtOrDefault(10)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            RequestedDisciplines = segments.Length > 11 ? segments.ElementAtOrDefault(11).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            AuthorizedDisciplines = segments.Length > 12 ? segments.ElementAtOrDefault(12).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            AuthorizationReferralType = segments.Length > 13 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(13), false) : null;
            ApprovalStatus = segments.Length > 14 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(14), false) : null;
            PlannedTreatmentStopDate = segments.ElementAtOrDefault(15)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ClinicalService = segments.Length > 16 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(16), false) : null;
            ReasonText = segments.ElementAtOrDefault(17);
            NumberOfAuthorizedTreatmentsUnits = segments.Length > 18 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(18), false) : null;
            NumberOfUsedTreatmentsUnits = segments.Length > 19 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(19), false) : null;
            NumberOfScheduleTreatmentsUnits = segments.Length > 20 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(20), false) : null;
            EncounterType = segments.Length > 21 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(21), false) : null;
            RemainingBenefitAmount = segments.Length > 22 ? TypeHelper.Deserialize<Money>(segments.ElementAtOrDefault(22), false) : null;
            AuthorizedProvider = segments.Length > 23 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(23), false) : null;
            AuthorizedHealthProfessional = segments.Length > 24 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(24), false) : null;
            SourceText = segments.ElementAtOrDefault(25);
            SourceDate = segments.ElementAtOrDefault(26)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            SourcePhone = segments.Length > 27 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments.ElementAtOrDefault(27), false) : null;
            Comment = segments.ElementAtOrDefault(28);
            ActionCode = segments.ElementAtOrDefault(29);
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
                                StringHelper.StringFormatSequence(0, 30, Configuration.FieldSeparator),
                                Id,
                                AuthorizingPayorPlanId?.ToDelimitedString(),
                                AuthorizingPayorCompanyId?.ToDelimitedString(),
                                AuthorizingPayorCompanyName,
                                AuthorizationEffectiveDate.HasValue ? AuthorizationEffectiveDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AuthorizationExpirationDate.HasValue ? AuthorizationExpirationDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AuthorizationIdentifier?.ToDelimitedString(),
                                ReimbursementLimit?.ToDelimitedString(),
                                RequestedNumberOfTreatments?.ToDelimitedString(),
                                AuthorizedNumberOfTreatments?.ToDelimitedString(),
                                ProcessDate.HasValue ? ProcessDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                RequestedDisciplines != null ? string.Join(Configuration.FieldRepeatSeparator, RequestedDisciplines.Select(x => x.ToDelimitedString())) : null,
                                AuthorizedDisciplines != null ? string.Join(Configuration.FieldRepeatSeparator, AuthorizedDisciplines.Select(x => x.ToDelimitedString())) : null,
                                AuthorizationReferralType?.ToDelimitedString(),
                                ApprovalStatus?.ToDelimitedString(),
                                PlannedTreatmentStopDate.HasValue ? PlannedTreatmentStopDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ClinicalService?.ToDelimitedString(),
                                ReasonText,
                                NumberOfAuthorizedTreatmentsUnits?.ToDelimitedString(),
                                NumberOfUsedTreatmentsUnits?.ToDelimitedString(),
                                NumberOfScheduleTreatmentsUnits?.ToDelimitedString(),
                                EncounterType?.ToDelimitedString(),
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