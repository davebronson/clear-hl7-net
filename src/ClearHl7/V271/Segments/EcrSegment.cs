using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ECR - Equipment Command Response.
    /// </summary>
    public class EcrSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ECR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ECR.1 - Command Response.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0387</remarks>
        public CodedWithExceptions CommandResponse { get; set; }

        /// <summary>
        /// ECR.2 - Date/Time Completed.
        /// </summary>
        public DateTime? DateTimeCompleted { get; set; }

        /// <summary>
        /// ECR.3 - Command Response Parameters.
        /// </summary>
        public IEnumerable<Text> CommandResponseParameters { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                CommandResponse?.ToDelimitedString(),
                                DateTimeCompleted.HasValue ? DateTimeCompleted.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                CommandResponseParameters != null ? string.Join(Configuration.FieldRepeatSeparator, CommandResponseParameters.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}