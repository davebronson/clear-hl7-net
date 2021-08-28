using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class LrlSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new LrlSegment
            {
                PrimaryKeyValueLrl = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "1"
                    }
                },
                SegmentActionCode = "2",
                SegmentUniqueKey = new EntityIdentifier
                {
                    EntityId = "3"
                },
                LocationRelationshipId = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                OrganizationalLocationRelationshipValue = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "5"
                    }
                },
                PatientLocationRelationshipValue = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "6"
                    }
                }
            };

            ISegment actual = new LrlSegment();
            actual.FromDelimitedString("LRL|1|2|3|4|5|6");

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
                ISegment hl7Segment = new LrlSegment();
                hl7Segment.FromDelimitedString("LRA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new LrlSegment
            {
                PrimaryKeyValueLrl = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "1"
                    }
                },
                SegmentActionCode = "2",
                SegmentUniqueKey = new EntityIdentifier
                {
                    EntityId = "3"
                },
                LocationRelationshipId = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                OrganizationalLocationRelationshipValue = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "5"
                    }
                },
                PatientLocationRelationshipValue = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "6"
                    }
                }
            };

            string expected = "LRL|1|2|3|4|5|6";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
