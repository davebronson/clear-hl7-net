using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class BpxSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new BpxSegment
            {
                SetIdBpx = 1,
                BpDispenseStatus = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                BpStatus = "3",
                BpDateTimeOfStatus = new DateTime(2020, 4, 4, 0, 0, 4),
                BcDonationId = new EntityIdentifier
                {
                    EntityId = "5"
                },
                BcComponent = new CodedWithNoExceptions
                {
                    Identifier = "6"
                },
                BcDonationTypeIntendedUse = new CodedWithNoExceptions
                {
                    Identifier = "7"
                },
                CpCommercialProduct = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                CpManufacturer = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "9"
                },
                CpLotNumber = new EntityIdentifier
                {
                    EntityId = "10"
                },
                BpBloodGroup = new CodedWithNoExceptions
                {
                    Identifier = "11"
                },
                BcSpecialTesting = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "12"
                    }
                },
                BpExpirationDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                BpQuantity = 14,
                BpAmount = 15,
                BpUnits = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                BpUniqueId = new EntityIdentifier
                {
                    EntityId = "17"
                },
                BpActualDispensedToLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "18"
                    }
                },
                BpActualDispensedToAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "19"
                    }
                },
                BpDispensedToReceiver = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "20"
                },
                BpDispensingIndividual = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "21"
                },
                ActionCode = "22"
            };

            ISegment actual = new BpxSegment();
            actual.FromDelimitedString("BPX|1|2|3|20200404000004|5|6|7|8|9|10|11|12|20200113000013|14|15|16|17|18|19|20|21|22");

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
                ISegment hl7Segment = new BpxSegment();
                hl7Segment.FromDelimitedString("BPA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new BpxSegment
            {
                SetIdBpx = 1,
                BpDispenseStatus = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                BpStatus = "3",
                BpDateTimeOfStatus = new DateTime(2020, 4, 4, 0, 0, 4),
                BcDonationId = new EntityIdentifier
                {
                    EntityId = "5"
                },
                BcComponent = new CodedWithNoExceptions
                {
                    Identifier = "6"
                },
                BcDonationTypeIntendedUse = new CodedWithNoExceptions
                {
                    Identifier = "7"
                },
                CpCommercialProduct = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                CpManufacturer = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "9"
                },
                CpLotNumber = new EntityIdentifier
                {
                    EntityId = "10"
                },
                BpBloodGroup = new CodedWithNoExceptions
                {
                    Identifier = "11"
                },
                BcSpecialTesting = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "12"
                    }
                },
                BpExpirationDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                BpQuantity = 14,
                BpAmount = 15,
                BpUnits = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                BpUniqueId = new EntityIdentifier
                {
                    EntityId = "17"
                },
                BpActualDispensedToLocation = new PersonLocation
                {
                    PointOfCare = new HierarchicDesignator
                    {
                        NamespaceId = "18"
                    }
                },
                BpActualDispensedToAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "19"
                    }
                },
                BpDispensedToReceiver = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "20"
                },
                BpDispensingIndividual = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "21"
                },
                ActionCode = "22"
            };

            string expected = "BPX|1|2|3|20200404000004|5|6|7|8|9|10|11|12|20200113000013|14|15|16|17|18|19|20|21|22";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
