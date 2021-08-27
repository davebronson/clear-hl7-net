using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// FHS.15 - Security Classification Tag.
        /// <para>Suggested: 0952 Security Classification Tag</para>
        /// </summary>
        public CodedWithExceptions SecurityClassificationTag { get; set; }

        /// <summary>
        /// FHS.16 - Security Handling Instructions.
        /// <para>Suggested: 0953 Security Handling Instructions</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SecurityHandlingInstructions { get; set; }

        /// <summary>
        /// FHS.17 - Special Access Restriction Instructions.
        /// </summary>
        public IEnumerable<string> SpecialAccessRestrictionInstructions { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);
            
            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            FileFieldSeparator = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            FileEncodingCharacters = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            FileSendingApplication = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[3], false) : null;
            FileSendingFacility = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[4], false) : null;
            FileReceivingApplication = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[5], false) : null;
            FileReceivingFacility = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[6], false) : null;
            FileCreationDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            FileSecurity = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            FileNameId = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            FileHeaderComment = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            FileControlId = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            ReferenceFileControlId = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            FileSendingNetworkAddress = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[13], false) : null;
            FileReceivingNetworkAddress = segments.Length > 14 && segments[14].Length > 0 ? TypeHelper.Deserialize<HierarchicDesignator>(segments[14], false) : null;
            SecurityClassificationTag = segments.Length > 15 && segments[15].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[15], false) : null;
            SecurityHandlingInstructions = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
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
                                StringHelper.StringFormatSequence(0, 18, Configuration.FieldSeparator),
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
                                FileReceivingNetworkAddress?.ToDelimitedString(),
                                SecurityClassificationTag?.ToDelimitedString(),
                                SecurityHandlingInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, SecurityHandlingInstructions.Select(x => x.ToDelimitedString())) : null,
                                SpecialAccessRestrictionInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, SpecialAccessRestrictionInstructions) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}