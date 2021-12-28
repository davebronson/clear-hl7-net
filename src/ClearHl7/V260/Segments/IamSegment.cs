﻿using System;
using System.Collections.Generic;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IAM - Patient Adverse Reaction Information.
    /// </summary>
    public class IamSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "IAM";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// IAM.1 - Set ID - IAM.
        /// </summary>
        public uint? SetIdIam { get; set; }

        /// <summary>
        /// IAM.2 - Allergen Type Code.
        /// <para>Suggested: 0127 Allergen Type -&gt; ClearHl7.Codes.V260.CodeAllergenType</para>
        /// </summary>
        public CodedWithExceptions AllergenTypeCode { get; set; }

        /// <summary>
        /// IAM.3 - Allergen Code/Mnemonic/Description.
        /// </summary>
        public CodedWithExceptions AllergenCodeMnemonicDescription { get; set; }

        /// <summary>
        /// IAM.4 - Allergy Severity Code.
        /// <para>Suggested: 0128 Allergy Severity -&gt; ClearHl7.Codes.V260.CodeAllergySeverity</para>
        /// </summary>
        public CodedWithExceptions AllergySeverityCode { get; set; }

        /// <summary>
        /// IAM.5 - Allergy Reaction Code.
        /// </summary>
        public IEnumerable<string> AllergyReactionCode { get; set; }

        /// <summary>
        /// IAM.6 - Allergy Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V260.CodeSegmentActionCode</para>
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
        /// <para>Suggested: 0436 Sensitivity To Causative Agent Code -&gt; ClearHl7.Codes.V260.CodeSensitivityToCausativeAgentCode</para>
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
        /// <para>Suggested: 0063 Relationship -&gt; ClearHl7.Codes.V260.CodeRelationship</para>
        /// </summary>
        public CodedWithExceptions RelationshipToPatientCode { get; set; }

        /// <summary>
        /// IAM.16 - Alert Device Code.
        /// <para>Suggested: 0437 Alert Device Code -&gt; ClearHl7.Codes.V260.CodeAlertDeviceCode</para>
        /// </summary>
        public CodedWithExceptions AlertDeviceCode { get; set; }

        /// <summary>
        /// IAM.17 - Allergy Clinical Status Code.
        /// <para>Suggested: 0438 Allergy Clinical Status -&gt; ClearHl7.Codes.V260.CodeAllergyClinicalStatus</para>
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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdIam = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            AllergenTypeCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            AllergenCodeMnemonicDescription = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[3], false, seps) : null;
            AllergySeverityCode = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            AllergyReactionCode = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            AllergyActionCode = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[6], false, seps) : null;
            AllergyUniqueIdentifier = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[7], false, seps) : null;
            ActionReason = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            SensitivityToCausativeAgentCode = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[9], false, seps) : null;
            AllergenGroupCodeMnemonicDescription = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[10], false, seps) : null;
            OnsetDate = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDateTime() : null;
            OnsetDateText = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            ReportedDateTime = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            ReportedBy = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<ExtendedPersonName>(segments[14], false, seps) : null;
            RelationshipToPatientCode = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[15], false, seps) : null;
            AlertDeviceCode = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[16], false, seps) : null;
            AllergyClinicalStatusCode = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[17], false, seps) : null;
            StatusedByPerson = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[18], false, seps) : null;
            StatusedByOrganization = segments.Length > 19 && segments[19].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[19], false, seps) : null;
            StatusedAtDateTime = segments.Length > 20 && segments[20].Length > 0 ? segments[20].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 21, Configuration.FieldSeparator),
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
                                StatusedAtDateTime.HasValue ? StatusedAtDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
