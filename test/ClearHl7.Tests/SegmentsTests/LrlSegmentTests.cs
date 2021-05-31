using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class LrlSegmentTests
    {
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
