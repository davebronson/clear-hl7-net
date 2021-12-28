﻿using System;
using System.Globalization;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V260.Types;

namespace ClearHl7.V260.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment ADJ - Adjustment.
    /// </summary>
    public class AdjSegment : ISegment
    {
        /// <inheritdoc/>
        public string Id { get; } = "ADJ";

        /// <inheritdoc/>
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
        /// <para>Suggested: 0564 Adjustment Category Code -&gt; ClearHl7.Codes.V260.CodeAdjustmentCategoryCode</para>
        /// </summary>
        public string AdjustmentCategory { get; set; }

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
        /// <para>Suggested: 0565 Provider Adjustment Reason Code -&gt; ClearHl7.Codes.V260.CodeProviderAdjustmentReasonCode</para>
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
        /// <para>Suggested: 0569 Adjustment Action -&gt; ClearHl7.Codes.V260.CodeAdjustmentAction</para>
        /// </summary>
        public string AdjustmentAction { get; set; }

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
                if (string.Compare(Id, segments[0], true, CultureInfo.CurrentCulture) != 0)
                {
                    throw new ArgumentException($"{ nameof(delimitedString) } does not begin with the proper segment Id: '{ Id }{ seps.FieldSeparator }'.", nameof(delimitedString));
                }
            }

            ProviderAdjustmentNumber = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[1], false, seps) : null;
            PayerAdjustmentNumber = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[2], false, seps) : null;
            AdjustmentSequenceNumber = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableUInt() : null;
            AdjustmentCategory = segments.Length > 4 && segments[4].Length > 0 ? segments[4] : null;
            AdjustmentAmount = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CompositePrice>(segments[5], false, seps) : null;
            AdjustmentQuantity = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[6], false, seps) : null;
            AdjustmentReasonPa = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[7], false, seps) : null;
            AdjustmentDescription = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            OriginalValue = segments.Length > 9 && segments[9].Length > 0 ? segments[9].ToNullableDecimal() : null;
            SubstituteValue = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
            AdjustmentAction = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            ProviderAdjustmentNumberCrossReference = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[12], false, seps) : null;
            ProviderProductServiceLineItemNumberCrossReference = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<EntityIdentifier>(segments[13], false, seps) : null;
            AdjustmentDate = segments.Length > 14 && segments[14].Length > 0 ? segments[14].ToNullableDateTime() : null;
            ResponsibleOrganization = segments.Length > 15 && segments[15].Length > 0 ? TypeSerializer.Deserialize<ExtendedCompositeNameAndIdNumberForOrganizations>(segments[15], false, seps) : null;
        }

        /// <inheritdoc/>
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
                                AdjustmentCategory,
                                AdjustmentAmount?.ToDelimitedString(),
                                AdjustmentQuantity?.ToDelimitedString(),
                                AdjustmentReasonPa?.ToDelimitedString(),
                                AdjustmentDescription,
                                OriginalValue.HasValue ? OriginalValue.Value.ToString(Consts.NumericFormat, culture) : null,
                                SubstituteValue.HasValue ? SubstituteValue.Value.ToString(Consts.NumericFormat, culture) : null,
                                AdjustmentAction,
                                ProviderAdjustmentNumberCrossReference?.ToDelimitedString(),
                                ProviderProductServiceLineItemNumberCrossReference?.ToDelimitedString(),
                                AdjustmentDate.HasValue ? AdjustmentDate.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ResponsibleOrganization?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
