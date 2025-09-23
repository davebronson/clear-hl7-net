using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment PMT - Payment Information.
    /// </summary>
    public class PmtSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PmtSegment"/> class.
        /// </summary>
        public PmtSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PmtSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public PmtSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "PMT";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0570 Payment Method Code -&gt; ClearHl7.Codes.V290.CodePaymentMethodCode</para>
        /// </summary>
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

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <inheritdoc/>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? Array.Empty<string>()
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (!string.Equals(Id, segments[0], StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            PaymentRemittanceAdviceNumber = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            PaymentRemittanceEffectiveDateTime = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            PaymentRemittanceExpirationDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            PaymentMethod = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            PaymentRemittanceDateTime = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            PaymentRemittanceAmount = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[6], false, seps) : null;
            CheckNumber = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[7], false, seps) : null;
            PayeeBankIdentification = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[8], false, seps) : null;
            PayeeTransitNumber = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            PayeeBankAccountId = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[10], false, seps) : null;
            PaymentOrganization = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[11], false, seps) : null;
            EsrCodeLine = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 13, Configuration.FieldSeparator),
                                Id,
                                PaymentRemittanceAdviceNumber?.ToDelimitedString(),
                                PaymentRemittanceEffectiveDateTime.ToHl7DateTimeString(typeof(PmtSegment), nameof(PaymentRemittanceEffectiveDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                PaymentRemittanceExpirationDateTime.ToHl7DateTimeString(typeof(PmtSegment), nameof(PaymentRemittanceExpirationDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                PaymentMethod?.ToDelimitedString(),
                                PaymentRemittanceDateTime.ToHl7DateTimeString(typeof(PmtSegment), nameof(PaymentRemittanceDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                PaymentRemittanceAmount?.ToDelimitedString(),
                                CheckNumber?.ToDelimitedString(),
                                PayeeBankIdentification?.ToDelimitedString(),
                                PayeeTransitNumber,
                                PayeeBankAccountId?.ToDelimitedString(),
                                PaymentOrganization?.ToDelimitedString(),
                                EsrCodeLine
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
