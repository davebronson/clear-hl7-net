using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RolSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RolSegment
            {
                RoleInstanceId = new EntityIdentifier
                {
                    EntityId = "1"
                },
                ActionCode = "2",
                RoleRol = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                RolePerson = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "4"
                    }
                },
                RoleBeginDateTime = new DateTime(2020, 5, 5, 0, 0, 5),
                RoleEndDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                RoleDuration = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                RoleActionReason = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                ProviderType = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                OrganizationUnitType = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                OfficeHomeAddressBirthplace = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "11"
                        }
                    }
                },
                Phone = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "12"
                    }
                },
                PersonsLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "13"
                    }
                },
                Organization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "14"
                }
            };

            ISegment actual = new RolSegment();
            actual.FromDelimitedString("ROL|1|2|3|4|20200505000005|20200606000006|7|8|9|10|11|12|13|14");

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
                ISegment hl7Segment = new RolSegment();
                hl7Segment.FromDelimitedString("ROA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RolSegment
            {
                RoleInstanceId = new EntityIdentifier
                {
                    EntityId = "1"
                },
                ActionCode = "2",
                RoleRol = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                RolePerson = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "4"
                    }
                },
                RoleBeginDateTime = new DateTime(2020, 5, 5, 0, 0, 5),
                RoleEndDateTime = new DateTime(2020, 6, 6, 0, 0, 6),
                RoleDuration = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                RoleActionReason = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                ProviderType = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                OrganizationUnitType = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                OfficeHomeAddressBirthplace = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "11"
                        }
                    }
                },
                Phone = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "12"
                    }
                },
                PersonsLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "13"
                    }
                },
                Organization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "14"
                }
            };

            string expected = "ROL|1|2|3|4|20200505000005|20200606000006|7|8|9|10|11|12|13|14";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
