using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// UB2.1 - Set ID - UB2.
        ///// </summary>
        //public SetIdUb2 { get; set; }

        ///// <summary>
        ///// UB2.2 - Co-Insurance Days (9).
        ///// </summary>
        //public CoInsuranceDays9 { get; set; }

        ///// <summary>
        ///// UB2.3 - Condition Code (24-30).
        ///// </summary>
        //public ConditionCode2430 { get; set; }

        ///// <summary>
        ///// UB2.4 - Covered Days (7).
        ///// </summary>
        //public CoveredDays7 { get; set; }

        ///// <summary>
        ///// UB2.5 - Non-Covered Days (8).
        ///// </summary>
        //public NonCoveredDays8 { get; set; }

        ///// <summary>
        ///// UB2.6 - Value Amount & Code (39-41).
        ///// </summary>
        //public ValueAmountCode3941 { get; set; }

        ///// <summary>
        ///// UB2.7 - Occurrence Code & Date (32-35).
        ///// </summary>
        //public OccurrenceCodeDate3235 { get; set; }

        ///// <summary>
        ///// UB2.8 - Occurrence Span Code/Dates (36).
        ///// </summary>
        //public OccurrenceSpanCodeDates36 { get; set; }

        ///// <summary>
        ///// UB2.9 - Uniform Billing Locator 2 (state).
        ///// </summary>
        //public UniformBillingLocator2State { get; set; }

        ///// <summary>
        ///// UB2.10 - Uniform Billing Locator 11 (state).
        ///// </summary>
        //public UniformBillingLocator11State { get; set; }

        ///// <summary>
        ///// UB2.11 - Uniform Billing Locator 31 (national).
        ///// </summary>
        //public UniformBillingLocator31National { get; set; }

        ///// <summary>
        ///// UB2.12 - Document Control Number.
        ///// </summary>
        //public DocumentControlNumber { get; set; }

        ///// <summary>
        ///// UB2.13 - Uniform Billing Locator 49 (national).
        ///// </summary>
        //public UniformBillingLocator49National { get; set; }

        ///// <summary>
        ///// UB2.14 - Uniform Billing Locator 56 (state).
        ///// </summary>
        //public UniformBillingLocator56State { get; set; }

        ///// <summary>
        ///// UB2.15 - Uniform Billing Locator 57 (sational).
        ///// </summary>
        //public UniformBillingLocator57Sational { get; set; }

        ///// <summary>
        ///// UB2.16 - Uniform Billing Locator 78 (state).
        ///// </summary>
        //public UniformBillingLocator78State { get; set; }

        ///// <summary>
        ///// UB2.17 - Special Visit Count.
        ///// </summary>
        //public SpecialVisitCount { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}"
                                ).TrimEnd('|');
        }
    }
}