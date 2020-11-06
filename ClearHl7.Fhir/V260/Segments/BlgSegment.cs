using System;
using ClearHl7.Fhir.V260.Types;

namespace ClearHl7.Fhir.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment BLG - Billing.
    /// </summary>
    public class BlgSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "BLG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// BLG.1 - When to Charge.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0100</remarks>
        public ChargeCodeAndDate WhenToCharge { get; set; }

        /// <summary>
        /// BLG.2 - Charge Type.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0122</remarks>
        public string ChargeType { get; set; }

        /// <summary>
        /// BLG.3 - Account ID.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit AccountId { get; set; }

        /// <summary>
        /// BLG.4 - Charge Type Reason.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0475</remarks>
        public CodedWithExceptions ChargeTypeReason { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}",
                                Id,
                                WhenToCharge?.ToDelimitedString(),
                                ChargeType,
                                AccountId?.ToDelimitedString(),
                                ChargeTypeReason?.ToDelimitedString()
                                ).TrimEnd('|');
        }
    }
}