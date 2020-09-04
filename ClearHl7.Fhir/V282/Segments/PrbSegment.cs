using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// PRB.1 - Action Code.
        ///// </summary>
        //public ActionCode { get; set; }

        ///// <summary>
        ///// PRB.2 - Action Date/Time.
        ///// </summary>
        //public ActionDateTime { get; set; }

        ///// <summary>
        ///// PRB.3 - Problem ID.
        ///// </summary>
        //public ProblemId { get; set; }

        ///// <summary>
        ///// PRB.4 - Problem Instance ID.
        ///// </summary>
        //public ProblemInstanceId { get; set; }

        ///// <summary>
        ///// PRB.5 - Episode of Care ID.
        ///// </summary>
        //public EpisodeOfCareId { get; set; }

        ///// <summary>
        ///// PRB.6 - Problem List Priority.
        ///// </summary>
        //public ProblemListPriority { get; set; }

        ///// <summary>
        ///// PRB.7 - Problem Established Date/Time.
        ///// </summary>
        //public ProblemEstablishedDateTime { get; set; }

        ///// <summary>
        ///// PRB.8 - Anticipated Problem Resolution Date/Time.
        ///// </summary>
        //public AnticipatedProblemResolutionDateTime { get; set; }

        ///// <summary>
        ///// PRB.9 - Actual Problem Resolution Date/Time.
        ///// </summary>
        //public ActualProblemResolutionDateTime { get; set; }

        ///// <summary>
        ///// PRB.10 - Problem Classification.
        ///// </summary>
        //public ProblemClassification { get; set; }

        ///// <summary>
        ///// PRB.11 - Problem Management Discipline.
        ///// </summary>
        //public ProblemManagementDiscipline { get; set; }

        ///// <summary>
        ///// PRB.12 - Problem Persistence.
        ///// </summary>
        //public ProblemPersistence { get; set; }

        ///// <summary>
        ///// PRB.13 - Problem Confirmation Status.
        ///// </summary>
        //public ProblemConfirmationStatus { get; set; }

        ///// <summary>
        ///// PRB.14 - Problem Life Cycle Status.
        ///// </summary>
        //public ProblemLifeCycleStatus { get; set; }

        ///// <summary>
        ///// PRB.15 - Problem Life Cycle Status Date/Time.
        ///// </summary>
        //public ProblemLifeCycleStatusDateTime { get; set; }

        ///// <summary>
        ///// PRB.16 - Problem Date of Onset.
        ///// </summary>
        //public ProblemDateOfOnset { get; set; }

        ///// <summary>
        ///// PRB.17 - Problem Onset Text.
        ///// </summary>
        //public ProblemOnsetText { get; set; }

        ///// <summary>
        ///// PRB.18 - Problem Ranking.
        ///// </summary>
        //public ProblemRanking { get; set; }

        ///// <summary>
        ///// PRB.19 - Certainty of Problem.
        ///// </summary>
        //public CertaintyOfProblem { get; set; }

        ///// <summary>
        ///// PRB.20 - Probability of Problem (0-1).
        ///// </summary>
        //public ProbabilityOfProblem01 { get; set; }

        ///// <summary>
        ///// PRB.21 - Individual Awareness of Problem.
        ///// </summary>
        //public IndividualAwarenessOfProblem { get; set; }

        ///// <summary>
        ///// PRB.22 - Problem Prognosis.
        ///// </summary>
        //public ProblemPrognosis { get; set; }

        ///// <summary>
        ///// PRB.23 - Individual Awareness of Prognosis.
        ///// </summary>
        //public IndividualAwarenessOfPrognosis { get; set; }

        ///// <summary>
        ///// PRB.24 - Family/Significant Other Awareness of Problem/Prognosis.
        ///// </summary>
        //public FamilySignificantOtherAwarenessOfProblemPrognosis { get; set; }

        ///// <summary>
        ///// PRB.25 - Security/Sensitivity.
        ///// </summary>
        //public SecuritySensitivity { get; set; }

        ///// <summary>
        ///// PRB.26 - Problem Severity.
        ///// </summary>
        //public ProblemSeverity { get; set; }

        ///// <summary>
        ///// PRB.27 - Problem Perspective.
        ///// </summary>
        //public ProblemPerspective { get; set; }

        ///// <summary>
        ///// PRB.28 - Mood Code.
        ///// </summary>
        //public MoodCode { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}"
                                ).TrimEnd('|');
        }
    }
}