using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment VAR - Variance.
    /// </summary>
    public class VarSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "VAR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// VAR.1 - Variance Instance ID.
        ///// </summary>
        //public VarianceInstanceId { get; set; }

        ///// <summary>
        ///// VAR.2 - Documented Date/Time.
        ///// </summary>
        //public DocumentedDateTime { get; set; }

        ///// <summary>
        ///// VAR.3 - Stated Variance Date/Time.
        ///// </summary>
        //public StatedVarianceDateTime { get; set; }

        ///// <summary>
        ///// VAR.4 - Variance Originator.
        ///// </summary>
        //public VarianceOriginator { get; set; }

        ///// <summary>
        ///// VAR.5 - Variance Classification.
        ///// </summary>
        //public VarianceClassification { get; set; }

        ///// <summary>
        ///// VAR.6 - Variance Description.
        ///// </summary>
        //public VarianceDescription { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}"
                                ).TrimEnd('|');
        }
    }
}