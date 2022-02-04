using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM3 - Categorical Service Test Observation.
    /// </summary>
    public class Om3Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Om3Segment"/> class.
        /// </summary>
        public Om3Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Om3Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Om3Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "OM3";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// OM3.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OM3.2 - Preferred Coding System.
        /// </summary>
        public CodedWithExceptions PreferredCodingSystem { get; set; }

        /// <summary>
        /// OM3.3 - Valid Coded "Answers".
        /// </summary>
        public IEnumerable<CodedWithExceptions> ValidCodedAnswers { get; set; }

        /// <summary>
        /// OM3.4 - Normal Text/Codes for Categorical Observations.
        /// </summary>
        public IEnumerable<CodedWithExceptions> NormalTextCodesForCategoricalObservations { get; set; }

        /// <summary>
        /// OM3.5 - Abnormal Text/Codes for Categorical Observations.
        /// </summary>
        public IEnumerable<CodedWithExceptions> AbnormalTextCodesForCategoricalObservations { get; set; }

        /// <summary>
        /// OM3.6 - Critical Text/Codes for Categorical Observations.
        /// </summary>
        public IEnumerable<CodedWithExceptions> CriticalTextCodesForCategoricalObservations { get; set; }

        /// <summary>
        /// OM3.7 - Value Type.
        /// <para>Suggested: 0125 Value Type -&gt; ClearHl7.Codes.V282.CodeValueType</para>
        /// </summary>
        public string ValueType { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SequenceNumberTestObservationMasterFile = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            PreferredCodingSystem = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            ValidCodedAnswers = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            NormalTextCodesForCategoricalObservations = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            AbnormalTextCodesForCategoricalObservations = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            CriticalTextCodesForCategoricalObservations = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ValueType = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                SequenceNumberTestObservationMasterFile.HasValue ? SequenceNumberTestObservationMasterFile.Value.ToString(Consts.NumericFormat, culture) : null,
                                PreferredCodingSystem?.ToDelimitedString(),
                                ValidCodedAnswers != null ? string.Join(Configuration.FieldRepeatSeparator, ValidCodedAnswers.Select(x => x.ToDelimitedString())) : null,
                                NormalTextCodesForCategoricalObservations != null ? string.Join(Configuration.FieldRepeatSeparator, NormalTextCodesForCategoricalObservations.Select(x => x.ToDelimitedString())) : null,
                                AbnormalTextCodesForCategoricalObservations != null ? string.Join(Configuration.FieldRepeatSeparator, AbnormalTextCodesForCategoricalObservations.Select(x => x.ToDelimitedString())) : null,
                                CriticalTextCodesForCategoricalObservations != null ? string.Join(Configuration.FieldRepeatSeparator, CriticalTextCodesForCategoricalObservations.Select(x => x.ToDelimitedString())) : null,
                                ValueType
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
