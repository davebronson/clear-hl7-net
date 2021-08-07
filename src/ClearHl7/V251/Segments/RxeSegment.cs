using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ClearHl7.Extensions;
using ClearHl7.Helpers;
using ClearHl7.V251.Types;

namespace ClearHl7.V251.Segments
{
    /// <summary>
    /// HL7 Version 2 Segment RXE - Pharmacy Treatment Encoded Order.
    /// </summary>
    public class RxeSegment : ISegment
    {
        /// <summary>
        /// Gets the ID for the Segment.  This property is read-only.
        /// </summary>
        public string Id { get; } = "RXE";
        
        /// <summary>
        /// Gets or sets the rank, or ordinal, which describes the place that this Segment resides in an ordered list of Segments.
        /// </summary>
        public int Ordinal { get; set; }

        /// <summary>
        /// RXE.1 - Quantity/Timing.
        /// </summary>
        public TimingQuantity QuantityTiming { get; set; }

        /// <summary>
        /// RXE.2 - Give Code.
        /// <para>Suggested: 0292 Vaccines Administered -&gt; ClearHl7.Codes.V251.CodeVaccinesAdministered</para>
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
        /// <para>Suggested: 0167 Substitution Status -&gt; ClearHl7.Codes.V251.CodeSubstitutionStatus</para>
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
        /// <para>Suggested: 0136 Yes/No Indicator -&gt; ClearHl7.Codes.V251.CodeYesNoIndicator</para>
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
        /// <para>Suggested: 0321 Dispense Method -&gt; ClearHl7.Codes.V251.CodeDispenseMethod</para>
        /// </summary>
        public string DispensePackageMethod { get; set; }

        /// <summary>
        /// RXE.31 - Supplementary Code.
        /// </summary>
        public IEnumerable<CodedElement> SupplementaryCode { get; set; }

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
        /// <para>Suggested: 0477 Controlled Substance Schedule -&gt; ClearHl7.Codes.V251.CodeControlledSubstanceSchedule</para>
        /// </summary>
        public CodedWithExceptions ControlledSubstanceSchedule { get; set; }

        /// <summary>
        /// RXE.36 - Formulary Status.
        /// <para>Suggested: 0478 Formulary Status -&gt; ClearHl7.Codes.V251.CodeFormularyStatus</para>
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
        /// <para>Suggested: 0480 Pharmacy Order Types -&gt; ClearHl7.Codes.V251.CodePharmacyOrderTypes</para>
        /// </summary>
        public string PharmacyOrderType { get; set; }

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

