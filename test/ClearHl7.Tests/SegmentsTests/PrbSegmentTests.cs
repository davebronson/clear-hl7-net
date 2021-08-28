using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class PrbSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new PrbSegment
            {
                ActionCode = "1",
                ActionDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                ProblemId = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ProblemInstanceId = new EntityIdentifier
                {
                    EntityId = "4"
                },
                EpisodeOfCareId = new EntityIdentifier
                {
                    EntityId = "5"
                },
                ProblemListPriority = 6,
                ProblemEstablishedDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                AnticipatedProblemResolutionDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                ActualProblemResolutionDateTime = new DateTime(2020, 9, 9, 0, 0, 9),
                ProblemClassification = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                ProblemManagementDiscipline = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                ProblemPersistence = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                ProblemConfirmationStatus = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                ProblemLifeCycleStatus = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                ProblemLifeCycleStatusDateTime = new DateTime(2020, 1, 15, 0, 0, 15),
                ProblemDateOfOnset = new DateTime(2020, 1, 16, 0, 0, 16),
                ProblemOnsetText = "17",
                ProblemRanking = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                CertaintyOfProblem = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                ProbabilityOfProblem01 = 20,
                IndividualAwarenessOfProblem = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                ProblemPrognosis = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                IndividualAwarenessOfPrognosis = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                FamilySignificantOtherAwarenessOfProblemPrognosis = "24",
                SecuritySensitivity = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                ProblemSeverity = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                ProblemPerspective = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                MoodCode = new CodedWithNoExceptions
                {
                    Identifier = "28"
                }
            };

            ISegment actual = new PrbSegment();
            actual.FromDelimitedString("PRB|1|20200202000002|3|4|5|6|20200707000007|20200808000008|20200909000009|10|11|12|13|14|20200115000015|20200116000016|17|18|19|20|21|22|23|24|25|26|27|28");

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
                ISegment hl7Segment = new PrbSegment();
                hl7Segment.FromDelimitedString("PRA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new PrbSegment
            {
                ActionCode = "1",
                ActionDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                ProblemId = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                ProblemInstanceId = new EntityIdentifier
                {
                    EntityId = "4"
                },
                EpisodeOfCareId = new EntityIdentifier
                {
                    EntityId = "5"
                },
                ProblemListPriority = 6,
                ProblemEstablishedDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                AnticipatedProblemResolutionDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                ActualProblemResolutionDateTime = new DateTime(2020, 9, 9, 0, 0, 9),
                ProblemClassification = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                ProblemManagementDiscipline = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "11"
                    }
                },
                ProblemPersistence = new CodedWithExceptions
                {
                    Identifier = "12"
                },
                ProblemConfirmationStatus = new CodedWithExceptions
                {
                    Identifier = "13"
                },
                ProblemLifeCycleStatus = new CodedWithExceptions
                {
                    Identifier = "14"
                },
                ProblemLifeCycleStatusDateTime = new DateTime(2020, 1, 15, 0, 0, 15),
                ProblemDateOfOnset = new DateTime(2020, 1, 16, 0, 0, 16),
                ProblemOnsetText = "17",
                ProblemRanking = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                CertaintyOfProblem = new CodedWithExceptions
                {
                    Identifier = "19"
                },
                ProbabilityOfProblem01 = 20,
                IndividualAwarenessOfProblem = new CodedWithExceptions
                {
                    Identifier = "21"
                },
                ProblemPrognosis = new CodedWithExceptions
                {
                    Identifier = "22"
                },
                IndividualAwarenessOfPrognosis = new CodedWithExceptions
                {
                    Identifier = "23"
                },
                FamilySignificantOtherAwarenessOfProblemPrognosis = "24",
                SecuritySensitivity = new CodedWithExceptions
                {
                    Identifier = "25"
                },
                ProblemSeverity = new CodedWithExceptions
                {
                    Identifier = "26"
                },
                ProblemPerspective = new CodedWithExceptions
                {
                    Identifier = "27"
                },
                MoodCode = new CodedWithNoExceptions
                {
                    Identifier = "28"
                }
            };

            string expected = "PRB|1|20200202000002|3|4|5|6|20200707000007|20200808000008|20200909000009|10|11|12|13|14|20200115000015|20200116000016|17|18|19|20|21|22|23|24|25|26|27|28";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
