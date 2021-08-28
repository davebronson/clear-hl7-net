using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class AffSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new AffSegment
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
                ProfessionalOrganizationAffiliationDateRange = new DateTimeRange[]
                {
                    new DateTimeRange
                    {
                        RangeStartDateTime = new DateTime(2020, 4, 4, 0, 0, 4)
                    }
                },
                ProfessionalAffiliationAdditionalInformation = "5"
            };

            ISegment actual = new AffSegment();
            actual.FromDelimitedString("AFF|1|2|3|20200404000004|5");

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
                ISegment hl7Segment = new AffSegment();
                hl7Segment.FromDelimitedString("AFA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
                ProfessionalOrganizationAffiliationDateRange = new DateTimeRange[]
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
