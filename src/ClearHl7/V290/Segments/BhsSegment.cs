using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BHS - Batch Header.
    /// </summary>
    public class BhsSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BhsSegment"/> class.
        /// </summary>
        public BhsSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BhsSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public BhsSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "BHS";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// BHS.1 - Batch Field Separator.
        /// </summary>
        public string BatchFieldSeparator { get; set; }

        /// <summary>
        /// BHS.2 - Batch Encoding Characters.
        /// </summary>
        public string BatchEncodingCharacters { get; set; }

        /// <summary>
        /// BHS.3 - Batch Sending Application.
        /// </summary>
        public HierarchicDesignator BatchSendingApplication { get; set; }

        /// <summary>
        /// BHS.4 - Batch Sending Facility.
        /// </summary>
        public HierarchicDesignator BatchSendingFacility { get; set; }

        /// <summary>
        /// BHS.5 - Batch Receiving Application.
        /// </summary>
        public HierarchicDesignator BatchReceivingApplication { get; set; }

        /// <summary>
        /// BHS.6 - Batch Receiving Facility.
        /// </summary>
        public HierarchicDesignator BatchReceivingFacility { get; set; }

        /// <summary>
        /// BHS.7 - Batch Creation Date/Time.
        /// </summary>
        public DateTime? BatchCreationDateTime { get; set; }

        /// <summary>
        /// BHS.8 - Batch Security.
        /// </summary>
        public string BatchSecurity { get; set; }

        /// <summary>
        /// BHS.9 - Batch Name/ID/Type.
        /// </summary>
        public string BatchNameIdType { get; set; }

        /// <summary>
        /// BHS.10 - Batch Comment.
        /// </summary>
        public string BatchComment { get; set; }

        /// <summary>
        /// BHS.11 - Batch Control ID.
        /// </summary>
        public string BatchControlId { get; set; }

        /// <summary>
        /// BHS.12 - Reference Batch Control ID.
        /// </summary>
        public string ReferenceBatchControlId { get; set; }

        /// <summary>
        /// BHS.13 - Batch Sending Network Address.
        /// </summary>
        public HierarchicDesignator BatchSendingNetworkAddress { get; set; }

        /// <summary>
        /// BHS.14 - Batch Receiving Network Address.
        /// </summary>
        public HierarchicDesignator BatchReceivingNetworkAddress { get; set; }

        /// <summary>
        /// BHS.15 - Security Classification Tag.
        /// <para>Suggested: 0952 Security Classification Tag</para>
        /// </summary>
        public CodedWithExceptions SecurityClassificationTag { get; set; }

        /// <summary>
        /// BHS.16 - Security Handling Instructions.
        /// <para>Suggested: 0953 Security Handling Instructions</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SecurityHandlingInstructions { get; set; }

        /// <summary>
        /// BHS.17 - Special Access Restriction Instructions.
        /// </summary>
        public IEnumerable<string> SpecialAccessRestrictionInstructions { get; set; }

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

            BatchFieldSeparator = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            BatchEncodingCharacters = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            BatchSendingApplication = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[3], false, seps) : null;
            BatchSendingFacility = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[4], false, seps) : null;
            BatchReceivingApplication = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[5], false, seps) : null;
            BatchReceivingFacility = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[6], false, seps) : null;
            BatchCreationDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            BatchSecurity = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            BatchNameIdType = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            BatchComment = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            BatchControlId = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            ReferenceBatchControlId = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            BatchSendingNetworkAddress = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[13], false, seps) : null;
            BatchReceivingNetworkAddress = segments.Length > 14 && segments[14].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[14], false, seps) : null;
            SecurityClassificationTag = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[15], false, seps) : null;
            SecurityHandlingInstructions = segments.Length > 16 && segments[16].Length > 0 ? segments[16].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SpecialAccessRestrictionInstructions = segments.Length > 17 && segments[17].Length > 0 ? segments[17].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 18, Configuration.FieldSeparator),
                                Id,
                                BatchFieldSeparator,
                                BatchEncodingCharacters,
                                BatchSendingApplication?.ToDelimitedString(),
                                BatchSendingFacility?.ToDelimitedString(),
                                BatchReceivingApplication?.ToDelimitedString(),
                                BatchReceivingFacility?.ToDelimitedString(),
                                BatchCreationDateTime?.ToHl7DateTimeString(typeof(BhsSegment), nameof(BatchCreationDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                BatchSecurity,
                                BatchNameIdType,
                                BatchComment,
                                BatchControlId,
                                ReferenceBatchControlId,
                                BatchSendingNetworkAddress?.ToDelimitedString(),
                                BatchReceivingNetworkAddress?.ToDelimitedString(),
                                SecurityClassificationTag?.ToDelimitedString(),
                                SecurityHandlingInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, SecurityHandlingInstructions.Select(x => x.ToDelimitedString())) : null,
                                SpecialAccessRestrictionInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, SpecialAccessRestrictionInstructions) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
