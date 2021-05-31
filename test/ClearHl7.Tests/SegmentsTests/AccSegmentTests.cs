using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class AccSegmentTests
    {
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
