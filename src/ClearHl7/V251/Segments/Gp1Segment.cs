using System;
using System.Collections.Generic;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment GP1 - Grouping Reimbursement - Visit.
    /// </summary>
    public class Gp1Segment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Gp1Segment"/> class.
        /// </summary>
        public Gp1Segment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Gp1Segment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public Gp1Segment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "GP1";

        /// <inheritdoc/>
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

            TypeOfBillCode = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            RevenueCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            OverallClaimDispositionCode = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            OceEditsPerVisitCode = segments.Length > 4 && segments[4].Length > 0 ? segments[4].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            OutlierCost = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[5], false, seps) : null;
        }

        /// <inheritdoc/>
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
