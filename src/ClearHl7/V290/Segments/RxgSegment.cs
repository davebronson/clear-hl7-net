using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V290.Types;

namespace ClearHl7.V290.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXG - Pharmacy Treatment Give.
    /// </summary>
    public class RxgSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXG";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
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
        /// <para>Suggested: 0292 Vaccines Administered</para>
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
        /// <para>Suggested: 0715 Give Units</para>
        /// </summary>
        public CodedWithExceptions GiveUnits { get; set; }

        /// <summary>
        /// RXG.8 - Give Dosage Form.
        /// <para>Suggested: 0716 Give Dosage Form</para>
        /// </summary>
        public CodedWithExceptions GiveDosageForm { get; set; }

        /// <summary>
        /// RXG.9 - Administration Notes.
        /// <para>Suggested: 0691 Administration Notes</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> AdministrationNotes { get; set; }

        /// <summary>
        /// RXG.10 - Substitution Status.
        /// <para>Suggested: 0167 Substitution Status -&gt; ClearHl7.Codes.V290.CodeSubstitutionStatus</para>
        /// </summary>
        public string SubstitutionStatus { get; set; }

        /// <summary>
        /// RXG.11 - Dispense-to Location.
        /// </summary>
        public string DispenseToLocation { get; set; }

        /// <summary>
        /// RXG.12 - Needs Human Review.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V290.CodeYesNoIndicator</para>
        /// </summary>
        public string NeedsHumanReview { get; set; }

        /// <summary>
        /// RXG.13 - Special Administration Instructions.
        /// <para>Suggested: 0738 Special Administration Instructions</para>
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
        /// <para>Suggested: 0722 Give Rate Units</para>
        /// </summary>
        public CodedWithExceptions GiveRateUnits { get; set; }

        /// <summary>
        /// RXG.17 - Give Strength.
        /// </summary>
        public decimal? GiveStrength { get; set; }

        /// <summary>
        /// RXG.18 - Give Strength Units.
        /// <para>Suggested: 0723 Give Strength Units</para>
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
        /// </summary>
        public IEnumerable<CodedWithExceptions> SubstanceManufacturerName { get; set; }

        /// <summary>
        /// RXG.22 - Indication.
        /// <para>Suggested: 0694 Indication</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> Indication { get; set; }

        /// <summary>
        /// RXG.23 - Give Drug Strength Volume.
        /// </summary>
        public decimal? GiveDrugStrengthVolume { get; set; }

        /// <summary>
        /// RXG.24 - Give Drug Strength Volume Units.
        /// <para>Suggested: 0744 Give Drug Strength Volume Units</para>
        /// </summary>
        public CodedWithExceptions GiveDrugStrengthVolumeUnits { get; set; }

        /// <summary>
        /// RXG.25 - Give Barcode Identifier.
        /// <para>Suggested: 0745 Give Barcode Identifier</para>
        /// </summary>
        public CodedWithExceptions GiveBarcodeIdentifier { get; set; }

        /// <summary>
        /// RXG.26 - Pharmacy Order Type.
        /// <para>Suggested: 0480 Pharmacy Order Types -&gt; ClearHl7.Codes.V290.CodePharmacyOrderTypes</para>
        /// </summary>
        public string PharmacyOrderType { get; set; }

        /// <summary>
        /// RXG.27 - Dispense to Pharmacy.
        /// <para>Suggested: 0714 Dispense to Pharmacy</para>
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

        /// <summary>
        /// RXG.31 - Give Tag Identifier.
        /// </summary>
        public IEnumerable<EntityIdentifier> GiveTagIdentifier { get; set; }

        /// <summary>
        /// RXG.32 - Dispense Amount.
        /// </summary>
        public decimal? DispenseAmount { get; set; }

        /// <summary>
        /// RXG.33 - Dispense Units.
        /// <para>Suggested: 0746 Dispense Units</para>
        /// </summary>
        public CodedWithExceptions DispenseUnits { get; set; }

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

            GiveSubIdCounter = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            DispenseSubIdCounter = segments.ElementAtOrDefault(2)?.ToNullableDecimal();
            QuantityTiming = segments.ElementAtOrDefault(3);
            GiveCode = segments.Length > 4 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(4), false) : null;
            GiveAmountMinimum = segments.ElementAtOrDefault(5)?.ToNullableDecimal();
            GiveAmountMaximum = segments.ElementAtOrDefault(6)?.ToNullableDecimal();
            GiveUnits = segments.Length > 7 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(7), false) : null;
            GiveDosageForm = segments.Length > 8 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(8), false) : null;
            AdministrationNotes = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            SubstitutionStatus = segments.ElementAtOrDefault(10);
            DispenseToLocation = segments.ElementAtOrDefault(11);
            NeedsHumanReview = segments.ElementAtOrDefault(12);
            SpecialAdministrationInstructions = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            GivePerTimeUnit = segments.ElementAtOrDefault(14);
            GiveRateAmount = segments.ElementAtOrDefault(15);
            GiveRateUnits = segments.Length > 16 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(16), false) : null;
            GiveStrength = segments.ElementAtOrDefault(17)?.ToNullableDecimal();
            GiveStrengthUnits = segments.Length > 18 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(18), false) : null;
            SubstanceLotNumber = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator) : null;
            SubstanceExpirationDate = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => x.ToDateTime(Consts.DateTimeFormatPrecisionSecond)) : null;
            SubstanceManufacturerName = segments.Length > 21 ? segments.ElementAtOrDefault(21).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            Indication = segments.Length > 22 ? segments.ElementAtOrDefault(22).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            GiveDrugStrengthVolume = segments.ElementAtOrDefault(23)?.ToNullableDecimal();
            GiveDrugStrengthVolumeUnits = segments.Length > 24 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(24), false) : null;
            GiveBarcodeIdentifier = segments.Length > 25 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(25), false) : null;
            PharmacyOrderType = segments.ElementAtOrDefault(26);
            DispenseToPharmacy = segments.Length > 27 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(27), false) : null;
            DispenseToPharmacyAddress = segments.Length > 28 ? TypeHelper.Deserialize<ExtendedAddress>(segments.ElementAtOrDefault(28), false) : null;
            DeliverToPatientLocation = segments.Length > 29 ? TypeHelper.Deserialize<PersonLocation>(segments.ElementAtOrDefault(29), false) : null;
            DeliverToAddress = segments.Length > 30 ? TypeHelper.Deserialize<ExtendedAddress>(segments.ElementAtOrDefault(30), false) : null;
            GiveTagIdentifier = segments.Length > 31 ? segments.ElementAtOrDefault(31).Split(separator).Select(x => TypeHelper.Deserialize<EntityIdentifier>(x, false)) : null;
            DispenseAmount = segments.ElementAtOrDefault(32)?.ToNullableDecimal();
            DispenseUnits = segments.Length > 33 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(33), false) : null;
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
                                StringHelper.StringFormatSequence(0, 34, Configuration.FieldSeparator),
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
                                DispenseToLocation,
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
                                DeliverToAddress?.ToDelimitedString(),
                                GiveTagIdentifier != null ? string.Join(Configuration.FieldRepeatSeparator, GiveTagIdentifier.Select(x => x.ToDelimitedString())) : null,
                                DispenseAmount.HasValue ? DispenseAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseUnits?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}