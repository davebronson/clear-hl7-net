using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment UB2 - Uniform Billing Data.
    /// </summary>
    public class Ub2Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "UB2";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// UB2.1 - Set ID - UB2.
        /// </summary>
        public uint? SetIdUb2 { get; set; }

        /// <summary>
        /// UB2.2 - Co-Insurance Days (9).
        /// </summary>
        public string CoInsuranceDays9 { get; set; }

        /// <summary>
        /// UB2.3 - Condition Code (24-30).
        /// <para>Suggested: 0043 Condition Code -&gt; ClearHl7.Codes.V280.CodeConditionCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ConditionCode24To30 { get; set; }

        /// <summary>
        /// UB2.4 - Covered Days (7).
        /// </summary>
        public string CoveredDays7 { get; set; }

        /// <summary>
        /// UB2.5 - Non-Covered Days (8).
        /// </summary>
        public string NonCoveredDays8 { get; set; }

        /// <summary>
        /// UB2.6 - Value Amount &amp; Code (39-41).
        /// </summary>
        public IEnumerable<ValueCodeAndAmount> ValueAmountCode39To41 { get; set; }

        /// <summary>
        /// UB2.7 - Occurrence Code &amp; Date (32-35).
        /// </summary>
        public IEnumerable<OccurrenceCodeAndDate> OccurrenceCodeDate32To35 { get; set; }

        /// <summary>
        /// UB2.8 - Occurrence Span Code/Dates (36).
        /// </summary>
        public IEnumerable<OccurrenceSpanCodeAndDate> OccurrenceSpanCodeDates36 { get; set; }

        /// <summary>
        /// UB2.9 - Uniform Billing Locator 2 (state).
        /// </summary>
        public IEnumerable<string> UniformBillingLocator2State { get; set; }

        /// <summary>
        /// UB2.10 - Uniform Billing Locator 11 (state).
        /// </summary>
        public IEnumerable<string> UniformBillingLocator11State { get; set; }

        /// <summary>
        /// UB2.11 - Uniform Billing Locator 31 (national).
        /// </summary>
        public string UniformBillingLocator31National { get; set; }

        /// <summary>
        /// UB2.12 - Document Control Number.
        /// </summary>
        public IEnumerable<string> DocumentControlNumber { get; set; }

        /// <summary>
        /// UB2.13 - Uniform Billing Locator 49 (national).
        /// </summary>
        public IEnumerable<string> UniformBillingLocator49National { get; set; }

        /// <summary>
        /// UB2.14 - Uniform Billing Locator 56 (state).
        /// </summary>
        public IEnumerable<string> UniformBillingLocator56State { get; set; }

        /// <summary>
        /// UB2.15 - Uniform Billing Locator 57 (sational).
        /// </summary>
        public string UniformBillingLocator57Sational { get; set; }

        /// <summary>
        /// UB2.16 - Uniform Billing Locator 78 (state).
        /// </summary>
        public IEnumerable<string> UniformBillingLocator78State { get; set; }

        /// <summary>
        /// UB2.17 - Special Visit Count.
        /// </summary>
        public decimal? SpecialVisitCount { get; set; }

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

            SetIdUb2 = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            CoInsuranceDays9 = segments.ElementAtOrDefault(2);
            ConditionCode24To30 = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            CoveredDays7 = segments.ElementAtOrDefault(4);
            NonCoveredDays8 = segments.ElementAtOrDefault(5);
            ValueAmountCode39To41 = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator).Select(x => TypeHelper.Deserialize<ValueCodeAndAmount>(x, false)) : null;
            OccurrenceCodeDate32To35 = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => TypeHelper.Deserialize<OccurrenceCodeAndDate>(x, false)) : null;
            OccurrenceSpanCodeDates36 = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator).Select(x => TypeHelper.Deserialize<OccurrenceSpanCodeAndDate>(x, false)) : null;
            UniformBillingLocator2State = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator) : null;
            UniformBillingLocator11State = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator) : null;
            UniformBillingLocator31National = segments.ElementAtOrDefault(11);
            DocumentControlNumber = segments.Length > 12 ? segments.ElementAtOrDefault(12).Split(separator) : null;
            UniformBillingLocator49National = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator) : null;
            UniformBillingLocator56State = segments.Length > 14 ? segments.ElementAtOrDefault(12).Split(separator) : null;
            UniformBillingLocator57Sational = segments.ElementAtOrDefault(15);
            UniformBillingLocator78State = segments.Length > 16 ? segments.ElementAtOrDefault(16).Split(separator) : null;
            SpecialVisitCount = segments.ElementAtOrDefault(17)?.ToNullableDecimal();
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
                                StringHelper.StringFormatSequence(0, 18, Configuration.FieldSeparator),
                                Id,
                                SetIdUb2.HasValue ? SetIdUb2.Value.ToString(culture) : null,
                                CoInsuranceDays9,
                                ConditionCode24To30 != null ? string.Join(Configuration.FieldRepeatSeparator, ConditionCode24To30.Select(x => x.ToDelimitedString())) : null,
                                CoveredDays7,
                                NonCoveredDays8,
                                ValueAmountCode39To41 != null ? string.Join(Configuration.FieldRepeatSeparator, ValueAmountCode39To41.Select(x => x.ToDelimitedString())) : null,
                                OccurrenceCodeDate32To35 != null ? string.Join(Configuration.FieldRepeatSeparator, OccurrenceCodeDate32To35.Select(x => x.ToDelimitedString())) : null,
                                OccurrenceSpanCodeDates36 != null ? string.Join(Configuration.FieldRepeatSeparator, OccurrenceSpanCodeDates36.Select(x => x.ToDelimitedString())) : null,
                                UniformBillingLocator2State != null ? string.Join(Configuration.FieldRepeatSeparator, UniformBillingLocator2State) : null,
                                UniformBillingLocator11State != null ? string.Join(Configuration.FieldRepeatSeparator, UniformBillingLocator11State) : null,
                                UniformBillingLocator31National,
                                DocumentControlNumber != null ? string.Join(Configuration.FieldRepeatSeparator, DocumentControlNumber) : null,
                                UniformBillingLocator49National != null ? string.Join(Configuration.FieldRepeatSeparator, UniformBillingLocator49National) : null,
                                UniformBillingLocator56State != null ? string.Join(Configuration.FieldRepeatSeparator, UniformBillingLocator56State) : null,
                                UniformBillingLocator57Sational,
                                UniformBillingLocator78State != null ? string.Join(Configuration.FieldRepeatSeparator, UniformBillingLocator78State) : null,
                                SpecialVisitCount.HasValue ? SpecialVisitCount.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}