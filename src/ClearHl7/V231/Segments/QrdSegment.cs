using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment QRD - Query Definition.
    /// </summary>
    public class QrdSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QrdSegment"/> class.
        /// </summary>
        public QrdSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QrdSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public QrdSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "QRD";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// QRD.1 - Query Date/Time.
        /// </summary>
        public DateTime? QueryDateTime { get; set; }

        /// <summary>
        /// QRD.2 - Query Format Code.
        /// <para>Suggested: 0106 Query/Response Format Code -&gt; ClearHl7.Codes.V231.CodeQueryResponseFormatCode</para>
        /// </summary>
        public string QueryFormatCode { get; set; }

        /// <summary>
        /// QRD.3 - Query Priority.
        /// <para>Suggested: 0091 Query Priority -&gt; ClearHl7.Codes.V231.CodeQueryPriority</para>
        /// </summary>
        public string QueryPriority { get; set; }

        /// <summary>
        /// QRD.4 - Query ID.
        /// </summary>
        public string QueryId { get; set; }

        /// <summary>
        /// QRD.5 - Deferred Response Type.
        /// <para>Suggested: 0107 Deferred Response Type -&gt; ClearHl7.Codes.V231.CodeDeferredResponseType</para>
        /// </summary>
        public string DeferredResponseType { get; set; }

        /// <summary>
        /// QRD.6 - Deferred Response Date/Time.
        /// </summary>
        public DateTime? DeferredResponseDateTime { get; set; }

        /// <summary>
        /// QRD.7 - Quantity Limited Request.
        /// <para>Suggested: 0126 Quantity Limited Request -&gt; ClearHl7.Codes.V231.CodeQuantityLimitedRequest</para>
        /// </summary>
        public CompositeQuantityWithUnits QuantityLimitedRequest { get; set; }

        /// <summary>
        /// QRD.8 - Who Subject Filter.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> WhoSubjectFilter { get; set; }

        /// <summary>
        /// QRD.9 - What Subject Filter.
        /// <para>Suggested: 0048 What Subject Filter -&gt; ClearHl7.Codes.V231.CodeWhatSubjectFilter</para>
        /// </summary>
        public IEnumerable<CodedElement> WhatSubjectFilter { get; set; }

        /// <summary>
        /// QRD.10 - What Department Data Code.
        /// </summary>
        public IEnumerable<CodedElement> WhatDepartmentDataCode { get; set; }

        /// <summary>
        /// QRD.11 - What Data Code Value Qual.
        /// </summary>
        public IEnumerable<ValueRange> WhatDataCodeValueQual { get; set; }

        /// <summary>
        /// QRD.12 - Query Results Level.
        /// <para>Suggested: 0108 Query Results Level -&gt; ClearHl7.Codes.V231.CodeQueryResultsLevel</para>
        /// </summary>
        public string QueryResultsLevel { get; set; }

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

            QueryDateTime = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDateTime() : null;
            QueryFormatCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            QueryPriority = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            QueryId = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            DeferredResponseType = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            DeferredResponseDateTime = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDateTime() : null;
            QuantityLimitedRequest = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[7], false, seps) : null;
            WhoSubjectFilter = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            WhatSubjectFilter = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null; ;
            WhatDepartmentDataCode = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null; ;
            WhatDataCodeValueQual = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ValueRange>(x, false, seps)) : null; ;
            QueryResultsLevel = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                QueryDateTime?.ToHl7DateTimeString(typeof(QrdSegment), nameof(QueryDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                QueryFormatCode,
                                QueryPriority,
                                QueryId,
                                DeferredResponseType,
                                DeferredResponseDateTime?.ToHl7DateTimeString(typeof(QrdSegment), nameof(DeferredResponseDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
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
