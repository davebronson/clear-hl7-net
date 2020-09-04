using System;

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

        ///// <summary>
        ///// OMC.1 - Sequence Number - Test/Observation Master File.
        ///// </summary>
        //public SequenceNumberTestObservationMasterFile { get; set; }

        ///// <summary>
        ///// OMC.2 - Segment Action Code.
        ///// </summary>
        //public SegmentActionCode { get; set; }

        ///// <summary>
        ///// OMC.3 - Segment Unique Key.
        ///// </summary>
        //public SegmentUniqueKey { get; set; }

        ///// <summary>
        ///// OMC.4 - Clinical Information Request.
        ///// </summary>
        //public ClinicalInformationRequest { get; set; }

        ///// <summary>
        ///// OMC.5 - Collection Event/Process Step.
        ///// </summary>
        //public CollectionEventProcessStep { get; set; }

        ///// <summary>
        ///// OMC.6 - Communication Location.
        ///// </summary>
        //public CommunicationLocation { get; set; }

        ///// <summary>
        ///// OMC.7 - Answer Required.
        ///// </summary>
        //public AnswerRequired { get; set; }

        ///// <summary>
        ///// OMC.8 - Hint/Help Text.
        ///// </summary>
        //public HintHelpText { get; set; }

        ///// <summary>
        ///// OMC.9 - Type of Answer.
        ///// </summary>
        //public TypeOfAnswer { get; set; }

        ///// <summary>
        ///// OMC.10 - Multiple Answers Allowed.
        ///// </summary>
        //public MultipleAnswersAllowed { get; set; }

        ///// <summary>
        ///// OMC.11 - Answer Choices.
        ///// </summary>
        //public AnswerChoices { get; set; }

        ///// <summary>
        ///// OMC.12 - Character Limit.
        ///// </summary>
        //public CharacterLimit { get; set; }

        ///// <summary>
        ///// OMC.13 - Number of Decimals.
        ///// </summary>
        //public NumberOfDecimals { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}"
                                ).TrimEnd('|');
        }
    }
}