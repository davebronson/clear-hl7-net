using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment QRD - Query Definition.
    /// </summary>
    public class QrdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "QRD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// QRD.1 - Query Date/Time.
        /// </summary>
        public DateTime? QueryDateTime { get; set; }

        /// <summary>
        /// QRD.2 - Query Format Code.
        /// <para>Suggested: 0106 Query/Response Format Code</para>
        /// </summary>
        public string QueryFormatCode { get; set; }

        /// <summary>
        /// QRD.3 - Query Priority.
        /// <para>Suggested: 0091 Query Priority -&gt; ClearHl7.Codes.V260.CodeQueryPriority</para>
        /// </summary>
        public string QueryPriority { get; set; }

        /// <summary>
        /// QRD.4 - Query ID.
        /// </summary>
        public string QueryId { get; set; }

        /// <summary>
        /// QRD.5 - Deferred Response Type.
        /// <para>Suggested: 0107 Deferred Response Type</para>
        /// </summary>
        public string DeferredResponseType { get; set; }

        /// <summary>
        /// QRD.6 - Deferred Response Date/Time.
        /// </summary>
        public DateTime? DeferredResponseDateTime { get; set; }

        /// <summary>
        /// QRD.7 - Quantity Limited Request.
        /// <para>Suggested: 0126 Quantity Limited Request -&gt; ClearHl7.Codes.V260.CodeQuantityLimitedRequest</para>
        /// </summary>
        public CompositeQuantityWithUnits QuantityLimitedRequest { get; set; }

        /// <summary>
        /// QRD.8 - Who Subject Filter.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> WhoSubjectFilter { get; set; }

        /// <summary>
        /// QRD.9 - What Subject Filter.
        /// <para>Suggested: 0048 What Subject Filter</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> WhatSubjectFilter { get; set; }

        /// <summary>
        /// QRD.10 - What Department Data Code.
        /// </summary>
        public IEnumerable<CodedWithExceptions> WhatDepartmentDataCode { get; set; }

        /// <summary>
        /// QRD.11 - What Data Code Value Qual.
        /// </summary>
        public IEnumerable<ValueRange> WhatDataCodeValueQual { get; set; }

        /// <summary>
        /// QRD.12 - Query Results Level.
        /// <para>Suggested: 0108 Query Results Level</para>
        /// </summary>
        public string QueryResultsLevel { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                QueryDateTime.HasValue ? QueryDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                QueryFormatCode,
                                QueryPriority,
                                QueryId,
                                DeferredResponseType,
                                DeferredResponseDateTime.HasValue ? DeferredResponseDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                QuantityLimitedRequest?.ToDelimitedString(),
                                WhoSubjectFilter != null ? string.Join(Configuration.FieldRepeatSeparator, WhoSubjectFilter.Select(x => x.ToDelimitedString())) : null,
                                WhatSubjectFilter != null ? string.Join(Configuration.FieldRepeatSeparator, WhatSubjectFilter.Select(x => x.ToDelimitedString())) : null,
                                WhatDepartmentDataCode != null ? string.Join(Configuration.FieldRepeatSeparator, WhatDepartmentDataCode.Select(x => x.ToDelimitedString())) : null,
                                WhatDataCodeValueQual != null ? string.Join(Configuration.FieldRepeatSeparator, WhatDataCodeValueQual.Select(x => x.ToDelimitedString())) : null,
                                QueryResultsLevel
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}