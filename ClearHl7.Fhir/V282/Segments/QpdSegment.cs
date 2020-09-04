using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment QPD - Query Parameter Definition.
    /// </summary>
    public class QpdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "QPD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// QPD.1 - Message Query Name.
        ///// </summary>
        //public MessageQueryName { get; set; }

        ///// <summary>
        ///// QPD.2 - Query Tag.
        ///// </summary>
        //public QueryTag { get; set; }

        ///// <summary>
        ///// QPD.3 - User Parameters (in successive fields).
        ///// </summary>
        //public UserParametersInSuccessiveFields { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}"
                                ).TrimEnd('|');
        }
    }
}