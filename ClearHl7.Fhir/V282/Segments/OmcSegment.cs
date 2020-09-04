using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V282.Types;

namespace ClearHl7.Fhir.V282.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0206</remarks>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// OMC.3 - Segment Unique Key.
        /// </summary>
        public EntityIdentifier SegmentUniqueKey { get; set; }

        /// <summary>
        /// OMC.4 - Clinical Information Request.
        /// </summary>
        public CodedWithExceptions ClinicalInformationRequest { get; set; }

        /// <summary>
        /// OMC.5 - Collection Event/Process Step.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0938</remarks>
        public IEnumerable<CodedWithExceptions> CollectionEventProcessStep { get; set; }

        /// <summary>
        /// OMC.6 - Communication Location.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0939</remarks>
        public CodedWithExceptions CommunicationLocation { get; set; }

        /// <summary>
        /// OMC.7 - Answer Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string AnswerRequired { get; set; }

        /// <summary>
        /// OMC.8 - Hint/Help Text.
        /// </summary>
        public string HintHelpText { get; set; }

        /// <summary>
        /// OMC.9 - Type of Answer.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0125</remarks>
        public string TypeOfAnswer { get; set; }

        /// <summary>
        /// OMC.10 - Multiple Answers Allowed.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string MultipleAnswersAllowed { get; set; }

        /// <summary>
        /// OMC.11 - Answer Choices.
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
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}",
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                SegmentActionCode,
                                SegmentUniqueKey?.ToDelimitedString(),
                                ClinicalInformationRequest?.ToDelimitedString(),
                                CollectionEventProcessStep != null ? string.Join("~", CollectionEventProcessStep.Select(x => x.ToDelimitedString())) : null,
                                CommunicationLocation?.ToDelimitedString(),
                                AnswerRequired,
                                HintHelpText,
                                TypeOfAnswer,
                                MultipleAnswersAllowed,
                                AnswerChoices != null ? string.Join("~", AnswerChoices.Select(x => x.ToDelimitedString())) : null,
                                CharacterLimit.HasValue ? CharacterLimit.Value.ToString(Consts.NumericFormat, culture) : null,
                                NumberOfDecimals.HasValue ? NumberOfDecimals.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd('|');
        }
    }
}