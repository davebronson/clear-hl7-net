using System;
using System.Collections.Generic;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class Cm0SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Cm0Segment
            {
                SetIdCm0 = 1,
                SponsorStudyId = new EntityIdentifier
                {
                    EntityId = "2"
                },
                AlternateStudyId = new List<EntityIdentifier>
                {
                    new EntityIdentifier
                    {
                        EntityId ="3"
                    }
                },
                TitleOfStudy = "4",
                ChairmanOfStudy = new List<ExtendedCompositeIdNumberAndNameForPersons>
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "5"
                    }
                },
                LastIrbApprovalDate = new DateTime(2020, 6, 6),
                TotalAccrualToDate = 7,
                LastAccrualDate = new DateTime(2020, 8, 8),
                ContactForStudy = new List<ExtendedCompositeIdNumberAndNameForPersons>
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "9"
                    }
                },
                ContactsTelephoneNumber = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "10"
                },
                ContactsAddress = new List<ExtendedAddress>
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress= "11"
                        }
                    }
                }
            };

            string expected = "CM0|1|2|3|4|5|20200606|7|20200808|9|10|11";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
