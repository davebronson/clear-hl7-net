using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PDA - Patient Death And Autopsy.
    /// </summary>
    public class PdaSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PDA";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// PDA.1 - Death Cause Code.
        ///// </summary>
        //public DeathCauseCode { get; set; }

        ///// <summary>
        ///// PDA.2 - Death Location.
        ///// </summary>
        //public DeathLocation { get; set; }

        ///// <summary>
        ///// PDA.3 - Death Certified Indicator.
        ///// </summary>
        //public DeathCertifiedIndicator { get; set; }

        ///// <summary>
        ///// PDA.4 - Death Certificate Signed Date/Time.
        ///// </summary>
        //public DeathCertificateSignedDateTime { get; set; }

        ///// <summary>
        ///// PDA.5 - Death Certified By.
        ///// </summary>
        //public DeathCertifiedBy { get; set; }

        ///// <summary>
        ///// PDA.6 - Autopsy Indicator.
        ///// </summary>
        //public AutopsyIndicator { get; set; }

        ///// <summary>
        ///// PDA.7 - Autopsy Start and End Date/Time.
        ///// </summary>
        //public AutopsyStartAndEndDateTime { get; set; }

        ///// <summary>
        ///// PDA.8 - Autopsy Performed By.
        ///// </summary>
        //public AutopsyPerformedBy { get; set; }

        ///// <summary>
        ///// PDA.9 - Coroner Indicator.
        ///// </summary>
        //public CoronerIndicator { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}"
                                ).TrimEnd('|');
        }
    }
}