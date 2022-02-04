using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment LCH - Location Characteristic.
    /// </summary>
    public class LchSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LchSegment"/> class.
        /// </summary>
        public LchSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LchSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public LchSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id { get; } = "LCH";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// LCH.1 - Primary Key Value - LCH.
        /// </summary>
        public PersonLocation PrimaryKeyValueLch { get; set; }

        /// <summary>
        /// LCH.2 - Segment Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V260.CodeSegmentActionCode</para>
        /// </summary>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// LCH.3 - Segment Unique Key.
        /// </summary>
        public EntityIdentifier SegmentUniqueKey { get; set; }

        /// <summary>
        /// LCH.4 - Location Characteristic ID.
        /// <para>Suggested: 0324 Location Characteristic ID -&gt; ClearHl7.Codes.V260.CodeLocationCharacteristicId</para>
        /// </summary>
        public CodedWithExceptions LocationCharacteristicId { get; set; }

        /// <summary>
        /// LCH.5 - Location Characteristic Value - LCH.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V260.CodeYesNoIndicator</para>
        /// </summary>
        public CodedWithExceptions LocationCharacteristicValueLch { get; set; }

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

            PrimaryKeyValueLch = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[1], false, seps) : null;
            SegmentActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            SegmentUniqueKey = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[3], false, seps) : null;
            LocationCharacteristicId = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            LocationCharacteristicValueLch = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                PrimaryKeyValueLch?.ToDelimitedString(),
                                SegmentActionCode,
                                SegmentUniqueKey?.ToDelimitedString(),
                                LocationCharacteristicId?.ToDelimitedString(),
                                LocationCharacteristicValueLch?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
