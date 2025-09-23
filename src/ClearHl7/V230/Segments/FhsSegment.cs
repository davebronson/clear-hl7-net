using System;
using System.Globalization;
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
        /// Initializes a new instance of the <see cref="FhsSegment"/> class.
        /// </summary>
        public FhsSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhsSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public FhsSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "FHS";

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            FileFieldSeparator = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            FileEncodingCharacters = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            FileSendingApplication = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            FileSendingFacility = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            FileReceivingApplication = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            FileReceivingFacility = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            FileCreationDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            FileSecurity = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            FileNameId = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            FileHeaderComment = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            FileControlId = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            ReferenceFileControlId = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
        }

        /// <inheritdoc/>
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
                                FileCreationDateTime.ToHl7DateTimeString(typeof(FhsSegment), nameof(FileCreationDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                FileSecurity,
                                FileNameId,
                                FileHeaderComment,
                                FileControlId,
                                ReferenceFileControlId
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
