using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Segments
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
        public string FileSendingApplication { get; set; }

        /// <summary>
        /// FHS.4 - File Sending Facility.
        /// </summary>
        public string FileSendingFacility { get; set; }

        /// <summary>
        /// FHS.5 - File Receiving Application.
        /// </summary>
        public string FileReceivingApplication { get; set; }

        /// <summary>
        /// FHS.6 - File Receiving Facility.
        /// </summary>
        public string FileReceivingFacility { get; set; }

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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            FileFieldSeparator = segments.ElementAtOrDefault(1);
            FileEncodingCharacters = segments.ElementAtOrDefault(2);
            FileSendingApplication = segments.ElementAtOrDefault(3);
            FileSendingFacility = segments.ElementAtOrDefault(4);
            FileReceivingApplication = segments.ElementAtOrDefault(5);
            FileReceivingFacility = segments.ElementAtOrDefault(6);
            FileCreationDateTime = segments.ElementAtOrDefault(7)?.ToNullableDateTime();
            FileSecurity = segments.ElementAtOrDefault(8);
            FileNameId = segments.ElementAtOrDefault(9);
            FileHeaderComment = segments.ElementAtOrDefault(10);
            FileControlId = segments.ElementAtOrDefault(11);
            ReferenceFileControlId = segments.ElementAtOrDefault(12);
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                FileFieldSeparator,
                                FileEncodingCharacters,
                                FileSendingApplication,
                                FileSendingFacility,
                                FileReceivingApplication,
                                FileReceivingFacility,
                                FileCreationDateTime.HasValue ? FileCreationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                FileSecurity,
                                FileNameId,
                                FileHeaderComment,
                                FileControlId,
                                ReferenceFileControlId
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}