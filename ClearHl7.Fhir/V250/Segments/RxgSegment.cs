using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.V250.Types;

namespace ClearHl7.Fhir.V250.Segments
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
        public TimingQuantity QuantityTiming { get; set; }

        /// <summary>
        /// RXG.4 - Give Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0292</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0167</remarks>
        public string SubstitutionStatus { get; set; }

        /// <summary>
        /// RXG.11 - Dispense-to Location.
        /// </summary>
        public LocationWithAddressVariationTwo DispenseToLocation { get; set; }

        /// <summary>
        /// RXG.12 - Needs Human Review.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
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
        /// <remarks>https://www.hl7.org/fhir/v2/0227</remarks>
        public IEnumerable<CodedElement> SubstanceManufacturerName { get; set; }

        /// <summary>
        /// RXG.22 - Indication.
        /// </summary>
        public IEnumerable<CodedElement> Indication { get; set; }

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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0480</remarks>
        public string PharmacyOrderType { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                "{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}",
                                Id,
                                GiveSubIdCounter.HasValue ? GiveSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseSubIdCounter.HasValue ? GiveSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                QuantityTiming?.ToDelimitedString(),
                                GiveCode?.ToDelimitedString(),
                                GiveAmountMinimum.HasValue ? GiveAmountMinimum.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveAmountMaximum.HasValue ? GiveAmountMaximum.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveUnits?.ToDelimitedString(),
                                GiveDosageForm?.ToDelimitedString(),
                                AdministrationNotes != null ? string.Join("~", AdministrationNotes.Select(x => x.ToDelimitedString())) : null,
                                SubstitutionStatus,
                                DispenseToLocation?.ToDelimitedString(),
                                NeedsHumanReview,
                                SpecialAdministrationInstructions != null ? string.Join("~", SpecialAdministrationInstructions.Select(x => x.ToDelimitedString())) : null,
                                GivePerTimeUnit,
                                GiveRateAmount,
                                GiveRateUnits?.ToDelimitedString(),
                                GiveStrength.HasValue ? GiveStrength.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveStrengthUnits?.ToDelimitedString(),
                                SubstanceLotNumber != null ? string.Join("~", SubstanceLotNumber) : null,
                                SubstanceExpirationDate != null ? string.Join("~", SubstanceExpirationDate.Select(x => x.ToString(Consts.DateTimeFormatPrecisionSecond, culture))) : null,
                                SubstanceManufacturerName != null ? string.Join("~", SubstanceManufacturerName.Select(x => x.ToDelimitedString())) : null,
                                Indication != null ? string.Join("~", Indication.Select(x => x.ToDelimitedString())) : null,
                                GiveDrugStrengthVolume.HasValue ? GiveDrugStrengthVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveDrugStrengthVolumeUnits?.ToDelimitedString(),
                                GiveBarcodeIdentifier?.ToDelimitedString(),
                                PharmacyOrderType
                                ).TrimEnd('|');
        }
    }
}