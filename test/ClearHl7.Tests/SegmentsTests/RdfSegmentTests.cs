using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RdfSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RdfSegment
            {
                NumberOfColumnsPerRow = 1,
                ColumnDescription = new RowColumnDefinition[]
                {
                    new RowColumnDefinition
                    {
                        SegmentFieldName = "2"
                    }
                }
            };

            ISegment actual = new RdfSegment();
            actual.FromDelimitedString("RDF|1|2");

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
                ISegment hl7Segment = new RdfSegment();
                hl7Segment.FromDelimitedString("RDA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RdfSegment
            {
                NumberOfColumnsPerRow = 1,
                ColumnDescription = new RowColumnDefinition[]
                {
                    new RowColumnDefinition
                    {
                        SegmentFieldName = "2"
                    }
                }
            };

            string expected = "RDF|1|2";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
