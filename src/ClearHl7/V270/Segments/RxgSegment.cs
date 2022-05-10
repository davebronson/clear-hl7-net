using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V270.Types;

namespace ClearHl7.V270.Segments
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
        public string QuantityTiming { get; set; }

        /// <summary>
        /// RXG.4 - Give Code.
        /// <para>Suggested: 0292 Vaccines Administered -&gt; ClearHl7.Codes.V270.CodeVaccinesAdministered</para>
        /// </summary>
        public CodedWithExceptions GiveCode { get; set; }

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
        public CodedWithExceptions GiveUnits { get; set; }

        /// <summary>
        /// RXG.8 - Give Dosage Form.
        /// </summary>
        public CodedWithExceptions GiveDosageForm { get; set; }

        /// <summary>
        /// RXG.9 - Administration Notes.
        /// </summary>
        public IEnumerable<CodedWithExceptions> AdministrationNotes { get; set; }

        /// <summary>
        /// RXG.10 - Substitution Status.
        /// <para>Suggested: 0167 Substitution Status -&gt; ClearHl7.Codes.V270.CodeSubstitutionStatus</para>
        /// </summary>
        public string SubstitutionStatus { get; set; }

        /// <summary>
        /// RXG.11 - Dispense-to Location.
        /// </summary>
        public LocationWithAddressVariationTwo DispenseToLocation { get; set; }

        /// <summary>
        /// RXG.12 - Needs Human Review.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string NeedsHumanReview { get; set; }

        /// <summary>
        /// RXG.13 - Special Administration Instructions.
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecialAdministrationInstructions { get; set; }

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
        public CodedWithExceptions GiveRateUnits { get; set; }

        /// <summary>
        /// RXG.17 - Give Strength.
        /// </summary>
        public decimal? GiveStrength { get; set; }

        /// <summary>
        /// RXG.18 - Give Strength Units.
        /// </summary>
        public CodedWithExceptions GiveStrengthUnits { get; set; }

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
        /// <para>Suggested: 0227 Manufacturers Of Vaccines (code=MVX) -&gt; ClearHl7.Codes.V270.CodeManufacturersOfVaccines</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SubstanceManufacturerName { get; set; }

        /// <summary>
        /// RXG.22 - Indication.
        /// </summary>
        public IEnumerable<CodedWithExceptions> Indication { get; set; }

        /// <summary>
        /// RXG.23 - Give Drug Strength Volume.
        /// </summary>
        public decimal? GiveDrugStrengthVolume { get; set; }

        /// <summary>
        /// RXG.24 - Give Drug Strength Volume Units.
        /// </summary>
        public CodedWithExceptions GiveDrugStrengthVolumeUnits { get; set; }

        /// <summary>
        /// RXG.25 - Give Barcode Identifier.
        /// </summary>
        public CodedWithExceptions GiveBarcodeIdentifier { get; set; }

        /// <summary>
        /// RXG.26 - Pharmacy Order Type.
        /// <para>Suggested: 0480 Pharmacy Order Types -&gt; ClearHl7.Codes.V270.CodePharmacyOrderTypes</para>
        /// </summary>
        public string PharmacyOrderType { get; set; }

        /// <summary>
        /// RXG.27 - Dispense to Pharmacy.
        /// </summary>
        public CodedWithExceptions DispenseToPharmacy { get; set; }

        /// <summary>
        /// RXG.28 - Dispense to Pharmacy Address.
        /// </summary>
        public ExtendedAddress DispenseToPharmacyAddress { get; set; }

        /// <summary>
        /// RXG.29 - Deliver-to Patient Location.
        /// </summary>
        public PersonLocation DeliverToPatientLocation { get; set; }

        /// <summary>
        /// RXG.30 - Deliver-to Address.
        /// </summary>
        public ExtendedAddress DeliverToAddress { get; set; }

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
            QuantityTiming = segments.Length > 3 && segments[3].Length > 0 ? segments[3] : null;
            GiveCode = segments.Length > 4 && segments[4].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[4], false, seps) : null;
            GiveAmountMinimum = segments.Length > 5 && segments[5].Length > 0 ? segments[5].ToNullableDecimal() : null;
            GiveAmountMaximum = segments.Length > 6 && segments[6].Length > 0 ? segments[6].ToNullableDecimal() : null;
            GiveUnits = segments.Length > 7 && segments[7].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[7], false, seps) : null;
            GiveDosageForm = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[8], false, seps) : null;
            AdministrationNotes = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            SubstitutionStatus = segments.Length > 10 && segments[10].Length > 0 ? segments[10] : null;
            DispenseToLocation = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<LocationWithAddressVariationTwo>(segments[11], false, seps) : null;
            NeedsHumanReview = segments.Length > 12 && segments[12].Length > 0 ? segments[12] : null;
            SpecialAdministrationInstructions = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            GivePerTimeUnit = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            GiveRateAmount = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            GiveRateUnits = segments.Length > 16 && segments[16].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[16], false, seps) : null;
            GiveStrength = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDecimal() : null;
            GiveStrengthUnits = segments.Length > 18 && segments[18].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[18], false, seps) : null;
            SubstanceLotNumber = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SubstanceExpirationDate = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDateTime()) : null;
            SubstanceManufacturerName = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            Indication = segments.Length > 22 && segments[22].Length > 0 ? segments[22].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            GiveDrugStrengthVolume = segments.Length > 23 && segments[23].Length > 0 ? segments[23].ToNullableDecimal() : null;
            GiveDrugStrengthVolumeUnits = segments.Length > 24 && segments[24].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[24], false, seps) : null;
            GiveBarcodeIdentifier = segments.Length > 25 && segments[25].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[25], false, seps) : null;
            PharmacyOrderType = segments.Length > 26 && segments[26].Length > 0 ? segments[26] : null;
            DispenseToPharmacy = segments.Length > 27 && segments[27].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[27], false, seps) : null;
            DispenseToPharmacyAddress = segments.Length > 28 && segments[28].Length > 0 ? TypeSerializer.Deserialize<ExtendedAddress>(segments[28], false, seps) : null;
            DeliverToPatientLocation = segments.Length > 29 && segments[29].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[29], false, seps) : null;
            DeliverToAddress = segments.Length > 30 && segments[30].Length > 0 ? TypeSerializer.Deserialize<ExtendedAddress>(segments[30], false, seps) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 31, Configuration.FieldSeparator),
                                Id,
                                GiveSubIdCounter.HasValue ? GiveSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseSubIdCounter.HasValue ? DispenseSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                QuantityTiming,
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
                                Indication != null ? string.Join(Configuration.FieldRepeatSeparator, Indication.Select(x => x.ToDelimitedString())) : null,
                                GiveDrugStrengthVolume.HasValue ? GiveDrugStrengthVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveDrugStrengthVolumeUnits?.ToDelimitedString(),
                                GiveBarcodeIdentifier?.ToDelimitedString(),
                                PharmacyOrderType,
                                DispenseToPharmacy?.ToDelimitedString(),
                                DispenseToPharmacyAddress?.ToDelimitedString(),
                                DeliverToPatientLocation?.ToDelimitedString(),
                                DeliverToAddress?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
