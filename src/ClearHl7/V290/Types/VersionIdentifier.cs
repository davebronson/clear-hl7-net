using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 VID - Version Identifier.
    /// </summary>
    public class VersionIdentifier : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// VID.1 - Version ID.
        /// <para>Suggested: 0104 Version ID -&gt; ClearHl7.Codes.V290.CodeVersionId</para>
        /// </summary>
        public string VersionId { get; set; }

        /// <summary>
        /// VID.2 - Internationalization Code.
        /// <para>Suggested: 0399 Country Code -&gt; https://www.iso.org/iso-3166-country-codes.html</para>
        /// </summary>
        public CodedWithExceptions InternationalizationCode { get; set; }

        /// <summary>
        /// VID.3 - International Version ID.
        /// </summary>
        public CodedWithExceptions InternationalVersionId { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;
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
