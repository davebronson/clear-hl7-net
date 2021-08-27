﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
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
        /// <para>Suggested: 0043 Condition Code</para>
        /// </summary>
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
        /// UB1.10 - Value Amount &amp; Code.
        /// </summary>
        public IEnumerable<ValueCodeAndAmount> ValueAmountCode { get; set; }

        /// <summary>
        /// UB1.11 - Number Of Grace Days.
        /// </summary>
        public decimal? NumberOfGraceDays { get; set; }

        /// <summary>
        /// UB1.12 - Special Program Indicator.
        /// <para>Suggested: 0348 Special Program Indicator</para>
        /// </summary>
        public CodedElement SpecialProgramIndicator { get; set; }

        /// <summary>
        /// UB1.13 - PSRO/UR Approval Indicator.
        /// <para>Suggested: 0349 PSRO/UR Approval Indicator</para>
        /// </summary>
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
        /// <para>Suggested: 0351 Occurrence Span</para>
        /// </summary>
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
        public void FromDelimitedString(string delimitedString, Separators separators)
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

            SetIdUb1 = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            BloodDeductible = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            BloodFurnishedPints = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            BloodReplacedPints = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            BloodNotReplacedPints = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            CoInsuranceDays = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            ConditionCode = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            CoveredDays = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            NonCoveredDays = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDecimal() : null;
            ValueAmountCode = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<ValueCodeAndAmount>(x, false, seps)) : null;
            NumberOfGraceDays = segments.Length > 11 && segments[11].Length > 0 ? segments[11].ToNullableDecimal() : null;
            SpecialProgramIndicator = segments.Length > 12 && segments[12].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[12], false, seps) : null;
            PsroUrApprovalIndicator = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[13], false, seps) : null;
            PsroUrApprovedStayFm = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            PsroUrApprovedStayTo = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDateTime() : null;
            Occurrence = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<OccurrenceCodeAndDate>(x, false, seps)) : null;
            OccurrenceSpan = segments.Length > 17 && segments[17].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[17], false, seps) : null;
            OccurSpanStartDate = segments.Length > 18 && segments[18].Length > 0 ? segments[18].ToNullableDateTime() : null;
            OccurSpanEndDate = segments.Length > 19 && segments[19].Length > 0 ? segments[19].ToNullableDateTime() : null;
            Ub82Locator2 = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            Ub82Locator9 = segments.Length > 21 && segments[21].Length > 0 ? segments[21] : null;
            Ub82Locator27 = segments.Length > 22 && segments[22].Length > 0 ? segments[22] : null;
            Ub82Locator45 = segments.Length > 23 && segments[23].Length > 0 ? segments[23] : null;
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
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}