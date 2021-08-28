using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class DpsSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new DpsSegment
            {
                DiagnosisCodeMcp = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                ProcedureCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                EffectiveDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                ExpirationDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                TypeOfLimitation = new CodedWithNoExceptions
                {
                    Identifier = "5"
                }
            };

            ISegment actual = new DpsSegment();
            actual.FromDelimitedString("DPS|1|2|20200303000003|20200404000004|5");

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
                ISegment hl7Segment = new DpsSegment();
                hl7Segment.FromDelimitedString("DPA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new DpsSegment
            {
                DiagnosisCodeMcp = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                ProcedureCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                EffectiveDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                ExpirationDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                TypeOfLimitation = new CodedWithNoExceptions
                {
                    Identifier = "5"
                }
            };

            string expected = "DPS|1|2|20200303000003|20200404000004|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
