using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
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
        /// <para>Suggested: 0223 Living Dependency -&gt; ClearHl7.Codes.V271.CodeLivingDependency</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> LivingDependency { get; set; }

        /// <summary>
        /// PD1.2 - Living Arrangement.
        /// <para>Suggested: 0220 Living Arrangement -&gt; ClearHl7.Codes.V271.CodeLivingArrangement</para>
        /// </summary>
        public CodedWithExceptions LivingArrangement { get; set; }

        /// <summary>
        /// PD1.3 - Patient Primary Facility.
        /// <para>Suggested: 0204 Organizational Name Type -&gt; ClearHl7.Codes.V271.CodeOrganizationalNameType</para>
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> PatientPrimaryFacility { get; set; }

        /// <summary>
        /// PD1.4 - Patient Primary Care Provider Name &amp; ID No..
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons PatientPrimaryCareProviderNameIdNo { get; set; }

        /// <summary>
        /// PD1.5 - Student Indicator.
        /// <para>Suggested: 0231 Student Status -&gt; ClearHl7.Codes.V271.CodeStudentStatus</para>
        /// </summary>
        public CodedWithExceptions StudentIndicator { get; set; }

        /// <summary>
        /// PD1.6 - Handicap.
        /// <para>Suggested: 0295 Handicap</para>
        /// </summary>
        public CodedWithExceptions Handicap { get; set; }

        /// <summary>
        /// PD1.7 - Living Will Code.
        /// <para>Suggested: 0315 Living Will Code -&gt; ClearHl7.Codes.V271.CodeLivingWillCode</para>
        /// </summary>
        public CodedWithExceptions LivingWillCode { get; set; }

        /// <summary>
        /// PD1.8 - Organ Donor Code.
        /// <para>Suggested: 0316 Organ Donor Code -&gt; ClearHl7.Codes.V271.CodeOrganDonorCode</para>
        /// </summary>
        public CodedWithExceptions OrganDonorCode { get; set; }

        /// <summary>
        /// PD1.9 - Separate Bill.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string SeparateBill { get; set; }

        /// <summary>
        /// PD1.10 - Duplicate Patient.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> DuplicatePatient { get; set; }

        /// <summary>
        /// PD1.11 - Publicity Code.
        /// <para>Suggested: 0215 Publicity Code -&gt; ClearHl7.Codes.V271.CodePublicityCode</para>
        /// </summary>
        public CodedWithExceptions PublicityCode { get; set; }

        /// <summary>
        /// PD1.12 - Protection Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0435 Advance Directive Code -&gt; ClearHl7.Codes.V271.CodeAdvanceDirectiveCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> AdvanceDirectiveCode { get; set; }

        /// <summary>
        /// PD1.16 - Immunization Registry Status.
        /// <para>Suggested: 0441 Immunization Registry Status -&gt; ClearHl7.Codes.V271.CodeImmunizationRegistryStatus</para>
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
        /// <para>Suggested: 0140 Military Service -&gt; ClearHl7.Codes.V271.CodeMilitaryService</para>
        /// </summary>
        public CodedWithExceptions MilitaryBranch { get; set; }

        /// <summary>
        /// PD1.20 - Military Rank/Grade.
        /// <para>Suggested: 0141 Military Rank/Grade -&gt; ClearHl7.Codes.V271.CodeMilitaryRankGrade</para>
        /// </summary>
        public CodedWithExceptions MilitaryRankGrade { get; set; }

        /// <summary>
        /// PD1.21 - Military Status.
        /// <para>Suggested: 0142 Military Status -&gt; ClearHl7.Codes.V271.CodeMilitaryStatus</para>
        /// </summary>
        public CodedWithExceptions MilitaryStatus { get; set; }

        /// <summary>
        /// PD1.22 - Advance Directive Last Verified Date.
        /// </summary>
        public DateTime? AdvanceDirectiveLastVerifiedDate { get; set; }

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

            LivingDependency = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            LivingArrangement = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[2], false) : null;
            PatientPrimaryFacility = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            PatientPrimaryCareProviderNameIdNo = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[4], false) : null;
            StudentIndicator = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[5], false) : null;
            Handicap = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[6], false) : null;
            LivingWillCode = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[7], false) : null;
            OrganDonorCode = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[8], false) : null;
            SeparateBill = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            DuplicatePatient = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            PublicityCode = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[11], false) : null;
            ProtectionIndicator = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            ProtectionIndicatorEffectiveDate = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            PlaceOfWorship = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            AdvanceDirectiveCode = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ImmunizationRegistryStatus = segments.Length > 16 && segments[16].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[16], false) : null;
            ImmunizationRegistryStatusEffectiveDate = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDateTime() : null;
            PublicityCodeEffectiveDate = segments.Length > 18 && segments[18].Length > 0 ? segments[18].ToNullableDateTime() : null;
            MilitaryBranch = segments.Length > 19 && segments[19].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[19], false) : null;
            MilitaryRankGrade = segments.Length > 20 && segments[20].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[20], false) : null;
            MilitaryStatus = segments.Length > 21 && segments[21].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[21], false) : null;
            AdvanceDirectiveLastVerifiedDate = segments.Length > 22 && segments[22].Length > 0 ? segments[22].ToNullableDateTime() : null;
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
                                StringHelper.StringFormatSequence(0, 23, Configuration.FieldSeparator),
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
                                AdvanceDirectiveLastVerifiedDate.HasValue ? AdvanceDirectiveLastVerifiedDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}