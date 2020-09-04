using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// REL.1 - Set ID -REL.
        ///// </summary>
        //public SetIdRel { get; set; }

        ///// <summary>
        ///// REL.2 - Relationship Type.
        ///// </summary>
        //public RelationshipType { get; set; }

        ///// <summary>
        ///// REL.3 - This Relationship Instance Identifier.
        ///// </summary>
        //public ThisRelationshipInstanceIdentifier { get; set; }

        ///// <summary>
        ///// REL.4 - Source Information Instance Identifier.
        ///// </summary>
        //public SourceInformationInstanceIdentifier { get; set; }

        ///// <summary>
        ///// REL.5 - Target Information Instance Identifier.
        ///// </summary>
        //public TargetInformationInstanceIdentifier { get; set; }

        ///// <summary>
        ///// REL.6 - Asserting Entity Instance ID.
        ///// </summary>
        //public AssertingEntityInstanceId { get; set; }

        ///// <summary>
        ///// REL.7 - Asserting Person.
        ///// </summary>
        //public AssertingPerson { get; set; }

        ///// <summary>
        ///// REL.8 - Asserting Organization.
        ///// </summary>
        //public AssertingOrganization { get; set; }

        ///// <summary>
        ///// REL.9 - Assertor Address.
        ///// </summary>
        //public AssertorAddress { get; set; }

        ///// <summary>
        ///// REL.10 - Assertor Contact.
        ///// </summary>
        //public AssertorContact { get; set; }

        ///// <summary>
        ///// REL.11 - Assertion Date Range.
        ///// </summary>
        //public AssertionDateRange { get; set; }

        ///// <summary>
        ///// REL.12 - Negation Indicator.
        ///// </summary>
        //public NegationIndicator { get; set; }

        ///// <summary>
        ///// REL.13 - Certainty of Relationship.
        ///// </summary>
        //public CertaintyOfRelationship { get; set; }

        ///// <summary>
        ///// REL.14 - Priority No.
        ///// </summary>
        //public PriorityNo { get; set; }

        ///// <summary>
        ///// REL.15 - Priority  Sequence No (rel preference for consideration).
        ///// </summary>
        //public PrioritySequenceNoRelPreferenceForConsideration { get; set; }

        ///// <summary>
        ///// REL.16 - Separability Indicator.
        ///// </summary>
        //public SeparabilityIndicator { get; set; }
                
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}"
                                ).TrimEnd('|');
        }
    }
}