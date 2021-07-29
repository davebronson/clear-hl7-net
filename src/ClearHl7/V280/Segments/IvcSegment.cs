using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V280.Types;

namespace ClearHl7.V280.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IVC - Invoice Segment.
    /// </summary>
    public class IvcSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "IVC";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// IVC.1 - Provider Invoice Number.
        /// </summary>
        public EntityIdentifier ProviderInvoiceNumber { get; set; }

        /// <summary>
        /// IVC.2 - Payer Invoice Number.
        /// </summary>
        public EntityIdentifier PayerInvoiceNumber { get; set; }

        /// <summary>
        /// IVC.3 - Contract/Agreement Number.
        /// </summary>
        public EntityIdentifier ContractAgreementNumber { get; set; }

        /// <summary>
        /// IVC.4 - Invoice Control.
        /// <para>Suggested: 0553 Invoice Control Code -&gt; ClearHl7.Codes.V280.CodeInvoiceControlCode</para>
        /// </summary>
        public CodedWithExceptions InvoiceControl { get; set; }

        /// <summary>
        /// IVC.5 - Invoice Reason.
        /// <para>Suggested: 0554 Invoice Reason Codes -&gt; ClearHl7.Codes.V280.CodeInvoiceReasonCodes</para>
        /// </summary>
        public CodedWithExceptions InvoiceReason { get; set; }

        /// <summary>
        /// IVC.6 - Invoice Type.
        /// <para>Suggested: 0555 Invoice Type -&gt; ClearHl7.Codes.V280.CodeInvoiceType</para>
        /// </summary>
        public CodedWithExceptions InvoiceType { get; set; }

        /// <summary>
        /// IVC.7 - Invoice Date/Time.
        /// </summary>
        public DateTime? InvoiceDateTime { get; set; }

        /// <summary>
        /// IVC.8 - Invoice Amount.
        /// </summary>
        public CompositePrice InvoiceAmount { get; set; }

        /// <summary>
        /// IVC.9 - Payment Terms.
        /// </summary>
        public string PaymentTerms { get; set; }

        /// <summary>
        /// IVC.10 - Provider Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations ProviderOrganization { get; set; }

        /// <summary>
        /// IVC.11 - Payer Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations PayerOrganization { get; set; }

        /// <summary>
        /// IVC.12 - Attention.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons Attention { get; set; }

        /// <summary>
        /// IVC.13 - Last Invoice Indicator.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V280.CodeYesNoIndicator</para>
        /// </summary>
        public string LastInvoiceIndicator { get; set; }

        /// <summary>
        /// IVC.14 - Invoice Booking Period.
        /// </summary>
        public DateTime? InvoiceBookingPeriod { get; set; }

        /// <summary>
        /// IVC.15 - Origin.
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// IVC.16 - Invoice Fixed Amount.
        /// </summary>
        public CompositePrice InvoiceFixedAmount { get; set; }

        /// <summary>
        /// IVC.17 - Special Costs.
        /// </summary>
        public CompositePrice SpecialCosts { get; set; }

        /// <summary>
        /// IVC.18 - Amount for Doctors Treatment.
        /// </summary>
        public CompositePrice AmountForDoctorsTreatment { get; set; }

        /// <summary>
        /// IVC.19 - Responsible Physician.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons ResponsiblePhysician { get; set; }

        /// <summary>
        /// IVC.20 - Cost Center.
        /// </summary>
        public ExtendedCompositeIdWithCheckDigit CostCenter { get; set; }

        /// <summary>
        /// IVC.21 - Invoice Prepaid Amount.
        /// </summary>
        public CompositePrice InvoicePrepaidAmount { get; set; }

        /// <summary>
        /// IVC.22 - Total Invoice Amount without Prepaid Amount.
        /// </summary>
        public CompositePrice TotalInvoiceAmountWithoutPrepaidAmount { get; set; }

        /// <summary>
        /// IVC.23 - Total-Amount of VAT.
        /// </summary>
        public CompositePrice TotalAmountOfVat { get; set; }

        /// <summary>
        /// IVC.24 - VAT-Rates applied.
        /// </summary>
        public IEnumerable<decimal> VatRatesApplied { get; set; }

        /// <summary>
        /// IVC.25 - Benefit Group.
        /// <para>Suggested: 0556 Benefit Group -&gt; ClearHl7.Codes.V280.CodeBenefitGroup</para>
        /// </summary>
        public CodedWithExceptions BenefitGroup { get; set; }

        /// <summary>
        /// IVC.26 - Provider Tax ID.
        /// </summary>
        public string ProviderTaxId { get; set; }

        /// <summary>
        /// IVC.27 - Payer Tax ID.
        /// </summary>
        public string PayerTaxId { get; set; }

        /// <summary>
        /// IVC.28 - Provider Tax Status.
        /// <para>Suggested: 0572 Tax Status -&gt; ClearHl7.Codes.V280.CodeTaxStatus</para>
        /// </summary>
        public CodedWithExceptions ProviderTaxStatus { get; set; }

        /// <summary>
        /// IVC.29 - Payer Tax Status.
        /// <para>Suggested: 0572 Tax Status -&gt; ClearHl7.Codes.V280.CodeTaxStatus</para>
        /// </summary>
        public CodedWithExceptions PayerTaxStatus { get; set; }

        /// <summary>
        /// IVC.30 - Sales Tax ID.
        /// </summary>
        public string SalesTaxId { get; set; }

        /// <summary>
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());
            char[] separator = Configuration.FieldRepeatSeparator.ToCharArray();

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ProviderInvoiceNumber = segments.Length > 1 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(1), false) : null;
            PayerInvoiceNumber = segments.Length > 2 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(2), false) : null;
            ContractAgreementNumber = segments.Length > 3 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(3), false) : null;
            InvoiceControl = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
            InvoiceReason = segments.Length > 5 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(5), false) : null;
            InvoiceType = segments.Length > 6 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(6), false) : null;
            InvoiceDateTime = segments.ElementAtOrDefault(7)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            InvoiceAmount = segments.Length > 8 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(8), false) : null;
            PaymentTerms = segments.ElementAtOrDefault(9);
            ProviderOrganization = segments.Length > 10 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(10), false) : null;
            PayerOrganization = segments.Length > 11 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(11), false) : null;
            Attention = segments.Length > 12 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(12), false) : null;
            LastInvoiceIndicator = segments.ElementAtOrDefault(13);
            InvoiceBookingPeriod = segments.ElementAtOrDefault(14)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            Origin = segments.ElementAtOrDefault(15);
            InvoiceFixedAmount = segments.Length > 16 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(16), false) : null;
            SpecialCosts = segments.Length > 17 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(17), false) : null;
            AmountForDoctorsTreatment = segments.Length > 18 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(18), false) : null;
            ResponsiblePhysician = segments.Length > 19 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(19), false) : null;
            CostCenter = segments.Length > 20 ? TypeHelper.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments.ElementAtOrDefault(20), false) : null;
            InvoicePrepaidAmount = segments.Length > 21 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(21), false) : null;
            TotalInvoiceAmountWithoutPrepaidAmount = segments.Length > 22 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(22), false) : null;
            TotalAmountOfVat = segments.Length > 23 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(23), false) : null;
            VatRatesApplied = segments.Length > 24 ? segments.ElementAtOrDefault(24).Split(separator).Select(x => x.ToDecimal()) : null;
            BenefitGroup = segments.Length > 25 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(25), false) : null;
            ProviderTaxId = segments.ElementAtOrDefault(26);
            PayerTaxId = segments.ElementAtOrDefault(27);
            ProviderTaxStatus = segments.Length > 28 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(28), false) : null;
            PayerTaxStatus = segments.Length > 29 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(29), false) : null;
            SalesTaxId = segments.ElementAtOrDefault(30);
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
                                StringHelper.StringFormatSequence(0, 31, Configuration.FieldSeparator),
                                Id,
                                ProviderInvoiceNumber?.ToDelimitedString(),
                                PayerInvoiceNumber?.ToDelimitedString(),
                                ContractAgreementNumber?.ToDelimitedString(),
                                InvoiceControl?.ToDelimitedString(),
                                InvoiceReason?.ToDelimitedString(),
                                InvoiceType?.ToDelimitedString(),
                                InvoiceDateTime.HasValue ? InvoiceDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                InvoiceAmount?.ToDelimitedString(),
                                PaymentTerms,
                                ProviderOrganization?.ToDelimitedString(),
                                PayerOrganization?.ToDelimitedString(),
                                Attention?.ToDelimitedString(),
                                LastInvoiceIndicator,
                                InvoiceBookingPeriod.HasValue ? InvoiceBookingPeriod.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                Origin,
                                InvoiceFixedAmount?.ToDelimitedString(),
                                SpecialCosts?.ToDelimitedString(),
                                AmountForDoctorsTreatment?.ToDelimitedString(),
                                ResponsiblePhysician?.ToDelimitedString(),
                                CostCenter?.ToDelimitedString(),
                                InvoicePrepaidAmount?.ToDelimitedString(),
                                TotalInvoiceAmountWithoutPrepaidAmount?.ToDelimitedString(),
                                TotalAmountOfVat?.ToDelimitedString(),
                                VatRatesApplied != null ? string.Join(Configuration.FieldRepeatSeparator, VatRatesApplied.Select(x => x.ToString(Consts.NumericFormat, culture))) : null,
                                BenefitGroup?.ToDelimitedString(),
                                ProviderTaxId,
                                PayerTaxId,
                                ProviderTaxStatus?.ToDelimitedString(),
                                PayerTaxStatus?.ToDelimitedString(),
                                SalesTaxId
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}