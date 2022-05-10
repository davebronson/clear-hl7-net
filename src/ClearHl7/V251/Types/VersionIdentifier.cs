using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V251.Types
{
    /// <summary>
    /// HL7 Version 2 VID - Version Identifier.
    /// </summary>
    public class VersionIdentifier : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionIdentifier"/> class.
        /// </summary>
        public VersionIdentifier()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionIdentifier"/> class.
        /// </summary>
        /// <param name="versionId">VID.1 - Version ID.</param>
        public VersionIdentifier(string versionId)
        {
            VersionId = versionId;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// VID.1 - Version ID.
        /// <para>Suggested: 0104 Version ID -&gt; ClearHl7.Codes.V251.CodeVersionId</para>
        /// </summary>
        public string VersionId { get; set; }

        /// <summary>
        /// VID.2 - Internationalization Code.
        /// <para>Suggested: 0399 Country Code -&gt; https://www.iso.org/iso-3166-country-codes.html</para>
        /// </summary>
        public CodedElement InternationalizationCode { get; set; }

        /// <summary>
        /// VID.3 - International Version ID.
        /// </summary>
        public CodedElement InternationalVersionId { get; set; }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(separator, StringSplitOptions.None);

            VersionId = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            InternationalizationCode = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[1], true, seps) : null;
            InternationalVersionId = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[2], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                VersionId,
                                InternationalizationCode?.ToDelimitedString(),
                                InternationalVersionId?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
