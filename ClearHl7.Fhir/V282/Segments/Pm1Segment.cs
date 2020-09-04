using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PM1 - Payer Master File.
    /// </summary>
    public class Pm1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PM1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// PM1.1 - Health Plan ID.
        ///// </summary>
        //public HealthPlanId { get; set; }

        ///// <summary>
        ///// PM1.2 - Insurance Company ID.
        ///// </summary>
        //public InsuranceCompanyId { get; set; }

        ///// <summary>
        ///// PM1.3 - Insurance Company Name.
        ///// </summary>
        //public InsuranceCompanyName { get; set; }

        ///// <summary>
        ///// PM1.4 - Insurance Company Address.
        ///// </summary>
        //public InsuranceCompanyAddress { get; set; }

        ///// <summary>
        ///// PM1.5 - Insurance Co Contact Person.
        ///// </summary>
        //public InsuranceCoContactPerson { get; set; }

        ///// <summary>
        ///// PM1.6 - Insurance Co Phone Number.
        ///// </summary>
        //public InsuranceCoPhoneNumber { get; set; }

        ///// <summary>
        ///// PM1.7 - Group Number.
        ///// </summary>
        //public GroupNumber { get; set; }

        ///// <summary>
        ///// PM1.8 - Group Name.
        ///// </summary>
        //public GroupName { get; set; }

        ///// <summary>
        ///// PM1.9 - Plan Effective Date.
        ///// </summary>
        //public PlanEffectiveDate { get; set; }

        ///// <summary>
        ///// PM1.10 - Plan Expiration Date.
        ///// </summary>
        //public PlanExpirationDate { get; set; }

        ///// <summary>
        ///// PM1.11 - Patient DOB Required.
        ///// </summary>
        //public PatientDobRequired { get; set; }

        ///// <summary>
        ///// PM1.12 - Patient Gender Required.
        ///// </summary>
        //public PatientGenderRequired { get; set; }

        ///// <summary>
        ///// PM1.13 - Patient Relationship Required.
        ///// </summary>
        //public PatientRelationshipRequired { get; set; }

        ///// <summary>
        ///// PM1.14 - Patient Signature Required.
        ///// </summary>
        //public PatientSignatureRequired { get; set; }

        ///// <summary>
        ///// PM1.15 - Diagnosis Required.
        ///// </summary>
        //public DiagnosisRequired { get; set; }

        ///// <summary>
        ///// PM1.16 - Service Required.
        ///// </summary>
        //public ServiceRequired { get; set; }

        ///// <summary>
        ///// PM1.17 - Patient Name Required.
        ///// </summary>
        //public PatientNameRequired { get; set; }

        ///// <summary>
        ///// PM1.18 - Patient Address Required.
        ///// </summary>
        //public PatientAddressRequired { get; set; }

        ///// <summary>
        ///// PM1.19 - Subscribers Name Required.
        ///// </summary>
        //public SubscribersNameRequired { get; set; }

        ///// <summary>
        ///// PM1.20 - Workman's Comp Indicator.
        ///// </summary>
        //public WorkmansCompIndicator { get; set; }

        ///// <summary>
        ///// PM1.21 - Bill Type Required.
        ///// </summary>
        //public BillTypeRequired { get; set; }

        ///// <summary>
        ///// PM1.22 - Commercial Carrier Name and Address Required.
        ///// </summary>
        //public CommercialCarrierNameAndAddressRequired { get; set; }

        ///// <summary>
        ///// PM1.23 - Policy Number Pattern.
        ///// </summary>
        //public PolicyNumberPattern { get; set; }

        ///// <summary>
        ///// PM1.24 - Group Number Pattern.
        ///// </summary>
        //public GroupNumberPattern { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}"
                                ).TrimEnd('|');
        }
    }
}