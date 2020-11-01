using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V270.Types;

namespace ClearHl7.Fhir.V270.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0223</remarks>
        public IEnumerable<CodedWithExceptions> LivingDependency { get; set; }

        /// <summary>
        /// PD1.2 - Living Arrangement.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0220</remarks>
        public CodedWithExceptions LivingArrangement { get; set; }

        /// <summary>
        /// PD1.3 - Patient Primary Facility.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0204</remarks>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> PatientPrimaryFacility { get; set; }

        /// <summary>
        /// PD1.4 - Patient Primary Care Provider Name & ID No..
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons PatientPrimaryCareProviderNameIdNo { get; set; }

        /// <summary>
        /// PD1.5 - Student Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0231</remarks>
        public CodedWithExceptions StudentIndicator { get; set; }

        /// <summary>
        /// PD1.6 - Handicap.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0295</remarks>
        public CodedWithExceptions Handicap { get; set; }

        /// <summary>
        /// PD1.7 - Living Will Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0315</remarks>
        public CodedWithExceptions LivingWillCode { get; set; }

        /// <summary>
        /// PD1.8 - Organ Donor Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0316</remarks>
        public CodedWithExceptions OrganDonorCode { get; set; }

        /// <summary>
        /// PD1.9 - Separate Bill.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string SeparateBill { get; set; }

        /// <summary>
        /// PD1.10 - Duplicate Patient.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> DuplicatePatient { get; set; }

        /// <summary>
        /// PD1.11 - Publicity Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0215</remarks>
        public CodedWithExceptions PublicityCode { get; set; }

        /// <summary>
        /// PD1.12 - Protection Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0435</remarks>
        public IEnumerable<CodedWithExceptions> AdvanceDirectiveCode { get; set; }

        /// <summary>
        /// PD1.16 - Immunization Registry Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0441</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0140</remarks>
        public CodedWithExceptions MilitaryBranch { get; set; }

        /// <summary>
        /// PD1.20 - Military Rank/Grade.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0141</remarks>
        public CodedWithExceptions MilitaryRankGrade { get; set; }

        /// <summary>
        /// PD1.21 - Military Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0142</remarks>
        public CodedWithExceptions MilitaryStatus { get; set; }

        /// <summary>
        /// PD1.22 - Advance Directive Last Verified Date.
        /// </summary>
        public DateTime? AdvanceDirectiveLastVerifiedDate { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}",
                                Id,
                                LivingDependency != null ? string.Join("~", LivingDependency.Select(x => x.ToDelimitedString())) : null,
                                LivingArrangement?.ToDelimitedString(),
                                PatientPrimaryFacility != null ? string.Join("~", PatientPrimaryFacility.Select(x => x.ToDelimitedString())) : null,
                                PatientPrimaryCareProviderNameIdNo?.ToDelimitedString(),
                                StudentIndicator?.ToDelimitedString(),
                                Handicap?.ToDelimitedString(),
                                LivingWillCode?.ToDelimitedString(),
                                OrganDonorCode?.ToDelimitedString(),
                                SeparateBill,
                                DuplicatePatient != null ? string.Join("~", DuplicatePatient.Select(x => x.ToDelimitedString())) : null,
                                PublicityCode?.ToDelimitedString(),
                                ProtectionIndicator,
                                ProtectionIndicatorEffectiveDate.HasValue ? ProtectionIndicatorEffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                PlaceOfWorship != null ? string.Join("~", PlaceOfWorship.Select(x => x.ToDelimitedString())) : null,
                                AdvanceDirectiveCode != null ? string.Join("~", AdvanceDirectiveCode.Select(x => x.ToDelimitedString())) : null,
                                ImmunizationRegistryStatus?.ToDelimitedString(),
                                ImmunizationRegistryStatusEffectiveDate.HasValue ? ImmunizationRegistryStatusEffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                PublicityCodeEffectiveDate.HasValue ? PublicityCodeEffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                MilitaryBranch?.ToDelimitedString(),
                                MilitaryRankGrade?.ToDelimitedString(),
                                MilitaryStatus?.ToDelimitedString(),
                                AdvanceDirectiveLastVerifiedDate.HasValue ? AdvanceDirectiveLastVerifiedDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null
                                ).TrimEnd('|');
        }
    }
}