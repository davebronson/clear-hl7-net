using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment VTQ - Virtual Table Query Request.
    /// </summary>
    public class VtqSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "VTQ";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// VTQ.1 - Query Tag.
        /// </summary>
        public string QueryTag { get; set; }

        /// <summary>
        /// VTQ.2 - Query/Response Format Code.
        /// <para>Suggested: 0106 Query/Response Format Code -&gt; ClearHl7.Codes.V251.CodeQueryResponseFormatCode</para>
        /// </summary>
        public string QueryResponseFormatCode { get; set; }

        /// <summary>
        /// VTQ.3 - VT Query Name.
        /// </summary>
        public CodedElement VtQueryName { get; set; }

        /// <summary>
        /// VTQ.4 - Virtual Table Name.
        /// </summary>
        public CodedElement VirtualTableName { get; set; }

        /// <summary>
        /// VTQ.5 - Selection Criteria.
        /// </summary>
        public QuerySelectionCriteria SelectionCriteria { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public VtqSegment FromDelimitedString(string delimitedString)
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
            VtQueryName = segments.Length > 3 ? new CodedElement().FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            VirtualTableName = segments.Length > 4 ? new CodedElement().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            SelectionCriteria = segments.Length > 5 ? new QuerySelectionCriteria().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            
            return this;
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
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                QueryTag,
                                QueryResponseFormatCode,
                                VtQueryName?.ToDelimitedString(),
                                VirtualTableName?.ToDelimitedString(),
                                SelectionCriteria?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}