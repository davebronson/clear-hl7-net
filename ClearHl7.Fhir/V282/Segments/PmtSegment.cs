using System;

namespace ClearHl7.Fhir.V282.Segments
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

        ///// <summary>
        ///// PMT.1 - Payment/Remittance Advice Number.
        ///// </summary>
        //public PaymentRemittanceAdviceNumber { get; set; }

        ///// <summary>
        ///// PMT.2 - Payment/Remittance Effective Date/Time.
        ///// </summary>
        //public PaymentRemittanceEffectiveDateTime { get; set; }

        ///// <summary>
        ///// PMT.3 - Payment/Remittance Expiration Date/Time.
        ///// </summary>
        //public PaymentRemittanceExpirationDateTime { get; set; }

        ///// <summary>
        ///// PMT.4 - Payment Method.
        ///// </summary>
        //public PaymentMethod { get; set; }

        ///// <summary>
        ///// PMT.5 - Payment/Remittance Date/Time.
        ///// </summary>
        //public PaymentRemittanceDateTime { get; set; }

        ///// <summary>
        ///// PMT.6 - Payment/Remittance Amount.
        ///// </summary>
        //public PaymentRemittanceAmount { get; set; }

        ///// <summary>
        ///// PMT.7 - Check Number.
        ///// </summary>
        //public CheckNumber { get; set; }

        ///// <summary>
        ///// PMT.8 - Payee Bank Identification.
        ///// </summary>
        //public PayeeBankIdentification { get; set; }

        ///// <summary>
        ///// PMT.9 - Payee Transit Number.
        ///// </summary>
        //public PayeeTransitNumber { get; set; }

        ///// <summary>
        ///// PMT.10 - Payee Bank Account ID.
        ///// </summary>
        //public PayeeBankAccountId { get; set; }

        ///// <summary>
        ///// PMT.11 - Payment Organization.
        ///// </summary>
        //public PaymentOrganization { get; set; }

        ///// <summary>
        ///// PMT.12 - ESR-Code-Line.
        ///// </summary>
        //public EsrCodeLine { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}"
                                ).TrimEnd('|');
        }
    }
}