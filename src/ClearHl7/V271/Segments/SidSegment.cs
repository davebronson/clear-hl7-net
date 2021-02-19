using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment SID - Substance Identifier.
    /// </summary>
    public class SidSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "SID";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// SID.1 - Application/Method Identifier.
        /// </summary>
        public CodedWithExceptions ApplicationMethodIdentifier { get; set; }

        /// <summary>
        /// SID.2 - Substance Lot Number.
        /// </summary>
        public string SubstanceLotNumber { get; set; }

        /// <summary>
        /// SID.3 - Substance Container Identifier.
        /// </summary>
        public string SubstanceContainerIdentifier { get; set; }

        /// <summary>
        /// SID.4 - Substance Manufacturer Identifier.
        /// <para>Suggested: 0385 Manufacturer Identifier</para>
        /// </summary>
        public CodedWithExceptions SubstanceManufacturerIdentifier { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 5, Configuration.FieldSeparator),
                                Id,
                                ApplicationMethodIdentifier?.ToDelimitedString(),
                                SubstanceLotNumber,
                                SubstanceContainerIdentifier,
                                SubstanceManufacturerIdentifier?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}