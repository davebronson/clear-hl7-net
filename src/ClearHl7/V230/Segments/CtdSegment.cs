using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment CTD - Contact Data.
    /// </summary>
    public class CtdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "CTD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// CTD.1 - Contact Role.
        /// <para>Suggested: 0131 Contact Role</para>
        /// </summary>
        public IEnumerable<CodedElement> ContactRole { get; set; }

        /// <summary>
        /// CTD.2 - Contact Name.
        /// </summary>
        public IEnumerable<ExtendedPersonName> ContactName { get; set; }

        /// <summary>
        /// CTD.3 - Contact Address.
        /// </summary>
        public ExtendedAddress ContactAddress { get; set; }

        /// <summary>
        /// CTD.4 - Contact Location.
        /// </summary>
        public EntityIdentifier ContactLocation { get; set; }

        /// <summary>
        /// CTD.5 - Contact Communication Information.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> ContactCommunicationInformation { get; set; }

        /// <summary>
        /// CTD.6 - Preferred Method of Contact.
        /// <para>Suggested: 0185 Preferred Method Of Contact -&gt; ClearHl7.Codes.V230.CodePreferredMethodOfContact</para>
        /// </summary>
        public CodedElement PreferredMethodOfContact { get; set; }

        /// <summary>
        /// CTD.7 - Contact Identifiers.
        /// </summary>
        public IEnumerable<string> ContactIdentifiers { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                ContactRole != null ? string.Join(Configuration.FieldRepeatSeparator, ContactRole.Select(x => x.ToDelimitedString())) : null,
                                ContactName != null ? string.Join(Configuration.FieldRepeatSeparator, ContactName.Select(x => x.ToDelimitedString())) : null,
                                ContactAddress?.ToDelimitedString(),
                                ContactLocation?.ToDelimitedString(),
                                ContactCommunicationInformation != null ? string.Join(Configuration.FieldRepeatSeparator, ContactCommunicationInformation.Select(x => x.ToDelimitedString())) : null,
                                PreferredMethodOfContact?.ToDelimitedString(),
                                ContactIdentifiers != null ? string.Join(Configuration.FieldRepeatSeparator, ContactIdentifiers) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}