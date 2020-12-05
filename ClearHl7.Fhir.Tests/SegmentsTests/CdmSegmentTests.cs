using System;
using System.Collections.Generic;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class CdmSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
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
                ChargeCodeAlias = new List<CodedWithExceptions>
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
                ExplodingCharges = new List<CodedWithExceptions>
                {
                    new CodedWithExceptions
                    {
                        Identifier = "6"
                    }
                },
                ProcedureCode = new List<CodedWithNoExceptions>
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "7"
                    }
                },
                ActiveInactiveFlag = "8",
                InventoryNumber = new List<CodedWithExceptions>
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                ResourceLoad = 10,
                ContractNumber = new List<ExtendedCompositeIdWithCheckDigit>
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "11"
                    }
                },
                ContractOrganization = new List<ExtendedCompositeNameAndIdNumberForOrganizations>
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
