﻿using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class IsdSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new IsdSegment
            {
                ReferenceInteractionNumber = 1,
                InteractionTypeIdentifier = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                InteractionActiveState = new CodedWithExceptions
                {
                    Identifier = "3"
                }
            };

            string expected = "ISD|1|2|3";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
