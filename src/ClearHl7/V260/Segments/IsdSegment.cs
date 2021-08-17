using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ISD - Interaction Status Detail.
    /// </summary>
    public class IsdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ISD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ISD.1 - Reference Interaction Number.
        /// </summary>
        public decimal? ReferenceInteractionNumber { get; set; }

        /// <summary>
        /// ISD.2 - Interaction Type Identifier.
        /// <para>Suggested: 0368 Remote Control Command -&gt; ClearHl7.Codes.V260.CodeRemoteControlCommand</para>
        /// </summary>
        public CodedWithExceptions InteractionTypeIdentifier { get; set; }

        /// <summary>
        /// ISD.3 - Interaction Active State.
        /// <para>Suggested: 0387 Command Response -&gt; ClearHl7.Codes.V260.CodeCommandResponse</para>
        /// </summary>
        public CodedWithExceptions InteractionActiveState { get; set; }

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

            ReferenceInteractionNumber = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            InteractionTypeIdentifier = segments.Length > 2 && segments[2].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[2], false) : null;
            InteractionActiveState = segments.Length > 3 && segments[3].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[3], false) : null;
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
                                StringHelper.StringFormatSequence(0, 4, Configuration.FieldSeparator),
                                Id,
                                ReferenceInteractionNumber.HasValue ? ReferenceInteractionNumber.Value.ToString(culture) : null,
                                InteractionTypeIdentifier?.ToDelimitedString(),
                                InteractionActiveState?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}