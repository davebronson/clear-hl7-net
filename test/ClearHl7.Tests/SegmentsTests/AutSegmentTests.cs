using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class AutSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new AutSegment
            {
                AuthorizingPayorPlanId = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                AuthorizingPayorCompanyId = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AuthorizingPayorCompanyName = "3",
                AuthorizationEffectiveDate = new DateTime(2020, 4, 4, 0, 0, 4),
                AuthorizationExpirationDate = new DateTime(2020, 5, 5, 0, 0, 5),
                AuthorizationIdentifier = new EntityIdentifier
                {
                    EntityId = "6"
                },
                ReimbursementLimit = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 7
                    }
                },
                RequestedNumberOfTreatments = new CompositeQuantityWithUnits
                {
                    Quantity = 8
                },
                AuthorizedNumberOfTreatments = new CompositeQuantityWithUnits
                {
                    Quantity = 9
                },
                ProcessDate = new DateTime(2020, 10, 10, 0, 0, 10),
                RequestedDisciplines = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                AuthorizedDisciplines = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "12"
                    }
                },
                AuthorizationReferralType = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                ApprovalStatus = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                PlannedTreatmentStopDate = new DateTime(2020, 1, 15, 0, 0, 15),
                ClinicalService = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                ReasonText = "17",
                NumberOfAuthorizedTreatmentsUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 18
                },
                NumberOfUsedTreatmentsUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 19
                },
                NumberOfScheduleTreatmentsUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 20
                },
                EncounterType = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                RemainingBenefitAmount = new Money
                {
                    Quantity = 22
                },
                AuthorizedProvider = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "23"
                },
                AuthorizedHealthProfessional = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "24"
                },
                SourceText = "25",
                SourceDate = new DateTime(2020, 1, 26, 0, 0, 26),
                SourcePhone = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "27"
                },
                Comment = "28",
                ActionCode = "29"
            };

            ISegment actual = new AutSegment();
            actual.FromDelimitedString("AUT|1|2|3|20200404000004|20200505000005|6|7|8|9|20201010000010|11|12|13|14|20200115000015|16|17|18|19|20|21|22|23|24|25|20200126000026|27|28|29");

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
                ISegment hl7Segment = new AutSegment();
                hl7Segment.FromDelimitedString("AUA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new AutSegment
            {
                AuthorizingPayorPlanId = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                AuthorizingPayorCompanyId = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                AuthorizingPayorCompanyName = "3",
                AuthorizationEffectiveDate = new DateTime(2020, 4, 4, 0, 0, 4),
                AuthorizationExpirationDate = new DateTime(2020, 5, 5, 0, 0, 5),
                AuthorizationIdentifier = new EntityIdentifier
                {
                    EntityId = "6"
                },
                ReimbursementLimit = new CompositePrice
                {
                    Price = new Money
                    {
                        Quantity = 7
                    }
                },
                RequestedNumberOfTreatments = new CompositeQuantityWithUnits
                {
                    Quantity = 8
                },
                AuthorizedNumberOfTreatments = new CompositeQuantityWithUnits
                {
                    Quantity = 9
                },
                ProcessDate = new DateTime(2020, 10, 10, 0, 0, 10),
                RequestedDisciplines = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                AuthorizedDisciplines = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "12"
                    }
                },
                AuthorizationReferralType = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                ApprovalStatus = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                PlannedTreatmentStopDate = new DateTime(2020, 1, 15, 0, 0, 15),
                ClinicalService = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                ReasonText = "17",
                NumberOfAuthorizedTreatmentsUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 18
                },
                NumberOfUsedTreatmentsUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 19
                },
                NumberOfScheduleTreatmentsUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 20
                },
                EncounterType = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                RemainingBenefitAmount = new Money
                {
                    Quantity = 22
                },
                AuthorizedProvider = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "23"
                },
                AuthorizedHealthProfessional = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "24"
                },
                SourceText = "25",
                SourceDate = new DateTime(2020, 1, 26, 0, 0, 26),
                SourcePhone = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "27"
                },
                Comment = "28",
                ActionCode = "29"
            };

            string expected = "AUT|1|2|3|20200404000004|20200505000005|6|7|8|9|20201010000010|11|12|13|14|20200115000015|16|17|18|19|20|21|22|23|24|25|20200126000026|27|28|29";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
