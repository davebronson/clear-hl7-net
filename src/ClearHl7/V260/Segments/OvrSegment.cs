using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
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
        /// <para>Suggested: 0518 Override Type -&gt; ClearHl7.Codes.V260.CodeOverrideType</para>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            BusinessRuleOverrideType = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            BusinessRuleOverrideCode = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            OverrideComments = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<Text>(segments[3], false, seps) : null;
            OverrideEnteredBy = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[4], false, seps) : null;
            OverrideAuthorizedBy = segments.Length > 5 && segments[5].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[5], false, seps) : null;
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