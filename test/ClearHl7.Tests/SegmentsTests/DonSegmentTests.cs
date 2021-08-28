using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class DonSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new DonSegment
            {
                DonationIdentificationNumberDin = new EntityIdentifier
                {
                    EntityId = "1"
                },
                DonationType = new CodedWithNoExceptions
                {
                    Identifier = "2"
                },
                PhlebotomyStartDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                PhlebotomyEndDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                DonationDuration = 5,
                DonationDurationUnits = new CodedWithNoExceptions
                {
                    Identifier = "6"
                },
                IntendedProcedureType = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "7"
                    }
                },
                ActualProcedureType = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "8"
                    }
                },
                DonorEligibilityFlag = "9",
                DonorEligibilityProcedureType = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "10"
                    }
                },
                DonorEligibilityDate = new DateTime(2020, 11, 11, 0, 0, 11),
                ProcessInterruption = new CodedWithNoExceptions
                {
                    Identifier = "12"
                },
                ProcessInterruptionReason = new CodedWithNoExceptions
                {
                    Identifier = "13"
                },
                PhlebotomyIssue = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "14"
                    }
                },
                IntendedRecipientBloodRelative = "15",
                IntendedRecipientName = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "16"
                    }
                },
                IntendedRecipientDob = new DateTime(2020, 1, 17, 0, 0, 17),
                IntendedRecipientFacility = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "18"
                },
                IntendedRecipientProcedureDate = new DateTime(2020, 1, 19, 0, 0, 19),
                IntendedRecipientOrderingProvider = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "20"
                    }
                },
                PhlebotomyStatus = new CodedWithNoExceptions
                {
                    Identifier = "21"
                },
                ArmStick = new CodedWithNoExceptions
                {
                    Identifier = "22"
                },
                BleedStartPhlebotomist = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "23"
                    }
                },
                BleedEndPhlebotomist = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "24"
                    }
                },
                AphaeresisTypeMachine = "25",
                AphaeresisMachineSerialNumber = "26",
                DonorReaction = "27",
                FinalReviewStaffId = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "28"
                    }
                },
                FinalReviewDateTime = new DateTime(2020, 1, 29, 0, 0, 29),
                NumberOfTubesCollected = 30,
                DonationSampleIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "31"
                    }
                },
                DonationAcceptStaff = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "32"
                },
                DonationMaterialReviewStaff = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "33"
                    }
                },
                ActionCode = "34"
            };

            ISegment actual = new DonSegment();
            actual.FromDelimitedString("DON|1|2|20200303000003|20200404000004|5|6|7|8|9|10|20201111000011|12|13|14|15|16|20200117000017|18|20200119000019|20|21|22|23|24|25|26|27|28|20200129000029|30|31|32|33|34");

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
                ISegment hl7Segment = new DonSegment();
                hl7Segment.FromDelimitedString("DOA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new DonSegment
            {
                DonationIdentificationNumberDin = new EntityIdentifier
                {
                    EntityId = "1"
                },
                DonationType = new CodedWithNoExceptions
                {
                    Identifier = "2"
                },
                PhlebotomyStartDateTime = new DateTime(2020, 3, 3, 0, 0, 3),
                PhlebotomyEndDateTime = new DateTime(2020, 4, 4, 0, 0, 4),
                DonationDuration = 5,
                DonationDurationUnits = new CodedWithNoExceptions
                {
                    Identifier = "6"
                },
                IntendedProcedureType = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "7"
                    }
                },
                ActualProcedureType = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "8"
                    }
                },
                DonorEligibilityFlag = "9",
                DonorEligibilityProcedureType = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "10"
                    }
                },
                DonorEligibilityDate = new DateTime(2020, 11, 11, 0, 0, 11),
                ProcessInterruption = new CodedWithNoExceptions
                {
                    Identifier = "12"
                },
                ProcessInterruptionReason = new CodedWithNoExceptions
                {
                    Identifier = "13"
                },
                PhlebotomyIssue = new CodedWithNoExceptions[]
                {
                    new CodedWithNoExceptions
                    {
                        Identifier = "14"
                    }
                },
                IntendedRecipientBloodRelative = "15",
                IntendedRecipientName = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "16"
                    }
                },
                IntendedRecipientDob = new DateTime(2020, 1, 17, 0, 0, 17),
                IntendedRecipientFacility = new ExtendedCompositeNameAndIdNumberForOrganizations
                {
                    OrganizationName = "18"
                },
                IntendedRecipientProcedureDate = new DateTime(2020, 1, 19, 0, 0, 19),
                IntendedRecipientOrderingProvider = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "20"
                    }
                },
                PhlebotomyStatus = new CodedWithNoExceptions
                {
                    Identifier = "21"
                },
                ArmStick = new CodedWithNoExceptions
                {
                    Identifier = "22"
                },
                BleedStartPhlebotomist = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "23"
                    }
                },
                BleedEndPhlebotomist = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "24"
                    }
                },
                AphaeresisTypeMachine = "25",
                AphaeresisMachineSerialNumber = "26",
                DonorReaction = "27",
                FinalReviewStaffId = new ExtendedPersonName
                {
                    FamilyName = new FamilyName
                    {
                        Surname = "28"
                    }
                },
                FinalReviewDateTime = new DateTime(2020, 1, 29, 0, 0, 29),
                NumberOfTubesCollected = 30,
                DonationSampleIdentifier = new EntityIdentifier[]
                {
                    new EntityIdentifier
                    {
                        EntityId = "31"
                    }
                },
                DonationAcceptStaff = new ExtendedCompositeIdNumberAndNameForPersons
                {
                    PersonIdentifier = "32"
                },
                DonationMaterialReviewStaff = new ExtendedCompositeIdNumberAndNameForPersons[]
                {
                    new ExtendedCompositeIdNumberAndNameForPersons
                    {
                        PersonIdentifier = "33"
                    }
                },
                ActionCode = "34"
            };

            string expected = "DON|1|2|20200303000003|20200404000004|5|6|7|8|9|10|20201111000011|12|13|14|15|16|20200117000017|18|20200119000019|20|21|22|23|24|25|26|27|28|20200129000029|30|31|32|33|34";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
