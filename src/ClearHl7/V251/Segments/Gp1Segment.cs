using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
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
        /// <para>Suggested: 0455 Type Of Bill Code -&gt; ClearHl7.Codes.V251.CodeTypeOfBillCode</para>
        /// </summary>
        public string TypeOfBillCode { get; set; }

        /// <summary>
        /// GP1.2 - Revenue Code.
        /// <para>Suggested: 0456 Revenue Code -&gt; ClearHl7.Codes.V251.CodeRevenueCode</para>
        /// </summary>
        public IEnumerable<string> RevenueCode { get; set; }

        /// <summary>
        /// GP1.3 - Overall Claim Disposition Code.
        /// <para>Suggested: 0457 Overall Claim Disposition Code -&gt; ClearHl7.Codes.V251.CodeOverallClaimDispositionCode</para>
        /// </summary>
        public string OverallClaimDispositionCode { get; set; }

        /// <summary>
        /// GP1.4 - OCE Edits per Visit Code.
        /// <para>Suggested: 0458 OCE Edit Code</para>
        /// </summary>
        public IEnumerable<string> OceEditsPerVisitCode { get; set; }

        /// <summary>
        /// GP1.5 - Outlier Cost.
        /// </summary>
        public CompositePrice OutlierCost { get; set; }

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

            TypeOfBillCode = segments.ElementAtOrDefault(1);
            RevenueCode = segments.Length > 2 ? segments.ElementAtOrDefault(2).Split(separator) : null;
            OverallClaimDispositionCode = segments.ElementAtOrDefault(3);
            OceEditsPerVisitCode = segments.Length > 4 ? segments.ElementAtOrDefault(4).Split(separator) : null;
            OutlierCost = segments.Length > 5 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(5), false) : null;
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
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                TypeOfBillCode,
                                RevenueCode != null ? string.Join(Configuration.FieldRepeatSeparator, RevenueCode) : null,
                                OverallClaimDispositionCode,
                                OceEditsPerVisitCode != null ? string.Join(Configuration.FieldRepeatSeparator, OceEditsPerVisitCode) : null,
                                OutlierCost?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}