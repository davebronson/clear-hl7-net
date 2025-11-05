using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment NCK - System Clock.
    /// </summary>
    public class NckSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NckSegment"/> class.
        /// </summary>
        public NckSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NckSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public NckSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "NCK";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// NCK.1 - System Date/Time.
        /// </summary>
        public DateTime? SystemDateTime { get; set; }

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

            SystemDateTime = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, Configuration.FieldSeparator),
                                Id,
                                SystemDateTime?.ToHl7DateTimeString(typeof(NckSegment), nameof(SystemDateTime), Consts.DateTimeFormatPrecisionSecond, culture)
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
