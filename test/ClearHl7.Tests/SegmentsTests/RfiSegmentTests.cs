using System;
using ClearHl7.V290.Segments;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RfiSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RfiSegment
            {
                RequestDate = new DateTime(2020, 1, 1, 0, 0, 1),
                ResponseDueDate = new DateTime(2020, 2, 2, 0, 0, 2),
                PatientConsent = "3",
                DateAdditionalInformationWasSubmitted = new DateTime(2020, 4, 4, 0, 0, 4)
            };

            ISegment actual = new RfiSegment();
            actual.FromDelimitedString("RFI|20200101000001|20200202000002|3|20200404000004");

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
                ISegment hl7Segment = new RfiSegment();
                hl7Segment.FromDelimitedString("RFA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
