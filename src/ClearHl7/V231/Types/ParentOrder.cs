using ClearHl7.Helpers;

namespace ClearHl7.V231.Types
{
    /// <summary>
    /// HL7 Version 2 EIP - Parent Order.
    /// </summary>
    public class ParentOrder : IType
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
                                StringHelper.StringFormatSequence(0, 2, separator),
                                PlacerAssignedIdentifier?.ToDelimitedString(),
                                FillerAssignedIdentifier?.ToDelimitedString()
                                ).TrimEnd(separator.ToCharArray());
        }
    }
}
