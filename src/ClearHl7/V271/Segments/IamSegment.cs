using System;
using System.Collections.Generic;
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0127</remarks>
        public CodedWithExceptions AllergenTypeCode { get; set; }

        /// <summary>
        /// IAM.3 - Allergen Code/Mnemonic/Description.
        /// </summary>
        public CodedWithExceptions AllergenCodeMnemonicDescription { get; set; }

        /// <summary>
        /// IAM.4 - Allergy Severity Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0128</remarks>
        public CodedWithExceptions AllergySeverityCode { get; set; }

        /// <summary>
        /// IAM.5 - Allergy Reaction Code.
        /// </summary>
        public IEnumerable<string> AllergyReactionCode { get; set; }

        /// <summary>
        /// IAM.6 - Allergy Action Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0206</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0436</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0063</remarks>
        public CodedWithExceptions RelationshipToPatientCode { get; set; }

        /// <summary>
        /// IAM.16 - Alert Device Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0437</remarks>
        public CodedWithExceptions AlertDeviceCode { get; set; }

        /// <summary>
        /// IAM.17 - Allergy Clinical Status Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0438</remarks>
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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