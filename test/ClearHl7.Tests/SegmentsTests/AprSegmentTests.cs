using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class AprSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new AprSegment
            {
                TimeSelectionCriteria = new SchedulingClassValuePair[]
                {
                    new SchedulingClassValuePair
                    {
                        ParameterClass = new CodedWithExceptions
                        {
                            Identifier = "1"
                        }
                    }
                },
                ResourceSelectionCriteria = new SchedulingClassValuePair[]
                {
                    new SchedulingClassValuePair
                    {
                        ParameterClass = new CodedWithExceptions
                        {
                            Identifier = "2"
                        }
                    }
                },
                LocationSelectionCriteria = new SchedulingClassValuePair[]
                {
                    new SchedulingClassValuePair
                    {
                        ParameterClass = new CodedWithExceptions
                        {
                            Identifier = "3"
                        }
                    }
                },
                SlotSpacingCriteria = 4,
                FillerOverrideCriteria = new SchedulingClassValuePair[]
                {
                    new SchedulingClassValuePair
                    {
                        ParameterClass = new CodedWithExceptions
                        {
                            Identifier = "5"
                        }
                    }
                },
            };

            string expected = "APR|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
