using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Gp1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Gp1Segment
            {
                TypeOfBillCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                RevenueCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                OverallClaimDispositionCode = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                OceEditsPerVisitCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                },
                OutlierCost = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 5
                    }
                }
            };

            ISegment actual = new Gp1Segment();
            actual.FromDelimitedString("GP1|1|2|3|4|5");

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
                ISegment hl7Segment = new Gp1Segment();
                hl7Segment.FromDelimitedString("GPA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Gp1Segment
            {
                TypeOfBillCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                RevenueCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                OverallClaimDispositionCode = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                OceEditsPerVisitCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                },
                OutlierCost = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 5
                    }
                }
            };

            string expected = "GP1|1|2|3|4|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
