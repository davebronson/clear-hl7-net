using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Tq1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Tq1Segment
            {
                SetIdTq1 = 1,
                Quantity = new CompositeQuantityWithUnits
                {
                    Quantity = 2
                },
                RepeatPattern = new RepeatPattern[]
                {
                    new RepeatPattern
                    {
                        RepeatPatternCode = new CodedWithExceptions
                        {
                            Identifier = "3"
                        }
                    }
                },
                ExplicitTime = new DateTime[]
                {
                    new DateTime(2020, 4, 4, 0, 0, 4)
                },
                RelativeTimeAndUnits = new CompositeQuantityWithUnits[]
                {
                    new CompositeQuantityWithUnits
                    {
                        Quantity = 5
                    }
                },
                ServiceDuration = new CompositeQuantityWithUnits
                {
                    Quantity = 6
                },
                StartDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                EndDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                Priority = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                ConditionText = new Text
                {
                    Value = "10"
                },
                TextInstruction = new Text
                {
                    Value = "11"
                },
                Conjunction = "12",
                OccurrenceDuration = new CompositeQuantityWithUnits
                {
                    Quantity = 13
                },
                TotalOccurrences = 14
            };

            ISegment actual = new Tq1Segment();
            actual.FromDelimitedString("TQ1|1|2|3|000004|5|6|20200707000007|20200808000008|9|10|11|12|13|14");

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
                ISegment hl7Segment = new Tq1Segment();
                hl7Segment.FromDelimitedString("TQA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Tq1Segment
            {
                SetIdTq1 = 1,
                Quantity = new CompositeQuantityWithUnits
                {
                    Quantity = 2
                },
                RepeatPattern = new RepeatPattern[]
                {
                    new RepeatPattern
                    {
                        RepeatPatternCode = new CodedWithExceptions
                        {
                            Identifier = "3"
                        }
                    }
                },
                ExplicitTime = new DateTime[]
                {
                    new DateTime(2020, 4, 4, 0, 0, 4)
                },
                RelativeTimeAndUnits = new CompositeQuantityWithUnits[]
                {
                    new CompositeQuantityWithUnits
                    {
                        Quantity = 5
                    }
                },
                ServiceDuration = new CompositeQuantityWithUnits
                {
                    Quantity = 6
                },
                StartDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                EndDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                Priority = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                ConditionText = new Text
                {
                    Value = "10"
                },
                TextInstruction = new Text
                {
                    Value = "11"
                },
                Conjunction = "12",
                OccurrenceDuration = new CompositeQuantityWithUnits
                {
                    Quantity = 13
                },
                TotalOccurrences = 14
            };

            string expected = "TQ1|1|2|3|000004|5|6|20200707000007|20200808000008|9|10|11|12|13|14";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
