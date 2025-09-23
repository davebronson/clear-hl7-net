using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PM1 - Payer Master File.
    /// </summary>
    public class Pm1Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pm1Segment"/> class.
        /// </summary>
        public Pm1Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pm1Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Pm1Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PM1";

        /// <inheritdoc/>
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

            HealthPlanId = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            InsuranceCompanyId = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(x, false, seps)) : null;
            InsuranceCompanyName = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            InsuranceCompanyAddress = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedAddress>(x, false, seps)) : null;
            InsuranceCoContactPerson = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
            InsuranceCoPhoneNumber = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
            GroupNumber = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            GroupName = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            PlanEffectiveDate = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDateTime() : null;
            PlanExpirationDate = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDateTime() : null;
            PatientDobRequired = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            PatientGenderRequired = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            PatientRelationshipRequired = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            PatientSignatureRequired = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            DiagnosisRequired = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            ServiceRequired = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            PatientNameRequired = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
            PatientAddressRequired = segments.Length > 18 && segments[18].Length > 0 ? segments[18] : null;
            SubscribersNameRequired = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            WorkmansCompIndicator = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            BillTypeRequired = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            CommercialCarrierNameAndAddressRequired = segments.Length > 22 && segments[22].Length > 0 ? segments[22] : null;
            PolicyNumberPattern = segments.Length > 23 && segments[23].Length > 0 ? segments[23] : null;
            GroupNumberPattern = segments.Length > 24 && segments[24].Length > 0 ? segments[24] : null;
        }

        /// <inheritdoc/>
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
                                PlanEffectiveDate.ToHl7DateTimeString(typeof(Pm1Segment), nameof(PlanEffectiveDate), Consts.DateFormatPrecisionDay, culture),
                                PlanExpirationDate.ToHl7DateTimeString(typeof(Pm1Segment), nameof(PlanExpirationDate), Consts.DateFormatPrecisionDay, culture),
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
