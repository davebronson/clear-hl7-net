using System.Linq;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 CNN - Composite Id Number And Name Simplified.
    /// </summary>
    public class CompositeIdNumberAndNameSimplified : IType
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
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
        /// <para>Suggested: 0360 Degree/License/Certificate -&gt; ClearHl7.Codes.V290.CodeDegreeLicenseCertificate</para>
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// CNN.8 - Source Table.
        /// <para>Suggested: 0297 Source Table</para>
        /// </summary>
        public string SourceTable { get; set; }

        /// <summary>
        /// CNN.9 - Assigning Authority - Namespace ID.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V290.CodeAssigningAuthority</para>
        /// </summary>
        public string AssigningAuthorityNamespaceId { get; set; }

        /// <summary>
        /// CNN.10 - Assigning Authority - Universal ID.
        /// </summary>
        public string AssigningAuthorityUniversalId { get; set; }

        /// <summary>
        /// CNN.11 - Assigning Authority - Universal ID Type.
        /// <para>Suggested: 0301 Universal ID Type -&gt; ClearHl7.Codes.V290.CodeUniversalIdType</para>
        /// </summary>
        public string AssigningAuthorityUniversalIdType { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public CompositeIdNumberAndNameSimplified FromDelimitedString(string delimitedString)
        {
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(separator.ToCharArray());

            IdNumber = segments.ElementAtOrDefault(0);
            FamilyName = segments.ElementAtOrDefault(1);
            GivenName = segments.ElementAtOrDefault(2);
            SecondAndFurtherGivenNamesOrInitialsThereof = segments.ElementAtOrDefault(3);
            Suffix = segments.ElementAtOrDefault(4);
            Prefix = segments.ElementAtOrDefault(5);
            Degree = segments.ElementAtOrDefault(6);
            SourceTable = segments.ElementAtOrDefault(7);
            AssigningAuthorityNamespaceId = segments.ElementAtOrDefault(8);
            AssigningAuthorityUniversalId = segments.ElementAtOrDefault(9);
            AssigningAuthorityUniversalIdType = segments.ElementAtOrDefault(10);

            return this;
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
