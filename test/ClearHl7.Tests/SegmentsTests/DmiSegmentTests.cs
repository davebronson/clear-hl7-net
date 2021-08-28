using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class DmiSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new DmiSegment
            {
                DiagnosticRelatedGroup = new CodedWithNoExceptions
                {
                    Identifier = "1"
                },
                MajorDiagnosticCategory = new CodedWithNoExceptions
                {
                    Identifier = "2"
                },
                LowerAndUpperTrimPoints = new NumericRange
                {
                    LowValue = 3
                },
                AverageLengthOfStay = 4,
                RelativeWeight = 5
            };

            ISegment actual = new DmiSegment();
            actual.FromDelimitedString("DMI|1|2|3|4|5");

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
                ISegment hl7Segment = new DmiSegment();
                hl7Segment.FromDelimitedString("DMA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new DmiSegment
            {
                DiagnosticRelatedGroup = new CodedWithNoExceptions
                {
                    Identifier = "1"
                },
                MajorDiagnosticCategory = new CodedWithNoExceptions
                {
                    Identifier = "2"
                },
                LowerAndUpperTrimPoints = new NumericRange
                {
                    LowValue = 3
                },
                AverageLengthOfStay = 4,
                RelativeWeight = 5
            };

            string expected = "DMI|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
