using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PD1 - Patient Additional Demographic.
    /// </summary>
    public class Pd1Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pd1Segment"/> class.
        /// </summary>
        public Pd1Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pd1Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Pd1Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PD1";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// PD1.1 - Living Dependency.
        /// <para>Suggested: 0223 Living Dependency -&gt; ClearHl7.Codes.V231.CodeLivingDependency</para>
        /// </summary>
        public IEnumerable<string> LivingDependency { get; set; }

        /// <summary>
        /// PD1.2 - Living Arrangement.
        /// <para>Suggested: 0220 Living Arrangement -&gt; ClearHl7.Codes.V231.CodeLivingArrangement</para>
        /// </summary>
        public string LivingArrangement { get; set; }

        /// <summary>
        /// PD1.3 - Patient Primary Facility.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> PatientPrimaryFacility { get; set; }

        /// <summary>
        /// PD1.4 - Patient Primary Care Provider Name &amp; ID No.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> PatientPrimaryCareProviderNameIdNo { get; set; }

        /// <summary>
        /// PD1.5 - Student Indicator.
        /// <para>Suggested: 0231 Student Status -&gt; ClearHl7.Codes.V231.CodeStudentStatus</para>
        /// </summary>
        public string StudentIndicator { get; set; }

        /// <summary>
        /// PD1.6 - Handicap.
        /// <para>Suggested: 0295 Handicap</para>
        /// </summary>
        public string Handicap { get; set; }

        /// <summary>
        /// PD1.7 - Living Will Code.
        /// <para>Suggested: 0315 Living Will Code -&gt; ClearHl7.Codes.V231.CodeLivingWillCode</para>
        /// </summary>
        public string LivingWillCode { get; set; }

        /// <summary>
        /// PD1.8 - Organ Donor Code.
        /// <para>Suggested: 0316 Organ Donor Code -&gt; ClearHl7.Codes.V231.CodeOrganDonorCode</para>
        /// </summary>
        public string OrganDonorCode { get; set; }

        /// <summary>
        /// PD1.9 - Separate Bill.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string SeparateBill { get; set; }

        /// <summary>
        /// PD1.10 - Duplicate Patient.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> DuplicatePatient { get; set; }

        /// <summary>
        /// PD1.11 - Publicity Code.
        /// <para>Suggested: 0215 Publicity Code</para>
        /// </summary>
        public CodedElement PublicityCode { get; set; }

        /// <summary>
        /// PD1.12 - Protection Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
        /// </summary>
        public string ProtectionIndicator { get; set; }

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

            LivingDependency = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            LivingArrangement = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            PatientPrimaryFacility = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            PatientPrimaryCareProviderNameIdNo = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            StudentIndicator = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            Handicap = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            LivingWillCode = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            OrganDonorCode = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            SeparateBill = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            DuplicatePatient = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            PublicityCode = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[11], false, seps) : null;
            ProtectionIndicator = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                LivingDependency != null ? string.Join(Configuration.FieldRepeatSeparator, LivingDependency) : null,
                                LivingArrangement,
                                PatientPrimaryFacility != null ? string.Join(Configuration.FieldRepeatSeparator, PatientPrimaryFacility.Select(x => x.ToDelimitedString())) : null,
                                PatientPrimaryCareProviderNameIdNo != null ? string.Join(Configuration.FieldRepeatSeparator, PatientPrimaryCareProviderNameIdNo.Select(x => x.ToDelimitedString())) : null,
                                StudentIndicator,
                                Handicap,
                                LivingWillCode,
                                OrganDonorCode,
                                SeparateBill,
                                DuplicatePatient != null ? string.Join(Configuration.FieldRepeatSeparator, DuplicatePatient.Select(x => x.ToDelimitedString())) : null,
                                PublicityCode?.ToDelimitedString(),
                                ProtectionIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
