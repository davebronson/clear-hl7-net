using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class SacSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new SacSegment
            {
                ExternalAccessionIdentifier = new EntityIdentifier
                {
                    EntityId = "1"
                },
                AccessionIdentifier = new EntityIdentifier
                {
                    EntityId = "2"
                },
                ContainerIdentifier = new EntityIdentifier
                {
                    EntityId = "3"
                },
                PrimaryParentContainerIdentifier = new EntityIdentifier
                {
                    EntityId = "4"
                },
                EquipmentContainerIdentifier = new EntityIdentifier
                {
                    EntityId = "5"
                },
                SpecimenSource = "6",
                RegistrationDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                ContainerStatus = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                CarrierType = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                CarrierIdentifier = new EntityIdentifier
                {
                    EntityId = "10"
                },
                PositionInCarrier = new NumericArray
                {
                    Value1 = 11
                },
                TrayTypeSac = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                TrayIdentifier = new EntityIdentifier
                {
                    EntityId = "13"
                },
                PositionInTray = new NumericArray
                {
                    Value1 = 14
                },
                Location = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "15"
                    }
                },
                ContainerHeight = 16,
                ContainerDiameter = 17,
                BarrierDelta = 18,
                BottomDelta = 19,
                ContainerHeightDiameterDeltaUnits = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                ContainerVolume = 21,
                AvailableSpecimenVolume = 22,
                InitialSpecimenVolume = 23,
                VolumeUnits = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                SeparatorType = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                CapType = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                Additive = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "27"
                    }
                },
                SpecimenComponent = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                DilutionFactor = new StructuredNumeric
                {
                    Comparator = "29"
                },
                Treatment = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                Temperature = new StructuredNumeric
                {
                    Comparator = "31"
                },
                HemolysisIndex = 32,
                HemolysisIndexUnits = new CodedWithExceptions
                {
                    Identifier = "33"
                },
                LipemiaIndex = 34,
                LipemiaIndexUnits = new CodedWithExceptions
                {
                    Identifier = "35"
                },
                IcterusIndex = 36,
                IcterusIndexUnits = new CodedWithExceptions
                {
                    Identifier = "37"
                },
                FibrinIndex = 38,
                FibrinIndexUnits = new CodedWithExceptions
                {
                    Identifier = "39"
                },
                SystemInducedContaminants = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "40"
                    }
                },
                DrugInterference = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "41"
                    }
                },
                ArtificialBlood = new CodedWithExceptions
                {
                    Identifier = "42"
                },
                SpecialHandlingCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "43"
                    }
                },
                OtherEnvironmentalFactors = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "44"
                    }
                },
                ContainerLength = new CompositeQuantityWithUnits
                {
                    Quantity = 45
                },
                ContainerWidth = new CompositeQuantityWithUnits
                {
                    Quantity = 46
                },
                ContainerForm = new CodedWithExceptions
                {
                    Identifier = "47"
                },
                ContainerMaterial = new CodedWithExceptions
                {
                    Identifier = "48"
                },
                ContainerCommonName = new CodedWithExceptions
                {
                    Identifier = "49"
                }
            };

            ISegment actual = new SacSegment();
            actual.FromDelimitedString("SAC|1|2|3|4|5|6|20200707000007|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49");

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
                ISegment hl7Segment = new SacSegment();
                hl7Segment.FromDelimitedString("SAA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new SacSegment
            {
                ExternalAccessionIdentifier = new EntityIdentifier
                {
                    EntityId = "1"
                },
                AccessionIdentifier = new EntityIdentifier
                {
                    EntityId = "2"
                },
                ContainerIdentifier = new EntityIdentifier
                {
                    EntityId = "3"
                },
                PrimaryParentContainerIdentifier = new EntityIdentifier
                {
                    EntityId = "4"
                },
                EquipmentContainerIdentifier = new EntityIdentifier
                {
                    EntityId = "5"
                },
                SpecimenSource = "6",
                RegistrationDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                ContainerStatus = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                CarrierType = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                CarrierIdentifier = new EntityIdentifier
                {
                    EntityId = "10"
                },
                PositionInCarrier = new NumericArray
                {
                    Value1 = 11
                },
                TrayTypeSac = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                TrayIdentifier = new EntityIdentifier
                {
                    EntityId = "13"
                },
                PositionInTray = new NumericArray
                {
                    Value1 = 14
                },
                Location = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "15"
                    }
                },
                ContainerHeight = 16,
                ContainerDiameter = 17,
                BarrierDelta = 18,
                BottomDelta = 19,
                ContainerHeightDiameterDeltaUnits = new CodedWithExceptions
                {
                    Identifier = "20"
                },
                ContainerVolume = 21,
                AvailableSpecimenVolume = 22,
                InitialSpecimenVolume = 23,
                VolumeUnits = new CodedWithExceptions
                {
                    Identifier = "24"
                },
                SeparatorType = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                CapType = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                Additive = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "27"
                    }
                },
                SpecimenComponent = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                DilutionFactor = new StructuredNumeric
                {
                    Comparator = "29"
                },
                Treatment = new CodedWithExceptions
                {
                    Identifier = "30"
                },
                Temperature = new StructuredNumeric
                {
                    Comparator = "31"
                },
                HemolysisIndex = 32,
                HemolysisIndexUnits = new CodedWithExceptions
                {
                    Identifier = "33"
                },
                LipemiaIndex = 34,
                LipemiaIndexUnits = new CodedWithExceptions
                {
                    Identifier = "35"
                },
                IcterusIndex = 36,
                IcterusIndexUnits = new CodedWithExceptions
                {
                    Identifier = "37"
                },
                FibrinIndex = 38,
                FibrinIndexUnits = new CodedWithExceptions
                {
                    Identifier = "39"
                },
                SystemInducedContaminants = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "40"
                    }
                },
                DrugInterference = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "41"
                    }
                },
                ArtificialBlood = new CodedWithExceptions
                {
                    Identifier = "42"
                },
                SpecialHandlingCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "43"
                    }
                },
                OtherEnvironmentalFactors = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "44"
                    }
                },
                ContainerLength = new CompositeQuantityWithUnits
                {
                    Quantity = 45
                },
                ContainerWidth = new CompositeQuantityWithUnits
                {
                    Quantity = 46
                },
                ContainerForm = new CodedWithExceptions
                {
                    Identifier = "47"
                },
                ContainerMaterial = new CodedWithExceptions
                {
                    Identifier = "48"
                },
                ContainerCommonName = new CodedWithExceptions
                {
                    Identifier = "49"
                }
            };

            string expected = "SAC|1|2|3|4|5|6|20200707000007|8|9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
