using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXG - Pharmacy Treatment Give.
    /// </summary>
    public class RxgSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RxgSegment"/> class.
        /// </summary>
        public RxgSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RxgSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public RxgSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "RXG";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// RXG.1 - Give Sub-ID Counter.
        /// </summary>
        public decimal? GiveSubIdCounter { get; set; }

        /// <summary>
        /// RXG.2 - Dispense Sub-ID Counter.
        /// </summary>
        public decimal? DispenseSubIdCounter { get; set; }

        /// <summary>
        /// RXG.3 - Quantity/Timing.
        /// </summary>
        public TimingQuantity QuantityTiming { get; set; }

        /// <summary>
        /// RXG.4 - Give Code.
        /// <para>Suggested: 0292 Vaccines Administered -&gt; ClearHl7.Codes.V230.CodeVaccinesAdministered</para>
        /// </summary>
        public CodedElement GiveCode { get; set; }

        /// <summary>
        /// RXG.5 - Give Amount - Minimum.
        /// </summary>
        public decimal? GiveAmountMinimum { get; set; }

        /// <summary>
        /// RXG.6 - Give Amount - Maximum.
        /// </summary>
        public decimal? GiveAmountMaximum { get; set; }

        /// <summary>
        /// RXG.7 - Give Units.
        /// </summary>
        public CodedElement GiveUnits { get; set; }

        /// <summary>
        /// RXG.8 - Give Dosage Form.
        /// </summary>
        public CodedElement GiveDosageForm { get; set; }

        /// <summary>
        /// RXG.9 - Administration Notes.
        /// </summary>
        public IEnumerable<CodedElement> AdministrationNotes { get; set; }

        /// <summary>
        /// RXG.10 - Substitution Status.
        /// <para>Suggested: 0167 Substitution Status -&gt; ClearHl7.Codes.V230.CodeSubstitutionStatus</para>
        /// </summary>
        public string SubstitutionStatus { get; set; }

        /// <summary>
        /// RXG.11 - Dispense-to Location.
        /// </summary>
        public LocationWithAddressVariationTwo DispenseToLocation { get; set; }

        /// <summary>
        /// RXG.12 - Needs Human Review.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V230.CodeYesNoIndicator</para>
        /// </summary>
        public string NeedsHumanReview { get; set; }

        /// <summary>
        /// RXG.13 - Special Administration Instructions.
        /// </summary>
        public IEnumerable<CodedElement> SpecialAdministrationInstructions { get; set; }

        /// <summary>
        /// RXG.14 - Give Per (Time Unit).
        /// </summary>
        public string GivePerTimeUnit { get; set; }

        /// <summary>
        /// RXG.15 - Give Rate Amount.
        /// </summary>
        public string GiveRateAmount { get; set; }

        /// <summary>
        /// RXG.16 - Give Rate Units.
        /// </summary>
        public CodedElement GiveRateUnits { get; set; }

        /// <summary>
        /// RXG.17 - Give Strength.
        /// </summary>
        public decimal? GiveStrength { get; set; }

        /// <summary>
        /// RXG.18 - Give Strength Units.
        /// </summary>
        public CodedElement GiveStrengthUnits { get; set; }

        /// <summary>
        /// RXG.19 - Substance Lot Number.
        /// </summary>
        public IEnumerable<string> SubstanceLotNumber { get; set; }

        /// <summary>
        /// RXG.20 - Substance Expiration Date.
        /// </summary>
        public IEnumerable<DateTime> SubstanceExpirationDate { get; set; }

        /// <summary>
        /// RXG.21 - Substance Manufacturer Name.
        /// </summary>
        public IEnumerable<CodedElement> SubstanceManufacturerName { get; set; }

        /// <summary>
        /// RXG.22 - Indication.
        /// </summary>
        public IEnumerable<CodedElement> Indication { get; set; }

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

            GiveSubIdCounter = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            DispenseSubIdCounter = segments.Length > 2 && segments[2].Length > 0 ? segments[2].ToNullableDecimal() : null;
            QuantityTiming = segments.Length > 3 && segments[3].Length > 0 ? TypeSerializer.Deserialize<TimingQuantity>(segments[3], false, seps) : null;
            GiveCode = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[4], false, seps) : null;
            GiveAmountMinimum = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            GiveAmountMaximum = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            GiveUnits = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[7], false, seps) : null;
            GiveDosageForm = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[8], false, seps) : null;
            AdministrationNotes = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            SubstitutionStatus = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            DispenseToLocation = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<LocationWithAddressVariationTwo>(segments[11], false, seps) : null;
            NeedsHumanReview = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            SpecialAdministrationInstructions = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            GivePerTimeUnit = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            GiveRateAmount = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            GiveRateUnits = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[16], false, seps) : null;
            GiveStrength = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDecimal() : null;
            GiveStrengthUnits = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[18], false, seps) : null;
            SubstanceLotNumber = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SubstanceExpirationDate = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDateTime()) : null;
            SubstanceManufacturerName = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            Indication = segments.Length > 22 && segments[22].Length > 0 ? segments[22].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 23, Configuration.FieldSeparator),
                                Id,
                                GiveSubIdCounter.HasValue ? GiveSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseSubIdCounter.HasValue ? DispenseSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                QuantityTiming?.ToDelimitedString(),
                                GiveCode?.ToDelimitedString(),
                                GiveAmountMinimum.HasValue ? GiveAmountMinimum.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveAmountMaximum.HasValue ? GiveAmountMaximum.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveUnits?.ToDelimitedString(),
                                GiveDosageForm?.ToDelimitedString(),
                                AdministrationNotes != null ? string.Join(Configuration.FieldRepeatSeparator, AdministrationNotes.Select(x => x.ToDelimitedString())) : null,
                                SubstitutionStatus,
                                DispenseToLocation?.ToDelimitedString(),
                                NeedsHumanReview,
                                SpecialAdministrationInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, SpecialAdministrationInstructions.Select(x => x.ToDelimitedString())) : null,
                                GivePerTimeUnit,
                                GiveRateAmount,
                                GiveRateUnits?.ToDelimitedString(),
                                GiveStrength.HasValue ? GiveStrength.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveStrengthUnits?.ToDelimitedString(),
                                SubstanceLotNumber != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceLotNumber) : null,
                                SubstanceExpirationDate != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceExpirationDate.Select(x => x.ToString(Consts.DateTimeFormatPrecisionSecond, culture))) : null,
                                SubstanceManufacturerName != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceManufacturerName.Select(x => x.ToDelimitedString())) : null,
                                Indication != null ? string.Join(Configuration.FieldRepeatSeparator, Indication.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
