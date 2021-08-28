using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class OrgSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new OrgSegment
            {
                SetIdOrg = 1,
                OrganizationUnitCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                OrganizationUnitTypeCode = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                PrimaryOrgUnitIndicator = "4",
                PractitionerOrgUnitIdentifier = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "5"
                },
                HealthCareProviderTypeCode = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                HealthCareProviderClassificationCode = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                HealthCareProviderAreaOfSpecializationCode = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                EffectiveDateRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 9, 9, 0, 0, 9)
                },
                EmploymentStatusCode = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                BoardApprovalIndicator = "11",
                PrimaryCarePhysicianIndicator = "12",
                CostCenterCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                }
            };

            ISegment actual = new OrgSegment();
            actual.FromDelimitedString("ORG|1|2|3|4|5|6|7|8|20200909000009|10|11|12|13");

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
                ISegment hl7Segment = new OrgSegment();
                hl7Segment.FromDelimitedString("ORA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new OrgSegment
            {
                SetIdOrg = 1,
                OrganizationUnitCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                OrganizationUnitTypeCode = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                PrimaryOrgUnitIndicator = "4",
                PractitionerOrgUnitIdentifier = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "5"
                },
                HealthCareProviderTypeCode = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                HealthCareProviderClassificationCode = new CodedWithExceptions
                {
                    Identifier = "7"
                },
                HealthCareProviderAreaOfSpecializationCode = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                EffectiveDateRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 9, 9, 0, 0, 9)
                },
                EmploymentStatusCode = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                BoardApprovalIndicator = "11",
                PrimaryCarePhysicianIndicator = "12",
                CostCenterCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "13"
                    }
                }
            };

            string expected = "ORG|1|2|3|4|5|6|7|8|20200909000009|10|11|12|13";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
