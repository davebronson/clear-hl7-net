using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// PSG.1 - Provider Product/Service Group Number.
        ///// </summary>
        //public ProviderProductServiceGroupNumber { get; set; }

        ///// <summary>
        ///// PSG.2 - Payer Product/Service Group Number.
        ///// </summary>
        //public PayerProductServiceGroupNumber { get; set; }

        ///// <summary>
        ///// PSG.3 - Product/Service Group Sequence Number.
        ///// </summary>
        //public ProductServiceGroupSequenceNumber { get; set; }

        ///// <summary>
        ///// PSG.4 - Adjudicate as Group.
        ///// </summary>
        //public AdjudicateAsGroup { get; set; }

        ///// <summary>
        ///// PSG.5 - Product/Service Group Billed Amount.
        ///// </summary>
        //public ProductServiceGroupBilledAmount { get; set; }

        ///// <summary>
        ///// PSG.6 - Product/Service Group Description.
        ///// </summary>
        //public ProductServiceGroupDescription { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}"
                                ).TrimEnd('|');
        }
    }
}