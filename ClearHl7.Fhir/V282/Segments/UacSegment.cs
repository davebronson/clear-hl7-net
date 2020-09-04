using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment UAC - User Authentication Credential Segment.
    /// </summary>
    public class UacSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "UAC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// UAC.1 - User Authentication Credential Type Code.
        ///// </summary>
        //public UserAuthenticationCredentialTypeCode { get; set; }

        ///// <summary>
        ///// UAC.2 - User Authentication Credential.
        ///// </summary>
        //public UserAuthenticationCredential { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}"
                                ).TrimEnd('|');
        }
    }
}