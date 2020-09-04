using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// PD1.1 - Living Dependency.
        ///// </summary>
        //public LivingDependency { get; set; }

        ///// <summary>
        ///// PD1.2 - Living Arrangement.
        ///// </summary>
        //public LivingArrangement { get; set; }

        ///// <summary>
        ///// PD1.3 - Patient Primary Facility.
        ///// </summary>
        //public PatientPrimaryFacility { get; set; }

        ///// <summary>
        ///// PD1.4 - Patient Primary Care Provider Name & ID No..
        ///// </summary>
        //public PatientPrimaryCareProviderNameIdNo { get; set; }

        ///// <summary>
        ///// PD1.5 - Student Indicator.
        ///// </summary>
        //public StudentIndicator { get; set; }

        ///// <summary>
        ///// PD1.6 - Handicap.
        ///// </summary>
        //public Handicap { get; set; }

        ///// <summary>
        ///// PD1.7 - Living Will Code.
        ///// </summary>
        //public LivingWillCode { get; set; }

        ///// <summary>
        ///// PD1.8 - Organ Donor Code.
        ///// </summary>
        //public OrganDonorCode { get; set; }

        ///// <summary>
        ///// PD1.9 - Separate Bill.
        ///// </summary>
        //public SeparateBill { get; set; }

        ///// <summary>
        ///// PD1.10 - Duplicate Patient.
        ///// </summary>
        //public DuplicatePatient { get; set; }

        ///// <summary>
        ///// PD1.11 - Publicity Code.
        ///// </summary>
        //public PublicityCode { get; set; }

        ///// <summary>
        ///// PD1.12 - Protection Indicator.
        ///// </summary>
        //public ProtectionIndicator { get; set; }

        ///// <summary>
        ///// PD1.13 - Protection Indicator Effective Date.
        ///// </summary>
        //public ProtectionIndicatorEffectiveDate { get; set; }

        ///// <summary>
        ///// PD1.14 - Place of Worship.
        ///// </summary>
        //public PlaceOfWorship { get; set; }

        ///// <summary>
        ///// PD1.15 - Advance Directive Code.
        ///// </summary>
        //public AdvanceDirectiveCode { get; set; }

        ///// <summary>
        ///// PD1.16 - Immunization Registry Status.
        ///// </summary>
        //public ImmunizationRegistryStatus { get; set; }

        ///// <summary>
        ///// PD1.17 - Immunization Registry Status Effective Date.
        ///// </summary>
        //public ImmunizationRegistryStatusEffectiveDate { get; set; }

        ///// <summary>
        ///// PD1.18 - Publicity Code Effective Date.
        ///// </summary>
        //public PublicityCodeEffectiveDate { get; set; }

        ///// <summary>
        ///// PD1.19 - Military Branch.
        ///// </summary>
        //public MilitaryBranch { get; set; }

        ///// <summary>
        ///// PD1.20 - Military Rank/Grade.
        ///// </summary>
        //public MilitaryRankGrade { get; set; }

        ///// <summary>
        ///// PD1.21 - Military Status.
        ///// </summary>
        //public MilitaryStatus { get; set; }

        ///// <summary>
        ///// PD1.22 - Advance Directive Last Verified Date.
        ///// </summary>
        //public AdvanceDirectiveLastVerifiedDate { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}"
                                ).TrimEnd('|');
        }
    }
}