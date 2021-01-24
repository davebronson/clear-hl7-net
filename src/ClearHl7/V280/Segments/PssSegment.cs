using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PSS - Product Service Section.
    /// </summary>
    public class PssSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PSS";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PSS.1 - Provider Product/Service Section Number.
        /// </summary>
        public EntityIdentifier ProviderProductServiceSectionNumber { get; set; }

        /// <summary>
        /// PSS.2 - Payer Product/Service Section Number.
        /// </summary>
        public EntityIdentifier PayerProductServiceSectionNumber { get; set; }

        /// <summary>
        /// PSS.3 - Product/Service Section Sequence Number.
        /// </summary>
        public uint? ProductServiceSectionSequenceNumber { get; set; }

        /// <summary>
        /// PSS.4 - Billed Amount.
        /// </summary>
        public CompositePrice BilledAmount { get; set; }

        /// <summary>
        /// PSS.5 - Section Description or Heading.
        /// </summary>
        public string SectionDescriptionOrHeading { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 6, Configuration.FieldSeparator),
                                Id,
                                ProviderProductServiceSectionNumber?.ToDelimitedString(),
                                PayerProductServiceSectionNumber?.ToDelimitedString(),
                                ProductServiceSectionSequenceNumber.HasValue ? ProductServiceSectionSequenceNumber.Value.ToString(culture) : null,
                                BilledAmount?.ToDelimitedString(),
                                SectionDescriptionOrHeading
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}