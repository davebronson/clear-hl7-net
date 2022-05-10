using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment OVR - Override Segment.
    /// </summary>
    public class OvrSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OvrSegment"/> class.
        /// </summary>
        public OvrSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OvrSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public OvrSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "OVR";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// OVR.1 - Business Rule Override Type.
        /// <para>Suggested: 0518 Override Type -&gt; ClearHl7.Codes.V290.CodeOverrideType</para>
        /// </summary>
        public CodedWithExceptions BusinessRuleOverrideType { get; set; }

        /// <summary>
        /// OVR.2 - Business Rule Override Code.
        /// <para>Suggested: 0521 Override Code</para>
        /// </summary>
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

            BusinessRuleOverrideType = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            BusinessRuleOverrideCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            OverrideComments = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<Text>(segments[3], false, seps) : null;
            OverrideEnteredBy = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[4], false, seps) : null;
            OverrideAuthorizedBy = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[5], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
