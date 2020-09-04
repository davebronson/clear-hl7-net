using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// PSS.1 - Provider Product/Service Section Number.
        ///// </summary>
        //public ProviderProductServiceSectionNumber { get; set; }

        ///// <summary>
        ///// PSS.2 - Payer Product/Service Section Number.
        ///// </summary>
        //public PayerProductServiceSectionNumber { get; set; }

        ///// <summary>
        ///// PSS.3 - Product/Service Section Sequence Number.
        ///// </summary>
        //public ProductServiceSectionSequenceNumber { get; set; }

        ///// <summary>
        ///// PSS.4 - Billed Amount.
        ///// </summary>
        //public BilledAmount { get; set; }

        ///// <summary>
        ///// PSS.5 - Section Description or Heading.
        ///// </summary>
        //public SectionDescriptionOrHeading { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}"
                                ).TrimEnd('|');
        }
    }
}