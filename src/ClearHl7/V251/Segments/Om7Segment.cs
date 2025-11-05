using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM7 - Additional Basic Attributes.
    /// </summary>
    public class Om7Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Om7Segment"/> class.
        /// </summary>
        public Om7Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Om7Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Om7Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "OM7";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0335 Repeat Pattern -&gt; ClearHl7.Codes.V251.CodeRepeatPattern</para>
        /// </summary>
        public string TestServiceDefaultFrequency { get; set; }

        /// <summary>
        /// OM7.11 - Consent Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0473 Formulary Status -&gt; ClearHl7.Codes.V251.CodeFormularyStatus</para>
        /// </summary>
        public string FormularyStatus { get; set; }

        /// <summary>
        /// OM7.23 - Special Order Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
        /// </summary>
        public string SpecialOrderIndicator { get; set; }

        /// <summary>
        /// OM7.24 - Primary Key Value - CDM.
        /// <para>Suggested: 0132 Transaction Code</para>
        /// </summary>
        public IEnumerable<CodedElement> PrimaryKeyValueCdm { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SequenceNumberTestObservationMasterFile = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            UniversalServiceIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[2], false, seps) : null;
            CategoryIdentifier = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            CategoryDescription = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[4], false, seps) : null;
            CategorySynonym = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            EffectiveTestServiceStartDateTime = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            EffectiveTestServiceEndDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            TestServiceDefaultDurationQuantity = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            TestServiceDefaultDurationUnits = segments.Length > 9 && segments[9].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[9], false, seps) : null;
            TestServiceDefaultFrequency = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            ConsentIndicator = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            ConsentIdentifier = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[12], false, seps) : null;
            ConsentEffectiveStartDateTime = segments.Length > 13 && segments[13].Length > 0 ? segments[13].ToNullableDateTime() : null;
            ConsentEffectiveEndDateTime = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            ConsentIntervalQuantity = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDecimal() : null;
            ConsentIntervalUnits = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[16], false, seps) : null;
            ConsentWaitingPeriodQuantity = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDecimal() : null;
            ConsentWaitingPeriodUnits = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[18], false, seps) : null;
            EffectiveDateTimeOfChange = segments.Length > 19 && segments[19].Length > 0 ? segments[19].ToNullableDateTime() : null;
            EnteredBy = segments.Length > 20 && segments[20].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[20], false, seps) : null;
            OrderableAtLocation = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<PersonLocation>(x, false, seps)) : null;
            FormularyStatus = segments.Length > 22 && segments[22].Length > 0 ? segments[22] : null;
            SpecialOrderIndicator = segments.Length > 23 && segments[23].Length > 0 ? segments[23] : null;
            PrimaryKeyValueCdm = segments.Length > 24 && segments[24].Length > 0 ? segments[24].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
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
                                EffectiveTestServiceStartDateTime?.ToHl7DateTimeString(typeof(Om7Segment), nameof(EffectiveTestServiceStartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                EffectiveTestServiceEndDateTime?.ToHl7DateTimeString(typeof(Om7Segment), nameof(EffectiveTestServiceEndDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                TestServiceDefaultDurationQuantity.HasValue ? TestServiceDefaultDurationQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                TestServiceDefaultDurationUnits?.ToDelimitedString(),
                                TestServiceDefaultFrequency,
                                ConsentIndicator,
                                ConsentIdentifier?.ToDelimitedString(),
                                ConsentEffectiveStartDateTime?.ToHl7DateTimeString(typeof(Om7Segment), nameof(ConsentEffectiveStartDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ConsentEffectiveEndDateTime?.ToHl7DateTimeString(typeof(Om7Segment), nameof(ConsentEffectiveEndDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                ConsentIntervalQuantity.HasValue ? ConsentIntervalQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                ConsentIntervalUnits?.ToDelimitedString(),
                                ConsentWaitingPeriodQuantity.HasValue ? ConsentWaitingPeriodQuantity.Value.ToString(Consts.NumericFormat, culture) : null,
                                ConsentWaitingPeriodUnits?.ToDelimitedString(),
                                EffectiveDateTimeOfChange?.ToHl7DateTimeString(typeof(Om7Segment), nameof(EffectiveDateTimeOfChange), Consts.DateTimeFormatPrecisionSecond, culture),
                                EnteredBy?.ToDelimitedString(),
                                OrderableAtLocation != null ? string.Join(Configuration.FieldRepeatSeparator, OrderableAtLocation.Select(x => x.ToDelimitedString())) : null,
                                FormularyStatus,
                                SpecialOrderIndicator,
                                PrimaryKeyValueCdm != null ? string.Join(Configuration.FieldRepeatSeparator, PrimaryKeyValueCdm.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
