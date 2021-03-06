﻿using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class BuiSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new BuiSegment
            {
                SetIdBui = 1,
                BloodUnitIdentifier = new EntityIdentifier
                {
                    EntityId = "2"
                },
                BloodUnitType = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                BloodUnitWeight = 4,
                WeightUnits = new CodedWithNoExceptions
                {
                    Identifier = "5"
                },
                BloodUnitVolume = 6,
                VolumeUnits = new CodedWithNoExceptions
                {
                    Identifier = "7"
                },
                ContainerCatalogNumber = "8",
                ContainerLotNumber = "9",
                ContainerManufacturer = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "10"
                },
                TransportTemperature = new NumericRange
                {
                    LowValue = 11
                },
                TransportTemperatureUnits = new CodedWithNoExceptions
                {
                    Identifier = "12"
                },
                ActionCode = "13"
            };

            string expected = "BUI|1|2|3|4|5|6|7|8|9|10|11|12|13";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
