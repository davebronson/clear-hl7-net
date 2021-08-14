using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
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
        /// <para>Suggested: 0287 Problem/Goal Action Code -&gt; ClearHl7.Codes.V251.CodeProblemGoalActionCode</para>
        /// </summary>
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
            ActionDateTime = segments.ElementAtOrDefault(2)?.ToNullableDateTime();
            ProblemId = segments.Length > 3 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(3), false) : null;
            ProblemInstanceId = segments.Length > 4 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(4), false) : null;
            EpisodeOfCareId = segments.Length > 5 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(5), false) : null;
            ProblemListPriority = segments.ElementAtOrDefault(6)?.ToNullableDecimal();
            ProblemEstablishedDateTime = segments.ElementAtOrDefault(7)?.ToNullableDateTime();
            AnticipatedProblemResolutionDateTime = segments.ElementAtOrDefault(8)?.ToNullableDateTime();
            ActualProblemResolutionDateTime = segments.ElementAtOrDefault(9)?.ToNullableDateTime();
            ProblemClassification = segments.Length > 10 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(10), false) : null;
            ProblemManagementDiscipline = segments.Length > 11 ? segments.ElementAtOrDefault(11).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ProblemPersistence = segments.Length > 12 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(12), false) : null;
            ProblemConfirmationStatus = segments.Length > 13 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(13), false) : null;
            ProblemLifeCycleStatus = segments.Length > 14 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(14), false) : null;
            ProblemLifeCycleStatusDateTime = segments.ElementAtOrDefault(15)?.ToNullableDateTime();
            ProblemDateOfOnset = segments.ElementAtOrDefault(16)?.ToNullableDateTime();
            ProblemOnsetText = segments.ElementAtOrDefault(17);
            ProblemRanking = segments.Length > 18 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(18), false) : null;
            CertaintyOfProblem = segments.Length > 19 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(19), false) : null;
            ProbabilityOfProblem01 = segments.ElementAtOrDefault(20)?.ToNullableDecimal();
            IndividualAwarenessOfProblem = segments.Length > 21 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(21), false) : null;
            ProblemPrognosis = segments.Length > 22 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(22), false) : null;
            IndividualAwarenessOfPrognosis = segments.Length > 23 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(23), false) : null;
            FamilySignificantOtherAwarenessOfProblemPrognosis = segments.ElementAtOrDefault(24);
            SecuritySensitivity = segments.Length > 25 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(25), false) : null;
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