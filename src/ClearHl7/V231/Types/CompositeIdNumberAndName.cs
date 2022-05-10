using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V231.Types
{
    /// <summary>
    /// HL7 Version 2 CN - Composite Id Number And Name.
    /// </summary>
    public class CompositeIdNumberAndName : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeIdNumberAndName"/> class.
        /// </summary>
        public CompositeIdNumberAndName()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeIdNumberAndName"/> class.
        /// </summary>
        /// <param name="idNumber">CN.1 - ID Number.</param>
        public CompositeIdNumberAndName(string idNumber)
        {
            IdNumber = idNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeIdNumberAndName"/> class.
        /// </summary>
        /// <param name="idNumber">CN.1 - ID Number.</param>
        /// <param name="familyName">CN.2 - Family Name.</param>
        /// <param name="givenName">CN.3 - Given Name.</param>
        public CompositeIdNumberAndName(string idNumber, string familyName, string givenName)
        {
            IdNumber = idNumber;
            FamilyName = familyName;
            GivenName = givenName;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CN.1 - ID Number.
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// CN.2 - Family Name.
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// CN.3 - Given Name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// CN.4 - Second and Further Given Names or Initials Thereof.
        /// </summary>
        public string SecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

        /// <summary>
        /// CN.5 - Suffix (e.g., JR or III).
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// CN.6 - Prefix (e.g., DR).
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// CN.7 - Degree (e.g., MD).
        /// <para>Suggested: 0360 Degree/License/Certificate -&gt; ClearHl7.Codes.V231.CodeDegreeLicenseCertificate</para>
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// CN.8 - Source Table.
        /// <para>Suggested: 0297 Source Table</para>
        /// </summary>
        public string SourceTable { get; set; }

        /// <summary>
        /// CN.9 - Assigning Authority.
        /// </summary>
        public HierarchicDesignator AssigningAuthority { get; set; }

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

            IdNumber = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            FamilyName = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            GivenName = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            SecondAndFurtherGivenNamesOrInitialsThereof = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            Suffix = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            Prefix = segments.Length > 5 && segments[5].Length > 0 ? segments[5] : null;
            Degree = segments.Length > 6 && segments[6].Length > 0 ? segments[6] : null;
            SourceTable = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            AssigningAuthority = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<HierarchicDesignator>(segments[8], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, separator),
                                IdNumber,
                                FamilyName,
                                GivenName,
                                SecondAndFurtherGivenNamesOrInitialsThereof,
                                Suffix,
                                Prefix,
                                Degree,
                                SourceTable,
                                AssigningAuthority?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
