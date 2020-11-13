﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0106</remarks>
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
        public IEnumerable<QuerySelectionCriteria> SelectionCriteria { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}",
                                Id,
                                QueryTag,
                                QueryResponseFormatCode,
                                VtQueryName?.ToDelimitedString(),
                                VirtualTableName?.ToDelimitedString(),
                                SelectionCriteria != null ? string.Join("~", SelectionCriteria.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd('|');
        }
    }
}