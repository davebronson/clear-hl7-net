using System;
using System.Globalization;
using ClearHl7.Helpers;

namespace ClearHl7.V290.Types
{
    /// <summary>
    /// HL7 Version 2 EI - Entity Identifier.
    /// </summary>
    public class EntityIdentifier : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityIdentifier"/> class.
        /// </summary>
        public EntityIdentifier()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityIdentifier"/> class.
        /// </summary>
        /// <param name="entityId">EI.1 - Entity Id.</param>
        public EntityIdentifier(string entityId)
        {
            EntityId = entityId;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// EI.1 - Entity Id.
        /// </summary>
        public string EntityId { get; set; }

        /// <summary>
        /// EI.2 - Namespace ID.
        /// <para>Suggested: 0363 Assigning Authority -&gt; ClearHl7.Codes.V290.CodeAssigningAuthority</para>
        /// </summary>
        public string NamespaceId { get; set; }

        /// <summary>
        /// EI.3 - Universal ID.
        /// </summary>
        public string UniversalId { get; set; }

        /// <summary>
        /// EI.4 - Universal ID Type.
        /// <para>Suggested: 0301 Universal ID Type -&gt; ClearHl7.Codes.V290.CodeUniversalIdType</para>
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

            EntityId = segments.Length > 0 && segments[0].Length > 0 ? segments[0] : null;
            NamespaceId = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            UniversalId = segments.Length > 2 && segments[2].Length > 0 ? segments[2] : null;
            UniversalIdType = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 4, separator),
                                EntityId,
                                NamespaceId,
                                UniversalId,
                                UniversalIdType
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
