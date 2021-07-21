using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment GOL - Goal Detail.
    /// </summary>
    public class GolSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "GOL";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// GOL.1 - Action Code.
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// GOL.2 - Action Date/Time.
        /// </summary>
        public DateTime? ActionDateTime { get; set; }

        /// <summary>
        /// GOL.3 - Goal ID.
        /// </summary>
        public CodedWithExceptions GoalId { get; set; }

        /// <summary>
        /// GOL.4 - Goal Instance ID.
        /// </summary>
        public EntityIdentifier GoalInstanceId { get; set; }

        /// <summary>
        /// GOL.5 - Episode of Care ID.
        /// </summary>
        public EntityIdentifier EpisodeOfCareId { get; set; }

        /// <summary>
        /// GOL.6 - Goal List Priority.
        /// </summary>
        public decimal? GoalListPriority { get; set; }

        /// <summary>
        /// GOL.7 - Goal Established Date/Time.
        /// </summary>
        public DateTime? GoalEstablishedDateTime { get; set; }

        /// <summary>
        /// GOL.8 - Expected Goal Achieve Date/Time.
        /// </summary>
        public DateTime? ExpectedGoalAchieveDateTime { get; set; }

        /// <summary>
        /// GOL.9 - Goal Classification.
        /// </summary>
        public CodedWithExceptions GoalClassification { get; set; }

        /// <summary>
        /// GOL.10 - Goal Management Discipline.
        /// </summary>
        public CodedWithExceptions GoalManagementDiscipline { get; set; }

        /// <summary>
        /// GOL.11 - Current Goal Review Status.
        /// </summary>
        public CodedWithExceptions CurrentGoalReviewStatus { get; set; }

        /// <summary>
        /// GOL.12 - Current Goal Review Date/Time.
        /// </summary>
        public DateTime? CurrentGoalReviewDateTime { get; set; }

        /// <summary>
        /// GOL.13 - Next Goal Review Date/Time.
        /// </summary>
        public DateTime? NextGoalReviewDateTime { get; set; }

        /// <summary>
        /// GOL.14 - Previous Goal Review Date/Time.
        /// </summary>
        public DateTime? PreviousGoalReviewDateTime { get; set; }

        /// <summary>
        /// GOL.15 - Goal Review Interval.
        /// </summary>
        public string GoalReviewInterval { get; set; }

        /// <summary>
        /// GOL.16 - Goal Evaluation.
        /// </summary>
        public CodedWithExceptions GoalEvaluation { get; set; }

        /// <summary>
        /// GOL.17 - Goal Evaluation Comment.
        /// </summary>
        public IEnumerable<string> GoalEvaluationComment { get; set; }

        /// <summary>
        /// GOL.18 - Goal Life Cycle Status.
        /// </summary>
        public CodedWithExceptions GoalLifeCycleStatus { get; set; }

        /// <summary>
        /// GOL.19 - Goal Life Cycle Status Date/Time.
        /// </summary>
        public DateTime? GoalLifeCycleStatusDateTime { get; set; }

        /// <summary>
        /// GOL.20 - Goal Target Type.
        /// </summary>
        public IEnumerable<CodedWithExceptions> GoalTargetType { get; set; }

        /// <summary>
        /// GOL.21 - Goal Target Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> GoalTargetName { get; set; }

        /// <summary>
        /// GOL.22 - Mood Code.
        /// <para>Suggested: 0725 Mood Codes -&gt; ClearHl7.Codes.V290.CodeMoodCodes</para>
        /// </summary>
        public CodedWithNoExceptions MoodCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ActionCode = segments.ElementAtOrDefault(1);
            ActionDateTime = segments.ElementAtOrDefault(2)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            GoalId = segments.Length > 3 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(3), false) : null;
            GoalInstanceId = segments.Length > 4 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(4), false) : null;
            EpisodeOfCareId = segments.Length > 5 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(5), false) : null;
            GoalListPriority = segments.ElementAtOrDefault(6)?.ToNullableDecimal();
            GoalEstablishedDateTime = segments.ElementAtOrDefault(7)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ExpectedGoalAchieveDateTime = segments.ElementAtOrDefault(8)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            GoalClassification = segments.Length > 9 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(9), false) : null;
            GoalManagementDiscipline = segments.Length > 10 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(10), false) : null;
            CurrentGoalReviewStatus = segments.Length > 11 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(11), false) : null;
            CurrentGoalReviewDateTime = segments.ElementAtOrDefault(12)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            NextGoalReviewDateTime = segments.ElementAtOrDefault(13)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            PreviousGoalReviewDateTime = segments.ElementAtOrDefault(14)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            GoalReviewInterval = segments.ElementAtOrDefault(15);
            GoalEvaluation = segments.Length > 16 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(16), false) : null;
            GoalEvaluationComment = segments.Length > 17 ? segments.ElementAtOrDefault(17).Split(separator) : null;
            GoalLifeCycleStatus = segments.Length > 18 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(18), false) : null;
            GoalLifeCycleStatusDateTime = segments.ElementAtOrDefault(19)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            GoalTargetType = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            GoalTargetName = segments.Length > 21 ? segments.ElementAtOrDefault(21).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false))  : null;
            MoodCode = segments.Length > 22 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments.ElementAtOrDefault(22), false) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 23, Configuration.FieldSeparator),
                                Id,
                                ActionCode,
                                ActionDateTime.HasValue ? ActionDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                GoalId?.ToDelimitedString(),
                                GoalInstanceId?.ToDelimitedString(),
                                EpisodeOfCareId?.ToDelimitedString(),
                                GoalListPriority.HasValue ? GoalListPriority.Value.ToString(Consts.NumericFormat, culture) : null,
                                GoalEstablishedDateTime.HasValue ? GoalEstablishedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ExpectedGoalAchieveDateTime.HasValue ? ExpectedGoalAchieveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                GoalClassification?.ToDelimitedString(),
                                GoalManagementDiscipline?.ToDelimitedString(),
                                CurrentGoalReviewStatus?.ToDelimitedString(),
                                CurrentGoalReviewDateTime.HasValue ? CurrentGoalReviewDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                NextGoalReviewDateTime.HasValue ? NextGoalReviewDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PreviousGoalReviewDateTime.HasValue ? PreviousGoalReviewDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                GoalReviewInterval,
                                GoalEvaluation?.ToDelimitedString(),
                                GoalEvaluationComment != null ? string.Join(Configuration.FieldRepeatSeparator, GoalEvaluationComment) : null,
                                GoalLifeCycleStatus?.ToDelimitedString(),
                                GoalLifeCycleStatusDateTime.HasValue ? GoalLifeCycleStatusDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                GoalTargetType != null ? string.Join(Configuration.FieldRepeatSeparator, GoalTargetType.Select(x => x.ToDelimitedString())) : null,
                                GoalTargetName != null ? string.Join(Configuration.FieldRepeatSeparator, GoalTargetName.Select(x => x.ToDelimitedString())) : null,
                                MoodCode?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}