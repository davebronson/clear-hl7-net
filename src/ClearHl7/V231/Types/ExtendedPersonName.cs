using System;
using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V231.Types
{
    /// <summary>
    /// HL7 Version 2 XPN - Extended Person Name.
    /// </summary>
    public class ExtendedPersonName : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
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
        /// <para>Suggested: 0360 Degree/License/Certificate -&gt; ClearHl7.Codes.V231.CodeDegreeLicenseCertificate</para>
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// XPN.7 - Name Type Code.
        /// <para>Suggested: 0200 Name Type -&gt; ClearHl7.Codes.V231.CodeNameType</para>
        /// </summary>
        public string NameTypeCode { get; set; }

        /// <summary>
        /// XPN.8 - Name Representation Code.
        /// <para>Suggested: 4000 Name/Address Representation -&gt; ClearHl7.Codes.V231.CodeNameAddressRepresentation</para>
        /// </summary>
        public string NameRepresentationCode { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        internal void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] separator = IsSubcomponent ? seps.SubcomponentSeparator : seps.ComponentSeparator;
            string[] segments = delimitedString == null
                ? new string[] { }
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
