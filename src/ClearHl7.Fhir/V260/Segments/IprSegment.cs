using System;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V260.Types;

namespace ClearHl7.Fhir.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IPR - Invoice Processing Results.
    /// </summary>
    public class IprSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "IPR";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// IPR.1 - IPR Identifier.
        /// </summary>
        public EntityIdentifier IprIdentifier { get; set; }

        /// <summary>
        /// IPR.2 - Provider Cross Reference Identifier.
        /// </summary>
        public EntityIdentifier ProviderCrossReferenceIdentifier { get; set; }

        /// <summary>
        /// IPR.3 - Payer Cross Reference Identifier.
        /// </summary>
        public EntityIdentifier PayerCrossReferenceIdentifier { get; set; }

        /// <summary>
        /// IPR.4 - IPR Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0571</remarks>
        public CodedWithExceptions IprStatus { get; set; }

        /// <summary>
        /// IPR.5 - IPR Date/Time.
        /// </summary>
        public DateTime? IprDateTime { get; set; }

        /// <summary>
        /// IPR.6 - Adjudicated/Paid Amount.
        /// </summary>
        public CompositePrice AdjudicatedPaidAmount { get; set; }

        /// <summary>
        /// IPR.7 - Expected Payment Date/Time.
        /// </summary>
        public DateTime? ExpectedPaymentDateTime { get; set; }

        /// <summary>
        /// IPR.8 - IPR Checksum.
        /// </summary>
        public string IprChecksum { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 9, Configuration.FieldSeparator),
                                Id,
                                IprIdentifier?.ToDelimitedString(),
                                ProviderCrossReferenceIdentifier?.ToDelimitedString(),
                                PayerCrossReferenceIdentifier?.ToDelimitedString(),
                                IprStatus?.ToDelimitedString(),
                                IprDateTime.HasValue ? IprDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                AdjudicatedPaidAmount?.ToDelimitedString(),
                                ExpectedPaymentDateTime.HasValue ? ExpectedPaymentDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                IprChecksum
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}