﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
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
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V280.CodeSegmentActionCode</para>
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
        /// <para>Suggested: 0725 Mood Codes -&gt; ClearHl7.Codes.V280.CodeMoodCodes</para>
        /// </summary>
        public CodedWithNoExceptions MoodCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ActionCode = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            ActionDateTime = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            GoalId = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[3], false) : null;
            GoalInstanceId = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[4], false) : null;
            EpisodeOfCareId = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[5], false) : null;
            GoalListPriority = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            GoalEstablishedDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            ExpectedGoalAchieveDateTime = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            GoalClassification = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[9], false) : null;
            GoalManagementDiscipline = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[10], false) : null;
            CurrentGoalReviewStatus = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[11], false) : null;
            CurrentGoalReviewDateTime = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDateTime() : null;
            NextGoalReviewDateTime = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            PreviousGoalReviewDateTime = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            GoalReviewInterval = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            GoalEvaluation = segments.Length > 16 && segments[16].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[16], false) : null;
            GoalEvaluationComment = segments.Length > 17 && segments[17].Length > 0 ? segments[17].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            GoalLifeCycleStatus = segments.Length > 18 && segments[18].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[18], false) : null;
            GoalLifeCycleStatusDateTime = segments.Length > 19 && segments[19].Length > 0 ? segments[19].ToNullableDateTime() : null;
            GoalTargetType = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            GoalTargetName = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            MoodCode = segments.Length > 22 && segments[22].Length > 0 ? TypeHelper.Deserialize<CodedWithNoExceptions>(segments[22], false) : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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