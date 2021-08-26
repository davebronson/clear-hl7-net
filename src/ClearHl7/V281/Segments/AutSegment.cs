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
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V281.CodeSegmentActionCode</para>
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            AuthorizingPayorPlanId = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[1], false) : null;
            AuthorizingPayorCompanyId = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[2], false) : null;
            AuthorizingPayorCompanyName = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            AuthorizationEffectiveDate = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDateTime() : null;
            AuthorizationExpirationDate = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            AuthorizationIdentifier = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[6], false) : null;
            ReimbursementLimit = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[7], false) : null;
            RequestedNumberOfTreatments = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments[8], false) : null;
            AuthorizedNumberOfTreatments = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments[9], false) : null;
            ProcessDate = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDateTime() : null;
            RequestedDisciplines = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            AuthorizedDisciplines = segments.Length > 12 && segments[12].Length > 0 ? segments[12].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            AuthorizationReferralType = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[13], false) : null;
            ApprovalStatus = segments.Length > 14 && segments[14].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[14], false) : null;
            PlannedTreatmentStopDate = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDateTime() : null;
            ClinicalService = segments.Length > 16 && segments[16].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[16], false) : null;
            ReasonText = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
            NumberOfAuthorizedTreatmentsUnits = segments.Length > 18 && segments[18].Length > 0 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments[18], false) : null;
            NumberOfUsedTreatmentsUnits = segments.Length > 19 && segments[19].Length > 0 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments[19], false) : null;
            NumberOfScheduleTreatmentsUnits = segments.Length > 20 && segments[20].Length > 0 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments[20], false) : null;
            EncounterType = segments.Length > 21 && segments[21].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[21], false) : null;
            RemainingBenefitAmount = segments.Length > 22 && segments[22].Length > 0 ? TypeHelper.Deserialize<Money>(segments[22], false) : null;
            AuthorizedProvider = segments.Length > 23 && segments[23].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[23], false) : null;
            AuthorizedHealthProfessional = segments.Length > 24 && segments[24].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[24], false) : null;
            SourceText = segments.Length > 25 && segments[25].Length > 0 ? segments[25] : null;
            SourceDate = segments.Length > 26 && segments[26].Length > 0 ? segments[26].ToNullableDateTime() : null;
            SourcePhone = segments.Length > 27 && segments[27].Length > 0 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments[27], false) : null;
            Comment = segments.Length > 28 && segments[28].Length > 0 ? segments[28] : null;
            ActionCode = segments.Length > 29 && segments[29].Length > 0 ? segments[29] : null;
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