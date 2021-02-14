using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V281.Types;

namespace ClearHl7.V281.Segments
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
        /// <para>Suggested: 0456 Revenue Code -&gt; ClearHl7.Codes.V281.CodeRevenueCode</para>
        /// </summary>
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
        /// <para>Suggested: 0459 Reimbursement Action Code -&gt; ClearHl7.Codes.V281.CodeReimbursementActionCode</para>
        /// </summary>
        public CodedWithExceptions ReimbursementActionCode { get; set; }

        /// <summary>
        /// GP2.5 - Denial or Rejection Code.
        /// <para>Suggested: 0460 Denial Or Rejection Code -&gt; ClearHl7.Codes.V281.CodeDenialOrRejectionCode</para>
        /// </summary>
        public CodedWithExceptions DenialOrRejectionCode { get; set; }

        /// <summary>
        /// GP2.6 - OCE Edit Code.
        /// <para>Suggested: 0458 OCE Edit Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> OceEditCode { get; set; }

        /// <summary>
        /// GP2.7 - Ambulatory Payment Classification Code.
        /// <para>Suggested: 0466 Ambulatory Payment Classification Code -&gt; ClearHl7.Codes.V281.CodeAmbulatoryPaymentClassificationCode</para>
        /// </summary>
        public CodedWithExceptions AmbulatoryPaymentClassificationCode { get; set; }

        /// <summary>
        /// GP2.8 - Modifier Edit Code.
        /// <para>Suggested: 0467 Modifier Edit Code</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> ModifierEditCode { get; set; }

        /// <summary>
        /// GP2.9 - Payment Adjustment Code.
        /// <para>Suggested: 0468 Payment Adjustment Code -&gt; ClearHl7.Codes.V281.CodePaymentAdjustmentCode</para>
        /// </summary>
        public CodedWithExceptions PaymentAdjustmentCode { get; set; }

        /// <summary>
        /// GP2.10 - Packaging Status Code.
        /// <para>Suggested: 0469 Packaging Status Code -&gt; ClearHl7.Codes.V281.CodePackagingStatusCode</para>
        /// </summary>
        public CodedWithExceptions PackagingStatusCode { get; set; }

        /// <summary>
        /// GP2.11 - Expected CMS Payment Amount.
        /// </summary>
        public CompositePrice ExpectedCmsPaymentAmount { get; set; }

        /// <summary>
        /// GP2.12 - Reimbursement Type Code.
        /// <para>Suggested: 0470 Reimbursement Type Code -&gt; ClearHl7.Codes.V281.CodeReimbursementTypeCode</para>
        /// </summary>
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
                                StringHelper.StringFormatSequence(0, 15, Configuration.FieldSeparator),
                                Id,
                                RevenueCode?.ToDelimitedString(),
                                NumberOfServiceUnits.HasValue ? NumberOfServiceUnits.Value.ToString(Consts.NumericFormat, culture) : null,
                                Charge?.ToDelimitedString(),
                                ReimbursementActionCode?.ToDelimitedString(),
                                DenialOrRejectionCode?.ToDelimitedString(),
                                OceEditCode != null ? string.Join(Configuration.FieldRepeatSeparator, OceEditCode.Select(x => x.ToDelimitedString())) : null,
                                AmbulatoryPaymentClassificationCode?.ToDelimitedString(),
                                ModifierEditCode != null ? string.Join(Configuration.FieldRepeatSeparator, ModifierEditCode.Select(x => x.ToDelimitedString())) : null,
                                PaymentAdjustmentCode?.ToDelimitedString(),
                                PackagingStatusCode?.ToDelimitedString(),
                                ExpectedCmsPaymentAmount?.ToDelimitedString(),
                                ReimbursementTypeCode?.ToDelimitedString(),
                                CoPayAmount?.ToDelimitedString(),
                                PayRatePerServiceUnit.HasValue ? PayRatePerServiceUnit.Value.ToString(Consts.NumericFormat, culture) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}