using System;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V281.Types;

namespace ClearHl7.Fhir.V281.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ADJ - Adjustment.
    /// </summary>
    public class AdjSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "ADJ";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// ADJ.1 - Provider Adjustment Number.
        /// </summary>
        public EntityIdentifier ProviderAdjustmentNumber { get; set; }

        /// <summary>
        /// ADJ.2 - Payer Adjustment Number.
        /// </summary>
        public EntityIdentifier PayerAdjustmentNumber { get; set; }

        /// <summary>
        /// ADJ.3 - Adjustment Sequence Number.
        /// </summary>
        public EntityIdentifier AdjustmentSequenceNumber { get; set; }

        /// <summary>
        /// ADJ.4 - Adjustment Category.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0564</remarks>
        public CodedWithExceptions AdjustmentCategory { get; set; }

        /// <summary>
        /// ADJ.5 - Adjustment Amount.
        /// </summary>
        public CompositePrice AdjustmentAmount { get; set; }

        /// <summary>
        /// ADJ.6 - Adjustment Quantity.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0560</remarks>
        public CompositeQuantityWithUnits AdjustmentQuantity { get; set; }

        /// <summary>
        /// ADJ.7 - Adjustment Reason PA.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0565</remarks>
        public CodedWithExceptions AdjustmentReasonPa { get; set; }

        /// <summary>
        /// ADJ.8 - Adjustment Description.
        /// </summary>
        public string AdjustmentDescription { get; set; }

        /// <summary>
        /// ADJ.9 - Original Value.
        /// </summary>
        public decimal? OriginalValue { get; set; }

        /// <summary>
        /// ADJ.10 - Substitute Value.
        /// </summary>
        public decimal? SubstituteValue { get; set; }

        /// <summary>
        /// ADJ.11 - Adjustment Action.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0569</remarks>
        public CodedWithExceptions AdjustmentAction { get; set; }

        /// <summary>
        /// ADJ.12 - Provider Adjustment Number Cross Reference.
        /// </summary>
        public EntityIdentifier ProviderAdjustmentNumberCrossReference { get; set; }

        /// <summary>
        /// ADJ.13 - Provider Product/Service Line Item Number Cross Reference.
        /// </summary>
        public EntityIdentifier ProviderProductServiceLineItemNumberCrossReference { get; set; }

        /// <summary>
        /// ADJ.14 - Adjustment Date.
        /// </summary>
        public DateTime? AdjustmentDate { get; set; }

        /// <summary>
        /// ADJ.15 - Responsible Organization.
        /// </summary>
        public ExtendedCompositeNameAndIdNumberForOrganizations ResponsibleOrganization { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 16, Configuration.FieldSeparator),
                                Id,
                                ProviderAdjustmentNumber?.ToDelimitedString(),
                                PayerAdjustmentNumber?.ToDelimitedString(),
                                AdjustmentSequenceNumber?.ToDelimitedString(),
                                AdjustmentCategory?.ToDelimitedString(),
                                AdjustmentAmount?.ToDelimitedString(),
                                AdjustmentQuantity?.ToDelimitedString(),
                                AdjustmentReasonPa?.ToDelimitedString(),
                                AdjustmentDescription,
                                OriginalValue.HasValue ? OriginalValue.Value.ToString(Consts.NumericFormat, culture) : null,
                                SubstituteValue.HasValue ? SubstituteValue.Value.ToString(Consts.NumericFormat, culture) : null,
                                AdjustmentAction?.ToDelimitedString(),
                                ProviderAdjustmentNumberCrossReference?.ToDelimitedString(),
                                ProviderProductServiceLineItemNumberCrossReference?.ToDelimitedString(),
                                AdjustmentDate.HasValue ? AdjustmentDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ResponsibleOrganization?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}