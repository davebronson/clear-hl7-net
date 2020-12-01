using System;
using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class AbsSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WhenFullyPopulated_ReturnsCorrectFieldSequence()
        {
            ISegment segment = new AbsSegment
            {
                DischargeCareProvider = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "1"
                },
                TransferMedicalServiceCode = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                SeverityOfIllnessCode = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                DateTimeOfAttestation = new DateTime(2020, 4, 1, 0, 0, 0),
                AttestedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "5"
                },
                TriageCode = new CodedWithExceptions
                {
                    Identifier = "6"
                },
                AbstractCompletionDateTime = new DateTime(2020, 7, 1, 0, 0, 0),
                AbstractedBy = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "8"
                },
                CaseCategoryCode = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                CaesarianSectionIndicator = "10",
                GestationCategoryCode = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                GestationPeriodWeeks = 12,
                NewbornCode = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                StillbornIndicator = "14"
            };

            string expected = "ABS|1|2|3|20200401000000|5|6|20200701000000|8|9|10|11|12|13|14";
            string actual = segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
