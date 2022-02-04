using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NPU - Bed Status Update.
    /// </summary>
    public class NpuSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NpuSegment"/> class.
        /// </summary>
        public NpuSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NpuSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public NpuSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "NPU";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// NPU.1 - Bed Location.
        /// </summary>
        public PersonLocation BedLocation { get; set; }

        /// <summary>
        /// NPU.2 - Bed Status.
        /// <para>Suggested: 0116 Bed Status -&gt; ClearHl7.Codes.V282.CodeBedStatus</para>
        /// </summary>
        public CodedWithExceptions BedStatus { get; set; }

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

            BedLocation = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[1], false, seps) : null;
            BedStatus = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, Configuration.FieldSeparator),
                                Id,
                                BedLocation?.ToDelimitedString(),
                                BedStatus?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
