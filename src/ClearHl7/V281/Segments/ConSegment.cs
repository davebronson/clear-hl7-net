using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CON - Consent Segment.
    /// </summary>
    public class ConSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConSegment"/> class.
        /// </summary>
        public ConSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public ConSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "CON";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// CON.1 - Set ID - CON.
        /// </summary>
        public uint? SetIdCon { get; set; }

        /// <summary>
        /// CON.2 - Consent Type.
        /// <para>Suggested: 0496 Consent Type -&gt; ClearHl7.Codes.V281.CodeConsentType</para>
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
        /// <para>Suggested: 0497 Consent Mode -&gt; ClearHl7.Codes.V281.CodeConsentMode</para>
        /// </summary>
        public CodedWithNoExceptions ConsentMode { get; set; }

        /// <summary>
        /// CON.11 - Consent Status.
        /// <para>Suggested: 0498 Consent Status -&gt; ClearHl7.Codes.V281.CodeConsentStatus</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string SubjectCompetenceIndicator { get; set; }

        /// <summary>
        /// CON.17 - Translator Assistance Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string TranslatorAssistanceIndicator { get; set; }

        /// <summary>
        /// CON.18 - Language Translated To.
        /// <para>Suggested: 0296 Primary Language</para>
        /// </summary>
        public CodedWithExceptions LanguageTranslatedTo { get; set; }

        /// <summary>
        /// CON.19 - Informational Material Supplied Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string InformationalMaterialSuppliedIndicator { get; set; }

        /// <summary>
        /// CON.20 - Consent Bypass Reason.
        /// <para>Suggested: 0499 Consent Bypass Reason -&gt; ClearHl7.Codes.V281.CodeConsentBypassReason</para>
        /// </summary>
        public CodedWithExceptions ConsentBypassReason { get; set; }

        /// <summary>
        /// CON.21 - Consent Disclosure Level.
        /// <para>Suggested: 0500 Consent Disclosure Level -&gt; ClearHl7.Codes.V281.CodeConsentDisclosureLevel</para>
        /// </summary>
        public string ConsentDisclosureLevel { get; set; }

        /// <summary>
        /// CON.22 - Consent Non-disclosure Reason.
        /// <para>Suggested: 0501 Consent Non-Disclosure Reason -&gt; ClearHl7.Codes.V281.CodeConsentNonDisclosureReason</para>
        /// </summary>
        public CodedWithExceptions ConsentNonDisclosureReason { get; set; }

        /// <summary>
        /// CON.23 - Non-subject Consenter Reason.
        /// <para>Suggested: 0502 Non-Subject Consenter Reason -&gt; ClearHl7.Codes.V281.CodeNonSubjectConsenterReason</para>
        /// </summary>
        public CodedWithExceptions NonSubjectConsenterReason { get; set; }

        /// <summary>
        /// CON.24 - Consenter ID.
        /// </summary>
        public IEnumerable<ExtendedPersonName> ConsenterId { get; set; }

        /// <summary>
        /// CON.25 - Relationship to Subject.
        /// <para>Suggested: 0548 Signatory's Relationship To Subject -&gt; ClearHl7.Codes.V281.CodeSignatorysRelationshipToSubject</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> RelationshipToSubject { get; set; }

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

            SetIdCon = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            ConsentType = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            ConsentFormIdAndVersion = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            ConsentFormNumber = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[4], false, seps) : null;
            ConsentText = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SubjectSpecificConsentText = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            ConsentBackgroundInformation = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SubjectSpecificConsentBackgroundText = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            ConsenterImposedLimitations = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            ConsentMode = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[10], false, seps) : null;
            ConsentStatus = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedWithNoExceptions>(segments[11], false, seps) : null;
            ConsentDiscussionDateTime = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDateTime() : null;
            ConsentDecisionDateTime = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            ConsentEffectiveDateTime = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            ConsentEndDateTime = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDateTime() : null;
            SubjectCompetenceIndicator = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
            TranslatorAssistanceIndicator = segments.Length > 17 && segments[17].Length > 0 ? segments[17] : null;
            LanguageTranslatedTo = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[18], false, seps) : null;
            InformationalMaterialSuppliedIndicator = segments.Length > 19 && segments[19].Length > 0 ? segments[19] : null;
            ConsentBypassReason = segments.Length > 20 && segments[20].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[20], false, seps) : null;
            ConsentDisclosureLevel = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            ConsentNonDisclosureReason = segments.Length > 22 && segments[22].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[22], false, seps) : null;
            NonSubjectConsenterReason = segments.Length > 23 && segments[23].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[23], false, seps) : null;
            ConsenterId = segments.Length > 24 && segments[24].Length > 0 ? segments[24].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
            RelationshipToSubject = segments.Length > 25 && segments[25].Length > 0 ? segments[25].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
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
                                ConsentDiscussionDateTime.ToHl7DateTimeString(typeof(ConSegment), nameof(ConsentDiscussionDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ConsentDecisionDateTime.ToHl7DateTimeString(typeof(ConSegment), nameof(ConsentDecisionDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ConsentEffectiveDateTime.ToHl7DateTimeString(typeof(ConSegment), nameof(ConsentEffectiveDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ConsentEndDateTime.ToHl7DateTimeString(typeof(ConSegment), nameof(ConsentEndDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
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
