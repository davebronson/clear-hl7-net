using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V282.Types;

namespace ClearHl7.Fhir.V282.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment GP2 - Grouping Reimbursement - Procedure Line Item.
    /// </summary>
    public class Gp2Segment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "GP2";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// GP2.1 - Revenue Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0456</remarks>
        public CodedWithExceptions RevenueCode { get; set; }

        /// <summary>
        /// GP2.2 - Number of Service Units.
        /// </summary>
        public decimal? NumberOfServiceUnits { get; set; }

        /// <summary>
        /// GP2.3 - Charge.
        /// </summary>
        public CompositePrice Charge { get; set; }

        /// <summary>
        /// GP2.4 - Reimbursement Action Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0459</remarks>
        public CodedWithExceptions ReimbursementActionCode { get; set; }

        /// <summary>
        /// GP2.5 - Denial or Rejection Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0460</remarks>
        public CodedWithExceptions DenialOrRejectionCode { get; set; }

        /// <summary>
        /// GP2.6 - OCE Edit Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0458</remarks>
        public IEnumerable<CodedWithExceptions> OceEditCode { get; set; }

        /// <summary>
        /// GP2.7 - Ambulatory Payment Classification Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0466</remarks>
        public CodedWithExceptions AmbulatoryPaymentClassificationCode { get; set; }

        /// <summary>
        /// GP2.8 - Modifier Edit Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0467</remarks>
        public IEnumerable<CodedWithExceptions> ModifierEditCode { get; set; }

        /// <summary>
        /// GP2.9 - Payment Adjustment Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0468</remarks>
        public CodedWithExceptions PaymentAdjustmentCode { get; set; }

        /// <summary>
        /// GP2.10 - Packaging Status Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0469</remarks>
        public CodedWithExceptions PackagingStatusCode { get; set; }

        /// <summary>
        /// GP2.11 - Expected CMS Payment Amount.
        /// </summary>
        public CompositePrice ExpectedCmsPaymentAmount { get; set; }

        /// <summary>
        /// GP2.12 - Reimbursement Type Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0470</remarks>
        public CodedWithExceptions ReimbursementTypeCode { get; set; }

        /// <summary>
        /// GP2.13 - Co-Pay Amount.
        /// </summary>
        public CompositePrice CoPayAmount { get; set; }

        /// <summary>
        /// GP2.14 - Pay Rate per Service Unit.
        /// </summary>
        public decimal? PayRatePerServiceUnit { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}",
                                Id,
                                RevenueCode?.ToDelimitedString(),
                                NumberOfServiceUnits.HasValue ? NumberOfServiceUnits.Value.ToString(Consts.NumericFormat, culture) : null,
                                Charge?.ToDelimitedString(),
                                ReimbursementActionCode?.ToDelimitedString(),
                                DenialOrRejectionCode?.ToDelimitedString(),
                                OceEditCode != null ? string.Join("~", OceEditCode.Select(x => x.ToDelimitedString())) : null,
                                AmbulatoryPaymentClassificationCode?.ToDelimitedString(),
                                ModifierEditCode != null ? string.Join("~", ModifierEditCode.Select(x => x.ToDelimitedString())) : null,
                                PaymentAdjustmentCode?.ToDelimitedString(),
                                PackagingStatusCode?.ToDelimitedString(),
                                ExpectedCmsPaymentAmount?.ToDelimitedString(),
                                ReimbursementTypeCode?.ToDelimitedString(),
                                CoPayAmount?.ToDelimitedString(),
                                PayRatePerServiceUnit.HasValue ? PayRatePerServiceUnit.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd('|');
        }
    }
}