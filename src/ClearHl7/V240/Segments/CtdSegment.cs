using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
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
        public IEnumerable<ExtendedAddress> ContactAddress { get; set; }

        /// <summary>
        /// CTD.4 - Contact Location.
        /// </summary>
        public PersonLocation ContactLocation { get; set; }

        /// <summary>
        /// CTD.5 - Contact Communication Information.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> ContactCommunicationInformation { get; set; }

        /// <summary>
        /// CTD.6 - Preferred Method of Contact.
        /// <para>Suggested: 0185 Preferred Method Of Contact -&gt; ClearHl7.Codes.V240.CodePreferredMethodOfContact</para>
        /// </summary>
        public CodedElement PreferredMethodOfContact { get; set; }

        /// <summary>
        /// CTD.7 - Contact Identifiers.
        /// </summary>
        public IEnumerable<string> ContactIdentifiers { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ContactRole = segments.Length > 1 && segments[1].Length > 0 ? segments[1].Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ContactName = segments.Length > 2 && segments[2].Length > 0 ? segments[2].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedPersonName>(x, false)) : null;
            ContactAddress = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            ContactLocation = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<PersonLocation>(segments[4], false) : null;
            ContactCommunicationInformation = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            PreferredMethodOfContact = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CodedElement>(segments[6], false) : null;
            ContactIdentifiers = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(separator) : null;
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
                                StringHelper.StringFormatSequence(0, 8, Configuration.FieldSeparator),
                                Id,
                                ContactRole != null ? string.Join(Configuration.FieldRepeatSeparator, ContactRole.Select(x => x.ToDelimitedString())) : null,
                                ContactName != null ? string.Join(Configuration.FieldRepeatSeparator, ContactName.Select(x => x.ToDelimitedString())) : null,
                                ContactAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ContactAddress.Select(x => x.ToDelimitedString())) : null,
                                ContactLocation?.ToDelimitedString(),
                                ContactCommunicationInformation != null ? string.Join(Configuration.FieldRepeatSeparator, ContactCommunicationInformation.Select(x => x.ToDelimitedString())) : null,
                                PreferredMethodOfContact?.ToDelimitedString(),
                                ContactIdentifiers != null ? string.Join(Configuration.FieldRepeatSeparator, ContactIdentifiers) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}