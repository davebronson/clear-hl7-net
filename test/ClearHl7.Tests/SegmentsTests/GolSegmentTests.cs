using System;
using ClearHl7.V290.Segments;
using ClearHl7.V290.Types;
using FluentAssertions;
using Xunit;

namespace ClearHl7.Tests.SegmentsTests
{
    public class GolSegmentTests
    {
        /// <summary>
        /// Validates that FromDelimitedString() returns the object instance with all properties correctly initialized.
        /// </summary>
        [Fact]
        public void FromDelimitedString_WithAllProperties_ReturnsCorrectlyInitializedFields()
        {
            ISegment expected = new GolSegment
            {
                ActionCode = "1",
                ActionDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                GoalId = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                GoalInstanceId = new EntityIdentifier
                {
                    EntityId = "4"
                },
                EpisodeOfCareId = new EntityIdentifier
                {
                    EntityId = "5"
                },
                GoalListPriority = 6,
                GoalEstablishedDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                ExpectedGoalAchieveDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                GoalClassification = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                GoalManagementDiscipline = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                CurrentGoalReviewStatus = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                CurrentGoalReviewDateTime = new DateTime(2020, 12, 12, 0, 0, 12),
                NextGoalReviewDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                PreviousGoalReviewDateTime = new DateTime(2020, 1, 14, 0, 0, 14),
                GoalReviewInterval = "15",
                GoalEvaluation = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                GoalEvaluationComment = new string[]
                {
                    "17"
                },
                GoalLifeCycleStatus = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                GoalLifeCycleStatusDateTime = new DateTime(2020, 1, 19, 0, 0, 19),
                GoalTargetType = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "20"
                    }
                },
                GoalTargetName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "21"
                        }
                    }
                },
                MoodCode = new CodedWithNoExceptions
                {
                    Identifier = "22"
                }
            };

            ISegment actual = new GolSegment();
            actual.FromDelimitedString("GOL|1|20200202000002|3|4|5|6|20200707000007|20200808000008|9|10|11|20201212000012|20200113000013|20200114000014|15|16|17|18|20200119000019|20|21|22");

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
                ISegment hl7Segment = new GolSegment();
                hl7Segment.FromDelimitedString("GOA|^~&|3|4|5|6");
            });
        }

        /// <summary>
        /// Validates that ToDelimitedString() returns output with all properties populated and in the correct sequence.
        /// </summary>
        [Fact]
        public void ToDelimitedString_WithAllProperties_ReturnsCorrectlySequencedFields()
        {
            ISegment hl7Segment = new GolSegment
            {
                ActionCode = "1",
                ActionDateTime = new DateTime(2020, 2, 2, 0, 0, 2),
                GoalId = new CodedWithExceptions
                {
                    Identifier = "3"
                },
                GoalInstanceId = new EntityIdentifier
                {
                    EntityId = "4"
                },
                EpisodeOfCareId = new EntityIdentifier
                {
                    EntityId = "5"
                },
                GoalListPriority = 6,
                GoalEstablishedDateTime = new DateTime(2020, 7, 7, 0, 0, 7),
                ExpectedGoalAchieveDateTime = new DateTime(2020, 8, 8, 0, 0, 8),
                GoalClassification = new CodedWithExceptions
                {
                    Identifier = "9"
                },
                GoalManagementDiscipline = new CodedWithExceptions
                {
                    Identifier = "10"
                },
                CurrentGoalReviewStatus = new CodedWithExceptions
                {
                    Identifier = "11"
                },
                CurrentGoalReviewDateTime = new DateTime(2020, 12, 12, 0, 0, 12),
                NextGoalReviewDateTime = new DateTime(2020, 1, 13, 0, 0, 13),
                PreviousGoalReviewDateTime = new DateTime(2020, 1, 14, 0, 0, 14),
                GoalReviewInterval = "15",
                GoalEvaluation = new CodedWithExceptions
                {
                    Identifier = "16"
                },
                GoalEvaluationComment = new string[]
                {
                    "17"
                },
                GoalLifeCycleStatus = new CodedWithExceptions
                {
                    Identifier = "18"
                },
                GoalLifeCycleStatusDateTime = new DateTime(2020, 1, 19, 0, 0, 19),
                GoalTargetType = new CodedWithExceptions[]
                {
                    new CodedWithExceptions
                    {
                        Identifier = "20"
                    }
                },
                GoalTargetName = new ExtendedPersonName[]
                {
                    new ExtendedPersonName
                    {
                        FamilyName = new FamilyName
                        {
                            Surname = "21"
                        }
                    }
                },
                MoodCode = new CodedWithNoExceptions
                {
                    Identifier = "22"
                }
            };

            string expected = "GOL|1|20200202000002|3|4|5|6|20200707000007|20200808000008|9|10|11|20201212000012|20200113000013|20200114000014|15|16|17|18|20200119000019|20|21|22";
            string actual = hl7Segment.ToDelimitedString();

            Assert.Equal(expected, actual);
        }
    }
}
