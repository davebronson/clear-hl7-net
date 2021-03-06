﻿using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment LRL - Location Relationship.
    /// </summary>
    public class LrlSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "LRL";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// LRL.1 - Primary Key Value - LRL.
        /// </summary>
        public PersonLocation PrimaryKeyValueLrl { get; set; }

        /// <summary>
        /// LRL.2 - Segment Action Code.
        /// <para>Suggested: 0206 Segment Action Code -&gt; ClearHl7.Codes.V250.CodeSegmentActionCode</para>
        /// </summary>
        public string SegmentActionCode { get; set; }

        /// <summary>
        /// LRL.3 - Segment Unique Key.
        /// </summary>
        public EntityIdentifier SegmentUniqueKey { get; set; }

        /// <summary>
        /// LRL.4 - Location Relationship ID.
        /// <para>Suggested: 0325 Location Relationship ID -&gt; ClearHl7.Codes.V250.CodeLocationRelationshipId</para>
        /// </summary>
        public CodedElement LocationRelationshipId { get; set; }

        /// <summary>
        /// LRL.5 - Organizational Location Relationship Value.
        /// </summary>
        public IEnumerable<ExtendedCompositeNameAndIdNumberForOrganizations> OrganizationalLocationRelationshipValue { get; set; }

        /// <summary>
        /// LRL.6 - Patient Location Relationship Value.
        /// </summary>
        public PersonLocation PatientLocationRelationshipValue { get; set; }
        
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
                                PrimaryKeyValueLrl?.ToDelimitedString(),
                                SegmentActionCode,
                                SegmentUniqueKey?.ToDelimitedString(),
                                LocationRelationshipId?.ToDelimitedString(),
                                OrganizationalLocationRelationshipValue != null ? string.Join(Configuration.FieldRepeatSeparator, OrganizationalLocationRelationshipValue.Select(x => x.ToDelimitedString())) : null,
                                PatientLocationRelationshipValue?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}