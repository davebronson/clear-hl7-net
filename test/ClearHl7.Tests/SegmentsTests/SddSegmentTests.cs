using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class SddSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new SddSegment
            {
                LotNumber = new EntityIdentifier
                {
                    EntityId = "1"
                },
                DeviceNumber = new EntityIdentifier
                {
                    EntityId = "2"
                },
                DeviceName = "3",
                DeviceDataState = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                LoadStatus = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ControlCode = 6,
                OperatorName = "7"
            };

            ISegment actual = new SddSegment();
            actual.FromDelimitedString("SDD|1|2|3|4|5|6|7");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new SddSegment
            {
                LotNumber = new EntityIdentifier
                {
                    EntityId = "1"
                },
                DeviceNumber = new EntityIdentifier
                {
                    EntityId = "2"
                },
                DeviceName = "3",
                DeviceDataState = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                LoadStatus = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ControlCode = 6,
                OperatorName = "7"
            };

            string expected = "SDD|1|2|3|4|5|6|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
