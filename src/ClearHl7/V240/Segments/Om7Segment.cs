using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM7 - Additional Basic Attributes.
    /// </summary>
    public class Om7Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OM7";

        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OM7.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OM7.2 - Universal Service Identifier.
        /// </summary>
        public CodedElement UniversalServiceIdentifier { get; set; }

        /// <summary>
        /// OM7.3 - Category Identifier.
        /// <para>Suggested: 0412 Category Identifier</para>
        /// </summary>
        public IEnumerable<CodedElement> CategoryIdentifier { get; set; }

        /// <summary>
        /// OM7.4 - Category Description.
        /// </summary>
        public Text CategoryDescription { get; set; }

        /// <summary>
        /// OM7.5 - Category Synonym.
        /// </summary>
        public IEnumerable<string> CategorySynonym { get; set; }

        /// <summary>
        /// OM7.6 - Effective Test/Service Start Date/Time.
        /// </summary>
        public DateTime? EffectiveTestServiceStartDateTime { get; set; }

        /// <summary>
        /// OM7.7 - Effective Test/Service End Date/Time.
        /// </summary>
        public DateTime? EffectiveTestServiceEndDateTime { get; set; }

        /// <summary>
        /// OM7.8 - Test/Service Default Duration Quantity.
        /// </summary>
        public decimal? TestServiceDefaultDurationQuantity { get; set; }

        /// <summary>
        /// OM7.9 - Test/Service Default Duration Units.
        /// </summary>
        public CodedElement TestServiceDefaultDurationUnits { get; set; }

        /// <summary>
        /// OM7.10 - Test/Service Default Frequency.
        /// <para>Suggested: 0335 Repeat Pattern -&gt; ClearHl7.Codes.V240.CodeRepeatPattern</para>
        /// </summary>
        public string TestServiceDefaultFrequency { get; set; }

        /// <summary>
        /// OM7.11 - Consent Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V240.CodeYesNoIndicator</para>
        /// </summary>
        public string ConsentIndicator { get; set; }

        /// <summary>
        /// OM7.12 - Consent Identifier.
        /// <para>Suggested: 0413 Consent Identifier</para>
        /// </summary>
        public CodedElement ConsentIdentifier { get; set; }

        /// <summary>
        /// OM7.13 - Consent Effective Start Date/Time.
        /// </summary>
        public DateTime? ConsentEffectiveStartDateTime { get; set; }

        /// <summary>
        /// OM7.14 - Consent Effective End Date/Time.
        /// </summary>
        public DateTime? ConsentEffectiveEndDateTime { get; set; }

        /// <summary>
        /// OM7.15 - Consent Interval Quantity.
        /// </summary>
        public decimal? ConsentIntervalQuantity { get; set; }

        /// <summary>
        /// OM7.16 - Consent Interval Units.
        /// <para>Suggested: 0414 Units Of Time</para>
        /// </summary>
        public CodedElement ConsentIntervalUnits { get; set; }

        /// <summary>
        /// OM7.17 - Consent Waiting Period Quantity.
        /// </summary>
        public decimal? ConsentWaitingPeriodQuantity { get; set; }

        /// <summary>
        /// OM7.18 - Consent Waiting Period Units.
        /// <para>Suggested: 0414 Units Of Time</para>
        /// </summary>
        public CodedElement ConsentWaitingPeriodUnits { get; set; }

        /// <summary>
        /// OM7.19 - Effective Date/Time of Change.
        /// </summary>
        public DateTime? EffectiveDateTimeOfChange { get; set; }

        /// <summary>
        /// OM7.20 - Entered By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons EnteredBy { get; set; }

        /// <summary>
        /// OM7.21 - Orderable-at Location.
        /// </summary>
        public IEnumerable<PersonLocation> OrderableAtLocation { get; set; }

        /// <summary>
        /// OM7.22 - Formulary Status.
        /// </summary>
        public string FormularyStatus { get; set; }

        /// <summary>
        /// OM7.23 - Special Order Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V240.CodeYesNoIndicator</para>
        /// </summary>
        public string SpecialOrderIndicator { get; set; }

        /// <summary>
        /// OM7.24 - Primary Key Value - CDM.
        /// <para>Suggested: 0132 Transaction Code</para>
        /// </summary>
        public IEnumerable<CodedElement> PrimaryKeyValueCdm { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 25, Configuration.FieldSeparator),
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                UniversalServiceIdentifier?.ToDelimitedString(),
                                CategoryIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, CategoryIdentifier.Select(x => x.ToDelimitedString())) : null,
                                CategoryDescription?.ToDelimitedString(),
                                CategorySynonym != null ? string.Join(Configuration.FieldRepeatSeparator, CategorySynonym) : null,
                                EffectiveTestServiceStartDateTime.HasValue ? EffectiveTestServiceStartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EffectiveTestServiceEndDateTime.HasValue ? EffectiveTestServiceEndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                TestServiceDefaultDurationQuantity.HasValue ? TestServiceDefaultDurationQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                TestServiceDefaultDurationUnits?.ToDelimitedString(),
                                TestServiceDefaultFrequency,
                                ConsentIndicator,
                                ConsentIdentifier?.ToDelimitedString(),
                                ConsentEffectiveStartDateTime.HasValue ? ConsentEffectiveStartDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ConsentEffectiveEndDateTime.HasValue ? ConsentEffectiveEndDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ConsentIntervalQuantity.HasValue ? ConsentIntervalQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                ConsentIntervalUnits?.ToDelimitedString(),
                                ConsentWaitingPeriodQuantity.HasValue ? ConsentWaitingPeriodQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                ConsentWaitingPeriodUnits?.ToDelimitedString(),
                                EffectiveDateTimeOfChange.HasValue ? EffectiveDateTimeOfChange.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                EnteredBy?.ToDelimitedString(),
                                OrderableAtLocation != null ? string.Join(Configuration.FieldRepeatSeparator, OrderableAtLocation.Select(x => x.ToDelimitedString())) : null,
                                FormularyStatus,
                                SpecialOrderIndicator,
                                PrimaryKeyValueCdm != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryKeyValueCdm.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
