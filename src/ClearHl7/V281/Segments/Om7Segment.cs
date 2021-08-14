using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
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
        public CodedWithExceptions UniversalServiceIdentifier { get; set; }

        /// <summary>
        /// OM7.3 - Category Identifier.
        /// <para>Suggested: 0412 Category Identifier</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> CategoryIdentifier { get; set; }

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
        public CodedWithExceptions TestServiceDefaultDurationUnits { get; set; }

        /// <summary>
        /// OM7.10 - Test/Service Default Frequency.
        /// </summary>
        public CodedWithExceptions TestServiceDefaultFrequency { get; set; }

        /// <summary>
        /// OM7.11 - Consent Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string ConsentIndicator { get; set; }

        /// <summary>
        /// OM7.12 - Consent Identifier.
        /// <para>Suggested: 0413 Consent Identifier</para>
        /// </summary>
        public CodedWithExceptions ConsentIdentifier { get; set; }

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
        public CodedWithExceptions ConsentIntervalUnits { get; set; }

        /// <summary>
        /// OM7.17 - Consent Waiting Period Quantity.
        /// </summary>
        public decimal? ConsentWaitingPeriodQuantity { get; set; }

        /// <summary>
        /// OM7.18 - Consent Waiting Period Units.
        /// <para>Suggested: 0414 Units Of Time</para>
        /// </summary>
        public CodedWithExceptions ConsentWaitingPeriodUnits { get; set; }

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
        /// <para>Suggested: 0473 Formulary Status -&gt; ClearHl7.Codes.V281.CodeFormularyStatus</para>
        /// </summary>
        public CodedWithExceptions FormularyStatus { get; set; }

        /// <summary>
        /// OM7.23 - Special Order Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
        /// </summary>
        public string SpecialOrderIndicator { get; set; }

        /// <summary>
        /// OM7.24 - Primary Key Value - CDM.
        /// </summary>
        public IEnumerable<CodedWithExceptions> PrimaryKeyValueCdm { get; set; }

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

            SequenceNumberTestObservationMasterFile = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            UniversalServiceIdentifier = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            CategoryIdentifier = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            CategoryDescription = segments.Length > 4 ? TypeHelper.Deserialize<Text>(segments.ElementAtOrDefault(4), false) : null;
            CategorySynonym = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator) : null;
            EffectiveTestServiceStartDateTime = segments.ElementAtOrDefault(6)?.ToNullableDateTime();
            EffectiveTestServiceEndDateTime = segments.ElementAtOrDefault(7)?.ToNullableDateTime();
            TestServiceDefaultDurationQuantity = segments.ElementAtOrDefault(8)?.ToNullableDecimal();
            TestServiceDefaultDurationUnits = segments.Length > 9 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(9), false) : null;
            TestServiceDefaultFrequency = segments.Length > 10 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(10), false) : null;
            ConsentIndicator = segments.ElementAtOrDefault(11);
            ConsentIdentifier = segments.Length > 12 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(12), false) : null;
            ConsentEffectiveStartDateTime = segments.ElementAtOrDefault(13)?.ToNullableDateTime();
            ConsentEffectiveEndDateTime = segments.ElementAtOrDefault(14)?.ToNullableDateTime();
            ConsentIntervalQuantity = segments.ElementAtOrDefault(15)?.ToNullableDecimal();
            ConsentIntervalUnits = segments.Length > 16 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(16), false) : null;
            ConsentWaitingPeriodQuantity = segments.ElementAtOrDefault(17)?.ToNullableDecimal();
            ConsentWaitingPeriodUnits = segments.Length > 18 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(18), false) : null;
            EffectiveDateTimeOfChange = segments.ElementAtOrDefault(19)?.ToNullableDateTime();
            EnteredBy = segments.Length > 20 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(20), false) : null;
            OrderableAtLocation = segments.Length > 21 ? segments.ElementAtOrDefault(21).Split(separator).Select(x => TypeHelper.Deserialize<PersonLocation>(x, false)) : null;
            FormularyStatus = segments.Length > 22 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(22), false) : null;
            SpecialOrderIndicator = segments.ElementAtOrDefault(23);
            PrimaryKeyValueCdm = segments.Length > 24 ? segments.ElementAtOrDefault(24).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
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
                                TestServiceDefaultFrequency?.ToDelimitedString(),
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
                                FormularyStatus?.ToDelimitedString(),
                                SpecialOrderIndicator,
                                PrimaryKeyValueCdm != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryKeyValueCdm.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
