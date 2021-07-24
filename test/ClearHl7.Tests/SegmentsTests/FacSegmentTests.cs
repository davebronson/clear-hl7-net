using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class FacSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new FacSegment
            {
                FacilityIdFac = new EntityIdentifier
                {
                    EntityId = "1"
                },
                FacilityType = "2",
                FacilityAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "3"
                        }
                    }
                },
                FacilityTelecommunication = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "4"
                },
                ContactPerson = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "5"
                    }
                },
                ContactTitle = new string[]
                {
                    "6"
                },
                ContactAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "7"
                        }
                    }
                },
                ContactTelecommunication = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "8"
                    }
                },
                SignatureAuthority = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "9"
                    }
                },
                SignatureAuthorityTitle = "10",
                SignatureAuthorityAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "11"
                        }
                    }
                },
                SignatureAuthorityTelecommunication = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "12"
                }
            };

            ISegment actual = new FacSegment();
            actual.FromDelimitedString("FAC|1|2|3|4|5|6|7|8|9|10|11|12");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new FacSegment
            {
                FacilityIdFac = new EntityIdentifier
                {
                    EntityId = "1"
                },
                FacilityType = "2",
                FacilityAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "3"
                        }
                    }
                },
                FacilityTelecommunication = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "4"
                },
                ContactPerson = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "5"
                    }
                },
                ContactTitle = new string[]
                {
                    "6"
                },
                ContactAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "7"
                        }
                    }
                },
                ContactTelecommunication = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "8"
                    }
                },
                SignatureAuthority = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "9"
                    }
                },
                SignatureAuthorityTitle = "10",
                SignatureAuthorityAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "11"
                        }
                    }
                },
                SignatureAuthorityTelecommunication = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "12"
                }
            };

            string expected = "FAC|1|2|3|4|5|6|7|8|9|10|11|12";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
