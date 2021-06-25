using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        /// <para>Suggested: 0948 Relationship Type</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string SeparabilityIndicator { get; set; }

        /// <summary>
        /// REL.17 - Source Information Instance Object Type.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V290.CodeIdentifierType</para>
        /// </summary>
        public string SourceInformationInstanceObjectType { get; set; }

        /// <summary>
        /// REL.18 - Target Information Instance Object Type.
        /// <para>Suggested: 0203 Identifier Type -&gt; ClearHl7.Codes.V290.CodeIdentifierType</para>
        /// </summary>
        public string TargetInformationInstanceObjectType { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public RelSegment FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            SetIdRel = segments.ElementAtOrDefault(1)?.ToNullableUInt();
            RelationshipType = segments.Length > 2 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(2)) : null;
            ThisRelationshipInstanceIdentifier = segments.Length > 3 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(3)) : null;
            SourceInformationInstanceIdentifier = segments.Length > 4 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(4)) : null;
            TargetInformationInstanceIdentifier = segments.Length > 5 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(5)) : null;
            AssertingEntityInstanceId = segments.Length > 6 ? new EntityIdentifier().FromDelimitedString(segments.ElementAtOrDefault(6)) : null;
            AssertingPerson = segments.Length > 7 ? new ExtendedCompositeIdNumberAndNameForPersons().FromDelimitedString(segments.ElementAtOrDefault(7)) : null;
            AssertingOrganization = segments.Length > 8 ? new ExtendedCompositeNameAndIdNumberForOrganizations().FromDelimitedString(segments.ElementAtOrDefault(8)) : null;
            AssertorAddress = segments.Length > 9 ? new ExtendedAddress().FromDelimitedString(segments.ElementAtOrDefault(9)) : null;
            AssertorContact = segments.Length > 10 ? new ExtendedTelecommunicationNumber().FromDelimitedString(segments.ElementAtOrDefault(10)) : null;
            AssertionDateRange = segments.Length > 11 ? new DateTimeRange().FromDelimitedString(segments.ElementAtOrDefault(11)) : null;
            NegationIndicator = segments.ElementAtOrDefault(12);
            CertaintyOfRelationship = segments.Length > 13 ? new CodedWithExceptions().FromDelimitedString(segments.ElementAtOrDefault(13)) : null;
            PriorityNo = segments.ElementAtOrDefault(14)?.ToNullableDecimal();
            PrioritySequenceNoRelPreferenceForConsideration = segments.ElementAtOrDefault(15)?.ToNullableDecimal();
            SeparabilityIndicator = segments.ElementAtOrDefault(16);
            SourceInformationInstanceObjectType = segments.ElementAtOrDefault(17);
            TargetInformationInstanceObjectType = segments.ElementAtOrDefault(18);
            
            return this;
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
                                StringHelper.StringFormatSequence(0, 19, Configuration.FieldSeparator),
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
                                SeparabilityIndicator,
                                SourceInformationInstanceObjectType,
                                TargetInformationInstanceObjectType
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}