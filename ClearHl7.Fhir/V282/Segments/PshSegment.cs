using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// PSH.1 - Report Type.
        ///// </summary>
        //public ReportType { get; set; }

        ///// <summary>
        ///// PSH.2 - Report Form Identifier.
        ///// </summary>
        //public ReportFormIdentifier { get; set; }

        ///// <summary>
        ///// PSH.3 - Report Date.
        ///// </summary>
        //public ReportDate { get; set; }

        ///// <summary>
        ///// PSH.4 - Report Interval Start Date.
        ///// </summary>
        //public ReportIntervalStartDate { get; set; }

        ///// <summary>
        ///// PSH.5 - Report Interval End Date.
        ///// </summary>
        //public ReportIntervalEndDate { get; set; }

        ///// <summary>
        ///// PSH.6 - Quantity Manufactured.
        ///// </summary>
        //public QuantityManufactured { get; set; }

        ///// <summary>
        ///// PSH.7 - Quantity Distributed.
        ///// </summary>
        //public QuantityDistributed { get; set; }

        ///// <summary>
        ///// PSH.8 - Quantity Distributed Method.
        ///// </summary>
        //public QuantityDistributedMethod { get; set; }

        ///// <summary>
        ///// PSH.9 - Quantity Distributed Comment.
        ///// </summary>
        //public QuantityDistributedComment { get; set; }

        ///// <summary>
        ///// PSH.10 - Quantity in Use.
        ///// </summary>
        //public QuantityInUse { get; set; }

        ///// <summary>
        ///// PSH.11 - Quantity in Use Method.
        ///// </summary>
        //public QuantityInUseMethod { get; set; }

        ///// <summary>
        ///// PSH.12 - Quantity in Use Comment.
        ///// </summary>
        //public QuantityInUseComment { get; set; }

        ///// <summary>
        ///// PSH.13 - Number of Product Experience Reports Filed by Facility.
        ///// </summary>
        //public NumberOfProductExperienceReportsFiledByFacility { get; set; }

        ///// <summary>
        ///// PSH.14 - Number of Product Experience Reports Filed by Distributor.
        ///// </summary>
        //public NumberOfProductExperienceReportsFiledByDistributor { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}"
                                ).TrimEnd('|');
        }
    }
}