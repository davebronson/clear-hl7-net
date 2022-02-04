using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DSP - Display Data.
    /// </summary>
    public class DspSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DspSegment"/> class.
        /// </summary>
        public DspSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DspSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public DspSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "DSP";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// DSP.1 - Set ID - DSP.
        /// </summary>
        public uint? SetIdDsp { get; set; }

        /// <summary>
        /// DSP.2 - Display Level.
        /// </summary>
        public uint? DisplayLevel { get; set; }

        /// <summary>
        /// DSP.3 - Data Line.
        /// </summary>
        public Text DataLine { get; set; }

        /// <summary>
        /// DSP.4 - Logical Break Point.
        /// </summary>
        public string LogicalBreakPoint { get; set; }

        /// <summary>
        /// DSP.5 - Result ID.
        /// </summary>
        public Text ResultId { get; set; }

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

            SetIdDsp = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            DisplayLevel = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableUInt() : null;
            DataLine = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[3], false, seps) : null;
            LogicalBreakPoint = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            ResultId = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[5], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                SetIdDsp.HasValue ? SetIdDsp.Value.ToString(culture) : null,
                                DisplayLevel.HasValue ? DisplayLevel.Value.ToString(culture) : null,
                                DataLine?.ToDelimitedString(),
                                LogicalBreakPoint,
                                ResultId?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
