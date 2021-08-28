using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Om2SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Om2Segment
            {
                SequenceNumberTestObservationMasterFile = 1,
                UnitsOfMeasure = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                RangeOfDecimalPrecision = new decimal[]
                {
                    3
                },
                CorrespondingSiUnitsOfMeasure = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                SiConversionFactor = new Text
                {
                    Value = "5"
                },
                ReferenceNormalRangeForOrdinalAndContinuousObservations = new ReferenceRange[]
                {
                    new ReferenceRange
                    {
                        NumericRange = new NumericRange
                        {
                            LowValue = 6
                        }
                    }
                },
                CriticalRangeForOrdinalAndContinuousObservations = new ReferenceRange[]
                {
                    new ReferenceRange
                    {
                        NumericRange = new NumericRange
                        {
                            LowValue = 7
                        }
                    }
                },
                AbsoluteRangeForOrdinalAndContinuousObservations = new ReferenceRange
                {
                    NumericRange = new NumericRange
                    {
                        LowValue = 8
                    }
                },
                DeltaCheckCriteria = new Delta[]
                {
                    new Delta
                    {
                        NormalRange = new NumericRange
                        {
                            LowValue = 9
                        }
                    }
                },
                MinimumMeaningfulIncrements = 10
            };

            ISegment actual = new Om2Segment();
            actual.FromDelimitedString("OM2|1|2|3|4|5|6|7|8|9|10");

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
                ISegment hl7Segment = new Om2Segment();
                hl7Segment.FromDelimitedString("OMA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Om2Segment
            {
                SequenceNumberTestObservationMasterFile = 1,
                UnitsOfMeasure = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                RangeOfDecimalPrecision = new decimal[]
                {
                    3
                },
                CorrespondingSiUnitsOfMeasure = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                SiConversionFactor = new Text
                {
                    Value = "5"
                },
                ReferenceNormalRangeForOrdinalAndContinuousObservations = new ReferenceRange[]
                {
                    new ReferenceRange
                    {
                        NumericRange = new NumericRange
                        {
                            LowValue = 6
                        }
                    }
                },
                CriticalRangeForOrdinalAndContinuousObservations = new ReferenceRange[]
                {
                    new ReferenceRange
                    {
                        NumericRange = new NumericRange
                        {
                            LowValue = 7
                        }
                    }
                },
                AbsoluteRangeForOrdinalAndContinuousObservations = new ReferenceRange
                {
                    NumericRange = new NumericRange
                    {
                        LowValue = 8
                    }
                },
                DeltaCheckCriteria = new Delta[]
                {
                    new Delta
                    {
                        NormalRange = new NumericRange
                        {
                            LowValue = 9
                        }
                    }
                },
                MinimumMeaningfulIncrements = 10
            };

            string expected = "OM2|1|2|3|4|5|6|7|8|9|10";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
