using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class BtxSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new BtxSegment
            {
                SetIdBtx = 1,
                BcDonationId = new EntityIdentifier
                {
                    EntityId = "2"
                },
                BcComponent = new CodedWithNoExceptions
                {
                    Identifier = "3"
                },
                BcBloodGroup = new CodedWithNoExceptions
                {
                    Identifier = "4"
                },
                CpCommercialProduct = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                CpManufacturer = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "6"
                },
                CpLotNumber = new EntityIdentifier
                {
                    EntityId = "7"
                },
                BpQuantity = 8,
                BpAmount = 9,
                BpUnits = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                BpTransfusionDispositionStatus = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                BpMessageStatus = "12",
                BpDateTimeOfStatus = new DateTime(2020, 1, 13, 0, 0, 13),
                BpTransfusionAdministrator = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "14"
                },
                BpTransfusionVerifier = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "15"
                },
                BpTransfusionStartDateTimeOfStatus = new DateTime(2020, 1, 16, 0, 0, 16),
                BpTransfusionEndDateTimeOfStatus = new DateTime(2020, 1, 17, 0, 0, 17),
                BpAdverseReactionType = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "18"
                    }
                },
                BpTransfusionInterruptedReason = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                BpUniqueId = new EntityIdentifier
                {
                    EntityId = "20"
                },
                ActionCode = "21"
            };

            ISegment actual = new BtxSegment();
            actual.FromDelimitedString("BTX|1|2|3|4|5|6|7|8|9|10|11|12|20200113000013|14|15|20200116000016|20200117000017|18|19|20|21");

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
                ISegment hl7Segment = new BtxSegment();
                hl7Segment.FromDelimitedString("BTA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new BtxSegment
            {
                SetIdBtx = 1,
                BcDonationId = new EntityIdentifier
                {
                    EntityId = "2"
                },
                BcComponent = new CodedWithNoExceptions
                {
                    Identifier = "3"
                },
                BcBloodGroup = new CodedWithNoExceptions
                {
                    Identifier = "4"
                },
                CpCommercialProduct = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                CpManufacturer = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "6"
                },
                CpLotNumber = new EntityIdentifier
                {
                    EntityId = "7"
                },
                BpQuantity = 8,
                BpAmount = 9,
                BpUnits = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                BpTransfusionDispositionStatus = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                BpMessageStatus = "12",
                BpDateTimeOfStatus = new DateTime(2020, 1, 13, 0, 0, 13),
                BpTransfusionAdministrator = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "14"
                },
                BpTransfusionVerifier = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "15"
                },
                BpTransfusionStartDateTimeOfStatus = new DateTime(2020, 1, 16, 0, 0, 16),
                BpTransfusionEndDateTimeOfStatus = new DateTime(2020, 1, 17, 0, 0, 17),
                BpAdverseReactionType = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "18"
                    }
                },
                BpTransfusionInterruptedReason = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                BpUniqueId = new EntityIdentifier
                {
                    EntityId = "20"
                },
                ActionCode = "21"
            };

            string expected = "BTX|1|2|3|4|5|6|7|8|9|10|11|12|20200113000013|14|15|20200116000016|20200117000017|18|19|20|21";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
