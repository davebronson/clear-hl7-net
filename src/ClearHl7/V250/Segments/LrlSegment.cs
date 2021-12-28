using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V250.Types;

namespace ClearHl7.V250.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment LRL - Location Relationship.
    /// </summary>
    public class LrlSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "LRL";

        /// <inheritdoc/>
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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            PrimaryKeyValueLrl = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[1], false, seps) : null;
            SegmentActionCode = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            SegmentUniqueKey = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[3], false, seps) : null;
            LocationRelationshipId = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[4], false, seps) : null;
            OrganizationalLocationRelationshipValue = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(x, false, seps)) : null;
            PatientLocationRelationshipValue = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[6], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
