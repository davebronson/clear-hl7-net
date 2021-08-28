using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RxrSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RxrSegment
            {
                Route = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                AdministrationSite = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AdministrationDevice = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                AdministrationMethod = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                RoutingInstruction = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                AdministrationSiteModifier = new CodedWithExceptions
                {
                    Identifier = "6"
                }
            };

            ISegment actual = new RxrSegment();
            actual.FromDelimitedString("RXR|1|2|3|4|5|6");

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
                ISegment hl7Segment = new RxrSegment();
                hl7Segment.FromDelimitedString("RXA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RxrSegment
            {
                Route = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                AdministrationSite = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AdministrationDevice = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                AdministrationMethod = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                RoutingInstruction = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                AdministrationSiteModifier = new CodedWithExceptions
                {
                    Identifier = "6"
                }
            };

            string expected = "RXR|1|2|3|4|5|6";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
