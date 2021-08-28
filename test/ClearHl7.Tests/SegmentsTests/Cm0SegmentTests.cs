using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Cm0SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Cm0Segment
            {
                SetIdCm0 = 1,
                SponsorStudyId = new EntityIdentifier
                {
                    EntityId = "2"
                },
                AlternateStudyId = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "3"
                    }
                },
                TitleOfStudy = "4",
                ChairmanOfStudy = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "5"
                    }
                },
                LastIrbApprovalDate = new DateTime(2020, 6, 6),
                TotalAccrualToDate = 7,
                LastAccrualDate = new DateTime(2020, 8, 8),
                ContactForStudy = new ExtendedCompositeIdNumberAndNameForPersons[]
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
                ContactsAddress = new ExtendedAddress[]
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

            ISegment actual = new Cm0Segment();
            actual.FromDelimitedString("CM0|1|2|3|4|5|20200606|7|20200808|9|10|11");

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
                ISegment hl7Segment = new Cm0Segment();
                hl7Segment.FromDelimitedString("CMA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
                AlternateStudyId = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "3"
                    }
                },
                TitleOfStudy = "4",
                ChairmanOfStudy = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "5"
                    }
                },
                LastIrbApprovalDate = new DateTime(2020, 6, 6),
                TotalAccrualToDate = 7,
                LastAccrualDate = new DateTime(2020, 8, 8),
                ContactForStudy = new ExtendedCompositeIdNumberAndNameForPersons[]
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
                ContactsAddress = new ExtendedAddress[]
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
