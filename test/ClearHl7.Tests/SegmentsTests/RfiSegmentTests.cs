﻿using System;
using ClearHl7.V290.Segments;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RfiSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RfiSegment
            {
                RequestDate = new DateTime(2020, 1, 1, 0, 0, 1),
                ResponseDueDate = new DateTime(2020, 2, 2, 0, 0, 2),
                PatientConsent = "3",
                DateAdditionalInformationWasSubmitted = new DateTime(2020, 4, 4, 0, 0, 4)
            };

            string expected = "RFI|20200101000001|20200202000002|3|20200404000004";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
