using System;
using ClearHl7.Fhir.V290.Segments;
using ClearHl7.Fhir.V290.Types;
using Xunit;

namespace ClearHl7.Fhir.Tests.SegmentsTests
{
    public class PmtSegmentTests
    {
        /// <summary>
        /// Validates that ToDelimitedString() returns output with all fields populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PmtSegment
            {
                PaymentRemittanceAdviceNumber = new EntityIdentifier
                {
                    EntityId = "1"
                },
                PaymentRemittanceEffectiveDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                PaymentRemittanceExpirationDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                PaymentMethod = new CodedWithExceptions
                {
                    Identifier = "4"
                },
                PaymentRemittanceDateTime = new DateTime(2020, 5, 5, 0, 0, 5),
                PaymentRemittanceAmount = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 6
                    }
                },
                CheckNumber = new EntityIdentifier
                {
                    EntityId = "7"
                },
                PayeeBankIdentification = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "8"
                },
                PayeeTransitNumber = "9",
                PayeeBankAccountId = new ExtendedCompositeIdWithCheckDigit
                {
                    IdNumber = "10"
                },
                PaymentOrganization = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "11"
                },
                EsrCodeLine = "12"
            };

            string expected = "PMT|1|20200202000002|20200303000003|4|20200505000005|6|7|8|9|10|11|12";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
