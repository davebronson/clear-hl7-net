using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V280.Types;

namespace ClearHl7.Fhir.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment FHS - File Header.
    /// </summary>
    public class FhsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "FHS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// FHS.1 - File Field Separator.
        /// </summary>
        public string FileFieldSeparator { get; set; }

        /// <summary>
        /// FHS.2 - File Encoding Characters.
        /// </summary>
        public string FileEncodingCharacters { get; set; }

        /// <summary>
        /// FHS.3 - File Sending Application.
        /// </summary>
        public HierarchicDesignator FileSendingApplication { get; set; }

        /// <summary>
        /// FHS.4 - File Sending Facility.
        /// </summary>
        public HierarchicDesignator FileSendingFacility { get; set; }

        /// <summary>
        /// FHS.5 - File Receiving Application.
        /// </summary>
        public HierarchicDesignator FileReceivingApplication { get; set; }

        /// <summary>
        /// FHS.6 - File Receiving Facility.
        /// </summary>
        public HierarchicDesignator FileReceivingFacility { get; set; }

        /// <summary>
        /// FHS.7 - File Creation Date/Time.
        /// </summary>
        public DateTime? FileCreationDateTime { get; set; }

        /// <summary>
        /// FHS.8 - File Security.
        /// </summary>
        public string FileSecurity { get; set; }

        /// <summary>
        /// FHS.9 - File Name/ID.
        /// </summary>
        public string FileNameId { get; set; }

        /// <summary>
        /// FHS.10 - File Header Comment.
        /// </summary>
        public string FileHeaderComment { get; set; }

        /// <summary>
        /// FHS.11 - File Control ID.
        /// </summary>
        public string FileControlId { get; set; }

        /// <summary>
        /// FHS.12 - Reference File Control ID.
        /// </summary>
        public string ReferenceFileControlId { get; set; }

        /// <summary>
        /// FHS.13 - File Sending Network Address.
        /// </summary>
        public HierarchicDesignator FileSendingNetworkAddress { get; set; }

        /// <summary>
        /// FHS.14 - File Receiving Network Address.
        /// </summary>
        public HierarchicDesignator FileReceivingNetworkAddress { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}",
                                Id,
                                FileFieldSeparator,
                                FileEncodingCharacters,
                                FileSendingApplication?.ToDelimitedString(),
                                FileSendingFacility?.ToDelimitedString(),
                                FileReceivingApplication?.ToDelimitedString(),
                                FileReceivingFacility?.ToDelimitedString(),
                                FileCreationDateTime.HasValue ? FileCreationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                FileSecurity,
                                FileNameId,
                                FileHeaderComment,
                                FileControlId,
                                ReferenceFileControlId,
                                FileSendingNetworkAddress?.ToDelimitedString(),
                                FileReceivingNetworkAddress?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}