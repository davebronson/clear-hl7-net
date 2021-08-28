using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class Rf1SegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new Rf1Segment
            {
                ReferralStatus = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                ReferralPriority = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ReferralType = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ReferralDisposition = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                },
                ReferralCategory = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                OriginatingReferralIdentifier = new EntityIdentifier
                {
                    EntityId = "6"
                },
                EffectiveDate = new DateTime(2020, 7, 7, 0, 0, 7),
                ExpirationDate = new DateTime(2020, 8, 8, 0, 0, 8),
                ProcessDate = new DateTime(2020, 9, 9, 0, 0, 9),
                ReferralReason = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "10"
                    }
                },
                ExternalReferralIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "11"
                    }
                },
                ReferralDocumentationCompletionStatus = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                PlannedTreatmentStopDate = new DateTime(2020, 1, 13, 0, 0, 13),
                ReferralReasonText = "14",
                NumberOfAuthorizedTreatmentsUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 15
                },
                NumberOfUsedTreatmentsUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 16
                },
                NumberOfScheduleTreatmentsUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 17
                },
                RemainingBenefitAmount = new Money
                {
                    Quantity = 18
                },
                AuthorizedProvider = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "19"
                },
                AuthorizedHealthProfessional = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "20"
                },
                SourceText = "21",
                SourceDate = new DateTime(2020, 1, 22, 0, 0, 22),
                SourcePhone = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "23"
                },
                Comment = "24",
                ActionCode = "25"
            };

            ISegment actual = new Rf1Segment();
            actual.FromDelimitedString("RF1|1|2|3|4|5|6|20200707000007|20200808000008|20200909000009|10|11|12|20200113000013|14|15|16|17|18|19|20|21|20200122000022|23|24|25");

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
                ISegment hl7Segment = new Rf1Segment();
                hl7Segment.FromDelimitedString("RFA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new Rf1Segment
            {
                ReferralStatus = new CodedWithExceptions
                {
                    Identifier = "1"
                },
                ReferralPriority = new CodedWithExceptions
                {
                    Identifier = "2"
                },
                ReferralType = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ReferralDisposition = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "4"
                    }
                },
                ReferralCategory = new CodedWithExceptions
                {
                    Identifier = "5"
                },
                OriginatingReferralIdentifier = new EntityIdentifier
                {
                    EntityId = "6"
                },
                EffectiveDate = new DateTime(2020, 7, 7, 0, 0, 7),
                ExpirationDate = new DateTime(2020, 8, 8, 0, 0, 8),
                ProcessDate = new DateTime(2020, 9, 9, 0, 0, 9),
                ReferralReason = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "10"
                    }
                },
                ExternalReferralIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "11"
                    }
                },
                ReferralDocumentationCompletionStatus = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                PlannedTreatmentStopDate = new DateTime(2020, 1, 13, 0, 0, 13),
                ReferralReasonText = "14",
                NumberOfAuthorizedTreatmentsUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 15
                },
                NumberOfUsedTreatmentsUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 16
                },
                NumberOfScheduleTreatmentsUnits = new CompositeQuantityWithUnits
                {
                    Quantity = 17
                },
                RemainingBenefitAmount = new Money
                {
                    Quantity = 18
                },
                AuthorizedProvider = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "19"
                },
                AuthorizedHealthProfessional = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "20"
                },
                SourceText = "21",
                SourceDate = new DateTime(2020, 1, 22, 0, 0, 22),
                SourcePhone = new ExtendedTelecommunicationNumber
                {
                    TelephoneNumber = "23"
                },
                Comment = "24",
                ActionCode = "25"
            };

            string expected = "RF1|1|2|3|4|5|6|20200707000007|20200808000008|20200909000009|10|11|12|20200113000013|14|15|16|17|18|19|20|21|20200122000022|23|24|25";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
