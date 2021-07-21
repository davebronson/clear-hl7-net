using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OM3 - Categorical Service Test Observation.
    /// </summary>
    public class Om3Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OM3";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OM3.1 - Sequence Number - Test/Observation Master File.
        /// </summary>
        public decimal? SequenceNumberTestObservationMasterFile { get; set; }

        /// <summary>
        /// OM3.2 - Preferred Coding System.
        /// <para>Suggested: 0650 Preferred Coding System</para>
        /// </summary>
        public CodedWithExceptions PreferredCodingSystem { get; set; }

        /// <summary>
        /// OM3.3 - Valid Coded "Answers".
        /// <para>Suggested: 0652 Valid Coded "Answers"</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ValidCodedAnswers { get; set; }

        /// <summary>
        /// OM3.4 - Normal Text/Codes for Categorical Observations.
        /// <para>Suggested: 0654 Normal Text/Codes for Categorical Observations</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> NormalTextCodesForCategoricalObservations { get; set; }

        /// <summary>
        /// OM3.5 - Abnormal Text/Codes for Categorical Observations.
        /// <para>Suggested: 0655 Abnormal Text/Codes for Categorical Observations</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> AbnormalTextCodesForCategoricalObservations { get; set; }

        /// <summary>
        /// OM3.6 - Critical Text/Codes for Categorical Observations.
        /// <para>Suggested: 0656 Critical Text/Codes for Categorical Observations</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> CriticalTextCodesForCategoricalObservations { get; set; }

        /// <summary>
        /// OM3.7 - Value Type.
        /// <para>Suggested: 0125 Value Type -&gt; ClearHl7.Codes.V290.CodeValueType</para>
        /// </summary>
        public string ValueType { get; set; }

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
            PreferredCodingSystem = segments.Length > 2 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(2), false) : null;
            ValidCodedAnswers = segments.Length > 3 ? segments.ElementAtOrDefault(3).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            NormalTextCodesForCategoricalObservations = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            AbnormalTextCodesForCategoricalObservations = segments.Length > 5 ? segments.ElementAtOrDefault(5).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            CriticalTextCodesForCategoricalObservations = segments.Length > 6 ? segments.ElementAtOrDefault(6).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            ValueType = segments.ElementAtOrDefault(7);
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