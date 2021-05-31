using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class LdpSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new LdpSegment
            {
                PrimaryKeyValueLdp = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "1"
                    }
                },
                LocationDepartment = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                LocationService = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "3"
                    }
                },
                SpecialtyType = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                },
                ValidPatientClasses = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "5"
                    }
                },
                ActiveInactiveFlag = "6",
                ActivationDateLdp = new DateTime(2020, 7, 7, 0, 0, 7),
                InactivationDateLdp = new DateTime(2020, 8, 8, 0, 0, 8),
                InactivatedReason = "9",
                VisitingHours = new VisitingHours[]
                {
                    new VisitingHours
                    {
                        StartDayRange = "10"
                    }
                },
                ContactPhone = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "11"
                },
                LocationCostCenter = new CodedWithExceptions
                {
                    Identifier = "12"
                }
            };

            string expected = "LDP|1|2|3|4|5|6|20200707000007|20200808000008|9|10|11|12";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
