using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        public IEnumerable<string> LivingDependency { get; set; }

        /// <summary>
        /// PD1.2 - Living Arrangement.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0220</remarks>
        public string LivingArrangement { get; set; }

        /// <summary>
        /// PD1.3 - Patient Primary Facility.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> PatientPrimaryFacility { get; set; }

        /// <summary>
        /// PD1.4 - Patient Primary Care Provider Name &amp; ID No..
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> PatientPrimaryCareProviderNameIdNo { get; set; }

        /// <summary>
        /// PD1.5 - Student Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0231</remarks>
        public string StudentIndicator { get; set; }

        /// <summary>
        /// PD1.6 - Handicap.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0295</remarks>
        public string Handicap { get; set; }

        /// <summary>
        /// PD1.7 - Living Will Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0315</remarks>
        public string LivingWillCode { get; set; }

        /// <summary>
        /// PD1.8 - Organ Donor Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0316</remarks>
        public string OrganDonorCode { get; set; }

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
        public CodedElement PublicityCode { get; set; }

        /// <summary>
        /// PD1.12 - Protection Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string ProtectionIndicator { get; set; }

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