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
    /// HL7 Version 2 Segment CON - Consent Segment.
    /// </summary>
    public class ConSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CON";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CON.1 - Set ID - CON.
        /// </summary>
        public uint? SetIdCon { get; set; }

        /// <summary>
        /// CON.2 - Consent Type.
        /// <para>Suggested: 0496 Consent Type -&gt; ClearHl7.Codes.V271.CodeConsentType</para>
        /// </summary>
        public CodedWithExceptions ConsentType { get; set; }

        /// <summary>
        /// CON.3 - Consent Form ID and Version.
        /// </summary>
        public string ConsentFormIdAndVersion { get; set; }

        /// <summary>
        /// CON.4 - Consent Form Number.
        /// </summary>
        public EntityIdentifier ConsentFormNumber { get; set; }

        /// <summary>
        /// CON.5 - Consent Text.
        /// </summary>
        public IEnumerable<string> ConsentText { get; set; }

        /// <summary>
        /// CON.6 - Subject-specific Consent Text.
        /// </summary>
        public IEnumerable<string> SubjectSpecificConsentText { get; set; }

        /// <summary>
        /// CON.7 - Consent Background Information.
        /// </summary>
        public IEnumerable<string> ConsentBackgroundInformation { get; set; }

        /// <summary>
        /// CON.8 - Subject-specific Consent Background Text.
        /// </summary>
        public IEnumerable<string> SubjectSpecificConsentBackgroundText { get; set; }

        /// <summary>
        /// CON.9 - Consenter-imposed limitations.
        /// </summary>
        public IEnumerable<string> ConsenterImposedLimitations { get; set; }

        /// <summary>
        /// CON.10 - Consent Mode.
        /// <para>Suggested: 0497 Consent Mode -&gt; ClearHl7.Codes.V271.CodeConsentMode</para>
        /// </summary>
        public CodedWithNoExceptions ConsentMode { get; set; }

        /// <summary>
        /// CON.11 - Consent Status.
        /// <para>Suggested: 0498 Consent Status -&gt; ClearHl7.Codes.V271.CodeConsentStatus</para>
        /// </summary>
        public CodedWithNoExceptions ConsentStatus { get; set; }

        /// <summary>
        /// CON.12 - Consent Discussion Date/Time.
        /// </summary>
        public DateTime? ConsentDiscussionDateTime { get; set; }

        /// <summary>
        /// CON.13 - Consent Decision Date/Time.
        /// </summary>
        public DateTime? ConsentDecisionDateTime { get; set; }

        /// <summary>
        /// CON.14 - Consent Effective Date/Time.
        /// </summary>
        public DateTime? ConsentEffectiveDateTime { get; set; }

        /// <summary>
        /// CON.15 - Consent End Date/Time.
        /// </summary>
        public DateTime? ConsentEndDateTime { get; set; }

        /// <summary>
        /// CON.16 - Subject Competence Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string SubjectCompetenceIndicator { get; set; }

        /// <summary>
        /// CON.17 - Translator Assistance Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string TranslatorAssistanceIndicator { get; set; }

        /// <summary>
        /// CON.18 - Language Translated To.
        /// <para>Suggested: 0296 Primary Language</para>
        /// </summary>
        public CodedWithExceptions LanguageTranslatedTo { get; set; }

        /// <summary>
        /// CON.19 - Informational Material Supplied Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V271.CodeYesNoIndicator</para>
        /// </summary>
        public string InformationalMaterialSuppliedIndicator { get; set; }

        /// <summary>
        /// CON.20 - Consent Bypass Reason.
        /// <para>Suggested: 0499 Consent Bypass Reason -&gt; ClearHl7.Codes.V271.CodeConsentBypassReason</para>
        /// </summary>
        public CodedWithExceptions ConsentBypassReason { get; set; }

        /// <summary>
        /// CON.21 - Consent Disclosure Level.
        /// <para>Suggested: 0500 Consent Disclosure Level -&gt; ClearHl7.Codes.V271.CodeConsentDisclosureLevel</para>
        /// </summary>
        public string ConsentDisclosureLevel { get; set; }

        /// <summary>
        /// CON.22 - Consent Non-disclosure Reason.
        /// <para>Suggested: 0501 Consent Non-Disclosure Reason -&gt; ClearHl7.Codes.V271.CodeConsentNonDisclosureReason</para>
        /// </summary>
        public CodedWithExceptions ConsentNonDisclosureReason { get; set; }

        /// <summary>
        /// CON.23 - Non-subject Consenter Reason.
        /// <para>Suggested: 0502 Non-Subject Consenter Reason -&gt; ClearHl7.Codes.V271.CodeNonSubjectConsenterReason</para>
        /// </summary>
        public CodedWithExceptions NonSubjectConsenterReason { get; set; }

        /// <summary>
        /// CON.24 - Consenter ID.
        /// </summary>
        public IEnumerable<ExtendedPersonName> ConsenterId { get; set; }

        /// <summary>
        /// CON.25 - Relationship to Subject.
        /// <para>Suggested: 0548 Signatory's Relationship To Subject -&gt; ClearHl7.Codes.V271.CodeSignatorysRelationshipToSubject</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> RelationshipToSubject { get; set; }

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

            SetIdCon = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            ConsentType = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            ConsentFormIdAndVersion = segments.ElementAtOrDefault(3);
            ConsentFormNumber = segments.Length > 4 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(4), false) : null;
            ConsentText = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator) : null;
            SubjectSpecificConsentText = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator) : null;
            ConsentBackgroundInformation = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator) : null;
            SubjectSpecificConsentBackgroundText = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator) : null;
            ConsenterImposedLimitations = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator) : null;
            ConsentMode = segments.Length > 10 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(10), false) : null;
            ConsentStatus = segments.Length > 11 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(11), false) : null;
            ConsentDiscussionDateTime = segments.ElementAtOrDefault(12)?.ToNullableDateTime();
            ConsentDecisionDateTime = segments.ElementAtOrDefault(13)?.ToNullableDateTime();
            ConsentEffectiveDateTime = segments.ElementAtOrDefault(14)?.ToNullableDateTime();
            ConsentEndDateTime = segments.ElementAtOrDefault(15)?.ToNullableDateTime();
            SubjectCompetenceIndicator = segments.ElementAtOrDefault(16);
            TranslatorAssistanceIndicator = segments.ElementAtOrDefault(17);
            LanguageTranslatedTo = segments.Length > 18 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(18), false) : null;
            InformationalMaterialSuppliedIndicator = segments.ElementAtOrDefault(19);
            ConsentBypassReason = segments.Length > 20 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(20), false) : null;
            ConsentDisclosureLevel = segments.ElementAtOrDefault(21);
            ConsentNonDisclosureReason = segments.Length > 22 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(22), false) : null;
            NonSubjectConsenterReason = segments.Length > 23 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(23), false) : null;
            ConsenterId = segments.Length > 24 ? segments.ElementAtOrDefault(24).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            RelationshipToSubject = segments.Length > 25 ? segments.ElementAtOrDefault(25).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 26, Configuration.FieldSeparator),
                                Id,
                                SetIdCon.HasValue ? SetIdCon.Value.ToString(culture) : null,
                                ConsentType?.ToDelimitedString(),
                                ConsentFormIdAndVersion,
                                ConsentFormNumber?.ToDelimitedString(),
                                ConsentText != null ? string.Join(Configuration.FieldRepeatSeparator, ConsentText) : null,
                                SubjectSpecificConsentText != null ? string.Join(Configuration.FieldRepeatSeparator, SubjectSpecificConsentText) : null,
                                ConsentBackgroundInformation != null ? string.Join(Configuration.FieldRepeatSeparator, ConsentBackgroundInformation) : null,
                                SubjectSpecificConsentBackgroundText != null ? string.Join(Configuration.FieldRepeatSeparator, SubjectSpecificConsentBackgroundText) : null,
                                ConsenterImposedLimitations != null ? string.Join(Configuration.FieldRepeatSeparator, ConsenterImposedLimitations) : null,
                                ConsentMode?.ToDelimitedString(),
                                ConsentStatus?.ToDelimitedString(),
                                ConsentDiscussionDateTime.HasValue ? ConsentDiscussionDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ConsentDecisionDateTime.HasValue ? ConsentDecisionDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ConsentEffectiveDateTime.HasValue ? ConsentEffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ConsentEndDateTime.HasValue ? ConsentEndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                SubjectCompetenceIndicator,
                                TranslatorAssistanceIndicator,
                                LanguageTranslatedTo?.ToDelimitedString(),
                                InformationalMaterialSuppliedIndicator,
                                ConsentBypassReason?.ToDelimitedString(),
                                ConsentDisclosureLevel,
                                ConsentNonDisclosureReason?.ToDelimitedString(),
                                NonSubjectConsenterReason?.ToDelimitedString(),
                                ConsenterId != null ? string.Join(Configuration.FieldRepeatSeparator, ConsenterId.Select(x => x.ToDelimitedString())) : null,
                                RelationshipToSubject != null ? string.Join(Configuration.FieldRepeatSeparator, RelationshipToSubject.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}