using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// PRA.1 - Primary Key Value - PRA.
        ///// </summary>
        //public PrimaryKeyValuePra { get; set; }

        ///// <summary>
        ///// PRA.2 - Practitioner Group.
        ///// </summary>
        //public PractitionerGroup { get; set; }

        ///// <summary>
        ///// PRA.3 - Practitioner Category.
        ///// </summary>
        //public PractitionerCategory { get; set; }

        ///// <summary>
        ///// PRA.4 - Provider Billing.
        ///// </summary>
        //public ProviderBilling { get; set; }

        ///// <summary>
        ///// PRA.5 - Specialty.
        ///// </summary>
        //public Specialty { get; set; }

        ///// <summary>
        ///// PRA.6 - Practitioner ID Numbers.
        ///// </summary>
        //public PractitionerIdNumbers { get; set; }

        ///// <summary>
        ///// PRA.7 - Privileges.
        ///// </summary>
        //public Privileges { get; set; }

        ///// <summary>
        ///// PRA.8 - Date Entered Practice.
        ///// </summary>
        //public DateEnteredPractice { get; set; }

        ///// <summary>
        ///// PRA.9 - Institution.
        ///// </summary>
        //public Institution { get; set; }

        ///// <summary>
        ///// PRA.10 - Date Left Practice.
        ///// </summary>
        //public DateLeftPractice { get; set; }

        ///// <summary>
        ///// PRA.11 - Government Reimbursement Billing Eligibility.
        ///// </summary>
        //public GovernmentReimbursementBillingEligibility { get; set; }

        ///// <summary>
        ///// PRA.12 - Set ID - PRA.
        ///// </summary>
        //public SetIdPra { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}"
                                ).TrimEnd('|');
        }
    }
}