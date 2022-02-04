using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RDT - Table Row Data.
    /// </summary>
    public class RdtSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RdtSegment"/> class.
        /// </summary>
        public RdtSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RdtSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public RdtSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "RDT";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// RDT.1 - Column Value.
        /// </summary>
        public string ColumnValue { get; set; }

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

            ColumnValue = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, Configuration.FieldSeparator),
                                Id,
                                ColumnValue
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
