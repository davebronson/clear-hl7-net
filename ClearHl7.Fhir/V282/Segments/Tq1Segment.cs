using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment TQ1 - Timing Quantity.
    /// </summary>
    public class Tq1Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "TQ1";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// TQ1.1 - Set ID - TQ1.
        ///// </summary>
        //public SetIdTq1 { get; set; }

        ///// <summary>
        ///// TQ1.2 - Quantity.
        ///// </summary>
        //public Quantity { get; set; }

        ///// <summary>
        ///// TQ1.3 - Repeat Pattern.
        ///// </summary>
        //public RepeatPattern { get; set; }

        ///// <summary>
        ///// TQ1.4 - Explicit Time.
        ///// </summary>
        //public ExplicitTime { get; set; }

        ///// <summary>
        ///// TQ1.5 - Relative Time and Units.
        ///// </summary>
        //public RelativeTimeAndUnits { get; set; }

        ///// <summary>
        ///// TQ1.6 - Service Duration.
        ///// </summary>
        //public ServiceDuration { get; set; }

        ///// <summary>
        ///// TQ1.7 - Start date/time.
        ///// </summary>
        //public StartDateTime { get; set; }

        ///// <summary>
        ///// TQ1.8 - End date/time.
        ///// </summary>
        //public EndDateTime { get; set; }

        ///// <summary>
        ///// TQ1.9 - Priority.
        ///// </summary>
        //public Priority { get; set; }

        ///// <summary>
        ///// TQ1.10 - Condition text.
        ///// </summary>
        //public ConditionText { get; set; }

        ///// <summary>
        ///// TQ1.11 - Text instruction.
        ///// </summary>
        //public TextInstruction { get; set; }

        ///// <summary>
        ///// TQ1.12 - Conjunction.
        ///// </summary>
        //public Conjunction { get; set; }

        ///// <summary>
        ///// TQ1.13 - Occurrence duration.
        ///// </summary>
        //public OccurrenceDuration { get; set; }

        ///// <summary>
        ///// TQ1.14 - Total occurrences.
        ///// </summary>
        //public TotalOccurrences { get; set; }
        
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