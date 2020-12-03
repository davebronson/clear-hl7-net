using System;
using System.Collections.Generic;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class AffSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new AffSegment
            {
                SetIdAff = 1,
                ProfessionalOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "2"
                },
                ProfessionalOrganizationAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "3"
                    }
                },
                ProfessionalOrganizationAffiliationDateRange = new List<DateTimeRange>
                {
                    new DateTimeRange
                    {
                        RangeStartDateTime = new DateTime(2020, 4, 4, 0, 0, 4)
                    }
                },
                ProfessionalAffiliationAdditionalInformation = "5"
            };

            string expected = "AFF|1|2|3|20200404000004|5";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
