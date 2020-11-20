using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V240.Types;

namespace ClearHl7.Fhir.V240.Segments
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
        public CodedElement PrimaryKeyValuePra { get; set; }

        /// <summary>
        /// PRA.2 - Practitioner Group.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0358</remarks>
        public IEnumerable<CodedElement> PractitionerGroup { get; set; }

        /// <summary>
        /// PRA.3 - Practitioner Category.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0186</remarks>
        public IEnumerable<string> PractitionerCategory { get; set; }

        /// <summary>
        /// PRA.4 - Provider Billing.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0187</remarks>
        public string ProviderBilling { get; set; }

        /// <summary>
        /// PRA.5 - Specialty.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0337</remarks>
        public IEnumerable<SpecialtyDescription> Specialty { get; set; }

        /// <summary>
        /// PRA.6 - Practitioner ID Numbers.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0338</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0537</remarks>
        public CodedElement Institution { get; set; }

        /// <summary>
        /// PRA.10 - Date Left Practice.
        /// </summary>
        public DateTime? DateLeftPractice { get; set; }

        /// <summary>
        /// PRA.11 - Government Reimbursement Billing Eligibility.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0401</remarks>
        public IEnumerable<CodedElement> GovernmentReimbursementBillingEligibility { get; set; }

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
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}",
                                Id,
                                PrimaryKeyValuePra?.ToDelimitedString(),
                                PractitionerGroup != null ? string.Join("~", PractitionerGroup.Select(x => x.ToDelimitedString())) : null,
                                PractitionerCategory != null ? string.Join("~", PractitionerCategory) : null,
                                ProviderBilling,
                                Specialty != null ? string.Join("~", Specialty.Select(x => x.ToDelimitedString())) : null,
                                PractitionerIdNumbers != null ? string.Join("~", PractitionerIdNumbers.Select(x => x.ToDelimitedString())) : null,
                                Privileges != null ? string.Join("~", Privileges.Select(x => x.ToDelimitedString())) : null,
                                DateEnteredPractice.HasValue ? DateEnteredPractice.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                Institution?.ToDelimitedString(),
                                DateLeftPractice.HasValue ? DateLeftPractice.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                GovernmentReimbursementBillingEligibility != null ? string.Join("~", GovernmentReimbursementBillingEligibility.Select(x => x.ToDelimitedString())) : null,
                                SetIdPra.HasValue ? SetIdPra.Value.ToString(culture) : null
                                ).TrimEnd('|');
        }
    }
}