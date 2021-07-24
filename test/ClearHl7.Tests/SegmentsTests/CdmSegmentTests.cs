using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class CdmSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new CdmSegment
            {
                PrimaryKeyValueCdm = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                ChargeCodeAlias = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                ChargeDescriptionShort = "3",
                ChargeDescriptionLong = "4",
                DescriptionOverrideIndicator = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ExplodingCharges = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "6"
                    }
                },
                ProcedureCode = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "7"
                    }
                },
                ActiveInactiveFlag = "8",
                InventoryNumber = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                ResourceLoad = 10,
                ContractNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "11"
                    }
                },
                ContractOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "12"
                    }
                },
                RoomFeeIndicator = "13"
            };

            ISegment actual = new CdmSegment();
            actual.FromDelimitedString("CDM|1|2|3|4|5|6|7|8|9|10|11|12|13");

            expected.Should().BeEquivalentTo(actual);
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new CdmSegment
            {
                PrimaryKeyValueCdm = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                ChargeCodeAlias = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "2"
                    }
                },
                ChargeDescriptionShort = "3",
                ChargeDescriptionLong = "4",
                DescriptionOverrideIndicator = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ExplodingCharges = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "6"
                    }
                },
                ProcedureCode = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "7"
                    }
                },
                ActiveInactiveFlag = "8",
                InventoryNumber = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                ResourceLoad = 10,
                ContractNumber = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "11"
                    }
                },
                ContractOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations[]
                {
                    new ExtendedCompositeNameAndIdNumberForOrganizations
                    {
                        OrganizationName = "12"
                    }
                },
                RoomFeeIndicator = "13"
            };

            string expected = "CDM|1|2|3|4|5|6|7|8|9|10|11|12|13";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
