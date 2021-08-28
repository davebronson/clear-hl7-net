using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class OrcSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new OrcSegment
            {
                OrderControl = "1",
                PlacerOrderNumber = new EntityIdentifier
                {
                    EntityId = "2"
                },
                FillerOrderNumber = new EntityIdentifier
                {
                    EntityId = "3"
                },
                PlacerGroupNumber = new EntityIdentifierPair
                {
                    PlacerAssignedIdentifier = new EntityIdentifier
                    {
                        EntityId = "4"
                    }
                },
                OrderStatus = "5",
                ResponseFlag = "6",
                QuantityTiming = new string[]
                {
                    "7"
                },
                ParentOrder = new EntityIdentifierPair[]
                {
                    new EntityIdentifierPair
                    {
                        PlacerAssignedIdentifier = new EntityIdentifier
                        {
                            EntityId = "8"
                        }
                    }
                },
                DateTimeOfTransaction = new DateTime(2020, 9, 9, 0, 0, 9),
                EnteredBy = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "10"
                    }
                },
                VerifiedBy = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "11"
                    }
                },
                OrderingProvider = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "12"
                    }
                },
                EnterersLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "13"
                    }
                },
                CallBackPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "14"
                    }
                },
                OrderEffectiveDateTime = new DateTime(2020, 1, 15, 0, 0, 15),
                OrderControlCodeReason = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                EnteringOrganization = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                EnteringDevice = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                ActionBy = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "19"
                    }
                },
                AdvancedBeneficiaryNoticeCode = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                OrderingFacilityName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "21"
                    }
                },
                OrderingFacilityAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "22"
                        }
                    }
                },
                OrderingFacilityPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "23"
                    }
                },
                OrderingProviderAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "24"
                        }
                    }
                },
                OrderStatusModifier = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                AdvancedBeneficiaryNoticeOverrideReason = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                FillersExpectedAvailabilityDateTime = new DateTime(2020, 1, 27, 0, 0, 27),
                ConfidentialityCode = new CodedWithExceptions
                {
                    Identifier = "28",
                },
                OrderType = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                EntererAuthorizationMode = new CodedWithNoExceptions
                {
                    Identifier = "30"
                },
                ParentUniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "31"
                },
                AdvancedBeneficiaryNoticeDate = new DateTime(2020, 3, 2),
                AlternatePlacerOrderNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "33"
                    }
                },
                OrderWorkflowProfile = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "34"
                    }
                },
                ActionCode = "35",
                OrderStatusDateRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 3, 6, 0, 0, 36)
                },
                OrderCreationDateTime = new DateTime(2020, 3, 7, 0, 0, 37),
                FillerOrderGroupNumber = new EntityIdentifier
                {
                    EntityId = "38"
                }
            };

            ISegment actual = new OrcSegment();
            actual.FromDelimitedString("ORC|1|2|3|4|5|6|7|8|20200909000009|10|11|12|13|14|20200115000015|16|17|18|19|20|21|22|23|24|25|26|20200127000027|28|29|30|31|20200302|33|34|35|20200306000036|20200307000037|38");

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
                ISegment hl7Segment = new OrcSegment();
                hl7Segment.FromDelimitedString("ORA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new OrcSegment
            {
                OrderControl = "1",
                PlacerOrderNumber = new EntityIdentifier
                {
                    EntityId = "2"
                },
                FillerOrderNumber = new EntityIdentifier
                {
                    EntityId = "3"
                },
                PlacerGroupNumber = new EntityIdentifierPair
                {
                    PlacerAssignedIdentifier = new EntityIdentifier
                    {
                        EntityId = "4"
                    }
                },
                OrderStatus = "5",
                ResponseFlag = "6",
                QuantityTiming = new string[]
                {
                    "7"
                },
                ParentOrder = new EntityIdentifierPair[]
                {
                    new EntityIdentifierPair
                    {
                        PlacerAssignedIdentifier = new EntityIdentifier
                        {
                            EntityId = "8"
                        }
                    }
                },
                DateTimeOfTransaction = new DateTime(2020, 9, 9, 0, 0, 9),
                EnteredBy = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "10"
                    }
                },
                VerifiedBy = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "11"
                    }
                },
                OrderingProvider = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "12"
                    }
                },
                EnterersLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "13"
                    }
                },
                CallBackPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "14"
                    }
                },
                OrderEffectiveDateTime = new DateTime(2020, 1, 15, 0, 0, 15),
                OrderControlCodeReason = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                EnteringOrganization = new CodedWithExceptions
                {
                    Identifier = "17"
                },
                EnteringDevice = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                ActionBy = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "19"
                    }
                },
                AdvancedBeneficiaryNoticeCode = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                OrderingFacilityName = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "21"
                    }
                },
                OrderingFacilityAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "22"
                        }
                    }
                },
                OrderingFacilityPhoneNumber = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "23"
                    }
                },
                OrderingProviderAddress = new ExtendedAddress[]
                {
                    new ExtendedAddress
                    {
                        StreetAddress = new StreetAddress
                        {
                            StreetOrMailingAddress = "24"
                        }
                    }
                },
                OrderStatusModifier = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                AdvancedBeneficiaryNoticeOverrideReason = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                FillersExpectedAvailabilityDateTime = new DateTime(2020, 1, 27, 0, 0, 27),
                ConfidentialityCode = new CodedWithExceptions
                {
                    Identifier = "28",
                },
                OrderType = new CodedWithExceptions
                {
                    Identifier = "29"
                },
                EntererAuthorizationMode = new CodedWithNoExceptions
                {
                    Identifier = "30"
                },
                ParentUniversalServiceIdentifier = new CodedWithExceptions
                {
                    Identifier = "31"
                },
                AdvancedBeneficiaryNoticeDate = new DateTime(2020, 3, 2),
                AlternatePlacerOrderNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "33"
                    }
                },
                OrderWorkflowProfile = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "34"
                    }
                },
                ActionCode = "35",
                OrderStatusDateRange = new DateTimeRange
                {
                    RangeStartDateTime = new DateTime(2020, 3, 6, 0, 0, 36)
                },
                OrderCreationDateTime = new DateTime(2020, 3, 7, 0, 0, 37),
                FillerOrderGroupNumber = new EntityIdentifier
                {
                    EntityId = "38"
                }
            };

            string expected = "ORC|1|2|3|4|5|6|7|8|20200909000009|10|11|12|13|14|20200115000015|16|17|18|19|20|21|22|23|24|25|26|20200127000027|28|29|30|31|20200302|33|34|35|20200306000036|20200307000037|38";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
