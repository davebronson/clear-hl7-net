using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Rq1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Rq1Segment
            {
                AnticipatedPrice = "1",
                ManufacturerIdentifier = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ManufacturersCatalog = "3",
                VendorId = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                VendorCatalog = "5",
                Taxable = "6",
                SubstituteAllowed = "7"
            };

            ISegment actual = new Rq1Segment();
            actual.FromDelimitedString("RQ1|1|2|3|4|5|6|7");

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
                ISegment hl7Segment = new Rq1Segment();
                hl7Segment.FromDelimitedString("RQA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Rq1Segment
            {
                AnticipatedPrice = "1",
                ManufacturerIdentifier = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ManufacturersCatalog = "3",
                VendorId = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                VendorCatalog = "5",
                Taxable = "6",
                SubstituteAllowed = "7"
            };

            string expected = "RQ1|1|2|3|4|5|6|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
