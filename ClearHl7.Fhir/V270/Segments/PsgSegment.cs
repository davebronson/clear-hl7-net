using System;
using ClearHl7.Fhir.V270.Types;

namespace ClearHl7.Fhir.V270.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PSG - Product Service Group.
    /// </summary>
    public class PsgSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PSG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PSG.1 - Provider Product/Service Group Number.
        /// </summary>
        public EntityIdentifier ProviderProductServiceGroupNumber { get; set; }

        /// <summary>
        /// PSG.2 - Payer Product/Service Group Number.
        /// </summary>
        public EntityIdentifier PayerProductServiceGroupNumber { get; set; }

        /// <summary>
        /// PSG.3 - Product/Service Group Sequence Number.
        /// </summary>
        public uint? ProductServiceGroupSequenceNumber { get; set; }

        /// <summary>
        /// PSG.4 - Adjudicate as Group.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
        public string AdjudicateAsGroup { get; set; }

        /// <summary>
        /// PSG.5 - Product/Service Group Billed Amount.
        /// </summary>
        public CompositePrice ProductServiceGroupBilledAmount { get; set; }

        /// <summary>
        /// PSG.6 - Product/Service Group Description.
        /// </summary>
        public string ProductServiceGroupDescription { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}",
                                Id,
                                ProviderProductServiceGroupNumber?.ToDelimitedString(),
                                PayerProductServiceGroupNumber?.ToDelimitedString(),
                                ProductServiceGroupSequenceNumber.HasValue ? ProductServiceGroupSequenceNumber.Value.ToString(culture) : null,
                                AdjudicateAsGroup,
                                ProductServiceGroupBilledAmount?.ToDelimitedString(),
                                ProductServiceGroupDescription
                                ).TrimEnd('|');
        }
    }
}