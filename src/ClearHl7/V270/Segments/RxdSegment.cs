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
    /// HL7 Version 2 Segment RXD - Pharmacy Treatment Dispense.
    /// </summary>
    public class RxdSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RxdSegment"/> class.
        /// </summary>
        public RxdSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RxdSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public RxdSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "RXD";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// RXD.1 - Dispense Sub-ID Counter.
        /// </summary>
        public decimal? DispenseSubIdCounter { get; set; }

        /// <summary>
        /// RXD.2 - Dispense/Give Code.
        /// <para>Suggested: 0292 Vaccines Administered -&gt; ClearHl7.Codes.V270.CodeVaccinesAdministered</para>
        /// </summary>
        public CodedWithExceptions DispenseGiveCode { get; set; }

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
        public CodedWithExceptions ActualDispenseUnits { get; set; }

        /// <summary>
        /// RXD.6 - Actual Dosage Form.
        /// </summary>
        public CodedWithExceptions ActualDosageForm { get; set; }

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
        /// <para>Suggested: 0167 Substitution Status -&gt; ClearHl7.Codes.V270.CodeSubstitutionStatus</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V270.CodeYesNoIndicator</para>
        /// </summary>
        public string NeedsHumanReview { get; set; }

        /// <summary>
        /// RXD.15 - Special Dispensing Instructions.
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecialDispensingInstructions { get; set; }

        /// <summary>
        /// RXD.16 - Actual Strength.
        /// </summary>
        public decimal? ActualStrength { get; set; }

        /// <summary>
        /// RXD.17 - Actual Strength Unit.
        /// </summary>
        public CodedWithExceptions ActualStrengthUnit { get; set; }

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
        /// <para>Suggested: 0227 Manufacturers Of Vaccines (code=MVX) -&gt; ClearHl7.Codes.V270.CodeManufacturersOfVaccines</para>
        /// </summary>
        public IEnumerable<CodedWithExceptions> SubstanceManufacturerName { get; set; }

        /// <summary>
        /// RXD.21 - Indication.
        /// </summary>
        public IEnumerable<CodedWithExceptions> Indication { get; set; }

        /// <summary>
        /// RXD.22 - Dispense Package Size.
        /// </summary>
        public decimal? DispensePackageSize { get; set; }

        /// <summary>
        /// RXD.23 - Dispense Package Size Unit.
        /// </summary>
        public CodedWithExceptions DispensePackageSizeUnit { get; set; }

        /// <summary>
        /// RXD.24 - Dispense Package Method.
        /// <para>Suggested: 0321 Dispense Method -&gt; ClearHl7.Codes.V270.CodeDispenseMethod</para>
        /// </summary>
        public string DispensePackageMethod { get; set; }

        /// <summary>
        /// RXD.25 - Supplementary Code.
        /// </summary>
        public IEnumerable<CodedWithExceptions> SupplementaryCode { get; set; }

        /// <summary>
        /// RXD.26 - Initiating Location.
        /// </summary>
        public CodedWithExceptions InitiatingLocation { get; set; }

        /// <summary>
        /// RXD.27 - Packaging/Assembly Location.
        /// </summary>
        public CodedWithExceptions PackagingAssemblyLocation { get; set; }

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
        /// <para>Suggested: 0480 Pharmacy Order Types -&gt; ClearHl7.Codes.V270.CodePharmacyOrderTypes</para>
        /// </summary>
        public string PharmacyOrderType { get; set; }

        /// <summary>
        /// RXD.33 - Dispense Type.
        /// <para>Suggested: 0484 Dispense Type -&gt; ClearHl7.Codes.V270.CodeDispenseType</para>
        /// </summary>
        public CodedWithExceptions DispenseType { get; set; }

        /// <summary>
        /// RXD.34 - Pharmacy Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> PharmacyPhoneNumber { get; set; }

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

            DispenseSubIdCounter = segments.Length > 1 && segments[1].Length > 0 ? segments[1].ToNullableDecimal() : null;
            DispenseGiveCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            DateTimeDispensed = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            ActualDispenseAmount = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            ActualDispenseUnits = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            ActualDosageForm = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            PrescriptionNumber = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            NumberOfRefillsRemaining = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            DispenseNotes = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            DispensingProvider = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            SubstitutionStatus = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            TotalDailyDose = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[12], false, seps) : null;
            DispenseToLocation = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<LocationWithAddressVariationTwo>(segments[13], false, seps) : null;
            NeedsHumanReview = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            SpecialDispensingInstructions = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            ActualStrength = segments.Length > 16 && segments[16].Length > 0 ? segments[16].ToNullableDecimal() : null;
            ActualStrengthUnit = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[17], false, seps) : null;
            SubstanceLotNumber = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SubstanceExpirationDate = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDateTime()) : null;
            SubstanceManufacturerName = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            Indication = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            DispensePackageSize = segments.Length > 22 && segments[22].Length > 0 ? segments[22].ToNullableDecimal() : null;
            DispensePackageSizeUnit = segments.Length > 23 && segments[23].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[23], false, seps) : null;
            DispensePackageMethod = segments.Length > 24 && segments[24].Length > 0 ? segments[24] : null;
            SupplementaryCode = segments.Length > 25 && segments[25].Length > 0 ? segments[25].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            InitiatingLocation = segments.Length > 26 && segments[26].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[26], false, seps) : null;
            PackagingAssemblyLocation = segments.Length > 27 && segments[27].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[27], false, seps) : null;
            ActualDrugStrengthVolume = segments.Length > 28 && segments[28].Length > 0 ? segments[28].ToNullableDecimal() : null;
            ActualDrugStrengthVolumeUnits = segments.Length > 29 && segments[29].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[29], false, seps) : null;
            DispenseToPharmacy = segments.Length > 30 && segments[30].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[30], false, seps) : null;
            DispenseToPharmacyAddress = segments.Length > 31 && segments[31].Length > 0 ? TypeSerializer.Deserialize<ExtendedAddress>(segments[31], false, seps) : null;
            PharmacyOrderType = segments.Length > 32 && segments[32].Length > 0 ? segments[32] : null;
            DispenseType = segments.Length > 33 && segments[33].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[33], false, seps) : null;
            PharmacyPhoneNumber = segments.Length > 34 && segments[34].Length > 0 ? segments[34].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 35, Configuration.FieldSeparator),
                                Id,
                                DispenseSubIdCounter.HasValue ? DispenseSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseGiveCode?.ToDelimitedString(),
                                DateTimeDispensed.ToHl7DateTimeString(typeof(RxdSegment), nameof(DateTimeDispensed), Consts.DateTimeFormatPrecisionSecond, culture),
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
                                DispenseType?.ToDelimitedString(),
                                PharmacyPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, PharmacyPhoneNumber.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