            QuantityTiming = segments.Length > 1 ? TypeHelper.Deserialize<TimingQuantity>(segments.ElementAtOrDefault(1), false) : null;
            GiveCode = segments.Length > 2 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(2), false) : null;
            GiveAmountMinimum = segments.ElementAtOrDefault(3)?.ToNullableDecimal();
            GiveAmountMaximum = segments.ElementAtOrDefault(4)?.ToNullableDecimal();
            GiveUnits = segments.Length > 5 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(5), false) : null;
            GiveDosageForm = segments.Length > 6 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(6), false) : null;
            ProvidersAdministrationInstructions = segments.Length > 7 ? segments.ElementAtOrDefault(7).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            DeliverToLocation = segments.Length > 8 ? TypeHelper.Deserialize<LocationWithAddressVariationOne>(segments.ElementAtOrDefault(8), false) : null;
            SubstitutionStatus = segments.ElementAtOrDefault(9);
            DispenseAmount = segments.ElementAtOrDefault(10)?.ToNullableDecimal();
            DispenseUnits = segments.Length > 11 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(11), false) : null;
            NumberOfRefills = segments.ElementAtOrDefault(12)?.ToNullableDecimal();
            OrderingProvidersDeaNumber = segments.Length > 13 ? segments.ElementAtOrDefault(13).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            PharmacistTreatmentSuppliersVerifierId = segments.Length > 14 ? segments.ElementAtOrDefault(14).Split(separator).Select(x => TypeHelper.Deserialize<ExtendedCompositeIdNumberAndNameForPersons>(x, false)) : null;
            PrescriptionNumber = segments.ElementAtOrDefault(15);
            NumberOfRefillsRemaining = segments.ElementAtOrDefault(16)?.ToNullableDecimal();
            NumberOfRefillsDosesDispensed = segments.ElementAtOrDefault(17)?.ToNullableDecimal();
            DateTimeOfMostRecentRefillOrDoseDispensed = segments.ElementAtOrDefault(18)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            TotalDailyDose = segments.Length > 19 ? TypeHelper.Deserialize<CompositeQuantityWithUnits>(segments.ElementAtOrDefault(19), false) : null;
            NeedsHumanReview = segments.ElementAtOrDefault(20);
            SpecialDispensingInstructions = segments.Length > 21 ? segments.ElementAtOrDefault(21).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            GivePerTimeUnit = segments.ElementAtOrDefault(22);
            GiveRateAmount = segments.ElementAtOrDefault(23);
            GiveRateUnits = segments.Length > 24 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(24), false) : null;
            GiveStrength = segments.ElementAtOrDefault(25)?.ToNullableDecimal();
            GiveStrengthUnits = segments.Length > 26 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(26), false) : null;
            GiveIndication = segments.Length > 27 ? segments.ElementAtOrDefault(27).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            DispensePackageSize = segments.ElementAtOrDefault(28)?.ToNullableDecimal();
            DispensePackageSizeUnit = segments.Length > 29 ? TypeHelper.Deserialize<CodedElement>(segments.ElementAtOrDefault(29), false) : null;
            DispensePackageMethod = segments.ElementAtOrDefault(30);
            SupplementaryCode = segments.Length > 31 ? segments.ElementAtOrDefault(31).Split(separator).Select(x => TypeHelper.Deserialize<CodedElement>(x, false)) : null;
            OriginalOrderDateTime = segments.ElementAtOrDefault(32)?.ToNullableDateTime(Consts.DateTimeFormatPrecisionSecond);
            GiveDrugStrengthVolume = segments.ElementAtOrDefault(33)?.ToNullableDecimal();
            GiveDrugStrengthVolumeUnits = segments.Length > 34 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(34), false) : null;
            ControlledSubstanceSchedule = segments.Length > 35 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(35), false) : null;
            FormularyStatus = segments.ElementAtOrDefault(36);
            PharmaceuticalSubstanceAlternative = segments.Length > 37 ? segments.ElementAtOrDefault(37).Split(separator).Select(x => TypeHelper.Deserialize<CodedWithExceptions>(x, false)) : null;
            PharmacyOfMostRecentFill = segments.Length > 38 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(38), false) : null;
            InitialDispenseAmount = segments.ElementAtOrDefault(39)?.ToNullableDecimal();
            DispensingPharmacy = segments.Length > 40 ? TypeHelper.Deserialize<CodedWithExceptions>(segments.ElementAtOrDefault(40), false) : null;
            DispensingPharmacyAddress = segments.Length > 41 ? TypeHelper.Deserialize<ExtendedAddress>(segments.ElementAtOrDefault(41), false) : null;
            DeliverToPatientLocation = segments.Length > 42 ? TypeHelper.Deserialize<PersonLocation>(segments.ElementAtOrDefault(42), false) : null;
            DeliverToAddress = segments.Length > 43 ? TypeHelper.Deserialize<ExtendedAddress>(segments.ElementAtOrDefault(43), false) : null;
            PharmacyOrderType = segments.ElementAtOrDefault(44);
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
                                StringHelper.StringFormatSequence(0, 45, Configuration.FieldSeparator),
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
                                DateTimeOfMostRecentRefillOrDoseDispensed.HasValue ? DateTimeOfMostRecentRefillOrDoseDispensed.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
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
                                OriginalOrderDateTime.HasValue ? OriginalOrderDateTime.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
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
                                PharmacyOrderType
                                ).TrimEnd(Configuration.FieldSeparator.ToCharArray());
        }
    }
}