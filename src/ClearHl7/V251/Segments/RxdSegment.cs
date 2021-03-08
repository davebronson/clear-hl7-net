using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXD - Pharmacy Treatment Dispense.
    /// </summary>
    public class RxdSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXD";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RXD.1 - Dispense Sub-ID Counter.
        /// </summary>
        public decimal? DispenseSubIdCounter { get; set; }

        /// <summary>
        /// RXD.2 - Dispense/Give Code.
        /// <para>Suggested: 0292 Vaccines Administered -&gt; ClearHl7.Codes.V251.CodeVaccinesAdministered</para>
        /// </summary>
        public CodedElement DispenseGiveCode { get; set; }

        /// <summary>
        /// RXD.3 - Date/Time Dispensed.
        /// </summary>
        public DateTime? DateTimeDispensed { get; set; }

        /// <summary>
        /// RXD.4 - Actual Dispense Amount.
        /// </summary>
        public decimal? ActualDispenseAmount { get; set; }

        /// <summary>
        /// RXD.5 - Actual Dispense Units.
        /// </summary>
        public CodedElement ActualDispenseUnits { get; set; }

        /// <summary>
        /// RXD.6 - Actual Dosage Form.
        /// </summary>
        public CodedElement ActualDosageForm { get; set; }

        /// <summary>
        /// RXD.7 - Prescription Number.
        /// </summary>
        public string PrescriptionNumber { get; set; }

        /// <summary>
        /// RXD.8 - Number of Refills Remaining.
        /// </summary>
        public decimal? NumberOfRefillsRemaining { get; set; }

        /// <summary>
        /// RXD.9 - Dispense Notes.
        /// </summary>
        public IEnumerable<string> DispenseNotes { get; set; }

        /// <summary>
        /// RXD.10 - Dispensing Provider.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> DispensingProvider { get; set; }

        /// <summary>
        /// RXD.11 - Substitution Status.
        /// <para>Suggested: 0167 Substitution Status -&gt; ClearHl7.Codes.V251.CodeSubstitutionStatus</para>
        /// </summary>
        public string SubstitutionStatus { get; set; }

        /// <summary>
        /// RXD.12 - Total Daily Dose.
        /// </summary>
        public CompositeQuantityWithUnits TotalDailyDose { get; set; }

        /// <summary>
        /// RXD.13 - Dispense-to Location.
        /// </summary>
        public LocationWithAddressVariationTwo DispenseToLocation { get; set; }

        /// <summary>
        /// RXD.14 - Needs Human Review.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
        /// </summary>
        public string NeedsHumanReview { get; set; }

        /// <summary>
        /// RXD.15 - Special Dispensing Instructions.
        /// </summary>
        public IEnumerable<CodedElement> SpecialDispensingInstructions { get; set; }

        /// <summary>
        /// RXD.16 - Actual Strength.
        /// </summary>
        public decimal? ActualStrength { get; set; }

        /// <summary>
        /// RXD.17 - Actual Strength Unit.
        /// </summary>
        public CodedElement ActualStrengthUnit { get; set; }
     
        /// <summary>
        /// RXD.18 - Substance Lot Number.
        /// </summary>
        public IEnumerable<string> SubstanceLotNumber { get; set; }

        /// <summary>
        /// RXD.19 - Substance Expiration Date.
        /// </summary>
        public IEnumerable<DateTime> SubstanceExpirationDate { get; set; }

        /// <summary>
        /// RXD.20 - Substance Manufacturer Name.
        /// <para>Suggested: 0227 Manufacturers Of Vaccines (code=MVX) -&gt; ClearHl7.Codes.V251.CodeManufacturersOfVaccines</para>
        /// </summary>
        public IEnumerable<CodedElement> SubstanceManufacturerName { get; set; }

        /// <summary>
        /// RXD.21 - Indication.
        /// </summary>
        public IEnumerable<CodedElement> Indication { get; set; }

        /// <summary>
        /// RXD.22 - Dispense Package Size.
        /// </summary>
        public decimal? DispensePackageSize { get; set; }

        /// <summary>
        /// RXD.23 - Dispense Package Size Unit.
        /// </summary>
        public CodedElement DispensePackageSizeUnit { get; set; }

        /// <summary>
        /// RXD.24 - Dispense Package Method.
        /// <para>Suggested: 0321 Dispense Method -&gt; ClearHl7.Codes.V251.CodeDispenseMethod</para>
        /// </summary>
        public string DispensePackageMethod { get; set; }

        /// <summary>
        /// RXD.25 - Supplementary Code.
        /// </summary>
        public IEnumerable<CodedElement> SupplementaryCode { get; set; }

        /// <summary>
        /// RXD.26 - Initiating Location.
        /// </summary>
        public CodedElement InitiatingLocation { get; set; }

        /// <summary>
        /// RXD.27 - Packaging/Assembly Location.
        /// </summary>
        public CodedElement PackagingAssemblyLocation { get; set; }

        /// <summary>
        /// RXD.28 - Actual Drug Strength Volume.
        /// </summary>
        public decimal? ActualDrugStrengthVolume { get; set; }

        /// <summary>
        /// RXD.29 - Actual Drug Strength Volume Units.
        /// </summary>
        public CodedWithExceptions ActualDrugStrengthVolumeUnits { get; set; }

        /// <summary>
        /// RXD.30 - Dispense to Pharmacy.
        /// </summary>
        public CodedWithExceptions DispenseToPharmacy { get; set; }

        /// <summary>
        /// RXD.31 - Dispense to Pharmacy Address.
        /// </summary>
        public ExtendedAddress DispenseToPharmacyAddress { get; set; }

        /// <summary>
        /// RXD.32 - Pharmacy Order Type.
        /// <para>Suggested: 0480 Pharmacy Order Types -&gt; ClearHl7.Codes.V251.CodePharmacyOrderTypes</para>
        /// </summary>
        public string PharmacyOrderType { get; set; }

        /// <summary>
        /// RXD.33 - Dispense Type.
        /// <para>Suggested: 0484 Dispense Type -&gt; ClearHl7.Codes.V251.CodeDispenseType</para>
        /// </summary>
        public CodedWithExceptions DispenseType { get; set; }

        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 34, Configuration.FieldSeparator),
                                Id,
                                DispenseSubIdCounter.HasValue ? DispenseSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseGiveCode?.ToDelimitedString(),
                                DateTimeDispensed.HasValue ? DateTimeDispensed.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
                                ActualDispenseAmount.HasValue ? ActualDispenseAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                ActualDispenseUnits?.ToDelimitedString(),
                                ActualDosageForm?.ToDelimitedString(),
                                PrescriptionNumber,
                                NumberOfRefillsRemaining.HasValue ? NumberOfRefillsRemaining.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseNotes != null ? string.Join(Configuration.FieldRepeatSeparator, DispenseNotes) : null,
                                DispensingProvider != null ? string.Join(Configuration.FieldRepeatSeparator, DispensingProvider.Select(x => x.ToDelimitedString())) : null,
                                SubstitutionStatus,
                                TotalDailyDose?.ToDelimitedString(),
                                DispenseToLocation?.ToDelimitedString(),
                                NeedsHumanReview,
                                SpecialDispensingInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, SpecialDispensingInstructions.Select(x => x.ToDelimitedString())) : null,
                                ActualStrength.HasValue ? ActualStrength.Value.ToString(Consts.NumericFormat, culture) : null,
                                ActualStrengthUnit?.ToDelimitedString(),
                                SubstanceLotNumber != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceLotNumber) : null,
                                SubstanceExpirationDate != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceExpirationDate.Select(x => x.ToString(Consts.DateTimeFormatPrecisionSecond, culture))) : null,
                                SubstanceManufacturerName != null ? string.Join(Configuration.FieldRepeatSeparator, SubstanceManufacturerName.Select(x => x.ToDelimitedString())) : null,
                                Indication != null ? string.Join(Configuration.FieldRepeatSeparator, Indication.Select(x => x.ToDelimitedString())) : null,
                                DispensePackageSize.HasValue ? DispensePackageSize.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispensePackageSizeUnit?.ToDelimitedString(),
                                DispensePackageMethod,
                                SupplementaryCode != null ? string.Join(Configuration.FieldRepeatSeparator, SupplementaryCode.Select(x => x.ToDelimitedString())) : null,
                                InitiatingLocation?.ToDelimitedString(),
                                PackagingAssemblyLocation?.ToDelimitedString(),
                                ActualDrugStrengthVolume.HasValue ? ActualDrugStrengthVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                ActualDrugStrengthVolumeUnits?.ToDelimitedString(),
                                DispenseToPharmacy?.ToDelimitedString(),
                                DispenseToPharmacyAddress?.ToDelimitedString(),
                                PharmacyOrderType,
                                DispenseType?.ToDelimitedString()
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}