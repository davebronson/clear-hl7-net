using System;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V280.Types;

namespace ClearHl7.Fhir.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PMT - Payment Information.
    /// </summary>
    public class PmtSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "PMT";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// PMT.1 - Payment/Remittance Advice Number.
        /// </summary>
        public EntityIdentifier PaymentRemittanceAdviceNumber { get; set; }

        /// <summary>
        /// PMT.2 - Payment/Remittance Effective Date/Time.
        /// </summary>
        public DateTime? PaymentRemittanceEffectiveDateTime { get; set; }

        /// <summary>
        /// PMT.3 - Payment/Remittance Expiration Date/Time.
        /// </summary>
        public DateTime? PaymentRemittanceExpirationDateTime { get; set; }

        /// <summary>
        /// PMT.4 - Payment Method.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0570</remarks>
        public CodedWithExceptions PaymentMethod { get; set; }

        /// <summary>
        /// PMT.5 - Payment/Remittance Date/Time.
        /// </summary>
        public DateTime? PaymentRemittanceDateTime { get; set; }

        /// <summary>
        /// PMT.6 - Payment/Remittance Amount.
        /// </summary>
        public CompositePrice PaymentRemittanceAmount { get; set; }

        /// <summary>
        /// PMT.7 - Check Number.
        /// </summary>
        public EntityIdentifier CheckNumber { get; set; }

        /// <summary>
        /// PMT.8 - Payee Bank Identification.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations PayeeBankIdentification { get; set; }

        /// <summary>
        /// PMT.9 - Payee Transit Number.
        /// </summary>
        public string PayeeTransitNumber { get; set; }

        /// <summary>
        /// PMT.10 - Payee Bank Account ID.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit PayeeBankAccountId { get; set; }

        /// <summary>
        /// PMT.11 - Payment Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations PaymentOrganization { get; set; }

        /// <summary>
        /// PMT.12 - ESR-Code-Line.
        /// </summary>
        public string EsrCodeLine { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                PaymentRemittanceAdviceNumber?.ToDelimitedString(),
                                PaymentRemittanceEffectiveDateTime.HasValue ? PaymentRemittanceEffectiveDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PaymentRemittanceExpirationDateTime.HasValue ? PaymentRemittanceExpirationDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PaymentMethod?.ToDelimitedString(),
                                PaymentRemittanceDateTime.HasValue ? PaymentRemittanceDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                PaymentRemittanceAmount?.ToDelimitedString(),
                                CheckNumber?.ToDelimitedString(),
                                PayeeBankIdentification?.ToDelimitedString(),
                                PayeeTransitNumber,
                                PayeeBankAccountId?.ToDelimitedString(),
                                PaymentOrganization?.ToDelimitedString(),
                                EsrCodeLine
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}