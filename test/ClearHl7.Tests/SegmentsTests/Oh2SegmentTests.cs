using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Oh2SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Oh2Segment
            {
                SetId = 1,
                ActionCode = "2",
                EnteredDate = new DateTime(2020, 3, 3),
                Occupation = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                Industry = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                WorkClassification = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                JobStartDate = new DateTime(2020, 7, 7),
                JobEndDate = new DateTime(2020, 8, 8),
                WorkSchedule = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                AverageHoursWorkedPerDay = 10,
                AverageDaysWorkedPerWeek = 11,
                EmployerOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "12"
                },
                EmployerAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "13"
                        }
                    }
                },
                SupervisoryLevel = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                JobDuties = new string[]
                {
                    "15"
                },
                OccupationalHazards = new string[]
                {
                    "16"
                },
                JobUniqueIdentifier = new EntityIdentifier
                {
                    EntityId = "17"
                },
                CurrentJobIndicator = new CodedWithExceptions
                {
                    Identifier = "18"
                }
            };

            string expected = "OH2|1|2|20200303|4|5|6|20200707|20200808|9|10|11|12|13|14|15|16|17|18";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
