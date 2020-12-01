using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V231.Types;

namespace ClearHl7.Fhir.V231.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0043</remarks>
        public IEnumerable<string> ConditionCode2430 { get; set; }

        /// <summary>
        /// UB2.4 - Covered Days (7).
        /// </summary>
        public string CoveredDays7 { get; set; }

        /// <summary>
        /// UB2.5 - Non-Covered Days (8).
        /// </summary>
        public string NonCoveredDays8 { get; set; }

        /// <summary>
        /// UB2.6 - Value Amount & Code (39-41).
        /// </summary>
        public IEnumerable<ValueCodeAndAmount> ValueAmountCode3941 { get; set; }

        /// <summary>
        /// UB2.7 - Occurrence Code & Date (32-35).
        /// </summary>
        public IEnumerable<OccurrenceCodeAndDate> OccurrenceCodeDate3235 { get; set; }

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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 18, Configuration.FieldSeparator),
                                Id,
                                SetIdUb2.HasValue ? SetIdUb2.Value.ToString(culture) : null,
                                CoInsuranceDays9,
                                ConditionCode2430 != null ? string.Join(Configuration.FieldRepeatSeparator, ConditionCode2430) : null,
                                CoveredDays7,
                                NonCoveredDays8,
                                ValueAmountCode3941 != null ? string.Join(Configuration.FieldRepeatSeparator, ValueAmountCode3941.Select(x => x.ToDelimitedString())) : null,
                                OccurrenceCodeDate3235 != null ? string.Join(Configuration.FieldRepeatSeparator, OccurrenceCodeDate3235.Select(x => x.ToDelimitedString())) : null,
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
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}