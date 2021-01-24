using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BHS - Batch Header.
    /// </summary>
    public class BhsSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "BHS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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
                                BatchCreationDateTime.HasValue ? BatchCreationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
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