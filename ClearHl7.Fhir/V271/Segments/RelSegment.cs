using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string SeparabilityIndicator { get; set; }
                
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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