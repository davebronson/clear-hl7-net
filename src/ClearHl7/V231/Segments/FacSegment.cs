using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment FAC - Facility.
    /// </summary>
    public class FacSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "FAC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// FAC.1 - Facility ID-FAC.
        /// </summary>
        public EntityIdentifier FacilityIdFac { get; set; }

        /// <summary>
        /// FAC.2 - Facility Type.
        /// <para>Suggested: 0331 Facility Type -&gt; ClearHl7.Codes.V231.CodeFacilityType</para>
        /// </summary>
        public string FacilityType { get; set; }

        /// <summary>
        /// FAC.3 - Facility Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> FacilityAddress { get; set; }

        /// <summary>
        /// FAC.4 - Facility Telecommunication.
        /// </summary>
        public ExtendedTelecommunicationNumber FacilityTelecommunication { get; set; }

        /// <summary>
        /// FAC.5 - Contact Person.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> ContactPerson { get; set; }

        /// <summary>
        /// FAC.6 - Contact Title.
        /// </summary>
        public IEnumerable<string> ContactTitle { get; set; }

        /// <summary>
        /// FAC.7 - Contact Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> ContactAddress { get; set; }

        /// <summary>
        /// FAC.8 - Contact Telecommunication.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> ContactTelecommunication { get; set; }

        /// <summary>
        /// FAC.9 - Signature Authority.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> SignatureAuthority { get; set; }

        /// <summary>
        /// FAC.10 - Signature Authority Title.
        /// </summary>
        public string SignatureAuthorityTitle { get; set; }

        /// <summary>
        /// FAC.11 - Signature Authority Address.
        /// </summary>
        public IEnumerable<ExtendedAddress> SignatureAuthorityAddress { get; set; }

        /// <summary>
        /// FAC.12 - Signature Authority Telecommunication.
        /// </summary>
        public ExtendedTelecommunicationNumber SignatureAuthorityTelecommunication { get; set; }

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

            FacilityIdFac = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[1], false) : null;
            FacilityType = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            FacilityAddress = segments.Length > 3 && segments[3].Length > 0 ? segments[3].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            FacilityTelecommunication = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments[4], false) : null;
            ContactPerson = segments.Length > 5 && segments[5].Length > 0 ? segments[5].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            ContactTitle = segments.Length > 6 && segments[6].Length > 0 ? segments[6].Split(separator) : null;
            ContactAddress = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            ContactTelecommunication = segments.Length > 8 && segments[8].Length > 0 ? segments[8].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(x, false)) : null;
            SignatureAuthority = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            SignatureAuthorityTitle = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            SignatureAuthorityAddress = segments.Length > 11 && segments[11].Length > 0 ? segments[11].Split(separator).Select(x => TypeHelper.Deserialize<ExtendedAddress>(x, false)) : null;
            SignatureAuthorityTelecommunication = segments.Length > 12 && segments[12].Length > 0 ? TypeHelper.Deserialize<ExtendedTelecommunicationNumber>(segments[12], false) : null;
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
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                FacilityIdFac?.ToDelimitedString(),
                                FacilityType,
                                FacilityAddress != null ? string.Join(Configuration.FieldRepeatSeparator, FacilityAddress.Select(x => x.ToDelimitedString())) : null,
                                FacilityTelecommunication?.ToDelimitedString(),
                                ContactPerson != null ? string.Join(Configuration.FieldRepeatSeparator, ContactPerson.Select(x => x.ToDelimitedString())) : null,
                                ContactTitle != null ? string.Join(Configuration.FieldRepeatSeparator, ContactTitle) : null,
                                ContactAddress != null ? string.Join(Configuration.FieldRepeatSeparator, ContactAddress.Select(x => x.ToDelimitedString())) : null,
                                ContactTelecommunication != null ? string.Join(Configuration.FieldRepeatSeparator, ContactTelecommunication.Select(x => x.ToDelimitedString())) : null,
                                SignatureAuthority != null ? string.Join(Configuration.FieldRepeatSeparator, SignatureAuthority.Select(x => x.ToDelimitedString())) : null,
                                SignatureAuthorityTitle,
                                SignatureAuthorityAddress != null ? string.Join(Configuration.FieldRepeatSeparator, SignatureAuthorityAddress.Select(x => x.ToDelimitedString())) : null,
                                SignatureAuthorityTelecommunication?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}