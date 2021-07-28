using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment EQL - Embedded Query Language.
    /// </summary>
    public class EqlSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "EQL";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// EQL.1 - Query Tag.
        /// </summary>
        public string QueryTag { get; set; }

        /// <summary>
        /// EQL.2 - Query/Response Format Code.
        /// <para>Suggested: 0106 Query/Response Format Code -&gt; ClearHl7.Codes.V230.CodeQueryResponseFormatCode</para>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            QueryTag = segments.ElementAtOrDefault(1);
            QueryResponseFormatCode = segments.ElementAtOrDefault(2);
            EqlQueryName = segments.Length > 3 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(3), false) : null;
            EqlQueryStatement = segments.ElementAtOrDefault(4);
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