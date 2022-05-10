using System;
using System.Globalization;
using ClearHl7.Helpers;
using ClearHl7.Serialization;

namespace ClearHl7.V270.Types
{
    /// <summary>
    /// HL7 Version 2 EIP - Entity Identifier Pair.
    /// </summary>
    public class EntityIdentifierPair : IType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityIdentifierPair"/> class.
        /// </summary>
        public EntityIdentifierPair()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityIdentifierPair"/> class.
        /// </summary>
        /// <param name="placerAssignedIdentifier">EIP.1 - Placer Assigned Identifier.</param>
        public EntityIdentifierPair(EntityIdentifier placerAssignedIdentifier)
        {
            PlacerAssignedIdentifier = placerAssignedIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityIdentifierPair"/> class.
        /// </summary>
        /// <param name="placerAssignedIdentifier">EIP.1 - Placer Assigned Identifier.</param>
        /// <param name="fillerAssignedIdentifier">EIP.2 - Filler Assigned Identifier.</param>
        public EntityIdentifierPair(EntityIdentifier placerAssignedIdentifier, EntityIdentifier fillerAssignedIdentifier)
        {
            PlacerAssignedIdentifier = placerAssignedIdentifier;
            FillerAssignedIdentifier = fillerAssignedIdentifier;
        }

        /// <inheritdoc/>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// EIP.1 - Placer Assigned Identifier.
        /// </summary>
        public EntityIdentifier PlacerAssignedIdentifier { get; set; }

        /// <summary>
        /// EIP.2 - Filler Assigned Identifier.
        /// </summary>
        public EntityIdentifier FillerAssignedIdentifier { get; set; }

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

            PlacerAssignedIdentifier = segments.Length > 0 && segments[0].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[0], true, seps) : null;
            FillerAssignedIdentifier = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], true, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string separator = IsSubcomponent ? Configuration.SubcomponentSeparator : Configuration.ComponentSeparator;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 2, separator),
                                PlacerAssignedIdentifier?.ToDelimitedString(),
                                FillerAssignedIdentifier?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
