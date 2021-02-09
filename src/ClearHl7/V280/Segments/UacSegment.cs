using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment UAC - User Authentication Credential Segment.
    /// </summary>
    public class UacSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "UAC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// UAC.1 - User Authentication Credential Type Code.
        /// <para>Suggested: 0615 User Authentication Credential Type Code -&gt; ClearHl7.Fhir.Codes.V280.CodeUserAuthenticationCredentialTypeCode</para>
        /// </summary>
        public CodedWithExceptions UserAuthenticationCredentialTypeCode { get; set; }

        /// <summary>
        /// UAC.2 - User Authentication Credential.
        /// </summary>
        public EncapsulatedData UserAuthenticationCredential { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, Configuration.FieldSeparator),
                                Id,
                                UserAuthenticationCredentialTypeCode?.ToDelimitedString(),
                                UserAuthenticationCredential?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}