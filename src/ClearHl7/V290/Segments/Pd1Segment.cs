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
    /// HL7 Version 2 Segment PD1 - Patient Additional Demographic.
    /// </summary>
    public class Pd1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PD1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PD1.1 - Living Dependency.
        /// <para>Suggested: 0223 Living Dependency -&gt; ClearHl7.Codes.V290.CodeLivingDependency</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> LivingDependency { get; set; }

        /// <summary>
        /// PD1.2 - Living Arrangement.
        /// <para>Suggested: 0220 Living Arrangement -&gt; ClearHl7.Codes.V290.CodeLivingArrangement</para>
        /// </summary>
        public CodedWithExceptions LivingArrangement { get; set; }

        /// <summary>
        /// PD1.3 - Patient Primary Facility.
        /// <para>Suggested: 0204 Organizational Name Type -&gt; ClearHl7.Codes.V290.CodeOrganizationalNameType</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> PatientPrimaryFacility { get; set; }

        /// <summary>
        /// PD1.4 - Patient Primary Care Provider Name &amp; ID No..
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons PatientPrimaryCareProviderNameIdNo { get; set; }

        /// <summary>
        /// PD1.5 - Student Indicator.
        /// <para>Suggested: 0231 Student Status -&gt; ClearHl7.Codes.V290.CodeStudentStatus</para>
        /// </summary>
        public CodedWithExceptions StudentIndicator { get; set; }

        /// <summary>
        /// PD1.6 - Handicap.
        /// <para>Suggested: 0295 Handicap</para>
        /// </summary>
        public CodedWithExceptions Handicap { get; set; }

        /// <summary>
        /// PD1.7 - Living Will Code.
        /// <para>Suggested: 0315 Living Will Code -&gt; ClearHl7.Codes.V290.CodeLivingWillCode</para>
        /// </summary>
        public CodedWithExceptions LivingWillCode { get; set; }

        /// <summary>
        /// PD1.8 - Organ Donor Code.
        /// <para>Suggested: 0316 Organ Donor Code -&gt; ClearHl7.Codes.V290.CodeOrganDonorCode</para>
        /// </summary>
        public CodedWithExceptions OrganDonorCode { get; set; }

        /// <summary>
        /// PD1.9 - Separate Bill.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string SeparateBill { get; set; }

        /// <summary>
        /// PD1.10 - Duplicate Patient.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> DuplicatePatient { get; set; }

        /// <summary>
        /// PD1.11 - Publicity Code.
        /// <para>Suggested: 0215 Publicity Code -&gt; ClearHl7.Codes.V290.CodePublicityCode</para>
        /// </summary>
        public CodedWithExceptions PublicityCode { get; set; }

        /// <summary>
        /// PD1.12 - Protection Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string ProtectionIndicator { get; set; }

        /// <summary>
        /// PD1.13 - Protection Indicator Effective Date.
        /// </summary>
        public DateTime? ProtectionIndicatorEffectiveDate { get; set; }

        /// <summary>
        /// PD1.14 - Place of Worship.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> PlaceOfWorship { get; set; }

        /// <summary>
        /// PD1.15 - Advance Directive Code.
        /// <para>Suggested: 0435 Advance Directive Code -&gt; ClearHl7.Codes.V290.CodeAdvanceDirectiveCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> AdvanceDirectiveCode { get; set; }

        /// <summary>
        /// PD1.16 - Immunization Registry Status.
        /// <para>Suggested: 0441 Immunization Registry Status -&gt; ClearHl7.Codes.V290.CodeImmunizationRegistryStatus</para>
        /// </summary>
        public CodedWithExceptions ImmunizationRegistryStatus { get; set; }

        /// <summary>
        /// PD1.17 - Immunization Registry Status Effective Date.
        /// </summary>
        public DateTime? ImmunizationRegistryStatusEffectiveDate { get; set; }

        /// <summary>
        /// PD1.18 - Publicity Code Effective Date.
        /// </summary>
        public DateTime? PublicityCodeEffectiveDate { get; set; }

        /// <summary>
        /// PD1.19 - Military Branch.
        /// <para>Suggested: 0140 Military Service -&gt; ClearHl7.Codes.V290.CodeMilitaryService</para>
        /// </summary>
        public CodedWithExceptions MilitaryBranch { get; set; }

        /// <summary>
        /// PD1.20 - Military Rank/Grade.
        /// <para>Suggested: 0141 Military Rank/Grade</para>
        /// </summary>
        public CodedWithExceptions MilitaryRankGrade { get; set; }

        /// <summary>
        /// PD1.21 - Military Status.
        /// <para>Suggested: 0142 Military Status -&gt; ClearHl7.Codes.V290.CodeMilitaryStatus</para>
        /// </summary>
        public CodedWithExceptions MilitaryStatus { get; set; }

        /// <summary>
        /// PD1.22 - Advance Directive Last Verified Date.
        /// </summary>
        public DateTime? AdvanceDirectiveLastVerifiedDate { get; set; }

        /// <summary>
        /// PD1.23 - Retirement Date.
        /// </summary>
        public DateTime? RetirementDate { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public Pd1Segment FromDelimitedString(string delimitedString)
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

            LivingDependency = segments.Length > 1 ? segments.ElementAtOrDefault(1).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            LivingArrangement = segments.Length > 2 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            PatientPrimaryFacility = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(x)) : null;
            PatientPrimaryCareProviderNameIdNo = segments.Length > 4 ? new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            StudentIndicator = segments.Length > 5 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            Handicap = segments.Length > 6 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            LivingWillCode = segments.Length > 7 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(7)) : null;
            OrganDonorCode = segments.Length > 8 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            SeparateBill = segments.ElementAtOrDefault(9);
            DuplicatePatient = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator).Select(x => new ExtendedCompositeIdWithCheckDigit().FromDelimitedString(x)) : null;
            PublicityCode = segments.Length > 11 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            ProtectionIndicator = segments.ElementAtOrDefault(12);
            ProtectionIndicatorEffectiveDate = segments.ElementAtOrDefault(13)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            PlaceOfWorship = segments.Length > 14 ? segments.ElementAtOrDefault(14).Split(separator).Select(x => new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(x)) : null;
            AdvanceDirectiveCode = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator).Select(x => new CodedWithExceptions().FromDelimitedString(x)) : null;
            ImmunizationRegistryStatus = segments.Length > 16 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(16)) : null;
            ImmunizationRegistryStatusEffectiveDate = segments.ElementAtOrDefault(17)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            PublicityCodeEffectiveDate = segments.ElementAtOrDefault(18)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            MilitaryBranch = segments.Length > 19 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(19)) : null;
            MilitaryRankGrade = segments.Length > 20 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(20)) : null;
            MilitaryStatus = segments.Length > 21 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(21)) : null;
            AdvanceDirectiveLastVerifiedDate = segments.ElementAtOrDefault(22)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            RetirementDate = segments.ElementAtOrDefault(23)?.ToNullableDateTime(Consts.DateFormatPrecisionDay);
            
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
                                StringHelper.StringFormatSequence(0, 24, Configuration.FieldSeparator),
                                Id,
                                LivingDependency != null ? string.Join(Configuration.FieldRepeatSeparator, LivingDependency.Select(x => x.ToDelimitedString())) : null,
                                LivingArrangement?.ToDelimitedString(),
                                PatientPrimaryFacility != null ? string.Join(Configuration.FieldRepeatSeparator, PatientPrimaryFacility.Select(x => x.ToDelimitedString())) : null,
                                PatientPrimaryCareProviderNameIdNo?.ToDelimitedString(),
                                StudentIndicator?.ToDelimitedString(),
                                Handicap?.ToDelimitedString(),
                                LivingWillCode?.ToDelimitedString(),
                                OrganDonorCode?.ToDelimitedString(),
                                SeparateBill,
                                DuplicatePatient != null ? string.Join(Configuration.FieldRepeatSeparator, DuplicatePatient.Select(x => x.ToDelimitedString())) : null,
                                PublicityCode?.ToDelimitedString(),
                                ProtectionIndicator,
                                ProtectionIndicatorEffectiveDate.HasValue ? ProtectionIndicatorEffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                PlaceOfWorship != null ? string.Join(Configuration.FieldRepeatSeparator, PlaceOfWorship.Select(x => x.ToDelimitedString())) : null,
                                AdvanceDirectiveCode != null ? string.Join(Configuration.FieldRepeatSeparator, AdvanceDirectiveCode.Select(x => x.ToDelimitedString())) : null,
                                ImmunizationRegistryStatus?.ToDelimitedString(),
                                ImmunizationRegistryStatusEffectiveDate.HasValue ? ImmunizationRegistryStatusEffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                PublicityCodeEffectiveDate.HasValue ? PublicityCodeEffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                MilitaryBranch?.ToDelimitedString(),
                                MilitaryRankGrade?.ToDelimitedString(),
                                MilitaryStatus?.ToDelimitedString(),
                                AdvanceDirectiveLastVerifiedDate.HasValue ? AdvanceDirectiveLastVerifiedDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                RetirementDate.HasValue ? RetirementDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}