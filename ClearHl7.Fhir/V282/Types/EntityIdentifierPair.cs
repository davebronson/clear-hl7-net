using System;

namespace ClearHl7.Fhir.V282.Types
{
    /// <summary>
    /// HL7 Version 2 EIP - Entity Identifier Pair.
    /// </summary>
    public class EntityIdentifierPair
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this instance is a subcomponent of another HL7 component instance.
        /// </summary>
        public bool IsSubcomponent { get; set; }

        /// <summary>
        /// EIP.1 - Placer Assigned Identifier.
        /// </summary>
        public EntityIdentifier PlacerAssignedIdentifier { get; set; }

        /// <summary>
        /// EIP.2 - Filler Assigned Identifier.
        /// </summary>
        public EntityIdentifier FillerAssignedIdentifier { get; set; }
    }
}
