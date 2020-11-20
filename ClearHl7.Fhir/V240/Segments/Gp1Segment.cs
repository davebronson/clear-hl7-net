using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V240.Types;

namespace ClearHl7.Fhir.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment GP1 - Grouping Reimbursement - Visit.
    /// </summary>
    public class Gp1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "GP1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// GP1.1 - Type of Bill Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0455</remarks>
        public string TypeOfBillCode { get; set; }

        /// <summary>
        /// GP1.2 - Revenue Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0456</remarks>
        public IEnumerable<string> RevenueCode { get; set; }

        /// <summary>
        /// GP1.3 - Overall Claim Disposition Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0457</remarks>
        public string OverallClaimDispositionCode { get; set; }

        /// <summary>
        /// GP1.4 - OCE Edits per Visit Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0458</remarks>
        public IEnumerable<string> OceEditsPerVisitCode { get; set; }

        /// <summary>
        /// GP1.5 - Outlier Cost.
        /// </summary>
        public CompositePrice OutlierCost { get; set; }
        
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
                                TypeOfBillCode,
                                RevenueCode != null ? string.Join("~", RevenueCode) : null,
                                OverallClaimDispositionCode,
                                OceEditsPerVisitCode != null ? string.Join("~", OceEditsPerVisitCode) : null,
                                OutlierCost?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}