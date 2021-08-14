using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PSH - Product Summary Header.
    /// </summary>
    public class PshSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PSH";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PSH.1 - Report Type.
        /// </summary>
        public string ReportType { get; set; }

        /// <summary>
        /// PSH.2 - Report Form Identifier.
        /// </summary>
        public string ReportFormIdentifier { get; set; }

        /// <summary>
        /// PSH.3 - Report Date.
        /// </summary>
        public DateTime? ReportDate { get; set; }

        /// <summary>
        /// PSH.4 - Report Interval Start Date.
        /// </summary>
        public DateTime? ReportIntervalStartDate { get; set; }

        /// <summary>
        /// PSH.5 - Report Interval End Date.
        /// </summary>
        public DateTime? ReportIntervalEndDate { get; set; }

        /// <summary>
        /// PSH.6 - Quantity Manufactured.
        /// </summary>
        public CompositeQuantityWithUnits QuantityManufactured { get; set; }

        /// <summary>
        /// PSH.7 - Quantity Distributed.
        /// </summary>
        public CompositeQuantityWithUnits QuantityDistributed { get; set; }

        /// <summary>
        /// PSH.8 - Quantity Distributed Method.
        /// <para>Suggested: 0329 Quantity Method -&gt; ClearHl7.Codes.V231.CodeQuantityMethod</para>
        /// </summary>
        public string QuantityDistributedMethod { get; set; }

        /// <summary>
        /// PSH.9 - Quantity Distributed Comment.
        /// </summary>
        public string QuantityDistributedComment { get; set; }

        /// <summary>
        /// PSH.10 - Quantity in Use.
        /// </summary>
        public CompositeQuantityWithUnits QuantityInUse { get; set; }

        /// <summary>
        /// PSH.11 - Quantity in Use Method.
        /// <para>Suggested: 0329 Quantity Method -&gt; ClearHl7.Codes.V231.CodeQuantityMethod</para>
        /// </summary>
        public string QuantityInUseMethod { get; set; }

        /// <summary>
        /// PSH.12 - Quantity in Use Comment.
        /// </summary>
        public string QuantityInUseComment { get; set; }

        /// <summary>
        /// PSH.13 - Number of Product Experience Reports Filed by Facility.
        /// </summary>
        public IEnumerable<decimal> NumberOfProductExperienceReportsFiledByFacility { get; set; }

        /// <summary>
        /// PSH.14 - Number of Product Experience Reports Filed by Distributor.
        /// </summary>
        public IEnumerable<decimal> NumberOfProductExperienceReportsFiledByDistributor { get; set; }

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

            ReportType = segments.ElementAtOrDefault(1);
            ReportFormIdentifier = segments.ElementAtOrDefault(2);
            ReportDate = segments.ElementAtOrDefault(3)?.ToNullableDateTime();
            ReportIntervalStartDate = segments.ElementAtOrDefault(4)?.ToNullableDateTime();
            ReportIntervalEndDate = segments.ElementAtOrDefault(5)?.ToNullableDateTime();
            QuantityManufactured = segments.Length > 6 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(6), false) : null;
            QuantityDistributed = segments.Length > 7 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(7), false) : null;
            QuantityDistributedMethod = segments.ElementAtOrDefault(8);
            QuantityDistributedComment = segments.ElementAtOrDefault(9);
            QuantityInUse = segments.Length > 10 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(10), false) : null;
            QuantityInUseMethod = segments.ElementAtOrDefault(11);
            QuantityInUseComment = segments.ElementAtOrDefault(12);
            NumberOfProductExperienceReportsFiledByFacility = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator).Select(x => x.ToDecimal()) : null;
            NumberOfProductExperienceReportsFiledByDistributor = segments.Length > 14 ? segments.ElementAtOrDefault(14).Split(separator).Select(x => x.ToDecimal()) : null;
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
                                StringHelper.StringFormatSequence(0, 15, Configuration.FieldSeparator),
                                Id,
                                ReportType,
                                ReportFormIdentifier,
                                ReportDate.HasValue ? ReportDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReportIntervalStartDate.HasValue ? ReportIntervalStartDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ReportIntervalEndDate.HasValue ? ReportIntervalEndDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                QuantityManufactured?.ToDelimitedString(),
                                QuantityDistributed?.ToDelimitedString(),
                                QuantityDistributedMethod,
                                QuantityDistributedComment,
                                QuantityInUse?.ToDelimitedString(),
                                QuantityInUseMethod,
                                QuantityInUseComment,
                                NumberOfProductExperienceReportsFiledByFacility != null ? string.Join(Configuration.FieldRepeatSeparator, NumberOfProductExperienceReportsFiledByFacility.Select(x => x.ToString(Consts.NumericFormat, culture))) : null,
                                NumberOfProductExperienceReportsFiledByDistributor != null ? string.Join(Configuration.FieldRepeatSeparator, NumberOfProductExperienceReportsFiledByDistributor.Select(x => x.ToString(Consts.NumericFormat, culture))) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}