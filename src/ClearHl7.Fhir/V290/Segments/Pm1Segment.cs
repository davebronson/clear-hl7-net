using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V290.Types;

namespace ClearHl7.Fhir.V290.Segments
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

        /// <summary>
        /// PM1.1 - Health Plan ID.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0072</remarks>
        public CodedWithExceptions HealthPlanId { get; set; }

        /// <summary>
        /// PM1.2 - Insurance Company ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdWithCheckDigit> InsuranceCompanyId { get; set; }

        /// <summary>
        /// PM1.3 - Insurance Company Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> InsuranceCompanyName { get; set; }

        /// <summary>
        /// PM1.4 - Insurance Company Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> InsuranceCompanyAddress { get; set; }

        /// <summary>
        /// PM1.5 - Insurance Co Contact Person.
        /// </summary>
        public IEnumerable<ExtendedPersonName> InsuranceCoContactPerson { get; set; }

        /// <summary>
        /// PM1.6 - Insurance Co Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> InsuranceCoPhoneNumber { get; set; }

        /// <summary>
        /// PM1.7 - Group Number.
        /// </summary>
        public string GroupNumber { get; set; }

        /// <summary>
        /// PM1.8 - Group Name.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> GroupName { get; set; }

        /// <summary>
        /// PM1.9 - Plan Effective Date.
        /// </summary>
        public DateTime? PlanEffectiveDate { get; set; }

        /// <summary>
        /// PM1.10 - Plan Expiration Date.
        /// </summary>
        public DateTime? PlanExpirationDate { get; set; }

        /// <summary>
        /// PM1.11 - Patient DOB Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string PatientDobRequired { get; set; }

        /// <summary>
        /// PM1.12 - Patient Gender Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string PatientGenderRequired { get; set; }

        /// <summary>
        /// PM1.13 - Patient Relationship Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string PatientRelationshipRequired { get; set; }

        /// <summary>
        /// PM1.14 - Patient Signature Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string PatientSignatureRequired { get; set; }

        /// <summary>
        /// PM1.15 - Diagnosis Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string DiagnosisRequired { get; set; }

        /// <summary>
        /// PM1.16 - Service Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string ServiceRequired { get; set; }

        /// <summary>
        /// PM1.17 - Patient Name Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string PatientNameRequired { get; set; }

        /// <summary>
        /// PM1.18 - Patient Address Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string PatientAddressRequired { get; set; }

        /// <summary>
        /// PM1.19 - Subscribers Name Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string SubscribersNameRequired { get; set; }

        /// <summary>
        /// PM1.20 - Workman's Comp Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string WorkmansCompIndicator { get; set; }

        /// <summary>
        /// PM1.21 - Bill Type Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string BillTypeRequired { get; set; }

        /// <summary>
        /// PM1.22 - Commercial Carrier Name and Address Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string CommercialCarrierNameAndAddressRequired { get; set; }

        /// <summary>
        /// PM1.23 - Policy Number Pattern.
        /// </summary>
        public string PolicyNumberPattern { get; set; }

        /// <summary>
        /// PM1.24 - Group Number Pattern.
        /// </summary>
        public string GroupNumberPattern { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 25, Configuration.FieldSeparator),
                                Id,
                                HealthPlanId?.ToDelimitedString(),
                                InsuranceCompanyId != null ? string.Join(Configuration.FieldRepeatSeparator, InsuranceCompanyId.Select(x => x.ToDelimitedString())) : null,
                                InsuranceCompanyName != null ? string.Join(Configuration.FieldRepeatSeparator, InsuranceCompanyName.Select(x => x.ToDelimitedString())) : null,
                                InsuranceCompanyAddress != null ? string.Join(Configuration.FieldRepeatSeparator, InsuranceCompanyAddress.Select(x => x.ToDelimitedString())) : null,
                                InsuranceCoContactPerson != null ? string.Join(Configuration.FieldRepeatSeparator, InsuranceCoContactPerson.Select(x => x.ToDelimitedString())) : null,
                                InsuranceCoPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, InsuranceCoPhoneNumber.Select(x => x.ToDelimitedString())) : null,
                                GroupNumber,
                                GroupName != null ? string.Join(Configuration.FieldRepeatSeparator, GroupName.Select(x => x.ToDelimitedString())) : null,
                                PlanEffectiveDate.HasValue ? PlanEffectiveDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                PlanExpirationDate.HasValue ? PlanExpirationDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                PatientDobRequired,
                                PatientGenderRequired,
                                PatientRelationshipRequired,
                                PatientSignatureRequired,
                                DiagnosisRequired,
                                ServiceRequired,
                                PatientNameRequired,
                                PatientAddressRequired,
                                SubscribersNameRequired,
                                WorkmansCompIndicator,
                                BillTypeRequired,
                                CommercialCarrierNameAndAddressRequired,
                                PolicyNumberPattern,
                                GroupNumberPattern
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}