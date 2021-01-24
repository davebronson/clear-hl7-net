using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PRB - Problem Details.
    /// </summary>
    public class PrbSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PRB";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PRB.1 - Action Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0287</remarks>
        public string ActionCode { get; set; }

        /// <summary>
        /// PRB.2 - Action Date/Time.
        /// </summary>
        public DateTime? ActionDateTime { get; set; }

        /// <summary>
        /// PRB.3 - Problem ID.
        /// </summary>
        public CodedElement ProblemId { get; set; }

        /// <summary>
        /// PRB.4 - Problem Instance ID.
        /// </summary>
        public EntityIdentifier ProblemInstanceId { get; set; }

        /// <summary>
        /// PRB.5 - Episode of Care ID.
        /// </summary>
        public EntityIdentifier EpisodeOfCareId { get; set; }

        /// <summary>
        /// PRB.6 - Problem List Priority.
        /// </summary>
        public decimal? ProblemListPriority { get; set; }

        /// <summary>
        /// PRB.7 - Problem Established Date/Time.
        /// </summary>
        public DateTime? ProblemEstablishedDateTime { get; set; }

        /// <summary>
        /// PRB.8 - Anticipated Problem Resolution Date/Time.
        /// </summary>
        public DateTime? AnticipatedProblemResolutionDateTime { get; set; }

        /// <summary>
        /// PRB.9 - Actual Problem Resolution Date/Time.
        /// </summary>
        public DateTime? ActualProblemResolutionDateTime { get; set; }

        /// <summary>
        /// PRB.10 - Problem Classification.
        /// </summary>
        public CodedElement ProblemClassification { get; set; }

        /// <summary>
        /// PRB.11 - Problem Management Discipline.
        /// </summary>
        public IEnumerable<CodedElement> ProblemManagementDiscipline { get; set; }

        /// <summary>
        /// PRB.12 - Problem Persistence.
        /// </summary>
        public CodedElement ProblemPersistence { get; set; }

        /// <summary>
        /// PRB.13 - Problem Confirmation Status.
        /// </summary>
        public CodedElement ProblemConfirmationStatus { get; set; }

        /// <summary>
        /// PRB.14 - Problem Life Cycle Status.
        /// </summary>
        public CodedElement ProblemLifeCycleStatus { get; set; }

        /// <summary>
        /// PRB.15 - Problem Life Cycle Status Date/Time.
        /// </summary>
        public DateTime? ProblemLifeCycleStatusDateTime { get; set; }

        /// <summary>
        /// PRB.16 - Problem Date of Onset.
        /// </summary>
        public DateTime? ProblemDateOfOnset { get; set; }

        /// <summary>
        /// PRB.17 - Problem Onset Text.
        /// </summary>
        public string ProblemOnsetText { get; set; }

        /// <summary>
        /// PRB.18 - Problem Ranking.
        /// </summary>
        public CodedElement ProblemRanking { get; set; }

        /// <summary>
        /// PRB.19 - Certainty of Problem.
        /// </summary>
        public CodedElement CertaintyOfProblem { get; set; }

        /// <summary>
        /// PRB.20 - Probability of Problem (0-1).
        /// </summary>
        public decimal? ProbabilityOfProblem01 { get; set; }

        /// <summary>
        /// PRB.21 - Individual Awareness of Problem.
        /// </summary>
        public CodedElement IndividualAwarenessOfProblem { get; set; }

        /// <summary>
        /// PRB.22 - Problem Prognosis.
        /// </summary>
        public CodedElement ProblemPrognosis { get; set; }

        /// <summary>
        /// PRB.23 - Individual Awareness of Prognosis.
        /// </summary>
        public CodedElement IndividualAwarenessOfPrognosis { get; set; }

        /// <summary>
        /// PRB.24 - Family/Significant Other Awareness of Problem/Prognosis.
        /// </summary>
        public string FamilySignificantOtherAwarenessOfProblemPrognosis { get; set; }

        /// <summary>
        /// PRB.25 - Security/Sensitivity.
        /// </summary>
        public CodedElement SecuritySensitivity { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 26, Configuration.FieldSeparator),
                                Id,
                                ActionCode,
                                ActionDateTime.HasValue ? ActionDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProblemId?.ToDelimitedString(),
                                ProblemInstanceId?.ToDelimitedString(),
                                EpisodeOfCareId?.ToDelimitedString(),
                                ProblemListPriority.HasValue ? ProblemListPriority.Value.ToString(Consts.NumericFormat, culture) : null,
                                ProblemEstablishedDateTime.HasValue ? ProblemEstablishedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AnticipatedProblemResolutionDateTime.HasValue ? AnticipatedProblemResolutionDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ActualProblemResolutionDateTime.HasValue ? ActualProblemResolutionDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProblemClassification?.ToDelimitedString(),
                                ProblemManagementDiscipline != null ? string.Join(Configuration.FieldRepeatSeparator, ProblemManagementDiscipline.Select(x => x.ToDelimitedString())) : null,
                                ProblemPersistence?.ToDelimitedString(),
                                ProblemConfirmationStatus?.ToDelimitedString(),
                                ProblemLifeCycleStatus?.ToDelimitedString(),
                                ProblemLifeCycleStatusDateTime.HasValue ? ProblemLifeCycleStatusDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProblemDateOfOnset.HasValue ? ProblemDateOfOnset.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ProblemOnsetText,
                                ProblemRanking?.ToDelimitedString(),
                                CertaintyOfProblem?.ToDelimitedString(),
                                ProbabilityOfProblem01.HasValue ? ProbabilityOfProblem01.Value.ToString(Consts.NumericFormat, culture) : null,
                                IndividualAwarenessOfProblem?.ToDelimitedString(),
                                ProblemPrognosis?.ToDelimitedString(),
                                IndividualAwarenessOfPrognosis?.ToDelimitedString(),
                                FamilySignificantOtherAwarenessOfProblemPrognosis,
                                SecuritySensitivity?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}