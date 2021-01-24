using System;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
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

        /// <summary>
        /// SFT.1 - Software Vendor Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations SoftwareVendorOrganization { get; set; }

        /// <summary>
        /// SFT.2 - Software Certified Version or Release Number.
        /// </summary>
        public string SoftwareCertifiedVersionOrReleaseNumber { get; set; }

        /// <summary>
        /// SFT.3 - Software Product Name.
        /// </summary>
        public string SoftwareProductName { get; set; }

        /// <summary>
        /// SFT.4 - Software Binary ID.
        /// </summary>
        public string SoftwareBinaryId { get; set; }

        /// <summary>
        /// SFT.5 - Software Product Information.
        /// </summary>
        public Text SoftwareProductInformation { get; set; }

        /// <summary>
        /// SFT.6 - Software Install Date.
        /// </summary>
        public DateTime? SoftwareInstallDate { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 7, Configuration.FieldSeparator),
                                Id,
                                SoftwareVendorOrganization?.ToDelimitedString(),
                                SoftwareCertifiedVersionOrReleaseNumber,
                                SoftwareProductName,
                                SoftwareBinaryId,
                                SoftwareProductInformation?.ToDelimitedString(),
                                SoftwareInstallDate.HasValue ? SoftwareInstallDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}