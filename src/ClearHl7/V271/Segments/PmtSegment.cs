using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V271.Types;

namespace ClearHl7.V271.Segments
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
        /// <para>Suggested: 0570 Payment Method Code -&gt; ClearHl7.Codes.V271.CodePaymentMethodCode</para>
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

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  Separators defined in the Configuration class are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            FromDelimitedString(delimitedString, null);
        }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.  The provided separators are used to split the string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <param name="separators">The separators to use for splitting the string.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString, Separators separators)
        {
            Separators seps = separators ?? new Separators().UsingConfigurationValues();
            string[] segments = delimitedString == null
                ? new string[] { }
                : delimitedString.Split(seps.FieldSeparator, StringSplitOptions.None);

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            PaymentRemittanceAdviceNumber = segments.Length > 1 && segments[1].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            PaymentRemittanceEffectiveDateTime = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDateTime() : null;
            PaymentRemittanceExpirationDateTime = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            PaymentMethod = segments.Length > 4 && segments[4].Length > 0 ? TypeHelper.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            PaymentRemittanceDateTime = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDateTime() : null;
            PaymentRemittanceAmount = segments.Length > 6 && segments[6].Length > 0 ? TypeHelper.Deserialize<CompositePrice>(segments[6], false, seps) : null;
            CheckNumber = segments.Length > 7 && segments[7].Length > 0 ? TypeHelper.Deserialize<EntityIdentifier>(segments[7], false, seps) : null;
            PayeeBankIdentification = segments.Length > 8 && segments[8].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[8], false, seps) : null;
            PayeeTransitNumber = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            PayeeBankAccountId = segments.Length > 10 && segments[10].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[10], false, seps) : null;
            PaymentOrganization = segments.Length > 11 && segments[11].Length > 0 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[11], false, seps) : null;
            EsrCodeLine = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
        }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

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
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}