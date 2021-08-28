using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Om7SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Om7Segment
            {
                SequenceNumberTestObservationMasterFile = 1,
                UniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                CategoryIdentifier = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                },
                CategoryDescription = new Text
                {
                    Value = "4"
                },
                CategorySynonym = new string[]
                {
                    "5"
                },
                EffectiveTestServiceStartDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                EffectiveTestServiceEndDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                TestServiceDefaultDurationQuantity = 8,
                TestServiceDefaultDurationUnits = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                TestServiceDefaultFrequency = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                ConsentIndicator = "11",
                ConsentIdentifier = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                ConsentEffectiveStartDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                ConsentEffectiveEndDateTime = new DateTime(2020, 1, 14, 0, 0, 14),
                ConsentIntervalQuantity = 15,
                ConsentIntervalUnits = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                ConsentWaitingPeriodQuantity = 17,
                ConsentWaitingPeriodUnits = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                EffectiveDateTimeOfChange = new DateTime(2020, 1, 19, 0, 0, 19),
                EnteredBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "20"
                },
                OrderableAtLocation = new PersonLocation[]
                {
                    new PersonLocation
                    {
                        PointOfCare = new HierarchicDesignator
                        {
                             NamespaceId = "21"
                        }
                    }
                },
                FormularyStatus = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                SpecialOrderIndicator = "23",
                PrimaryKeyValueCdm = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "24"
                    }
                }
            };

            ISegment actual = new Om7Segment();
            actual.FromDelimitedString("OM7|1|2|3|4|5|20200606000006|20200707000007|8|9|10|11|12|20200113000013|20200114000014|15|16|17|18|20200119000019|20|21|22|23|24");

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
                ISegment hl7Segment = new Om7Segment();
                hl7Segment.FromDelimitedString("OMA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Om7Segment
            {
                SequenceNumberTestObservationMasterFile = 1,
                UniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                CategoryIdentifier = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                },
                CategoryDescription = new Text
                {
                    Value = "4"
                },
                CategorySynonym = new string[]
                {
                    "5"
                },
                EffectiveTestServiceStartDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                EffectiveTestServiceEndDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                TestServiceDefaultDurationQuantity = 8,
                TestServiceDefaultDurationUnits = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                TestServiceDefaultFrequency = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                ConsentIndicator = "11",
                ConsentIdentifier = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                ConsentEffectiveStartDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                ConsentEffectiveEndDateTime = new DateTime(2020, 1, 14, 0, 0, 14),
                ConsentIntervalQuantity = 15,
                ConsentIntervalUnits = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                ConsentWaitingPeriodQuantity = 17,
                ConsentWaitingPeriodUnits = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                EffectiveDateTimeOfChange = new DateTime(2020, 1, 19, 0, 0, 19),
                EnteredBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "20"
                },
                OrderableAtLocation = new PersonLocation[]
                {
                    new PersonLocation
                    {
                        PointOfCare = new HierarchicDesignator
                        {
                             NamespaceId = "21"
                        }
                    }
                },
                FormularyStatus = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                SpecialOrderIndicator = "23",
                PrimaryKeyValueCdm = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "24"
                    }
                }
            };

            string expected = "OM7|1|2|3|4|5|20200606000006|20200707000007|8|9|10|11|12|20200113000013|20200114000014|15|16|17|18|20200119000019|20|21|22|23|24";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
