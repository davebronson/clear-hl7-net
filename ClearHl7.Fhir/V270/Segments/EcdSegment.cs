using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V270.Types;

namespace ClearHl7.Fhir.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ECD - Equipment Command.
    /// </summary>
    public class EcdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ECD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ECD.1 - Reference Command Number.
        /// </summary>
        public decimal? ReferenceCommandNumber { get; set; }

        /// <summary>
        /// ECD.2 - Remote Control Command.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0368</remarks>
        public CodedWithExceptions RemoteControlCommand { get; set; }

        /// <summary>
        /// ECD.3 - Response Required.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string ResponseRequired { get; set; }

        /// <summary>
        /// ECD.4 - Requested Completion Time.
        /// </summary>
        public string RequestedCompletionTime { get; set; }

        /// <summary>
        /// ECD.5 - Parameters.
        /// </summary>
        public IEnumerable<Text> Parameters { get; set; }
        
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
                                ReferenceCommandNumber.HasValue ? ReferenceCommandNumber.Value.ToString(Consts.NumericFormat, culture) : null,
                                RemoteControlCommand?.ToDelimitedString(),
                                ResponseRequired,
                                RequestedCompletionTime,
                                Parameters != null ? string.Join(Configuration.FieldRepeatSeparator, Parameters.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}