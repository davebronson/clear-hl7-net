﻿using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class DevSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new DevSegment
            {
                ActionCode = "1",
                UniqueDeviceIdentifier = new EntityIdentifier
                {
                    EntityId = "2"
                },
                DeviceType = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "3"
                    }
                },
                DeviceStatus = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "4"
                    }
                },
                ManufacturerDistributor = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "5"
                },
                BrandName = "6",
                ModelIdentifier = "7",
                CatalogueIdentifier = "8",
                UdiDeviceIdentifier = new EntityIdentifier
                {
                    EntityId = "9"
                },
                DeviceLotNumber = "10",
                DeviceSerialNumber = "11",
                DeviceManufactureDate = new DateTime(2020, 12, 12, 0, 0, 12),
                DeviceExpiryDate = new DateTime(2020, 1, 13, 0, 0, 13),
                SafetyCharacteristics = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "14"
                    }
                },
                DeviceDonationIdentification = new EntityIdentifier
                {
                    EntityId = "15"
                },
                SoftwareVersionNumber = "16",
                ImplantationStatus = new CodedWithNoExceptions
                {
                    Identifier = "17"
                }
            };

            string expected = "DEV|1|2|3|4|5|6|7|8|9|10|11|20201212000012|20200113000013|14|15|16|17";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
