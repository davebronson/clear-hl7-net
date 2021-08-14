using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IAM - Patient Adverse Reaction Information.
    /// </summary>
    public class IamSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "IAM";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// IAM.1 - Set ID - IAM.
        /// </summary>
        public uint? SetIdIam { get; set; }

        /// <summary>
        /// IAM.2 - Allergen Type Code.
        /// <para>Suggested: 0127 Allergen Type -&gt; ClearHl7.Codes.V271.CodeAllergenType</para>
        /// </summary>
        public CodedWithExceptions AllergenTypeCode { get; set; }

        /// <summary>
        /// IAM.3 - Allergen Code/Mnemonic/Description.
        /// </summary>
        public CodedWithExceptions AllergenCodeMnemonicDescription { get; set; }

        /// <summary>
        /// IAM.4 - Allergy Severity Code.
        /// <para>Suggested: 0128 Allergy Severity -&gt; ClearHl7.Codes.V271.CodeAllergySeverity</para>
        /// </summary>
        public CodedWithExceptions AllergySeverityCode { get; set; }

        /// <summary>
        /// IAM.5 - Allergy Reaction Code.
        /// </summary>
        public IEnumerable<string> AllergyReactionCode { get; set; }

        /// <summary>
        /// IAM.6 - Allergy Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V271.CodeSegmentActionCode</para>
        /// </summary>
        public CodedWithNoExceptions AllergyActionCode { get; set; }

        /// <summary>
        /// IAM.7 - Allergy Unique Identifier.
        /// </summary>
        public EntityIdentifier AllergyUniqueIdentifier { get; set; }

        /// <summary>
        /// IAM.8 - Action Reason.
        /// </summary>
        public string ActionReason { get; set; }

        /// <summary>
        /// IAM.9 - Sensitivity to Causative Agent Code.
        /// <para>Suggested: 0436 Sensitivity To Causative Agent Code -&gt; ClearHl7.Codes.V271.CodeSensitivityToCausativeAgentCode</para>
        /// </summary>
        public CodedWithExceptions SensitivityToCausativeAgentCode { get; set; }

        /// <summary>
        /// IAM.10 - Allergen Group Code/Mnemonic/Description.
        /// </summary>
        public CodedWithExceptions AllergenGroupCodeMnemonicDescription { get; set; }

        /// <summary>
        /// IAM.11 - Onset Date.
        /// </summary>
        public DateTime? OnsetDate { get; set; }

        /// <summary>
        /// IAM.12 - Onset Date Text.
        /// </summary>
        public string OnsetDateText { get; set; }

        /// <summary>
        /// IAM.13 - Reported Date/Time.
        /// </summary>
        public DateTime? ReportedDateTime { get; set; }

        /// <summary>
        /// IAM.14 - Reported By.
        /// </summary>
        public ExtendedPersonName ReportedBy { get; set; }

        /// <summary>
        /// IAM.15 - Relationship to Patient Code.
        /// <para>Suggested: 0063 Relationship -&gt; ClearHl7.Codes.V271.CodeRelationship</para>
        /// </summary>
        public CodedWithExceptions RelationshipToPatientCode { get; set; }

        /// <summary>
        /// IAM.16 - Alert Device Code.
        /// <para>Suggested: 0437 Alert Device Code -&gt; ClearHl7.Codes.V271.CodeAlertDeviceCode</para>
        /// </summary>
        public CodedWithExceptions AlertDeviceCode { get; set; }

        /// <summary>
        /// IAM.17 - Allergy Clinical Status Code.
        /// <para>Suggested: 0438 Allergy Clinical Status -&gt; ClearHl7.Codes.V271.CodeAllergyClinicalStatus</para>
        /// </summary>
        public CodedWithExceptions AllergyClinicalStatusCode { get; set; }

        /// <summary>
        /// IAM.18 - Statused by Person.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons StatusedByPerson { get; set; }

        /// <summary>
        /// IAM.19 - Statused by Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations StatusedByOrganization { get; set; }

        /// <summary>
        /// IAM.20 - Statused at Date/Time.
        /// </summary>
        public DateTime? StatusedAtDateTime { get; set; }

        /// <summary>
        /// IAM.21 - Inactivated by Person.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons InactivatedByPerson { get; set; }

        /// <summary>
        /// IAM.22 - Inactivated Date/Time.
        /// </summary>
        public DateTime? InactivatedDateTime { get; set; }

        /// <summary>
        /// IAM.23 - Initially Recorded by Person.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons InitiallyRecordedByPerson { get; set; }

        /// <summary>
        /// IAM.24 - Initially Recorded Date/Time.
        /// </summary>
        public DateTime? InitiallyRecordedDateTime { get; set; }

        /// <summary>
        /// IAM.25 - Modified by Person.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons ModifiedByPerson { get; set; }

        /// <summary>
        /// IAM.26 - Modified Date/Time.
        /// </summary>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// IAM.27 - Clinician Identified Code.
        /// </summary>
        public CodedWithExceptions ClinicianIdentifiedCode { get; set; }

        /// <summary>
        /// IAM.28 - Initially Recorded by Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations InitiallyRecordedByOrganization { get; set; }

        /// <summary>
        /// IAM.29 - Modified by Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations ModifiedByOrganization { get; set; }

        /// <summary>
        /// IAM.30 - Inactivated by Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations InactivatedByOrganization { get; set; }

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

            SetIdIam = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            AllergenTypeCode = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            AllergenCodeMnemonicDescription = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            AllergySeverityCode = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
            AllergyReactionCode = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator) : null;
            AllergyActionCode = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(6), false) : null;
            AllergyUniqueIdentifier = segments.Length > 7 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(7), false) : null;
            ActionReason = segments.ElementAtOrDefault(8);
            SensitivityToCausativeAgentCode = segments.Length > 9 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(9), false) : null;
            AllergenGroupCodeMnemonicDescription = segments.Length > 10 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(10), false) : null;
            OnsetDate = segments.ElementAtOrDefault(11)?.ToNullableDateTime();
            OnsetDateText = segments.ElementAtOrDefault(12);
            ReportedDateTime = segments.ElementAtOrDefault(13)?.ToNullableDateTime();
            ReportedBy = segments.Length > 14 ? TypeHelper.Deserialize<ExtendedPersonName>(segments.ElementAtOrDefault(14), false) : null;
            RelationshipToPatientCode = segments.Length > 15 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(15), false) : null;
            AlertDeviceCode = segments.Length > 16 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(16), false) : null;
            AllergyClinicalStatusCode = segments.Length > 17 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(17), false) : null;
            StatusedByPerson = segments.Length > 18 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(18), false) : null;
            StatusedByOrganization = segments.Length > 19 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(19), false) : null;
            StatusedAtDateTime = segments.ElementAtOrDefault(20)?.ToNullableDateTime();
            InactivatedByPerson = segments.Length > 21 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(21), false) : null;
            InactivatedDateTime = segments.ElementAtOrDefault(22)?.ToNullableDateTime();
            InitiallyRecordedByPerson = segments.Length > 23 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(23), false) : null;
            InitiallyRecordedDateTime = segments.ElementAtOrDefault(24)?.ToNullableDateTime();
            ModifiedByPerson = segments.Length > 25 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(25), false) : null;
            ModifiedDateTime = segments.ElementAtOrDefault(26)?.ToNullableDateTime();
            ClinicianIdentifiedCode = segments.Length > 27 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(27), false) : null;
            InitiallyRecordedByOrganization = segments.Length > 28 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(28), false) : null;
            ModifiedByOrganization = segments.Length > 29 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(29), false) : null;
            InactivatedByOrganization = segments.Length > 30 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(30), false) : null;
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
                                StringHelper.StringFormatSequence(0, 31, Configuration.FieldSeparator),
                                Id,
                                SetIdIam.HasValue ? SetIdIam.Value.ToString(culture) : null,
                                AllergenTypeCode?.ToDelimitedString(),
                                AllergenCodeMnemonicDescription?.ToDelimitedString(),
                                AllergySeverityCode?.ToDelimitedString(),
                                AllergyReactionCode != null ? string.Join(Configuration.FieldRepeatSeparator, AllergyReactionCode) : null,
                                AllergyActionCode?.ToDelimitedString(),
                                AllergyUniqueIdentifier?.ToDelimitedString(),
                                ActionReason,
                                SensitivityToCausativeAgentCode?.ToDelimitedString(),
                                AllergenGroupCodeMnemonicDescription?.ToDelimitedString(),
                                OnsetDate.HasValue ? OnsetDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                OnsetDateText,
                                ReportedDateTime.HasValue ? ReportedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReportedBy?.ToDelimitedString(),
                                RelationshipToPatientCode?.ToDelimitedString(),
                                AlertDeviceCode?.ToDelimitedString(),
                                AllergyClinicalStatusCode?.ToDelimitedString(),
                                StatusedByPerson?.ToDelimitedString(),
                                StatusedByOrganization?.ToDelimitedString(),
                                StatusedAtDateTime.HasValue ? StatusedAtDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InactivatedByPerson?.ToDelimitedString(),
                                InactivatedDateTime.HasValue ? InactivatedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InitiallyRecordedByPerson?.ToDelimitedString(),
                                InitiallyRecordedDateTime.HasValue ? InitiallyRecordedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ModifiedByPerson?.ToDelimitedString(),
                                ModifiedDateTime.HasValue ? ModifiedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ClinicianIdentifiedCode?.ToDelimitedString(),
                                InitiallyRecordedByOrganization?.ToDelimitedString(),
                                ModifiedByOrganization?.ToDelimitedString(),
                                InactivatedByOrganization?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}