﻿using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
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
        /// <para>Suggested: 0455 Type Of Bill Code -&gt; ClearHl7.Codes.V281.CodeTypeOfBillCode</para>
        /// </summary>
        public CodedWithExceptions TypeOfBillCode { get; set; }

        /// <summary>
        /// GP1.2 - Revenue Code.
        /// <para>Suggested: 0456 Revenue Code -&gt; ClearHl7.Codes.V281.CodeRevenueCode</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> RevenueCode { get; set; }

        /// <summary>
        /// GP1.3 - Overall Claim Disposition Code.
        /// <para>Suggested: 0457 Overall Claim Disposition Code -&gt; ClearHl7.Codes.V281.CodeOverallClaimDispositionCode</para>
        /// </summary>
        public CodedWithExceptions OverallClaimDispositionCode { get; set; }

        /// <summary>
        /// GP1.4 - OCE Edits per Visit Code.
        /// <para>Suggested: 0458 OCE Edit Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> OceEditsPerVisitCode { get; set; }

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
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                TypeOfBillCode?.ToDelimitedString(),
                                RevenueCode != null ? string.Join(Configuration.FieldRepeatSeparator, RevenueCode.Select(x => x.ToDelimitedString())) : null,
                                OverallClaimDispositionCode?.ToDelimitedString(),
                                OceEditsPerVisitCode != null ? string.Join(Configuration.FieldRepeatSeparator, OceEditsPerVisitCode.Select(x => x.ToDelimitedString())) : null,
                                OutlierCost?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}