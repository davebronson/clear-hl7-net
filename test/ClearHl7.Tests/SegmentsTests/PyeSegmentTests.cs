using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PyeSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PyeSegment
            {
                SetIdPye = 1,
                PayeeType = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                PayeeRelationshipToInvoicePatient = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                PayeeIdentificationList = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "4"
                },
                PayeePersonName = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "5"
                    }
                },
                PayeeAddress = new ExtendedAddress
                {
                    StreetAddress = new StreetAddress
                    {
                        StreetOrMailingAddress = "6"
                    }
                },
                PaymentMethod = new CodedWithExceptions
                {
                    Identifier = "7"
                },
            };

            string expected = "PYE|1|2|3|4|5|6|7";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
