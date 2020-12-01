using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
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

        /// <summary>
        /// UB1.1 - Set ID - UB1.
        /// </summary>
        public uint? SetIdUb1 { get; set; }

        /// <summary>
        /// UB1.2 - Blood Deductible.
        /// </summary>
        public decimal? BloodDeductible { get; set; }

        /// <summary>
        /// UB1.3 - Blood Furnished-Pints.
        /// </summary>
        public decimal? BloodFurnishedPints { get; set; }

        /// <summary>
        /// UB1.4 - Blood Replaced-Pints.
        /// </summary>
        public decimal? BloodReplacedPints { get; set; }

        /// <summary>
        /// UB1.5 - Blood Not Replaced-Pints.
        /// </summary>
        public decimal? BloodNotReplacedPints { get; set; }

        /// <summary>
        /// UB1.6 - Co-Insurance Days.
        /// </summary>
        public decimal? CoInsuranceDays { get; set; }

        /// <summary>
        /// UB1.7 - Condition Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0043</remarks>
        public IEnumerable<string> ConditionCode { get; set; }

        /// <summary>
        /// UB1.8 - Covered Days.
        /// </summary>
        public decimal? CoveredDays { get; set; }

        /// <summary>
        /// UB1.9 - Non Covered Days.
        /// </summary>
        public decimal? NonCoveredDays { get; set; }

        /// <summary>
        /// UB1.10 - Value Amount & Code.
        /// </summary>
        public IEnumerable<ValueCodeAndAmount> ValueAmountCode { get; set; }

        /// <summary>
        /// UB1.11 - Number Of Grace Days.
        /// </summary>
        public decimal? NumberOfGraceDays { get; set; }

        /// <summary>
        /// UB1.12 - Special Program Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0348</remarks>
        public CodedElement SpecialProgramIndicator { get; set; }

        /// <summary>
        /// UB1.13 - PSRO/UR Approval Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0349</remarks>
        public CodedElement PsroUrApprovalIndicator { get; set; }

        /// <summary>
        /// UB1.14 - PSRO/UR Approved Stay-Fm.
        /// </summary>
        public DateTime? PsroUrApprovedStayFm { get; set; }

        /// <summary>
        /// UB1.15 - PSRO/UR Approved Stay-To.
        /// </summary>
        public DateTime? PsroUrApprovedStayTo { get; set; }

        /// <summary>
        /// UB1.16 - Occurrence.
        /// </summary>
        public IEnumerable<OccurrenceCodeAndDate> Occurrence { get; set; }

        /// <summary>
        /// UB1.17 - Occurrence Span.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0351</remarks>
        public CodedElement OccurrenceSpan { get; set; }

        /// <summary>
        /// UB1.18 - Occur Span Start Date.
        /// </summary>
        public DateTime? OccurSpanStartDate { get; set; }

        /// <summary>
        /// UB1.19 - Occur Span End Date.
        /// </summary>
        public DateTime? OccurSpanEndDate { get; set; }

        /// <summary>
        /// UB1.20 - UB-82 Locator 2.
        /// </summary>
        public string Ub82Locator2 { get; set; }

        /// <summary>
        /// UB1.21 - UB-82 Locator 9.
        /// </summary>
        public string Ub82Locator9 { get; set; }

        /// <summary>
        /// UB1.22 - UB-82 Locator 27.
        /// </summary>
        public string Ub82Locator27 { get; set; }

        /// <summary>
        /// UB1.23 - UB-82 Locator 45.
        /// </summary>
        public string Ub82Locator45 { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 24, Configuration.FieldSeparator),
                                Id,
                                SetIdUb1.HasValue ? SetIdUb1.Value.ToString(culture) : null,
                                BloodDeductible.HasValue ? BloodDeductible.Value.ToString(Consts.NumericFormat, culture) : null,
                                BloodFurnishedPints.HasValue ? BloodFurnishedPints.Value.ToString(Consts.NumericFormat, culture) : null,
                                BloodReplacedPints.HasValue ? BloodReplacedPints.Value.ToString(Consts.NumericFormat, culture) : null,
                                BloodNotReplacedPints.HasValue ? BloodNotReplacedPints.Value.ToString(Consts.NumericFormat, culture) : null,
                                CoInsuranceDays.HasValue ? CoInsuranceDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                ConditionCode != null ? string.Join(Configuration.FieldRepeatSeparator, ConditionCode) : null,
                                CoveredDays.HasValue ? CoveredDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                NonCoveredDays.HasValue ? NonCoveredDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                ValueAmountCode != null ? string.Join(Configuration.FieldRepeatSeparator, ValueAmountCode.Select(x => x.ToDelimitedString())) : null,
                                NumberOfGraceDays.HasValue ? NumberOfGraceDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                SpecialProgramIndicator?.ToDelimitedString(),
                                PsroUrApprovalIndicator?.ToDelimitedString(),
                                PsroUrApprovedStayFm.HasValue ? PsroUrApprovedStayFm.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                PsroUrApprovedStayTo.HasValue ? PsroUrApprovedStayTo.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                Occurrence != null ? string.Join(Configuration.FieldRepeatSeparator, Occurrence.Select(x => x.ToDelimitedString())) : null,
                                OccurrenceSpan?.ToDelimitedString(),
                                OccurSpanStartDate.HasValue ? OccurSpanStartDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                OccurSpanEndDate.HasValue ? OccurSpanEndDate.Value.ToString(Consts.DateFormatPrecisionDay, culture) : null,
                                Ub82Locator2,
                                Ub82Locator9,
                                Ub82Locator27,
                                Ub82Locator45
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}