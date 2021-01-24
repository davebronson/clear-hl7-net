using System;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DRG - Diagnosis Related Group.
    /// </summary>
    public class DrgSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DRG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// DRG.1 - Diagnostic Related Group.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0055</remarks>
        public CodedElement DiagnosticRelatedGroup { get; set; }

        /// <summary>
        /// DRG.2 - DRG Assigned Date/Time.
        /// </summary>
        public DateTime? DrgAssignedDateTime { get; set; }

        /// <summary>
        /// DRG.3 - DRG Approval Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string DrgApprovalIndicator { get; set; }

        /// <summary>
        /// DRG.4 - DRG Grouper Review Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0056</remarks>
        public string DrgGrouperReviewCode { get; set; }

        /// <summary>
        /// DRG.5 - Outlier Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0083</remarks>
        public CodedElement OutlierType { get; set; }

        /// <summary>
        /// DRG.6 - Outlier Days.
        /// </summary>
        public decimal? OutlierDays { get; set; }

        /// <summary>
        /// DRG.7 - Outlier Cost.
        /// </summary>
        public CompositePrice OutlierCost { get; set; }

        /// <summary>
        /// DRG.8 - DRG Payor.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0229</remarks>
        public string DrgPayor { get; set; }

        /// <summary>
        /// DRG.9 - Outlier Reimbursement.
        /// </summary>
        public CompositePrice OutlierReimbursement { get; set; }

        /// <summary>
        /// DRG.10 - Confidential Indicator.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string ConfidentialIndicator { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 11, Configuration.FieldSeparator),
                                Id,
                                DiagnosticRelatedGroup?.ToDelimitedString(),
                                DrgAssignedDateTime.HasValue ? DrgAssignedDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                DrgApprovalIndicator,
                                DrgGrouperReviewCode,
                                OutlierType?.ToDelimitedString(),
                                OutlierDays.HasValue ? OutlierDays.Value.ToString(Consts.NumericFormat, culture) : null,
                                OutlierCost?.ToDelimitedString(),
                                DrgPayor,
                                OutlierReimbursement?.ToDelimitedString(),
                                ConfidentialIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}