using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment REL - Clinical Relationship Segment.
    /// </summary>
    public class RelSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "REL";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// REL.1 - Set ID -REL.
        /// </summary>
        public uint? SetIdRel { get; set; }

        /// <summary>
        /// REL.2 - Relationship Type.
        /// </summary>
        public CodedWithExceptions RelationshipType { get; set; }

        /// <summary>
        /// REL.3 - This Relationship Instance Identifier.
        /// </summary>
        public EntityIdentifier ThisRelationshipInstanceIdentifier { get; set; }

        /// <summary>
        /// REL.4 - Source Information Instance Identifier.
        /// </summary>
        public EntityIdentifier SourceInformationInstanceIdentifier { get; set; }

        /// <summary>
        /// REL.5 - Target Information Instance Identifier.
        /// </summary>
        public EntityIdentifier TargetInformationInstanceIdentifier { get; set; }

        /// <summary>
        /// REL.6 - Asserting Entity Instance ID.
        /// </summary>
        public EntityIdentifier AssertingEntityInstanceId { get; set; }

        /// <summary>
        /// REL.7 - Asserting Person.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons AssertingPerson { get; set; }

        /// <summary>
        /// REL.8 - Asserting Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations AssertingOrganization { get; set; }

        /// <summary>
        /// REL.9 - Assertor Address.
        /// </summary>
        public ExtendedAddress AssertorAddress { get; set; }

        /// <summary>
        /// REL.10 - Assertor Contact.
        /// </summary>
        public ExtendedTelecommunicationNumber AssertorContact { get; set; }

        /// <summary>
        /// REL.11 - Assertion Date Range.
        /// </summary>
        public DateTimeRange AssertionDateRange { get; set; }

        /// <summary>
        /// REL.12 - Negation Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string NegationIndicator { get; set; }

        /// <summary>
        /// REL.13 - Certainty of Relationship.
        /// </summary>
        public CodedWithExceptions CertaintyOfRelationship { get; set; }

        /// <summary>
        /// REL.14 - Priority No.
        /// </summary>
        public decimal? PriorityNo { get; set; }

        /// <summary>
        /// REL.15 - Priority  Sequence No (rel preference for consideration).
        /// </summary>
        public decimal? PrioritySequenceNoRelPreferenceForConsideration { get; set; }

        /// <summary>
        /// REL.16 - Separability Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string SeparabilityIndicator { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdRel = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableUInt() : null;
            RelationshipType = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[2], false) : null;
            ThisRelationshipInstanceIdentifier = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[3], false) : null;
            SourceInformationInstanceIdentifier = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[4], false) : null;
            TargetInformationInstanceIdentifier = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[5], false) : null;
            AssertingEntityInstanceId = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[6], false) : null;
            AssertingPerson = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[7], false) : null;
            AssertingOrganization = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[8], false) : null;
            AssertorAddress = segments.Length > 9 && segments[9].Length > 0 ? TypeHelper.Deserialize<ExtendedAddress>(segments[9], false) : null;
            AssertorContact = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments[10], false) : null;
            AssertionDateRange = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<DateTimeRange>(segments[11], false) : null;
            NegationIndicator = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            CertaintyOfRelationship = segments.Length > 13 && segments[13].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[13], false) : null;
            PriorityNo = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDecimal() : null;
            PrioritySequenceNoRelPreferenceForConsideration = segments.Length > 15 && segments[15].Length > 0 ? segments[15].ToNullableDecimal() : null;
            SeparabilityIndicator = segments.Length > 16 && segments[16].Length > 0 ? segments[16] : null;
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
                                StringHelper.StringFormatSequence(0, 17, Configuration.FieldSeparator),
                                Id,
                                SetIdRel.HasValue ? SetIdRel.Value.ToString(culture) : null,
                                RelationshipType?.ToDelimitedString(),
                                ThisRelationshipInstanceIdentifier?.ToDelimitedString(),
                                SourceInformationInstanceIdentifier?.ToDelimitedString(),
                                TargetInformationInstanceIdentifier?.ToDelimitedString(),
                                AssertingEntityInstanceId?.ToDelimitedString(),
                                AssertingPerson?.ToDelimitedString(),
                                AssertingOrganization?.ToDelimitedString(),
                                AssertorAddress?.ToDelimitedString(),
                                AssertorContact?.ToDelimitedString(),
                                AssertionDateRange?.ToDelimitedString(),
                                NegationIndicator,
                                CertaintyOfRelationship?.ToDelimitedString(),
                                PriorityNo.HasValue ? PriorityNo.Value.ToString(Consts.NumericFormat, culture) : null,
                                PrioritySequenceNoRelPreferenceForConsideration.HasValue ? PrioritySequenceNoRelPreferenceForConsideration.Value.ToString(Consts.NumericFormat, culture) : null,
                                SeparabilityIndicator
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}