using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment TCD - Test Code Detail.
    /// </summary>
    public class TcdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "TCD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// TCD.1 - Universal Service Identifier.
        ///// </summary>
        //public UniversalServiceIdentifier { get; set; }

        ///// <summary>
        ///// TCD.2 - Auto-Dilution Factor.
        ///// </summary>
        //public AutoDilutionFactor { get; set; }

        ///// <summary>
        ///// TCD.3 - Rerun Dilution Factor.
        ///// </summary>
        //public RerunDilutionFactor { get; set; }

        ///// <summary>
        ///// TCD.4 - Pre-Dilution Factor.
        ///// </summary>
        //public PreDilutionFactor { get; set; }

        ///// <summary>
        ///// TCD.5 - Endogenous Content of Pre-Dilution Diluent.
        ///// </summary>
        //public EndogenousContentOfPreDilutionDiluent { get; set; }

        ///// <summary>
        ///// TCD.6 - Automatic Repeat Allowed.
        ///// </summary>
        //public AutomaticRepeatAllowed { get; set; }

        ///// <summary>
        ///// TCD.7 - Reflex Allowed.
        ///// </summary>
        //public ReflexAllowed { get; set; }

        ///// <summary>
        ///// TCD.8 - Analyte Repeat Status.
        ///// </summary>
        //public AnalyteRepeatStatus { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}"
                                ).TrimEnd('|');
        }
    }
}