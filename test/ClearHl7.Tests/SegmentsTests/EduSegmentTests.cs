using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class EduSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new EduSegment
            {
                SetIdEdu = 1,
                AcademicDegree = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AcademicDegreeProgramDateRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                },
                AcademicDegreeProgramParticipationDateRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 4, 4, 0, 0, 4)
                },
                AcademicDegreeGrantedDate = new DateTime(2020, 5, 5),
                School = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "6"
                },
                SchoolTypeCode = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                SchoolAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "8"
                    }
                },
                MajorFieldOfStudy = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                }
            };

            string expected = "EDU|1|2|20200303000003|20200404000004|20200505|6|7|8|9";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
