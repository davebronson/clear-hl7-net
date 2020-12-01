using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V230.Types;

namespace ClearHl7.Fhir.V230.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0329</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0329</remarks>
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
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}