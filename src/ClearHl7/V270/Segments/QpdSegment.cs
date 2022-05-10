using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment QPD - Query Parameter Definition.
    /// </summary>
    public class QpdSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QpdSegment"/> class.
        /// </summary>
        public QpdSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QpdSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public QpdSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "QPD";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// QPD.1 - Message Query Name.
        /// <para>Suggested: 0471 Query Name</para>
        /// </summary>
        public CodedWithExceptions MessageQueryName { get; set; }

        /// <summary>
        /// QPD.2 - Query Tag.
        /// </summary>
        public string QueryTag { get; set; }

        /// <summary>
        /// QPD.3 - User Parameters (in successive fields).
        /// </summary>
        public string UserParametersInSuccessiveFields { get; set; }

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

            MessageQueryName = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            QueryTag = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            UserParametersInSuccessiveFields = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                MessageQueryName?.ToDelimitedString(),
                                QueryTag,
                                UserParametersInSuccessiveFields
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
