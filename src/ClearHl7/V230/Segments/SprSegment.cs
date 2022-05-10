using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SPR - Stored Procedure Request Definition.
    /// </summary>
    public class SprSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SprSegment"/> class.
        /// </summary>
        public SprSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SprSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public SprSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "SPR";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// SPR.1 - Query Tag.
        /// </summary>
        public string QueryTag { get; set; }

        /// <summary>
        /// SPR.2 - Query/Response Format Code.
        /// <para>Suggested: 0106 Query/Response Format Code -&gt; ClearHl7.Codes.V230.CodeQueryResponseFormatCode</para>
        /// </summary>
        public string QueryResponseFormatCode { get; set; }

        /// <summary>
        /// SPR.3 - Stored Procedure Name.
        /// </summary>
        public CodedElement StoredProcedureName { get; set; }

        /// <summary>
        /// SPR.4 - Input Parameter List.
        /// </summary>
        public IEnumerable<QueryInputParameterList> InputParameterList { get; set; }

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

            QueryTag = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            QueryResponseFormatCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            StoredProcedureName = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[3], false, seps) : null;
            InputParameterList = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<QueryInputParameterList>(x, false, seps)) : null;
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
                                StoredProcedureName?.ToDelimitedString(),
                                InputParameterList != null ? string.Join(Configuration.FieldRepeatSeparator, InputParameterList.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
