using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V271.Types;

namespace ClearHl7.Fhir.V271.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PCE - Patient Charge Cost Center Exceptions.
    /// </summary>
    public class PceSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PCE";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PCE.1 - Set ID - PCE.
        /// </summary>
        public uint? SetIdPce { get; set; }

        /// <summary>
        /// PCE.2 - Cost Center Account Number.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0319</remarks>
        public ExtendedCompositeIdWithCheckDigit CostCenterAccountNumber { get; set; }

        /// <summary>
        /// PCE.3 - Transaction Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0132</remarks>
        public CodedWithExceptions TransactionCode { get; set; }

        /// <summary>
        /// PCE.4 - Transaction amount - unit.
        /// </summary>
        public CompositePrice TransactionAmountUnit { get; set; }
        
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
                                SetIdPce.HasValue ? SetIdPce.Value.ToString(culture) : null,
                                CostCenterAccountNumber?.ToDelimitedString(),
                                TransactionCode?.ToDelimitedString(),
                                TransactionAmountUnit?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}