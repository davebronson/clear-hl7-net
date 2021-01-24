using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment DST - Transport Destination.
    /// </summary>
    public class DstSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "DST";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// DST.1 - Destination.
        /// <para>Suggested: 0943 Destination</para>
        /// </summary>
        public CodedWithExceptions Destination { get; set; }

        /// <summary>
        /// DST.2 - Route.
        /// <para>Suggested: 0944 Route</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Route { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, Configuration.FieldSeparator),
                                Id,
                                Destination?.ToDelimitedString(),
                                Route != null ? string.Join(Configuration.FieldRepeatSeparator, Route.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}