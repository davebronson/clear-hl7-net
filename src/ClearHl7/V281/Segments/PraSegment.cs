using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PRA - Practitioner Detail.
    /// </summary>
    public class PraSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PRA";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PRA.1 - Primary Key Value - PRA.
        /// </summary>
        public CodedWithExceptions PrimaryKeyValuePra { get; set; }

        /// <summary>
        /// PRA.2 - Practitioner Group.
        /// <para>Suggested: 0358 Practitioner Group</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> PractitionerGroup { get; set; }

        /// <summary>
        /// PRA.3 - Practitioner Category.
        /// <para>Suggested: 0186 Practitioner Category</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> PractitionerCategory { get; set; }

        /// <summary>
        /// PRA.4 - Provider Billing.
        /// <para>Suggested: 0187 Provider Billing -&gt; ClearHl7.Codes.V281.CodeProviderBilling</para>
        /// </summary>
        public string ProviderBilling { get; set; }

        /// <summary>
        /// PRA.5 - Specialty.
        /// <para>Suggested: 0337 Certification Status -&gt; ClearHl7.Codes.V281.CodeCertificationStatus</para>
        /// </summary>
        public IEnumerable<SpecialtyDescription> Specialty { get; set; }

        /// <summary>
        /// PRA.6 - Practitioner ID Numbers.
        /// <para>Suggested: 0338 Practitioner ID Number Type -&gt; ClearHl7.Codes.V281.CodePractitionerIdNumberType</para>
        /// </summary>
        public IEnumerable<PractitionerLicenseOrOtherIdNumber> PractitionerIdNumbers { get; set; }

        /// <summary>
        /// PRA.7 - Privileges.
        /// </summary>
        public IEnumerable<PractitionerInstitutionalPrivileges> Privileges { get; set; }

        /// <summary>
        /// PRA.8 - Date Entered Practice.
        /// </summary>
        public DateTime? DateEnteredPractice { get; set; }

        /// <summary>
        /// PRA.9 - Institution.
        /// <para>Suggested: 0537 Institution</para>
        /// </summary>
        public CodedWithExceptions Institution { get; set; }

        /// <summary>
        /// PRA.10 - Date Left Practice.
        /// </summary>
        public DateTime? DateLeftPractice { get; set; }

        /// <summary>
        /// PRA.11 - Government Reimbursement Billing Eligibility.
        /// <para>Suggested: 0401 Government Reimbursement Program -&gt; ClearHl7.Codes.V281.CodeGovernmentReimbursementProgram</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> GovernmentReimbursementBillingEligibility { get; set; }

        /// <summary>
        /// PRA.12 - Set ID - PRA.
        /// </summary>
        public uint? SetIdPra { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValuePra?.ToDelimitedString(),
                                PractitionerGroup != null ? string.Join(Configuration.FieldRepeatSeparator, PractitionerGroup.Select(x => x.ToDelimitedString())) : null,
                                PractitionerCategory != null ? string.Join(Configuration.FieldRepeatSeparator, PractitionerCategory.Select(x => x.ToDelimitedString())) : null,
                                ProviderBilling,
                                Specialty != null ? string.Join(Configuration.FieldRepeatSeparator, Specialty.Select(x => x.ToDelimitedString())) : null,
                                PractitionerIdNumbers != null ? string.Join(Configuration.FieldRepeatSeparator, PractitionerIdNumbers.Select(x => x.ToDelimitedString())) : null,
                                Privileges != null ? string.Join(Configuration.FieldRepeatSeparator, Privileges.Select(x => x.ToDelimitedString())) : null,
                                DateEnteredPractice.HasValue ? DateEnteredPractice.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                Institution?.ToDelimitedString(),
                                DateLeftPractice.HasValue ? DateLeftPractice.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                GovernmentReimbursementBillingEligibility != null ? string.Join(Configuration.FieldRepeatSeparator, GovernmentReimbursementBillingEligibility.Select(x => x.ToDelimitedString())) : null,
                                SetIdPra.HasValue ? SetIdPra.Value.ToString(culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}