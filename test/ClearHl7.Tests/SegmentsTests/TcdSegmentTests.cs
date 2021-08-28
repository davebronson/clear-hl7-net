using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class TcdSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new TcdSegment
            {
                UniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                AutoDilutionFactor = new StructuredNumeric
                {
                    Comparator = "2"
                },
                RerunDilutionFactor = new StructuredNumeric
                {
                    Comparator = "3"
                },
                PreDilutionFactor = new StructuredNumeric
                {
                    Comparator = "4"
                },
                EndogenousContentOfPreDilutionDiluent = new StructuredNumeric
                {
                    Comparator = "5"
                },
                AutomaticRepeatAllowed = "6",
                ReflexAllowed = "7",
                AnalyteRepeatStatus = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                SpecimenConsumptionQuantity = new CompositeQuantityWithUnits
                {
                    Quantity = 9
                },
                PoolSize = 10,
                AutoDilutionType = new CodedWithExceptions
                {
                    Identifier = "11"
                }
            };

            ISegment actual = new TcdSegment();
            actual.FromDelimitedString("TCD|1|2|3|4|5|6|7|8|9|10|11");

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
                ISegment hl7Segment = new TcdSegment();
                hl7Segment.FromDelimitedString("TCA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new TcdSegment
            {
                UniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                AutoDilutionFactor = new StructuredNumeric
                {
                    Comparator = "2"
                },
                RerunDilutionFactor = new StructuredNumeric
                {
                    Comparator = "3"
                },
                PreDilutionFactor = new StructuredNumeric
                {
                    Comparator = "4"
                },
                EndogenousContentOfPreDilutionDiluent = new StructuredNumeric
                {
                    Comparator = "5"
                },
                AutomaticRepeatAllowed = "6",
                ReflexAllowed = "7",
                AnalyteRepeatStatus = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                SpecimenConsumptionQuantity = new CompositeQuantityWithUnits
                {
                    Quantity = 9
                },
                PoolSize = 10,
                AutoDilutionType = new CodedWithExceptions
                {
                    Identifier = "11"
                }
            };

            string expected = "TCD|1|2|3|4|5|6|7|8|9|10|11";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
