using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class IpcSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new IpcSegment
            {
                AccessionIdentifier = new EntityIdentifier
                {
                    EntityId = "1"
                },
                RequestedProcedureId = new EntityIdentifier
                {
                    EntityId = "2"
                },
                StudyInstanceUid = new EntityIdentifier
                {
                    EntityId = "3"
                },
                ScheduledProcedureStepId = new EntityIdentifier
                {
                    EntityId = "4"
                },
                Modality = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ProtocolCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "6"
                    }
                },
                ScheduledStationName = new EntityIdentifier
                {
                    EntityId = "7"
                },
                ScheduledProcedureStepLocation = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "8"
                    }
                },
                ScheduledStationAeTitle = "9",
                ActionCode = "10"
            };

            string expected = "IPC|1|2|3|4|5|6|7|8|9|10";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
