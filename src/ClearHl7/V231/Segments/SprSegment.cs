﻿using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SPR - Stored Procedure Request Definition.
    /// </summary>
    public class SprSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SPR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// SPR.1 - Query Tag.
        /// </summary>
        public string QueryTag { get; set; }

        /// <summary>
        /// SPR.2 - Query/Response Format Code.
        /// <para>Suggested: 0106 Query/Response Format Code -&gt; ClearHl7.Codes.V231.CodeQueryResponseFormatCode</para>
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

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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