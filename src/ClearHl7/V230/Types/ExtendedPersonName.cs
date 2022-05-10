using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V230.Types
{
    /// <summary>
    /// HL7 Version 2 XPN - Extended Person Name.
    /// </summary>
    public class ExtendedPersonName : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedPersonName"/> class.
        /// </summary>
        public ExtendedPersonName()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedPersonName"/> class.
        /// </summary>
        /// <param name="familyName">XPN.1 - Family Name.</param>
        /// <param name="givenName">XPN.2 - Given Name.</param>
        public ExtendedPersonName(string familyName, string givenName)
        {
            FamilyName = familyName;
            GivenName = givenName;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// XPN.1 - Family Name.
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// XPN.2 - Given Name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// XPN.3 - Second and Further Given Names or Initials Thereof.
        /// </summary>
        public string SecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

        /// <summary>
        /// XPN.4 - Suffix (e.g., JR or III).
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// XPN.5 - Prefix (e.g., DR).
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// XPN.6 - Degree (e.g., MD).
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// XPN.7 - Name Type Code.
        /// <para>Suggested: 0200 Name Type -&gt; ClearHl7.Codes.V230.CodeNameType</para>
        /// </summary>
        public string NameTypeCode { get; set; }

        /// <summary>
        /// XPN.8 - Name Representation Code.
        /// <para>Suggested: 4000 Name/Address Representation</para>
        /// </summary>
        public string NameRepresentationCode { get; set; }

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

            FamilyName = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            GivenName = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            SecondAndFurtherGivenNamesOrInitialsThereof = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            Suffix = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            Prefix = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            Degree = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            NameTypeCode = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            NameRepresentationCode = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 8, separator),
                                FamilyName,
                                GivenName,
                                SecondAndFurtherGivenNamesOrInitialsThereof,
                                Suffix,
                                Prefix,
                                Degree,
                                NameTypeCode,
                                NameRepresentationCode
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
