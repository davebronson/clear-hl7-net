using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OMC - Supporting Clinical Information.
    /// </summary>
    public class OmcSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OmcSegment"/> class.
        /// </summary>
        public OmcSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmcSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public OmcSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "OMC";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// OMC.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OMC.2 - Segment Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V290.CodeSegmentActionCode</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string AnswerRequired { get; set; }

        /// <summary>
        /// OMC.8 - Hint/Help Text.
        /// </summary>
        public string HintHelpText { get; set; }

        /// <summary>
        /// OMC.9 - Type of Answer.
        /// <para>Suggested: 0125 Value Type -&gt; ClearHl7.Codes.V290.CodeValueType</para>
        /// </summary>
        public string TypeOfAnswer { get; set; }

        /// <summary>
        /// OMC.10 - Multiple Answers Allowed.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
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

            SequenceNumberTestObservationMasterFile = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            SegmentActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            SegmentUniqueKey = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[3], false, seps) : null;
            ClinicalInformationRequest = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            CollectionEventProcessStep = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            CommunicationLocation = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            AnswerRequired = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            HintHelpText = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            TypeOfAnswer = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            MultipleAnswersAllowed = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            AnswerChoices = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            CharacterLimit = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDecimal() : null;
            NumberOfDecimals = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDecimal() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
