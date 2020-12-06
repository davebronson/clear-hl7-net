using ClearHl7.Fhir.V282.Segments;
using ClearHl7.Fhir.V282.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class ErrSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new ErrSegment
            {
                ErrorCodeAndLocation = "1",
                ErrorLocation = new ErrorLocation[]
                {
                    new ErrorLocation
                    {
                        SegmentId = "2"
                    }
                },
                Hl7ErrorCode = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                Severity = "4",
                ApplicationErrorCode = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                ApplicationErrorParameter = new string[]
                {
                    "6"
                },
                DiagnosticInformation = new Text
                {
                    Value = "7"
                },
                UserMessage = new Text
                {
                    Value = "8"
                },
                InformPersonIndicator = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "9"
                    }
                },
                OverrideType = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                OverrideReasonCode = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                HelpDeskContactPoint = new ExtendedTelecommunicationNumber[]
                {
                    new ExtendedTelecommunicationNumber
                    {
                        TelephoneNumber = "12"
                    }
                }
            };

            string expected = "ERR|1|2|3|4|5|6|7|8|9|10|11|12";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
