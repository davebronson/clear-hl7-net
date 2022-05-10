using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V271.Types
{
    /// <summary>
    /// HL7 Version 2 CNN - Composite Id Number And Name Simplified.
    /// </summary>
    public class CompositeIdNumberAndNameSimplified : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeIdNumberAndNameSimplified"/> class.
        /// </summary>
        public CompositeIdNumberAndNameSimplified()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeIdNumberAndNameSimplified"/> class.
        /// </summary>
        /// <param name="idNumber">CNN.1 - ID Number.</param>
        /// <param name="familyName">CNN.2 - Family Name.</param>
        /// <param name="givenName">CNN.3 - Given Name.</param>
        public CompositeIdNumberAndNameSimplified(string idNumber, string familyName, string givenName)
        {
            IdNumber = idNumber;
            FamilyName = familyName;
            GivenName = givenName;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// CNN.1 - ID Number.
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// CNN.2 - Family Name.
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// CNN.3 - Given Name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// CNN.4 - Second and Further Given Names or Initials Thereof.
        /// </summary>
        public string SecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

        /// <summary>
        /// CNN.5 - Suffix (e.g., JR or III).
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// CNN.6 - Prefix (e.g., DR).
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// CNN.7 - Degree (e.g., MD).
        /// <para>Suggested: 0360 Degree/License/Certificate</para>
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// CNN.8 - Source Table.
        /// <para>Suggested: 0297 Source Table</para>
        /// </summary>
        public string SourceTable { get; set; }

        /// <summary>
        /// CNN.9 - Assigning Authority - Namespace ID.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V271.CodeAssigningAuthority</para>
        /// </summary>
        public string AssigningAuthorityNamespaceId { get; set; }

        /// <summary>
        /// CNN.10 - Assigning Authority - Universal ID.
        /// </summary>
        public string AssigningAuthorityUniversalId { get; set; }

        /// <summary>
        /// CNN.11 - Assigning Authority - Universal ID Type.
        /// <para>Suggested: 0301 Universal ID Type -&gt; ClearHl7.Codes.V271.CodeUniversalIdType</para>
        /// </summary>
        public string AssigningAuthorityUniversalIdType { get; set; }

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
            AssigningAuthorityNamespaceId = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            AssigningAuthorityUniversalId = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            AssigningAuthorityUniversalIdType = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 11, separator),
                                IdNumber,
                                FamilyName,
                                GivenName,
                                SecondAndFurtherGivenNamesOrInitialsThereof,
                                Suffix,
                                Prefix,
                                Degree,
                                SourceTable,
                                AssigningAuthorityNamespaceId,
                                AssigningAuthorityUniversalId,
                                AssigningAuthorityUniversalIdType
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
