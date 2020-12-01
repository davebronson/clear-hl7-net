using System;
using System.Collections.Generic;
using System.Linq;
using ClearHl7.Fhir.Helpers;
using ClearHl7.Fhir.V270.Types;

namespace ClearHl7.Fhir.V270.Segments
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
        public string QuantityTiming { get; set; }

        /// <summary>
        /// RXE.2 - Give Code.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0292</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0167</remarks>
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
        public DateTime? DTOfMostRecentRefillOrDoseDispensed { get; set; }

        /// <summary>
        /// RXE.19 - Total Daily Dose.
        /// </summary>
        public CompositeQuantityWithUnits TotalDailyDose { get; set; }

        /// <summary>
        /// RXE.20 - Needs Human Review.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0136</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0321</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0477</remarks>
        public CodedWithExceptions ControlledSubstanceSchedule { get; set; }

        /// <summary>
        /// RXE.36 - Formulary Status.
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0478</remarks>
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
        /// </summary>
        /// <remarks>https://www.hl7.org/fhir/v2/0480</remarks>
        public string PharmacyOrderType { get; set; }

        /// <summary>
        /// RXE.45 - Pharmacy Phone Number.
        /// </summary>
        public IEnumerable<ExtendedTelecommunicationNumber> PharmacyPhoneNumber { get; set; }
        
        /// <summary>
        /// Returns a delimited string representation of this instance.
        /// </summary>
        /// <returns>A string.</returns>
        public string ToDelimitedString()
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentCulture;

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
                                DTOfMostRecentRefillOrDoseDispensed.HasValue ? DTOfMostRecentRefillOrDoseDispensed.Value.ToString(Consts.DateTimeFormatPrecisionSecond, culture) : null,
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
                                PharmacyOrderType,
                                PharmacyPhoneNumber != null ? string.Join(Configuration.FieldRepeatSeparator, PharmacyPhoneNumber.Select(x => x.ToDelimitedString())) : null
                                ).TrimEnd(Configuration.FieldSeparator);
        }
    }
}