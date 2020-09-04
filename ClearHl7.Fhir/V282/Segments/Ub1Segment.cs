using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment UB1 - Ub82.
    /// </summary>
    public class Ub1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "UB1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// UB1.1 - Set ID - UB1.
        ///// </summary>
        //public SetIdUb1 { get; set; }

        ///// <summary>
        ///// UB1.2 - Blood Deductible.
        ///// </summary>
        //public BloodDeductible { get; set; }

        ///// <summary>
        ///// UB1.3 - Blood Furnished-Pints.
        ///// </summary>
        //public BloodFurnishedPints { get; set; }

        ///// <summary>
        ///// UB1.4 - Blood Replaced-Pints.
        ///// </summary>
        //public BloodReplacedPints { get; set; }

        ///// <summary>
        ///// UB1.5 - Blood Not Replaced-Pints.
        ///// </summary>
        //public BloodNotReplacedPints { get; set; }

        ///// <summary>
        ///// UB1.6 - Co-Insurance Days.
        ///// </summary>
        //public CoInsuranceDays { get; set; }

        ///// <summary>
        ///// UB1.7 - Condition Code.
        ///// </summary>
        //public ConditionCode { get; set; }

        ///// <summary>
        ///// UB1.8 - Covered Days.
        ///// </summary>
        //public CoveredDays { get; set; }

        ///// <summary>
        ///// UB1.9 - Non Covered Days.
        ///// </summary>
        //public NonCoveredDays { get; set; }

        ///// <summary>
        ///// UB1.10 - Value Amount & Code.
        ///// </summary>
        //public ValueAmountCode { get; set; }

        ///// <summary>
        ///// UB1.11 - Number Of Grace Days.
        ///// </summary>
        //public NumberOfGraceDays { get; set; }

        ///// <summary>
        ///// UB1.12 - Special Program Indicator.
        ///// </summary>
        //public SpecialProgramIndicator { get; set; }

        ///// <summary>
        ///// UB1.13 - PSRO/UR Approval Indicator.
        ///// </summary>
        //public PsroUrApprovalIndicator { get; set; }

        ///// <summary>
        ///// UB1.14 - PSRO/UR Approved Stay-Fm.
        ///// </summary>
        //public PsroUrApprovedStayFm { get; set; }

        ///// <summary>
        ///// UB1.15 - PSRO/UR Approved Stay-To.
        ///// </summary>
        //public PsroUrApprovedStayTo { get; set; }

        ///// <summary>
        ///// UB1.16 - Occurrence.
        ///// </summary>
        //public Occurrence { get; set; }

        ///// <summary>
        ///// UB1.17 - Occurrence Span.
        ///// </summary>
        //public OccurrenceSpan { get; set; }

        ///// <summary>
        ///// UB1.18 - Occur Span Start Date.
        ///// </summary>
        //public OccurSpanStartDate { get; set; }

        ///// <summary>
        ///// UB1.19 - Occur Span End Date.
        ///// </summary>
        //public OccurSpanEndDate { get; set; }

        ///// <summary>
        ///// UB1.20 - UB-82 Locator 2.
        ///// </summary>
        //public Ub82Locator2 { get; set; }

        ///// <summary>
        ///// UB1.21 - UB-82 Locator 9.
        ///// </summary>
        //public Ub82Locator9 { get; set; }

        ///// <summary>
        ///// UB1.22 - UB-82 Locator 27.
        ///// </summary>
        //public Ub82Locator27 { get; set; }

        ///// <summary>
        ///// UB1.23 - UB-82 Locator 45.
        ///// </summary>
        //public Ub82Locator45 { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}"
                                ).TrimEnd('|');
        }
    }
}