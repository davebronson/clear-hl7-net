using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class EcrSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new EcrSegment
            {
                CommandResponse = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                DateTimeCompleted = new DateTime(2020, 2, 2, 0, 0, 2),
                CommandResponseParameters = new Text[]
                {
                    new Text
                    {
                        Value = "3"
                    }
                }
            };

            string expected = "ECR|1|20200202000002|3";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
