using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class MrgSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new MrgSegment
            {
                PriorPatientIdentifierList = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "1"
                    }
                },
                PriorAlternatePatientId = "2",
                PriorPatientAccountNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "3"
                },
                PriorPatientId = "4",
                PriorVisitNumber = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "5"
                },
                PriorAlternateVisitId = new ExtendedCompositeIdWithCheckDigit[]
                {
                    new ExtendedCompositeIdWithCheckDigit
                    {
                        IdNumber = "6"
                    }
                },
                PriorPatientName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "7"
                        }
                    }
                }
            };

            string expected = "MRG|1|2|3|4|5|6|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
