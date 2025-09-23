using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment IVC - Invoice Segment.
    /// </summary>
    public class IvcSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IvcSegment"/> class.
        /// </summary>
        public IvcSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IvcSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public IvcSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "IVC";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0553 Invoice Control Code -&gt; ClearHl7.Codes.V281.CodeInvoiceControlCode</para>
        /// </summary>
        public CodedWithExceptions InvoiceControl { get; set; }

        /// <summary>
        /// IVC.5 - Invoice Reason.
        /// <para>Suggested: 0554 Invoice Reason Codes -&gt; ClearHl7.Codes.V281.CodeInvoiceReasonCodes</para>
        /// </summary>
        public CodedWithExceptions InvoiceReason { get; set; }

        /// <summary>
        /// IVC.6 - Invoice Type.
        /// <para>Suggested: 0555 Invoice Type -&gt; ClearHl7.Codes.V281.CodeInvoiceType</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V281.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0556 Benefit Group -&gt; ClearHl7.Codes.V281.CodeBenefitGroup</para>
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
        /// <para>Suggested: 0572 Tax Status -&gt; ClearHl7.Codes.V281.CodeTaxStatus</para>
        /// </summary>
        public CodedWithExceptions ProviderTaxStatus { get; set; }

        /// <summary>
        /// IVC.29 - Payer Tax Status.
        /// <para>Suggested: 0572 Tax Status -&gt; ClearHl7.Codes.V281.CodeTaxStatus</para>
        /// </summary>
        public CodedWithExceptions PayerTaxStatus { get; set; }

        /// <summary>
        /// IVC.30 - Sales Tax ID.
        /// </summary>
        public string SalesTaxId { get; set; }

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

            ProviderInvoiceNumber = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            PayerInvoiceNumber = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            ContractAgreementNumber = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[3], false, seps) : null;
            InvoiceControl = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            InvoiceReason = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            InvoiceType = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            InvoiceDateTime = segments.Length > 7 && segments[7].Length > 0 ? segments[7].ToNullableDateTime() : null;
            InvoiceAmount = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[8], false, seps) : null;
            PaymentTerms = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            ProviderOrganization = segments.Length > 10 && segments[10].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[10], false, seps) : null;
            PayerOrganization = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[11], false, seps) : null;
            Attention = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[12], false, seps) : null;
            LastInvoiceIndicator = segments.Length > 13 && segments[13].Length > 0 ? segments[13] : null;
            InvoiceBookingPeriod = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            Origin = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            InvoiceFixedAmount = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[16], false, seps) : null;
            SpecialCosts = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[17], false, seps) : null;
            AmountForDoctorsTreatment = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[18], false, seps) : null;
            ResponsiblePhysician = segments.Length > 19 && segments[19].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments[19], false, seps) : null;
            CostCenter = segments.Length > 20 && segments[20].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeIdWithCheckDigit>(segments[20], false, seps) : null;
            InvoicePrepaidAmount = segments.Length > 21 && segments[21].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[21], false, seps) : null;
            TotalInvoiceAmountWithoutPrepaidAmount = segments.Length > 22 && segments[22].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[22], false, seps) : null;
            TotalAmountOfVat = segments.Length > 23 && segments[23].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[23], false, seps) : null;
            VatRatesApplied = segments.Length > 24 && segments[24].Length > 0 ? segments[24].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDecimal()) : null;
            BenefitGroup = segments.Length > 25 && segments[25].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[25], false, seps) : null;
            ProviderTaxId = segments.Length > 26 && segments[26].Length > 0 ? segments[26] : null;
            PayerTaxId = segments.Length > 27 && segments[27].Length > 0 ? segments[27] : null;
            ProviderTaxStatus = segments.Length > 28 && segments[28].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[28], false, seps) : null;
            PayerTaxStatus = segments.Length > 29 && segments[29].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[29], false, seps) : null;
            SalesTaxId = segments.Length > 30 && segments[30].Length > 0 ? segments[30] : null;
        }

        /// <inheritdoc/>
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
                                InvoiceDateTime.ToHl7DateTimeString(typeof(IvcSegment), nameof(InvoiceDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                InvoiceAmount?.ToDelimitedString(),
                                PaymentTerms,
                                ProviderOrganization?.ToDelimitedString(),
                                PayerOrganization?.ToDelimitedString(),
                                Attention?.ToDelimitedString(),
                                LastInvoiceIndicator,
                                InvoiceBookingPeriod.ToHl7DateTimeString(typeof(IvcSegment), nameof(InvoiceBookingPeriod), Consts.DateTimeFormatPrecisionSecond, culture),
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
