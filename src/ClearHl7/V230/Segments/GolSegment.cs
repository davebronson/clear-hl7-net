﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment GOL - Goal Detail.
    /// </summary>
    public class GolSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "GOL";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// GOL.1 - Action Code.
        /// <para>Suggested: 0287 Problem/Goal Action Code -&gt; ClearHl7.Codes.V230.CodeProblemGoalActionCode</para>
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// GOL.2 - Action Date/Time.
        /// </summary>
        public DateTime? ActionDateTime { get; set; }

        /// <summary>
        /// GOL.3 - Goal ID.
        /// </summary>
        public CodedElement GoalId { get; set; }

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
        public CodedElement GoalClassification { get; set; }

        /// <summary>
        /// GOL.10 - Goal Management Discipline.
        /// </summary>
        public CodedElement GoalManagementDiscipline { get; set; }

        /// <summary>
        /// GOL.11 - Current Goal Review Status.
        /// </summary>
        public CodedElement CurrentGoalReviewStatus { get; set; }

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
        public TimingQuantity GoalReviewInterval { get; set; }

        /// <summary>
        /// GOL.16 - Goal Evaluation.
        /// </summary>
        public CodedElement GoalEvaluation { get; set; }

        /// <summary>
        /// GOL.17 - Goal Evaluation Comment.
        /// </summary>
        public IEnumerable<string> GoalEvaluationComment { get; set; }

        /// <summary>
        /// GOL.18 - Goal Life Cycle Status.
        /// </summary>
        public CodedElement GoalLifeCycleStatus { get; set; }

        /// <summary>
        /// GOL.19 - Goal Life Cycle Status Date/Time.
        /// </summary>
        public DateTime? GoalLifeCycleStatusDateTime { get; set; }

        /// <summary>
        /// GOL.20 - Goal Target Type.
        /// </summary>
        public IEnumerable<CodedElement> GoalTargetType { get; set; }

        /// <summary>
        /// GOL.21 - Goal Target Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> GoalTargetName { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
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
            GoalId = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], false, seps) : null;
            GoalInstanceId = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[4], false, seps) : null;
            EpisodeOfCareId = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[5], false, seps) : null;
            GoalListPriority = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            GoalEstablishedDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            ExpectedGoalAchieveDateTime = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDateTime() : null;
            GoalClassification = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[9], false, seps) : null;
            GoalManagementDiscipline = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[10], false, seps) : null;
            CurrentGoalReviewStatus = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[11], false, seps) : null;
            CurrentGoalReviewDateTime = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDateTime() : null;
            NextGoalReviewDateTime = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            PreviousGoalReviewDateTime = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            GoalReviewInterval = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<TimingQuantity>(segments[15], false, seps) : null;
            GoalEvaluation = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[16], false, seps) : null;
            GoalEvaluationComment = segments.Length > 17 && segments[17].Length > 0 ? segments[17].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            GoalLifeCycleStatus = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[18], false, seps) : null;
            GoalLifeCycleStatusDateTime = segments.Length > 19 && segments[19].Length > 0 ? segments[19].ToNullableDateTime() : null;
            GoalTargetType = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            GoalTargetName = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedPersonName>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 22, Configuration.FieldSeparator),
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
                                GoalReviewInterval?.ToDelimitedString(),
                                GoalEvaluation?.ToDelimitedString(),
                                GoalEvaluationComment != null ? string.Join(Configuration.FieldRepeatSeparator, GoalEvaluationComment) : null,
                                GoalLifeCycleStatus?.ToDelimitedString(),
                                GoalLifeCycleStatusDateTime.HasValue ? GoalLifeCycleStatusDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                GoalTargetType != null ? string.Join(Configuration.FieldRepeatSeparator, GoalTargetType.Select(x => x.ToDelimitedString())) : null,
                                GoalTargetName != null ? string.Join(Configuration.FieldRepeatSeparator, GoalTargetName.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
