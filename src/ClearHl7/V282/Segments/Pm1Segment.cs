using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
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
        /// <para>Suggested: 0072 Insurance Plan ID</para>
        /// </summary>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string PatientDobRequired { get; set; }

        /// <summary>
        /// PM1.12 - Patient Gender Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string PatientGenderRequired { get; set; }

        /// <summary>
        /// PM1.13 - Patient Relationship Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string PatientRelationshipRequired { get; set; }

        /// <summary>
        /// PM1.14 - Patient Signature Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string PatientSignatureRequired { get; set; }

        /// <summary>
        /// PM1.15 - Diagnosis Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string DiagnosisRequired { get; set; }

        /// <summary>
        /// PM1.16 - Service Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string ServiceRequired { get; set; }

        /// <summary>
        /// PM1.17 - Patient Name Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string PatientNameRequired { get; set; }

        /// <summary>
        /// PM1.18 - Patient Address Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string PatientAddressRequired { get; set; }

        /// <summary>
        /// PM1.19 - Subscribers Name Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string SubscribersNameRequired { get; set; }

        /// <summary>
        /// PM1.20 - Workman's Comp Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string WorkmansCompIndicator { get; set; }

        /// <summary>
        /// PM1.21 - Bill Type Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string BillTypeRequired { get; set; }

        /// <summary>
        /// PM1.22 - Commercial Carrier Name and Address Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
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

            HealthPlanId = segments.Length > 1 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(1), false) : null;
            InsuranceCompanyId = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false)) : null;
            InsuranceCompanyName = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            InsuranceCompanyAddress = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            InsuranceCoContactPerson = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            InsuranceCoPhoneNumber = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            GroupNumber = segments.ElementAtOrDefault(7);
            GroupName = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false)) : null;
            PlanEffectiveDate = segments.ElementAtOrDefault(9)?.ToNullableDateTime();
            PlanExpirationDate = segments.ElementAtOrDefault(10)?.ToNullableDateTime();
            PatientDobRequired = segments.ElementAtOrDefault(11);
            PatientGenderRequired = segments.ElementAtOrDefault(12);
            PatientRelationshipRequired = segments.ElementAtOrDefault(13);
            PatientSignatureRequired = segments.ElementAtOrDefault(14);
            DiagnosisRequired = segments.ElementAtOrDefault(15);
            ServiceRequired = segments.ElementAtOrDefault(16);
            PatientNameRequired = segments.ElementAtOrDefault(17);
            PatientAddressRequired = segments.ElementAtOrDefault(18);
            SubscribersNameRequired = segments.ElementAtOrDefault(19);
            WorkmansCompIndicator = segments.ElementAtOrDefault(20);
            BillTypeRequired = segments.ElementAtOrDefault(21);
            CommercialCarrierNameAndAddressRequired = segments.ElementAtOrDefault(22);
            PolicyNumberPattern = segments.ElementAtOrDefault(23);
            GroupNumberPattern = segments.ElementAtOrDefault(24);
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