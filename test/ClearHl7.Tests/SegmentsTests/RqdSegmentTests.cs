using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RqdSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new RqdSegment
            {
                RequisitionLineNumber = 1,
                ItemCodeInternal = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ItemCodeExternal = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                HospitalItemCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                RequisitionQuantity = 5,
                RequisitionUnitOfMeasure = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                CostCenterAccountNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "7"
                },
                ItemNaturalAccountCode = new CodedWithExceptions
                {
                    Identifier = "8"
                },
                DeliverToId = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                DateNeeded = new DateTime(2020, 10, 10)
            };

            string expected = "RQD|1|2|3|4|5|6|7|8|9|20201010";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
