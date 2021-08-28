using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class ScdSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new ScdSegment
            {
                CycleStartTime = new DateTime(2020, 1, 1, 0, 0, 1),
                CycleCount = 2,
                TempMax = new CompositeQuantityWithUnits
                {
                    Quantity = 3
                },
                TempMin = new CompositeQuantityWithUnits
                {
                    Quantity = 4
                },
                LoadNumber = 5,
                ConditionTime = new CompositeQuantityWithUnits
                {
                    Quantity = 6
                },
                SterilizeTime = new CompositeQuantityWithUnits
                {
                    Quantity = 7
                },
                ExhaustTime = new CompositeQuantityWithUnits
                {
                    Quantity = 8
                },
                TotalCycleTime = new CompositeQuantityWithUnits
                {
                    Quantity = 9
                },
                DeviceStatus = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                CycleStartDateTime = new DateTime(2020, 11, 11, 0, 0, 11),
                DryTime = new CompositeQuantityWithUnits
                {
                    Quantity = 12
                },
                LeakRate = new CompositeQuantityWithUnits
                {
                    Quantity = 13
                },
                ControlTemperature = new CompositeQuantityWithUnits
                {
                    Quantity = 14
                },
                SterilizerTemperature = new CompositeQuantityWithUnits
                {
                    Quantity = 15
                },
                CycleCompleteTime = new DateTime(2020, 1, 16, 0, 0, 16),
                UnderTemperature = new CompositeQuantityWithUnits
                {
                    Quantity = 17
                },
                OverTemperature = new CompositeQuantityWithUnits
                {
                    Quantity = 18
                },
                AbortCycle = new CodedWithNoExceptions
                {
                    Identifier = "19"
                },
                Alarm = new CodedWithNoExceptions
                {
                    Identifier = "20"
                },
                LongInChargePhase = new CodedWithNoExceptions
                {
                    Identifier = "21"
                },
                LongInExhaustPhase = new CodedWithNoExceptions
                {
                    Identifier = "22"
                },
                LongInFastExhaustPhase = new CodedWithNoExceptions
                {
                    Identifier = "23"
                },
                Reset = new CodedWithNoExceptions
                {
                    Identifier = "24"
                },
                OperatorUnload = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "25"
                },
                DoorOpen = new CodedWithNoExceptions
                {
                    Identifier = "26"
                },
                ReadingFailure = new CodedWithNoExceptions
                {
                    Identifier = "27"
                },
                CycleType = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                ThermalRinseTime = new CompositeQuantityWithUnits
                {
                    Quantity = 29
                },
                WashTime = new CompositeQuantityWithUnits
                {
                    Quantity = 30
                },
                InjectionRate = new CompositeQuantityWithUnits
                {
                    Quantity = 31
                },
                ProcedureCode = new CodedWithNoExceptions
                {
                    Identifier = "32"
                },
                PatientIdentifierList = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "33"
                    }
                },
                AttendingDoctor = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "34"
                },
                DilutionFactor = new StructuredNumeric
                {
                    Comparator = "35"
                },
                FillTime = new CompositeQuantityWithUnits
                {
                    Quantity = 36
                },
                InletTemperature = new CompositeQuantityWithUnits
                {
                    Quantity = 37
                }
            };

            ISegment actual = new ScdSegment();
            actual.FromDelimitedString("SCD|000001|2|3|4|5|6|7|8|9|10|20201111000011|12|13|14|15|000016|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37");

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
                ISegment hl7Segment = new ScdSegment();
                hl7Segment.FromDelimitedString("SCA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ScdSegment
            {
                CycleStartTime = new DateTime(2020, 1, 1, 0, 0, 1),
                CycleCount = 2,
                TempMax = new CompositeQuantityWithUnits
                {
                    Quantity = 3
                },
                TempMin = new CompositeQuantityWithUnits
                {
                    Quantity = 4
                },
                LoadNumber = 5,
                ConditionTime = new CompositeQuantityWithUnits
                {
                    Quantity = 6
                },
                SterilizeTime = new CompositeQuantityWithUnits
                {
                    Quantity = 7
                },
                ExhaustTime = new CompositeQuantityWithUnits
                {
                    Quantity = 8
                },
                TotalCycleTime = new CompositeQuantityWithUnits
                {
                    Quantity = 9
                },
                DeviceStatus = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                CycleStartDateTime = new DateTime(2020, 11, 11, 0, 0, 11),
                DryTime = new CompositeQuantityWithUnits
                {
                    Quantity = 12
                },
                LeakRate = new CompositeQuantityWithUnits
                {
                    Quantity = 13
                },
                ControlTemperature = new CompositeQuantityWithUnits
                {
                    Quantity = 14
                },
                SterilizerTemperature = new CompositeQuantityWithUnits
                {
                    Quantity = 15
                },
                CycleCompleteTime = new DateTime(2020, 1, 16, 0, 0, 16),
                UnderTemperature = new CompositeQuantityWithUnits
                {
                    Quantity = 17
                },
                OverTemperature = new CompositeQuantityWithUnits
                {
                    Quantity = 18
                },
                AbortCycle = new CodedWithNoExceptions
                {
                    Identifier = "19"
                },
                Alarm = new CodedWithNoExceptions
                {
                    Identifier = "20"
                },
                LongInChargePhase = new CodedWithNoExceptions
                {
                    Identifier = "21"
                },
                LongInExhaustPhase = new CodedWithNoExceptions
                {
                    Identifier = "22"
                },
                LongInFastExhaustPhase = new CodedWithNoExceptions
                {
                    Identifier = "23"
                },
                Reset = new CodedWithNoExceptions
                {
                    Identifier = "24"
                },
                OperatorUnload = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "25"
                },
                DoorOpen = new CodedWithNoExceptions
                {
                    Identifier = "26"
                },
                ReadingFailure = new CodedWithNoExceptions
                {
                    Identifier = "27"
                },
                CycleType = new CodedWithExceptions
                {
                    Identifier = "28"
                },
                ThermalRinseTime = new CompositeQuantityWithUnits
                {
                    Quantity = 29
                },
                WashTime = new CompositeQuantityWithUnits
                {
                    Quantity = 30
                },
                InjectionRate = new CompositeQuantityWithUnits
                {
                    Quantity = 31
                },
                ProcedureCode = new CodedWithNoExceptions
                {
                    Identifier = "32"
                },
                PatientIdentifierList = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "33"
                    }
                },
                AttendingDoctor = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "34"
                },
                DilutionFactor = new StructuredNumeric
                {
                    Comparator = "35"
                },
                FillTime = new CompositeQuantityWithUnits
                {
                    Quantity = 36
                },
                InletTemperature = new CompositeQuantityWithUnits
                {
                    Quantity = 37
                }
            };

            string expected = "SCD|000001|2|3|4|5|6|7|8|9|10|20201111000011|12|13|14|15|000016|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
