using System;
using System.Collections.Generic;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class BpxSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
                BcSpecialTesting = new List<CodedWithNoExceptions>
                {
                    new CodedWithNoExceptions
                    {
                        Identifier ="12"
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
                }
            };

            string expected = "BPX|1|2|3|20200404000004|5|6|7|8|9|10|11|12|20200113000013|14|15|16|17|18|19|20|21";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
