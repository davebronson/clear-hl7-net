using System;
using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class Al1SegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Al1Segment
            {
                SetIdAl1 = 1,
                AllergenTypeCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AllergenCodeMnemonicDescription = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                AllergySeverityCode = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                AllergyReactionCode = new string[]
                {
                    "5"
                },
                IdentificationDate = new DateTime(2020, 6, 6)
            };

            string expected = "AL1|1|2|3|4|5|20200606";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
