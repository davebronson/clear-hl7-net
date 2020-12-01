using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0496</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0497</remarks>
        public CodedWithNoExceptions ConsentMode { get; set; }

        /// <summary>
        /// CON.11 - Consent Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0498</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string SubjectCompetenceIndicator { get; set; }

        /// <summary>
        /// CON.17 - Translator Assistance Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string TranslatorAssistanceIndicator { get; set; }

        /// <summary>
        /// CON.18 - Language Translated To.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0296</remarks>
        public string LanguageTranslatedTo { get; set; }

        /// <summary>
        /// CON.19 - Informational Material Supplied Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string InformationalMaterialSuppliedIndicator { get; set; }

        /// <summary>
        /// CON.20 - Consent Bypass Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0499</remarks>
        public CodedWithExceptions ConsentBypassReason { get; set; }

        /// <summary>
        /// CON.21 - Consent Disclosure Level.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0500</remarks>
        public string ConsentDisclosureLevel { get; set; }

        /// <summary>
        /// CON.22 - Consent Non-disclosure Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0501</remarks>
        public CodedWithExceptions ConsentNonDisclosureReason { get; set; }

        /// <summary>
        /// CON.23 - Non-subject Consenter Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0502</remarks>
        public CodedWithExceptions NonSubjectConsenterReason { get; set; }

        /// <summary>
        /// CON.24 - Consenter ID.
        /// </summary>
        public IEnumerable<ExtendedPersonName> ConsenterId { get; set; }

        /// <summary>
        /// CON.25 - Relationship to Subject.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0548</remarks>
        public IEnumerable<string> RelationshipToSubject { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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
                                LanguageTranslatedTo,
                                InformationalMaterialSuppliedIndicator,
                                ConsentBypassReason?.ToDelimitedString(),
                                ConsentDisclosureLevel,
                                ConsentNonDisclosureReason?.ToDelimitedString(),
                                NonSubjectConsenterReason?.ToDelimitedString(),
                                ConsenterId != null ? string.Join(Configuration.FieldRepeatSeparator, ConsenterId.Select(x => x.ToDelimitedString())) : null,
                                RelationshipToSubject != null ? string.Join(Configuration.FieldRepeatSeparator, RelationshipToSubject) : null
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}