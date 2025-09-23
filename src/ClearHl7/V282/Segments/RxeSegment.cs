using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.Serialization;
using ClearHl7.V282.Types;

namespace ClearHl7.V282.Segments
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
        public string QuantityTiming { get; set; }

        /// <summary>
        /// RXE.2 - Give Code.
        /// <para>Suggested: 0292 Vaccines Administered -&gt; ClearHl7.Codes.V282.CodeVaccinesAdministered</para>
        /// </summary>
        public CodedWithExceptions GiveCode { get; set; }

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
        public CodedWithExceptions GiveUnits { get; set; }

        /// <summary>
        /// RXE.6 - Give Dosage Form.
        /// </summary>
        public CodedWithExceptions GiveDosageForm { get; set; }

        /// <summary>
        /// RXE.7 - Provider's Administration Instructions.
        /// </summary>
        public IEnumerable<CodedWithExceptions> ProvidersAdministrationInstructions { get; set; }

        /// <summary>
        /// RXE.8 - Deliver-To Location.
        /// </summary>
        public string DeliverToLocation { get; set; }

        /// <summary>
        /// RXE.9 - Substitution Status.
        /// <para>Suggested: 0167 Substitution Status -&gt; ClearHl7.Codes.V282.CodeSubstitutionStatus</para>
        /// </summary>
        public string SubstitutionStatus { get; set; }

        /// <summary>
        /// RXE.10 - Dispense Amount.
        /// </summary>
        public decimal? DispenseAmount { get; set; }

        /// <summary>
        /// RXE.11 - Dispense Units.
        /// </summary>
        public CodedWithExceptions DispenseUnits { get; set; }

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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V282.CodeYesNoIndicator</para>
        /// </summary>
        public string NeedsHumanReview { get; set; }

        /// <summary>
        /// RXE.21 - Special Dispensing Instructions.
        /// </summary>
        public IEnumerable<CodedWithExceptions> SpecialDispensingInstructions { get; set; }

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
        public CodedWithExceptions GiveRateUnits { get; set; }

        /// <summary>
        /// RXE.25 - Give Strength.
        /// </summary>
        public decimal? GiveStrength { get; set; }

        /// <summary>
        /// RXE.26 - Give Strength Units.
        /// </summary>
        public CodedWithExceptions GiveStrengthUnits { get; set; }

        /// <summary>
        /// RXE.27 - Give Indication.
        /// </summary>
        public IEnumerable<CodedWithExceptions> GiveIndication { get; set; }

        /// <summary>
        /// RXE.28 - Dispense Package Size.
        /// </summary>
        public decimal? DispensePackageSize { get; set; }

        /// <summary>
        /// RXE.29 - Dispense Package Size Unit.
        /// </summary>
        public CodedWithExceptions DispensePackageSizeUnit { get; set; }

        /// <summary>
        /// RXE.30 - Dispense Package Method.
        /// <para>Suggested: 0321 Dispense Method -&gt; ClearHl7.Codes.V282.CodeDispenseMethod</para>
        /// </summary>
        public string DispensePackageMethod { get; set; }

        /// <summary>
        /// RXE.31 - Supplementary Code.
        /// </summary>
        public IEnumerable<CodedWithExceptions> SupplementaryCode { get; set; }

        /// <summary>
        /// RXE.32 - Original Order Date/Time.
        /// </summary>
        public DateTime? OriginalOrderDateTime { get; set; }

        /// <summary>
        /// RXE.33 - Give Drug Strength Volume.
        /// </summary>
        public decimal? GiveDrugStrengthVolume { get; set; }

        /// <summary>
        /// RXE.34 - Give Drug Strength Volume Units.
        /// </summary>
        public CodedWithExceptions GiveDrugStrengthVolumeUnits { get; set; }

        /// <summary>
        /// RXE.35 - Controlled Substance Schedule.
        /// <para>Suggested: 0477 Controlled Substance Schedule -&gt; ClearHl7.Codes.V282.CodeControlledSubstanceSchedule</para>
        /// </summary>
        public CodedWithExceptions ControlledSubstanceSchedule { get; set; }

        /// <summary>
        /// RXE.36 - Formulary Status.
        /// <para>Suggested: 0478 Formulary Status -&gt; ClearHl7.Codes.V282.CodeFormularyStatus</para>
        /// </summary>
        public string FormularyStatus { get; set; }

        /// <summary>
        /// RXE.37 - Pharmaceutical Substance Alternative.
        /// </summary>
        public IEnumerable<CodedWithExceptions> PharmaceuticalSubstanceAlternative { get; set; }

        /// <summary>
        /// RXE.38 - Pharmacy of Most Recent Fill.
        /// </summary>
        public CodedWithExceptions PharmacyOfMostRecentFill { get; set; }

        /// <summary>
        /// RXE.39 - Initial Dispense Amount.
        /// </summary>
        public decimal? InitialDispenseAmount { get; set; }

        /// <summary>
        /// RXE.40 - Dispensing Pharmacy.
        /// </summary>
        public CodedWithExceptions DispensingPharmacy { get; set; }

        /// <summary>
        /// RXE.41 - Dispensing Pharmacy Address.
        /// </summary>
        public ExtendedAddress DispensingPharmacyAddress { get; set; }

        /// <summary>
        /// RXE.42 - Deliver-to Patient Location.
        /// </summary>
        public PersonLocation DeliverToPatientLocation { get; set; }

        /// <summary>
        /// RXE.43 - Deliver-to Address.
        /// </summary>
        public ExtendedAddress DeliverToAddress { get; set; }

        /// <summary>
        /// RXE.44 - Pharmacy Order Type.
        /// <para>Suggested: 0480 Pharmacy Order Types -&gt; ClearHl7.Codes.V282.CodePharmacyOrderTypes</para>
        /// </summary>
        public string PharmacyOrderType { get; set; }

        /// <summary>
        /// RXE.45 - Pharmacy Phone Number.
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

            QuantityTiming = segments.Length > 1 && segments[1].Length > 0 ? segments[1] : null;
            GiveCode = segments.Length > 2 && segments[2].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[2], false, seps) : null;
            GiveAmountMinimum = segments.Length > 3 && segments[3].Length > 0 ? segments[3].ToNullableDecimal() : null;
            GiveAmountMaximum = segments.Length > 4 && segments[4].Length > 0 ? segments[4].ToNullableDecimal() : null;
            GiveUnits = segments.Length > 5 && segments[5].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[5], false, seps) : null;
            GiveDosageForm = segments.Length > 6 && segments[6].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[6], false, seps) : null;
            ProvidersAdministrationInstructions = segments.Length > 7 && segments[7].Length > 0 ? segments[7].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            DeliverToLocation = segments.Length > 8 && segments[8].Length > 0 ? segments[8] : null;
            SubstitutionStatus = segments.Length > 9 && segments[9].Length > 0 ? segments[9] : null;
            DispenseAmount = segments.Length > 10 && segments[10].Length > 0 ? segments[10].ToNullableDecimal() : null;
            DispenseUnits = segments.Length > 11 && segments[11].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[11], false, seps) : null;
            NumberOfRefills = segments.Length > 12 && segments[12].Length > 0 ? segments[12].ToNullableDecimal() : null;
            OrderingProvidersDeaNumber = segments.Length > 13 && segments[13].Length > 0 ? segments[13].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            PharmacistTreatmentSuppliersVerifierId = segments.Length > 14 && segments[14].Length > 0 ? segments[14].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false, seps)) : null;
            PrescriptionNumber = segments.Length > 15 && segments[15].Length > 0 ? segments[15] : null;
            NumberOfRefillsRemaining = segments.Length > 16 && segments[16].Length > 0 ? segments[16].ToNullableDecimal() : null;
            NumberOfRefillsDosesDispensed = segments.Length > 17 && segments[17].Length > 0 ? segments[17].ToNullableDecimal() : null;
            DateTimeOfMostRecentRefillOrDoseDispensed = segments.Length > 18 && segments[18].Length > 0 ? segments[18].ToNullableDateTime() : null;
            TotalDailyDose = segments.Length > 19 && segments[19].Length > 0 ? TypeSerializer.Deserialize<CompositeQuantityWithUnits>(segments[19], false, seps) : null;
            NeedsHumanReview = segments.Length > 20 && segments[20].Length > 0 ? segments[20] : null;
            SpecialDispensingInstructions = segments.Length > 21 && segments[21].Length > 0 ? segments[21].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            GivePerTimeUnit = segments.Length > 22 && segments[22].Length > 0 ? segments[22] : null;
            GiveRateAmount = segments.Length > 23 && segments[23].Length > 0 ? segments[23] : null;
            GiveRateUnits = segments.Length > 24 && segments[24].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[24], false, seps) : null;
            GiveStrength = segments.Length > 25 && segments[25].Length > 0 ? segments[25].ToNullableDecimal() : null;
            GiveStrengthUnits = segments.Length > 26 && segments[26].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[26], false, seps) : null;
            GiveIndication = segments.Length > 27 && segments[27].Length > 0 ? segments[27].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            DispensePackageSize = segments.Length > 28 && segments[28].Length > 0 ? segments[28].ToNullableDecimal() : null;
            DispensePackageSizeUnit = segments.Length > 29 && segments[29].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[29], false, seps) : null;
            DispensePackageMethod = segments.Length > 30 && segments[30].Length > 0 ? segments[30] : null;
            SupplementaryCode = segments.Length > 31 && segments[31].Length > 0 ? segments[31].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            OriginalOrderDateTime = segments.Length > 32 && segments[32].Length > 0 ? segments[32].ToNullableDateTime() : null;
            GiveDrugStrengthVolume = segments.Length > 33 && segments[33].Length > 0 ? segments[33].ToNullableDecimal() : null;
            GiveDrugStrengthVolumeUnits = segments.Length > 34 && segments[34].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[34], false, seps) : null;
            ControlledSubstanceSchedule = segments.Length > 35 && segments[35].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[35], false, seps) : null;
            FormularyStatus = segments.Length > 36 && segments[36].Length > 0 ? segments[36] : null;
            PharmaceuticalSubstanceAlternative = segments.Length > 37 && segments[37].Length > 0 ? segments[37].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<CodedWithExceptions>(x, false, seps)) : null;
            PharmacyOfMostRecentFill = segments.Length > 38 && segments[38].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[38], false, seps) : null;
            InitialDispenseAmount = segments.Length > 39 && segments[39].Length > 0 ? segments[39].ToNullableDecimal() : null;
            DispensingPharmacy = segments.Length > 40 && segments[40].Length > 0 ? TypeSerializer.Deserialize<CodedWithExceptions>(segments[40], false, seps) : null;
            DispensingPharmacyAddress = segments.Length > 41 && segments[41].Length > 0 ? TypeSerializer.Deserialize<ExtendedAddress>(segments[41], false, seps) : null;
            DeliverToPatientLocation = segments.Length > 42 && segments[42].Length > 0 ? TypeSerializer.Deserialize<PersonLocation>(segments[42], false, seps) : null;
            DeliverToAddress = segments.Length > 43 && segments[43].Length > 0 ? TypeSerializer.Deserialize<ExtendedAddress>(segments[43], false, seps) : null;
            PharmacyOrderType = segments.Length > 44 && segments[44].Length > 0 ? segments[44] : null;
            PharmacyPhoneNumber = segments.Length > 45 && segments[45].Length > 0 ? segments[45].Split(seps.FieldRepeatSeparator, StringSplitOptions.None).Select(x => TypeSerializer.Deserialize<ExtendedTelecommunicationNumber>(x, false, seps)) : null;
        }

        /// <inheritdoc/>
        public string ToDelimitedString()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return string.Format(
                                culture,
                                StringHelper.StringFormatSequence(0, 46, Configuration.FieldSeparator),
                                Id,
                                QuantityTiming,
                                GiveCode?.ToDelimitedString(),
                                GiveAmountMinimum.HasValue ? GiveAmountMinimum.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveAmountMaximum.HasValue ? GiveAmountMaximum.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveUnits?.ToDelimitedString(),
                                GiveDosageForm?.ToDelimitedString(),
                                ProvidersAdministrationInstructions != null ? string.Join(Configuration.FieldRepeatSeparator, ProvidersAdministrationInstructions.Select(x => x.ToDelimitedString())) : null,
                                DeliverToLocation,
                                SubstitutionStatus,
                                DispenseAmount.HasValue ? DispenseAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispenseUnits?.ToDelimitedString(),
                                NumberOfRefills.HasValue ? NumberOfRefills.Value.ToString(Consts.NumericFormat, culture) : null,
                                OrderingProvidersDeaNumber != null ? string.Join(Configuration.FieldRepeatSeparator, OrderingProvidersDeaNumber.Select(x => x.ToDelimitedString())) : null,
                                PharmacistTreatmentSuppliersVerifierId != null ? string.Join(Configuration.FieldRepeatSeparator, PharmacistTreatmentSuppliersVerifierId.Select(x => x.ToDelimitedString())) : null,
                                PrescriptionNumber,
                                NumberOfRefillsRemaining.HasValue ? NumberOfRefillsRemaining.Value.ToString(Consts.NumericFormat, culture) : null,
                                NumberOfRefillsDosesDispensed.HasValue ? NumberOfRefillsDosesDispensed.Value.ToString(Consts.NumericFormat, culture) : null,
                                DateTimeOfMostRecentRefillOrDoseDispensed.ToHl7DateTimeString(typeof(RxeSegment), nameof(DateTimeOfMostRecentRefillOrDoseDispensed), Consts.DateTimeFormatPrecisionSecond, culture),
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
                                SupplementaryCode != null ? string.Join(Configuration.FieldRepeatSeparator, SupplementaryCode.Select(x => x.ToDelimitedString())) : null,
                                OriginalOrderDateTime.ToHl7DateTimeString(typeof(RxeSegment), nameof(OriginalOrderDateTime), Consts.DateTimeFormatPrecisionSecond, culture),
                                GiveDrugStrengthVolume.HasValue ? GiveDrugStrengthVolume.Value.ToString(Consts.NumericFormat, culture) : null,
                                GiveDrugStrengthVolumeUnits?.ToDelimitedString(),
                                ControlledSubstanceSchedule?.ToDelimitedString(),
                                FormularyStatus,
                                PharmaceuticalSubstanceAlternative != null ? string.Join(Configuration.FieldRepeatSeparator, PharmaceuticalSubstanceAlternative.Select(x => x.ToDelimitedString())) : null,
                                PharmacyOfMostRecentFill?.ToDelimitedString(),
                                InitialDispenseAmount.HasValue ? InitialDispenseAmount.Value.ToString(Consts.NumericFormat, culture) : null,
                                DispensingPharmacy?.ToDelimitedString(),
                                DispensingPharmacyAddress?.ToDelimitedString(),
                                DeliverToPatientLocation?.ToDelimitedString(),
                                DeliverToAddress?.ToDelimitedString(),
                                PharmacyOrderType,
                                PharmacyPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, PharmacyPhoneNumber.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}
