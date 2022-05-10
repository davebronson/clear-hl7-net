using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V250.Types
{
    /// <summary>
    /// HL7 Version 2 HD - Hierarchic Designator.
    /// </summary>
    public class HierarchicDesignator : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchicDesignator"/> class.
        /// </summary>
        public HierarchicDesignator()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchicDesignator"/> class.
        /// </summary>
        /// <param name="namespaceId">HD.1 - Namespace ID.</param>
        public HierarchicDesignator(string namespaceId)
        {
            NamespaceId = namespaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchicDesignator"/> class.
        /// </summary>
        /// <param name="universalId">HD.2 - Universal ID.</param>
        /// <param name="universalIdType">HD.3 - Universal ID Type.</param>
        public HierarchicDesignator(string universalId, string universalIdType)
        {
            UniversalId = universalId;
            UniversalIdType = universalIdType;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// HD.1 - Namespace ID.
        /// <para>Suggested: 0300 Namespace Id</para>
        /// </summary>
        public string NamespaceId { get; set; }

        /// <summary>
        /// HD.2 - Universal ID.
        /// </summary>
        public string UniversalId { get; set; }

        /// <summary>
        /// HD.3 - Universal ID Type.
        /// <para>Suggested: 0301 Universal ID Type -&gt; ClearHl7.Codes.V250.CodeUniversalIdType</para>
        /// </summary>
        public string UniversalIdType { get; set; }

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

            NamespaceId = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            UniversalId = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            UniversalIdType = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 3, separator),
                                NamespaceId,
                                UniversalId,
                                UniversalIdType
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
