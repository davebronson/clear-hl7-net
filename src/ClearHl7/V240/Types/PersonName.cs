using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V240.Types
{
    /// <summary>
    /// HL7 Version 2 PN - Person Name.
    /// </summary>
    public class PersonName : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonName"/> class.
        /// </summary>
        public PersonName()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonName"/> class.
        /// </summary>
        /// <param name="familyName">PN.1 - Family Name.</param>
        /// <param name="givenName">PN.2 - Given Name.</param>
        public PersonName(string familyName, string givenName)
        {
            FamilyName = familyName;
            GivenName = givenName;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// PN.1 - Family Name.
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// PN.2 - Given Name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// PN.3 - Second and Further Given Names or Initials Thereof.
        /// </summary>
        public string SecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

        /// <summary>
        /// PN.4 - Suffix.
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// PN.5 - Prefix.
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// PN.6 - Degree.
        /// <para>Suggested: 0360 Degree/License/Certificate -&gt; ClearHl7.Codes.V240.CodeDegreeLicenseCertificate</para>
        /// </summary>
        public string Degree { get; set; }

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
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, separator),
                                FamilyName,
                                GivenName,
                                SecondAndFurtherGivenNamesOrInitialsThereof,
                                Suffix,
                                Prefix,
                                Degree
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
