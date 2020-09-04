using System;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SFT - Software Segment.
    /// </summary>
    public class SftSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SFT";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        ///// <summary>
        ///// SFT.1 - Software Vendor Organization.
        ///// </summary>
        //public SoftwareVendorOrganization { get; set; }

        ///// <summary>
        ///// SFT.2 - Software Certified Version or Release Number.
        ///// </summary>
        //public SoftwareCertifiedVersionOrReleaseNumber { get; set; }

        ///// <summary>
        ///// SFT.3 - Software Product Name.
        ///// </summary>
        //public SoftwareProductName { get; set; }

        ///// <summary>
        ///// SFT.4 - Software Binary ID.
        ///// </summary>
        //public SoftwareBinaryId { get; set; }

        ///// <summary>
        ///// SFT.5 - Software Product Information.
        ///// </summary>
        //public SoftwareProductInformation { get; set; }

        ///// <summary>
        ///// SFT.6 - Software Install Date.
        ///// </summary>
        //public SoftwareInstallDate { get; set; }
        
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