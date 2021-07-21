using System;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
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
        public uint? AdjustmentSequenceNumber { get; set; }

        /// <summary>
        /// ADJ.4 - Adjustment Category.
        /// <para>Suggested: 0564 Adjustment Category Code -&gt; ClearHl7.Codes.V290.CodeAdjustmentCategoryCode</para>
        /// </summary>
        public CodedWithExceptions AdjustmentCategory { get; set; }

        /// <summary>
        /// ADJ.5 - Adjustment Amount.
        /// </summary>
        public CompositePrice AdjustmentAmount { get; set; }

        /// <summary>
        /// ADJ.6 - Adjustment Quantity.
        /// <para>Suggested: 0560 Quantity Units</para>
        /// </summary>
        public CompositeQuantityWithUnits AdjustmentQuantity { get; set; }

        /// <summary>
        /// ADJ.7 - Adjustment Reason PA.
        /// <para>Suggested: 0565 Provider Adjustment Reason Code -&gt; ClearHl7.Codes.V290.CodeProviderAdjustmentReasonCode</para>
        /// </summary>
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
        /// <para>Suggested: 0569 Adjustment Action -&gt; ClearHl7.Codes.V290.CodeAdjustmentAction</para>
        /// </summary>
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
        /// Initializes properties of this instance with values parsed from the given delimited string.
        /// </summary>
        /// <param name="delimitedString">A string representation that will be deserialized into the object instance.</param>
        /// <exception cref="ArgumentException">delimitedString does not begin with the proper segment Id.</exception>
        public void FromDelimitedString(string delimitedString)
        {
            string[] segments = delimitedString == null ? new string[] { } : delimitedString.Split(Configuration.FieldSeparator.ToCharArray());

            if (segments.Length > 0)
            {
                if (string.Compare(Id, segments.First(), true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ Configuration.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ProviderAdjustmentNumber = segments.Length > 1 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(1), false) : null;
            PayerAdjustmentNumber = segments.Length > 2 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(2), false) : null;
            AdjustmentSequenceNumber = segments.ElementAtOrDefault(3)?.ToNullableUInt();
            AdjustmentCategory = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
            AdjustmentAmount = segments.Length > 5 ? TypeHelper.Deserialize<CompositePrice>(segments.ElementAtOrDefault(5), false) : null;
            AdjustmentQuantity = segments.Length > 6 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(6), false) : null;
            AdjustmentReasonPa = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(7), false) : null;
            AdjustmentDescription = segments.ElementAtOrDefault(8);
            OriginalValue = segments.ElementAtOrDefault(9)?.ToNullableDecimal();
            SubstituteValue = segments.ElementAtOrDefault(10)?.ToNullableDecimal();
            AdjustmentAction = segments.Length > 11 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(11), false) : null;
            ProviderAdjustmentNumberCrossReference = segments.Length > 12 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(12), false) : null;
            ProviderProductServiceLineItemNumberCrossReference = segments.Length > 13 ? TypeHelper.Deserialize<EntityIdentifier>(segments.ElementAtOrDefault(13), false) : null;
            AdjustmentDate = segments.ElementAtOrDefault(14)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ResponsibleOrganization = segments.Length > 15 ? TypeHelper.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments.ElementAtOrDefault(15), false) : null;
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
                                StringHelper.StringFormatSequence(0, 16, Configuration.FieldSeparator),
                                Id,
                                ProviderAdjustmentNumber?.ToDelimitedString(),
                                PayerAdjustmentNumber?.ToDelimitedString(),
                                AdjustmentSequenceNumber.HasValue ? AdjustmentSequenceNumber.Value.ToString(culture) : null,
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
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}