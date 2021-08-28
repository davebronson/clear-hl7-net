using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class AccSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new AccSegment
            {
                AccidentDateTime = new DateTime(2020, 1, 1, 0, 0, 1),
                AccidentCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AccidentLocation = "3",
                AutoAccidentState = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                AccidentJobRelatedIndicator = "5",
                AccidentDeathIndicator = "6",
                EnteredBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "7"
                },
                AccidentDescription = "8",
                BroughtInBy = "9",
                PoliceNotifiedIndicator = "10",
                AccidentAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        IsSubcomponent = true,
                        StreetOrMailingAddress = "11"
                    }
                },
                DegreeOfPatientLiability = 12,
                AccidentIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "13"
                    }
                }
            };

            ISegment actual = new AccSegment();
            actual.FromDelimitedString("ACC|20200101000001|2|3|4|5|6|7|8|9|10|11|12|13");

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
                ISegment hl7Segment = new AccSegment();
                hl7Segment.FromDelimitedString("ACA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new AccSegment
            {
                AccidentDateTime = new DateTime(2020, 1, 1, 0, 0, 1),
                AccidentCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AccidentLocation = "3",
                AutoAccidentState = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                AccidentJobRelatedIndicator = "5",
                AccidentDeathIndicator = "6",
                EnteredBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "7"
                },
                AccidentDescription = "8",
                BroughtInBy = "9",
                PoliceNotifiedIndicator = "10",
                AccidentAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "11"
                    }
                },
                DegreeOfPatientLiability = 12,
                AccidentIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "13"
                    }
                }
            };

            string expected = "ACC|20200101000001|2|3|4|5|6|7|8|9|10|11|12|13";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
