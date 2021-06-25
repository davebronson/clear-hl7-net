﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0681 Primary Key Value - PRA</para>
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
        /// <para>Suggested: 0187 Provider Billing -&gt; ClearHl7.Codes.V290.CodeProviderBilling</para>
        /// </summary>
        public string ProviderBilling { get; set; }

        /// <summary>
        /// PRA.5 - Specialty.
        /// <para>Suggested: 0337 Certification Status -&gt; ClearHl7.Codes.V290.CodeCertificationStatus</para>
        /// </summary>
        public IEnumerable<SpecialtyDescription> Specialty { get; set; }

        /// <summary>
        /// PRA.6 - Practitioner ID Numbers.
        /// <para>Suggested: 0338 Practitioner ID Number Type -&gt; ClearHl7.Codes.V290.CodePractitionerIdNumberType</para>
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
        /// <para>Suggested: 0401 Government Reimbursement Program -&gt; ClearHl7.Codes.V290.CodeGovernmentReimbursementProgram</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> GovernmentReimbursementBillingEligibility { get; set; }

        /// <summary>
        /// PRA.12 - Set ID - PRA.
        /// </summary>
        public uint? SetIdPra { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public PraSegment FromDelimitedString(string delimitedString)
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

            PrimaryKeyValuePra = segments.Length > 1 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(1)) : null;
            PractitionerGroup = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            PractitionerCategory = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            ProviderBilling = segments.ElementAtOrDefault(4);
            Specialty = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => new SpecialtyDescription().FromDelimitedString(x)) : null;
            PractitionerIdNumbers = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator).Select(x => new PractitionerLicenseOrOtherIdNumber().FromDelimitedString(x)) : null;
            Privileges = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => new PractitionerInstitutionalPrivileges().FromDelimitedString(x)) : null;
            DateEnteredPractice = segments.ElementAtOrDefault(8)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            Institution = segments.Length > 9 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(9)) : null;
            DateLeftPractice = segments.ElementAtOrDefault(10)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            GovernmentReimbursementBillingEligibility = segments.Length > 11 ? segments.ElementAtOrDefault(11).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            SetIdPra = segments.ElementAtOrDefault(12)?.ToNullableUInt();
            
            return this;
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