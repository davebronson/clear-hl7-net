using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V230.Types;

namespace ClearHl7.V230.Segments
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
        /// <para>Suggested: 0292 Vaccines Administered -&gt; ClearHl7.Codes.V230.CodeVaccinesAdministered</para>
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
        public IEnumerable<CodedElement> DispenseNotes { get; set; }

        /// <summary>
        /// RXD.10 - Dispensing Provider.
        /// </summary>
        public ExtendedCompositeIdNumberAndNameForPersons DispensingProvider { get; set; }

        /// <summary>
        /// RXD.11 - Substitution Status.
        /// <para>Suggested: 0167 Substitution Status -&gt; ClearHl7.Codes.V230.CodeSubstitutionStatus</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V230.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0321 Dispense Method -&gt; ClearHl7.Codes.V230.CodeDispenseMethod</para>
        /// </summary>
        public string DispensePackageMethod { get; set; }

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

            DispenseSubIdCounter = segments.ElementAtOrDefault(1)?.ToNullableDecimal();
            DispenseGiveCode = segments.Length > 2 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(2), false) : null;
            DateTimeDispensed = segments.ElementAtOrDefault(3)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            ActualDispenseAmount = segments.ElementAtOrDefault(4)?.ToNullableDecimal();
            ActualDispenseUnits = segments.Length > 5 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(5), false) : null;
            ActualDosageForm = segments.Length > 6 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(6), false) : null;
            PrescriptionNumber = segments.ElementAtOrDefault(7);
            NumberOfRefillsRemaining = segments.ElementAtOrDefault(8)?.ToNullableDecimal();
            DispenseNotes = segments.Length > 9 ? segments.ElementAtOrDefault(9).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            DispensingProvider = segments.Length > 10 ? TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(segments.ElementAtOrDefault(10), false) : null;
            SubstitutionStatus = segments.ElementAtOrDefault(11);
            TotalDailyDose = segments.Length > 12 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(12), false) : null;
            DispenseToLocation = segments.Length > 13 ? TypeHelper.Deserialize<LocationWithAddressVariationTwo>(segments.ElementAtOrDefault(13), false) : null;
            NeedsHumanReview = segments.ElementAtOrDefault(14);
            SpecialDispensingInstructions = segments.Length > 15 ? segments.ElementAtOrDefault(15).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            ActualStrength = segments.ElementAtOrDefault(16)?.ToNullableDecimal();
            ActualStrengthUnit = segments.Length > 17 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(17), false) : null;
            SubstanceLotNumber = segments.Length > 18 ? segments.ElementAtOrDefault(18).Split(separator) : null;
            SubstanceExpirationDate = segments.Length > 19 ? segments.ElementAtOrDefault(19).Split(separator).Select(x => x.ToDateTime(Consts.DateTimeFormatPrecisionSecond)) : null;
            SubstanceManufacturerName = segments.Length > 20 ? segments.ElementAtOrDefault(20).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            Indication = segments.Length > 21 ? segments.ElementAtOrDefault(21).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            DispensePackageSize = segments.ElementAtOrDefault(22)?.ToNullableDecimal();
            DispensePackageSizeUnit = segments.Length > 23 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(23), false) : null;
            DispensePackageMethod = segments.ElementAtOrDefault(24);
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
                                StringHelper.StringFormatSequence(0, 25, Configuration.FieldSeparator),
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
                                DispensingProvider?.ToDelimitedString(),
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