using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PRA - Practitioner Detail.
    /// </summary>
    public class PraSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PraSegment"/> class.
        /// </summary>
        public PraSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PraSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PraSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PRA";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PRA.1 - Primary Key Value - PRA.
        /// </summary>
        public CodedElement PrimaryKeyValuePra { get; set; }

        /// <summary>
        /// PRA.2 - Practitioner Group.
        /// <para>Suggested: 0358 Practitioner Group</para>
        /// </summary>
        public IEnumerable<CodedElement> PractitionerGroup { get; set; }

        /// <summary>
        /// PRA.3 - Practitioner Category.
        /// <para>Suggested: 0186 Practitioner Category</para>
        /// </summary>
        public IEnumerable<string> PractitionerCategory { get; set; }

        /// <summary>
        /// PRA.4 - Provider Billing.
        /// <para>Suggested: 0187 Provider Billing -&gt; ClearHl7.Codes.V250.CodeProviderBilling</para>
        /// </summary>
        public string ProviderBilling { get; set; }

        /// <summary>
        /// PRA.5 - Specialty.
        /// <para>Suggested: 0337 Certification Status -&gt; ClearHl7.Codes.V250.CodeCertificationStatus</para>
        /// </summary>
        public IEnumerable<SpecialtyDescription> Specialty { get; set; }

        /// <summary>
        /// PRA.6 - Practitioner ID Numbers.
        /// <para>Suggested: 0338 Practitioner ID Number Type -&gt; ClearHl7.Codes.V250.CodePractitionerIdNumberType</para>
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
        public CodedElement Institution { get; set; }

        /// <summary>
        /// PRA.10 - Date Left Practice.
        /// </summary>
        public DateTime? DateLeftPractice { get; set; }

        /// <summary>
        /// PRA.11 - Government Reimbursement Billing Eligibility.
        /// <para>Suggested: 0401 Government Reimbursement Program -&gt; ClearHl7.Codes.V250.CodeGovernmentReimbursementProgram</para>
        /// </summary>
        public IEnumerable<CodedElement> GovernmentReimbursementBillingEligibility { get; set; }

        /// <summary>
        /// PRA.12 - Set ID - PRA.
        /// </summary>
        public uint? SetIdPra { get; set; }

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

            PrimaryKeyValuePra = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[1], false, seps) : null;
            PractitionerGroup = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            PractitionerCategory = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            ProviderBilling = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            Specialty = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<SpecialtyDescription>(x, false, seps)) : null;
            PractitionerIdNumbers = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<PractitionerLicenseOrOtherIdNumber>(x, false, seps)) : null;
            Privileges = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<PractitionerInstitutionalPrivileges>(x, false, seps)) : null;
            DateEnteredPractice = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            Institution = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[9], false, seps) : null;
            DateLeftPractice = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDateTime() : null;
            GovernmentReimbursementBillingEligibility = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            SetIdPra = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableUInt() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValuePra?.ToDelimitedString(),
                                PractitionerGroup != null ? string.Join(Configuration.FieldRepeatSeparator, PractitionerGroup.Select(x => x.ToDelimitedString())) : null,
                                PractitionerCategory != null ? string.Join(Configuration.FieldRepeatSeparator, PractitionerCategory) : null,
                                ProviderBilling,
                                Specialty != null ? string.Join(Configuration.FieldRepeatSeparator, Specialty.Select(x => x.ToDelimitedString())) : null,
                                PractitionerIdNumbers != null ? string.Join(Configuration.FieldRepeatSeparator, PractitionerIdNumbers.Select(x => x.ToDelimitedString())) : null,
                                Privileges != null ? string.Join(Configuration.FieldRepeatSeparator, Privileges.Select(x => x.ToDelimitedString())) : null,
                                DateEnteredPractice?.ToHl7DateTimeString(typeof(PraSegment), nameof(DateEnteredPractice), Consts.DateFormatPrecisionDay, culture),
                                Institution?.ToDelimitedString(),
                                DateLeftPractice?.ToHl7DateTimeString(typeof(PraSegment), nameof(DateLeftPractice), Consts.DateFormatPrecisionDay, culture),
                                GovernmentReimbursementBillingEligibility != null ? string.Join(Configuration.FieldRepeatSeparator, GovernmentReimbursementBillingEligibility.Select(x => x.ToDelimitedString())) : null,
                                SetIdPra.HasValue ? SetIdPra.Value.ToString(culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
