using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class VarSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new VarSegment
            {
                VarianceInstanceId = new EntityIdentifier
                {
                    EntityId = "1"
                },
                DocumentedDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                StatedVarianceDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                VarianceOriginator = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "4"
                    }
                },
                VarianceClassification = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                VarianceDescription = new string[]
                {
                    "6"
                }
            };

            string expected = "VAR|1|20200202000002|20200303000003|4|5|6";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
