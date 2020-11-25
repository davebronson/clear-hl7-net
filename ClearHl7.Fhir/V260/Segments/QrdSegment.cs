using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V260.Types;

namespace ClearHl7.Fhir.V260.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0106</remarks>
        public string QueryFormatCode { get; set; }

        /// <summary>
        /// QRD.3 - Query Priority.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0091</remarks>
        public string QueryPriority { get; set; }

        /// <summary>
        /// QRD.4 - Query ID.
        /// </summary>
        public string QueryId { get; set; }

        /// <summary>
        /// QRD.5 - Deferred Response Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0107</remarks>
        public string DeferredResponseType { get; set; }

        /// <summary>
        /// QRD.6 - Deferred Response Date/Time.
        /// </summary>
        public DateTime? DeferredResponseDateTime { get; set; }

        /// <summary>
        /// QRD.7 - Quantity Limited Request.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0126</remarks>
        public CompositeQuantityWithUnits QuantityLimitedRequest { get; set; }

        /// <summary>
        /// QRD.8 - Who Subject Filter.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> WhoSubjectFilter { get; set; }

        /// <summary>
        /// QRD.9 - What Subject Filter.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0048</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0108</remarks>
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
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}",
                                Id,
                                QueryDateTime.HasValue ? QueryDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                QueryFormatCode,
                                QueryPriority,
                                QueryId,
                                DeferredResponseType,
                                DeferredResponseDateTime.HasValue ? DeferredResponseDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                QuantityLimitedRequest?.ToDelimitedString(),
                                WhoSubjectFilter != null ? string.Join("~", WhoSubjectFilter.Select(x => x.ToDelimitedString())) : null,
                                WhatSubjectFilter != null ? string.Join("~", WhatSubjectFilter.Select(x => x.ToDelimitedString())) : null,
                                WhatDepartmentDataCode != null ? string.Join("~", WhatDepartmentDataCode.Select(x => x.ToDelimitedString())) : null,
                                WhatDataCodeValueQual != null ? string.Join("~", WhatDataCodeValueQual.Select(x => x.ToDelimitedString())) : null,
                                QueryResultsLevel
                                ).TrimEnd('|');
        }
    }
}