using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V270.Types;

namespace ClearHl7.Fhir.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OVR - Override Segment.
    /// </summary>
    public class OvrSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "OVR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// OVR.1 - Business Rule Override Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0518</remarks>
        public CodedWithExceptions BusinessRuleOverrideType { get; set; }

        /// <summary>
        /// OVR.2 - Business Rule Override Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0521</remarks>
        public CodedWithExceptions BusinessRuleOverrideCode { get; set; }

        /// <summary>
        /// OVR.3 - Override Comments.
        /// </summary>
        public Text OverrideComments { get; set; }

        /// <summary>
        /// OVR.4 - Override Entered By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons OverrideEnteredBy { get; set; }

        /// <summary>
        /// OVR.5 - Override Authorized By.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons OverrideAuthorizedBy { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                BusinessRuleOverrideType?.ToDelimitedString(),
                                BusinessRuleOverrideCode?.ToDelimitedString(),
                                OverrideComments?.ToDelimitedString(),
                                OverrideEnteredBy?.ToDelimitedString(),
                                OverrideAuthorizedBy?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}