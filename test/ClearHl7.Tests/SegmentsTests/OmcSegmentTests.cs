using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class OmcSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new OmcSegment
            {
                SequenceNumberTestObservationMasterFile = 1,
                SegmentActionCode = "2",
                SegmentUniqueKey = new EntityIdentifier
                {
                    EntityId = "3"
                },
                ClinicalInformationRequest = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                CollectionEventProcessStep = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "5"
                    }
                },
                CommunicationLocation = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                AnswerRequired = "7",
                HintHelpText = "8",
                TypeOfAnswer = "9",
                MultipleAnswersAllowed = "10",
                AnswerChoices = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                CharacterLimit = 12,
                NumberOfDecimals = 13
            };

            string expected = "OMC|1|2|3|4|5|6|7|8|9|10|11|12|13";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
