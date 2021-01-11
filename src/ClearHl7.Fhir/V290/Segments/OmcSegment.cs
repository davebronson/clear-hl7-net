using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V290.Types;

namespace ClearHl7.Fhir.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OMC - Supporting Clinical Information.
    /// </summary>
    public class OmcSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OMC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OMC.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OMC.2 - Segment Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Fhir.Codes.V290.CodeSegmentActionCode</para>
        /// </summary>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// OMC.3 - Segment Unique Key.
        /// </summary>
        public EntityIdentifier SegmentUniqueKey { get; set; }

        /// <summary>
        /// OMC.4 - Clinical Information Request.
        /// <para>Suggested: 0664 Clinical Information Request</para>
        /// </summary>
        public CodedWithExceptions ClinicalInformationRequest { get; set; }

        /// <summary>
        /// OMC.5 - Collection Event/Process Step.
        /// <para>Suggested: 0938 Collection Event/Process Step</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> CollectionEventProcessStep { get; set; }

        /// <summary>
        /// OMC.6 - Communication Location.
        /// <para>Suggested: 0939 Communication Location</para>
        /// </summary>
        public CodedWithExceptions CommunicationLocation { get; set; }

        /// <summary>
        /// OMC.7 - Answer Required.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Fhir.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string AnswerRequired { get; set; }

        /// <summary>
        /// OMC.8 - Hint/Help Text.
        /// </summary>
        public string HintHelpText { get; set; }

        /// <summary>
        /// OMC.9 - Type of Answer.
        /// <para>Suggested: 0125 Value Type -&gt; ClearHl7.Fhir.Codes.V290.CodeValueType</para>
        /// </summary>
        public string TypeOfAnswer { get; set; }

        /// <summary>
        /// OMC.10 - Multiple Answers Allowed.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Fhir.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string MultipleAnswersAllowed { get; set; }

        /// <summary>
        /// OMC.11 - Answer Choices.
        /// <para>Suggested: 0665 Answer Choices</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> AnswerChoices { get; set; }

        /// <summary>
        /// OMC.12 - Character Limit.
        /// </summary>
        public decimal? CharacterLimit { get; set; }

        /// <summary>
        /// OMC.13 - Number of Decimals.
        /// </summary>
        public decimal? NumberOfDecimals { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 14, Configuration.FieldSeparator),
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                SegmentActionCode,
                                SegmentUniqueKey?.ToDelimitedString(),
                                ClinicalInformationRequest?.ToDelimitedString(),
                                CollectionEventProcessStep != null ? string.Join(Configuration.FieldRepeatSeparator, CollectionEventProcessStep.Select(x => x.ToDelimitedString())) : null,
                                CommunicationLocation?.ToDelimitedString(),
                                AnswerRequired,
                                HintHelpText,
                                TypeOfAnswer,
                                MultipleAnswersAllowed,
                                AnswerChoices != null ? string.Join(Configuration.FieldRepeatSeparator, AnswerChoices.Select(x => x.ToDelimitedString())) : null,
                                CharacterLimit.HasValue ? CharacterLimit.Value.ToString(Consts.NumericFormat, culture) : null,
                                NumberOfDecimals.HasValue ? NumberOfDecimals.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}