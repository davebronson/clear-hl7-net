using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V240.Types;

namespace ClearHl7.V240.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXE - Pharmacy Treatment Encoded Order.
    /// </summary>
    public class RxeSegment : ISegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RxeSegment"/> class.
        /// </summary>
        public RxeSegment()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RxeSegment"/> class.
        /// </summary>
        /// <param name="ordinal">The rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.</param>
        public RxeSegment(int ordinal)
        {
            Ordinal = ordinal;
        }

        /// <inheritdoc/>
        public string Id => "RXE";

        /// <inheritdoc/>
        public int Ordinal { get; set; }

        /// <summary>
        /// RXE.1 - Quantity/Timing.
        /// </summary>
        public TimingQuantity QuantityTiming { get; set; }

        /// <summary>
        /// RXE.2 - Give Code.
        /// <para>Suggested: 0292 Vaccines Administered -&gt; ClearHl7.Codes.V240.CodeVaccinesAdministered</para>
        /// </summary>
        public CodedElement GiveCode { get; set; }

        /// <summary>
        /// RXE.3 - Give Amount - Minimum.
        /// </summary>
        public decimal? GiveAmountMinimum { get; set; }

        /// <summary>
        /// RXE.4 - Give Amount - Maximum.
        /// </summary>
        public decimal? GiveAmountMaximum { get; set; }

        /// <summary>
        /// RXE.5 - Give Units.
        /// </summary>
        public CodedElement GiveUnits { get; set; }

        /// <summary>
        /// RXE.6 - Give Dosage Form.
        /// </summary>
        public CodedElement GiveDosageForm { get; set; }

        /// <summary>
        /// RXE.7 - Provider's Administration Instructions.
        /// </summary>
        public IEnumerable<CodedElement> ProvidersAdministrationInstructions { get; set; }

        /// <summary>
        /// RXE.8 - Deliver-To Location.
        /// </summary>
        public LocationWithAddressVariationOne DeliverToLocation { get; set; }

        /// <summary>
        /// RXE.9 - Substitution Status.
        /// <para>Suggested: 0167 Substitution Status -&gt; ClearHl7.Codes.V240.CodeSubstitutionStatus</para>
        /// </summary>
        public string SubstitutionStatus { get; set; }

        /// <summary>
        /// RXE.10 - Dispense Amount.
        /// </summary>
        public decimal? DispenseAmount { get; set; }

        /// <summary>
        /// RXE.11 - Dispense Units.
        /// </summary>
        public CodedElement DispenseUnits { get; set; }

        /// <summary>
        /// RXE.12 - Number Of Refills.
        /// </summary>
        public decimal? NumberOfRefills { get; set; }

        /// <summary>
        /// RXE.13 - Ordering Provider's DEA Number.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> OrderingProvidersDeaNumber { get; set; }

        /// <summary>
        /// RXE.14 - Pharmacist/Treatment Supplier's Verifier ID.
        /// </summary>
        public IEnumerable<ExtendedCompositeIdNumberAndNameForPersons> PharmacistTreatmentSuppliersVerifierId { get; set; }

        /// <summary>
        /// RXE.15 - Prescription Number.
        /// </summary>
        public string PrescriptionNumber { get; set; }

        /// <summary>
        /// RXE.16 - Number of Refills Remaining.
        /// </summary>
        public decimal? NumberOfRefillsRemaining { get; set; }

        /// <summary>
        /// RXE.17 - Number of Refills/Doses Dispensed.
        /// </summary>
        public decimal? NumberOfRefillsDosesDispensed { get; set; }

        /// <summary>
        /// RXE.18 - D/T of Most Recent Refill or Dose Dispensed.
        /// </summary>
        public DateTime? DateTimeOfMostRecentRefillOrDoseDispensed { get; set; }

        /// <summary>
        /// RXE.19 - Total Daily Dose.
        /// </summary>
        public CompositeQuantityWithUnits TotalDailyDose { get; set; }

        /// <summary>
        /// RXE.20 - Needs Human Review.
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V240.CodeYesNoIndicator</para>
        /// </summary>
        public string NeedsHumanReview { get; set; }

        /// <summary>
        /// RXE.21 - Special Dispensing Instructions.
        /// </summary>
        public IEnumerable<CodedElement> SpecialDispensingInstructions { get; set; }

        /// <summary>
        /// RXE.22 - Give Per (Time Unit).
        /// </summary>
        public string GivePerTimeUnit { get; set; }

        /// <summary>
        /// RXE.23 - Give Rate Amount.
        /// </summary>
        public string GiveRateAmount { get; set; }

        /// <summary>
        /// RXE.24 - Give Rate Units.
        /// </summary>
        public CodedElement GiveRateUnits { get; set; }

        /// <summary>
        /// RXE.25 - Give Strength.
        /// </summary>
        public decimal? GiveStrength { get; set; }

        /// <summary>
        /// RXE.26 - Give Strength Units.
        /// </summary>
        public CodedElement GiveStrengthUnits { get; set; }

        /// <summary>
        /// RXE.27 - Give Indication.
        /// </summary>
        public IEnumerable<CodedElement> GiveIndication { get; set; }

        /// <summary>
        /// RXE.28 - Dispense Package Size.
        /// </summary>
        public decimal? DispensePackageSize { get; set; }

        /// <summary>
        /// RXE.29 - Dispense Package Size Unit.
        /// </summary>
        public CodedElement DispensePackageSizeUnit { get; set; }

        /// <summary>
        /// RXE.30 - Dispense Package Method.
        /// <para>Suggested: 0321 Dispense Method -&gt; ClearHl7.Codes.V240.CodeDispenseMethod</para>
        /// </summary>
        public string DispensePackageMethod { get; set; }

        /// <summary>
        /// RXE.31 - Supplementary Code.
        /// </summary>
        public IEnumerable<CodedElement> SupplementaryCode { get; set; }

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

            QuantityTiming = segments.Length > 1 && segments[1].Length > 0 ? TypeSerializer.Deserialize<TimingQuantity>(segments[1], false, seps) : null;
            GiveCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[2], false, seps) : null;
            GiveAmountMinimum = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            GiveAmountMaximum = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            GiveUnits = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[5], false, seps) : null;
            GiveDosageForm = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[6], false, seps) : null;
            ProvidersAdministrationInstructions = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            DeliverToLocation = segments.Length > 8 && segments[8].Length > 0 ? TypeSerializer.Deserialize<LocationWithAddressVariationOne>(segments[8], false, seps) : null;
            SubstitutionStatus = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            DispenseAmount = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
            DispenseUnits = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[11], false, seps) : null;
            NumberOfRefills = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDecimal() : null;
            OrderingProvidersDeaNumber = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            PharmacistTreatmentSuppliersVerifierId = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            PrescriptionNumber = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            NumberOfRefillsRemaining = segments.Length > 16 && segments[16].Length > 0 ? segments[16].ToNullableDecimal() : null;
            NumberOfRefillsDosesDispensed = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDecimal() : null;
            DateTimeOfMostRecentRefillOrDoseDispensed = segments.Length > 18 && segments[18].Length > 0 ? segments[18].ToNullableDateTime() : null;
            TotalDailyDose = segments.Length > 19 && segments[19].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[19], false, seps) : null;
            NeedsHumanReview = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            SpecialDispensingInstructions = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            GivePerTimeUnit = segments.Length > 22 && segments[22].Length > 0 ? segments[22] : null;
            GiveRateAmount = segments.Length > 23 && segments[23].Length > 0 ? segments[23] : null;
            GiveRateUnits = segments.Length > 24 && segments[24].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[24], false, seps) : null;
            GiveStrength = segments.Length > 25 && segments[25].Length > 0 ? segments[25].ToNullableDecimal() : null;
            GiveStrengthUnits = segments.Length > 26 && segments[26].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[26], false, seps) : null;
            GiveIndication = segments.Length > 27 && segments[27].Length > 0 ? segments[27].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
            DispensePackageSize = segments.Length > 28 && segments[28].Length > 0 ? segments[28].ToNullableDecimal() : null;
            DispensePackageSizeUnit = segments.Length > 29 && segments[29].Length > 0 ? TypeSerializer.Deserialize<CodedElement>(segments[29], false, seps) : null;
            DispensePackageMethod = segments.Length > 30 && segments[30].Length > 0 ? segments[30] : null;
            SupplementaryCode = segments.Length > 31 && segments[31].Length > 0 ? segments[31].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedElement>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 32, Configuration.FieldSeparator),
                                Id,
                                QuantityTiming?.ToDelimitedString(),
                                GiveCode?.ToDelimitedString(),
                                GiveAmountMinimum.HasValue ? GiveAmountMinimum.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveAmountMaximum.HasValue ? GiveAmountMaximum.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveUnits?.ToDelimitedString(),
                                GiveDosageForm?.ToDelimitedString(),
                                ProvidersAdministrationInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, ProvidersAdministrationInstructions.Select(x => x.ToDelimitedString())) : null,
                                DeliverToLocation?.ToDelimitedString(),
                                SubstitutionStatus,
                                DispenseAmount.HasValue ? DispenseAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseUnits?.ToDelimitedString(),
                                NumberOfRefills.HasValue ? NumberOfRefills.Value.ToString(Consts.NumericFormat, culture) : null,
                                OrderingProvidersDeaNumber != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingProvidersDeaNumber.Select(x => x.ToDelimitedString())) : null,
                                PharmacistTreatmentSuppliersVerifierId != null ? string.Join(Configuration.FieldRepeatSeparator, PharmacistTreatmentSuppliersVerifierId.Select(x => x.ToDelimitedString())) : null,
                                PrescriptionNumber,
                                NumberOfRefillsRemaining.HasValue ? NumberOfRefillsRemaining.Value.ToString(Consts.NumericFormat, culture) : null,
                                NumberOfRefillsDosesDispensed.HasValue ? NumberOfRefillsDosesDispensed.Value.ToString(Consts.NumericFormat, culture) : null,
                                DateTimeOfMostRecentRefillOrDoseDispensed?.ToHl7DateTimeString(typeof(RxeSegment), nameof(DateTimeOfMostRecentRefillOrDoseDispensed), Consts.DateTimeFormatPrecisionSecond, culture),
                                TotalDailyDose?.ToDelimitedString(),
                                NeedsHumanReview,
                                SpecialDispensingInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, SpecialDispensingInstructions.Select(x => x.ToDelimitedString())) : null,
                                GivePerTimeUnit,
                                GiveRateAmount,
                                GiveRateUnits?.ToDelimitedString(),
                                GiveStrength.HasValue ? GiveStrength.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveStrengthUnits?.ToDelimitedString(),
                                GiveIndication != null ? string.Join(Configuration.FieldRepeatSeparator, GiveIndication.Select(x => x.ToDelimitedString())) : null,
                                DispensePackageSize.HasValue ? DispensePackageSize.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispensePackageSizeUnit?.ToDelimitedString(),
                                DispensePackageMethod,
                                SupplementaryCode != null ? string.Join(Configuration.FieldRepeatSeparator, SupplementaryCode.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
