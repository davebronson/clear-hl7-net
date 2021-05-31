using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PrdSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PrdSegment
            {
                ProviderRole = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "1"
                    }
                },
                ProviderName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "2"
                        }
                    }
                },
                ProviderAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "3"
                        }
                    }
                },
                ProviderLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "4"
                    }
                },
                ProviderCommunicationInformation = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "5"
                    }
                },
                PreferredMethodOfContact = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                ProviderIdentifiers = new PractitionerLicenseOrOtherIdNumber[]
                {
                    new PractitionerLicenseOrOtherIdNumber
                    {
                        IdNumber = "7"
                    }
                },
                EffectiveStartDateOfProviderRole = new DateTime(2020, 8, 8, 0, 0, 8),
                EffectiveEndDateOfProviderRole = new DateTime[]
                {
                    new DateTime(2020, 9, 9, 0, 0, 9)
                },
                ProviderOrganizationNameAndIdentifier = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "10"
                },
                ProviderOrganizationAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "11"
                        }
                    }
                },
                ProviderOrganizationLocationInformation = new PersonLocation[]
                {
                    new PersonLocation
                    {
                        PointOfCare = new HierarchicDesignator
                        {
                            NamespaceId = "12"
                        }
                    }
                },
                ProviderOrganizationCommunicationInformation = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "13"
                    }
                },
                ProviderOrganizationMethodOfContact = new CodedWithExceptions
                {
                    Identifier = "14"
                }
            };

            string expected = "PRD|1|2|3|4|5|6|7|20200808000008|20200909000009|10|11|12|13|14";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
