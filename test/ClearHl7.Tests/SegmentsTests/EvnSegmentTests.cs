using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class EvnSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new EvnSegment
            {
                EventTypeCode = "1",
                RecordedDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                DateTimePlannedEvent = new DateTime(2020, 3, 3, 0, 0, 3),
                EventReasonCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                OperatorId = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "5"
                    }
                },
                EventOccurred = new DateTime(2020, 6, 6, 0, 0, 6),
                EventFacility = new HierarchicDesignator
                {
                    NamespaceId = "7"
                }
            };

            ISegment actual = new EvnSegment();
            actual.FromDelimitedString("EVN|1|20200202000002|20200303000003|4|5|20200606000006|7");

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
                ISegment hl7Segment = new EvnSegment();
                hl7Segment.FromDelimitedString("EVA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new EvnSegment
            {
                EventTypeCode = "1",
                RecordedDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                DateTimePlannedEvent = new DateTime(2020, 3, 3, 0, 0, 3),
                EventReasonCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                OperatorId = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "5"
                    }
                },
                EventOccurred = new DateTime(2020, 6, 6, 0, 0, 6),
                EventFacility = new HierarchicDesignator
                {
                    NamespaceId = "7"
                }
            };

            string expected = "EVN|1|20200202000002|20200303000003|4|5|20200606000006|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
