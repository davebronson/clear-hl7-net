using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V240.Types;

namespace ClearHl7.Fhir.V240.Segments
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
        /// <remarks>https://www.hl7.org/fhir/v2/0287</remarks>
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

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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