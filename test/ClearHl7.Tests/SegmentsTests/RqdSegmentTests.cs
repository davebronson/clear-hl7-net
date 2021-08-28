using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class RqdSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new RqdSegment
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

            ISegment actual = new RqdSegment();
            actual.FromDelimitedString("RQD|1|2|3|4|5|6|7|8|9|20201010");

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
                ISegment hl7Segment = new RqdSegment();
                hl7Segment.FromDelimitedString("RQA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
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
