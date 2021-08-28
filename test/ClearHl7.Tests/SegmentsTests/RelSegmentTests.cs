using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RelSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RelSegment
            {
                SetIdRel = 1,
                RelationshipType = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ThisRelationshipInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "3"
                },
                SourceInformationInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "4"
                },
                TargetInformationInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "5"
                },
                AssertingEntityInstanceId = new EntityIdentifier
                {
                    EntityId = "6"
                },
                AssertingPerson = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "7"
                },
                AssertingOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "8"
                },
                AssertorAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "9"
                    }
                },
                AssertorContact = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "10"
                },
                AssertionDateRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 11, 11, 0, 0, 11)
                },
                NegationIndicator = "12",
                CertaintyOfRelationship = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                PriorityNo = 14,
                PrioritySequenceNoRelPreferenceForConsideration = 15,
                SeparabilityIndicator = "16",
                SourceInformationInstanceObjectType = "17",
                TargetInformationInstanceObjectType = "18"
            };

            ISegment actual = new RelSegment();
            actual.FromDelimitedString("REL|1|2|3|4|5|6|7|8|9|10|20201111000011|12|13|14|15|16|17|18");

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
                ISegment hl7Segment = new RelSegment();
                hl7Segment.FromDelimitedString("REA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RelSegment
            {
                SetIdRel = 1,
                RelationshipType = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ThisRelationshipInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "3"
                },
                SourceInformationInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "4"
                },
                TargetInformationInstanceIdentifier = new EntityIdentifier
                {
                    EntityId = "5"
                },
                AssertingEntityInstanceId = new EntityIdentifier
                {
                    EntityId = "6"
                },
                AssertingPerson = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "7"
                },
                AssertingOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "8"
                },
                AssertorAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "9"
                    }
                },
                AssertorContact = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "10"
                },
                AssertionDateRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 11, 11, 0, 0, 11)
                },
                NegationIndicator = "12",
                CertaintyOfRelationship = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                PriorityNo = 14,
                PrioritySequenceNoRelPreferenceForConsideration = 15,
                SeparabilityIndicator = "16",
                SourceInformationInstanceObjectType = "17",
                TargetInformationInstanceObjectType = "18"
            };

            string expected = "REL|1|2|3|4|5|6|7|8|9|10|20201111000011|12|13|14|15|16|17|18";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
