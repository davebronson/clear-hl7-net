using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PesSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PesSegment
            {
                SenderOrganizationName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "1"
                    }
                },
                SenderIndividualName = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "2"
                    }
                },
                SenderAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "3"
                        }
                    }
                },
                SenderTelephone = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "4"
                    }
                },
                SenderEventIdentifier = new EntityIdentifier
                {
                    EntityId = "5"
                },
                SenderSequenceNumber = 6,
                SenderEventDescription = new string[]
                {
                    "7"
                },
                SenderComment = "8",
                SenderAwareDateTime = new DateTime(2020, 9, 9, 0, 0, 9),
                EventReportDate = new DateTime(2020, 10, 10, 0, 0, 10),
                EventReportTimingType = new string[]
                {
                    "11"
                },
                EventReportSource = "12",
                EventReportedTo = new string[]
                {
                    "13"
                }
            };

            string expected = "PES|1|2|3|4|5|6|7|8|20200909000009|20201010000010|11|12|13";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
