using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class UacSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new UacSegment
            {
                UserAuthenticationCredentialTypeCode = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                UserAuthenticationCredential = new EncapsulatedData
                {
                    SourceApplication = new HierarchicDesignator
                    {
                        NamespaceId = "2"
                    }
                }
            };

            string expected = "UAC|1|2";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
