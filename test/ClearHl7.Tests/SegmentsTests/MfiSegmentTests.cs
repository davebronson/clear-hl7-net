﻿using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class MfiSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new MfiSegment
            {
                MasterFileIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                MasterFileApplicationIdentifier = new HierarchicDesignator[]
                {
                    new HierarchicDesignator
                    {
                        NamespaceId = "2"
                    }
                },
                FileLevelEventCode = "3",
                EnteredDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                EffectiveDateTime = new DateTime(2020, 5, 5, 0, 0, 5),
                ResponseLevelCode = "6"
            };

            string expected = "MFI|1|2|3|20200404000004|20200505000005|6";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
