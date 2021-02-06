using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
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
        /// <para>Suggested: 0553 Invoice Control Code -&gt; ClearHl7.Fhir.Codes.V281.CodeInvoiceControlCode</para>
        /// </summary>
        public CodedWithExceptions InvoiceControl { get; set; }

        /// <summary>
        /// IVC.5 - Invoice Reason.
        /// <para>Suggested: 0554 Invoice Reason Codes -&gt; ClearHl7.Fhir.Codes.V281.CodeInvoiceReasonCodes</para>
        /// </summary>
        public CodedWithExceptions InvoiceReason { get; set; }

        /// <summary>
        /// IVC.6 - Invoice Type.
        /// <para>Suggested: 0555 Invoice Type -&gt; ClearHl7.Fhir.Codes.V281.CodeInvoiceType</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Fhir.Codes.V281.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0556 Benefit Group -&gt; ClearHl7.Fhir.Codes.V281.CodeBenefitGroup</para>
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
        /// <para>Suggested: 0572 Tax Status -&gt; ClearHl7.Fhir.Codes.V281.CodeTaxStatus</para>
        /// </summary>
        public CodedWithExceptions ProviderTaxStatus { get; set; }

        /// <summary>
        /// IVC.29 - Payer Tax Status.
        /// <para>Suggested: 0572 Tax Status -&gt; ClearHl7.Fhir.Codes.V281.CodeTaxStatus</para>
        /// </summary>
        public CodedWithExceptions PayerTaxStatus { get; set; }

        /// <summary>
        /// IVC.30 - Sales Tax ID.
        /// </summary>
        public string SalesTaxId { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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