using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment QAK - Query Acknowledgment.
    /// </summary>
    public class QakSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "QAK";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// QAK.1 - Query Tag.
        /// </summary>
        public string QueryTag { get; set; }

        /// <summary>
        /// QAK.2 - Query Response Status.
        /// <para>Suggested: 0208 Query Response Status -&gt; ClearHl7.Codes.V230.CodeQueryResponseStatus</para>
        /// </summary>
        public string QueryResponseStatus { get; set; }

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

            QueryTag = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            QueryResponseStatus = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, Configuration.FieldSeparator),
                                Id,
                                QueryTag,
                                QueryResponseStatus
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
