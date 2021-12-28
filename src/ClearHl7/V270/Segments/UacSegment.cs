using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment UAC - User Authentication Credential Segment.
    /// </summary>
    public class UacSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "UAC";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// UAC.1 - User Authentication Credential Type Code.
        /// <para>Suggested: 0615 User Authentication Credential Type Code -&gt; ClearHl7.Codes.V270.CodeUserAuthenticationCredentialTypeCode</para>
        /// </summary>
        public CodedWithExceptions UserAuthenticationCredentialTypeCode { get; set; }

        /// <summary>
        /// UAC.2 - User Authentication Credential.
        /// </summary>
        public EncapsulatedData UserAuthenticationCredential { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            UserAuthenticationCredentialTypeCode = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[1], false, seps) : null;
            UserAuthenticationCredential = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EncapsulatedData>(segments[2], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
