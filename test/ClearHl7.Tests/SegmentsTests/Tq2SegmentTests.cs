using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Tq2SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Tq2Segment
            {
                SetIdTq2 = 1,
                SequenceResultsFlag = "2",
                RelatedPlacerNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "3"
                    }
                },
                RelatedFillerNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "4"
                    }
                },
                RelatedPlacerGroupNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "5"
                    }
                },
                SequenceConditionCode = "6",
                CyclicEntryExitIndicator = "7",
                SequenceConditionTimeInterval = new CompositeQuantityWithUnits
                {
                    Quantity = 8
                },
                CyclicGroupMaximumNumberOfRepeats = 9,
                SpecialServiceRequestRelationship = "10"
            };

            ISegment actual = new Tq2Segment();
            actual.FromDelimitedString("TQ2|1|2|3|4|5|6|7|8|9|10");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that calling FromDelimitedString() with a string input containing an incorrect segment ID results in an ArgumentException being thrown.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithIncorrectSegmentId_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ISegment hl7Segment = new Tq2Segment();
                hl7Segment.FromDelimitedString("TQA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Tq2Segment
            {
                SetIdTq2 = 1,
                SequenceResultsFlag = "2",
                RelatedPlacerNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "3"
                    }
                },
                RelatedFillerNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "4"
                    }
                },
                RelatedPlacerGroupNumber = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "5"
                    }
                },
                SequenceConditionCode = "6",
                CyclicEntryExitIndicator = "7",
                SequenceConditionTimeInterval = new CompositeQuantityWithUnits
                {
                    Quantity = 8
                },
                CyclicGroupMaximumNumberOfRepeats = 9,
                SpecialServiceRequestRelationship = "10"
            };

            string expected = "TQ2|1|2|3|4|5|6|7|8|9|10";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
