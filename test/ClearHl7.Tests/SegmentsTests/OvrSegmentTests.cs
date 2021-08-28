using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class OvrSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new OvrSegment
            {
                BusinessRuleOverrideType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                BusinessRuleOverrideCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                OverrideComments = new Text
                {
                    Value = "3"
                },
                OverrideEnteredBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "4"
                },
                OverrideAuthorizedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "5"
                }
            };

            ISegment actual = new OvrSegment();
            actual.FromDelimitedString("OVR|1|2|3|4|5");

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
                ISegment hl7Segment = new OvrSegment();
                hl7Segment.FromDelimitedString("OVA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new OvrSegment
            {
                BusinessRuleOverrideType = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                BusinessRuleOverrideCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                OverrideComments = new Text
                {
                    Value = "3"
                },
                OverrideEnteredBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "4"
                },
                OverrideAuthorizedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "5"
                }
            };

            string expected = "OVR|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
