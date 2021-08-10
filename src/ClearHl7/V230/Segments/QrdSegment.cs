using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        /// <para>Suggested: 0106 Query/Response Format Code -&gt; ClearHl7.Codes.V230.CodeQueryResponseFormatCode</para>
        /// </summary>
        public string QueryFormatCode { get; set; }

        /// <summary>
        /// QRD.3 - Query Priority.
        /// <para>Suggested: 0091 Query Priority -&gt; ClearHl7.Codes.V230.CodeQueryPriority</para>
        /// </summary>
        public string QueryPriority { get; set; }

        /// <summary>
        /// QRD.4 - Query ID.
        /// </summary>
        public string QueryId { get; set; }

        /// <summary>
        /// QRD.5 - Deferred Response Type.
        /// <para>Suggested: 0107 Deferred Response Type -&gt; ClearHl7.Codes.V230.CodeDeferredResponseType</para>
        /// </summary>
        public string DeferredResponseType { get; set; }

        /// <summary>
        /// QRD.6 - Deferred Response Date/Time.
        /// </summary>
        public DateTime? DeferredResponseDateTime { get; set; }

        /// <summary>
        /// QRD.7 - Quantity Limited Request.
        /// <para>Suggested: 0126 Quantity Limited Request -&gt; ClearHl7.Codes.V230.CodeQuantityLimitedRequest</para>
        /// </summary>
        public CompositeQuantityWithUnits QuantityLimitedRequest { get; set; }

        /// <summary>
        /// QRD.8 - Who Subject Filter.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> WhoSubjectFilter { get; set; }

        /// <summary>
        /// QRD.9 - What Subject Filter.
        /// <para>Suggested: 0048 What Subject Filter -&gt; ClearHl7.Codes.V230.CodeWhatSubjectFilter</para>
        /// </summary>
        public IEnumerable<CodedElement> WhatSubjectFilter { get; set; }

        /// <summary>
        /// QRD.10 - What Department Data Code.
        /// </summary>
        public IEnumerable<CodedElement> WhatDepartmentDataCode { get; set; }

        /// <summary>
        /// QRD.11 - What Data Code Value Qual.
        /// </summary>
        public IEnumerable<string> WhatDataCodeValueQual { get; set; }

        /// <summary>
        /// QRD.12 - Query Results Level.
        /// <para>Suggested: 0108 Query Results Level -&gt; ClearHl7.Codes.V230.CodeQueryResultsLevel</para>
        /// </summary>
        public string QueryResultsLevel { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            QueryDateTime = segments.ElementAtOrDefault(1)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            QueryFormatCode = segments.ElementAtOrDefault(2);
            QueryPriority = segments.ElementAtOrDefault(3);
            QueryId = segments.ElementAtOrDefault(4);
            DeferredResponseType = segments.ElementAtOrDefault(5);
            DeferredResponseDateTime = segments.ElementAtOrDefault(6)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            QuantityLimitedRequest = segments.Length > 7 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(7), false) : null;
            WhoSubjectFilter = segments.Length > 8 ? segments.ElementAtOrDefault(8).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            WhatSubjectFilter = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null; ;
            WhatDepartmentDataCode = segments.Length > 10 ? segments.ElementAtOrDefault(10).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null; ;
            WhatDataCodeValueQual = segments.Length > 11 ? segments.ElementAtOrDefault(11).Split(separator) : null; ;
            QueryResultsLevel = segments.ElementAtOrDefault(12);
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
                                WhatDataCodeValueQual != null ? string.Join(Configuration.FieldRepeatSeparator, WhatDataCodeValueQual) : null,
                                QueryResultsLevel
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}