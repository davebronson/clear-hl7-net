using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class MfiSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new MfiSegment
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

            ISegment actual = new MfiSegment();
            actual.FromDelimitedString("MFI|1|2|3|20200404000004|20200505000005|6");

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
                ISegment hl7Segment = new MfiSegment();
                hl7Segment.FromDelimitedString("MFA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
