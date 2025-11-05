using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V231.Types;

namespace ClearHl7.V231.Segments
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
        /// <para>Suggested: 0292 Vaccines Administered -&gt; ClearHl7.Codes.V231.CodeVaccinesAdministered</para>
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
        /// <para>Suggested: 0167 Substitution Status -&gt; ClearHl7.Codes.V231.CodeSubstitutionStatus</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V231.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0227 Manufacturers Of Vaccines (code=MVX) -&gt; ClearHl7.Codes.V231.CodeManufacturersOfVaccines</para>
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
        /// <para>Suggested: 0321 Dispense Method -&gt; ClearHl7.Codes.V231.CodeDispenseMethod</para>
        /// </summary>
        public string DispensePackageMethod { get; set; }

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
            DispenseGiveCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[2], false, seps) : null;
            DateTimeDispensed = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDateTime() : null;
            ActualDispenseAmount = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            ActualDispenseUnits = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[5], false, seps) : null;
            ActualDosageForm = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[6], false, seps) : null;
            PrescriptionNumber = segments.Length > 7 && segments[7].Length > 0 ? segments[7] : null;
            NumberOfRefillsRemaining = segments.Length > 8 && segments[8].Length > 0 ? segments[8].ToNullableDecimal() : null;
            DispenseNotes = segments.Length > 9 && segments[9].Length > 0 ? segments[9].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            DispensingProvider = segments.Length > 10 && segments[10].Length > 0 ? segments[10].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            SubstitutionStatus = segments.Length > 11 && segments[11].Length > 0 ? segments[11] : null;
            TotalDailyDose = segments.Length > 12 && segments[12].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[12], false, seps) : null;
            DispenseToLocation = segments.Length > 13 && segments[13].Length > 0 ? TypeSerializer.Deserialize<LocationWithAddressVariationTwo>(segments[13], false, seps) : null;
            NeedsHumanReview = segments.Length > 14 && segments[14].Length > 0 ? segments[14] : null;
            SpecialDispensingInstructions = segments.Length > 15 && segments[15].Length > 0 ? segments[15].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            ActualStrength = segments.Length > 16 && segments[16].Length > 0 ? segments[16].ToNullableDecimal() : null;
            ActualStrengthUnit = segments.Length > 17 && segments[17].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[17], false, seps) : null;
            SubstanceLotNumber = segments.Length > 18 && segments[18].Length > 0 ? segments[18].Split(seps.FieldRepeatSeparator, StringSplitOptions.None) : null;
            SubstanceExpirationDate = segments.Length > 19 && segments[19].Length > 0 ? segments[19].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => x.ToDateTime()) : null;
            SubstanceManufacturerName = segments.Length > 20 && segments[20].Length > 0 ? segments[20].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            Indication = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            DispensePackageSize = segments.Length > 22 && segments[22].Length > 0 ? segments[22].ToNullableDecimal() : null;
            DispensePackageSizeUnit = segments.Length > 23 && segments[23].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[23], false, seps) : null;
            DispensePackageMethod = segments.Length > 24 && segments[24].Length > 0 ? segments[24] : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 25, Configuration.FieldSeparator),
                                Id,
                                DispenseSubIdCounter.HasValue ? DispenseSubIdCounter.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseGiveCode?.ToDelimitedString(),
                                DateTimeDispensed?.ToHl7DateTimeString(typeof(RxdSegment), nameof(DateTimeDispensed), Consts.DateTimeFormatPrecisionSecond, culture),
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
                                DispensePackageMethod
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
