using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment EQL - Embedded Query Language.
    /// </summary>
    public class EqlSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "EQL";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// EQL.1 - Query Tag.
        /// </summary>
        public string QueryTag { get; set; }

        /// <summary>
        /// EQL.2 - Query/Response Format Code.
        /// <para>Suggested: 0106 Query/Response Format Code -&gt; ClearHl7.Codes.V251.CodeQueryResponseFormatCode</para>
        /// </summary>
        public string QueryResponseFormatCode { get; set; }

        /// <summary>
        /// EQL.3 - EQL Query Name.
        /// </summary>
        public CodedElement EqlQueryName { get; set; }

        /// <summary>
        /// EQL.4 - EQL Query Statement.
        /// </summary>
        public string EqlQueryStatement { get; set; }

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
            QueryResponseFormatCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            EqlQueryName = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], false, seps) : null;
            EqlQueryStatement = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                QueryTag,
                                QueryResponseFormatCode,
                                EqlQueryName?.ToDelimitedString(),
                                EqlQueryStatement
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
